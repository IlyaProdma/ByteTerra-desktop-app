using ByteTerraUtils;

namespace DubnaHackathon
{
    public partial class EditSessionForm : Form
    {
        private GoogleUtils _GoogleUtils;
        private string _SpreadSheetId;

        public EditSessionForm(GoogleUtils googleUtils, string spreadSheetId)
        {
            InitializeComponent();
            _GoogleUtils = googleUtils;
            _SpreadSheetId = spreadSheetId;
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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!CheckFilledOD())
            {
                MessageBox.Show("Заполните поля ОД1-ОД4!");
                return;
            }
            if (!CheckFilledTD())
            {
                MessageBox.Show("Заполните хотя бы одно поле ТД1-ТД9!");
                return;
            }
            if (string.IsNullOrEmpty(sessionIdTextBox.Text))
            {
                MessageBox.Show("Введите номер сеанса!");
                return;
            }
            if (!CheckSessionId())
            {
                MessageBox.Show("Некорректный номер сеанса!");
                return;
            }
            SetSessionInfo();
            Close();
        }

        private void SetSessionInfo()
        {
            List<double> onlineDetectors = new List<double>();
            onlineDetectors.Add(Convert.ToDouble(od1TextBox.Text));
            onlineDetectors.Add(Convert.ToDouble(od2TextBox.Text));
            onlineDetectors.Add(Convert.ToDouble(od3TextBox.Text));
            onlineDetectors.Add(Convert.ToDouble(od4TextBox.Text));
            _GoogleUtils.SetOnlineDetectorsInfo(_SpreadSheetId, Convert.ToInt32(sessionIdTextBox.Text), onlineDetectors);
            List<double> trackDetectors = new List<double>();
            if (!string.IsNullOrEmpty(td1TextBox.Text)) trackDetectors.Add(Convert.ToDouble(td1TextBox.Text));
            if (!string.IsNullOrEmpty(td2TextBox.Text)) trackDetectors.Add(Convert.ToDouble(td2TextBox.Text));
            if (!string.IsNullOrEmpty(td3TextBox.Text)) trackDetectors.Add(Convert.ToDouble(td3TextBox.Text));
            if (!string.IsNullOrEmpty(td4TextBox.Text)) trackDetectors.Add(Convert.ToDouble(td4TextBox.Text));
            if (!string.IsNullOrEmpty(td5TextBox.Text)) trackDetectors.Add(Convert.ToDouble(td5TextBox.Text));
            if (!string.IsNullOrEmpty(td6TextBox.Text)) trackDetectors.Add(Convert.ToDouble(td6TextBox.Text));
            if (!string.IsNullOrEmpty(td7TextBox.Text)) trackDetectors.Add(Convert.ToDouble(td7TextBox.Text));
            if (!string.IsNullOrEmpty(td8TextBox.Text)) trackDetectors.Add(Convert.ToDouble(td8TextBox.Text));
            if (!string.IsNullOrEmpty(td9TextBox.Text)) trackDetectors.Add(Convert.ToDouble(td9TextBox.Text));
            _GoogleUtils.SetTrackDetectorsInfo(_SpreadSheetId, Convert.ToInt32(sessionIdTextBox.Text), trackDetectors);
            SetMeasureResults(onlineDetectors, trackDetectors);
        }

        private bool CheckFilledOD()
        {
            return !(string.IsNullOrEmpty(od1TextBox.Text) || string.IsNullOrEmpty(od2TextBox.Text) ||
                     string.IsNullOrEmpty(od3TextBox.Text) || string.IsNullOrEmpty(od4TextBox.Text));
        }

        private bool CheckFilledTD()
        {
            return !(string.IsNullOrEmpty(td1TextBox.Text) && string.IsNullOrEmpty(td2TextBox.Text) &&
                     string.IsNullOrEmpty(td3TextBox.Text) && string.IsNullOrEmpty(td4TextBox.Text) &&
                     string.IsNullOrEmpty(td5TextBox.Text) && string.IsNullOrEmpty(td6TextBox.Text) &&
                     string.IsNullOrEmpty(td7TextBox.Text) && string.IsNullOrEmpty(td8TextBox.Text) &&
                     string.IsNullOrEmpty(td9TextBox.Text));
        }

        private bool CheckSessionId()
        {
            var vals = _GoogleUtils.GetRowBySessionNumber(_SpreadSheetId, "Data", Convert.ToInt32(sessionIdTextBox.Text));
            return vals.Count > 0;
        }

        private void SetMeasureResults(List<double> ods, List<double> tds)
        {
            var odsAvg = ods.Average();
            List<double> ks = new List<double>(tds.Select(td => td / odsAvg));
            var kAvg = ks.Average();
            var sigma = Math.Sqrt(Math.Pow(ks.Select(ki => ki - kAvg).Sum(), 2) / ks.Count);
            var ip = kAvg * 0.28;
            var ts = new double[3] { 63.6567, 9.9248, 5.8409 };
            var t = ts[tds.Count - 2];
            var error = Math.Sqrt(Math.Pow(sigma*t, 2) + Math.Pow(ip, 2));
            double heterogeneity = (tds.Max() - tds.Min() / tds.Max()) * 100;
            double heterogeneity_left = -1;
            double heterogeneity_right = -1;
            if (tds.Count == 4)
            {
                heterogeneity_left = ((tds.GetRange(0, 2).Max() - tds.GetRange(0, 2).Min())/tds.GetRange(0, 2).Max()) * 100;
                heterogeneity_right = ((tds.GetRange(2, 2).Max() - tds.GetRange(2, 2).Min()) / tds.GetRange(2, 2).Max()) * 100;
            }
            _GoogleUtils.SetMeasureResults(_SpreadSheetId, Convert.ToInt32(sessionIdTextBox.Text), kAvg,
                                           error, heterogeneity, heterogeneity_left, heterogeneity_right);
        }
    }
}
