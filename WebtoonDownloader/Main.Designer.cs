using WebtoonDownloader.Interface;

namespace WebtoonDownloader
{
	partial class Main
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.MINIMIZE_BUTTON = new WebtoonDownloader.Interface.FlatImageButton();
			this.CLOSE_BUTTON = new WebtoonDownloader.Interface.FlatImageButton();
			this.APP_LOGO = new System.Windows.Forms.PictureBox();
			this.APP_TITLE = new WebtoonDownloader.Interface.CustomLabel();
			this.URL_TEXTBOX = new System.Windows.Forms.TextBox();
			this.StatusMessageLabel = new System.Windows.Forms.Label();
			this.webtoonTitleLabel = new System.Windows.Forms.Label();
			this.webtoonDescriptionLabel = new System.Windows.Forms.Label();
			this.URL_TEXTBOX_TITLELABEL = new System.Windows.Forms.Label();
			this.webtoonStarRateLabel = new System.Windows.Forms.Label();
			this.webtoonUploadDateLabel = new System.Windows.Forms.Label();
			this.uploadDateImage = new System.Windows.Forms.PictureBox();
			this.starImage = new System.Windows.Forms.PictureBox();
			this.thumbnailImage = new System.Windows.Forms.PictureBox();
			this.backgroundImage = new System.Windows.Forms.PictureBox();
			this.CANCEL_BUTTON = new WebtoonDownloader.Interface.FlatButton();
			this.REQUEST_BUTTON = new WebtoonDownloader.Interface.FlatButton();
			this.downloadProgress = new WebtoonDownloader.Interface.FlatProgressBar();
			this.downFinishShutDownCheckBox = new System.Windows.Forms.CheckBox();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MINIMIZE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uploadDateImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.starImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.thumbnailImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add(this.MINIMIZE_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.CLOSE_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.APP_LOGO);
			this.APP_TITLE_BAR.Controls.Add(this.APP_TITLE);
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(600, 40);
			this.APP_TITLE_BAR.TabIndex = 0;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			// 
			// MINIMIZE_BUTTON
			// 
			this.MINIMIZE_BUTTON.AnimationLerpP = 0.8F;
			this.MINIMIZE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.MINIMIZE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MINIMIZE_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.DimGray;
			this.MINIMIZE_BUTTON.Image = global::WebtoonDownloader.Properties.Resources.minimize;
			this.MINIMIZE_BUTTON.Location = new System.Drawing.Point(520, 0);
			this.MINIMIZE_BUTTON.Name = "MINIMIZE_BUTTON";
			this.MINIMIZE_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.DarkGray;
			this.MINIMIZE_BUTTON.Size = new System.Drawing.Size(40, 40);
			this.MINIMIZE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.MINIMIZE_BUTTON.TabIndex = 6;
			this.MINIMIZE_BUTTON.TabStop = false;
			this.MINIMIZE_BUTTON.Click += new System.EventHandler(this.MINIMIZE_BUTTON_Click);
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.AnimationLerpP = 0.8F;
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.IndianRed;
			this.CLOSE_BUTTON.Image = global::WebtoonDownloader.Properties.Resources.close;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(560, 0);
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
			this.APP_LOGO.Cursor = System.Windows.Forms.Cursors.Hand;
			this.APP_LOGO.Image = global::WebtoonDownloader.Properties.Resources.APP_ICON_30x30;
			this.APP_LOGO.Location = new System.Drawing.Point(5, 5);
			this.APP_LOGO.Name = "APP_LOGO";
			this.APP_LOGO.Size = new System.Drawing.Size(30, 30);
			this.APP_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.APP_LOGO.TabIndex = 3;
			this.APP_LOGO.TabStop = false;
			this.APP_LOGO.Click += new System.EventHandler(this.APP_LOGO_Click);
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
			this.APP_TITLE.Text = "웹툰 다운로더";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// URL_TEXTBOX
			// 
			this.URL_TEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.URL_TEXTBOX.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.URL_TEXTBOX.Location = new System.Drawing.Point(68, 285);
			this.URL_TEXTBOX.Name = "URL_TEXTBOX";
			this.URL_TEXTBOX.Size = new System.Drawing.Size(304, 23);
			this.URL_TEXTBOX.TabIndex = 1;
			this.URL_TEXTBOX.Text = "http://comic.naver.com/webtoon/list.nhn?titleId=570503&weekday=thu";
			// 
			// StatusMessageLabel
			// 
			this.StatusMessageLabel.BackColor = System.Drawing.Color.Transparent;
			this.StatusMessageLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.StatusMessageLabel.Location = new System.Drawing.Point(6, 256);
			this.StatusMessageLabel.Name = "StatusMessageLabel";
			this.StatusMessageLabel.Size = new System.Drawing.Size(406, 23);
			this.StatusMessageLabel.TabIndex = 3;
			this.StatusMessageLabel.Text = "ㅁㄴㅇㅁㄴㅇㅁㄴㅇㄴ";
			this.StatusMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.StatusMessageLabel.Visible = false;
			// 
			// webtoonTitleLabel
			// 
			this.webtoonTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonTitleLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonTitleLabel.Location = new System.Drawing.Point(9, 120);
			this.webtoonTitleLabel.Name = "webtoonTitleLabel";
			this.webtoonTitleLabel.Size = new System.Drawing.Size(583, 30);
			this.webtoonTitleLabel.TabIndex = 5;
			this.webtoonTitleLabel.Text = "웹툰 다운로더";
			this.webtoonTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// webtoonDescriptionLabel
			// 
			this.webtoonDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonDescriptionLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonDescriptionLabel.Location = new System.Drawing.Point(9, 155);
			this.webtoonDescriptionLabel.Name = "webtoonDescriptionLabel";
			this.webtoonDescriptionLabel.Size = new System.Drawing.Size(583, 60);
			this.webtoonDescriptionLabel.TabIndex = 6;
			this.webtoonDescriptionLabel.Text = "다운받으실 웹툰의 URL을 입력하세요.";
			this.webtoonDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// URL_TEXTBOX_TITLELABEL
			// 
			this.URL_TEXTBOX_TITLELABEL.AutoSize = true;
			this.URL_TEXTBOX_TITLELABEL.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.URL_TEXTBOX_TITLELABEL.Location = new System.Drawing.Point(6, 289);
			this.URL_TEXTBOX_TITLELABEL.Name = "URL_TEXTBOX_TITLELABEL";
			this.URL_TEXTBOX_TITLELABEL.Size = new System.Drawing.Size(59, 15);
			this.URL_TEXTBOX_TITLELABEL.TabIndex = 8;
			this.URL_TEXTBOX_TITLELABEL.Text = "웹툰 링크";
			// 
			// webtoonStarRateLabel
			// 
			this.webtoonStarRateLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonStarRateLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonStarRateLabel.Location = new System.Drawing.Point(425, 124);
			this.webtoonStarRateLabel.Name = "webtoonStarRateLabel";
			this.webtoonStarRateLabel.Size = new System.Drawing.Size(50, 23);
			this.webtoonStarRateLabel.TabIndex = 10;
			this.webtoonStarRateLabel.Text = "0.00";
			this.webtoonStarRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// webtoonUploadDateLabel
			// 
			this.webtoonUploadDateLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonUploadDateLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonUploadDateLabel.Location = new System.Drawing.Point(485, 124);
			this.webtoonUploadDateLabel.Name = "webtoonUploadDateLabel";
			this.webtoonUploadDateLabel.Size = new System.Drawing.Size(90, 23);
			this.webtoonUploadDateLabel.TabIndex = 12;
			this.webtoonUploadDateLabel.Text = "2016.23.23";
			this.webtoonUploadDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// uploadDateImage
			// 
			this.uploadDateImage.BackColor = System.Drawing.Color.Transparent;
			this.uploadDateImage.Image = global::WebtoonDownloader.Properties.Resources.date;
			this.uploadDateImage.Location = new System.Drawing.Point(510, 80);
			this.uploadDateImage.Name = "uploadDateImage";
			this.uploadDateImage.Size = new System.Drawing.Size(40, 40);
			this.uploadDateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.uploadDateImage.TabIndex = 13;
			this.uploadDateImage.TabStop = false;
			// 
			// starImage
			// 
			this.starImage.BackColor = System.Drawing.Color.Transparent;
			this.starImage.Image = global::WebtoonDownloader.Properties.Resources.star;
			this.starImage.Location = new System.Drawing.Point(430, 80);
			this.starImage.Name = "starImage";
			this.starImage.Size = new System.Drawing.Size(40, 40);
			this.starImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.starImage.TabIndex = 9;
			this.starImage.TabStop = false;
			// 
			// thumbnailImage
			// 
			this.thumbnailImage.BackColor = System.Drawing.Color.Transparent;
			this.thumbnailImage.Location = new System.Drawing.Point(7, 60);
			this.thumbnailImage.Name = "thumbnailImage";
			this.thumbnailImage.Size = new System.Drawing.Size(200, 202);
			this.thumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.thumbnailImage.TabIndex = 4;
			this.thumbnailImage.TabStop = false;
			this.thumbnailImage.Paint += new System.Windows.Forms.PaintEventHandler(this.thumbnailImage_Paint);
			// 
			// backgroundImage
			// 
			this.backgroundImage.BackColor = System.Drawing.Color.Transparent;
			this.backgroundImage.Image = global::WebtoonDownloader.Properties.Resources.background;
			this.backgroundImage.Location = new System.Drawing.Point(0, 0);
			this.backgroundImage.Name = "backgroundImage";
			this.backgroundImage.Size = new System.Drawing.Size(600, 320);
			this.backgroundImage.TabIndex = 16;
			this.backgroundImage.TabStop = false;
			this.backgroundImage.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundImage_Paint);
			// 
			// CANCEL_BUTTON
			// 
			this.CANCEL_BUTTON.AnimationLerpP = 0.8F;
			this.CANCEL_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CANCEL_BUTTON.ButtonText = "취소";
			this.CANCEL_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.CANCEL_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CANCEL_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.DarkOrange;
			this.CANCEL_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CANCEL_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CANCEL_BUTTON.Location = new System.Drawing.Point(312, 284);
			this.CANCEL_BUTTON.Name = "CANCEL_BUTTON";
			this.CANCEL_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.Orange;
			this.CANCEL_BUTTON.Size = new System.Drawing.Size(60, 25);
			this.CANCEL_BUTTON.TabIndex = 15;
			this.CANCEL_BUTTON.Text = "취소";
			this.CANCEL_BUTTON.UseVisualStyleBackColor = false;
			this.CANCEL_BUTTON.Click += new System.EventHandler(this.CANCEL_BUTTON_Click);
			// 
			// REQUEST_BUTTON
			// 
			this.REQUEST_BUTTON.AnimationLerpP = 0.8F;
			this.REQUEST_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.REQUEST_BUTTON.ButtonText = "다운로드";
			this.REQUEST_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.REQUEST_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.REQUEST_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.REQUEST_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.REQUEST_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REQUEST_BUTTON.Location = new System.Drawing.Point(378, 284);
			this.REQUEST_BUTTON.Name = "REQUEST_BUTTON";
			this.REQUEST_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.REQUEST_BUTTON.Size = new System.Drawing.Size(210, 25);
			this.REQUEST_BUTTON.TabIndex = 14;
			this.REQUEST_BUTTON.Text = "다운로드";
			this.REQUEST_BUTTON.UseVisualStyleBackColor = false;
			this.REQUEST_BUTTON.Click += new System.EventHandler(this.REQUEST_BUTTON_Click);
			// 
			// downloadProgress
			// 
			this.downloadProgress.BackColor = System.Drawing.Color.White;
			this.downloadProgress.Location = new System.Drawing.Point(12, 285);
			this.downloadProgress.Name = "downloadProgress";
			this.downloadProgress.Progress = 0;
			this.downloadProgress.Size = new System.Drawing.Size(294, 23);
			this.downloadProgress.TabIndex = 7;
			this.downloadProgress.Visible = false;
			// 
			// downFinishShutDownCheckBox
			// 
			this.downFinishShutDownCheckBox.AutoSize = true;
			this.downFinishShutDownCheckBox.BackColor = System.Drawing.Color.Transparent;
			this.downFinishShutDownCheckBox.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.downFinishShutDownCheckBox.Location = new System.Drawing.Point(462, 262);
			this.downFinishShutDownCheckBox.Name = "downFinishShutDownCheckBox";
			this.downFinishShutDownCheckBox.Size = new System.Drawing.Size(126, 17);
			this.downFinishShutDownCheckBox.TabIndex = 17;
			this.downFinishShutDownCheckBox.Text = "완료 후 시스템 종료";
			this.downFinishShutDownCheckBox.UseVisualStyleBackColor = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(600, 320);
			this.Controls.Add(this.downFinishShutDownCheckBox);
			this.Controls.Add(this.CANCEL_BUTTON);
			this.Controls.Add(this.REQUEST_BUTTON);
			this.Controls.Add(this.uploadDateImage);
			this.Controls.Add(this.webtoonUploadDateLabel);
			this.Controls.Add(this.webtoonStarRateLabel);
			this.Controls.Add(this.starImage);
			this.Controls.Add(this.URL_TEXTBOX_TITLELABEL);
			this.Controls.Add(this.downloadProgress);
			this.Controls.Add(this.webtoonDescriptionLabel);
			this.Controls.Add(this.webtoonTitleLabel);
			this.Controls.Add(this.thumbnailImage);
			this.Controls.Add(this.StatusMessageLabel);
			this.Controls.Add(this.URL_TEXTBOX);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.backgroundImage);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "웹툰 다운로더";
			this.Load += new System.EventHandler(this.Main_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MINIMIZE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uploadDateImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.starImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.thumbnailImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.TextBox URL_TEXTBOX;
		private System.Windows.Forms.Label StatusMessageLabel;
		private System.Windows.Forms.PictureBox thumbnailImage;
		private System.Windows.Forms.Label webtoonTitleLabel;
		private System.Windows.Forms.Label webtoonDescriptionLabel;
		private FlatProgressBar downloadProgress;
		private System.Windows.Forms.PictureBox APP_LOGO;
		private System.Windows.Forms.Label URL_TEXTBOX_TITLELABEL;
		private System.Windows.Forms.PictureBox starImage;
		private System.Windows.Forms.Label webtoonStarRateLabel;
		private System.Windows.Forms.Label webtoonUploadDateLabel;
		private System.Windows.Forms.PictureBox uploadDateImage;
		private FlatImageButton CLOSE_BUTTON;
		private FlatImageButton MINIMIZE_BUTTON;
		private FlatButton REQUEST_BUTTON;
		private FlatButton CANCEL_BUTTON;
		private System.Windows.Forms.PictureBox backgroundImage;
		private System.Windows.Forms.CheckBox downFinishShutDownCheckBox;
	}
}

