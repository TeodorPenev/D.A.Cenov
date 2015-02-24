namespace TRZ
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииСФишовеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииСToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаНаЗаплатиПоМесецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаНаЗаплатиПоДаденРаботникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.справкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииСToolStripMenuItem,
            this.операцииСФишовеToolStripMenuItem,
            this.операцииСToolStripMenuItem1});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // операцииСToolStripMenuItem
            // 
            this.операцииСToolStripMenuItem.Name = "операцииСToolStripMenuItem";
            this.операцииСToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.операцииСToolStripMenuItem.Text = "Операции с работници";
            this.операцииСToolStripMenuItem.Click += new System.EventHandler(this.операцииСToolStripMenuItem_Click);
            // 
            // операцииСФишовеToolStripMenuItem
            // 
            this.операцииСФишовеToolStripMenuItem.Name = "операцииСФишовеToolStripMenuItem";
            this.операцииСФишовеToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.операцииСФишовеToolStripMenuItem.Text = "Операции с фишове";
            this.операцииСФишовеToolStripMenuItem.Click += new System.EventHandler(this.операцииСФишовеToolStripMenuItem_Click);
            // 
            // операцииСToolStripMenuItem1
            // 
            this.операцииСToolStripMenuItem1.Name = "операцииСToolStripMenuItem1";
            this.операцииСToolStripMenuItem1.Size = new System.Drawing.Size(245, 22);
            this.операцииСToolStripMenuItem1.Text = "Операции с изплатени заплати";
            this.операцииСToolStripMenuItem1.Click += new System.EventHandler(this.операцииСToolStripMenuItem1_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаНаЗаплатиПоМесецToolStripMenuItem,
            this.справкаНаЗаплатиПоДаденРаботникToolStripMenuItem});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.справкиToolStripMenuItem.Text = "Справки";
            // 
            // справкаНаЗаплатиПоМесецToolStripMenuItem
            // 
            this.справкаНаЗаплатиПоМесецToolStripMenuItem.Name = "справкаНаЗаплатиПоМесецToolStripMenuItem";
            this.справкаНаЗаплатиПоМесецToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.справкаНаЗаплатиПоМесецToolStripMenuItem.Text = "Справка на заплати по месец";
            this.справкаНаЗаплатиПоМесецToolStripMenuItem.Click += new System.EventHandler(this.справкаНаЗаплатиПоМесецToolStripMenuItem_Click);
            // 
            // справкаНаЗаплатиПоДаденРаботникToolStripMenuItem
            // 
            this.справкаНаЗаплатиПоДаденРаботникToolStripMenuItem.Name = "справкаНаЗаплатиПоДаденРаботникToolStripMenuItem";
            this.справкаНаЗаплатиПоДаденРаботникToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.справкаНаЗаплатиПоДаденРаботникToolStripMenuItem.Text = "Справка на заплати по работник";
            this.справкаНаЗаплатиПоДаденРаботникToolStripMenuItem.Click += new System.EventHandler(this.справкаНаЗаплатиПоДаденРаботникToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TRZ.Properties.Resources.TRZ;
            this.ClientSize = new System.Drawing.Size(595, 293);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ТРЗ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииСФишовеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииСToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаНаЗаплатиПоМесецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаНаЗаплатиПоДаденРаботникToolStripMenuItem;
    }
}

