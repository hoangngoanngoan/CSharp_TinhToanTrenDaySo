namespace CSharp_TinhToanTrenDaySo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double soBD;
        private double soKT;

        private string GetInfo()
        {
            try
            {
                double BD;
                double KT;
                BD = Convert.ToDouble(txtSBD.Text);
                KT = Convert.ToDouble(txtSKT.Text);
                if(BD < KT)
                {
                    soBD = BD;
                    soKT = KT;
                    return labKQ.Text = "Thành công";
                }
                else return labKQ.Text = "Phải nhập số bắt đầu nhỏ hơn số kết thúc";
            }catch
            {
                return labKQ.Text = "Phải nhập số";
            }
        }

        private string TinhTong()
        {
            GetInfo();
            double tong = 0;
            for (double i = soBD; i<= soKT; i++)
            {
                tong += i;
            }
            return tong.ToString();
        }
        private string TinhTich()
        {
            GetInfo();
            double tich = 1;
            for (double i = soBD; i <= soKT; i++)
            {
                tich *= i;
            }
            return tich.ToString();
        }

        private string TinhTongChan()
        {
            GetInfo() ;
            double tong = 0;
            for (double i = soBD; i<= soKT; i++ )
            {
                if (i % 2 == 0)
                {
                    tong += i;
                }
            }
            return tong .ToString();
        }

        private string TinhTongLe()
        {
            GetInfo();
            double tong = 0;
            for (double i = soBD; i <= soKT; i++)
            {
                if (i % 2 != 0)
                {
                    tong += i;
                }
            }
            return tong.ToString();
        }
        private void butTinh_Click(object sender, EventArgs e)
        {
            GetInfo();
            txtTong.Text = TinhTong();
            txtTich.Text = TinhTich();
            txtTongChan.Text = TinhTongChan();
            txtTongLe.Text = TinhTongLe();  
        }

    }

}
