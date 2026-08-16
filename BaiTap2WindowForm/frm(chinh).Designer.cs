namespace BaiTap2WindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bàiKiểmTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiSố1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiSố1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bàiSố3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiKiểmTraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bàiKiểmTraToolStripMenuItem
            // 
            this.bàiKiểmTraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiSố1ToolStripMenuItem,
            this.bàiSố1ToolStripMenuItem1,
            this.bàiSố3ToolStripMenuItem});
            this.bàiKiểmTraToolStripMenuItem.Name = "bàiKiểmTraToolStripMenuItem";
            this.bàiKiểmTraToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.bàiKiểmTraToolStripMenuItem.Text = "Bài kiểm tra";
            this.bàiKiểmTraToolStripMenuItem.Click += new System.EventHandler(this.bàiKiểmTraToolStripMenuItem_Click);
            // 
            // bàiSố1ToolStripMenuItem
            // 
            this.bàiSố1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bàiSố1ToolStripMenuItem.Image")));
            this.bàiSố1ToolStripMenuItem.Name = "bàiSố1ToolStripMenuItem";
            this.bàiSố1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bàiSố1ToolStripMenuItem.Text = "Bài số 1";
            // 
            // bàiSố1ToolStripMenuItem1
            // 
            this.bàiSố1ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("bàiSố1ToolStripMenuItem1.Image")));
            this.bàiSố1ToolStripMenuItem1.Name = "bàiSố1ToolStripMenuItem1";
            this.bàiSố1ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.bàiSố1ToolStripMenuItem1.Text = "Bài số 2";
            this.bàiSố1ToolStripMenuItem1.Click += new System.EventHandler(this.bàiSố1ToolStripMenuItem1_Click);
            // 
            // bàiSố3ToolStripMenuItem
            // 
            this.bàiSố3ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bàiSố3ToolStripMenuItem.Image")));
            this.bàiSố3ToolStripMenuItem.Name = "bàiSố3ToolStripMenuItem";
            this.bàiSố3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bàiSố3ToolStripMenuItem.Text = "Bài số 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bàiKiểmTraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiSố1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bàiSố1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bàiSố3ToolStripMenuItem;
    }
}

