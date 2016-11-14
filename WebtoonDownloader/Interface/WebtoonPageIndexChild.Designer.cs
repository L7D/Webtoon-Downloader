namespace WebtoonDownloader.Interface
{
	partial class WebtoonPageIndexChild
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
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent( )
		{
			this.INDEX_BUTTON = new WebtoonDownloader.Interface.FlatButton();
			this.SuspendLayout();
			// 
			// INDEX_BUTTON
			// 
			this.INDEX_BUTTON.AnimationLerpP = 0.8F;
			this.INDEX_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.INDEX_BUTTON.ButtonText = "1";
			this.INDEX_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.INDEX_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.INDEX_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.INDEX_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.INDEX_BUTTON.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.INDEX_BUTTON.Location = new System.Drawing.Point(0, 0);
			this.INDEX_BUTTON.Name = "INDEX_BUTTON";
			this.INDEX_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.INDEX_BUTTON.Size = new System.Drawing.Size(40, 30);
			this.INDEX_BUTTON.TabIndex = 15;
			this.INDEX_BUTTON.Text = "1";
			this.INDEX_BUTTON.UseVisualStyleBackColor = false;
			this.INDEX_BUTTON.Click += new System.EventHandler(this.INDEX_BUTTON_Click);
			// 
			// WebtoonPageIndexChild
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.INDEX_BUTTON);
			this.Name = "WebtoonPageIndexChild";
			this.Size = new System.Drawing.Size(40, 30);
			this.ResumeLayout(false);

		}

		#endregion

		private FlatButton INDEX_BUTTON;
	}
}
