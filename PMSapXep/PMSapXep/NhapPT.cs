using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMSapXep
{
    public partial class NhapPT : Form
    {
        public NhapPT()
        {
            InitializeComponent();
        }

        private void lb_nhap_Click(object sender, EventArgs e)
        {

        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Giatri_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            int ViTri, GiaTri;
            ViTri = Convert.ToInt32(txt_Vitri.Text);
            GiaTri = Convert.ToInt32(txt_Giatri.Text);

            #region KIỂM TRA GIÁ TRỊ NHÂP VÀO
            if (ViTri > Form1.SoPT - 1)
            {
                MessageBox.Show("không tồn tại vị trí phần tử");
                return;
            }


            if (GiaTri >= 100)
            {
                MessageBox.Show("0 <= giá trị nhập vào <= 100");
                this.txt_Giatri.Clear();
                return;
            }
            #endregion
          
            Form1.Array[ViTri] = GiaTri;
            Form1.Bn[ViTri].Text = GiaTri.ToString();
            //tu dong tang gia tri cua vi tri phan tu
            this.txt_Vitri.Text = (ViTri + 1).ToString();

            Form1.Bn[ViTri].BackColor = Color.Green;
            

            
        }

        private void btn_exits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhapPT_Load(object sender, EventArgs e)
        {

        }

        private void txt_Vitri_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Vitri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
