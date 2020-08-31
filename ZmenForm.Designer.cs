namespace Kalendář
{
    partial class ZmenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.zrusitUdal_butt = new System.Windows.Forms.Button();
            this.vybrat_butt = new System.Windows.Forms.Button();
            this.typudalosti_combo = new System.Windows.Forms.ComboBox();
            this.den_combo = new System.Windows.Forms.ComboBox();
            this.mesic_combo = new System.Windows.Forms.ComboBox();
            this.rok_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opakujese_check = new System.Windows.Forms.CheckBox();
            this.vymaz_butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zrusitUdal_butt
            // 
            this.zrusitUdal_butt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.zrusitUdal_butt.Location = new System.Drawing.Point(13, 123);
            this.zrusitUdal_butt.Margin = new System.Windows.Forms.Padding(4);
            this.zrusitUdal_butt.Name = "zrusitUdal_butt";
            this.zrusitUdal_butt.Size = new System.Drawing.Size(105, 28);
            this.zrusitUdal_butt.TabIndex = 2;
            this.zrusitUdal_butt.Text = "Zrušit";
            this.zrusitUdal_butt.UseVisualStyleBackColor = true;
            this.zrusitUdal_butt.Click += new System.EventHandler(this.zrusitUdal_butt_Click);
            // 
            // vybrat_butt
            // 
            this.vybrat_butt.Location = new System.Drawing.Point(240, 123);
            this.vybrat_butt.Margin = new System.Windows.Forms.Padding(4);
            this.vybrat_butt.Name = "vybrat_butt";
            this.vybrat_butt.Size = new System.Drawing.Size(105, 28);
            this.vybrat_butt.TabIndex = 3;
            this.vybrat_butt.Text = "Změnit";
            this.vybrat_butt.UseVisualStyleBackColor = true;
            this.vybrat_butt.Click += new System.EventHandler(this.vybrat_butt_Click);
            // 
            // typudalosti_combo
            // 
            this.typudalosti_combo.FormattingEnabled = true;
            this.typudalosti_combo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.typudalosti_combo.Location = new System.Drawing.Point(128, 12);
            this.typudalosti_combo.Name = "typudalosti_combo";
            this.typudalosti_combo.Size = new System.Drawing.Size(217, 24);
            this.typudalosti_combo.TabIndex = 4;
            this.typudalosti_combo.SelectedIndexChanged += new System.EventHandler(this.typudalosti_combo_SelectedIndexChanged);
            // 
            // den_combo
            // 
            this.den_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.den_combo.FormattingEnabled = true;
            this.den_combo.IntegralHeight = false;
            this.den_combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.den_combo.Location = new System.Drawing.Point(128, 41);
            this.den_combo.Margin = new System.Windows.Forms.Padding(4);
            this.den_combo.Name = "den_combo";
            this.den_combo.Size = new System.Drawing.Size(52, 24);
            this.den_combo.TabIndex = 7;
            // 
            // mesic_combo
            // 
            this.mesic_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesic_combo.FormattingEnabled = true;
            this.mesic_combo.IntegralHeight = false;
            this.mesic_combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.mesic_combo.Location = new System.Drawing.Point(188, 41);
            this.mesic_combo.Margin = new System.Windows.Forms.Padding(4);
            this.mesic_combo.Name = "mesic_combo";
            this.mesic_combo.Size = new System.Drawing.Size(52, 24);
            this.mesic_combo.TabIndex = 8;
            // 
            // rok_combo
            // 
            this.rok_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rok_combo.FormattingEnabled = true;
            this.rok_combo.Location = new System.Drawing.Point(249, 41);
            this.rok_combo.Margin = new System.Windows.Forms.Padding(4);
            this.rok_combo.Name = "rok_combo";
            this.rok_combo.Size = new System.Drawing.Size(96, 24);
            this.rok_combo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Událost / název";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Datum";
            // 
            // opakujese_check
            // 
            this.opakujese_check.AutoSize = true;
            this.opakujese_check.Location = new System.Drawing.Point(131, 78);
            this.opakujese_check.Name = "opakujese_check";
            this.opakujese_check.Size = new System.Drawing.Size(110, 21);
            this.opakujese_check.TabIndex = 14;
            this.opakujese_check.Text = "Opakuje se?";
            this.opakujese_check.UseVisualStyleBackColor = true;
            // 
            // vymaz_butt
            // 
            this.vymaz_butt.Location = new System.Drawing.Point(248, 73);
            this.vymaz_butt.Margin = new System.Windows.Forms.Padding(4);
            this.vymaz_butt.Name = "vymaz_butt";
            this.vymaz_butt.Size = new System.Drawing.Size(96, 28);
            this.vymaz_butt.TabIndex = 15;
            this.vymaz_butt.Text = "Vymazat";
            this.vymaz_butt.UseVisualStyleBackColor = true;
            this.vymaz_butt.Click += new System.EventHandler(this.vymaz_butt_Click);
            // 
            // ZmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.zrusitUdal_butt;
            this.ClientSize = new System.Drawing.Size(357, 164);
            this.ControlBox = false;
            this.Controls.Add(this.vymaz_butt);
            this.Controls.Add(this.opakujese_check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rok_combo);
            this.Controls.Add(this.mesic_combo);
            this.Controls.Add(this.den_combo);
            this.Controls.Add(this.typudalosti_combo);
            this.Controls.Add(this.vybrat_butt);
            this.Controls.Add(this.zrusitUdal_butt);
            this.Name = "ZmenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Změnit událost";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ZmenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zrusitUdal_butt;
        private System.Windows.Forms.Button vybrat_butt;
        private System.Windows.Forms.ComboBox typudalosti_combo;
        private System.Windows.Forms.ComboBox den_combo;
        private System.Windows.Forms.ComboBox mesic_combo;
        private System.Windows.Forms.ComboBox rok_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox opakujese_check;
        private System.Windows.Forms.Button vymaz_butt;
    }
}