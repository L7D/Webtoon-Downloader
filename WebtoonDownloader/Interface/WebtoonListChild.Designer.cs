namespace WebtoonDownloader.Interface
{
	partial class WebtoonListChild
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
			this.webtoonTitleLabel = new System.Windows.Forms.Label();
			this.webtoonUploadDateLabel = new System.Windows.Forms.Label();
			this.webtoonStarRateLabel = new System.Windows.Forms.Label();
			this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
			this.blockButton = new WebtoonDownloader.Interface.FlatImageButton();
			this.uploadDateImage = new System.Windows.Forms.PictureBox();
			this.starImage = new System.Windows.Forms.PictureBox();
			this.thumbnailImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.blockButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uploadDateImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.starImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.thumbnailImage)).BeginInit();
			this.SuspendLayout();
			// 
			// webtoonTitleLabel
			// 
			this.webtoonTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonTitleLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonTitleLabel.Location = new System.Drawing.Point(151, 5);
			this.webtoonTitleLabel.Name = "webtoonTitleLabel";
			this.webtoonTitleLabel.Size = new System.Drawing.Size(376, 30);
			this.webtoonTitleLabel.TabIndex = 6;
			this.webtoonTitleLabel.Text = "웹툰 화";
			this.webtoonTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// webtoonUploadDateLabel
			// 
			this.webtoonUploadDateLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonUploadDateLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonUploadDateLabel.Location = new System.Drawing.Point(207, 67);
			this.webtoonUploadDateLabel.Name = "webtoonUploadDateLabel";
			this.webtoonUploadDateLabel.Size = new System.Drawing.Size(90, 20);
			this.webtoonUploadDateLabel.TabIndex = 16;
			this.webtoonUploadDateLabel.Text = "2016.23.23";
			this.webtoonUploadDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// webtoonStarRateLabel
			// 
			this.webtoonStarRateLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonStarRateLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonStarRateLabel.Location = new System.Drawing.Point(151, 67);
			this.webtoonStarRateLabel.Name = "webtoonStarRateLabel";
			this.webtoonStarRateLabel.Size = new System.Drawing.Size(50, 20);
			this.webtoonStarRateLabel.TabIndex = 15;
			this.webtoonStarRateLabel.Text = "0.00";
			this.webtoonStarRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// blockButton
			// 
			this.blockButton.AnimationLerpP = 0.8F;
			this.blockButton.BackColor = System.Drawing.Color.Transparent;
			this.blockButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.blockButton.EnterStateBackgroundColor = System.Drawing.Color.LightCoral;
			this.blockButton.Image = global::WebtoonDownloader.Properties.Resources.block;
			this.blockButton.Location = new System.Drawing.Point(487, 47);
			this.blockButton.Name = "blockButton";
			this.blockButton.NormalStateBackgroundColor = System.Drawing.Color.DarkGray;
			this.blockButton.Size = new System.Drawing.Size(40, 40);
			this.blockButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.blockButton.TabIndex = 18;
			this.blockButton.TabStop = false;
			this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
			// 
			// uploadDateImage
			// 
			this.uploadDateImage.BackColor = System.Drawing.Color.Transparent;
			this.uploadDateImage.Image = global::WebtoonDownloader.Properties.Resources.date;
			this.uploadDateImage.Location = new System.Drawing.Point(242, 43);
			this.uploadDateImage.Name = "uploadDateImage";
			this.uploadDateImage.Size = new System.Drawing.Size(20, 20);
			this.uploadDateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.uploadDateImage.TabIndex = 17;
			this.uploadDateImage.TabStop = false;
			// 
			// starImage
			// 
			this.starImage.BackColor = System.Drawing.Color.Transparent;
			this.starImage.Image = global::WebtoonDownloader.Properties.Resources.star;
			this.starImage.Location = new System.Drawing.Point(166, 43);
			this.starImage.Name = "starImage";
			this.starImage.Size = new System.Drawing.Size(20, 20);
			this.starImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.starImage.TabIndex = 14;
			this.starImage.TabStop = false;
			// 
			// thumbnailImage
			// 
			this.thumbnailImage.BackColor = System.Drawing.Color.Transparent;
			this.thumbnailImage.Location = new System.Drawing.Point(5, 5);
			this.thumbnailImage.Name = "thumbnailImage";
			this.thumbnailImage.Size = new System.Drawing.Size(140, 80);
			this.thumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.thumbnailImage.TabIndex = 0;
			this.thumbnailImage.TabStop = false;
			this.thumbnailImage.Paint += new System.Windows.Forms.PaintEventHandler(this.thumbnailImage_Paint);
			// 
			// WebtoonListChild
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.blockButton);
			this.Controls.Add(this.uploadDateImage);
			this.Controls.Add(this.webtoonUploadDateLabel);
			this.Controls.Add(this.webtoonStarRateLabel);
			this.Controls.Add(this.starImage);
			this.Controls.Add(this.webtoonTitleLabel);
			this.Controls.Add(this.thumbnailImage);
			this.DoubleBuffered = true;
			this.Name = "WebtoonListChild";
			this.Size = new System.Drawing.Size(530, 90);
			this.Load += new System.EventHandler(this.WebtoonListChild_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.WebtoonListChild_Paint);
			((System.ComponentModel.ISupportInitialize)(this.blockButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uploadDateImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.starImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.thumbnailImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox thumbnailImage;
		private System.Windows.Forms.Label webtoonTitleLabel;
		private System.Windows.Forms.PictureBox uploadDateImage;
		private System.Windows.Forms.Label webtoonUploadDateLabel;
		private System.Windows.Forms.Label webtoonStarRateLabel;
		private System.Windows.Forms.PictureBox starImage;
		private FlatImageButton blockButton;
		private System.Windows.Forms.ToolTip toolTipControl;
	}
}
