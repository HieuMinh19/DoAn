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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region KHAI BÁO BIẾN TOÀN CỤC
        public static int SoPT = 0;
       
        public static int[] Array; // mang chua m so nguyen
        public static Button[] Bn; //tao ra mang 
        int HEIGHT = 100; //chieu cao luc di chuyen button

        // siZE luc đầu là 60, t sửa thành 47 

        int Size ; // kich thươc NUt
        int KhoangCachNut;//  
        int Canh_le;
        #endregion KHAI BÁO BIẾN TOÀN CỤC

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            #region thiet lap kich thuoc node
            //khoi tao kich thuoc mang
            SoPT = int.Parse(txtNhapPT.Text.Trim());
            //them
            switch(SoPT)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                    Size = 60;
                    KhoangCachNut = 25;
                    Canh_le = (1460 - Size * SoPT - KhoangCachNut * (SoPT - 1)) / 2;
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Size = 55;
                    KhoangCachNut = 25;
                    Canh_le = (1460 - Size * SoPT - KhoangCachNut * (SoPT - 1)) / 2;
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    Size = 47;
                    KhoangCachNut = 25;
                    Canh_le = (1460 - Size * SoPT - KhoangCachNut * (SoPT - 1)) / 2;
                    break;
            }
            //het them
            #endregion
            #region tao mang
            if (1 < SoPT && SoPT < 16)
            {
                Array = new int[SoPT]; //khoi tao mang M gom n phan tu
                Bn = new Button[SoPT]; //khoi tao Button Bn gom n Button
                pnNut.Controls.Clear(); //xong trong PnNut cac thanh trong
                for (int i = 0; i < SoPT; i++)
                {
                    Button btn = new Button();           
                    btn.Text = "0";
                    btn.Width = btn.Height = Size;         
                    btn.Location = new Point(Canh_le + i * (btn.Width + KhoangCachNut),
                        pnNut.Height / 2 - btn.Height / 2);                             
                    pnNut.Controls.Add(btn);
                    Array[i] = 0;
                    Bn[i] = btn;
                    Bn[i].ForeColor = Color.White;
                    Bn[i].BackColor = Color.OrangeRed;
                }
            }
            else
            {
                //int a = Int16.Parse(txtNhapPT.Text);
                //if ((n < 2) || (n > 15))
                MessageBox.Show("Mảng từ 2 -> 15 phần tử");
                txtNhapPT.Focus();
            }
            #endregion 
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_SoPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rad_InterchangeSort_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            rad_InterchangeSort.Checked = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rad_SelectionSort_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rad_HeapSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_MergeSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_BubbleSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_ShakerSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_InsertionSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_BinaryInsertionSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_ShellSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_QuickSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Sophantu_TextChanged(object sender, EventArgs e)
        {

        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grb_khoitao_Enter(object sender, EventArgs e)
        {
            
        }

        private void pnNut_Click(object sender, EventArgs e)
        {

        }

        private void lbSophantu_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NhapPT fr = new NhapPT();
            fr.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            pnNut.Controls.Clear();
        }

        private void btn_Ngaunhien_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            for (int i = 0; i < SoPT; i++)
            {
                Array[i] = rd.Next(100);
                Bn[i].Text = Array[i].ToString();
            }
        }

        private void rad_Giam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hàng đầu tiên chứa số phần tử mảng, các hàng tiếp theo chứa các phần tử", "Hướng dẫn");
        }

        private void rad_Tang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Batdau_Click(object sender, EventArgs e)
        {

        }

        private void trb_Tocdo_Scroll(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            rad_Tang.Checked = true;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void pnNut_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
