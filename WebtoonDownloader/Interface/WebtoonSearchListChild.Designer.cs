namespace WebtoonDownloader.Interface
{
	partial class WebtoonSearchListChild
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

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent( )
		{
			this.components = new System.ComponentModel.Container();
			this.webtoonThumbnailImage = new System.Windows.Forms.PictureBox();
			this.webtoonTitleLabel = new System.Windows.Forms.Label();
			this.webtoonDescriptionLabel = new System.Windows.Forms.Label();
			this.webtoonAuthorLabel = new System.Windows.Forms.Label();
			this.webtoonNumLabel = new System.Windows.Forms.Label();
			this.webtoonUploadLabel = new System.Windows.Forms.Label();
			this.webtoonGenreLabel = new System.Windows.Forms.Label();
			this.selectButton = new WebtoonDownloader.Interface.FlatButton();
			this.adultIcon = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.webtoonThumbnailImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adultIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// webtoonThumbnailImage
			// 
			this.webtoonThumbnailImage.BackColor = System.Drawing.Color.Transparent;
			this.webtoonThumbnailImage.Location = new System.Drawing.Point(3, 3);
			this.webtoonThumbnailImage.Name = "webtoonThumbnailImage";
			this.webtoonThumbnailImage.Size = new System.Drawing.Size(150, 144);
			this.webtoonThumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.webtoonThumbnailImage.TabIndex = 0;
			this.webtoonThumbnailImage.TabStop = false;
			this.webtoonThumbnailImage.Paint += new System.Windows.Forms.PaintEventHandler(this.webtoonThumbnailImage_Paint);
			// 
			// webtoonTitleLabel
			// 
			this.webtoonTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonTitleLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonTitleLabel.Location = new System.Drawing.Point(159, 3);
			this.webtoonTitleLabel.Name = "webtoonTitleLabel";
			this.webtoonTitleLabel.Size = new System.Drawing.Size(447, 25);
			this.webtoonTitleLabel.TabIndex = 7;
			this.webtoonTitleLabel.Text = "웹툰 이름";
			this.webtoonTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// webtoonDescriptionLabel
			// 
			this.webtoonDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonDescriptionLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonDescriptionLabel.Location = new System.Drawing.Point(161, 49);
			this.webtoonDescriptionLabel.Name = "webtoonDescriptionLabel";
			this.webtoonDescriptionLabel.Size = new System.Drawing.Size(477, 70);
			this.webtoonDescriptionLabel.TabIndex = 8;
			this.webtoonDescriptionLabel.Text = "웹툰 설명";
			// 
			// webtoonAuthorLabel
			// 
			this.webtoonAuthorLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonAuthorLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonAuthorLabel.Location = new System.Drawing.Point(161, 30);
			this.webtoonAuthorLabel.Name = "webtoonAuthorLabel";
			this.webtoonAuthorLabel.Size = new System.Drawing.Size(376, 15);
			this.webtoonAuthorLabel.TabIndex = 9;
			this.webtoonAuthorLabel.Text = "웹툰 작가";
			this.webtoonAuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// webtoonNumLabel
			// 
			this.webtoonNumLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonNumLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonNumLabel.Location = new System.Drawing.Point(642, 117);
			this.webtoonNumLabel.Name = "webtoonNumLabel";
			this.webtoonNumLabel.Size = new System.Drawing.Size(105, 30);
			this.webtoonNumLabel.TabIndex = 10;
			this.webtoonNumLabel.Text = "총 0화";
			this.webtoonNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// webtoonUploadLabel
			// 
			this.webtoonUploadLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonUploadLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonUploadLabel.Location = new System.Drawing.Point(159, 125);
			this.webtoonUploadLabel.Name = "webtoonUploadLabel";
			this.webtoonUploadLabel.Size = new System.Drawing.Size(205, 20);
			this.webtoonUploadLabel.TabIndex = 11;
			this.webtoonUploadLabel.Text = "마지막 업로드 일 : 2016.23.23";
			this.webtoonUploadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// webtoonGenreLabel
			// 
			this.webtoonGenreLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonGenreLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonGenreLabel.Location = new System.Drawing.Point(612, 3);
			this.webtoonGenreLabel.Name = "webtoonGenreLabel";
			this.webtoonGenreLabel.Size = new System.Drawing.Size(135, 30);
			this.webtoonGenreLabel.TabIndex = 12;
			this.webtoonGenreLabel.Text = "연애 장르";
			this.webtoonGenreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// selectButton
			// 
			this.selectButton.AnimationLerpP = 0.8F;
			this.selectButton.BackColor = System.Drawing.Color.Transparent;
			this.selectButton.ButtonText = "선택";
			this.selectButton.ButtonTextColor = System.Drawing.Color.Black;
			this.selectButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.selectButton.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.selectButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.selectButton.Location = new System.Drawing.Point(642, 50);
			this.selectButton.Name = "selectButton";
			this.selectButton.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.selectButton.Size = new System.Drawing.Size(104, 50);
			this.selectButton.TabIndex = 13;
			this.selectButton.Text = "선택";
			this.selectButton.UseVisualStyleBackColor = false;
			this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
			// 
			// adultIcon
			// 
			this.adultIcon.BackColor = System.Drawing.Color.Transparent;
			this.adultIcon.Image = global::WebtoonDownloader.Properties.Resources.adultIcon;
			this.adultIcon.Location = new System.Drawing.Point(608, 117);
			this.adultIcon.Name = "adultIcon";
			this.adultIcon.Size = new System.Drawing.Size(30, 30);
			this.adultIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.adultIcon.TabIndex = 14;
			this.adultIcon.TabStop = false;
			this.toolTip1.SetToolTip(this.adultIcon, "미성년자 관람 불가 웹툰");
			// 
			// WebtoonSearchListChild
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.adultIcon);
			this.Controls.Add(this.selectButton);
			this.Controls.Add(this.webtoonGenreLabel);
			this.Controls.Add(this.webtoonUploadLabel);
			this.Controls.Add(this.webtoonNumLabel);
			this.Controls.Add(this.webtoonAuthorLabel);
			this.Controls.Add(this.webtoonDescriptionLabel);
			this.Controls.Add(this.webtoonTitleLabel);
			this.Controls.Add(this.webtoonThumbnailImage);
			this.Name = "WebtoonSearchListChild";
			this.Size = new System.Drawing.Size(750, 150);
			this.Load += new System.EventHandler(this.WebtoonSearchListChild_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.WebtoonSearchListChild_Paint);
			((System.ComponentModel.ISupportInitialize)(this.webtoonThumbnailImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adultIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox webtoonThumbnailImage;
		private System.Windows.Forms.Label webtoonTitleLabel;
		private System.Windows.Forms.Label webtoonDescriptionLabel;
		private System.Windows.Forms.Label webtoonAuthorLabel;
		private System.Windows.Forms.Label webtoonNumLabel;
		private System.Windows.Forms.Label webtoonUploadLabel;
		private System.Windows.Forms.Label webtoonGenreLabel;
		private FlatButton selectButton;
		private System.Windows.Forms.PictureBox adultIcon;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}
