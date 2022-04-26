using System.Text.RegularExpressions;
using System.Windows.Forms;
using ByteTerraUtils;

namespace DubnaHackathon
{
    public partial class CreateReportForm : Form
    {
        private string _PathToSave;
        private string _SpreadSheetId;
        private DocumentUtils _DocumentUtils;
        private bool _IsSaving;

        public CreateReportForm(string apiKey, string applicationName, string spreadSheetId)
        {
            InitializeComponent();
            statusLabel.Visible = false;
            _DocumentUtils = new DocumentUtils(apiKey, applicationName);
            _SpreadSheetId = spreadSheetId;
            _PathToSave = Directory.GetCurrentDirectory();
            currentDirSaveLabel.Text = _PathToSave;
            admProtocolRadioButton.Checked = true;
            _IsSaving = false;
        }

        private void sessionIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' &&
                (((sender as TextBox)!.Text.IndexOf('-') > -1) || string.IsNullOrEmpty(((sender as TextBox)!.Text))))
            {
                e.Handled = true;
            }
        }

        private void admProtocolRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (admProtocolRadioButton.Checked)
            {
                monProtocolRadioButton.Checked = false;
            }
        }

        private void monProtocolRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (monProtocolRadioButton.Checked)
            {
                admProtocolRadioButton.Checked = false;
            }
        }

        private void chooseDirSaveButton_Click(object sender, EventArgs e)
        {
            if (!_IsSaving)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        _PathToSave = fbd.SelectedPath;
                    }
                }
                currentDirSaveLabel.Text = _PathToSave;
            }
        }

        private void createReportsButton_Click(object sender, EventArgs e)
        {
            if (!_IsSaving)
            {
                fileSaver.RunWorkerAsync();
            }
        }

        private void CreateReports(int startId, int stopId)
        {
            if (admProtocolRadioButton.Checked)
            {
                for (int sessionId = startId; sessionId <= stopId; ++sessionId)
                {
                    try
                    {
                        _DocumentUtils.CreateAdmissionReport(_SpreadSheetId, sessionId, _PathToSave);
                    }
                    catch (InvalidOperationException ex)
                    {
                        if (ex.Message.ToLower() == "not enough info")
                        {
                            MessageBox.Show($"Недостаточно информации о сеансе {sessionId}");
                        }
                        else if (ex.Message.ToLower() == "no such sessionid")
                        {
                            MessageBox.Show($"Сеанса {sessionId} не существует");
                        }
                    }
                }
            } else if (monProtocolRadioButton.Checked)
            {
                for (int sessionId = startId; sessionId <= stopId; ++sessionId)
                {
                    try
                    {
                        _DocumentUtils.CreateMonitorReport(_SpreadSheetId, sessionId, _PathToSave);
                    }
                    catch (InvalidOperationException ex)
                    {
                        if (ex.Message.ToLower() == "not enough info")
                        {
                            MessageBox.Show($"Недостаточно информации о сеансе {sessionId}");
                        }
                        else if (ex.Message.ToLower() == "no such sessionid")
                        {
                            MessageBox.Show($"Сеанса {sessionId} не существует");
                        }
                    }
                }
            }
        }

        private void fileSaver_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _IsSaving = true;
            if (string.IsNullOrEmpty(sessionIdTextBox.Text))
            {
                MessageBox.Show("Введите номер или номера сессий!");
                return;
            }
            if (string.IsNullOrEmpty(_PathToSave) || string.IsNullOrWhiteSpace(_PathToSave))
            {
                MessageBox.Show("Некорректная папка сохранения!");
                return;
            }
            string pattern1 = "(\\d+)-(\\d+)";
            string pattern2 = "^(\\d+)$";
            Match match1 = Regex.Match(sessionIdTextBox.Text, pattern1);
            Match match2 = Regex.Match(sessionIdTextBox.Text, pattern2);
            if (match1.Success)
            {
                int start = Math.Min(Int32.Parse(match1.Groups[1].Value), Int32.Parse(match1.Groups[2].Value));
                int stop = Math.Max(Int32.Parse(match1.Groups[1].Value), Int32.Parse(match1.Groups[2].Value));
                Invoke(new Action(() => { statusLabel.Visible = true; statusLabel.Text = "Идет сохранение..."; }));
                CreateReports(start, stop);
            }
            else if (match2.Success)
            {
                int sessionId = Int32.Parse(match2.Groups[1].Value);
                Invoke(new Action(() => { statusLabel.Visible = true; statusLabel.Text = "Идет сохранение..."; }));
                CreateReports(sessionId, sessionId);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
                return;
            }
            Invoke(new Action(() => sessionIdTextBox.Text = ""));
        }

        private void fileSaver_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
        }

        private void fileSaver_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Invoke(new Action(() => statusLabel.Text = "Сохранение закончено!"));
            _IsSaving = false;
        }

        private void CreateReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_IsSaving)
            {
                e.Cancel = true;
            }
        }
    }
}
