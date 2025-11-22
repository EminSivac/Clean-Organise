using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CHS_Rechnungen
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LoadUserControl(new UcDashboard());
        }

        private void LoadUserControl(UserControl uc)
        {
            if (panelRight.Controls.Count == 0 ||
                panelRight.Controls[0].GetType() != uc.GetType())
            {
                panelRight.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                panelRight.Controls.Add(uc);
            }
        }


        #region UiEvents
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dbCon = DBConnection.Instance();
            dbCon.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcDashboard());
        }

        private void btnStammdaten_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcStammdaten());
        }

        private void btnEinstellungen_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcEinstellungen());
        }

        private void btnRechnungen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon...", "Comming Soon...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
    }
}
