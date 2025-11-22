namespace CHS_Rechnungen
{
    partial class UcEinstellungen
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
            label1 = new Label();
            TXT_BOX_Prefix_1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TXT_BOX_Suffix_1 = new TextBox();
            CMBO_BOX_DATE_1 = new ComboBox();
            CMBO_BOX_NR_1 = new ComboBox();
            label5 = new Label();
            CMBO_BOX_NR_2 = new ComboBox();
            label6 = new Label();
            CMBO_BOX_DATE_2 = new ComboBox();
            label7 = new Label();
            TXT_BOX_Suffix_2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            TXT_BOX_Prefix_2 = new TextBox();
            label10 = new Label();
            CMBO_BOX_NR_3 = new ComboBox();
            label11 = new Label();
            CMBO_BOX_DATE_3 = new ComboBox();
            label12 = new Label();
            TXT_BOX_Suffix_3 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            TXT_BOX_Prefix_3 = new TextBox();
            label15 = new Label();
            CMBO_BOX_NR_4 = new ComboBox();
            label16 = new Label();
            CMBO_BOX_DATE_4 = new ComboBox();
            label17 = new Label();
            TXT_BOX_Suffix_4 = new TextBox();
            label18 = new Label();
            label19 = new Label();
            TXT_BOX_Prefix_4 = new TextBox();
            label20 = new Label();
            label21 = new Label();
            btnRechnungVorlage = new Button();
            btnAngebotVorlage = new Button();
            btnVertragsrechnungVorlage = new Button();
            btnWinterdienstVorlage = new Button();
            label22 = new Label();
            btnSaveAll = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(11, 121);
            label1.Name = "label1";
            label1.Size = new Size(217, 31);
            label1.TabIndex = 0;
            label1.Text = "Rechnungsnummer:";
            // 
            // TXT_BOX_Prefix_1
            // 
            TXT_BOX_Prefix_1.Location = new Point(426, 140);
            TXT_BOX_Prefix_1.Margin = new Padding(3, 4, 3, 4);
            TXT_BOX_Prefix_1.Name = "TXT_BOX_Prefix_1";
            TXT_BOX_Prefix_1.Size = new Size(114, 27);
            TXT_BOX_Prefix_1.TabIndex = 1;
            TXT_BOX_Prefix_1.TextChanged += showSaveAll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(426, 121);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Prefix";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 121);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Datum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(838, 121);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "Suffix";
            // 
            // TXT_BOX_Suffix_1
            // 
            TXT_BOX_Suffix_1.Location = new Point(838, 140);
            TXT_BOX_Suffix_1.Margin = new Padding(3, 4, 3, 4);
            TXT_BOX_Suffix_1.Name = "TXT_BOX_Suffix_1";
            TXT_BOX_Suffix_1.Size = new Size(114, 27);
            TXT_BOX_Suffix_1.TabIndex = 5;
            TXT_BOX_Suffix_1.TextChanged += showSaveAll;
            // 
            // CMBO_BOX_DATE_1
            // 
            CMBO_BOX_DATE_1.DisplayMember = "value";
            CMBO_BOX_DATE_1.FormattingEnabled = true;
            CMBO_BOX_DATE_1.Location = new Point(547, 140);
            CMBO_BOX_DATE_1.Margin = new Padding(3, 4, 3, 4);
            CMBO_BOX_DATE_1.Name = "CMBO_BOX_DATE_1";
            CMBO_BOX_DATE_1.Size = new Size(138, 28);
            CMBO_BOX_DATE_1.TabIndex = 7;
            CMBO_BOX_DATE_1.ValueMember = "datum_format_id";
            CMBO_BOX_DATE_1.SelectedIndexChanged += showSaveAll;
            // 
            // CMBO_BOX_NR_1
            // 
            CMBO_BOX_NR_1.FormattingEnabled = true;
            CMBO_BOX_NR_1.Items.AddRange(new object[] { "3-stellig", "4-stellig", "5-stellig", "6-stellig" });
            CMBO_BOX_NR_1.Location = new Point(693, 141);
            CMBO_BOX_NR_1.Margin = new Padding(3, 4, 3, 4);
            CMBO_BOX_NR_1.Name = "CMBO_BOX_NR_1";
            CMBO_BOX_NR_1.Size = new Size(138, 28);
            CMBO_BOX_NR_1.TabIndex = 9;
            CMBO_BOX_NR_1.SelectedIndexChanged += showSaveAll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(693, 123);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 8;
            label5.Text = "Laufende Nummer";
            // 
            // CMBO_BOX_NR_2
            // 
            CMBO_BOX_NR_2.FormattingEnabled = true;
            CMBO_BOX_NR_2.Items.AddRange(new object[] { "3-stellig", "4-stellig", "5-stellig", "6-stellig" });
            CMBO_BOX_NR_2.Location = new Point(693, 235);
            CMBO_BOX_NR_2.Margin = new Padding(3, 4, 3, 4);
            CMBO_BOX_NR_2.Name = "CMBO_BOX_NR_2";
            CMBO_BOX_NR_2.Size = new Size(138, 28);
            CMBO_BOX_NR_2.TabIndex = 18;
            CMBO_BOX_NR_2.SelectedIndexChanged += showSaveAll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(693, 216);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 17;
            label6.Text = "Laufende Nummer";
            // 
            // CMBO_BOX_DATE_2
            // 
            CMBO_BOX_DATE_2.DisplayMember = "value";
            CMBO_BOX_DATE_2.FormattingEnabled = true;
            CMBO_BOX_DATE_2.Location = new Point(547, 233);
            CMBO_BOX_DATE_2.Margin = new Padding(3, 4, 3, 4);
            CMBO_BOX_DATE_2.Name = "CMBO_BOX_DATE_2";
            CMBO_BOX_DATE_2.Size = new Size(138, 28);
            CMBO_BOX_DATE_2.TabIndex = 16;
            CMBO_BOX_DATE_2.ValueMember = "datum_format_id";
            CMBO_BOX_DATE_2.SelectedIndexChanged += showSaveAll;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(838, 215);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 15;
            label7.Text = "Suffix";
            // 
            // TXT_BOX_Suffix_2
            // 
            TXT_BOX_Suffix_2.Location = new Point(838, 233);
            TXT_BOX_Suffix_2.Margin = new Padding(3, 4, 3, 4);
            TXT_BOX_Suffix_2.Name = "TXT_BOX_Suffix_2";
            TXT_BOX_Suffix_2.Size = new Size(114, 27);
            TXT_BOX_Suffix_2.TabIndex = 14;
            TXT_BOX_Suffix_2.TextChanged += showSaveAll;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(547, 215);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 13;
            label8.Text = "Datum";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(426, 215);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 12;
            label9.Text = "Prefix";
            // 
            // TXT_BOX_Prefix_2
            // 
            TXT_BOX_Prefix_2.Location = new Point(426, 233);
            TXT_BOX_Prefix_2.Margin = new Padding(3, 4, 3, 4);
            TXT_BOX_Prefix_2.Name = "TXT_BOX_Prefix_2";
            TXT_BOX_Prefix_2.Size = new Size(114, 27);
            TXT_BOX_Prefix_2.TabIndex = 11;
            TXT_BOX_Prefix_2.TextChanged += showSaveAll;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F);
            label10.Location = new Point(11, 215);
            label10.Name = "label10";
            label10.Size = new Size(204, 31);
            label10.TabIndex = 10;
            label10.Text = "Angebotsnummer:";
            // 
            // CMBO_BOX_NR_3
            // 
            CMBO_BOX_NR_3.FormattingEnabled = true;
            CMBO_BOX_NR_3.Items.AddRange(new object[] { "3-stellig", "4-stellig", "5-stellig", "6-stellig" });
            CMBO_BOX_NR_3.Location = new Point(693, 328);
            CMBO_BOX_NR_3.Margin = new Padding(3, 4, 3, 4);
            CMBO_BOX_NR_3.Name = "CMBO_BOX_NR_3";
            CMBO_BOX_NR_3.Size = new Size(138, 28);
            CMBO_BOX_NR_3.TabIndex = 27;
            CMBO_BOX_NR_3.SelectedIndexChanged += showSaveAll;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(693, 309);
            label11.Name = "label11";
            label11.Size = new Size(132, 20);
            label11.TabIndex = 26;
            label11.Text = "Laufende Nummer";
            // 
            // CMBO_BOX_DATE_3
            // 
            CMBO_BOX_DATE_3.DisplayMember = "value";
            CMBO_BOX_DATE_3.FormattingEnabled = true;
            CMBO_BOX_DATE_3.Location = new Point(547, 327);
            CMBO_BOX_DATE_3.Margin = new Padding(3, 4, 3, 4);
            CMBO_BOX_DATE_3.Name = "CMBO_BOX_DATE_3";
            CMBO_BOX_DATE_3.Size = new Size(138, 28);
            CMBO_BOX_DATE_3.TabIndex = 25;
            CMBO_BOX_DATE_3.ValueMember = "datum_format_id";
            CMBO_BOX_DATE_3.SelectedIndexChanged += showSaveAll;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(838, 308);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 24;
            label12.Text = "Suffix";
            // 
            // TXT_BOX_Suffix_3
            // 
            TXT_BOX_Suffix_3.Location = new Point(838, 327);
            TXT_BOX_Suffix_3.Margin = new Padding(3, 4, 3, 4);
            TXT_BOX_Suffix_3.Name = "TXT_BOX_Suffix_3";
            TXT_BOX_Suffix_3.Size = new Size(114, 27);
            TXT_BOX_Suffix_3.TabIndex = 23;
            TXT_BOX_Suffix_3.TextChanged += showSaveAll;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(547, 308);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 22;
            label13.Text = "Datum";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(426, 308);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 21;
            label14.Text = "Prefix";
            // 
            // TXT_BOX_Prefix_3
            // 
            TXT_BOX_Prefix_3.Location = new Point(426, 327);
            TXT_BOX_Prefix_3.Margin = new Padding(3, 4, 3, 4);
            TXT_BOX_Prefix_3.Name = "TXT_BOX_Prefix_3";
            TXT_BOX_Prefix_3.Size = new Size(114, 27);
            TXT_BOX_Prefix_3.TabIndex = 20;
            TXT_BOX_Prefix_3.TextChanged += showSaveAll;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F);
            label15.Location = new Point(11, 308);
            label15.Name = "label15";
            label15.Size = new Size(287, 31);
            label15.TabIndex = 19;
            label15.Text = "Vertragsrechnungnummer:";
            // 
            // CMBO_BOX_NR_4
            // 
            CMBO_BOX_NR_4.FormattingEnabled = true;
            CMBO_BOX_NR_4.Items.AddRange(new object[] { "3-stellig", "4-stellig", "5-stellig", "6-stellig" });
            CMBO_BOX_NR_4.Location = new Point(693, 421);
            CMBO_BOX_NR_4.Margin = new Padding(3, 4, 3, 4);
            CMBO_BOX_NR_4.Name = "CMBO_BOX_NR_4";
            CMBO_BOX_NR_4.Size = new Size(138, 28);
            CMBO_BOX_NR_4.TabIndex = 36;
            CMBO_BOX_NR_4.SelectedIndexChanged += showSaveAll;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(693, 403);
            label16.Name = "label16";
            label16.Size = new Size(132, 20);
            label16.TabIndex = 35;
            label16.Text = "Laufende Nummer";
            // 
            // CMBO_BOX_DATE_4
            // 
            CMBO_BOX_DATE_4.DisplayMember = "value";
            CMBO_BOX_DATE_4.FormattingEnabled = true;
            CMBO_BOX_DATE_4.Location = new Point(547, 420);
            CMBO_BOX_DATE_4.Margin = new Padding(3, 4, 3, 4);
            CMBO_BOX_DATE_4.Name = "CMBO_BOX_DATE_4";
            CMBO_BOX_DATE_4.Size = new Size(138, 28);
            CMBO_BOX_DATE_4.TabIndex = 34;
            CMBO_BOX_DATE_4.ValueMember = "datum_format_id";
            CMBO_BOX_DATE_4.SelectedIndexChanged += showSaveAll;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(838, 401);
            label17.Name = "label17";
            label17.Size = new Size(46, 20);
            label17.TabIndex = 33;
            label17.Text = "Suffix";
            // 
            // TXT_BOX_Suffix_4
            // 
            TXT_BOX_Suffix_4.Location = new Point(838, 420);
            TXT_BOX_Suffix_4.Margin = new Padding(3, 4, 3, 4);
            TXT_BOX_Suffix_4.Name = "TXT_BOX_Suffix_4";
            TXT_BOX_Suffix_4.Size = new Size(114, 27);
            TXT_BOX_Suffix_4.TabIndex = 32;
            TXT_BOX_Suffix_4.TextChanged += showSaveAll;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(547, 401);
            label18.Name = "label18";
            label18.Size = new Size(54, 20);
            label18.TabIndex = 31;
            label18.Text = "Datum";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(426, 401);
            label19.Name = "label19";
            label19.Size = new Size(46, 20);
            label19.TabIndex = 30;
            label19.Text = "Prefix";
            // 
            // TXT_BOX_Prefix_4
            // 
            TXT_BOX_Prefix_4.Location = new Point(426, 420);
            TXT_BOX_Prefix_4.Margin = new Padding(3, 4, 3, 4);
            TXT_BOX_Prefix_4.Name = "TXT_BOX_Prefix_4";
            TXT_BOX_Prefix_4.Size = new Size(114, 27);
            TXT_BOX_Prefix_4.TabIndex = 29;
            TXT_BOX_Prefix_4.TextChanged += showSaveAll;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 13.8F);
            label20.Location = new Point(11, 401);
            label20.Name = "label20";
            label20.Size = new Size(242, 31);
            label20.TabIndex = 28;
            label20.Text = "Winderdienstnummer:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(11, 488);
            label21.Name = "label21";
            label21.Size = new Size(136, 41);
            label21.TabIndex = 37;
            label21.Text = "Vorlagen";
            // 
            // btnRechnungVorlage
            // 
            btnRechnungVorlage.Location = new Point(11, 600);
            btnRechnungVorlage.Margin = new Padding(3, 4, 3, 4);
            btnRechnungVorlage.Name = "btnRechnungVorlage";
            btnRechnungVorlage.Size = new Size(171, 100);
            btnRechnungVorlage.TabIndex = 38;
            btnRechnungVorlage.Text = "Rechnung";
            btnRechnungVorlage.UseVisualStyleBackColor = true;
            btnRechnungVorlage.Click += btnRechnungVorlage_Click;
            // 
            // btnAngebotVorlage
            // 
            btnAngebotVorlage.Location = new Point(229, 600);
            btnAngebotVorlage.Margin = new Padding(3, 4, 3, 4);
            btnAngebotVorlage.Name = "btnAngebotVorlage";
            btnAngebotVorlage.Size = new Size(171, 100);
            btnAngebotVorlage.TabIndex = 39;
            btnAngebotVorlage.Text = "Angebot";
            btnAngebotVorlage.UseVisualStyleBackColor = true;
            btnAngebotVorlage.Click += btnAngebotVorlage_Click;
            // 
            // btnVertragsrechnungVorlage
            // 
            btnVertragsrechnungVorlage.Location = new Point(457, 600);
            btnVertragsrechnungVorlage.Margin = new Padding(3, 4, 3, 4);
            btnVertragsrechnungVorlage.Name = "btnVertragsrechnungVorlage";
            btnVertragsrechnungVorlage.Size = new Size(171, 100);
            btnVertragsrechnungVorlage.TabIndex = 40;
            btnVertragsrechnungVorlage.Text = "Vertragsrechnung";
            btnVertragsrechnungVorlage.UseVisualStyleBackColor = true;
            btnVertragsrechnungVorlage.Click += btnVertragsrechnungVorlage_Click;
            // 
            // btnWinterdienstVorlage
            // 
            btnWinterdienstVorlage.Location = new Point(686, 600);
            btnWinterdienstVorlage.Margin = new Padding(3, 4, 3, 4);
            btnWinterdienstVorlage.Name = "btnWinterdienstVorlage";
            btnWinterdienstVorlage.Size = new Size(171, 100);
            btnWinterdienstVorlage.TabIndex = 41;
            btnWinterdienstVorlage.Text = "Winterdienst";
            btnWinterdienstVorlage.UseVisualStyleBackColor = true;
            btnWinterdienstVorlage.Click += btnWinterdienstVorlage_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(11, 17);
            label22.Name = "label22";
            label22.Size = new Size(229, 41);
            label22.TabIndex = 42;
            label22.Text = "Nummernkreise";
            // 
            // btnSaveAll
            // 
            btnSaveAll.Location = new Point(775, 21);
            btnSaveAll.Margin = new Padding(3, 4, 3, 4);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new Size(177, 47);
            btnSaveAll.TabIndex = 43;
            btnSaveAll.Text = "Alles Speichern";
            btnSaveAll.UseVisualStyleBackColor = true;
            btnSaveAll.Visible = false;
            btnSaveAll.Click += btnSaveAll_Click;
            // 
            // UcEinstellungen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSaveAll);
            Controls.Add(label22);
            Controls.Add(btnWinterdienstVorlage);
            Controls.Add(btnVertragsrechnungVorlage);
            Controls.Add(btnAngebotVorlage);
            Controls.Add(btnRechnungVorlage);
            Controls.Add(label21);
            Controls.Add(CMBO_BOX_NR_4);
            Controls.Add(label16);
            Controls.Add(CMBO_BOX_DATE_4);
            Controls.Add(label17);
            Controls.Add(TXT_BOX_Suffix_4);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(TXT_BOX_Prefix_4);
            Controls.Add(label20);
            Controls.Add(CMBO_BOX_NR_3);
            Controls.Add(label11);
            Controls.Add(CMBO_BOX_DATE_3);
            Controls.Add(label12);
            Controls.Add(TXT_BOX_Suffix_3);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(TXT_BOX_Prefix_3);
            Controls.Add(label15);
            Controls.Add(CMBO_BOX_NR_2);
            Controls.Add(label6);
            Controls.Add(CMBO_BOX_DATE_2);
            Controls.Add(label7);
            Controls.Add(TXT_BOX_Suffix_2);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(TXT_BOX_Prefix_2);
            Controls.Add(label10);
            Controls.Add(CMBO_BOX_NR_1);
            Controls.Add(label5);
            Controls.Add(CMBO_BOX_DATE_1);
            Controls.Add(label4);
            Controls.Add(TXT_BOX_Suffix_1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TXT_BOX_Prefix_1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcEinstellungen";
            Size = new Size(1097, 907);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TXT_BOX_Prefix_1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TXT_BOX_Suffix_1;
        private ComboBox CMBO_BOX_DATE_1;
        private ComboBox CMBO_BOX_NR_1;
        private Label label5;
        private ComboBox CMBO_BOX_NR_2;
        private Label label6;
        private ComboBox CMBO_BOX_DATE_2;
        private Label label7;
        private TextBox TXT_BOX_Suffix_2;
        private Label label8;
        private Label label9;
        private TextBox TXT_BOX_Prefix_2;
        private Label label10;
        private ComboBox CMBO_BOX_NR_3;
        private Label label11;
        private ComboBox CMBO_BOX_DATE_3;
        private Label label12;
        private TextBox TXT_BOX_Suffix_3;
        private Label label13;
        private Label label14;
        private TextBox TXT_BOX_Prefix_3;
        private Label label15;
        private ComboBox CMBO_BOX_NR_4;
        private Label label16;
        private ComboBox CMBO_BOX_DATE_4;
        private Label label17;
        private TextBox TXT_BOX_Suffix_4;
        private Label label18;
        private Label label19;
        private TextBox TXT_BOX_Prefix_4;
        private Label label20;
        private Label label21;
        private Button btnRechnungVorlage;
        private Button btnAngebotVorlage;
        private Button btnVertragsrechnungVorlage;
        private Button btnWinterdienstVorlage;
        private Label label22;
        private Button btnSaveAll;
    }
}
