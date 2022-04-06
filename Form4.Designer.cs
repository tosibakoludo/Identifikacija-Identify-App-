
namespace Identifikacija__Identify_App_
{
    partial class Form4
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
            this.akcijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaberiFotografijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sačuvajKaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akcijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // akcijaToolStripMenuItem
            // 
            this.akcijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaberiFotografijuToolStripMenuItem,
            this.sačuvajKaoToolStripMenuItem});
            this.akcijaToolStripMenuItem.Name = "akcijaToolStripMenuItem";
            this.akcijaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.akcijaToolStripMenuItem.Text = "Akcija";
            // 
            // odaberiFotografijuToolStripMenuItem
            // 
            this.odaberiFotografijuToolStripMenuItem.Name = "odaberiFotografijuToolStripMenuItem";
            this.odaberiFotografijuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.odaberiFotografijuToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.odaberiFotografijuToolStripMenuItem.Text = "Odaberi fotografiju ...";
            this.odaberiFotografijuToolStripMenuItem.Click += new System.EventHandler(this.odaberiFotografijuToolStripMenuItem_Click);
            // 
            // sačuvajKaoToolStripMenuItem
            // 
            this.sačuvajKaoToolStripMenuItem.Name = "sačuvajKaoToolStripMenuItem";
            this.sačuvajKaoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sačuvajKaoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.sačuvajKaoToolStripMenuItem.Text = "Sačuvaj kao ...";
            this.sačuvajKaoToolStripMenuItem.Click += new System.EventHandler(this.sačuvajKaoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "\"NN COMPANY\" KARTICA";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem akcijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaberiFotografijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sačuvajKaoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}