using ByteTerraUtils;

namespace DubnaHackathon
{
    public partial class MainForm : Form
    {
        private GoogleUtils _GoogleUtils;
        private string _SpreadSheetId = "1WEvoZXh8u4zmdTqoVwKjBVQ_k5ktEJgS2jTnfG_F2jk"; // my table
        private string _ServiceAccountEmail = "documentsbot@documentsbot.iam.gserviceaccount.com";
        private string _ApplicationName = "DocumentsBot";
        private string _CredentialsFile = "servicecreds.json";
        private string _DataRange = "Data!A1:AH";
        private string _TimingRange = "Timing!A1:R";
        private string _IonRange = "Информация по иону!A1:O";
        private string _CurrentRange;
        private string apiKey = "AIzaSyBlzETUEJQJn4lSzTELzSLdKhtW0WCWvDk"; // google api key

        public MainForm()
        {
            InitializeComponent();
            _GoogleUtils = new GoogleUtils(_ServiceAccountEmail, _CredentialsFile, _ApplicationName);
            _CurrentRange = _DataRange;
            dataSheetRadioButton.Checked = true;
        }

        private void FillTable()
        {
            var sheetValues = _GoogleUtils.GetValuesFromRange(_SpreadSheetId, _CurrentRange);
            googleGridView.Columns.Clear();
            googleGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            for (int i = 0; i < sheetValues[0].Count; ++i)
            {
                googleGridView.Columns.Add(new DataGridViewTextBoxColumn());
                googleGridView.Columns[i].Name = sheetValues[0][i].ToString();
            }
            for (int i = 1; i < sheetValues.Count; ++i)
            {
                while (sheetValues[i].Count < 34) {
                    sheetValues[i].Add("");
                }
                googleGridView.Rows.Add(sheetValues[i].Cast<string>().ToArray());
            }
            googleGridView.Update();
        }

        private void dataSheetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dataSheetRadioButton.Checked)
            {
                timingSheetRadioButton.Checked = false;
                ionSheetRadioButton.Checked = false;
                _CurrentRange = _DataRange;
                FillTable();
            }
        }

        private void timingSheetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (timingSheetRadioButton.Checked)
            {
                dataSheetRadioButton.Checked = false;
                ionSheetRadioButton.Checked = false;
                _CurrentRange = _TimingRange;
                FillTable();
            }
        }

        private void ionSheetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ionSheetRadioButton.Checked)
            {
                dataSheetRadioButton.Checked = false;
                timingSheetRadioButton.Checked = false;
                _CurrentRange = _IonRange;
                FillTable();
            }
        }

        private void refreshTableButton_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            CreateReportForm reportForm = new CreateReportForm(apiKey, _ApplicationName, _SpreadSheetId);
            reportForm.ShowDialog();
        }

        private void createSessionButton_Click(object sender, EventArgs e)
        {
            AddSessionForm newSessionForm = new AddSessionForm(_GoogleUtils, _SpreadSheetId);
            newSessionForm.ShowDialog();
            FillTable();
        }

        private void editSessionButton_Click(object sender, EventArgs e)
        {
            EditSessionForm editSessionForm = new EditSessionForm(_GoogleUtils, _SpreadSheetId);
            editSessionForm.ShowDialog();
            FillTable();
        }
    }
}