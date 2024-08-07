using System.Globalization;

namespace Tinhlaisuatnganhang
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Sotien = Convert.ToDouble(SoTienTxt.Text);
            double Laisuat = double.Parse(LsCbB.SelectedItem.ToString().Replace("%", "")) / 100;
            int Sonam = (int)SonamNR.Value;

            for (int i = 0; i < Sonam; i++)
            {
                double Solai = Sotien * Laisuat;
                KetQuaLb.Items.Add("Năm " + i+1 + " Tiền gốc: " + Sotien.ToString("0,##0.00") + " - Lãi: " + Solai.ToString("N", new CultureInfo("en-US")));
                Sotien += Solai;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (double i = 0.01; i <= 0.101; i += 0.001)
            {
                LsCbB.Items.Add(String.Format("{0:P1}", Math.Round(i, 3)));
            }
            SoTienTxt.Text = "10000000";
            LsCbB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
