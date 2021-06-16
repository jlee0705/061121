using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carFixMgr.ui
{
    public partial class ReceiptForm : MaterialForm
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void receiptSave_Click(object sender, EventArgs e)
        {
            string name = custName.Text;
            string telA = custTelA.SelectedText;
            string telB = custTelB.Text;
            string year = custYear.SelectedText;
            string month = custMonth.SelectedText;
            string day = custDay.SelectedText;
            string model = carModel.SelectedText;
            string carnumber = carNum.Text;
            string cc = carCC.SelectedText;
            string caryear = carYear.SelectedText;
            string staffname = staffName.Text;

            Console.WriteLine("고객명: " + name);
            Console.WriteLine("전화번호: " + telA + telB);
            Console.WriteLine("생년월일: " + year + "년" + month + "월" + day + "일");
            Console.WriteLine("차량모델: " + model);
            Console.WriteLine("차량번호: " + carnumber);
            Console.WriteLine("배기량: " + cc);
            Console.WriteLine("차량연식: " + caryear);
            Console.WriteLine("담당자: " + staffname);

        }

        private void receiptClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
