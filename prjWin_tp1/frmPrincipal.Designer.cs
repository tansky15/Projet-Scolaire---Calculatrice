
namespace prjWin_tp1
{
    partial class frmPrincipal
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuProgrammes = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.versionScientifiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bureauChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionLocaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterProgrammeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAffichage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelDutilisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolStandard = new System.Windows.Forms.ToolStripButton();
            this.toolScientific = new System.Windows.Forms.ToolStripButton();
            this.toolBureauEx = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProgrammes,
            this.mnuAffichage,
            this.mnuAide});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuProgrammes
            // 
            this.mnuProgrammes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatriceToolStripMenuItem,
            this.bureauChangeToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterProgrammeToolStripMenuItem});
            this.mnuProgrammes.Name = "mnuProgrammes";
            this.mnuProgrammes.Size = new System.Drawing.Size(107, 24);
            this.mnuProgrammes.Text = "Programmes";
            // 
            // calculatriceToolStripMenuItem
            // 
            this.calculatriceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmStandard,
            this.versionScientifiqueToolStripMenuItem});
            this.calculatriceToolStripMenuItem.Image = global::prjWin_tp1.Properties.Resources._54079;
            this.calculatriceToolStripMenuItem.Name = "calculatriceToolStripMenuItem";
            this.calculatriceToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.calculatriceToolStripMenuItem.Text = "Calculatrices";
            // 
            // frmStandard
            // 
            this.frmStandard.Name = "frmStandard";
            this.frmStandard.Size = new System.Drawing.Size(222, 26);
            this.frmStandard.Text = "Version Standard";
            this.frmStandard.Click += new System.EventHandler(this.versionStandardToolStripMenuItem_Click);
            // 
            // versionScientifiqueToolStripMenuItem
            // 
            this.versionScientifiqueToolStripMenuItem.Name = "versionScientifiqueToolStripMenuItem";
            this.versionScientifiqueToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.versionScientifiqueToolStripMenuItem.Text = "Version Scientifique";
            this.versionScientifiqueToolStripMenuItem.Click += new System.EventHandler(this.versionScientifiqueToolStripMenuItem_Click);
            // 
            // bureauChangeToolStripMenuItem
            // 
            this.bureauChangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionLocaleToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.bureauChangeToolStripMenuItem.Image = global::prjWin_tp1.Properties.Resources._54079;
            this.bureauChangeToolStripMenuItem.Name = "bureauChangeToolStripMenuItem";
            this.bureauChangeToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.bureauChangeToolStripMenuItem.Text = "Bureaux Change";
            // 
            // versionLocaleToolStripMenuItem
            // 
            this.versionLocaleToolStripMenuItem.Enabled = false;
            this.versionLocaleToolStripMenuItem.Name = "versionLocaleToolStripMenuItem";
            this.versionLocaleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.versionLocaleToolStripMenuItem.Text = "Version Locale";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Enabled = false;
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.versionToolStripMenuItem.Text = "Version En Ligne";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(272, 6);
            // 
            // quitterProgrammeToolStripMenuItem
            // 
            this.quitterProgrammeToolStripMenuItem.Name = "quitterProgrammeToolStripMenuItem";
            this.quitterProgrammeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.quitterProgrammeToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.quitterProgrammeToolStripMenuItem.Text = "Quitter Programme";
            this.quitterProgrammeToolStripMenuItem.Click += new System.EventHandler(this.quitterProgrammeToolStripMenuItem_Click);
            // 
            // mnuAffichage
            // 
            this.mnuAffichage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolbar,
            this.mnuStatusBar});
            this.mnuAffichage.Name = "mnuAffichage";
            this.mnuAffichage.Size = new System.Drawing.Size(87, 24);
            this.mnuAffichage.Text = "Affichage";
            // 
            // mnuToolbar
            // 
            this.mnuToolbar.Checked = true;
            this.mnuToolbar.CheckOnClick = true;
            this.mnuToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuToolbar.Name = "mnuToolbar";
            this.mnuToolbar.Size = new System.Drawing.Size(224, 26);
            this.mnuToolbar.Text = "Toolbar";
            this.mnuToolbar.CheckedChanged += new System.EventHandler(this.mnuToolbar_CheckedChanged);
            this.mnuToolbar.Click += new System.EventHandler(this.toolbarsToolStripMenuItem_Click);
            // 
            // mnuStatusBar
            // 
            this.mnuStatusBar.Checked = true;
            this.mnuStatusBar.CheckOnClick = true;
            this.mnuStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuStatusBar.Name = "mnuStatusBar";
            this.mnuStatusBar.Size = new System.Drawing.Size(224, 26);
            this.mnuStatusBar.Text = "Status Bar";
            this.mnuStatusBar.Click += new System.EventHandler(this.mnuStatusBar_Click);
            // 
            // mnuAide
            // 
            this.mnuAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuelDutilisationToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.mnuAide.Name = "mnuAide";
            this.mnuAide.Size = new System.Drawing.Size(54, 24);
            this.mnuAide.Text = "Aide";
            // 
            // manuelDutilisationToolStripMenuItem
            // 
            this.manuelDutilisationToolStripMenuItem.Name = "manuelDutilisationToolStripMenuItem";
            this.manuelDutilisationToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.manuelDutilisationToolStripMenuItem.Text = "Manuel d\'utilisation";
            this.manuelDutilisationToolStripMenuItem.Click += new System.EventHandler(this.manuelDutilisationToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // toolBar
            // 
            this.toolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStandard,
            this.toolScientific,
            this.toolBureauEx,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.toolStripButton1});
            this.toolBar.Location = new System.Drawing.Point(0, 28);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1482, 31);
            this.toolBar.TabIndex = 3;
            this.toolBar.Text = "toolStrip1";
            this.toolBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStandard
            // 
            this.toolStandard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStandard.Image = global::prjWin_tp1.Properties.Resources.calculatrice_icone_png;
            this.toolStandard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStandard.Name = "toolStandard";
            this.toolStandard.Size = new System.Drawing.Size(29, 28);
            this.toolStandard.Text = "toolStripButton1";
            this.toolStandard.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolScientific
            // 
            this.toolScientific.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolScientific.Image = global::prjWin_tp1.Properties.Resources.fx991es_2;
            this.toolScientific.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolScientific.Name = "toolScientific";
            this.toolScientific.Size = new System.Drawing.Size(29, 28);
            this.toolScientific.Text = "toolStripButton1";
            this.toolScientific.Click += new System.EventHandler(this.toolScientific_Click);
            // 
            // toolBureauEx
            // 
            this.toolBureauEx.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBureauEx.Image = global::prjWin_tp1.Properties.Resources.unnamed__1_;
            this.toolBureauEx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBureauEx.Name = "toolBureauEx";
            this.toolBureauEx.Size = new System.Drawing.Size(29, 28);
            this.toolBureauEx.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::prjWin_tp1.Properties.Resources.free_coin_exchange_icon_2427_thumb;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 827);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1482, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatus
            // 
            this.toolStatus.Name = "toolStatus";
            this.toolStatus.Size = new System.Drawing.Size(49, 20);
            this.toolStatus.Text = "Status";
            this.toolStatus.Click += new System.EventHandler(this.toolStripStatusLabel1_Click_1);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjWin_tp1.Properties.Resources.img12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimumSize = new System.Drawing.Size(1500, 900);
            this.Name = "frmPrincipal";
            this.Text = "College Institut Teccart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuProgrammes;
        private System.Windows.Forms.ToolStripMenuItem mnuAffichage;
        private System.Windows.Forms.ToolStripMenuItem mnuAide;
        private System.Windows.Forms.ToolStripMenuItem calculatriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmStandard;
        private System.Windows.Forms.ToolStripMenuItem versionScientifiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bureauChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterProgrammeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuToolbar;
        private System.Windows.Forms.ToolStripMenuItem mnuStatusBar;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton toolStandard;
        private System.Windows.Forms.ToolStripButton toolScientific;
        private System.Windows.Forms.ToolStripButton toolBureauEx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatus;
        private System.Windows.Forms.ToolStripMenuItem manuelDutilisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionLocaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}