namespace Kalendář
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.novaUdal_butt = new System.Windows.Forms.Button();
            this.denbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mesicbox = new System.Windows.Forms.TextBox();
            this.rokbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.nameEvent_box = new System.Windows.Forms.TextBox();
            this.rokEvent_Box = new System.Windows.Forms.TextBox();
            this.denEvent_box = new System.Windows.Forms.TextBox();
            this.mesicEvent_box = new System.Windows.Forms.TextBox();
            this.denleft_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vtydnubox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.casHodiny_lejbl = new System.Windows.Forms.Label();
            this.casMinuty_lejbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // novaUdal_butt
            // 
            this.novaUdal_butt.Location = new System.Drawing.Point(481, 314);
            this.novaUdal_butt.Margin = new System.Windows.Forms.Padding(4);
            this.novaUdal_butt.Name = "novaUdal_butt";
            this.novaUdal_butt.Size = new System.Drawing.Size(129, 28);
            this.novaUdal_butt.TabIndex = 0;
            this.novaUdal_butt.Text = "Nová událost";
            this.novaUdal_butt.UseVisualStyleBackColor = true;
            this.novaUdal_butt.Click += new System.EventHandler(this.novaUdal_butt_Click);
            // 
            // denbox
            // 
            this.denbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.denbox.Location = new System.Drawing.Point(24, 54);
            this.denbox.Margin = new System.Windows.Forms.Padding(4);
            this.denbox.Name = "denbox";
            this.denbox.ReadOnly = true;
            this.denbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.denbox.Size = new System.Drawing.Size(59, 41);
            this.denbox.TabIndex = 2;
            this.denbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("8bitoperator JVE", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dnes je";
            // 
            // mesicbox
            // 
            this.mesicbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mesicbox.Location = new System.Drawing.Point(92, 54);
            this.mesicbox.Margin = new System.Windows.Forms.Padding(4);
            this.mesicbox.Name = "mesicbox";
            this.mesicbox.ReadOnly = true;
            this.mesicbox.Size = new System.Drawing.Size(59, 41);
            this.mesicbox.TabIndex = 4;
            this.mesicbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rokbox
            // 
            this.rokbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rokbox.Location = new System.Drawing.Point(160, 54);
            this.rokbox.Margin = new System.Windows.Forms.Padding(4);
            this.rokbox.Name = "rokbox";
            this.rokbox.ReadOnly = true;
            this.rokbox.Size = new System.Drawing.Size(101, 41);
            this.rokbox.TabIndex = 5;
            this.rokbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("8bitoperator JVE", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 41);
            this.label5.TabIndex = 8;
            this.label5.Text = "se koná ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("8bitoperator JVE", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 41);
            this.label6.TabIndex = 9;
            this.label6.Text = "To je jen za ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 350);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Zpravovat ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameEvent_box
            // 
            this.nameEvent_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameEvent_box.Location = new System.Drawing.Point(24, 277);
            this.nameEvent_box.Margin = new System.Windows.Forms.Padding(4);
            this.nameEvent_box.Name = "nameEvent_box";
            this.nameEvent_box.ReadOnly = true;
            this.nameEvent_box.Size = new System.Drawing.Size(403, 41);
            this.nameEvent_box.TabIndex = 13;
            // 
            // rokEvent_Box
            // 
            this.rokEvent_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rokEvent_Box.Location = new System.Drawing.Point(164, 226);
            this.rokEvent_Box.Margin = new System.Windows.Forms.Padding(4);
            this.rokEvent_Box.Name = "rokEvent_Box";
            this.rokEvent_Box.ReadOnly = true;
            this.rokEvent_Box.Size = new System.Drawing.Size(107, 41);
            this.rokEvent_Box.TabIndex = 12;
            this.rokEvent_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // denEvent_box
            // 
            this.denEvent_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.denEvent_box.Location = new System.Drawing.Point(24, 226);
            this.denEvent_box.Margin = new System.Windows.Forms.Padding(4);
            this.denEvent_box.Name = "denEvent_box";
            this.denEvent_box.ReadOnly = true;
            this.denEvent_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.denEvent_box.Size = new System.Drawing.Size(59, 41);
            this.denEvent_box.TabIndex = 11;
            this.denEvent_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mesicEvent_box
            // 
            this.mesicEvent_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mesicEvent_box.Location = new System.Drawing.Point(96, 226);
            this.mesicEvent_box.Margin = new System.Windows.Forms.Padding(4);
            this.mesicEvent_box.Name = "mesicEvent_box";
            this.mesicEvent_box.ReadOnly = true;
            this.mesicEvent_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mesicEvent_box.Size = new System.Drawing.Size(59, 41);
            this.mesicEvent_box.TabIndex = 14;
            this.mesicEvent_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // denleft_box
            // 
            this.denleft_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.denleft_box.Location = new System.Drawing.Point(252, 329);
            this.denleft_box.Margin = new System.Windows.Forms.Padding(4);
            this.denleft_box.Name = "denleft_box";
            this.denleft_box.ReadOnly = true;
            this.denleft_box.Size = new System.Drawing.Size(91, 41);
            this.denleft_box.TabIndex = 15;
            this.denleft_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("8bitoperator JVE", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(352, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 41);
            this.label7.TabIndex = 16;
            this.label7.Text = "dní!";
            // 
            // vtydnubox
            // 
            this.vtydnubox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vtydnubox.Location = new System.Drawing.Point(24, 105);
            this.vtydnubox.Margin = new System.Windows.Forms.Padding(4);
            this.vtydnubox.Name = "vtydnubox";
            this.vtydnubox.ReadOnly = true;
            this.vtydnubox.Size = new System.Drawing.Size(127, 41);
            this.vtydnubox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("8bitoperator JVE", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(413, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 80);
            this.label1.TabIndex = 20;
            this.label1.Text = ":";
            // 
            // casHodiny_lejbl
            // 
            this.casHodiny_lejbl.Font = new System.Drawing.Font("8bitoperator JVE", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.casHodiny_lejbl.Location = new System.Drawing.Point(316, 58);
            this.casHodiny_lejbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.casHodiny_lejbl.Name = "casHodiny_lejbl";
            this.casHodiny_lejbl.Size = new System.Drawing.Size(112, 79);
            this.casHodiny_lejbl.TabIndex = 21;
            this.casHodiny_lejbl.Text = "0";
            this.casHodiny_lejbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // casMinuty_lejbl
            // 
            this.casMinuty_lejbl.Font = new System.Drawing.Font("8bitoperator JVE", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.casMinuty_lejbl.Location = new System.Drawing.Point(449, 58);
            this.casMinuty_lejbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.casMinuty_lejbl.Name = "casMinuty_lejbl";
            this.casMinuty_lejbl.Size = new System.Drawing.Size(112, 79);
            this.casMinuty_lejbl.TabIndex = 22;
            this.casMinuty_lejbl.Text = "0";
            this.casMinuty_lejbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(627, 393);
            this.Controls.Add(this.casMinuty_lejbl);
            this.Controls.Add(this.casHodiny_lejbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vtydnubox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.denleft_box);
            this.Controls.Add(this.mesicEvent_box);
            this.Controls.Add(this.nameEvent_box);
            this.Controls.Add(this.rokEvent_Box);
            this.Controls.Add(this.denEvent_box);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rokbox);
            this.Controls.Add(this.mesicbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.denbox);
            this.Controls.Add(this.novaUdal_butt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalendář";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button novaUdal_butt;
        private System.Windows.Forms.TextBox denbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mesicbox;
        private System.Windows.Forms.TextBox rokbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nameEvent_box;
        private System.Windows.Forms.TextBox rokEvent_Box;
        private System.Windows.Forms.TextBox denEvent_box;
        private System.Windows.Forms.TextBox mesicEvent_box;
        private System.Windows.Forms.TextBox denleft_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vtydnubox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label casHodiny_lejbl;
        private System.Windows.Forms.Label casMinuty_lejbl;
        private System.Windows.Forms.Timer timer1;
    }
}

