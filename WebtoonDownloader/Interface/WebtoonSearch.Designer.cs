namespace WebtoonDownloader.Interface
{
	partial class WebtoonSearch
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebtoonSearch));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_LOGO = new System.Windows.Forms.PictureBox();
			this.webtoonSearchResultList = new System.Windows.Forms.Panel();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchTitleLabel = new System.Windows.Forms.Label();
			this.searchStatusLabel = new System.Windows.Forms.Label();
			this.webtoonDirectURLTextBox = new System.Windows.Forms.TextBox();
			this.searchMasterPanel = new System.Windows.Forms.Panel();
			this.searchIcon = new System.Windows.Forms.PictureBox();
			this.searchMasterPanelDescription = new System.Windows.Forms.Label();
			this.webtoonDirectURLTitleLabel = new System.Windows.Forms.Label();
			this.searchResultPanel = new System.Windows.Forms.Panel();
			this.CLOSE_BUTTON = new WebtoonDownloader.Interface.FlatImageButton();
			this.APP_TITLE = new WebtoonDownloader.Interface.CustomLabel();
			this.searchButton = new WebtoonDownloader.Interface.FlatButton();
			this.researchButton = new WebtoonDownloader.Interface.FlatButton();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).BeginInit();
			this.searchMasterPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
			this.searchResultPanel.SuspendLayout();
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
			this.APP_TITLE_BAR.TabIndex = 3;
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
			// webtoonSearchResultList
			// 
			this.webtoonSearchResultList.AutoScroll = true;
			this.webtoonSearchResultList.BackColor = System.Drawing.Color.Transparent;
			this.webtoonSearchResultList.Location = new System.Drawing.Point(0, 35);
			this.webtoonSearchResultList.Name = "webtoonSearchResultList";
			this.webtoonSearchResultList.Size = new System.Drawing.Size(776, 580);
			this.webtoonSearchResultList.TabIndex = 4;
			// 
			// searchTextBox
			// 
			this.searchTextBox.BackColor = System.Drawing.Color.White;
			this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.searchTextBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.searchTextBox.Location = new System.Drawing.Point(98, 100);
			this.searchTextBox.MaxLength = 20;
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(384, 27);
			this.searchTextBox.TabIndex = 5;
			this.searchTextBox.WordWrap = false;
			this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
			// 
			// searchTitleLabel
			// 
			this.searchTitleLabel.AutoSize = true;
			this.searchTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.searchTitleLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.searchTitleLabel.Location = new System.Drawing.Point(15, 102);
			this.searchTitleLabel.Name = "searchTitleLabel";
			this.searchTitleLabel.Size = new System.Drawing.Size(74, 20);
			this.searchTitleLabel.TabIndex = 6;
			this.searchTitleLabel.Text = "웹툰 제목";
			// 
			// searchStatusLabel
			// 
			this.searchStatusLabel.BackColor = System.Drawing.Color.Transparent;
			this.searchStatusLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.searchStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.searchStatusLabel.Location = new System.Drawing.Point(0, 0);
			this.searchStatusLabel.Name = "searchStatusLabel";
			this.searchStatusLabel.Size = new System.Drawing.Size(588, 35);
			this.searchStatusLabel.TabIndex = 7;
			this.searchStatusLabel.Text = "검색 중 ...";
			this.searchStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// webtoonDirectURLTextBox
			// 
			this.webtoonDirectURLTextBox.BackColor = System.Drawing.Color.White;
			this.webtoonDirectURLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.webtoonDirectURLTextBox.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonDirectURLTextBox.Location = new System.Drawing.Point(22, 192);
			this.webtoonDirectURLTextBox.Name = "webtoonDirectURLTextBox";
			this.webtoonDirectURLTextBox.Size = new System.Drawing.Size(460, 27);
			this.webtoonDirectURLTextBox.TabIndex = 10;
			this.webtoonDirectURLTextBox.WordWrap = false;
			this.webtoonDirectURLTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.webtoonDirectURLTextBox_KeyDown);
			// 
			// searchMasterPanel
			// 
			this.searchMasterPanel.BackColor = System.Drawing.Color.Transparent;
			this.searchMasterPanel.Controls.Add(this.searchIcon);
			this.searchMasterPanel.Controls.Add(this.searchMasterPanelDescription);
			this.searchMasterPanel.Controls.Add(this.webtoonDirectURLTitleLabel);
			this.searchMasterPanel.Controls.Add(this.searchTextBox);
			this.searchMasterPanel.Controls.Add(this.webtoonDirectURLTextBox);
			this.searchMasterPanel.Controls.Add(this.searchButton);
			this.searchMasterPanel.Controls.Add(this.searchTitleLabel);
			this.searchMasterPanel.Location = new System.Drawing.Point(13, 46);
			this.searchMasterPanel.Name = "searchMasterPanel";
			this.searchMasterPanel.Size = new System.Drawing.Size(776, 299);
			this.searchMasterPanel.TabIndex = 11;
			// 
			// searchIcon
			// 
			this.searchIcon.Image = global::WebtoonDownloader.Properties.Resources.searchIcon;
			this.searchIcon.Location = new System.Drawing.Point(523, 25);
			this.searchIcon.Name = "searchIcon";
			this.searchIcon.Size = new System.Drawing.Size(250, 200);
			this.searchIcon.TabIndex = 14;
			this.searchIcon.TabStop = false;
			// 
			// searchMasterPanelDescription
			// 
			this.searchMasterPanelDescription.AutoSize = true;
			this.searchMasterPanelDescription.BackColor = System.Drawing.Color.Transparent;
			this.searchMasterPanelDescription.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.searchMasterPanelDescription.Location = new System.Drawing.Point(15, 14);
			this.searchMasterPanelDescription.Name = "searchMasterPanelDescription";
			this.searchMasterPanelDescription.Size = new System.Drawing.Size(460, 21);
			this.searchMasterPanelDescription.TabIndex = 13;
			this.searchMasterPanelDescription.Text = "다운로드 할 웹툰을 선택해야 합니다, 해당 웹툰을 검색하세요.";
			// 
			// webtoonDirectURLTitleLabel
			// 
			this.webtoonDirectURLTitleLabel.AutoSize = true;
			this.webtoonDirectURLTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.webtoonDirectURLTitleLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.webtoonDirectURLTitleLabel.Location = new System.Drawing.Point(19, 170);
			this.webtoonDirectURLTitleLabel.Name = "webtoonDirectURLTitleLabel";
			this.webtoonDirectURLTitleLabel.Size = new System.Drawing.Size(115, 15);
			this.webtoonDirectURLTitleLabel.TabIndex = 11;
			this.webtoonDirectURLTitleLabel.Text = "또는 웹툰 주소 입력";
			// 
			// searchResultPanel
			// 
			this.searchResultPanel.BackColor = System.Drawing.Color.Transparent;
			this.searchResultPanel.Controls.Add(this.webtoonSearchResultList);
			this.searchResultPanel.Controls.Add(this.researchButton);
			this.searchResultPanel.Controls.Add(this.searchStatusLabel);
			this.searchResultPanel.Location = new System.Drawing.Point(13, 46);
			this.searchResultPanel.Name = "searchResultPanel";
			this.searchResultPanel.Size = new System.Drawing.Size(776, 617);
			this.searchResultPanel.TabIndex = 12;
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
			this.APP_TITLE.Size = new System.Drawing.Size(166, 17);
			this.APP_TITLE.TabIndex = 0;
			this.APP_TITLE.Text = "다운로드 할 웹툰 찾아보기";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// searchButton
			// 
			this.searchButton.AnimationLerpP = 0.8F;
			this.searchButton.BackColor = System.Drawing.Color.Transparent;
			this.searchButton.ButtonText = "검색";
			this.searchButton.ButtonTextColor = System.Drawing.Color.Black;
			this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.searchButton.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.searchButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.searchButton.Location = new System.Drawing.Point(563, 247);
			this.searchButton.Name = "searchButton";
			this.searchButton.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.searchButton.Size = new System.Drawing.Size(210, 50);
			this.searchButton.TabIndex = 9;
			this.searchButton.Text = "검색";
			this.searchButton.UseVisualStyleBackColor = false;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// researchButton
			// 
			this.researchButton.AnimationLerpP = 0.8F;
			this.researchButton.BackColor = System.Drawing.Color.Transparent;
			this.researchButton.ButtonText = "다시 검색";
			this.researchButton.ButtonTextColor = System.Drawing.Color.Black;
			this.researchButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.researchButton.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.researchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.researchButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.researchButton.Location = new System.Drawing.Point(595, 2);
			this.researchButton.Name = "researchButton";
			this.researchButton.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.researchButton.Size = new System.Drawing.Size(180, 25);
			this.researchButton.TabIndex = 10;
			this.researchButton.Text = "다시 검색";
			this.researchButton.UseVisualStyleBackColor = false;
			this.researchButton.Click += new System.EventHandler(this.researchButton_Click);
			// 
			// WebtoonSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 675);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.searchMasterPanel);
			this.Controls.Add(this.searchResultPanel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WebtoonSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "웹툰 다운로더 - 다운로드 할 웹툰 찾아보기";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WebtoonSearch_FormClosed);
			this.Load += new System.EventHandler(this.WebtoonSearch_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.WebtoonSearch_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).EndInit();
			this.searchMasterPanel.ResumeLayout(false);
			this.searchMasterPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
			this.searchResultPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private FlatImageButton CLOSE_BUTTON;
		private System.Windows.Forms.PictureBox APP_LOGO;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.Panel webtoonSearchResultList;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Label searchTitleLabel;
		private FlatButton searchButton;
		private System.Windows.Forms.Label searchStatusLabel;
		private System.Windows.Forms.TextBox webtoonDirectURLTextBox;
		private System.Windows.Forms.Panel searchMasterPanel;
		private System.Windows.Forms.Label webtoonDirectURLTitleLabel;
		private System.Windows.Forms.Label searchMasterPanelDescription;
		private System.Windows.Forms.Panel searchResultPanel;
		private FlatButton researchButton;
		private System.Windows.Forms.PictureBox searchIcon;
	}
}