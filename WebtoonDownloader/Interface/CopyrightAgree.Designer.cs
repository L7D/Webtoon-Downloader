namespace WebtoonDownloader.Interface
{
	partial class CopyrightAgree
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyrightAgree));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.copyrightLabelTitle = new System.Windows.Forms.Label();
			this.copyrightHTMLText = new System.Windows.Forms.WebBrowser();
			this.lawIcon = new System.Windows.Forms.PictureBox();
			this.APP_LOGO = new System.Windows.Forms.PictureBox();
			this.licenseDetailShowButton = new WebtoonDownloader.Interface.FlatButton();
			this.showAnotherLanguageButton = new WebtoonDownloader.Interface.FlatButton();
			this.DISAGREE_BUTTON = new WebtoonDownloader.Interface.FlatButton();
			this.AGREE_BUTTON = new WebtoonDownloader.Interface.FlatButton();
			this.APP_TITLE = new WebtoonDownloader.Interface.CustomLabel();
			this.CLOSE_BUTTON = new WebtoonDownloader.Interface.FlatImageButton();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lawIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add(this.APP_LOGO);
			this.APP_TITLE_BAR.Controls.Add(this.APP_TITLE);
			this.APP_TITLE_BAR.Controls.Add(this.CLOSE_BUTTON);
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(600, 40);
			this.APP_TITLE_BAR.TabIndex = 1;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			// 
			// copyrightLabelTitle
			// 
			this.copyrightLabelTitle.AutoSize = true;
			this.copyrightLabelTitle.BackColor = System.Drawing.Color.Transparent;
			this.copyrightLabelTitle.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.copyrightLabelTitle.Location = new System.Drawing.Point(55, 58);
			this.copyrightLabelTitle.Name = "copyrightLabelTitle";
			this.copyrightLabelTitle.Size = new System.Drawing.Size(529, 17);
			this.copyrightLabelTitle.TabIndex = 9;
			this.copyrightLabelTitle.Text = "아래의 중요한 사용권 안내문을 읽으시고 동의를 해야 프로그램을 사용하실 수 있습니다.";
			// 
			// copyrightHTMLText
			// 
			this.copyrightHTMLText.AllowNavigation = false;
			this.copyrightHTMLText.AllowWebBrowserDrop = false;
			this.copyrightHTMLText.IsWebBrowserContextMenuEnabled = false;
			this.copyrightHTMLText.Location = new System.Drawing.Point(12, 90);
			this.copyrightHTMLText.MinimumSize = new System.Drawing.Size(20, 20);
			this.copyrightHTMLText.Name = "copyrightHTMLText";
			this.copyrightHTMLText.ScriptErrorsSuppressed = true;
			this.copyrightHTMLText.ScrollBarsEnabled = false;
			this.copyrightHTMLText.Size = new System.Drawing.Size(576, 365);
			this.copyrightHTMLText.TabIndex = 10;
			this.copyrightHTMLText.WebBrowserShortcutsEnabled = false;
			// 
			// lawIcon
			// 
			this.lawIcon.BackColor = System.Drawing.Color.Transparent;
			this.lawIcon.Cursor = System.Windows.Forms.Cursors.Default;
			this.lawIcon.Image = global::WebtoonDownloader.Properties.Resources.lawWarning;
			this.lawIcon.Location = new System.Drawing.Point(12, 50);
			this.lawIcon.Name = "lawIcon";
			this.lawIcon.Size = new System.Drawing.Size(30, 30);
			this.lawIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.lawIcon.TabIndex = 5;
			this.lawIcon.TabStop = false;
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
			// licenseDetailShowButton
			// 
			this.licenseDetailShowButton.AnimationLerpP = 0.8F;
			this.licenseDetailShowButton.BackColor = System.Drawing.Color.Transparent;
			this.licenseDetailShowButton.ButtonText = "사용권에 대한 자세한 정보 보기";
			this.licenseDetailShowButton.ButtonTextColor = System.Drawing.Color.Black;
			this.licenseDetailShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.licenseDetailShowButton.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.licenseDetailShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.licenseDetailShowButton.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.licenseDetailShowButton.Location = new System.Drawing.Point(12, 462);
			this.licenseDetailShowButton.Name = "licenseDetailShowButton";
			this.licenseDetailShowButton.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.licenseDetailShowButton.Size = new System.Drawing.Size(191, 25);
			this.licenseDetailShowButton.TabIndex = 11;
			this.licenseDetailShowButton.Text = "사용권에 대한 자세한 정보 보기";
			this.licenseDetailShowButton.UseVisualStyleBackColor = false;
			this.licenseDetailShowButton.Click += new System.EventHandler(this.licenseDetailShowButton_Click);
			// 
			// showAnotherLanguageButton
			// 
			this.showAnotherLanguageButton.AnimationLerpP = 0.8F;
			this.showAnotherLanguageButton.BackColor = System.Drawing.Color.Transparent;
			this.showAnotherLanguageButton.ButtonText = "사용권 한글 번역본 보기";
			this.showAnotherLanguageButton.ButtonTextColor = System.Drawing.Color.Black;
			this.showAnotherLanguageButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.showAnotherLanguageButton.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.showAnotherLanguageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.showAnotherLanguageButton.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.showAnotherLanguageButton.Location = new System.Drawing.Point(12, 493);
			this.showAnotherLanguageButton.Name = "showAnotherLanguageButton";
			this.showAnotherLanguageButton.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.showAnotherLanguageButton.Size = new System.Drawing.Size(191, 25);
			this.showAnotherLanguageButton.TabIndex = 8;
			this.showAnotherLanguageButton.Text = "사용권 한글 번역본 보기";
			this.showAnotherLanguageButton.UseVisualStyleBackColor = false;
			this.showAnotherLanguageButton.Click += new System.EventHandler(this.showAnotherLanguageButton_Click);
			// 
			// DISAGREE_BUTTON
			// 
			this.DISAGREE_BUTTON.AnimationLerpP = 0.8F;
			this.DISAGREE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.DISAGREE_BUTTON.ButtonText = "프로그램 종료";
			this.DISAGREE_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.DISAGREE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DISAGREE_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.DarkOrange;
			this.DISAGREE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DISAGREE_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.DISAGREE_BUTTON.Location = new System.Drawing.Point(242, 488);
			this.DISAGREE_BUTTON.Name = "DISAGREE_BUTTON";
			this.DISAGREE_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.Orange;
			this.DISAGREE_BUTTON.Size = new System.Drawing.Size(150, 30);
			this.DISAGREE_BUTTON.TabIndex = 7;
			this.DISAGREE_BUTTON.Text = "프로그램 종료";
			this.DISAGREE_BUTTON.UseVisualStyleBackColor = false;
			this.DISAGREE_BUTTON.Click += new System.EventHandler(this.DISAGREE_BUTTON_Click);
			// 
			// AGREE_BUTTON
			// 
			this.AGREE_BUTTON.AnimationLerpP = 0.8F;
			this.AGREE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.AGREE_BUTTON.ButtonText = "동의";
			this.AGREE_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.AGREE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AGREE_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.AGREE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AGREE_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AGREE_BUTTON.Location = new System.Drawing.Point(398, 488);
			this.AGREE_BUTTON.Name = "AGREE_BUTTON";
			this.AGREE_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.AGREE_BUTTON.Size = new System.Drawing.Size(190, 30);
			this.AGREE_BUTTON.TabIndex = 6;
			this.AGREE_BUTTON.Text = "동의";
			this.AGREE_BUTTON.UseVisualStyleBackColor = false;
			this.AGREE_BUTTON.Click += new System.EventHandler(this.AGREE_BUTTON_Click);
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
			this.APP_TITLE.Text = "웹툰 다운로더 사용권 동의";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
			this.CLOSE_BUTTON.TabIndex = 4;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// CopyrightAgree
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(600, 530);
			this.Controls.Add(this.licenseDetailShowButton);
			this.Controls.Add(this.copyrightHTMLText);
			this.Controls.Add(this.copyrightLabelTitle);
			this.Controls.Add(this.showAnotherLanguageButton);
			this.Controls.Add(this.DISAGREE_BUTTON);
			this.Controls.Add(this.AGREE_BUTTON);
			this.Controls.Add(this.lawIcon);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CopyrightAgree";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "웹툰 다운로더 - 사용권 동의";
			this.Load += new System.EventHandler(this.CopyrightAgree_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.CopyrightAgree_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lawIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.PictureBox APP_LOGO;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox lawIcon;
		private FlatImageButton CLOSE_BUTTON;
		private FlatButton AGREE_BUTTON;
		private FlatButton DISAGREE_BUTTON;
		private FlatButton showAnotherLanguageButton;
		private System.Windows.Forms.Label copyrightLabelTitle;
		private System.Windows.Forms.WebBrowser copyrightHTMLText;
		private FlatButton licenseDetailShowButton;
	}
}