namespace WebtoonStoreForm.Interface
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
			this.copyrightText = new System.Windows.Forms.Label();
			this.lawIcon = new System.Windows.Forms.PictureBox();
			this.APP_LOGO = new System.Windows.Forms.PictureBox();
			this.DISAGREE_BUTTON = new WebtoonStoreForm.Interface.FlatButton();
			this.AGREE_BUTTON = new WebtoonStoreForm.Interface.FlatButton();
			this.APP_TITLE = new WebtoonStoreForm.Interface.CustomLabel();
			this.CLOSE_BUTTON = new WebtoonStoreForm.Interface.FlatImageButton();
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
			// copyrightText
			// 
			this.copyrightText.BackColor = System.Drawing.Color.Transparent;
			this.copyrightText.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.copyrightText.ForeColor = System.Drawing.SystemColors.ControlText;
			this.copyrightText.Location = new System.Drawing.Point(12, 55);
			this.copyrightText.Name = "copyrightText";
			this.copyrightText.Size = new System.Drawing.Size(420, 150);
			this.copyrightText.TabIndex = 2;
			this.copyrightText.Text = "이 프로그램은 다운받은 웹툰의 개인 소장 용으로만 사용하셔야 합니다.\r\n이 프로그램의 불법적인 사용으로 인하여 발생되는 모든 법적 문제는 사용자 " +
    "본인의 책임입니다.\r\n\r\n마지막 작성일 : 2016-11-09";
			// 
			// lawIcon
			// 
			this.lawIcon.BackColor = System.Drawing.Color.Transparent;
			this.lawIcon.Cursor = System.Windows.Forms.Cursors.Default;
			this.lawIcon.Image = global::WebtoonStoreForm.Properties.Resources.law;
			this.lawIcon.Location = new System.Drawing.Point(438, 55);
			this.lawIcon.Name = "lawIcon";
			this.lawIcon.Size = new System.Drawing.Size(150, 150);
			this.lawIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.lawIcon.TabIndex = 5;
			this.lawIcon.TabStop = false;
			// 
			// APP_LOGO
			// 
			this.APP_LOGO.BackColor = System.Drawing.Color.Transparent;
			this.APP_LOGO.Cursor = System.Windows.Forms.Cursors.Default;
			this.APP_LOGO.Image = global::WebtoonStoreForm.Properties.Resources.APP_ICON_30x30;
			this.APP_LOGO.Location = new System.Drawing.Point(5, 5);
			this.APP_LOGO.Name = "APP_LOGO";
			this.APP_LOGO.Size = new System.Drawing.Size(30, 30);
			this.APP_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.APP_LOGO.TabIndex = 3;
			this.APP_LOGO.TabStop = false;
			// 
			// DISAGREE_BUTTON
			// 
			this.DISAGREE_BUTTON.AnimationLerpP = 0.8F;
			this.DISAGREE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.DISAGREE_BUTTON.ButtonText = "동의 안 함";
			this.DISAGREE_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.DISAGREE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DISAGREE_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.DISAGREE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DISAGREE_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.DISAGREE_BUTTON.Location = new System.Drawing.Point(282, 213);
			this.DISAGREE_BUTTON.Name = "DISAGREE_BUTTON";
			this.DISAGREE_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.DISAGREE_BUTTON.Size = new System.Drawing.Size(150, 25);
			this.DISAGREE_BUTTON.TabIndex = 7;
			this.DISAGREE_BUTTON.Text = "동의 안 함";
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
			this.AGREE_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AGREE_BUTTON.Location = new System.Drawing.Point(438, 213);
			this.AGREE_BUTTON.Name = "AGREE_BUTTON";
			this.AGREE_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.AGREE_BUTTON.Size = new System.Drawing.Size(150, 25);
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
			this.APP_TITLE.Size = new System.Drawing.Size(153, 17);
			this.APP_TITLE.TabIndex = 0;
			this.APP_TITLE.Text = "웹툰 다운로더 사용 동의";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.AnimationLerpP = 0.8F;
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.IndianRed;
			this.CLOSE_BUTTON.Image = global::WebtoonStoreForm.Properties.Resources.close;
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
			this.ClientSize = new System.Drawing.Size(600, 250);
			this.Controls.Add(this.DISAGREE_BUTTON);
			this.Controls.Add(this.AGREE_BUTTON);
			this.Controls.Add(this.lawIcon);
			this.Controls.Add(this.copyrightText);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CopyrightAgree";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "웹툰 다운로더 - 사용 동의 ";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.CopyrightAgree_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lawIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.PictureBox APP_LOGO;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.Label copyrightText;
		private System.Windows.Forms.PictureBox lawIcon;
		private FlatImageButton CLOSE_BUTTON;
		private FlatButton AGREE_BUTTON;
		private FlatButton DISAGREE_BUTTON;
	}
}