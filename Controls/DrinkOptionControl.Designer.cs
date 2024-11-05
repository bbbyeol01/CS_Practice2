namespace Coffee_Kiosk.Controls
{
    partial class DrinkOptionControl
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Pretendard", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_name.Location = new System.Drawing.Point(70, 21);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(60, 18);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "옵션이름";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_quantity.Location = new System.Drawing.Point(278, 21);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(20, 19);
            this.lbl_quantity.TabIndex = 2;
            this.lbl_quantity.Text = "0";
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.White;
            this.btn_plus.FlatAppearance.BorderSize = 0;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Image = global::Coffee_Kiosk.Properties.Resources.plus_icon;
            this.btn_plus.Location = new System.Drawing.Point(315, 15);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(30, 30);
            this.btn_plus.TabIndex = 3;
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.White;
            this.btn_minus.FlatAppearance.BorderSize = 0;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Image = global::Coffee_Kiosk.Properties.Resources.minus_icon;
            this.btn_minus.Location = new System.Drawing.Point(227, 15);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(30, 30);
            this.btn_minus.TabIndex = 1;
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // DrinkOptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.lbl_name);
            this.Name = "DrinkOptionControl";
            this.Size = new System.Drawing.Size(400, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Button btn_plus;
    }
}
