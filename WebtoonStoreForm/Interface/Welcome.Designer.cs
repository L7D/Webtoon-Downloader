namespace WebtoonStoreForm.Interface
{
	partial class Welcome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
			this.programIcon = new System.Windows.Forms.PictureBox();
			this.programTitle = new System.Windows.Forms.Label();
			this.programAuthor = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.programIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// programIcon
			// 
			this.programIcon.BackColor = System.Drawing.Color.Transparent;
			this.programIcon.Cursor = System.Windows.Forms.Cursors.Default;
			this.programIcon.Image = global::WebtoonStoreForm.Properties.Resources.APP_ICON_150x150;
			this.programIcon.Location = new System.Drawing.Point(125, 20);
			this.programIcon.Name = "programIcon";
			this.programIcon.Size = new System.Drawing.Size(150, 150);
			this.programIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.programIcon.TabIndex = 6;
			this.programIcon.TabStop = false;
			// 
			// programTitle
			// 
			this.programTitle.BackColor = System.Drawing.Color.Transparent;
			this.programTitle.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.programTitle.Location = new System.Drawing.Point(0, 185);
			this.programTitle.Name = "programTitle";
			this.programTitle.Size = new System.Drawing.Size(400, 30);
			this.programTitle.TabIndex = 7;
			this.programTitle.Text = "웹툰 다운로더";
			this.programTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// programAuthor
			// 
			this.programAuthor.BackColor = System.Drawing.Color.Transparent;
			this.programAuthor.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.programAuthor.Location = new System.Drawing.Point(0, 215);
			this.programAuthor.Name = "programAuthor";
			this.programAuthor.Size = new System.Drawing.Size(400, 30);
			this.programAuthor.TabIndex = 8;
			this.programAuthor.Text = "Copyright © DeveloFOX Studio (L7D) 2016";
			this.programAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Welcome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(400, 250);
			this.Controls.Add(this.programAuthor);
			this.Controls.Add(this.programTitle);
			this.Controls.Add(this.programIcon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Welcome";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "웹툰 다운로더 - 환영합니다";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Welcome_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Welcome_Paint);
			((System.ComponentModel.ISupportInitialize)(this.programIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox programIcon;
		private System.Windows.Forms.Label programTitle;
		private System.Windows.Forms.Label programAuthor;
	}
}