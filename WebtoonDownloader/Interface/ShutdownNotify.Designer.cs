namespace WebtoonDownloader.Interface
{
	partial class ShutdownNotify
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutdownNotify));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.CLOSE_BUTTON = new WebtoonDownloader.Interface.FlatImageButton();
			this.APP_LOGO = new System.Windows.Forms.PictureBox();
			this.APP_TITLE = new WebtoonDownloader.Interface.CustomLabel();
			this.warningNotify = new System.Windows.Forms.Label();
			this.warningIcon = new System.Windows.Forms.PictureBox();
			this.CANCEL_SYSTEM_SHUTDOWN = new WebtoonDownloader.Interface.FlatButton();
			this.systemShutdownCount = new System.Windows.Forms.Label();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.warningIcon)).BeginInit();
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
			this.APP_TITLE_BAR.TabIndex = 2;
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
			this.APP_TITLE.Size = new System.Drawing.Size(109, 17);
			this.APP_TITLE.TabIndex = 0;
			this.APP_TITLE.Text = "시스템 종료 알림";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// warningNotify
			// 
			this.warningNotify.AutoSize = true;
			this.warningNotify.BackColor = System.Drawing.Color.Transparent;
			this.warningNotify.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.warningNotify.Location = new System.Drawing.Point(65, 60);
			this.warningNotify.Name = "warningNotify";
			this.warningNotify.Size = new System.Drawing.Size(363, 20);
			this.warningNotify.TabIndex = 3;
			this.warningNotify.Text = "다운로드가 모두 완료되었으며 시스템이 종료됩니다.";
			// 
			// warningIcon
			// 
			this.warningIcon.BackColor = System.Drawing.Color.Transparent;
			this.warningIcon.Cursor = System.Windows.Forms.Cursors.Default;
			this.warningIcon.Image = global::WebtoonDownloader.Properties.Resources.lawWarning;
			this.warningIcon.Location = new System.Drawing.Point(15, 55);
			this.warningIcon.Name = "warningIcon";
			this.warningIcon.Size = new System.Drawing.Size(30, 30);
			this.warningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.warningIcon.TabIndex = 6;
			this.warningIcon.TabStop = false;
			// 
			// CANCEL_SYSTEM_SHUTDOWN
			// 
			this.CANCEL_SYSTEM_SHUTDOWN.AnimationLerpP = 0.8F;
			this.CANCEL_SYSTEM_SHUTDOWN.BackColor = System.Drawing.Color.Transparent;
			this.CANCEL_SYSTEM_SHUTDOWN.ButtonText = "시스템 종료 취소";
			this.CANCEL_SYSTEM_SHUTDOWN.ButtonTextColor = System.Drawing.Color.Black;
			this.CANCEL_SYSTEM_SHUTDOWN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CANCEL_SYSTEM_SHUTDOWN.EnterStateBackgroundColor = System.Drawing.Color.DarkOrange;
			this.CANCEL_SYSTEM_SHUTDOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CANCEL_SYSTEM_SHUTDOWN.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CANCEL_SYSTEM_SHUTDOWN.Location = new System.Drawing.Point(208, 108);
			this.CANCEL_SYSTEM_SHUTDOWN.Name = "CANCEL_SYSTEM_SHUTDOWN";
			this.CANCEL_SYSTEM_SHUTDOWN.NormalStateBackgroundColor = System.Drawing.Color.Orange;
			this.CANCEL_SYSTEM_SHUTDOWN.Size = new System.Drawing.Size(240, 30);
			this.CANCEL_SYSTEM_SHUTDOWN.TabIndex = 7;
			this.CANCEL_SYSTEM_SHUTDOWN.Text = "시스템 종료 취소";
			this.CANCEL_SYSTEM_SHUTDOWN.UseVisualStyleBackColor = false;
			this.CANCEL_SYSTEM_SHUTDOWN.Click += new System.EventHandler(this.CANCEL_SYSTEM_SHUTDOWN_Click);
			// 
			// systemShutdownCount
			// 
			this.systemShutdownCount.BackColor = System.Drawing.Color.Transparent;
			this.systemShutdownCount.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.systemShutdownCount.Location = new System.Drawing.Point(12, 108);
			this.systemShutdownCount.Name = "systemShutdownCount";
			this.systemShutdownCount.Size = new System.Drawing.Size(190, 30);
			this.systemShutdownCount.TabIndex = 8;
			this.systemShutdownCount.Text = "60초 후 시스템이 종료됩니다.";
			this.systemShutdownCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ShutdownNotify
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(460, 150);
			this.Controls.Add(this.systemShutdownCount);
			this.Controls.Add(this.CANCEL_SYSTEM_SHUTDOWN);
			this.Controls.Add(this.warningIcon);
			this.Controls.Add(this.warningNotify);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ShutdownNotify";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "웹툰 다운로더 - 시스템 종료 알림";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.ShutdownNotify_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShutdownNotify_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.warningIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private FlatImageButton CLOSE_BUTTON;
		private System.Windows.Forms.PictureBox APP_LOGO;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.Label warningNotify;
		private System.Windows.Forms.PictureBox warningIcon;
		private FlatButton CANCEL_SYSTEM_SHUTDOWN;
		private System.Windows.Forms.Label systemShutdownCount;
	}
}