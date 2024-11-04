namespace POS_build.View
{
    partial class SelectOptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_pic = new System.Windows.Forms.Panel();
            this.pic_drink = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel_pic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drink)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 24);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_desc);
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Controls.Add(this.panel_pic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 160);
            this.panel2.TabIndex = 1;
            // 
            // panel_pic
            // 
            this.panel_pic.Controls.Add(this.pic_drink);
            this.panel_pic.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_pic.Location = new System.Drawing.Point(0, 0);
            this.panel_pic.Name = "panel_pic";
            this.panel_pic.Padding = new System.Windows.Forms.Padding(20);
            this.panel_pic.Size = new System.Drawing.Size(188, 160);
            this.panel_pic.TabIndex = 0;
            // 
            // pic_drink
            // 
            this.pic_drink.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_drink.Location = new System.Drawing.Point(48, 20);
            this.pic_drink.Name = "pic_drink";
            this.pic_drink.Size = new System.Drawing.Size(120, 120);
            this.pic_drink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_drink.TabIndex = 0;
            this.pic_drink.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_name.Location = new System.Drawing.Point(190, 40);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(66, 23);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "label2";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Pretendard Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_desc.Location = new System.Drawing.Point(190, 64);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(48, 18);
            this.lbl_desc.TabIndex = 3;
            this.lbl_desc.Text = "label2";
            // 
            // SelectOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectOptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SelectOptionForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_pic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_drink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_pic;
        private System.Windows.Forms.PictureBox pic_drink;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_name;
    }
}