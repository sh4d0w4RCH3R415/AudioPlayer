
namespace Audio_Player
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pnlTitleBar = new System.Windows.Forms.Panel();
			this.pnlMinimize = new System.Windows.Forms.Panel();
			this.lblMinimize = new System.Windows.Forms.Label();
			this.pnlClose = new System.Windows.Forms.Panel();
			this.lblClose = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlPlayerTab = new System.Windows.Forms.Panel();
			this.lblPlayerTab = new System.Windows.Forms.Label();
			this.pnlSettingsTab = new System.Windows.Forms.Panel();
			this.lblSettingsTab = new System.Windows.Forms.Label();
			this.picPlayerTab = new System.Windows.Forms.PictureBox();
			this.picSettingsTab = new System.Windows.Forms.PictureBox();
			this.pnlSettings = new System.Windows.Forms.Panel();
			this.pnlRemoveSelectedMedia = new System.Windows.Forms.Panel();
			this.lblRemoveSelectedMedia = new System.Windows.Forms.Label();
			this.pnlAddMedia = new System.Windows.Forms.Panel();
			this.lblAddMedia = new System.Windows.Forms.Label();
			this.lstAudioFiles = new System.Windows.Forms.ListBox();
			this.info = new System.Windows.Forms.ToolTip(this.components);
			this.lstPlayableMedia = new System.Windows.Forms.ListBox();
			this.pnlPlayMedia = new System.Windows.Forms.Panel();
			this.lblPlayMedia = new System.Windows.Forms.Label();
			this.pnlPlayer = new System.Windows.Forms.Panel();
			this.pnlStopMedia = new System.Windows.Forms.Panel();
			this.lblStopMedia = new System.Windows.Forms.Label();
			this.pnlTitleBar.SuspendLayout();
			this.pnlMinimize.SuspendLayout();
			this.pnlClose.SuspendLayout();
			this.pnlPlayerTab.SuspendLayout();
			this.pnlSettingsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerTab)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picSettingsTab)).BeginInit();
			this.pnlSettings.SuspendLayout();
			this.pnlRemoveSelectedMedia.SuspendLayout();
			this.pnlAddMedia.SuspendLayout();
			this.pnlPlayMedia.SuspendLayout();
			this.pnlPlayer.SuspendLayout();
			this.pnlStopMedia.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTitleBar
			// 
			this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
			this.pnlTitleBar.Controls.Add(this.pnlMinimize);
			this.pnlTitleBar.Controls.Add(this.pnlClose);
			this.pnlTitleBar.Controls.Add(this.lblTitle);
			this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitleBar.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
			this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
			this.pnlTitleBar.Name = "pnlTitleBar";
			this.pnlTitleBar.Size = new System.Drawing.Size(376, 32);
			this.pnlTitleBar.TabIndex = 0;
			this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// pnlMinimize
			// 
			this.pnlMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMinimize.Controls.Add(this.lblMinimize);
			this.pnlMinimize.Location = new System.Drawing.Point(312, 0);
			this.pnlMinimize.Name = "pnlMinimize";
			this.pnlMinimize.Size = new System.Drawing.Size(32, 32);
			this.pnlMinimize.TabIndex = 3;
			this.info.SetToolTip(this.pnlMinimize, "Minimizes the window");
			this.pnlMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_MsClick);
			this.pnlMinimize.MouseEnter += new System.EventHandler(this.Minimize_MsEnter);
			this.pnlMinimize.MouseLeave += new System.EventHandler(this.Minimize_MsLeave);
			// 
			// lblMinimize
			// 
			this.lblMinimize.AutoSize = true;
			this.lblMinimize.Font = new System.Drawing.Font("Webdings", 11F);
			this.lblMinimize.Location = new System.Drawing.Point(5, 5);
			this.lblMinimize.Name = "lblMinimize";
			this.lblMinimize.Size = new System.Drawing.Size(24, 20);
			this.lblMinimize.TabIndex = 1;
			this.lblMinimize.Text = "0";
			this.info.SetToolTip(this.lblMinimize, "Minimizes the window");
			this.lblMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_MsClick);
			this.lblMinimize.MouseEnter += new System.EventHandler(this.Minimize_MsEnter);
			this.lblMinimize.MouseLeave += new System.EventHandler(this.Minimize_MsLeave);
			// 
			// pnlClose
			// 
			this.pnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlClose.Controls.Add(this.lblClose);
			this.pnlClose.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
			this.pnlClose.Location = new System.Drawing.Point(344, 0);
			this.pnlClose.Name = "pnlClose";
			this.pnlClose.Size = new System.Drawing.Size(32, 32);
			this.pnlClose.TabIndex = 2;
			this.info.SetToolTip(this.pnlClose, "Closes the window");
			this.pnlClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_MsClick);
			this.pnlClose.MouseEnter += new System.EventHandler(this.Close_MsEnter);
			this.pnlClose.MouseLeave += new System.EventHandler(this.Close_MsLeave);
			// 
			// lblClose
			// 
			this.lblClose.AutoSize = true;
			this.lblClose.Font = new System.Drawing.Font("Webdings", 10.5F);
			this.lblClose.Location = new System.Drawing.Point(5, 6);
			this.lblClose.Name = "lblClose";
			this.lblClose.Size = new System.Drawing.Size(23, 20);
			this.lblClose.TabIndex = 0;
			this.lblClose.Text = "r";
			this.info.SetToolTip(this.lblClose, "Closes the window");
			this.lblClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_MsClick);
			this.lblClose.MouseEnter += new System.EventHandler(this.Close_MsEnter);
			this.lblClose.MouseLeave += new System.EventHandler(this.Close_MsLeave);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
			this.lblTitle.Location = new System.Drawing.Point(4, 6);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(103, 21);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Audio Player";
			this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// pnlPlayerTab
			// 
			this.pnlPlayerTab.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pnlPlayerTab.Controls.Add(this.lblPlayerTab);
			this.pnlPlayerTab.Location = new System.Drawing.Point(77, 55);
			this.pnlPlayerTab.Name = "pnlPlayerTab";
			this.pnlPlayerTab.Size = new System.Drawing.Size(109, 28);
			this.pnlPlayerTab.TabIndex = 1;
			this.info.SetToolTip(this.pnlPlayerTab, "Opens the player tab");
			this.pnlPlayerTab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerTab_MsClick);
			this.pnlPlayerTab.MouseEnter += new System.EventHandler(this.PlayerTab_MsEnter);
			this.pnlPlayerTab.MouseLeave += new System.EventHandler(this.PlayerTab_MsLeave);
			// 
			// lblPlayerTab
			// 
			this.lblPlayerTab.Font = new System.Drawing.Font("Yu Gothic Medium", 10F);
			this.lblPlayerTab.Location = new System.Drawing.Point(31, 6);
			this.lblPlayerTab.Name = "lblPlayerTab";
			this.lblPlayerTab.Size = new System.Drawing.Size(49, 18);
			this.lblPlayerTab.TabIndex = 0;
			this.lblPlayerTab.Text = "Player";
			this.lblPlayerTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.info.SetToolTip(this.lblPlayerTab, "Opens the player tab");
			this.lblPlayerTab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerTab_MsClick);
			this.lblPlayerTab.MouseEnter += new System.EventHandler(this.PlayerTab_MsEnter);
			this.lblPlayerTab.MouseLeave += new System.EventHandler(this.PlayerTab_MsLeave);
			// 
			// pnlSettingsTab
			// 
			this.pnlSettingsTab.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pnlSettingsTab.Controls.Add(this.lblSettingsTab);
			this.pnlSettingsTab.Location = new System.Drawing.Point(192, 55);
			this.pnlSettingsTab.Name = "pnlSettingsTab";
			this.pnlSettingsTab.Size = new System.Drawing.Size(109, 28);
			this.pnlSettingsTab.TabIndex = 2;
			this.info.SetToolTip(this.pnlSettingsTab, "Opens the settings tab");
			this.pnlSettingsTab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SettingsTab_MsClick);
			this.pnlSettingsTab.MouseEnter += new System.EventHandler(this.SettingsTab_MsEnter);
			this.pnlSettingsTab.MouseLeave += new System.EventHandler(this.SettingsTab_MsLeave);
			// 
			// lblSettingsTab
			// 
			this.lblSettingsTab.Font = new System.Drawing.Font("Yu Gothic Medium", 10F);
			this.lblSettingsTab.Location = new System.Drawing.Point(24, 6);
			this.lblSettingsTab.Name = "lblSettingsTab";
			this.lblSettingsTab.Size = new System.Drawing.Size(62, 18);
			this.lblSettingsTab.TabIndex = 0;
			this.lblSettingsTab.Text = "Settings";
			this.lblSettingsTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.info.SetToolTip(this.lblSettingsTab, "Opens the settings tab");
			this.lblSettingsTab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SettingsTab_MsClick);
			this.lblSettingsTab.MouseEnter += new System.EventHandler(this.SettingsTab_MsEnter);
			this.lblSettingsTab.MouseLeave += new System.EventHandler(this.SettingsTab_MsLeave);
			// 
			// picPlayerTab
			// 
			this.picPlayerTab.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.picPlayerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(125)))));
			this.picPlayerTab.Location = new System.Drawing.Point(77, 89);
			this.picPlayerTab.Name = "picPlayerTab";
			this.picPlayerTab.Size = new System.Drawing.Size(109, 2);
			this.picPlayerTab.TabIndex = 3;
			this.picPlayerTab.TabStop = false;
			// 
			// picSettingsTab
			// 
			this.picSettingsTab.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.picSettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(125)))));
			this.picSettingsTab.Location = new System.Drawing.Point(192, 89);
			this.picSettingsTab.Name = "picSettingsTab";
			this.picSettingsTab.Size = new System.Drawing.Size(109, 2);
			this.picSettingsTab.TabIndex = 4;
			this.picSettingsTab.TabStop = false;
			this.picSettingsTab.Visible = false;
			// 
			// pnlSettings
			// 
			this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSettings.Controls.Add(this.pnlRemoveSelectedMedia);
			this.pnlSettings.Controls.Add(this.pnlAddMedia);
			this.pnlSettings.Controls.Add(this.lstAudioFiles);
			this.pnlSettings.Location = new System.Drawing.Point(12, 107);
			this.pnlSettings.Name = "pnlSettings";
			this.pnlSettings.Size = new System.Drawing.Size(352, 255);
			this.pnlSettings.TabIndex = 5;
			// 
			// pnlRemoveSelectedMedia
			// 
			this.pnlRemoveSelectedMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlRemoveSelectedMedia.Controls.Add(this.lblRemoveSelectedMedia);
			this.pnlRemoveSelectedMedia.Location = new System.Drawing.Point(51, 126);
			this.pnlRemoveSelectedMedia.Name = "pnlRemoveSelectedMedia";
			this.pnlRemoveSelectedMedia.Size = new System.Drawing.Size(123, 42);
			this.pnlRemoveSelectedMedia.TabIndex = 2;
			this.info.SetToolTip(this.pnlRemoveSelectedMedia, "Removes the selected media in the list from the player");
			this.pnlRemoveSelectedMedia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoveSelectedMedia_MsClick);
			this.pnlRemoveSelectedMedia.MouseEnter += new System.EventHandler(this.RemoveSelectedMedia_MsEnter);
			this.pnlRemoveSelectedMedia.MouseLeave += new System.EventHandler(this.RemoveSelectedMedia_MsLeave);
			// 
			// lblRemoveSelectedMedia
			// 
			this.lblRemoveSelectedMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblRemoveSelectedMedia.AutoSize = true;
			this.lblRemoveSelectedMedia.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
			this.lblRemoveSelectedMedia.Location = new System.Drawing.Point(0, 0);
			this.lblRemoveSelectedMedia.Name = "lblRemoveSelectedMedia";
			this.lblRemoveSelectedMedia.Size = new System.Drawing.Size(125, 42);
			this.lblRemoveSelectedMedia.TabIndex = 1;
			this.lblRemoveSelectedMedia.Text = "Remove\r\nSelected Media";
			this.lblRemoveSelectedMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.info.SetToolTip(this.lblRemoveSelectedMedia, "Removes the selected media in the list from the player");
			this.lblRemoveSelectedMedia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoveSelectedMedia_MsClick);
			this.lblRemoveSelectedMedia.MouseEnter += new System.EventHandler(this.RemoveSelectedMedia_MsEnter);
			this.lblRemoveSelectedMedia.MouseLeave += new System.EventHandler(this.RemoveSelectedMedia_MsLeave);
			// 
			// pnlAddMedia
			// 
			this.pnlAddMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnlAddMedia.Controls.Add(this.lblAddMedia);
			this.pnlAddMedia.Location = new System.Drawing.Point(51, 78);
			this.pnlAddMedia.Name = "pnlAddMedia";
			this.pnlAddMedia.Size = new System.Drawing.Size(123, 42);
			this.pnlAddMedia.TabIndex = 1;
			this.info.SetToolTip(this.pnlAddMedia, "Adds new media to the player");
			this.pnlAddMedia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddMedia_MsClick);
			this.pnlAddMedia.MouseEnter += new System.EventHandler(this.AddMedia_MsEnter);
			this.pnlAddMedia.MouseLeave += new System.EventHandler(this.AddMedia_MsLeave);
			// 
			// lblAddMedia
			// 
			this.lblAddMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblAddMedia.AutoSize = true;
			this.lblAddMedia.Font = new System.Drawing.Font("Yu Gothic Medium", 14F);
			this.lblAddMedia.Location = new System.Drawing.Point(10, 10);
			this.lblAddMedia.Name = "lblAddMedia";
			this.lblAddMedia.Size = new System.Drawing.Size(106, 25);
			this.lblAddMedia.TabIndex = 1;
			this.lblAddMedia.Text = "Add Media";
			this.lblAddMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.info.SetToolTip(this.lblAddMedia, "Adds new media to the player");
			this.lblAddMedia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddMedia_MsClick);
			this.lblAddMedia.MouseEnter += new System.EventHandler(this.AddMedia_MsEnter);
			this.lblAddMedia.MouseLeave += new System.EventHandler(this.AddMedia_MsLeave);
			// 
			// lstAudioFiles
			// 
			this.lstAudioFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
			this.lstAudioFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstAudioFiles.Font = new System.Drawing.Font("Yu Gothic Medium", 10F);
			this.lstAudioFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(195)))), ((int)(((byte)(205)))));
			this.lstAudioFiles.FormattingEnabled = true;
			this.lstAudioFiles.ItemHeight = 17;
			this.lstAudioFiles.Location = new System.Drawing.Point(232, 0);
			this.lstAudioFiles.Name = "lstAudioFiles";
			this.lstAudioFiles.Size = new System.Drawing.Size(117, 255);
			this.lstAudioFiles.TabIndex = 0;
			this.info.SetToolTip(this.lstAudioFiles, "The media currently saved in the player");
			// 
			// lstPlayableMedia
			// 
			this.lstPlayableMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
			this.lstPlayableMedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstPlayableMedia.Font = new System.Drawing.Font("Yu Gothic Medium", 10F);
			this.lstPlayableMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(195)))), ((int)(((byte)(205)))));
			this.lstPlayableMedia.FormattingEnabled = true;
			this.lstPlayableMedia.ItemHeight = 17;
			this.lstPlayableMedia.Location = new System.Drawing.Point(232, 0);
			this.lstPlayableMedia.Name = "lstPlayableMedia";
			this.lstPlayableMedia.Size = new System.Drawing.Size(117, 255);
			this.lstPlayableMedia.TabIndex = 0;
			this.info.SetToolTip(this.lstPlayableMedia, "The media that can be played in the player");
			this.lstPlayableMedia.SelectedIndexChanged += new System.EventHandler(this.SelectedMedia_FileChanged);
			this.lstPlayableMedia.SelectedValueChanged += new System.EventHandler(this.SelectedMedia_FileChanged);
			// 
			// pnlPlayMedia
			// 
			this.pnlPlayMedia.Controls.Add(this.lblPlayMedia);
			this.pnlPlayMedia.Location = new System.Drawing.Point(56, 83);
			this.pnlPlayMedia.Name = "pnlPlayMedia";
			this.pnlPlayMedia.Size = new System.Drawing.Size(118, 42);
			this.pnlPlayMedia.TabIndex = 1;
			this.info.SetToolTip(this.pnlPlayMedia, "Plays the selected media");
			this.pnlPlayMedia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlaySelectedMedia_MsClick);
			this.pnlPlayMedia.MouseEnter += new System.EventHandler(this.PlaySelectedMedia_MsEnter);
			this.pnlPlayMedia.MouseLeave += new System.EventHandler(this.PlaySelectedMedia_MsLeave);
			// 
			// lblPlayMedia
			// 
			this.lblPlayMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPlayMedia.AutoSize = true;
			this.lblPlayMedia.Location = new System.Drawing.Point(14, 12);
			this.lblPlayMedia.Name = "lblPlayMedia";
			this.lblPlayMedia.Size = new System.Drawing.Size(93, 21);
			this.lblPlayMedia.TabIndex = 0;
			this.lblPlayMedia.Text = "Play Media";
			this.lblPlayMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.info.SetToolTip(this.lblPlayMedia, "Plays the selected media");
			this.lblPlayMedia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlaySelectedMedia_MsClick);
			this.lblPlayMedia.MouseEnter += new System.EventHandler(this.PlaySelectedMedia_MsEnter);
			this.lblPlayMedia.MouseLeave += new System.EventHandler(this.PlaySelectedMedia_MsLeave);
			// 
			// pnlPlayer
			// 
			this.pnlPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlPlayer.Controls.Add(this.pnlStopMedia);
			this.pnlPlayer.Controls.Add(this.pnlPlayMedia);
			this.pnlPlayer.Controls.Add(this.lstPlayableMedia);
			this.pnlPlayer.Location = new System.Drawing.Point(12, 107);
			this.pnlPlayer.Name = "pnlPlayer";
			this.pnlPlayer.Size = new System.Drawing.Size(352, 255);
			this.pnlPlayer.TabIndex = 6;
			// 
			// pnlStopMedia
			// 
			this.pnlStopMedia.Controls.Add(this.lblStopMedia);
			this.pnlStopMedia.Location = new System.Drawing.Point(56, 131);
			this.pnlStopMedia.Name = "pnlStopMedia";
			this.pnlStopMedia.Size = new System.Drawing.Size(118, 42);
			this.pnlStopMedia.TabIndex = 2;
			this.info.SetToolTip(this.pnlStopMedia, "Plays the selected media");
			this.pnlStopMedia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StopSelectedMedia_MsClick);
			this.pnlStopMedia.MouseEnter += new System.EventHandler(this.StopSelectedMedia_MsEnter);
			this.pnlStopMedia.MouseLeave += new System.EventHandler(this.StopSelectedMedia_MsLeave);
			// 
			// lblStopMedia
			// 
			this.lblStopMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblStopMedia.AutoSize = true;
			this.lblStopMedia.Location = new System.Drawing.Point(13, 12);
			this.lblStopMedia.Name = "lblStopMedia";
			this.lblStopMedia.Size = new System.Drawing.Size(95, 21);
			this.lblStopMedia.TabIndex = 0;
			this.lblStopMedia.Text = "Stop Media";
			this.lblStopMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.info.SetToolTip(this.lblStopMedia, "Stops playing the selected media");
			this.lblStopMedia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StopSelectedMedia_MsClick);
			this.lblStopMedia.MouseEnter += new System.EventHandler(this.StopSelectedMedia_MsEnter);
			this.lblStopMedia.MouseLeave += new System.EventHandler(this.StopSelectedMedia_MsLeave);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(376, 374);
			this.Controls.Add(this.pnlPlayer);
			this.Controls.Add(this.pnlSettings);
			this.Controls.Add(this.picSettingsTab);
			this.Controls.Add(this.picPlayerTab);
			this.Controls.Add(this.pnlSettingsTab);
			this.Controls.Add(this.pnlPlayerTab);
			this.Controls.Add(this.pnlTitleBar);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Yu Gothic Medium", 12F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(195)))), ((int)(((byte)(205)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Audio Player";
			this.pnlTitleBar.ResumeLayout(false);
			this.pnlTitleBar.PerformLayout();
			this.pnlMinimize.ResumeLayout(false);
			this.pnlMinimize.PerformLayout();
			this.pnlClose.ResumeLayout(false);
			this.pnlClose.PerformLayout();
			this.pnlPlayerTab.ResumeLayout(false);
			this.pnlSettingsTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picPlayerTab)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picSettingsTab)).EndInit();
			this.pnlSettings.ResumeLayout(false);
			this.pnlRemoveSelectedMedia.ResumeLayout(false);
			this.pnlRemoveSelectedMedia.PerformLayout();
			this.pnlAddMedia.ResumeLayout(false);
			this.pnlAddMedia.PerformLayout();
			this.pnlPlayMedia.ResumeLayout(false);
			this.pnlPlayMedia.PerformLayout();
			this.pnlPlayer.ResumeLayout(false);
			this.pnlStopMedia.ResumeLayout(false);
			this.pnlStopMedia.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTitleBar;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlMinimize;
		private System.Windows.Forms.Panel pnlClose;
		private System.Windows.Forms.Label lblMinimize;
		private System.Windows.Forms.Label lblClose;
		private System.Windows.Forms.Panel pnlPlayerTab;
		private System.Windows.Forms.Label lblPlayerTab;
		private System.Windows.Forms.Panel pnlSettingsTab;
		private System.Windows.Forms.Label lblSettingsTab;
		private System.Windows.Forms.PictureBox picPlayerTab;
		private System.Windows.Forms.PictureBox picSettingsTab;
		private System.Windows.Forms.Panel pnlSettings;
		private System.Windows.Forms.ListBox lstAudioFiles;
		private System.Windows.Forms.Panel pnlAddMedia;
		private System.Windows.Forms.Panel pnlRemoveSelectedMedia;
		private System.Windows.Forms.ToolTip info;
		private System.Windows.Forms.Label lblRemoveSelectedMedia;
		private System.Windows.Forms.Label lblAddMedia;
		private System.Windows.Forms.Panel pnlPlayer;
		private System.Windows.Forms.ListBox lstPlayableMedia;
		private System.Windows.Forms.Panel pnlPlayMedia;
		private System.Windows.Forms.Label lblPlayMedia;
		private System.Windows.Forms.Panel pnlStopMedia;
		private System.Windows.Forms.Label lblStopMedia;
	}
}

