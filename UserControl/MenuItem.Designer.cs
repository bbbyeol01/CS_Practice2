namespace Coffee_Kiosk
{
    partial class MenuItem
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
            this.pic_drink = new System.Windows.Forms.PictureBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drink)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_type);
            this.panel1.Controls.Add(this.pic_drink);
            this.panel1.Controls.Add(this.lbl_price);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(270, 150);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // pic_drink
            // 
            this.pic_drink.Location = new System.Drawing.Point(20, 25);
            this.pic_drink.Name = "pic_drink";
            this.pic_drink.Size = new System.Drawing.Size(100, 100);
            this.pic_drink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_drink.TabIndex = 5;
            this.pic_drink.TabStop = false;
            this.pic_drink.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_price.Location = new System.Drawing.Point(120, 64);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(124, 30);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "label1";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_price.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Pretendard", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_name.Location = new System.Drawing.Point(121, 42);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(137, 30);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "label2";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // lbl_type
            // 
            this.lbl_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_type.Font = new System.Drawing.Font("Pretendard Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_type.Location = new System.Drawing.Point(121, 87);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(124, 30);
            this.lbl_type.TabIndex = 6;
            this.lbl_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_type.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // MenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MenuItem";
            this.Size = new System.Drawing.Size(270, 150);
            this.Click += new System.EventHandler(this.MenuItem_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_drink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_drink;
        private System.Windows.Forms.Label lbl_type;
    }
}
