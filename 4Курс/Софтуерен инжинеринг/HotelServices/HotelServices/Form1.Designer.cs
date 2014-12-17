namespace HotelServices
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
            this.работаСКлиентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стаиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резервацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаПоДатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаПоСтаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаПоИмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСКлиентиToolStripMenuItem,
            this.стаиToolStripMenuItem,
            this.резервацииToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // работаСКлиентиToolStripMenuItem
            // 
            this.работаСКлиентиToolStripMenuItem.Name = "работаСКлиентиToolStripMenuItem";
            this.работаСКлиентиToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.работаСКлиентиToolStripMenuItem.Text = "Клиенти";
            this.работаСКлиентиToolStripMenuItem.Click += new System.EventHandler(this.работаСКлиентиToolStripMenuItem_Click);
            // 
            // стаиToolStripMenuItem
            // 
            this.стаиToolStripMenuItem.Name = "стаиToolStripMenuItem";
            this.стаиToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.стаиToolStripMenuItem.Text = "Стаи";
            this.стаиToolStripMenuItem.Click += new System.EventHandler(this.стаиToolStripMenuItem_Click);
            // 
            // резервацииToolStripMenuItem
            // 
            this.резервацииToolStripMenuItem.Name = "резервацииToolStripMenuItem";
            this.резервацииToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.резервацииToolStripMenuItem.Text = "Резервации";
            this.резервацииToolStripMenuItem.Click += new System.EventHandler(this.резервацииToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаПоДатаToolStripMenuItem,
            this.справкаПоСтаяToolStripMenuItem,
            this.справкаПоИмеToolStripMenuItem});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.справкиToolStripMenuItem.Text = "Справки";
            // 
            // справкаПоДатаToolStripMenuItem
            // 
            this.справкаПоДатаToolStripMenuItem.Name = "справкаПоДатаToolStripMenuItem";
            this.справкаПоДатаToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.справкаПоДатаToolStripMenuItem.Text = "Справка по дата";
            this.справкаПоДатаToolStripMenuItem.Click += new System.EventHandler(this.справкаПоДатаToolStripMenuItem_Click);
            // 
            // справкаПоСтаяToolStripMenuItem
            // 
            this.справкаПоСтаяToolStripMenuItem.Name = "справкаПоСтаяToolStripMenuItem";
            this.справкаПоСтаяToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.справкаПоСтаяToolStripMenuItem.Text = "Справка по стая";
            this.справкаПоСтаяToolStripMenuItem.Click += new System.EventHandler(this.справкаПоСтаяToolStripMenuItem_Click);
            // 
            // справкаПоИмеToolStripMenuItem
            // 
            this.справкаПоИмеToolStripMenuItem.Name = "справкаПоИмеToolStripMenuItem";
            this.справкаПоИмеToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.справкаПоИмеToolStripMenuItem.Text = "Справка по име";
            this.справкаПоИмеToolStripMenuItem.Click += new System.EventHandler(this.справкаПоИмеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelServices.Properties.Resources.lacleamy_hotel_services_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 432);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hotel Servises";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСКлиентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стаиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резервацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаПоДатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаПоСтаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаПоИмеToolStripMenuItem;
    }
}

