namespace WebtoonDownloader.Interface
{
	partial class UpdateNotifyForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateNotifyForm));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.CLOSE_BUTTON = new WebtoonDownloader.Interface.FlatImageButton();
			this.APP_LOGO = new System.Windows.Forms.PictureBox();
			this.APP_TITLE = new WebtoonDownloader.Interface.CustomLabel();
			this.updateLogHTMLText = new System.Windows.Forms.WebBrowser();
			this.UPDATE_BUTTON = new WebtoonDownloader.Interface.FlatButton();
			this.UPDATE_LATER_BUTTON = new WebtoonDownloader.Interface.FlatButton();
			this.updateLabelTitle = new System.Windows.Forms.Label();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).BeginInit();
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
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(600, 40);
			this.APP_TITLE_BAR.TabIndex = 3;
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
			this.APP_TITLE.Size = new System.Drawing.Size(91, 17);
			this.APP_TITLE.TabIndex = 0;
			this.APP_TITLE.Text = "업데이트 알림";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// updateLogHTMLText
			// 
			this.updateLogHTMLText.AllowNavigation = false;
			this.updateLogHTMLText.AllowWebBrowserDrop = false;
			this.updateLogHTMLText.IsWebBrowserContextMenuEnabled = false;
			this.updateLogHTMLText.Location = new System.Drawing.Point(12, 87);
			this.updateLogHTMLText.MinimumSize = new System.Drawing.Size(20, 20);
			this.updateLogHTMLText.Name = "updateLogHTMLText";
			this.updateLogHTMLText.ScriptErrorsSuppressed = true;
			this.updateLogHTMLText.Size = new System.Drawing.Size(576, 365);
			this.updateLogHTMLText.TabIndex = 11;
			this.updateLogHTMLText.WebBrowserShortcutsEnabled = false;
			// 
			// UPDATE_BUTTON
			// 
			this.UPDATE_BUTTON.AnimationLerpP = 0.8F;
			this.UPDATE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.UPDATE_BUTTON.ButtonText = "지금 다운로드";
			this.UPDATE_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.UPDATE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UPDATE_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.UPDATE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UPDATE_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.UPDATE_BUTTON.Location = new System.Drawing.Point(398, 458);
			this.UPDATE_BUTTON.Name = "UPDATE_BUTTON";
			this.UPDATE_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.UPDATE_BUTTON.Size = new System.Drawing.Size(190, 30);
			this.UPDATE_BUTTON.TabIndex = 12;
			this.UPDATE_BUTTON.Text = "지금 다운로드";
			this.UPDATE_BUTTON.UseVisualStyleBackColor = false;
			this.UPDATE_BUTTON.Click += new System.EventHandler(this.UPDATE_BUTTON_Click);
			// 
			// UPDATE_LATER_BUTTON
			// 
			this.UPDATE_LATER_BUTTON.AnimationLerpP = 0.8F;
			this.UPDATE_LATER_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.UPDATE_LATER_BUTTON.ButtonText = "나중에";
			this.UPDATE_LATER_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.UPDATE_LATER_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UPDATE_LATER_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.UPDATE_LATER_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UPDATE_LATER_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.UPDATE_LATER_BUTTON.Location = new System.Drawing.Point(202, 458);
			this.UPDATE_LATER_BUTTON.Name = "UPDATE_LATER_BUTTON";
			this.UPDATE_LATER_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.UPDATE_LATER_BUTTON.Size = new System.Drawing.Size(190, 30);
			this.UPDATE_LATER_BUTTON.TabIndex = 13;
			this.UPDATE_LATER_BUTTON.Text = "나중에";
			this.UPDATE_LATER_BUTTON.UseVisualStyleBackColor = false;
			this.UPDATE_LATER_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// updateLabelTitle
			// 
			this.updateLabelTitle.AutoSize = true;
			this.updateLabelTitle.BackColor = System.Drawing.Color.Transparent;
			this.updateLabelTitle.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.updateLabelTitle.Location = new System.Drawing.Point(48, 55);
			this.updateLabelTitle.Name = "updateLabelTitle";
			this.updateLabelTitle.Size = new System.Drawing.Size(504, 17);
			this.updateLabelTitle.TabIndex = 14;
			this.updateLabelTitle.Text = "새로운 버전의 웹툰 다운로더를 사용하실 수 있습니다, 지금 다운로드 하시겠습니까?";
			// 
			// UpdateNotifyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(600, 500);
			this.Controls.Add(this.updateLabelTitle);
			this.Controls.Add(this.UPDATE_LATER_BUTTON);
			this.Controls.Add(this.UPDATE_BUTTON);
			this.Controls.Add(this.updateLogHTMLText);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UpdateNotifyForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "웹툰 다운로더 - 업데이트 알림";
			this.Load += new System.EventHandler(this.UpdateNotifyForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateNotifyForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private FlatImageButton CLOSE_BUTTON;
		private System.Windows.Forms.PictureBox APP_LOGO;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.WebBrowser updateLogHTMLText;
		private FlatButton UPDATE_BUTTON;
		private FlatButton UPDATE_LATER_BUTTON;
		private System.Windows.Forms.Label updateLabelTitle;
	}
}