using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
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
            if (result != null)
            {
                TXT_BOX_Prefix_1.Text = Helper.DataTabelWhereAsRow(result, "rechnungs_nummer")[2];
                TXT_BOX_Prefix_2.Text = Helper.DataTabelWhereAsRow(result, "angebots_nummer")[2];
                //TXT_BOX_Prefix_3.Text = Helper.DataTabelWhereAsRow(result, "vertrags_nummer")[2];
                //TXT_BOX_Prefix_4.Text = Helper.DataTabelWhereAsRow(result, "winterdient_nummer")[2];

                //CMBO_BOX_DATE_1.SelectedIndex = 2;
            }
            else
            {
                //Put Empty into DB
            }
        }

        private DataTable getNumbers()
        {
            var result = SqlHandler.Select("SELECT * FROM `nummernkreise`");
            if(result != null)
            {
                return result;
            }
            return null;
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
    }
}
