namespace CHS_Rechnungen
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelRight = new Panel();
            btnDashboard = new Button();
            btnStammdaten = new Button();
            btnEinstellungen = new Button();
            btnRechnungen = new Button();
            SuspendLayout();
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Location = new Point(207, 12);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(960, 680);
            panelRight.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(12, 12);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(177, 77);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnStammdaten
            // 
            btnStammdaten.Location = new Point(12, 95);
            btnStammdaten.Name = "btnStammdaten";
            btnStammdaten.Size = new Size(177, 77);
            btnStammdaten.TabIndex = 2;
            btnStammdaten.Text = "Stammdaten";
            btnStammdaten.UseVisualStyleBackColor = true;
            btnStammdaten.Click += btnStammdaten_Click;
            // 
            // btnEinstellungen
            // 
            btnEinstellungen.Location = new Point(12, 178);
            btnEinstellungen.Name = "btnEinstellungen";
            btnEinstellungen.Size = new Size(177, 77);
            btnEinstellungen.TabIndex = 3;
            btnEinstellungen.Text = "Einstellungen";
            btnEinstellungen.UseVisualStyleBackColor = true;
            btnEinstellungen.Click += btnEinstellungen_Click;
            // 
            // btnRechnungen
            // 
            btnRechnungen.Location = new Point(12, 261);
            btnRechnungen.Name = "btnRechnungen";
            btnRechnungen.Size = new Size(177, 77);
            btnRechnungen.TabIndex = 4;
            btnRechnungen.Text = "Rechnungen";
            btnRechnungen.UseVisualStyleBackColor = true;
            btnRechnungen.Click += btnRechnungen_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1184, 710);
            Controls.Add(btnRechnungen);
            Controls.Add(btnEinstellungen);
            Controls.Add(btnStammdaten);
            Controls.Add(btnDashboard);
            Controls.Add(panelRight);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHS-Rechnungen";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRight;
        private Button btnDashboard;
        private Button btnStammdaten;
        private Button btnEinstellungen;
        private Button btnRechnungen;
    }
}
