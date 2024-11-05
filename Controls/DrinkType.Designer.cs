namespace Coffee_Kiosk.Controls
{
    partial class DrinkType
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.radio_hot = new System.Windows.Forms.RadioButton();
            this.radio_ice = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radio_hot
            // 
            this.radio_hot.AutoSize = true;
            this.radio_hot.Enabled = false;
            this.radio_hot.Font = new System.Drawing.Font("Pretendard", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radio_hot.Location = new System.Drawing.Point(70, 26);
            this.radio_hot.Name = "radio_hot";
            this.radio_hot.Size = new System.Drawing.Size(58, 22);
            this.radio_hot.TabIndex = 0;
            this.radio_hot.TabStop = true;
            this.radio_hot.Text = "HOT";
            this.radio_hot.UseVisualStyleBackColor = true;
            this.radio_hot.CheckedChanged += new System.EventHandler(this.radio_hot_CheckedChanged);
            // 
            // radio_ice
            // 
            this.radio_ice.AutoSize = true;
            this.radio_ice.Enabled = false;
            this.radio_ice.Font = new System.Drawing.Font("Pretendard", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radio_ice.Location = new System.Drawing.Point(248, 26);
            this.radio_ice.Name = "radio_ice";
            this.radio_ice.Size = new System.Drawing.Size(50, 22);
            this.radio_ice.TabIndex = 1;
            this.radio_ice.TabStop = true;
            this.radio_ice.Text = "ICE";
            this.radio_ice.UseVisualStyleBackColor = true;
            // 
            // DrinkType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radio_ice);
            this.Controls.Add(this.radio_hot);
            this.Name = "DrinkType";
            this.Size = new System.Drawing.Size(400, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_hot;
        private System.Windows.Forms.RadioButton radio_ice;
    }
}
