using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ChgType
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            comboBuySell.Items.AddRange(new object[] { "B", "S" });
            comboChangeType.Items.AddRange(new object[] { "1", "2" });
            comboOrderType.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });

            comboChangeType.SelectedItem = "1";
            comboOrderType.SelectedItem = "5";
            textBrokerCode.Text = "585T";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dataGridViewRecords.Rows.Add(
                textBrokerCode.Text.Trim(),
                textInvestorAccount.Text.Trim(),
                textProxyNumber.Text.Trim(),
                textTransactionNumber.Text.Trim(),
                comboBuySell.Text.Trim(),
                textStockCode.Text.Trim(),
                comboChangeType.Text.Trim(),
                textMarginCode.Text.Trim(),
                numericSplitShares.Value,
                numericSplitAmount.Value,
                comboOrderType.Text.Trim());

            ClearInputControls();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (dataGridViewRecords.Rows.Count == 0)
            {
                MessageBox.Show("目前沒有可匯出的記錄。", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            saveFileDialog.FileName = string.Format("C31_{0:yyyyMMdd}.csv", DateTime.Today);
            if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            var exportRows = new List<string>();
            try
            {
                foreach (DataGridViewRow row in dataGridViewRecords.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        exportRows.Add(FormatExportRow(row));
                    }
                }
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var writer = new StreamWriter(saveFileDialog.FileName, false, new UTF8Encoding(false)))
            {
                foreach (string exportRow in exportRows)
                {
                    writer.WriteLine(exportRow);
                }
            }

            MessageBox.Show("CSV 檔案已匯出。", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string FormatExportRow(DataGridViewRow row)
        {
            var fields = new[]
            {
                FixedText(GetCellValue(row, 0), 4, "證券商代號"),
                FixedText(GetCellValue(row, 1), 7, "投資人帳號"),
                FixedText(GetCellValue(row, 2), 5, "委託書編號"),
                FixedZeroPaddedText(GetCellValue(row, 3), 8, "成交總序號"),
                FixedText(GetCellValue(row, 4), 1, "買賣別"),
                MaxLengthText(GetCellValue(row, 5), 6, "證券代號"),
                FixedText(GetCellValue(row, 6), 1, "異動別"),
                GetCellValue(row, 7),
                FixedNumber(GetCellValue(row, 8), 10, "分割成交股數"),
                FixedNumber(GetCellValue(row, 9), 12, "分割成交金額"),
                FixedText(GetCellValue(row, 10), 1, "變更後委託類別")
            };

            return string.Join(",", fields) + ",";
        }

        private static string GetCellValue(DataGridViewRow row, int columnIndex)
        {
            return row.Cells[columnIndex].Value == null ? string.Empty : row.Cells[columnIndex].Value.ToString().Trim();
        }

        private static string FixedText(string value, int length, string fieldName)
        {
            if (value.Length > length)
            {
                throw new ArgumentException(string.Format("{0} 不可超過 {1} 個字元。", fieldName, length));
            }

            return value.PadRight(length, ' ');
        }

        private static string FixedZeroPaddedText(string value, int length, string fieldName)
        {
            if (value.Length > length)
            {
                throw new ArgumentException(string.Format("{0} 不可超過 {1} 個字元。", fieldName, length));
            }

            return value.PadLeft(length, '0');
        }

        private static string MaxLengthText(string value, int length, string fieldName)
        {
            if (value.Length > length)
            {
                throw new ArgumentException(string.Format("{0} 不可超過 {1} 個字元。", fieldName, length));
            }

            return value;
        }

        private static string FixedNumber(string value, int length, string fieldName)
        {
            decimal number;
            if (!decimal.TryParse(value, out number) || number < 0 || number != decimal.Truncate(number))
            {
                throw new ArgumentException(string.Format("{0} 必須為非負整數。", fieldName));
            }

            var integerValue = decimal.ToInt64(number).ToString();
            if (integerValue.Length > length)
            {
                throw new ArgumentException(string.Format("{0} 不可超過 {1} 位數。", fieldName, length));
            }

            return integerValue.PadLeft(length, '0');
        }

        private void ClearInputControls()
        {
            textTransactionNumber.Clear();
            textTransactionNumber.Focus();
        }
    }
}
