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
			this.APP_TITLE_PANEL = new System.Windows.Forms.Panel();
			this.APP_LOGO = new System.Windows.Forms.PictureBox();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.APP_TITLE = new System.Windows.Forms.Label();
			this.copyrightText = new System.Windows.Forms.Label();
			this.AGREE_BUTTON = new System.Windows.Forms.Button();
			this.DISAGREE_BUTTON = new System.Windows.Forms.Button();
			this.APP_TITLE_PANEL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_PANEL
			// 
			this.APP_TITLE_PANEL.Controls.Add(this.APP_LOGO);
			this.APP_TITLE_PANEL.Controls.Add(this.CLOSE_BUTTON);
			this.APP_TITLE_PANEL.Controls.Add(this.APP_TITLE);
			this.APP_TITLE_PANEL.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_PANEL.Name = "APP_TITLE_PANEL";
			this.APP_TITLE_PANEL.Size = new System.Drawing.Size(600, 40);
			this.APP_TITLE_PANEL.TabIndex = 1;
			this.APP_TITLE_PANEL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_PANEL_MouseDown);
			this.APP_TITLE_PANEL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_PANEL_MouseMove);
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
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::WebtoonStoreForm.Properties.Resources.close;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(565, 5);
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.Size = new System.Drawing.Size(30, 30);
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CLOSE_BUTTON.TabIndex = 2;
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
			this.APP_TITLE.Size = new System.Drawing.Size(153, 17);
			this.APP_TITLE.TabIndex = 0;
			this.APP_TITLE.Text = "웹툰 다운로더 사용 동의";
			// 
			// copyrightText
			// 
			this.copyrightText.BackColor = System.Drawing.Color.Transparent;
			this.copyrightText.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.copyrightText.ForeColor = System.Drawing.SystemColors.ControlText;
			this.copyrightText.Location = new System.Drawing.Point(12, 60);
			this.copyrightText.Name = "copyrightText";
			this.copyrightText.Size = new System.Drawing.Size(576, 180);
			this.copyrightText.TabIndex = 2;
			this.copyrightText.Text = "이 프로그램은 다운받은 웹툰의 개인 소장 용으로만 사용하셔야 합니다.\r\n이 프로그램의 불법적인 사용으로 인하여 발생되는 모든 법적 문제는 사용자 " +
    "본인의 책임입니다.\r\n\r\n마지막 작성일 : 2016-11-09";
			// 
			// AGREE_BUTTON
			// 
			this.AGREE_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke;
			this.AGREE_BUTTON.FlatAppearance.BorderSize = 0;
			this.AGREE_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
			this.AGREE_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
			this.AGREE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AGREE_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AGREE_BUTTON.Location = new System.Drawing.Point(418, 265);
			this.AGREE_BUTTON.Name = "AGREE_BUTTON";
			this.AGREE_BUTTON.Size = new System.Drawing.Size(170, 23);
			this.AGREE_BUTTON.TabIndex = 3;
			this.AGREE_BUTTON.Text = "동의";
			this.AGREE_BUTTON.UseVisualStyleBackColor = false;
			this.AGREE_BUTTON.Click += new System.EventHandler(this.AGREE_BUTTON_Click);
			// 
			// DISAGREE_BUTTON
			// 
			this.DISAGREE_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke;
			this.DISAGREE_BUTTON.FlatAppearance.BorderSize = 0;
			this.DISAGREE_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
			this.DISAGREE_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
			this.DISAGREE_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DISAGREE_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.DISAGREE_BUTTON.Location = new System.Drawing.Point(242, 265);
			this.DISAGREE_BUTTON.Name = "DISAGREE_BUTTON";
			this.DISAGREE_BUTTON.Size = new System.Drawing.Size(170, 23);
			this.DISAGREE_BUTTON.TabIndex = 4;
			this.DISAGREE_BUTTON.Text = "동의 안함";
			this.DISAGREE_BUTTON.UseVisualStyleBackColor = false;
			this.DISAGREE_BUTTON.Click += new System.EventHandler(this.DISAGREE_BUTTON_Click);
			// 
			// CopyrightAgree
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(600, 300);
			this.Controls.Add(this.DISAGREE_BUTTON);
			this.Controls.Add(this.AGREE_BUTTON);
			this.Controls.Add(this.copyrightText);
			this.Controls.Add(this.APP_TITLE_PANEL);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CopyrightAgree";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "웹툰 다운로더";
			this.APP_TITLE_PANEL.ResumeLayout(false);
			this.APP_TITLE_PANEL.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.APP_LOGO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_PANEL;
		private System.Windows.Forms.PictureBox APP_LOGO;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.Label APP_TITLE;
		private System.Windows.Forms.Label copyrightText;
		private System.Windows.Forms.Button AGREE_BUTTON;
		private System.Windows.Forms.Button DISAGREE_BUTTON;
	}
}