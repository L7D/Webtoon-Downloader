namespace WebtoonDownloader.Interface
{
	partial class DownloadOptionForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadOptionForm));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_LOGO = new System.Windows.Forms.PictureBox();
			this.fastDownloadModeTitle = new System.Windows.Forms.Label();
			this.webtoonPageList = new System.Windows.Forms.Panel();
			this.loadingStatusLabel = new System.Windows.Forms.Label();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchTitleLabel = new System.Windows.Forms.Label();
			this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
			this.fastDownloadModeDesc = new System.Windows.Forms.Label();
			this.webtoonThumbnailImage = new System.Windows.Forms.PictureBox();
			this.webtoonDescriptionLabel = new System.Windows.Forms.Label();
			this.webtoonTitleLabel = new System.Windows.Forms.Label();
			this.webtoonNumLabel = new System.Windows.Forms.Label();
			this.fastDownloadModeSwitch = new WebtoonDownloader.Interface.FlatImageButton();
			this.DOWNLOAD_BUTTON = new WebtoonDownloader.Interface.FlatButton();
			this.sortSwitchImageButton = new WebtoonDownloader.Interface.FlatImageButton();
			this.CLOSE_BUTTON = new WebtoonDownloader.Interface.FlatImageButton();
			this.APP_TITLE = new WebtoonDownloader.Interface.CustomLabel();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.webtoonThumbnailImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fastDownloadModeSwitch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sortSwitchImageButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
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
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(800, 40);
			this.APP_TITLE_BAR.TabIndex = 2;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
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
			// fastDownloadModeTitle
			// 
			this.fastDownloadModeTitle.AutoSize = true;
			this.fastDownloadModeTitle.BackColor = System.Drawing.Color.Transparent;
			this.fastDownloadModeTitle.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.fastDownloadModeTitle.Location = new System.Drawing.Point(68, 640);
			this.fastDownloadModeTitle.Name = "fastDownloadModeTitle";
			this.fastDownloadModeTitle.Size = new System.Drawing.Size(229, 20);
			this.fastDownloadModeTitle.TabIndex = 7;
			this.fastDownloadModeTitle.Text = "고속 다운로드 모드 비 활성화 됨";
			// 
			// webtoonPageList
			// 
			this.webtoonPageList.AutoScroll = true;
			this.webtoonPageList.BackColor = System.Drawing.Color.Transparent;
			this.webtoonPageList.Location = new System.Drawing.Point(12, 82);
			this.webtoonPageList.Name = "webtoonPageList";
			this.webtoonPageList.Size = new System.Drawing.Size(550, 545);
			this.webtoonPageList.TabIndex = 3;
			// 
			// loadingStatusLabel
			// 
			this.loadingStatusLabel.BackColor = System.Drawing.Color.Transparent;
			this.loadingStatusLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.loadingStatusLabel.Location = new System.Drawing.Point(568, 602);
			this.loadingStatusLabel.Name = "loadingStatusLabel";
			this.loadingStatusLabel.Size = new System.Drawing.Size(220, 25);
			this.loadingStatusLabel.TabIndex = 0;
			this.loadingStatusLabel.Text = "데이터를 불러오고 있습니다 ...";
			this.loadingStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// searchTextBox
			// 
			this.searchTextBox.BackColor = System.Drawing.Color.White;
			this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.searchTextBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.searchTextBox.Location = new System.Drawing.Point(100, 50);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(426, 23);
			this.searchTextBox.TabIndex = 4;
			this.searchTextBox.WordWrap = false;
			this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
			// 
			// searchTitleLabel
			// 
			this.searchTitleLabel.AutoSize = true;
			this.searchTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.searchTitleLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.searchTitleLabel.Location = new System.Drawing.Point(11, 54);
			this.searchTitleLabel.Name = "searchTitleLabel";
			this.searchTitleLabel.Size = new System.Drawing.Size(83, 15);
			this.searchTitleLabel.TabIndex = 5;
			this.searchTitleLabel.Text = "제목으로 검색";
			// 
			// toolTipControl
			// 
			this.toolTipControl.BackColor = System.Drawing.Color.White;
			// 
			// fastDownloadModeDesc
			// 
			this.fastDownloadModeDesc.AutoSize = true;
			this.fastDownloadModeDesc.BackColor = System.Drawing.Color.Transparent;
			this.fastDownloadModeDesc.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.fastDownloadModeDesc.Location = new System.Drawing.Point(69, 670);
			this.fastDownloadModeDesc.Name = "fastDownloadModeDesc";
			this.fastDownloadModeDesc.Size = new System.Drawing.Size(482, 13);
			this.fastDownloadModeDesc.TabIndex = 12;
			this.fastDownloadModeDesc.Text = "고속 다운로드 모드는 파일 안정성을 위한 대기시간을 모두 없애 다운로드 속도를 가속시킵니다.";
			this.fastDownloadModeDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// webtoonThumbnailImage
			// 
			this.webtoonThumbnailImage.BackColor = System.Drawing.Color.Transparent;
			this.webtoonThumbnailImage.Location = new System.Drawing.Point(568, 82);
			this.webtoonThumbnailImage.Name = "webtoonThumbnailImage";
			this.webtoonThumbnailImage.Size = new System.Drawing.Size(220, 202);
			this.webtoonThumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.webtoonThumbnailImage.TabIndex = 13;
			this.webtoonThumbnailImage.TabStop = false;
			// 
			// webtoonDescriptionLabel
			// 
			this.webtoonDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonDescriptionLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonDescriptionLabel.Location = new System.Drawing.Point(568, 335);
			this.webtoonDescriptionLabel.Name = "webtoonDescriptionLabel";
			this.webtoonDescriptionLabel.Size = new System.Drawing.Size(220, 149);
			this.webtoonDescriptionLabel.TabIndex = 15;
			this.webtoonDescriptionLabel.Text = "웹툰 설명";
			this.webtoonDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// webtoonTitleLabel
			// 
			this.webtoonTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonTitleLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonTitleLabel.Location = new System.Drawing.Point(568, 295);
			this.webtoonTitleLabel.Name = "webtoonTitleLabel";
			this.webtoonTitleLabel.Size = new System.Drawing.Size(220, 30);
			this.webtoonTitleLabel.TabIndex = 14;
			this.webtoonTitleLabel.Text = "웹툰 이름";
			this.webtoonTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// webtoonNumLabel
			// 
			this.webtoonNumLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonNumLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonNumLabel.Location = new System.Drawing.Point(568, 46);
			this.webtoonNumLabel.Name = "webtoonNumLabel";
			this.webtoonNumLabel.Size = new System.Drawing.Size(220, 30);
			this.webtoonNumLabel.TabIndex = 16;
			this.webtoonNumLabel.Text = "총 0개의 화";
			this.webtoonNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fastDownloadModeSwitch
			// 
			this.fastDownloadModeSwitch.AnimationLerpP = 0.8F;
			this.fastDownloadModeSwitch.BackColor = System.Drawing.Color.Transparent;
			this.fastDownloadModeSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.fastDownloadModeSwitch.EnterStateBackgroundColor = System.Drawing.Color.DimGray;
			this.fastDownloadModeSwitch.Image = global::WebtoonDownloader.Properties.Resources.fastDownload;
			this.fastDownloadModeSwitch.Location = new System.Drawing.Point(12, 638);
			this.fastDownloadModeSwitch.Name = "fastDownloadModeSwitch";
			this.fastDownloadModeSwitch.NormalStateBackgroundColor = System.Drawing.Color.DarkGray;
			this.fastDownloadModeSwitch.Size = new System.Drawing.Size(50, 50);
			this.fastDownloadModeSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.fastDownloadModeSwitch.TabIndex = 11;
			this.fastDownloadModeSwitch.TabStop = false;
			this.fastDownloadModeSwitch.Click += new System.EventHandler(this.fastDownloadModeSwitch_Click);
			// 
			// DOWNLOAD_BUTTON
			// 
			this.DOWNLOAD_BUTTON.AnimationLerpP = 0.8F;
			this.DOWNLOAD_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.DOWNLOAD_BUTTON.ButtonText = "다운로드";
			this.DOWNLOAD_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.DOWNLOAD_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DOWNLOAD_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.DOWNLOAD_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DOWNLOAD_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.DOWNLOAD_BUTTON.Location = new System.Drawing.Point(568, 638);
			this.DOWNLOAD_BUTTON.Name = "DOWNLOAD_BUTTON";
			this.DOWNLOAD_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.DOWNLOAD_BUTTON.Size = new System.Drawing.Size(220, 50);
			this.DOWNLOAD_BUTTON.TabIndex = 8;
			this.DOWNLOAD_BUTTON.Text = "다운로드";
			this.DOWNLOAD_BUTTON.UseVisualStyleBackColor = false;
			this.DOWNLOAD_BUTTON.Click += new System.EventHandler(this.DOWNLOAD_BUTTON_Click);
			// 
			// sortSwitchImageButton
			// 
			this.sortSwitchImageButton.AnimationLerpP = 0.8F;
			this.sortSwitchImageButton.BackColor = System.Drawing.Color.Transparent;
			this.sortSwitchImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sortSwitchImageButton.EnterStateBackgroundColor = System.Drawing.Color.DimGray;
			this.sortSwitchImageButton.Image = global::WebtoonDownloader.Properties.Resources.ascSort;
			this.sortSwitchImageButton.Location = new System.Drawing.Point(532, 46);
			this.sortSwitchImageButton.Name = "sortSwitchImageButton";
			this.sortSwitchImageButton.NormalStateBackgroundColor = System.Drawing.Color.DarkGray;
			this.sortSwitchImageButton.Size = new System.Drawing.Size(30, 30);
			this.sortSwitchImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.sortSwitchImageButton.TabIndex = 6;
			this.sortSwitchImageButton.TabStop = false;
			this.sortSwitchImageButton.Click += new System.EventHandler(this.sortSwitchImageButton_Click);
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.AnimationLerpP = 0.8F;
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.IndianRed;
			this.CLOSE_BUTTON.Image = global::WebtoonDownloader.Properties.Resources.close;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(760, 0);
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.DarkGray;
			this.CLOSE_BUTTON.Size = new System.Drawing.Size(40, 40);
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.CLOSE_BUTTON.TabIndex = 5;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// APP_TITLE
			// 
			this.APP_TITLE.AutoSize = true;
			this.APP_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.APP_TITLE.Location = new System.Drawing.Point(40, 12);
			this.APP_TITLE.Name = "APP_TITLE";
			this.APP_TITLE.Size = new System.Drawing.Size(91, 17);
			this.APP_TITLE.TabIndex = 0;
			this.APP_TITLE.Text = "다운로드 옵션";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// DownloadOptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 700);
			this.Controls.Add(this.webtoonNumLabel);
			this.Controls.Add(this.webtoonDescriptionLabel);
			this.Controls.Add(this.webtoonThumbnailImage);
			this.Controls.Add(this.webtoonTitleLabel);
			this.Controls.Add(this.fastDownloadModeDesc);
			this.Controls.Add(this.fastDownloadModeSwitch);
			this.Controls.Add(this.loadingStatusLabel);
			this.Controls.Add(this.fastDownloadModeTitle);
			this.Controls.Add(this.DOWNLOAD_BUTTON);
			this.Controls.Add(this.sortSwitchImageButton);
			this.Controls.Add(this.searchTitleLabel);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.webtoonPageList);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DownloadOptionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "웹툰 다운로더 - 다운로드 옵션";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DownloadOptionForm_FormClosed);
			this.Load += new System.EventHandler(this.DownloadOptionForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.DownloadOptionForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.webtoonThumbnailImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fastDownloadModeSwitch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sortSwitchImageButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private FlatImageButton CLOSE_BUTTON;
		private System.Windows.Forms.PictureBox APP_LOGO;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.Panel webtoonPageList;
		private System.Windows.Forms.Label loadingStatusLabel;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Label searchTitleLabel;
		private FlatImageButton sortSwitchImageButton;
		private System.Windows.Forms.ToolTip toolTipControl;
		private System.Windows.Forms.Label fastDownloadModeTitle;
		private FlatButton DOWNLOAD_BUTTON;
		private FlatImageButton fastDownloadModeSwitch;
		private System.Windows.Forms.Label fastDownloadModeDesc;
		private System.Windows.Forms.PictureBox webtoonThumbnailImage;
		private System.Windows.Forms.Label webtoonDescriptionLabel;
		private System.Windows.Forms.Label webtoonTitleLabel;
		private System.Windows.Forms.Label webtoonNumLabel;
	}
}