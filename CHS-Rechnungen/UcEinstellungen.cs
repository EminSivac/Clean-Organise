using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS_Rechnungen
{
    public partial class UcEinstellungen : UserControl
    {
        public UcEinstellungen()
        {
            InitializeComponent();
            InitializeNumbers();
            btnSaveAll.Visible = false;
        }

        private void openTemplate(string filePath)
        {
            if (File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show($"Die Vorlage ist nicht vorhanden. Eine neue wurde angelegt", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                xlsxCreate(filePath);
                System.Diagnostics.Process.Start(new ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
        }

        private void xlsxCreate(string filePath)
        {
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                // Workbook-Part hinzufügen
                WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                // Worksheet-Part hinzufügen
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                // Sheets-Container hinzufügen
                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());

                // Sheet anlegen
                Sheet sheet = new Sheet()
                {
                    Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Vorlage"
                };

                sheets.Append(sheet);

                workbookPart.Workbook.Save();
            }
        }

        private void InitializeNumbers()
        {
            var result = getNumbers();
            var date_formats = getDateFormats();
            setDateFormats(date_formats);

            fillNumbersIfPosible(result, "rechnungs_nummer", 2, TXT_BOX_Prefix_1, 1);
            fillNumbersIfPosible(result, "angebots_nummer", 2, TXT_BOX_Prefix_2, 2);
            fillNumbersIfPosible(result, "vertrags_nummer", 2, TXT_BOX_Prefix_3, 3);
            fillNumbersIfPosible(result, "winterdient_nummer", 2, TXT_BOX_Prefix_4, 4);

            fillNumbersIfPosible(result, "rechnungs_nummer", 3, TXT_BOX_Suffix_1, 1);
            fillNumbersIfPosible(result, "angebots_nummer", 3, TXT_BOX_Suffix_2, 2);
            fillNumbersIfPosible(result, "vertrags_nummer", 3, TXT_BOX_Suffix_3, 3);
            fillNumbersIfPosible(result, "winterdient_nummer", 3, TXT_BOX_Suffix_4, 4);

            CMBO_BOX_NR_1.SelectedIndex = int.Parse(Helper.DataTableOneValueOnly(result, 0, 5));
            CMBO_BOX_NR_2.SelectedIndex = int.Parse(Helper.DataTableOneValueOnly(result, 1, 5));
            CMBO_BOX_NR_3.SelectedIndex = int.Parse(Helper.DataTableOneValueOnly(result, 2, 5));
            CMBO_BOX_NR_4.SelectedIndex = int.Parse(Helper.DataTableOneValueOnly(result, 3, 5));

            CMBO_BOX_DATE_1.SelectedIndex = int.Parse(Helper.DataTableOneValueOnly(result, 0, 4));
            CMBO_BOX_DATE_2.SelectedIndex = int.Parse(Helper.DataTableOneValueOnly(result, 1, 4));
            CMBO_BOX_DATE_3.SelectedIndex = int.Parse(Helper.DataTableOneValueOnly(result, 2, 4));
            CMBO_BOX_DATE_4.SelectedIndex = int.Parse(Helper.DataTableOneValueOnly(result, 3, 4));
        }

        private void setDateFormats(System.Data.DataTable date_formats)
        {
            string[] strings = new string[4];
            for (int i = 0; i < 4; i++)
            {
                strings[i] = Helper.DataTableOneValueOnly(date_formats, i, 1);
            }

            CMBO_BOX_DATE_1.Items.AddRange(strings);
            CMBO_BOX_DATE_2.Items.AddRange(strings);
            CMBO_BOX_DATE_3.Items.AddRange(strings);
            CMBO_BOX_DATE_4.Items.AddRange(strings);
        }

        private System.Data.DataTable getNumbers()
        {
            var result = SqlHandler.Select("SELECT * FROM `nummernkreise`");
            if (result != null)
            {
                return result;
            }
            return null;
        }
        private System.Data.DataTable getDateFormats()
        {
            var result = SqlHandler.Select("SELECT * FROM `datum_format`");
            if (result != null)
            {
                return result;
            }
            return null;
        }

        private void fillNumbersIfPosible(System.Data.DataTable result, string search, int column, TextBox textBox, int nummerkreisId)
        {
            var text = Helper.DataTableWhereAsRow(result, "name", search);

            if (text == null)
            {
                SqlHandler.Post($"REPLACE INTO `nummernkreise` (`nummerkreise_id`, `name`, `prefix`, `suffix`, `datum_format`, `laufende_nummer`) VALUES ('{nummerkreisId}', '{search}', '', '', '1', '1') ");

                text = Helper.DataTableWhereAsRow(getNumbers(), "name", search);
            }

            textBox.Text = text[column];
        }

        #region UI_Events
        private void btnRechnungVorlage_Click(object sender, EventArgs e)
        {
            string filePath = "RechnungVorlage.xlsx";
            openTemplate(filePath);
        }

        private void btnAngebotVorlage_Click(object sender, EventArgs e)
        {
            string filePath = "AngebotVorlage.xlsx";
            openTemplate(filePath);
        }

        private void btnVertragsrechnungVorlage_Click(object sender, EventArgs e)
        {
            string filePath = "VertragsrechnungVorlage.xlsx";
            openTemplate(filePath);
        }

        private void btnWinterdienstVorlage_Click(object sender, EventArgs e)
        {
            string filePath = "WinterdienstVorlage.xlsx";
            openTemplate(filePath);
        }
        #endregion

        private void updateNummerkreise(string nummerkreise_id, string name, string prefix, string suffix, string datum_format, string laufende_nummer)
        {
            SqlHandler.Post($"REPLACE INTO `nummernkreise` (`nummerkreise_id`, `name`, `prefix`, `suffix`, `datum_format`, `laufende_nummer`) VALUES ('{nummerkreise_id}', '{name}', '{prefix}', '{suffix}', {datum_format}, {laufende_nummer}) ");
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            updateNummerkreise("1", "rechnungs_nummer", TXT_BOX_Prefix_1.Text, TXT_BOX_Suffix_1.Text, CMBO_BOX_DATE_1.SelectedIndex.ToString(), CMBO_BOX_NR_1.SelectedIndex.ToString());

            updateNummerkreise("2", "angebots_nummer", TXT_BOX_Prefix_2.Text, TXT_BOX_Suffix_2.Text, CMBO_BOX_DATE_2.SelectedIndex.ToString(), CMBO_BOX_NR_2.SelectedIndex.ToString());

            updateNummerkreise("3", "vertrags_nummer", TXT_BOX_Prefix_3.Text, TXT_BOX_Suffix_3.Text, CMBO_BOX_DATE_3.SelectedIndex.ToString(), CMBO_BOX_NR_3.SelectedIndex.ToString());

            updateNummerkreise("4", "winterdient_nummer", TXT_BOX_Prefix_4.Text, TXT_BOX_Suffix_4.Text, CMBO_BOX_DATE_4.SelectedIndex.ToString(), CMBO_BOX_NR_4.SelectedIndex.ToString());

            btnSaveAll.Visible = false;
        }

        private void showSaveAll(object sender, EventArgs e)
        {
            btnSaveAll.Visible = true;
        }
    }
}
