using ByteTerraUtils;

namespace DubnaHackathon
{
    public partial class AddSessionForm : Form
    {
        private GoogleUtils _GoogleUtils;
        private string _SpreadSheetId;
        private int _NewSessionId;

        public AddSessionForm(GoogleUtils googleUtils, string spreadSheetId)
        {
            InitializeComponent();
            _GoogleUtils = googleUtils;
            _SpreadSheetId = spreadSheetId;
            LoadSessionInfo();
            dateTimeStart.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            dateTimeStart.Value = DateTime.Now;
            dateTimeEnd.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            dateTimeEnd.Value = DateTime.Now;
            dateTimeEnd.MaxDate = DateTime.Now;
            dateTimeDuration.Value = DateTime.Parse("00:00:00");
            sessionNumLabel.Text = $"Информация о сеансе № {_NewSessionId}";
            sessionRadioButton.Checked = true;
        }

        private void LoadSessionInfo()
        {
            var sessionNums = _GoogleUtils.GetValuesFromRange(_SpreadSheetId, "Data!A1:A");
            _NewSessionId = Convert.ToInt32(sessionNums[sessionNums.Count - 1][0]) + 1;
            var codeEnvs = _GoogleUtils.GetValuesFromRange(_SpreadSheetId, "Информация по иону!O1:O");
            codeEnvComboBox.Items.Clear();
            codeEnvComboBox.Items.AddRange(codeEnvs.Select(x => x[0].ToString()).ToArray());
            codeEnvComboBox.Items.RemoveAt(0);
        }

        private void integerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void floatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' &&
                (((sender as TextBox)!.Text.IndexOf('.') > -1) || string.IsNullOrEmpty(((sender as TextBox)!.Text))))
            {
                e.Handled = true;
            }
        }

        private void addSessionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(orgNameTextBox.Text) || string.IsNullOrWhiteSpace(orgNameTextBox.Text) ||
                (string.IsNullOrEmpty(testObj1TextBox.Text) && string.IsNullOrEmpty(testObj2TextBox.Text) &&
                 string.IsNullOrEmpty(testObj3TextBox.Text) && string.IsNullOrEmpty(testObj4TextBox.Text)) ||
                string.IsNullOrEmpty(angleTextBox.Text) || string.IsNullOrEmpty(pressureTextBox.Text) ||
                string.IsNullOrEmpty(humidityTextBox.Text) || string.IsNullOrEmpty(testObjTemperatureTextBox.Text) ||
                string.IsNullOrEmpty(sessionTemperatureTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            SaveSessionInfo();
        }

        private void SaveSessionInfo()
        {
            try
            {
                Session session;
                if (sessionRadioButton.Checked)
                {
                    session = new Session(_NewSessionId, orgNameTextBox.Text,
                                          new string[] { testObj1TextBox.Text, testObj2TextBox.Text,
                                                         testObj3TextBox.Text, testObj4TextBox.Text },
                                          codeEnvComboBox.SelectedItem.ToString()!, GetLastAdmProtocolCode(),
                                          Double.Parse(angleTextBox.Text), Double.Parse(pressureTextBox.Text),
                                          Double.Parse(humidityTextBox.Text), Double.Parse(testObjTemperatureTextBox.Text),
                                          Double.Parse(sessionTemperatureTextBox.Text), dateTimeStart.Value,
                                          dateTimeEnd.Value, dateTimeDuration.Value.TimeOfDay);
                }
                else
                {
                    string orgName = pnChangeRadioButton.Checked ? pnChangeRadioButton.Text : pnRadioButton.Text;
                    session = new Session(_NewSessionId, orgName,
                                          new string[] { testObj1TextBox.Text, testObj2TextBox.Text,
                                                         testObj3TextBox.Text, testObj4TextBox.Text },
                                          codeEnvComboBox.SelectedItem.ToString()!, protocolCodeTextBox.Text,
                                          Double.Parse(angleTextBox.Text), Double.Parse(pressureTextBox.Text),
                                          Double.Parse(humidityTextBox.Text), Double.Parse(testObjTemperatureTextBox.Text),
                                          Double.Parse(sessionTemperatureTextBox.Text), dateTimeStart.Value,
                                          dateTimeEnd.Value, dateTimeDuration.Value.TimeOfDay);
                }
                _GoogleUtils.SetNewSessionInfo(_SpreadSheetId, session);
                MessageBox.Show($"Сеанс {_NewSessionId} успешно добавлен.");
                Close();
            } catch
            {
                MessageBox.Show("Что-то пошло не так :(");
            }
        }

        private string GetLastAdmProtocolCode()
        {
            var values = _GoogleUtils.GetValuesFromRange(_SpreadSheetId, "Data!B1:X");
            for (int i = values.Count - 1; i >= 0; --i)
            {
                if (values[i][0].ToString()!.StartsWith("ПН") && Double.Parse(values[i][21].ToString()!) == 2e+04)
                {
                    return values[i][22].ToString()!;
                }
            }
            return "";
        }

        private void pnChangeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pnChangeRadioButton.Checked)
            {
                orgNameTextBox.Enabled = false;
                protocolCodeTextBox.Enabled = true;
                sessionRadioButton.Checked = false;
                pnRadioButton.Checked = false;
            }
        }

        private void pnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pnRadioButton.Checked)
            {
                orgNameTextBox.Enabled = false;
                protocolCodeTextBox.Enabled = true;
                pnChangeRadioButton.Checked = false;
                sessionRadioButton.Checked = false;
            }
        }

        private void sessionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sessionRadioButton.Checked)
            {
                orgNameTextBox.Enabled = true;
                protocolCodeTextBox.Enabled = false;
                pnChangeRadioButton.Checked = false;
                pnRadioButton.Checked = false;
            }
        }
    }
}
