namespace Kalendář
{
    partial class UdalostForm
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
            this.potvrdUdal_butt = new System.Windows.Forms.Button();
            this.newDay_combo = new System.Windows.Forms.ComboBox();
            this.newMonth_combo = new System.Windows.Forms.ComboBox();
            this.newYear_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newEvent_box = new System.Windows.Forms.TextBox();
            this.everyYear_check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // zrusitUdal_butt
            // 
            this.zrusitUdal_butt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.zrusitUdal_butt.Location = new System.Drawing.Point(20, 150);
            this.zrusitUdal_butt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zrusitUdal_butt.Name = "zrusitUdal_butt";
            this.zrusitUdal_butt.Size = new System.Drawing.Size(105, 28);
            this.zrusitUdal_butt.TabIndex = 1;
            this.zrusitUdal_butt.Text = "Zrušit";
            this.zrusitUdal_butt.UseVisualStyleBackColor = true;
            this.zrusitUdal_butt.Click += new System.EventHandler(this.zrusitUdal_butt_Click);
            // 
            // potvrdUdal_butt
            // 
            this.potvrdUdal_butt.Location = new System.Drawing.Point(253, 150);
            this.potvrdUdal_butt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.potvrdUdal_butt.Name = "potvrdUdal_butt";
            this.potvrdUdal_butt.Size = new System.Drawing.Size(105, 28);
            this.potvrdUdal_butt.TabIndex = 2;
            this.potvrdUdal_butt.Text = "Vytvořit";
            this.potvrdUdal_butt.UseVisualStyleBackColor = true;
            this.potvrdUdal_butt.Click += new System.EventHandler(this.potvrdUdal_butt_Click);
            // 
            // newDay_combo
            // 
            this.newDay_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newDay_combo.FormattingEnabled = true;
            this.newDay_combo.IntegralHeight = false;
            this.newDay_combo.Items.AddRange(new object[] {
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
            this.newDay_combo.Location = new System.Drawing.Point(127, 15);
            this.newDay_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newDay_combo.Name = "newDay_combo";
            this.newDay_combo.Size = new System.Drawing.Size(52, 24);
            this.newDay_combo.TabIndex = 3;
            // 
            // newMonth_combo
            // 
            this.newMonth_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newMonth_combo.FormattingEnabled = true;
            this.newMonth_combo.IntegralHeight = false;
            this.newMonth_combo.Items.AddRange(new object[] {
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
            this.newMonth_combo.Location = new System.Drawing.Point(192, 15);
            this.newMonth_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newMonth_combo.Name = "newMonth_combo";
            this.newMonth_combo.Size = new System.Drawing.Size(52, 24);
            this.newMonth_combo.TabIndex = 4;
            // 
            // newYear_combo
            // 
            this.newYear_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newYear_combo.FormattingEnabled = true;
            this.newYear_combo.Location = new System.Drawing.Point(253, 15);
            this.newYear_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newYear_combo.Name = "newYear_combo";
            this.newYear_combo.Size = new System.Drawing.Size(96, 24);
            this.newYear_combo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datum události";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Typ události";
            // 
            // newEvent_box
            // 
            this.newEvent_box.Location = new System.Drawing.Point(127, 48);
            this.newEvent_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newEvent_box.Name = "newEvent_box";
            this.newEvent_box.Size = new System.Drawing.Size(223, 22);
            this.newEvent_box.TabIndex = 8;
            // 
            // everyYear_check
            // 
            this.everyYear_check.AutoSize = true;
            this.everyYear_check.Location = new System.Drawing.Point(20, 122);
            this.everyYear_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.everyYear_check.Name = "everyYear_check";
            this.everyYear_check.Size = new System.Drawing.Size(164, 21);
            this.everyYear_check.TabIndex = 9;
            this.everyYear_check.Text = "Opakovat každý rok?";
            this.everyYear_check.UseVisualStyleBackColor = true;
            // 
            // UdalostForm
            // 
            this.AcceptButton = this.potvrdUdal_butt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.zrusitUdal_butt;
            this.ClientSize = new System.Drawing.Size(375, 193);
            this.ControlBox = false;
            this.Controls.Add(this.everyYear_check);
            this.Controls.Add(this.newEvent_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newYear_combo);
            this.Controls.Add(this.newMonth_combo);
            this.Controls.Add(this.newDay_combo);
            this.Controls.Add(this.potvrdUdal_butt);
            this.Controls.Add(this.zrusitUdal_butt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(393, 240);
            this.Name = "UdalostForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nová událost";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UdalostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zrusitUdal_butt;
        private System.Windows.Forms.Button potvrdUdal_butt;
        private System.Windows.Forms.ComboBox newMonth_combo;
        private System.Windows.Forms.ComboBox newYear_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newEvent_box;
        private System.Windows.Forms.CheckBox everyYear_check;
        private System.Windows.Forms.ComboBox newDay_combo;
    }
}