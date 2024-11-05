namespace Coffee_Kiosk
{
    partial class SellForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_category = new System.Windows.Forms.Panel();
            this.btn_smootie = new System.Windows.Forms.Button();
            this.btn_teaAndAde = new System.Windows.Forms.Button();
            this.btn_nonCoffee = new System.Windows.Forms.Button();
            this.btn_coffee = new System.Windows.Forms.Button();
            this.panel_order = new System.Windows.Forms.Panel();
            this.panel_total = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.panel_btn = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_dessert = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_category.SuspendLayout();
            this.panel_order.SuspendLayout();
            this.panel_total.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(540, 50);
            this.panel_top.TabIndex = 0;
            // 
            // panel_category
            // 
            this.panel_category.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_category.Controls.Add(this.btn_dessert);
            this.panel_category.Controls.Add(this.btn_smootie);
            this.panel_category.Controls.Add(this.btn_teaAndAde);
            this.panel_category.Controls.Add(this.btn_nonCoffee);
            this.panel_category.Controls.Add(this.btn_coffee);
            this.panel_category.Location = new System.Drawing.Point(0, 53);
            this.panel_category.Name = "panel_category";
            this.panel_category.Size = new System.Drawing.Size(650, 100);
            this.panel_category.TabIndex = 1;
            // 
            // btn_smootie
            // 
            this.btn_smootie.BackColor = System.Drawing.Color.White;
            this.btn_smootie.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_smootie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_smootie.FlatAppearance.BorderSize = 0;
            this.btn_smootie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_smootie.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_smootie.Location = new System.Drawing.Point(390, 0);
            this.btn_smootie.Name = "btn_smootie";
            this.btn_smootie.Size = new System.Drawing.Size(130, 100);
            this.btn_smootie.TabIndex = 3;
            this.btn_smootie.Text = "스무디";
            this.btn_smootie.UseVisualStyleBackColor = false;
            this.btn_smootie.Click += new System.EventHandler(this.btn_smootie_Click);
            // 
            // btn_teaAndAde
            // 
            this.btn_teaAndAde.BackColor = System.Drawing.Color.White;
            this.btn_teaAndAde.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_teaAndAde.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_teaAndAde.FlatAppearance.BorderSize = 0;
            this.btn_teaAndAde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teaAndAde.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_teaAndAde.Location = new System.Drawing.Point(260, 0);
            this.btn_teaAndAde.Name = "btn_teaAndAde";
            this.btn_teaAndAde.Size = new System.Drawing.Size(130, 100);
            this.btn_teaAndAde.TabIndex = 2;
            this.btn_teaAndAde.Text = "차/에이드";
            this.btn_teaAndAde.UseVisualStyleBackColor = false;
            this.btn_teaAndAde.Click += new System.EventHandler(this.btn_teaAndAde_Click);
            // 
            // btn_nonCoffee
            // 
            this.btn_nonCoffee.BackColor = System.Drawing.Color.White;
            this.btn_nonCoffee.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_nonCoffee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_nonCoffee.FlatAppearance.BorderSize = 0;
            this.btn_nonCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nonCoffee.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_nonCoffee.Location = new System.Drawing.Point(130, 0);
            this.btn_nonCoffee.Name = "btn_nonCoffee";
            this.btn_nonCoffee.Size = new System.Drawing.Size(130, 100);
            this.btn_nonCoffee.TabIndex = 1;
            this.btn_nonCoffee.Text = "논커피";
            this.btn_nonCoffee.UseVisualStyleBackColor = false;
            this.btn_nonCoffee.Click += new System.EventHandler(this.btn_nonCoffee_Click);
            // 
            // btn_coffee
            // 
            this.btn_coffee.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_coffee.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_coffee.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_coffee.FlatAppearance.BorderSize = 0;
            this.btn_coffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_coffee.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_coffee.ForeColor = System.Drawing.Color.White;
            this.btn_coffee.Location = new System.Drawing.Point(0, 0);
            this.btn_coffee.Name = "btn_coffee";
            this.btn_coffee.Size = new System.Drawing.Size(130, 100);
            this.btn_coffee.TabIndex = 0;
            this.btn_coffee.Text = "커피";
            this.btn_coffee.UseVisualStyleBackColor = false;
            this.btn_coffee.Click += new System.EventHandler(this.btn_coffee_Click);
            // 
            // panel_order
            // 
            this.panel_order.Controls.Add(this.panel2);
            this.panel_order.Controls.Add(this.panel_total);
            this.panel_order.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_order.Location = new System.Drawing.Point(0, 666);
            this.panel_order.Name = "panel_order";
            this.panel_order.Padding = new System.Windows.Forms.Padding(20);
            this.panel_order.Size = new System.Drawing.Size(540, 294);
            this.panel_order.TabIndex = 2;
            // 
            // panel_total
            // 
            this.panel_total.Controls.Add(this.panel1);
            this.panel_total.Controls.Add(this.panel_btn);
            this.panel_total.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_total.Location = new System.Drawing.Point(20, 174);
            this.panel_total.Name = "panel_total";
            this.panel_total.Size = new System.Drawing.Size(500, 100);
            this.panel_total.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_totalPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(306, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(54, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "1개";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "총";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Pretendard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(115, 20);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(171, 60);
            this.lbl_totalPrice.TabIndex = 0;
            this.lbl_totalPrice.Text = "1,800원";
            this.lbl_totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_btn
            // 
            this.panel_btn.Controls.Add(this.button5);
            this.panel_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_btn.Location = new System.Drawing.Point(306, 0);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Padding = new System.Windows.Forms.Padding(20);
            this.panel_btn.Size = new System.Drawing.Size(194, 100);
            this.panel_btn.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(20, 20);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 60);
            this.button5.TabIndex = 0;
            this.button5.Text = "결제하기";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel_menu
            // 
            this.panel_menu.AutoScroll = true;
            this.panel_menu.BackColor = System.Drawing.Color.White;
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_menu.Location = new System.Drawing.Point(0, 153);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(540, 513);
            this.panel_menu.TabIndex = 3;
            // 
            // btn_dessert
            // 
            this.btn_dessert.BackColor = System.Drawing.Color.White;
            this.btn_dessert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_dessert.FlatAppearance.BorderSize = 0;
            this.btn_dessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dessert.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_dessert.Location = new System.Drawing.Point(520, 0);
            this.btn_dessert.Name = "btn_dessert";
            this.btn_dessert.Size = new System.Drawing.Size(135, 100);
            this.btn_dessert.TabIndex = 4;
            this.btn_dessert.Text = "디저트";
            this.btn_dessert.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 174);
            this.panel2.TabIndex = 1;
            // 
            // SellForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(540, 960);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_order);
            this.Controls.Add(this.panel_category);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Pretendard", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SellForm_Load);
            this.panel_category.ResumeLayout(false);
            this.panel_order.ResumeLayout(false);
            this.panel_total.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_category;
        private System.Windows.Forms.Button btn_smootie;
        private System.Windows.Forms.Button btn_teaAndAde;
        private System.Windows.Forms.Button btn_nonCoffee;
        private System.Windows.Forms.Button btn_coffee;
        private System.Windows.Forms.Panel panel_order;
        private System.Windows.Forms.Panel panel_total;
        private System.Windows.Forms.Panel panel_btn;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dessert;
        private System.Windows.Forms.Panel panel2;
    }
}

