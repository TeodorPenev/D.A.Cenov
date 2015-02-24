namespace HotelRegistration
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
            this.началоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свободнизаетиСтаиЗаПериодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяЗаНаеманеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исторяЗаНаеманетоНаПосетителToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.въвежданеНаПосетителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.началоToolStripMenuItem,
            this.операцииToolStripMenuItem,
            this.справкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // началоToolStripMenuItem
            // 
            this.началоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изходToolStripMenuItem});
            this.началоToolStripMenuItem.Name = "началоToolStripMenuItem";
            this.началоToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.началоToolStripMenuItem.Text = "Начало";
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.изходToolStripMenuItem.Text = "Изход";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.въвежданеНаПосетителиToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свободнизаетиСтаиЗаПериодToolStripMenuItem,
            this.историяЗаНаеманеToolStripMenuItem,
            this.исторяЗаНаеманетоНаПосетителToolStripMenuItem});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.справкиToolStripMenuItem.Text = "Справки";
            // 
            // свободнизаетиСтаиЗаПериодToolStripMenuItem
            // 
            this.свободнизаетиСтаиЗаПериодToolStripMenuItem.Name = "свободнизаетиСтаиЗаПериодToolStripMenuItem";
            this.свободнизаетиСтаиЗаПериодToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.свободнизаетиСтаиЗаПериодToolStripMenuItem.Text = "Свободни/заети стаи за период";
            // 
            // историяЗаНаеманеToolStripMenuItem
            // 
            this.историяЗаНаеманеToolStripMenuItem.Name = "историяЗаНаеманеToolStripMenuItem";
            this.историяЗаНаеманеToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.историяЗаНаеманеToolStripMenuItem.Text = "История за наемане на стая";
            // 
            // исторяЗаНаеманетоНаПосетителToolStripMenuItem
            // 
            this.исторяЗаНаеманетоНаПосетителToolStripMenuItem.Name = "исторяЗаНаеманетоНаПосетителToolStripMenuItem";
            this.исторяЗаНаеманетоНаПосетителToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.исторяЗаНаеманетоНаПосетителToolStripMenuItem.Text = "История за на посетител";
            this.исторяЗаНаеманетоНаПосетителToolStripMenuItem.Click += new System.EventHandler(this.исторяЗаНаеманетоНаПосетителToolStripMenuItem_Click);
            // 
            // въвежданеНаПосетителиToolStripMenuItem
            // 
            this.въвежданеНаПосетителиToolStripMenuItem.Name = "въвежданеНаПосетителиToolStripMenuItem";
            this.въвежданеНаПосетителиToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.въвежданеНаПосетителиToolStripMenuItem.Text = "Работа с посетители";
            this.въвежданеНаПосетителиToolStripMenuItem.Click += new System.EventHandler(this.въвежданеНаПосетителиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 260);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem началоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem въвежданеНаПосетителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свободнизаетиСтаиЗаПериодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяЗаНаеманеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исторяЗаНаеманетоНаПосетителToolStripMenuItem;
    }
}

