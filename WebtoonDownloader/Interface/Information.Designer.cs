namespace WebtoonDownloader.Interface
{
	partial class Information
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.CLOSE_BUTTON = new WebtoonDownloader.Interface.FlatImageButton();
			this.APP_LOGO = new System.Windows.Forms.PictureBox();
			this.APP_TITLE = new WebtoonDownloader.Interface.CustomLabel();
			this.programIcon = new System.Windows.Forms.PictureBox();
			this.programTitleKO = new System.Windows.Forms.Label();
			this.programTitleEN = new System.Windows.Forms.Label();
			this.programVersion = new System.Windows.Forms.Label();
			this.programAuthor = new System.Windows.Forms.Label();
			this.lawWarning = new System.Windows.Forms.Label();
			this.openSourceProjectButton = new WebtoonDownloader.Interface.FlatButton();
			this.updateCheckStatus = new System.Windows.Forms.Label();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.programIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add(this.CLOSE_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.APP_LOGO);
			this.APP_TITLE_BAR.Controls.Add(this.APP_TITLE);
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(460, 40);
			this.APP_TITLE_BAR.TabIndex = 1;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.AnimationLerpP = 0.8F;
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.IndianRed;
			this.CLOSE_BUTTON.Image = global::WebtoonDownloader.Properties.Resources.close;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(420, 0);
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.DarkGray;
			this.CLOSE_BUTTON.Size = new System.Drawing.Size(40, 40);
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.CLOSE_BUTTON.TabIndex = 5;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// APP_LOGO
			// 
			this.APP_LOGO.BackColor = System.Drawing.Color.Transparent;
			this.APP_LOGO.Cursor = System.Windows.Forms.Cursors.Default;
			this.APP_LOGO.Image = global::WebtoonDownloader.Properties.Resources.APP_ICON_30x30;
			this.APP_LOGO.Location = new System.Drawing.Point(5, 5);
			this.APP_LOGO.Name = "APP_LOGO";
			this.APP_LOGO.Size = new System.Drawing.Size(30, 30);
			this.APP_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.APP_LOGO.TabIndex = 3;
			this.APP_LOGO.TabStop = false;
			// 
			// APP_TITLE
			// 
			this.APP_TITLE.AutoSize = true;
			this.APP_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.APP_TITLE.Location = new System.Drawing.Point(40, 12);
			this.APP_TITLE.Name = "APP_TITLE";
			this.APP_TITLE.Size = new System.Drawing.Size(122, 17);
			this.APP_TITLE.TabIndex = 0;
			this.APP_TITLE.Text = "웹툰 다운로더 정보";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// programIcon
			// 
			this.programIcon.BackColor = System.Drawing.Color.Transparent;
			this.programIcon.Cursor = System.Windows.Forms.Cursors.Default;
			this.programIcon.Image = global::WebtoonDownloader.Properties.Resources.APP_ICON_150x150;
			this.programIcon.Location = new System.Drawing.Point(12, 52);
			this.programIcon.Name = "programIcon";
			this.programIcon.Size = new System.Drawing.Size(150, 150);
			this.programIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.programIcon.TabIndex = 5;
			this.programIcon.TabStop = false;
			// 
			// programTitleKO
			// 
			this.programTitleKO.AutoSize = true;
			this.programTitleKO.BackColor = System.Drawing.Color.Transparent;
			this.programTitleKO.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.programTitleKO.Location = new System.Drawing.Point(170, 52);
			this.programTitleKO.Name = "programTitleKO";
			this.programTitleKO.Size = new System.Drawing.Size(112, 21);
			this.programTitleKO.TabIndex = 6;
			this.programTitleKO.Text = "웹툰 다운로더";
			// 
			// programTitleEN
			// 
			this.programTitleEN.AutoSize = true;
			this.programTitleEN.BackColor = System.Drawing.Color.Transparent;
			this.programTitleEN.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.programTitleEN.Location = new System.Drawing.Point(173, 75);
			this.programTitleEN.Name = "programTitleEN";
			this.programTitleEN.Size = new System.Drawing.Size(141, 17);
			this.programTitleEN.TabIndex = 7;
			this.programTitleEN.Text = "Webtoon Downloader";
			// 
			// programVersion
			// 
			this.programVersion.BackColor = System.Drawing.Color.Transparent;
			this.programVersion.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.programVersion.Location = new System.Drawing.Point(257, 274);
			this.programVersion.Name = "programVersion";
			this.programVersion.Size = new System.Drawing.Size(196, 17);
			this.programVersion.TabIndex = 8;
			this.programVersion.Text = "버전 1.0.0.0";
			this.programVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// programAuthor
			// 
			this.programAuthor.AutoSize = true;
			this.programAuthor.BackColor = System.Drawing.Color.Transparent;
			this.programAuthor.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.programAuthor.Location = new System.Drawing.Point(9, 274);
			this.programAuthor.Name = "programAuthor";
			this.programAuthor.Size = new System.Drawing.Size(242, 17);
			this.programAuthor.TabIndex = 9;
			this.programAuthor.Text = "Copyright © DeveloFOX Studio 2016";
			// 
			// lawWarning
			// 
			this.lawWarning.BackColor = System.Drawing.Color.Transparent;
			this.lawWarning.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.lawWarning.Location = new System.Drawing.Point(171, 147);
			this.lawWarning.Name = "lawWarning";
			this.lawWarning.Size = new System.Drawing.Size(282, 93);
			this.lawWarning.TabIndex = 10;
			this.lawWarning.Text = "본 소프트웨어 저작자 혹은 저작권자는 이 소프트웨어와 연관되어 발생하는 어떠한 법적 문제에 책임을 지지 않습니다.\r\n\r\nMIT License";
			// 
			// openSourceProjectButton
			// 
			this.openSourceProjectButton.AnimationLerpP = 0.8F;
			this.openSourceProjectButton.BackColor = System.Drawing.Color.Transparent;
			this.openSourceProjectButton.ButtonText = "오픈 소스 프로젝트";
			this.openSourceProjectButton.ButtonTextColor = System.Drawing.Color.Black;
			this.openSourceProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.openSourceProjectButton.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.openSourceProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.openSourceProjectButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.openSourceProjectButton.Location = new System.Drawing.Point(12, 210);
			this.openSourceProjectButton.Name = "openSourceProjectButton";
			this.openSourceProjectButton.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.openSourceProjectButton.Size = new System.Drawing.Size(150, 30);
			this.openSourceProjectButton.TabIndex = 12;
			this.openSourceProjectButton.Text = "오픈 소스 프로젝트";
			this.openSourceProjectButton.UseVisualStyleBackColor = false;
			this.openSourceProjectButton.Click += new System.EventHandler(this.openSourceProjectButton_Click);
			// 
			// updateCheckStatus
			// 
			this.updateCheckStatus.BackColor = System.Drawing.Color.Transparent;
			this.updateCheckStatus.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.updateCheckStatus.Location = new System.Drawing.Point(173, 97);
			this.updateCheckStatus.Name = "updateCheckStatus";
			this.updateCheckStatus.Size = new System.Drawing.Size(278, 15);
			this.updateCheckStatus.TabIndex = 13;
			this.updateCheckStatus.Text = "업데이트 확인 중 ...";
			// 
			// Information
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(460, 300);
			this.Controls.Add(this.updateCheckStatus);
			this.Controls.Add(this.openSourceProjectButton);
			this.Controls.Add(this.lawWarning);
			this.Controls.Add(this.programAuthor);
			this.Controls.Add(this.programVersion);
			this.Controls.Add(this.programTitleEN);
			this.Controls.Add(this.programTitleKO);
			this.Controls.Add(this.programIcon);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Information";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "웹툰 다운로더 - 정보";
			this.Load += new System.EventHandler(this.Information_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Information_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.programIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.PictureBox APP_LOGO;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox programIcon;
		private System.Windows.Forms.Label programTitleKO;
		private System.Windows.Forms.Label programTitleEN;
		private System.Windows.Forms.Label programVersion;
		private System.Windows.Forms.Label programAuthor;
		private System.Windows.Forms.Label lawWarning;
		private FlatImageButton CLOSE_BUTTON;
		private FlatButton openSourceProjectButton;
		private System.Windows.Forms.Label updateCheckStatus;
	}
}