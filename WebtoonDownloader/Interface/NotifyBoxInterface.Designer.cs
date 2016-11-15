namespace WebtoonDownloader.Interface
{
	partial class NotifyBoxInterface
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyBoxInterface));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.TITLE_LABEL = new WebtoonDownloader.Interface.CustomLabel();
			this.MESSAGE_LABEL = new System.Windows.Forms.Label();
			this.TYPE_ICON = new System.Windows.Forms.PictureBox();
			this.Yes_Button = new WebtoonDownloader.Interface.FlatButton();
			this.NO_Button = new WebtoonDownloader.Interface.FlatButton();
			this.OK_Button = new WebtoonDownloader.Interface.FlatButton();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TYPE_ICON)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add(this.TITLE_LABEL);
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(500, 30);
			this.APP_TITLE_BAR.TabIndex = 10;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			// 
			// TITLE_LABEL
			// 
			this.TITLE_LABEL.AutoSize = true;
			this.TITLE_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.TITLE_LABEL.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TITLE_LABEL.Location = new System.Drawing.Point(8, 7);
			this.TITLE_LABEL.Name = "TITLE_LABEL";
			this.TITLE_LABEL.Size = new System.Drawing.Size(31, 15);
			this.TITLE_LABEL.TabIndex = 0;
			this.TITLE_LABEL.Text = "안내";
			this.TITLE_LABEL.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// MESSAGE_LABEL
			// 
			this.MESSAGE_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.MESSAGE_LABEL.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.MESSAGE_LABEL.Location = new System.Drawing.Point(80, 40);
			this.MESSAGE_LABEL.Name = "MESSAGE_LABEL";
			this.MESSAGE_LABEL.Size = new System.Drawing.Size(408, 70);
			this.MESSAGE_LABEL.TabIndex = 11;
			this.MESSAGE_LABEL.Text = "메세지";
			this.MESSAGE_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TYPE_ICON
			// 
			this.TYPE_ICON.BackColor = System.Drawing.Color.Transparent;
			this.TYPE_ICON.Image = global::WebtoonDownloader.Properties.Resources.WARNING_ICON;
			this.TYPE_ICON.Location = new System.Drawing.Point(15, 50);
			this.TYPE_ICON.Name = "TYPE_ICON";
			this.TYPE_ICON.Size = new System.Drawing.Size(50, 50);
			this.TYPE_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.TYPE_ICON.TabIndex = 15;
			this.TYPE_ICON.TabStop = false;
			// 
			// Yes_Button
			// 
			this.Yes_Button.AnimationLerpP = 0.8F;
			this.Yes_Button.BackColor = System.Drawing.Color.Transparent;
			this.Yes_Button.ButtonText = "확인";
			this.Yes_Button.ButtonTextColor = System.Drawing.Color.Black;
			this.Yes_Button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Yes_Button.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.Yes_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Yes_Button.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Yes_Button.Location = new System.Drawing.Point(282, 113);
			this.Yes_Button.Name = "Yes_Button";
			this.Yes_Button.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.Yes_Button.Size = new System.Drawing.Size(100, 25);
			this.Yes_Button.TabIndex = 16;
			this.Yes_Button.Text = "확인";
			this.Yes_Button.UseVisualStyleBackColor = false;
			this.Yes_Button.Click += new System.EventHandler(this.Yes_Button_Click);
			// 
			// NO_Button
			// 
			this.NO_Button.AnimationLerpP = 0.8F;
			this.NO_Button.BackColor = System.Drawing.Color.Transparent;
			this.NO_Button.ButtonText = "취소";
			this.NO_Button.ButtonTextColor = System.Drawing.Color.Black;
			this.NO_Button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NO_Button.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.NO_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NO_Button.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.NO_Button.Location = new System.Drawing.Point(388, 113);
			this.NO_Button.Name = "NO_Button";
			this.NO_Button.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.NO_Button.Size = new System.Drawing.Size(100, 25);
			this.NO_Button.TabIndex = 17;
			this.NO_Button.Text = "취소";
			this.NO_Button.UseVisualStyleBackColor = false;
			this.NO_Button.Click += new System.EventHandler(this.NO_Button_Click);
			// 
			// OK_Button
			// 
			this.OK_Button.AnimationLerpP = 0.8F;
			this.OK_Button.BackColor = System.Drawing.Color.Transparent;
			this.OK_Button.ButtonText = "확인";
			this.OK_Button.ButtonTextColor = System.Drawing.Color.Black;
			this.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OK_Button.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OK_Button.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OK_Button.Location = new System.Drawing.Point(388, 113);
			this.OK_Button.Name = "OK_Button";
			this.OK_Button.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.OK_Button.Size = new System.Drawing.Size(100, 25);
			this.OK_Button.TabIndex = 18;
			this.OK_Button.Text = "확인";
			this.OK_Button.UseVisualStyleBackColor = false;
			this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
			// 
			// NotifyBoxInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(500, 150);
			this.Controls.Add(this.OK_Button);
			this.Controls.Add(this.NO_Button);
			this.Controls.Add(this.Yes_Button);
			this.Controls.Add(this.TYPE_ICON);
			this.Controls.Add(this.MESSAGE_LABEL);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NotifyBoxInterface";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "웹툰 다운로더 - 알림";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.NotifyBoxInterface_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.NotifyBoxInterface_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TYPE_ICON)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.Label MESSAGE_LABEL;
		private System.Windows.Forms.PictureBox TYPE_ICON;
		private CustomLabel TITLE_LABEL;
		private FlatButton Yes_Button;
		private FlatButton NO_Button;
		private FlatButton OK_Button;
	}
}