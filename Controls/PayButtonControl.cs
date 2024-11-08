using Coffee_Kiosk.Model;
using Coffee_Kiosk.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Kiosk.Controls
{
    public partial class PayButtonControl : UserControl
    {

        int price;
        public PayButtonControl(int totalPrice)
        {
            InitializeComponent();
            this.price = totalPrice;
        }

        public string Name
        {
            get { return lbl_name.Text; }
            set { lbl_name.Text = value; }
        }
        public Image Pic_method
        {
            set { this.pic_payMethod.Image = value;  }
        }

        private void PayButtonControl_Click(object sender, EventArgs e)
        {
            // 가상 결제 객체
            IPaymentProcessor paymentProcessor = new MockPaymentProcessor();

            // 결제 요청 -> 결과를 받음 지금은 무조건 성공
            TransactionResult result = paymentProcessor.ProcessPayment(price);

            if (result.IsSuccess)
            {
                PayResultForm payResultForm = new PayResultForm("success");
                ShadowForm shadow = new ShadowForm();

                shadow.Show();
                payResultForm.FormClosed += (s, args) => { shadow.Dispose(); };
                payResultForm.ShowDialog();

                Thread.Sleep(3000);

                payResultForm.Close();

            }
            else
            {
                PayResultForm payResultForm = new PayResultForm("fail");
                ShadowForm shadow = new ShadowForm();

                shadow.Show();
                payResultForm.FormClosed += (s, args) => { shadow.Dispose(); };
                payResultForm.ShowDialog();

                Thread.Sleep(3000);

                payResultForm.Close();
            }
        }
    }
}
