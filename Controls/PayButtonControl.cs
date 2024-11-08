using Coffee_Kiosk.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            // 가상 결제 프로세서 객체 생성
            IPaymentProcessor paymentProcessor = new MockPaymentProcessor();

            // 결제 요청을 시도하고 결과를 받음
            TransactionResult result = paymentProcessor.ProcessPayment(price);

            if (result.IsSuccess)
            {
                MessageBox.Show($"결제 성공: {result.ApprovedAmount}원이 승인되었습니다.");
            }
            else
            {
                MessageBox.Show($"결제 실패: {result.ErrorMessage}");
            }
        }
    }
}
