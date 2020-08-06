namespace GameTTNT
{
    partial class GAME
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GAME));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.bar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.btnPvsC = new DevComponents.DotNetBar.ButtonX();
            this.btnPvsP = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chếĐộChơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiVsMáyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiVsNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiếnTiếpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.buttonX4);
            this.groupBox1.Controls.Add(this.buttonX3);
            this.groupBox1.Controls.Add(this.bar);
            this.groupBox1.Controls.Add(this.btnPvsC);
            this.groupBox1.Controls.Add(this.btnPvsP);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(629, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 604);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(18, 325);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 31);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(145, 542);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(110, 41);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.Symbol = "";
            this.buttonX4.TabIndex = 7;
            this.buttonX4.Text = "Thoát";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(6, 542);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(110, 41);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.TabIndex = 6;
            this.buttonX3.Text = "Chơi mới";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.bar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bar.ChunkColor = System.Drawing.Color.Red;
            this.bar.Location = new System.Drawing.Point(58, 325);
            this.bar.Name = "bar";
            this.bar.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee;
            this.bar.Size = new System.Drawing.Size(194, 32);
            this.bar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.bar.TabIndex = 5;
            this.bar.Text = "progressBarX1";
            // 
            // btnPvsC
            // 
            this.btnPvsC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPvsC.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPvsC.Location = new System.Drawing.Point(52, 456);
            this.btnPvsC.Name = "btnPvsC";
            this.btnPvsC.Size = new System.Drawing.Size(167, 48);
            this.btnPvsC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPvsC.Symbol = "";
            this.btnPvsC.TabIndex = 2;
            this.btnPvsC.Text = "Đánh với Máy";
            this.btnPvsC.TextColor = System.Drawing.Color.Red;
            this.btnPvsC.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btnPvsP
            // 
            this.btnPvsP.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPvsP.BackColor = System.Drawing.Color.Red;
            this.btnPvsP.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPvsP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPvsP.Location = new System.Drawing.Point(52, 392);
            this.btnPvsP.Name = "btnPvsP";
            this.btnPvsP.Size = new System.Drawing.Size(167, 48);
            this.btnPvsP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPvsP.Symbol = "";
            this.btnPvsP.TabIndex = 1;
            this.btnPvsP.Text = "Đánh với Người";
            this.btnPvsP.TextColor = System.Drawing.Color.Red;
            this.btnPvsP.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GameTTNT.Properties.Resources.game1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chếĐộChơiToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // chếĐộChơiToolStripMenuItem
            // 
            this.chếĐộChơiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiVsMáyToolStripMenuItem,
            this.ngườiVsNgườiToolStripMenuItem});
            this.chếĐộChơiToolStripMenuItem.Name = "chếĐộChơiToolStripMenuItem";
            this.chếĐộChơiToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.chếĐộChơiToolStripMenuItem.Text = "&Game mới";
            // 
            // ngườiVsMáyToolStripMenuItem
            // 
            this.ngườiVsMáyToolStripMenuItem.Name = "ngườiVsMáyToolStripMenuItem";
            this.ngườiVsMáyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.ngườiVsMáyToolStripMenuItem.Text = "Người vs Máy";
            this.ngườiVsMáyToolStripMenuItem.Click += new System.EventHandler(this.ngườiVsMáyToolStripMenuItem_Click);
            // 
            // ngườiVsNgườiToolStripMenuItem
            // 
            this.ngườiVsNgườiToolStripMenuItem.Name = "ngườiVsNgườiToolStripMenuItem";
            this.ngườiVsNgườiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.ngườiVsNgườiToolStripMenuItem.Text = "Người vs Người";
            this.ngườiVsNgườiToolStripMenuItem.Click += new System.EventHandler(this.ngườiVsNgườiToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayLạiToolStripMenuItem,
            this.tiếnTiếpToolStripMenuItem});
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thoátToolStripMenuItem.Text = "&Tùy chọn";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.quayLạiToolStripMenuItem.Text = "&Quay lại";
            this.quayLạiToolStripMenuItem.Click += new System.EventHandler(this.quayLạiToolStripMenuItem_Click);
            // 
            // tiếnTiếpToolStripMenuItem
            // 
            this.tiếnTiếpToolStripMenuItem.Name = "tiếnTiếpToolStripMenuItem";
            this.tiếnTiếpToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.tiếnTiếpToolStripMenuItem.Text = "&Tiến tiếp";
            this.tiếnTiếpToolStripMenuItem.Click += new System.EventHandler(this.tiếnTiếpToolStripMenuItem_Click);
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.BackColor = System.Drawing.Color.Teal;
            this.pnlBanCo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBanCo.Location = new System.Drawing.Point(12, 31);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(601, 601);
            this.pnlBanCo.TabIndex = 2;
            this.pnlBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanCo_Paint);
            this.pnlBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBanCo_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 649);
            this.Controls.Add(this.pnlBanCo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GAME";
            this.Text = "GAME CARO";
            this.Load += new System.EventHandler(this.GAME_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnPvsC;
        private DevComponents.DotNetBar.ButtonX btnPvsP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.ToolStripMenuItem chếĐộChơiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiVsMáyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiVsNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiếnTiếpToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        public DevComponents.DotNetBar.Controls.ProgressBarX bar;
    }
}

