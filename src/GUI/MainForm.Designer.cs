namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.DrawTriangeButton = new System.Windows.Forms.ToolStripButton();
            this.drawPointBtn = new System.Windows.Forms.ToolStripButton();
            this.drawLineBtn = new System.Windows.Forms.ToolStripButton();
            this.DrawEllipseButton = new System.Windows.Forms.ToolStripButton();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.groupShapeBtn = new System.Windows.Forms.ToolStripButton();
            this.colorBtn = new System.Windows.Forms.ToolStripButton();
            this.RotateTrackBar = new System.Windows.Forms.TrackBar();
            this.SizeTrackBar = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SetOpacitytrackBar = new System.Windows.Forms.TrackBar();
            this.CustomShapeBtn = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetOpacitytrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(693, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 401);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(693, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawRectangleSpeedButton,
            this.DrawTriangeButton,
            this.drawPointBtn,
            this.drawLineBtn,
            this.CustomShapeBtn,
            this.DrawEllipseButton,
            this.pickUpSpeedButton,
            this.groupShapeBtn,
            this.colorBtn});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(693, 27);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            this.speedMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SpeedMenu_ItemClicked);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(24, 24);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // DrawTriangeButton
            // 
            this.DrawTriangeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawTriangeButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawTriangeButton.Image")));
            this.DrawTriangeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawTriangeButton.Name = "DrawTriangeButton";
            this.DrawTriangeButton.Size = new System.Drawing.Size(24, 24);
            this.DrawTriangeButton.Text = "DrawTriangeButton";
            this.DrawTriangeButton.Click += new System.EventHandler(this.DrawTriangeButton_Click);
            // 
            // drawPointBtn
            // 
            this.drawPointBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPointBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawPointBtn.Image")));
            this.drawPointBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPointBtn.Name = "drawPointBtn";
            this.drawPointBtn.Size = new System.Drawing.Size(24, 24);
            this.drawPointBtn.Text = "pointBtn";
            this.drawPointBtn.ToolTipText = "drawPointBtn";
            this.drawPointBtn.Click += new System.EventHandler(this.drawPointBtn_Click);
            // 
            // drawLineBtn
            // 
            this.drawLineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawLineBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawLineBtn.Image")));
            this.drawLineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawLineBtn.Name = "drawLineBtn";
            this.drawLineBtn.Size = new System.Drawing.Size(24, 24);
            this.drawLineBtn.Text = "lineBtn";
            this.drawLineBtn.ToolTipText = "drawLineBtn";
            this.drawLineBtn.Click += new System.EventHandler(this.drawLineBtn_Click_1);
            // 
            // DrawEllipseButton
            // 
            this.DrawEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawEllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawEllipseButton.Image")));
            this.DrawEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawEllipseButton.Name = "DrawEllipseButton";
            this.DrawEllipseButton.Size = new System.Drawing.Size(24, 24);
            this.DrawEllipseButton.Text = "DrawEllipseButton";
            this.DrawEllipseButton.Click += new System.EventHandler(this.DrawEllipseButton_Click);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(24, 24);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            // 
            // groupShapeBtn
            // 
            this.groupShapeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.groupShapeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupShapeBtn.Image = ((System.Drawing.Image)(resources.GetObject("groupShapeBtn.Image")));
            this.groupShapeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupShapeBtn.Name = "groupShapeBtn";
            this.groupShapeBtn.Size = new System.Drawing.Size(24, 24);
            this.groupShapeBtn.Text = "GroupBtn";
            this.groupShapeBtn.Click += new System.EventHandler(this.groupShapeBtn_Click);
            // 
            // colorBtn
            // 
            this.colorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorBtn.Image = ((System.Drawing.Image)(resources.GetObject("colorBtn.Image")));
            this.colorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(24, 24);
            this.colorBtn.Text = "colorBtn";
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // RotateTrackBar
            // 
            this.RotateTrackBar.Location = new System.Drawing.Point(367, 23);
            this.RotateTrackBar.Name = "RotateTrackBar";
            this.RotateTrackBar.Size = new System.Drawing.Size(104, 45);
            this.RotateTrackBar.TabIndex = 5;
            // 
            // SizeTrackBar
            // 
            this.SizeTrackBar.Location = new System.Drawing.Point(284, 23);
            this.SizeTrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SizeTrackBar.Maximum = 20;
            this.SizeTrackBar.Name = "SizeTrackBar";
            this.SizeTrackBar.Size = new System.Drawing.Size(78, 45);
            this.SizeTrackBar.TabIndex = 6;
            this.SizeTrackBar.Value = 10;
            this.SizeTrackBar.Scroll += new System.EventHandler(this.SizeTrackBar_Scroll);
            // 
            // SetOpacitytrackBar
            // 
            this.SetOpacitytrackBar.Location = new System.Drawing.Point(201, 23);
            this.SetOpacitytrackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SetOpacitytrackBar.Maximum = 255;
            this.SetOpacitytrackBar.Name = "SetOpacitytrackBar";
            this.SetOpacitytrackBar.Size = new System.Drawing.Size(78, 45);
            this.SetOpacitytrackBar.TabIndex = 8;
            this.SetOpacitytrackBar.Value = 255;
            this.SetOpacitytrackBar.Scroll += new System.EventHandler(this.SetOpacitytrackBar_Scroll);
            // 
            // CustomShapeBtn
            // 
            this.CustomShapeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CustomShapeBtn.Image = ((System.Drawing.Image)(resources.GetObject("CustomShapeBtn.Image")));
            this.CustomShapeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CustomShapeBtn.Name = "CustomShapeBtn";
            this.CustomShapeBtn.Size = new System.Drawing.Size(24, 24);
            this.CustomShapeBtn.Text = "CustomShapeBtn";
            this.CustomShapeBtn.Click += new System.EventHandler(this.CustomShapeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 423);
            this.Controls.Add(this.SetOpacitytrackBar);
            this.Controls.Add(this.SizeTrackBar);
            this.Controls.Add(this.RotateTrackBar);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotateTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetOpacitytrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton DrawEllipseButton;
        private System.Windows.Forms.ToolStripButton DrawTriangeButton;
        private System.Windows.Forms.TrackBar RotateTrackBar;
        private System.Windows.Forms.ToolStripButton groupShapeBtn;
        private System.Windows.Forms.TrackBar SizeTrackBar;
        private System.Windows.Forms.ToolStripButton drawPointBtn;
        private System.Windows.Forms.ToolStripButton drawLineBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton colorBtn;
        private System.Windows.Forms.TrackBar SetOpacitytrackBar;
        private System.Windows.Forms.ToolStripButton CustomShapeBtn;
    }
}
