using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS_Rechnungen
{
    public static class Helper
    {
        public static void ShowAsTable(List<List<string>> rows)
        {
            if (rows == null || rows.Count == 0)
            {
                MessageBox.Show("Keine Daten gefunden.");
                return;
            }

            // Breite der Spalten bestimmen (maximale Länge pro Spalte)
            int colCount = rows[0].Count;
            int[] colWidths = new int[colCount];

            foreach (var row in rows)
            {
                for (int i = 0; i < colCount; i++)
                {
                    int length = row[i]?.Length ?? 0;
                    if (length > colWidths[i])
                        colWidths[i] = length;
                }
            }

            // Tabelle bauen
            var sb = new System.Text.StringBuilder();
            foreach (var row in rows)
            {
                for (int i = 0; i < colCount; i++)
                {
                    sb.Append((row[i] ?? "").PadRight(colWidths[i] + 2));
                }
                sb.AppendLine();
            }

            MessageBox.Show(sb.ToString(), "Daten-Tabelle");
        }

        private static DataTable ToDataTable(List<List<string>> data, List<string>? columnNames = null)
        {
            DataTable dt = new DataTable();

            if (data == null || data.Count == 0)
                return dt;

            int columnCount = data[0].Count;

            // Wenn keine Spaltennamen angegeben wurden, generisch benennen
            if (columnNames == null || columnNames.Count != columnCount)
            {
                for (int i = 0; i < columnCount; i++)
                    dt.Columns.Add("Spalte " + (i + 1));
            }
            else
            {
                foreach (var col in columnNames)
                    dt.Columns.Add(col);
            }

            foreach (var row in data)
                dt.Rows.Add(row.ToArray());

            return dt;
        }

        public static string DataTableOneValueOnly(DataTable dt, int row, int column)
        {
            return dt.Rows[row].ItemArray[column].ToString();
        }

        public static string[]? DataTableWhereAsRow(DataTable dt, string columnName, string search)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row[columnName]?.ToString() == search)
                {
                    return row.ItemArray.Select(x => x?.ToString() ?? "").ToArray();
                }
            }
            return null;
        }


        public static string DataTableWhereSearchColumn(DataTable dt, string search)
        {
            string result = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (search == dt.Rows[i].ItemArray[j].ToString())
                    {
                        result = dt.Rows[i].ItemArray[j].ToString();
                    }
                }
            }
            return result;
        }
    }
}
