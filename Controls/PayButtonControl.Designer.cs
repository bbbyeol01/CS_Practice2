namespace Coffee_Kiosk.Controls
{
    partial class PayButtonControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_payMethod = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_payMethod)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_payMethod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 60);
            this.panel1.TabIndex = 0;
            // 
            // pic_payMethod
            // 
            this.pic_payMethod.BackColor = System.Drawing.Color.Transparent;
            this.pic_payMethod.Location = new System.Drawing.Point(48, 7);
            this.pic_payMethod.Name = "pic_payMethod";
            this.pic_payMethod.Size = new System.Drawing.Size(100, 50);
            this.pic_payMethod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_payMethod.TabIndex = 0;
            this.pic_payMethod.TabStop = false;
            this.pic_payMethod.Click += new System.EventHandler(this.PayButtonControl_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_name.Location = new System.Drawing.Point(154, 19);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(74, 23);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "결제방식";
            this.lbl_name.Click += new System.EventHandler(this.PayButtonControl_Click);
            // 
            // PayButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel1);
            this.Name = "PayButtonControl";
            this.Size = new System.Drawing.Size(300, 60);
            this.Click += new System.EventHandler(this.PayButtonControl_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_payMethod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_payMethod;
    }
}
