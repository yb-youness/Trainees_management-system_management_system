namespace gestion_stagiaire_colaimo
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new gestion_stagiaire_colaimo.CrystalReport1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zoneStagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneSpecialitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.badgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attestationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 47);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport11;
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1274, 708);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneStagiaireToolStripMenuItem,
            this.zoneServiceToolStripMenuItem,
            this.zoneSpecialitéToolStripMenuItem,
            this.imprimerToolStripMenuItem,
            this.compteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 26);
            this.menuStrip1.TabIndex = 75;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zoneStagiaireToolStripMenuItem
            // 
            this.zoneStagiaireToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoneStagiaireToolStripMenuItem.Image")));
            this.zoneStagiaireToolStripMenuItem.Name = "zoneStagiaireToolStripMenuItem";
            this.zoneStagiaireToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoneStagiaireToolStripMenuItem.Text = "Zone Stagiaire";
            this.zoneStagiaireToolStripMenuItem.Click += new System.EventHandler(this.zoneStagiaireToolStripMenuItem_Click);
            // 
            // zoneServiceToolStripMenuItem
            // 
            this.zoneServiceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoneServiceToolStripMenuItem.Image")));
            this.zoneServiceToolStripMenuItem.Name = "zoneServiceToolStripMenuItem";
            this.zoneServiceToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.zoneServiceToolStripMenuItem.Text = "Zone Service";
            this.zoneServiceToolStripMenuItem.Click += new System.EventHandler(this.zoneServiceToolStripMenuItem_Click);
            // 
            // zoneSpecialitéToolStripMenuItem
            // 
            this.zoneSpecialitéToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoneSpecialitéToolStripMenuItem.Image")));
            this.zoneSpecialitéToolStripMenuItem.Name = "zoneSpecialitéToolStripMenuItem";
            this.zoneSpecialitéToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.zoneSpecialitéToolStripMenuItem.Text = "Zone Specialité";
            this.zoneSpecialitéToolStripMenuItem.Click += new System.EventHandler(this.zoneSpecialitéToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.badgeToolStripMenuItem,
            this.attestationToolStripMenuItem});
            this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            // 
            // badgeToolStripMenuItem
            // 
            this.badgeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("badgeToolStripMenuItem.Image")));
            this.badgeToolStripMenuItem.Name = "badgeToolStripMenuItem";
            this.badgeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.badgeToolStripMenuItem.Text = "Badge";
            this.badgeToolStripMenuItem.Click += new System.EventHandler(this.badgeToolStripMenuItem_Click);
            // 
            // attestationToolStripMenuItem
            // 
            this.attestationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("attestationToolStripMenuItem.Image")));
            this.attestationToolStripMenuItem.Name = "attestationToolStripMenuItem";
            this.attestationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.attestationToolStripMenuItem.Text = "Attestation";
            this.attestationToolStripMenuItem.Click += new System.EventHandler(this.attestationToolStripMenuItem_Click);
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("compteToolStripMenuItem.Image")));
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.compteToolStripMenuItem.Text = "Compte";
            this.compteToolStripMenuItem.Click += new System.EventHandler(this.compteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1276, 750);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport1 CrystalReport11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zoneStagiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneSpecialitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem badgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attestationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}