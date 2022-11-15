﻿
namespace Do_an_Winform
{
    partial class frm_Thukho
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Thukho));
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sidemenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.functionPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.subuserPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInfo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.userBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.headerPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.slideBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.mainPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.titlePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidemenu.SuspendLayout();
            this.functionPanel.SuspendLayout();
            this.subuserPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideBtn)).BeginInit();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // Transition
            // 
            this.Transition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition.DefaultAnimation = animation1;
            // 
            // sidemenu
            // 
            this.sidemenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidemenu.BackgroundImage")));
            this.sidemenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidemenu.Controls.Add(this.functionPanel);
            this.sidemenu.Controls.Add(this.subuserPanel);
            this.sidemenu.Controls.Add(this.userPanel);
            this.sidemenu.Controls.Add(this.headerPanel);
            this.Transition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.sidemenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.sidemenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.sidemenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.sidemenu.Location = new System.Drawing.Point(0, 38);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Quality = 10;
            this.sidemenu.Size = new System.Drawing.Size(250, 567);
            this.sidemenu.TabIndex = 3;
            // 
            // functionPanel
            // 
            this.functionPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("functionPanel.BackgroundImage")));
            this.functionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.functionPanel.Controls.Add(this.btnStock);
            this.functionPanel.Controls.Add(this.btnNhap);
            this.Transition.SetDecoration(this.functionPanel, BunifuAnimatorNS.DecorationType.None);
            this.functionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.functionPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.functionPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.functionPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.functionPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.functionPanel.Location = new System.Drawing.Point(0, 236);
            this.functionPanel.Name = "functionPanel";
            this.functionPanel.Quality = 10;
            this.functionPanel.Size = new System.Drawing.Size(250, 116);
            this.functionPanel.TabIndex = 12;
            // 
            // btnStock
            // 
            this.btnStock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStock.BorderRadius = 0;
            this.btnStock.ButtonText = "Tồn kho";
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnStock, BunifuAnimatorNS.DecorationType.None);
            this.btnStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnStock.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStock.Iconimage = global::Do_an_Winform.Properties.Resources.warehouse;
            this.btnStock.Iconimage_right = null;
            this.btnStock.Iconimage_right_Selected = null;
            this.btnStock.Iconimage_Selected = null;
            this.btnStock.IconMarginLeft = 12;
            this.btnStock.IconMarginRight = 0;
            this.btnStock.IconRightVisible = false;
            this.btnStock.IconRightZoom = 0D;
            this.btnStock.IconVisible = true;
            this.btnStock.IconZoom = 60D;
            this.btnStock.IsTab = false;
            this.btnStock.Location = new System.Drawing.Point(0, 6);
            this.btnStock.Name = "btnStock";
            this.btnStock.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStock.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStock.selected = false;
            this.btnStock.Size = new System.Drawing.Size(250, 48);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "Tồn kho";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStock.Textcolor = System.Drawing.Color.Transparent;
            this.btnStock.TextFont = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhap.BorderRadius = 0;
            this.btnNhap.ButtonText = "Nhập hàng";
            this.btnNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnNhap, BunifuAnimatorNS.DecorationType.None);
            this.btnNhap.DisabledColor = System.Drawing.Color.Gray;
            this.btnNhap.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNhap.Iconimage = global::Do_an_Winform.Properties.Resources.import;
            this.btnNhap.Iconimage_right = null;
            this.btnNhap.Iconimage_right_Selected = null;
            this.btnNhap.Iconimage_Selected = null;
            this.btnNhap.IconMarginLeft = 12;
            this.btnNhap.IconMarginRight = 0;
            this.btnNhap.IconRightVisible = false;
            this.btnNhap.IconRightZoom = 0D;
            this.btnNhap.IconVisible = true;
            this.btnNhap.IconZoom = 60D;
            this.btnNhap.IsTab = false;
            this.btnNhap.Location = new System.Drawing.Point(0, 60);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNhap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnNhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNhap.selected = true;
            this.btnNhap.Size = new System.Drawing.Size(250, 48);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập hàng";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhap.Textcolor = System.Drawing.Color.Transparent;
            this.btnNhap.TextFont = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // subuserPanel
            // 
            this.subuserPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subuserPanel.BackgroundImage")));
            this.subuserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subuserPanel.Controls.Add(this.btnLogout);
            this.subuserPanel.Controls.Add(this.btnInfo);
            this.Transition.SetDecoration(this.subuserPanel, BunifuAnimatorNS.DecorationType.None);
            this.subuserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subuserPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subuserPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subuserPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subuserPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subuserPanel.Location = new System.Drawing.Point(0, 121);
            this.subuserPanel.Name = "subuserPanel";
            this.subuserPanel.Quality = 10;
            this.subuserPanel.Size = new System.Drawing.Size(250, 115);
            this.subuserPanel.TabIndex = 13;
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "Đăng xuất";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = null;
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 90;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = false;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 60D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 57);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(250, 48);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.Transparent;
            this.btnLogout.TextFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.BorderRadius = 0;
            this.btnInfo.ButtonText = "Thông tin";
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnInfo, BunifuAnimatorNS.DecorationType.None);
            this.btnInfo.DisabledColor = System.Drawing.Color.Gray;
            this.btnInfo.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInfo.Iconimage = null;
            this.btnInfo.Iconimage_right = null;
            this.btnInfo.Iconimage_right_Selected = null;
            this.btnInfo.Iconimage_Selected = null;
            this.btnInfo.IconMarginLeft = 90;
            this.btnInfo.IconMarginRight = 0;
            this.btnInfo.IconRightVisible = false;
            this.btnInfo.IconRightZoom = 0D;
            this.btnInfo.IconVisible = true;
            this.btnInfo.IconZoom = 60D;
            this.btnInfo.IsTab = false;
            this.btnInfo.Location = new System.Drawing.Point(0, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInfo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnInfo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInfo.selected = true;
            this.btnInfo.Size = new System.Drawing.Size(250, 48);
            this.btnInfo.TabIndex = 11;
            this.btnInfo.Text = "Thông tin";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Textcolor = System.Drawing.Color.Transparent;
            this.btnInfo.TextFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // userPanel
            // 
            this.userPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPanel.BackgroundImage")));
            this.userPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPanel.Controls.Add(this.userBtn);
            this.Transition.SetDecoration(this.userPanel, BunifuAnimatorNS.DecorationType.None);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.userPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.userPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.userPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.userPanel.Location = new System.Drawing.Point(0, 56);
            this.userPanel.Name = "userPanel";
            this.userPanel.Quality = 10;
            this.userPanel.Size = new System.Drawing.Size(250, 65);
            this.userPanel.TabIndex = 14;
            // 
            // userBtn
            // 
            this.userBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.userBtn.BackColor = System.Drawing.Color.Transparent;
            this.userBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userBtn.BorderRadius = 0;
            this.userBtn.ButtonText = "Lồ Sìn Dậu";
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.userBtn, BunifuAnimatorNS.DecorationType.None);
            this.userBtn.DisabledColor = System.Drawing.Color.Gray;
            this.userBtn.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.userBtn.Iconimage = global::Do_an_Winform.Properties.Resources.user;
            this.userBtn.Iconimage_right = null;
            this.userBtn.Iconimage_right_Selected = null;
            this.userBtn.Iconimage_Selected = null;
            this.userBtn.IconMarginLeft = 5;
            this.userBtn.IconMarginRight = 0;
            this.userBtn.IconRightVisible = false;
            this.userBtn.IconRightZoom = 0D;
            this.userBtn.IconVisible = true;
            this.userBtn.IconZoom = 90D;
            this.userBtn.IsTab = false;
            this.userBtn.Location = new System.Drawing.Point(0, 6);
            this.userBtn.Name = "userBtn";
            this.userBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.userBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.userBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.userBtn.selected = true;
            this.userBtn.Size = new System.Drawing.Size(250, 48);
            this.userBtn.TabIndex = 4;
            this.userBtn.Text = "Lồ Sìn Dậu";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userBtn.Textcolor = System.Drawing.Color.Transparent;
            this.userBtn.TextFont = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerPanel.BackgroundImage")));
            this.headerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerPanel.Controls.Add(this.slideBtn);
            this.Transition.SetDecoration(this.headerPanel, BunifuAnimatorNS.DecorationType.None);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.headerPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.headerPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.headerPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Quality = 10;
            this.headerPanel.Size = new System.Drawing.Size(250, 56);
            this.headerPanel.TabIndex = 15;
            // 
            // slideBtn
            // 
            this.slideBtn.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.slideBtn, BunifuAnimatorNS.DecorationType.None);
            this.slideBtn.Image = ((System.Drawing.Image)(resources.GetObject("slideBtn.Image")));
            this.slideBtn.ImageActive = null;
            this.slideBtn.Location = new System.Drawing.Point(9, 19);
            this.slideBtn.Name = "slideBtn";
            this.slideBtn.Size = new System.Drawing.Size(35, 20);
            this.slideBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slideBtn.TabIndex = 6;
            this.slideBtn.TabStop = false;
            this.slideBtn.Zoom = 10;
            this.slideBtn.Click += new System.EventHandler(this.slideBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Transition.SetDecoration(this.mainPanel, BunifuAnimatorNS.DecorationType.None);
            this.mainPanel.GradientBottomLeft = System.Drawing.SystemColors.Control;
            this.mainPanel.GradientBottomRight = System.Drawing.SystemColors.Control;
            this.mainPanel.GradientTopLeft = System.Drawing.SystemColors.Control;
            this.mainPanel.GradientTopRight = System.Drawing.SystemColors.Control;
            this.mainPanel.Location = new System.Drawing.Point(260, 45);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Quality = 10;
            this.mainPanel.Size = new System.Drawing.Size(943, 549);
            this.mainPanel.TabIndex = 5;
            // 
            // titlePanel
            // 
            this.titlePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titlePanel.BackgroundImage")));
            this.titlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titlePanel.Controls.Add(this.btnMaximize);
            this.titlePanel.Controls.Add(this.btnMinimize);
            this.titlePanel.Controls.Add(this.btnClose);
            this.Transition.SetDecoration(this.titlePanel, BunifuAnimatorNS.DecorationType.None);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.titlePanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.titlePanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.titlePanel.GradientTopRight = System.Drawing.Color.White;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Quality = 10;
            this.titlePanel.Size = new System.Drawing.Size(1215, 38);
            this.titlePanel.TabIndex = 4;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximize.Image = global::Do_an_Winform.Properties.Resources.full_screen;
            this.btnMaximize.ImageActive = null;
            this.btnMaximize.Location = new System.Drawing.Point(1146, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(18, 22);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Zoom = 10;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Image = global::Do_an_Winform.Properties.Resources.minus;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1102, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 22);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = global::Do_an_Winform.Properties.Resources.crossed;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1182, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frm_Thukho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 605);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titlePanel);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Thukho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Thukho_Load);
            this.sidemenu.ResumeLayout(false);
            this.functionPanel.ResumeLayout(false);
            this.subuserPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slideBtn)).EndInit();
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition Transition;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton slideBtn;
        private Bunifu.Framework.UI.BunifuFlatButton userBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel functionPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnStock;
        private Bunifu.Framework.UI.BunifuFlatButton btnNhap;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.Framework.UI.BunifuFlatButton btnInfo;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuGradientPanel subuserPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel userPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel sidemenu;
        private Bunifu.Framework.UI.BunifuGradientPanel headerPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel mainPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel titlePanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}