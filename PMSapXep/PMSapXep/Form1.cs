﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;
namespace PMSapXep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //auto load thuật toán và ý tưởng của thuật toán InterchangeSort
            rad_InsertionSort.Checked = true;
            rad_InterchangeSort.Checked = true;

        }
        #region Khai bao bien toan cuc
        public static int SoPT = 0;

        public static int[] Array; // mang chua m so nguyen
        public static Button[] Bn, Bn1,Bn2; //tao ra mang 
      
        public static Label[] Chi_so;
        public static int[] Pos; //vi tri cua   button trong mang
        int HEIGHT = 100; //chieu cao luc di chuyen button
        int DemQuickSort = 0;// d?m s? l?n dich chuy?n qua trái ph?a c?a button
        // siZE luc d?u là 60, t s?a thành 47 

        int Size; // kich thuoc NUt
        int KhoangCachNut;//  
        int Canh_le;
        bool kttaomang, kttaomang1;
        #endregion KHAI BÁO BIẾN TOÀN CỤC

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            btn_Ngaunhien.Enabled = true;
            btnxoamang.Enabled = true;
            btn_mofile.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;



            //khoi tao kich thuoc mang
            SoPT = int.Parse(txtNhapPT.Text.Trim());
            //tính toán vị trí phần tử dựa trên số phần tử

            Tao_Mang(Properties.Resources.chuaxep);


        }

        #region các hàm khác

        public void Tao_Mang(System.Drawing.Image nen)
        {
            #region thiet lap kich thuoc node
            switch (SoPT)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                    Size = 70;
                    KhoangCachNut = 25;
                    Canh_le = (pnNut.Width - Size * SoPT - KhoangCachNut * (SoPT - 1)) / 2;
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Size = 60;
                    KhoangCachNut = 25;
                    Canh_le = (pnNut.Width - Size * SoPT - KhoangCachNut * (SoPT - 1)) / 2;
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    Size = 50;
                    KhoangCachNut = 25;
                    Canh_le = (pnNut.Width - Size * SoPT - KhoangCachNut * (SoPT - 1)) / 2;
                    break;
            }
            #endregion

            #region tao mang
            if (1 < SoPT && SoPT < 16)
            {

                Array = new int[SoPT]; //khoi tao mang M gom n phan tu
                Bn = new Button[SoPT]; //khoi tao Button Bn gom n 
                Pos = new int[SoPT];
                pnNut.Controls.Clear(); //xong trong PnNut cac thanh trong
                Chi_so = new Label[SoPT];
                for (int i = 0; i < SoPT; i++)
                {
                    //tao button
                    Button btn = new Button();
                    btn.Text = "0";
                    btn.Width = btn.Height = Size;
                    btn.Location = new Point(Canh_le + i * (btn.Width + KhoangCachNut),
                        pnNut.Height / 2 - btn.Height / 2);
                    pnNut.Controls.Add(btn);
                    Array[i] = 0;
                    Bn[i] = btn;
                    Pos[i] = i;
                    Bn[i].ForeColor = Color.White;
                    //??
                    Bn[i].FlatStyle = FlatStyle.Flat;
                    Bn[i].BackgroundImage = nen;
                    Bn[i].BackgroundImageLayout = ImageLayout.Stretch;
                    //tao chi_So
                    Label lbChiSo = new Label();
                    lbChiSo.Text = i.ToString();
                    lbChiSo.Width = lbChiSo.Height = Size;

                    switch (SoPT)
                    {
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            lbChiSo.Location = new Point(Canh_le + i * (btn.Width + KhoangCachNut) + Size / 2, btn.Location.Y + btn.Height * 3);
                            break;
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            lbChiSo.Location = new Point(Canh_le + i * (btn.Width + KhoangCachNut) + Size / 2, btn.Location.Y + btn.Height * 3 + 10);
                            break;
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                            lbChiSo.Location = new Point(Canh_le + i * (btn.Width + KhoangCachNut) + Size / 2, btn.Location.Y + btn.Height * 4);
                            break;
                    }
                    pnNut.Controls.Add(lbChiSo);
                    Chi_so[i] = lbChiSo;
                    Chi_so[i].ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Mảng từ 2 đến 15 phần tử");
                txtNhapPT.Focus();
            }
            #endregion 
        }

        //ham co do tre
        public void Tre(int milisecond)
        {
            Application.DoEvents();
            Thread.Sleep(milisecond);
        }

        #endregion
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

		#region y tuong va code
		private void rad_InterchangeSort_CheckedChanged(object sender, EventArgs e)
		{
			text_ytuong.Text = "Xuất phát từ đầu dãy, tìm tất các các cặp nghịch thế, triệt tiêu bằng cách đổi chỗ 2 phần tử trong cặp nghịch thế.\r\nLặp lại xử lý trên với phần tử kế trong dãy.  ";
			lb_code.Items.Clear();
			code x = new code();
			x.Interchangesort(lb_code, rad_Tang.Checked);
		}

		private void rad_SelectionSort_CheckedChanged(object sender, EventArgs e)
		{
			lb_code.Items.Clear();
			code x = new code();
			x.Selectionsort(lb_code, rad_Tang.Checked);
			text_ytuong.Text = "Chọn phần tử nhỏ nhất trong N phần tử trong dãy hiện hành ban đầu.Đưa phần tử này về vị trí đầu dãy hiện hành\r\nXem dãy hiện hành chỉ còn N-1 phần tử của dãy hiện hành ban đầuBắt đầu từ vị trí thứ 2\r\nLặp lại quá trình trên cho dãy hiện hành đến khi dãy hiện hành chỉ còn 1 phần tử";

		}

		private void rad_HeapSort_CheckedChanged(object sender, EventArgs e)
		{
			lb_code.Items.Clear();
			text_ytuong.Text = "Heap Sort tận dụng được các phép so sánh ở bước i-1, mà thuật toán sắp xếp chọn trực tiếp không tận dụng được\r\nĐể làm được điều này Heap sort thao tác dựa trên cây.\r\nỞ cây trên, phần tử ở mức i chính là phần tử lớn trong cặp phần tử ở mức i +1, do đó phần tử ở nút gốc là phần tử lớn nhất.\r\nNếu loại bỏ gốc ra khỏi cây, thì việc cập  nhật cây chỉ xãy ra trên những nhấn liên quan đến phần tử mới loại bỏ, còn các nhánh khác thì bảo toàn.\r\nBước kế tiếp có thể sử dụng lại kết quả so sánh của bước hiện tại. ";
			code x = new code();
			x.heapsort(lb_code, rad_Tang.Checked);
		}

		private void rad_MergeSort_CheckedChanged(object sender, EventArgs e)
		{
			lb_code.Items.Clear();
			code x = new code();
			x.Mergesort(lb_code, rad_Tang.Checked);
			text_ytuong.Text = "Giải thuật Merge sort sắp xếp dãy a1, a2, ..., an dựa trên nhận xét sau: \r\n    +Mỗi dãy a1, a2, ..., an bất kỳ là một tập hợp các dãy con liên tiếp mà mỗi dãy con đều đã có thứ tự. \r\n    +Dãy đã có thứ tự coi như có 1 dãy con.\r\nMảng A chia làm 02 phần bằng nhau\r\nSắp xếp 02 phần\r\nTrộn 02 nửa lại ";
		}

		private void rad_BubbleSort_CheckedChanged(object sender, EventArgs e)
		{
			lb_code.Items.Clear();
			code x = new code();
			x.bubblesort(lb_code, rad_Tang.Checked);
			text_ytuong.Text = "Xuất phát từ cuối dãy, đổi chỗ các cặp phần tử kế cận để đưa phần tử nhỏ hơn trong cặp phần tử đó về vị trí đúng đầu dãy hiện hành, sau đó sẽ không xét đến nó ở bước tiếp theo, do vậy ở lần xử lý thứ i sẽ có vị trí đầu dãy là i.\r\nLặp lại xử lý trên cho đến khi không còn cặp phần tử nào để xét.";

		}

		private void rad_ShakerSort_CheckedChanged(object sender, EventArgs e)
		{
			text_ytuong.Text = "Trong mỗi lần sắp xếp, duyệt mảng theo 2 lượt từ 2 phía khác nhau:\r\n    +Lượt đi: đẩy phần tử nhỏ về đầu mảng.\r\n    +Lượt về: đẩy phần tử lớn về cuối mảng. \r\nGhi nhận lại những đoạn đã sắp xếp nhằm tiết kiệm các phép so sánh thừa.";
			lb_code.Items.Clear();
			code x = new code();
			x.ShakerSort(lb_code, rad_Tang.Checked);
		}

		private void rad_InsertionSort_CheckedChanged(object sender, EventArgs e)
		{
			lb_code.Items.Clear();
			text_ytuong.Text = "Giả sử có một dãy a0 , a1 ,... ,an-1 trong đó i phần tử đầu tiên a0 , a1 ,... ,ai-1 đã có thứ\r\nTìm cách chèn phần tử  ai vào vị trí thích hợp của đoạn đã được sắp để có dãy mới a0 , a1,... ,ai trở nên có thứ tự. Vị trí này chính là vị trí giữa hai phần tử ak-1 và ak thỏa ak-1 < ai < ak (1≤k≤i). ";
			code x = new code();
			x.insertionsort(lb_code, rad_Tang.Checked);
		}

		private void rad_BinaryInsertionSort_CheckedChanged(object sender, EventArgs e)
		{
			lb_code.Items.Clear();
			code x = new code();
			x.Binaryinsertionsort(lb_code, rad_Tang.Checked);
			text_ytuong.Text = "Giả sử có một dãy a0 , a1 ,... ,an-1 trong đó i phần tử đầu tiên a0 , a1 ,... ,ai-1 đã có thứ\r\nChúng tasử dụng tìm kiếm nhị phân để chèn phần tử  ai vào vị trí thích hợp của đoạn đã được sắp để có dãy mới a0 , a1,... ,ai trở nên có thứ tự. Vị trí này chính là vị trí giữa hai phần tử ak-1 và ak thỏa ak-1 < ai < ak (1≤k≤i). .";
		}

		private void rad_ShellSort_CheckedChanged(object sender, EventArgs e)
		{
			text_ytuong.Text = "Phân hoạch dãy thành các dãy con \r\nSắp xếp các dãy con theo phương pháp chèn trực tiếp \r\nDùng phương pháp chèn trực tiếp sắp xếp lại cả dãy. ";
			lb_code.Items.Clear();
			code x = new code();
			x.shellsort(lb_code, rad_Tang.Checked);
		}

		private void rad_QuickSort_CheckedChanged(object sender, EventArgs e)
		{
			lb_code.Items.Clear();
			code x = new code();
			x.quicksort(lb_code, rad_Tang.Checked);
			text_ytuong.Text = "Giải thuật QuickSort sắp xếp dãy a1, a2 ..., aN dựa trên việc phân hoạch dãy ban đầu thành 3 phần\r\n    +Phần 1: Gồm các phần tử  có giá trị bé hơn x \r\n    +Phần 2: Gồm các phần tử  có giá trị bằng  x\r\n    +Phần 3: Gồm các phần tử  có giá trị lớn hơn \r\nSau khi thực hiện phân hoạch, dãy ban đầu được phân thành 3 đoạn:\r\n    •1. ak  ≤ x , với k = 1 .. j\r\n    • 2.ak = x , với k = j + 1..i - 1\r\n    • 3.ak   x , với k = i..N\r\nKhi đoạn thứ 2 đã có thứ tự.\r\n    +Nếu các đoạn 1 và 3 chỉ có 1 phần tử thì khi đó dãy con ban đầu đã được sắp.\r\n    +Nếu các đoạn 1 và 3  có nhiều hơn 1 phần tử  thì dãy ban đầu chỉ có thứ tự khi các đoạn 1, 3 được sắp xếp.\r\n    +Để sắp xếp các đoạn 1 và 3,ta phân hoạch dãy theo phương pháp ban đầu    ";
		}
		#endregion
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
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
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


            btn_Batdau.Enabled = true;

        }

        private void rad_Giam_CheckedChanged(object sender, EventArgs e)
        {
            lb_code.Refresh();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                btnPause.Text = "Tiếp Tục ";
            }
            else
            {
                timer1.Stop();
                btnPause.Text = "Tạm dừng ";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
        }


        private void btnmofile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hàng đầu tiên chứa số phần tử mảng, các hàng tiếp theo chứa các phần tử", "Hướng dẫn");
            Process notePad = new Process();
            notePad.StartInfo.FileName = "notepad.exe";
            notePad.StartInfo.Arguments = Application.StartupPath + @"/TEST.txt";
            notePad.Start();
        }

        private void rad_Tang_CheckedChanged(object sender, EventArgs e)
        {
            lb_code.Refresh();
        }

        private void btn_Batdau_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = true;

            btnhuy.Enabled = true;
            btn_mofile.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            btn_Ngaunhien.Enabled = false;
            btnTaoMang.Enabled = false;
            btnxoamang.Enabled = false;

            btn_Batdau.Enabled = false;



            if (rad_InterchangeSort.Checked == true)
                InterchangeSort(Bn);
            if (rad_SelectionSort.Checked == true)
                SelectionSort(Bn);
            if (rad_BubbleSort.Checked == true)
                BubbleSort(Bn);
            if (rad_ShakerSort.Checked == true)
                ShakerSort(Bn);
            if (rad_InsertionSort.Checked == true)
                InsertionSort(Bn);
            if (rad_BinaryInsertionSort.Checked == true)
                BinaryInsertionSort(Bn);
            if (rad_ShellSort.Checked == true)
                ShellSort(Bn);
            if (rad_HeapSort.Checked == true)
                HeapSort_Batdau(Bn);
            if (rad_QuickSort.Checked == true)
                Quicksort_Batdau(Bn);
            if (rad_MergeSort.Checked == true)//chua 
                MergeSort_Batdau(Bn);

            btnTaoMang.Enabled = true;
            btnhuy.Enabled = true;
            btn_mofile.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            btn_Ngaunhien.Enabled = false;
            btnhuy.Enabled = false;
            btnPause.Enabled = false;
            btn_xuatgip.Enabled = false;
            btnxoamang.Enabled = false;

            btn_Batdau.Enabled = false;

        }






        #region Di chuyen node

        public void SwapInts(int[] arr, int Pos1, int Pos2)
        {
            int Temp = arr[Pos1];
            arr[Pos1] = arr[Pos2];
            arr[Pos2] = Temp;
        }
        public void DiLen(Control btn)
        {
            //di len do cao 50
            for (int i = 0; i < Size +5; i++)
            {
                btn.Top = btn.Top - 1;
                System.Threading.Thread.Sleep((10 - trb_Tocdo.Value) / 3);
                Application.DoEvents();
            }
        }

        public void DiXuong(Control btn)
        {
            for (int i = 0; i < Size + 5; i++)
            {
                btn.Top = btn.Top + 1;
                System.Threading.Thread.Sleep((10 - trb_Tocdo.Value) / 3);
                Application.DoEvents();
            }

        }
        public void QuaPhai(Control btn)
        {
            for (int i = 0; i < (Size + KhoangCachNut); i++)
            {
                btn.Left = btn.Left + 1;
                //SwapInts(ViTri, ViTri[i], ViTri[i - 1]);
                Thread.Sleep((10 - trb_Tocdo.Value) / 3);
                Application.DoEvents();
            }
        }
        public void QuaTrai(Control btn, int Step)
        {
            for (int i = 0; i < Step * (Size + KhoangCachNut); i++)
            {
                btn.Left = btn.Left - 1;
                Thread.Sleep((10 - trb_Tocdo.Value) / 3);
                Application.DoEvents();
            }
        }
        public void Hoan_Tri_Node(int t1, int t2)
        {
            Button Temp = Bn[t1];
            Bn[t1] = Bn[t2];
            Bn[t2] = Temp;
        }
        //btn1 qua phai, btn2  qua trai
        public void HoanVi(Control btn1, Control btn2)
        {
            Point p1 = btn1.Location;
            Point p2 = btn2.Location;

            if (p1 != p2)
            {
                for (int i = p1.X; i < p2.X; i++)
                {
                    btn2.Left = btn2.Left - 1;
                    System.Threading.Thread.Sleep((10 - trb_Tocdo.Value) / 3);
                    Application.DoEvents();
                    btn1.Left = btn1.Left + 1;
                    System.Threading.Thread.Sleep((10 - trb_Tocdo.Value) / 3);
                    Application.DoEvents();
                }
            }
        }
        public void Hoan_vi(Button[] arrBT, int Pos1, int Pos2)
        {
            DiLen(arrBT[Pos1]);
            DiXuong(arrBT[Pos2]);
            HoanVi(arrBT[Pos1], arrBT[Pos2]);
            DiXuong(arrBT[Pos1]);
            DiLen(arrBT[Pos2]);
        }

        public void QuaPhai(int[] ViTri, Control btn)
        {
            for (int i = 0; i < (Size + KhoangCachNut); i++)
            {
                btn.Left = btn.Left + 1;

                Thread.Sleep((10 - trb_Tocdo.Value) / 3);
                Application.DoEvents();
            }
        }
        public void QuaTrai(Control btn)
        {
            for (int i = 0; i < DemQuickSort * (Size + KhoangCachNut); i++)
            {
                btn.Left = btn.Left - 1;
                Thread.Sleep((10 - trb_Tocdo.Value) / 3);
                Application.DoEvents();
            }
        }
        #endregion

        //ham thiet lap mau cua node
        public void Dat_mau_node(Button t, System.Drawing.Image image)
        {
            t.Refresh();
            t.BackgroundImage = image;
            t.BackgroundImageLayout = ImageLayout.Stretch;

        }

        #region thuat toan

        #region InterchangeSort
        private void InterchangeSort(Button[] M)
        {
            for (int i = 0; i < M.Length - 1; i++)
            {
                Mui_ten_xuong_1.Visible = true;
                Mui_ten_xuong_1.Text = "i=" + i;
                Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y - Size - 70);
                pnNut.Controls.Add(Mui_ten_xuong_1);
                Mui_ten_xuong_1.Refresh();
                //select dong code trong list box
                lb_code.SelectedIndex = 3;
                Tre((10 - trb_Tocdo.Value) * 100);
                for (int j = i + 1; j < M.Length; j++)
                {
                    Mui_ten_xuong_2.Visible = true;
                    Mui_ten_xuong_2.Text = "j=" + j;
                    Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y - Size - 70);
                    pnNut.Controls.Add(Mui_ten_xuong_2);
                    Mui_ten_xuong_2.Refresh();
                    Tre((10 - trb_Tocdo.Value) * 100);

                    //select dong code trong list box
                    lb_code.SelectedIndex = 4;
                    Tre((10 - trb_Tocdo.Value) * 100);

                    lb_code.SelectedIndex = 5;
                    Tre((10 - trb_Tocdo.Value) * 100);
                    if (Array[i] > Array[j] && rad_Tang.Checked == true)
                    {
                        lb_code.SelectedIndex = 6;
                        Tre((10 - trb_Tocdo.Value) * 100);
                        SwapInts(Array, i, j);
                        Hoan_vi(Bn, Pos[i], Pos[j]);
                        SwapInts(Pos, i, j);
                    }
                    else if (Array[i] < Array[j] && rad_Giam.Checked == true)
                    {
                        lb_code.SelectedIndex = 6;
                        Tre((10 - trb_Tocdo.Value) * 100);

                        SwapInts(Array, i, j);
                        Hoan_vi(Bn, Pos[i], Pos[j]);
                        SwapInts(Pos, i, j);
                    }
                }
                
                Bn[Pos[i]].ForeColor = Color.White;
                Bn[Pos[i]].FlatStyle = FlatStyle.Flat;
                Bn[Pos[i]].BackgroundImage = Properties.Resources.daxep;
                Bn[Pos[i]].BackgroundImageLayout = ImageLayout.Stretch;
                Bn[Pos[i]].Refresh();

                //đổi màu button cuối cùng của mảng
                if (i == M.Length - 2)
                {
                    Bn[Pos[M.Length - 1]].ForeColor = Color.White;
                    Bn[Pos[M.Length - 1]].FlatStyle = FlatStyle.Flat;
                    Bn[Pos[M.Length - 1]].BackgroundImage = Properties.Resources.daxep;
                    Bn[Pos[M.Length - 1]].BackgroundImageLayout = ImageLayout.Stretch;
                    Bn[Pos[M.Length - 1]].Refresh();
                }
            }
            
        }


        #endregion

        #region SelectionSort        
        private void SelectionSort(Button[] M)
        {
            int min;

            for (int i = 0; i < M.Length - 1; i++)
            {
                lb_code.SelectedIndex = 5;
                //Thread.Sleep(3000);
                min = i;
                //Thiết lập
                Mui_ten_xuong_1.Visible = true;
                Mui_ten_xuong_1.Text = "i=" + i;
                Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[min].Location.Y - Size - 70);
                pnNut.Controls.Add(Mui_ten_xuong_1);
                Mui_ten_xuong_1.Refresh();
                Tre((10 - trb_Tocdo.Value) * 100);

                //thiết lập mũi tên chỉ vị trí MIN đầu tiên
                Mui_ten_len_1.Visible = true;
                Mui_ten_len_1.Text = "Min=" + min;
                Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * min) + (Size / 2) - 30, Bn[min].Location.Y + 2 * Size + 5);
                pnNut.Controls.Add(Mui_ten_len_1);
                Mui_ten_len_1.Refresh();
                Tre((10 - trb_Tocdo.Value) * 100);

                for (int j = i + 1; j < M.Length; j++)
                {
                    lb_code.SelectedIndex = 7;

                    Mui_ten_xuong_2.Visible = true;
                    Mui_ten_xuong_2.Text = "j=" + j;
                    Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[min].Location.Y - Size - 70);

                    pnNut.Controls.Add(Mui_ten_xuong_2);
                    Mui_ten_xuong_2.Refresh();
                    Tre((10 - trb_Tocdo.Value) * 100);

                    if (Array[j] < Array[min] && rad_Tang.Checked == true)
                    {
                        min = j;
                        lb_code.SelectedIndex = 8;

                        Mui_ten_len_1.Visible = true;
                        Mui_ten_len_1.Text = "Min=" + min;
                        Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * min) + (Size / 2) - 30, Bn[j].Location.Y + 2 * Size + 5);
                        Mui_ten_len_1.Refresh();

                    }

                    if (Array[j] > Array[min] && rad_Giam.Checked == true)
                        min = j;
                    lb_code.SelectedIndex = 6;
                    
                }
                lb_code.SelectedIndex = 9;
               
                if (i != min)
                {

                    //cap nhat gia tri trong mang
                    SwapInts(Array, i, min);


                    //hoan vi button tren giao dien
                    Hoan_vi(Bn, Pos[i], Pos[min]);
                    lb_code.SelectedIndex = 10;
                    
                    //cap nhat vi tri cua button
                    SwapInts(Pos, i, min);
                }
                lb_code.SelectedIndex = 3;
                


                Bn[Pos[i]].ForeColor = Color.White;
                Bn[Pos[i]].FlatStyle = FlatStyle.Flat;
                Bn[Pos[i]].BackgroundImage = Properties.Resources.daxep;
                Bn[Pos[i]].BackgroundImageLayout = ImageLayout.Stretch;
                Bn[Pos[i]].Refresh();

                //đổi màu button cuối cùng của mảng
                if (i == M.Length - 2)
                {
                    Bn[Pos[M.Length - 1]].ForeColor = Color.White;
                    Bn[Pos[M.Length - 1]].FlatStyle = FlatStyle.Flat;
                    Bn[Pos[M.Length - 1]].BackgroundImage = Properties.Resources.daxep;
                    Bn[Pos[M.Length - 1]].BackgroundImageLayout = ImageLayout.Stretch;
                    Bn[Pos[M.Length - 1]].Refresh();
                }

            }

        }

        #endregion

        #region BubbleSort
        private void BubbleSort(Button[] M)
        {

            for (int i = 0; i < M.Length - 1; i++)
            {

                Mui_ten_xuong_1.Visible = true;
                Mui_ten_xuong_1.Text = "i=" + i;
                Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + 5, Bn[i].Location.Y - Size - 80);
                pnNut.Controls.Add(Mui_ten_xuong_1);
                Mui_ten_xuong_1.Refresh();
                for (int j = M.Length - 1; j > i; j--)
                {
                    int x = j - 1;
                    Mui_ten_xuong_2.Visible = true;
                    Mui_ten_xuong_2.Text = "j=" + j;
                    Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + 5, Bn[j].Location.Y - Size - 80);
                    pnNut.Controls.Add(Mui_ten_xuong_2);
                    Mui_ten_xuong_2.Refresh();
                    lb_code.SelectedIndex = 5;
                    Tre((10 - trb_Tocdo.Value) * 100);
                    //lb_code.SelectedIndex = 5;
                    if (Array[j - 1] > Array[j] && rad_Tang.Checked == true)
                    {
                        lb_code.SelectedIndex = 6;
                        Mui_ten_len_1.Visible = true;
                        Mui_ten_len_1.Text = "j-1=" + x;
                        Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * x) + 5, Bn[j].Location.Y + Size + 80);
                        pnNut.Controls.Add(Mui_ten_len_1);
                        Mui_ten_len_1.Refresh();
                        SwapInts(Array, j - 1, j);
                        Hoan_vi(Bn, Pos[j - 1], Pos[j]);
                        SwapInts(Pos, j - 1, j);
                    }
                    if (Array[j - 1] < Array[j] && rad_Giam.Checked == true)
                    {
                        lb_code.SelectedIndex = 6;
                        Mui_ten_len_1.Visible = true;
                        Mui_ten_len_1.Text = "j-1=" + x;
                        Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * x) + 5, Bn[j].Location.Y + Size + 80);
                        pnNut.Controls.Add(Mui_ten_len_1);
                        Mui_ten_len_1.Refresh();
                        SwapInts(Array, j - 1, j);
                        Hoan_vi(Bn, Pos[j - 1], Pos[j]);
                        SwapInts(Pos, j - 1, j);
                    }
                }
                Bn[Pos[i]].ForeColor = Color.White;
                Bn[Pos[i]].FlatStyle = FlatStyle.Flat;
                Bn[Pos[i]].BackgroundImage = Properties.Resources.daxep;
                Bn[Pos[i]].BackgroundImageLayout = ImageLayout.Stretch;
                Bn[Pos[i]].Refresh();
                if (i == M.Length - 2)
                {
                    Bn[Pos[M.Length - 1]].ForeColor = Color.White;
                    Bn[Pos[M.Length - 1]].FlatStyle = FlatStyle.Flat;
                    Bn[Pos[M.Length - 1]].BackgroundImage = Properties.Resources.daxep;
                    Bn[Pos[M.Length - 1]].BackgroundImageLayout = ImageLayout.Stretch;
                    Bn[Pos[M.Length - 1]].Refresh();
                }
            }
        }
        #endregion

        #region ShakerSort
        private void ShakerSort(Button[] M)
        {
            int Left = 0;
            int Right = M.Length - 1;
            int k = 0;
            while (Left < Right)
            {
                for (int i = Left; i < Right; i++)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        SwapInts(Array, i, i + 1);
                        Hoan_vi(Bn, Pos[i], Pos[i + 1]);
                        SwapInts(Pos, i, i + 1);
                        k = i;
                    }
                }
                Right = k;
                for (int i = Right; i > Left; i--)
                {
                    if (Array[i] < Array[i - 1])
                    {
                        SwapInts(Array, i, i - 1);
                        Hoan_vi(Bn, Pos[i], Pos[i - 1]);
                        SwapInts(Pos, i, i - 1);
                        k = i;
                    }
                }
                Left = k;
            }
            MessageBox.Show("S?p X?p Xong");
        }
        #endregion

        #region InsertionSort 
        private void InsertionSort(Button[] M)
        {
            Bn[0].ForeColor = Color.White;
            Bn[0].FlatStyle = FlatStyle.Flat;
            Bn[0].BackgroundImage = Properties.Resources.daxep;
            Bn[0].BackgroundImageLayout = ImageLayout.Stretch;
            Bn[0].Refresh();
            lb_code.SelectedIndex = 2;
            Tre((10 - trb_Tocdo.Value) * 100);
            for (int i = 1; i < M.Length; i++)
            {

                Mui_ten_xuong_1.Visible = true;
                Mui_ten_xuong_1.Text = "i=" + i;
                Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + 5, Bn[i].Location.Y - Size - 80);
                pnNut.Controls.Add(Mui_ten_xuong_1);
                Mui_ten_xuong_1.Refresh();
                DemQuickSort = 0;
                int x = Array[i];
                int j = i;
                if (rad_Tang.Checked == true)
                {
                    if (j > 0 && Array[j - 1] > x)
                    {
                        lb_code.SelectedIndex = 5;
                        DiLen(M[j]);
                        //

                        //
                        while (j > 0 && Array[j - 1] > x)
                        {
                            int y = j - 1;
                            lb_code.SelectedIndex = 9;
                            Mui_ten_len_1.Visible = true;
                            Mui_ten_len_1.Text = "j-1=" + y;
                            Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * (j - 1)) + 5, Bn[j - 1].Location.Y + Size);
                            pnNut.Controls.Add(Mui_ten_len_1);
                            Mui_ten_len_1.Refresh();

                            QuaPhai(M[j - 1]);
                            Hoan_Tri_Node(j, j - 1);
                            SwapInts(Array, j, j - 1);
                            // Hoan_vi(Bn, Pos[j], Pos[j-1]);//
                            // SwapInts(Pos, j, j-1);//t

                            j--;
                            DemQuickSort++;
                        }
                        lb_code.SelectedIndex = 12;
                        QuaTrai(M[j], DemQuickSort);
                        DiXuong(M[j]);
                        Bn[j].ForeColor = Color.White;
                        Bn[j].FlatStyle = FlatStyle.Flat;
                        Bn[j].BackgroundImage = Properties.Resources.daxep;
                        Bn[j].BackgroundImageLayout = ImageLayout.Stretch;
                        Bn[j].Refresh();
                    }
                }
                if (rad_Giam.Checked == true)
                {
                    if (j > 0 && Array[j - 1] < x)
                    {
                        lb_code.SelectedIndex = 5;
                        DiLen(M[j]);
                        while (j > 0 && Array[j - 1] < x)
                        {
                            int y = j - 1;
                            lb_code.SelectedIndex = 9;
                            Mui_ten_len_1.Visible = true;
                            Mui_ten_len_1.Text = "j-1=" + y;
                            Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * (j - 1)) + 5, Bn[j - 1].Location.Y + Size);
                            pnNut.Controls.Add(Mui_ten_len_1);
                            Mui_ten_len_1.Refresh();
                            lb_code.SelectedIndex = 9;
                            QuaPhai(M[j - 1]);
                            Hoan_Tri_Node(j, j - 1);
                            SwapInts(Array, j, j - 1);
                            j--;
                            DemQuickSort++;
                        }
                        lb_code.SelectedIndex = 12;
                        QuaTrai(M[j], DemQuickSort);
                        DiXuong(M[j]);

                        Bn[j].ForeColor = Color.White;
                        Bn[j].FlatStyle = FlatStyle.Flat;
                        Bn[j].BackgroundImage = Properties.Resources.daxep;
                        Bn[j].BackgroundImageLayout = ImageLayout.Stretch;
                        Bn[j].Refresh();
                    }
                }

                Bn[i].ForeColor = Color.White;
                Bn[i].FlatStyle = FlatStyle.Flat;
                Bn[i].BackgroundImage = Properties.Resources.daxep;
                Bn[i].BackgroundImageLayout = ImageLayout.Stretch;
                Bn[i].Refresh();

            }
        }
            #endregion

        #region BinaryInsertionSort
        private void BinaryInsertionSort(Button[] M)
        {
            int l, r, m, i;
            int DoiCho = 0;
            int x;//luu giá tr? a[i] tránh b? ghi dè khi d?i ch? các ph?n t?.
            for (i = 1; i < M.Length; i++)
            {
               DemQuickSort = 0;
                DoiCho = 0;
                x = Array[i];
                l = 0;
                r = i;
                while (l <= r) // tìm v? trí chèn x
                {
                    m = (l + r) / 2; // tìm v? trí thích h?p m
                    if (x < Array[m])
                    {
                        r = m - 1;
                        DoiCho++;
                    }
                    else l = m + 1;
                }
                if (DoiCho == 0)
                    continue;
                DiLen(M[i]);
                for (int j = i - 1; j >= l; j--)
                {

                    QuaPhai(M[j]);
                    SwapInts(Array, j, j + 1);
                    Hoan_Tri_Node(j, j + 1);
                    DemQuickSort++;
                }
                QuaTrai(M[l]);
                DiXuong(M[l]);

            }
        }
        #endregion

        #region ShellSort
        private void ShellSort(Button[] M)
        {

            int i, j, gap, temp;
            for (gap = SoPT / 2; gap > 0; gap = gap / 2)

            {

                for (i = 0; i < SoPT; i = i + gap)

                {

                    temp = Array[i];
                    if (rad_Tang.Checked == true)
                    {
                        for (j = i; j > 0 && Array[j - gap] > temp; j = j - gap)
                        {
                            Array[j] = Array[j - gap];
                            SwapInts(Array, j - gap, j);
                            Hoan_vi(Bn, Pos[j - gap], Pos[j]);
                            SwapInts(Pos, j - gap, j);
                        }


                        Array[j] = temp;
                    }
                    else if (rad_Giam.Checked == true)
                    {
                        for (j = i; j > 0 && Array[j - gap] < temp; j = j - gap)
                        {
                            Array[j] = Array[j - gap];
                            SwapInts(Array, j - gap, j);
                            Hoan_vi(Bn, Pos[j - gap], Pos[j]);
                            SwapInts(Pos, j - gap, j);
                        }


                        Array[j] = temp;
                    }

                }

            }
        }
		#endregion

		#region quick sort
		private void Quicksort_Batdau(Button[] M)
		{

			Quicksort(Array, 0, M.Length - 1);
            pnNut.Controls.Remove(Mui_ten_len_1);
            pnNut.Controls.Remove(Mui_ten_len_2);
            pnNut.Controls.Remove(Mui_ten_len_3);
            pnNut.Controls.Remove(Mui_ten_xuong_1);
            pnNut.Controls.Remove(Mui_ten_xuong_2);
            for (int r=0;r< M.Length; r++)
            {
                Bn[r].ForeColor = Color.White;
                Bn[r].FlatStyle = FlatStyle.Flat;
                Bn[r].BackgroundImage = Properties.Resources.daxep;
                Bn[r].BackgroundImageLayout = ImageLayout.Stretch;
                Bn[r].Refresh();
            }
			MessageBox.Show("Sap xep xong");
		}

		private void Quicksort(int[] array, int l, int r)
		{
            pnNut.Controls.Remove(Mui_ten_len_1);
            pnNut.Controls.Remove(Mui_ten_len_2);
            pnNut.Controls.Remove(Mui_ten_len_3);
            lb_code.SelectedIndex = 0;
            Mui_ten_xuong_1.Visible = true;
            Mui_ten_xuong_1.Text = "Left=" + l;
            Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * l) + (Size / 2) - 30, Bn[l].Location.Y - Size - 70);
            pnNut.Controls.Add(Mui_ten_xuong_1);
            Mui_ten_xuong_1.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            Mui_ten_xuong_2.Visible = true;
            Mui_ten_xuong_2.Text = "Right=" + r;
            Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * r) + (Size / 2) - 30, Bn[r].Location.Y - Size - 70);
            pnNut.Controls.Add(Mui_ten_xuong_2);
            Mui_ten_xuong_2.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            int i = l;
            lb_code.SelectedIndex = 2;
            Mui_ten_len_3.Visible = true;
            Mui_ten_len_3.Text = "i=" + i;
            Mui_ten_len_3.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
            pnNut.Controls.Add(Mui_ten_len_3);
            Mui_ten_len_3.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            int j = r;
            lb_code.SelectedIndex = 3;
            Mui_ten_len_1.Visible = true;
            Mui_ten_len_1.Text = "j=" + j;
            Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y + 2 * Size + 5);
            pnNut.Controls.Add(Mui_ten_len_1);
            Mui_ten_len_1.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            int x = array[(i + j) / 2];
            int X = (i + j) / 2;
            lb_code.SelectedIndex = 4;
            Mui_ten_len_2.Visible = true;
            Mui_ten_len_2.Text = "MID=" + X;
            Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * X) + (Size / 2) - 30, Bn[X].Location.Y + 2 * Size + 5+170);
            pnNut.Controls.Add(Mui_ten_len_2);
            Mui_ten_len_2.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            while (i <= j)
			{
                if (rad_Tang.Checked == true)
                {
                    while (array[i] < x )
                    {
                        lb_code.SelectedIndex = 8;
                        i++;
                        Mui_ten_len_3.Text = "i=" + i;
                        Mui_ten_len_3.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
                        Mui_ten_len_3.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 100);
                    }
                    while (array[j] > x)
                    {
                        lb_code.SelectedIndex = 10;
                        j--;
                        Mui_ten_len_1.Text = "j=" + j;
                        Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y + 2 * Size + 5);
                        Mui_ten_len_1.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 100);
                    }
                }
                if (rad_Giam.Checked == true)
                {
                    while (array[i] > x )
                    {
                        lb_code.SelectedIndex = 8;
                        i++;
                        Mui_ten_len_3.Text = "i=" + i;
                        Mui_ten_len_3.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
                        Mui_ten_len_3.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 100);
                    }
                    while (array[j] < x )
                    {
                        lb_code.SelectedIndex = 10;
                        j--;
                        Mui_ten_len_1.Text = "j=" + j;
                        Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y + 2 * Size + 5);
                        Mui_ten_len_1.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 100);
                    }
                }
				lb_code.SelectedIndex = 11;
				Tre((10 - trb_Tocdo.Value) * 20);
                if (i <= j)
                {
                    if (array[i] != array[j])
                    {
                        lb_code.SelectedIndex = 13;
                        SwapInts(array, i, j);
                        Hoan_vi(Bn, i, j);
                        Hoan_Tri_Node(i, j);
                    }
                    i++;
                    j--;
                    if (j >= 0)
                    {
                        lb_code.SelectedIndex = 14;
                        Mui_ten_len_1.Text = "j=" + j;
                        Mui_ten_len_3.Text = "i=" + i;
                        Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y + 2 * Size + 5);
                        Mui_ten_len_1.Refresh();
                        Mui_ten_len_3.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
                        Mui_ten_len_3.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 300);
                    }
                }
			}
			lb_code.SelectedIndex = 17;
			Tre((10 - trb_Tocdo.Value) * 20);
			if (j > l)
			{
				lb_code.SelectedIndex = 18;
				Tre((10 - trb_Tocdo.Value) * 20);
				Quicksort(array, l, j);
			}
			lb_code.SelectedIndex = 19;
			Tre((10 - trb_Tocdo.Value) * 20);
			if (i < r)
			{
				lb_code.SelectedIndex = 20;
				Tre((10 - trb_Tocdo.Value) * 20);
				Quicksort(array, i, r);
			}
		}
		#endregion

		#region heap sort
		private void shift(int[] array, int l, int r)
		{
			int x, i, j;
			i = l;
            Mui_ten_xuong_1.Visible = true;
            Mui_ten_xuong_1.Text = "Left=" + l;
            Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * l) + (Size / 2) - 30, Bn[l].Location.Y - Size - 70);
            pnNut.Controls.Add(Mui_ten_xuong_1);
            Mui_ten_xuong_1.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            Mui_ten_xuong_2.Visible = true;
            Mui_ten_xuong_2.Text = "Right=" + r;
            Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * r) + (Size / 2) - 30, Bn[r].Location.Y - Size - 70);
            pnNut.Controls.Add(Mui_ten_xuong_2);
            Mui_ten_xuong_2.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            j = 2 * i + 1;
            Mui_ten_len_3.Visible = true;
            Mui_ten_len_3.Text = "i=" + i;
            Mui_ten_len_3.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
            pnNut.Controls.Add(Mui_ten_len_3);
            Mui_ten_len_3.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            Mui_ten_len_1.Visible = true;
            Mui_ten_len_1.Text = "j=" + j;
            Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y + 2 * Size + 5);
            pnNut.Controls.Add(Mui_ten_len_1);
            Mui_ten_len_1.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            x = array[i];
			if (rad_Tang.Checked == true)
			{
				lb_code.SelectedIndex = 19;
				while (j <= r)
				{
					if (j < r)
					{
						if (array[j] < array[j + 1])
						{
							lb_code.SelectedIndex = 23;
							j++;
                            Mui_ten_len_1.Visible = true;
                            Mui_ten_len_1.Text = "j=" + j;
                            Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y + 2 * Size + 5);
                            pnNut.Controls.Add(Mui_ten_len_1);
                            Mui_ten_len_1.Refresh();
                            Tre((10 - trb_Tocdo.Value) * 100);
                        }
					}
					if (array[j] <= x)
					{
						return;
					}
					else
					{

						lb_code.SelectedIndex = 28;
                        Mui_ten_len_1.Visible = true;
                        Mui_ten_len_1.Text = "j=" + j;
                        Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y + 2 * Size + 5);
                        pnNut.Controls.Add(Mui_ten_len_1);
                        Mui_ten_len_1.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 100);
                        Mui_ten_len_3.Visible = true;
                        Mui_ten_len_3.Text = "i=" + i;
                        Mui_ten_len_3.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
                        pnNut.Controls.Add(Mui_ten_len_3);
                        Mui_ten_len_3.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 100);
                        SwapInts(array, i, j);
						Hoan_vi(Bn, i, j);
						Hoan_Tri_Node(i, j);
                        SwapInts(Pos, i, j);
                        lb_code.SelectedIndex = 29;
                        i = j;
                        j = 2 * i + 1;
                        x = array[i];
					}
				}
			}
			else
			{
                while (j <= r)
                {
                    lb_code.SelectedIndex = 20;
                    if (j < r)
                        if (array[j] > array[j + 1])
                        {
                            j++;
                            lb_code.SelectedIndex = 28;
                            Mui_ten_len_1.Visible = true;
                            Mui_ten_len_1.Text = "j=" + j;
                            Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y + 2 * Size + 5);
                            pnNut.Controls.Add(Mui_ten_len_1);
                            Mui_ten_len_1.Refresh();
                            Tre((10 - trb_Tocdo.Value) * 100);
                        }
					if (array[j] >= x)
						return;
					else
					{
                        lb_code.SelectedIndex = 28;
                        Mui_ten_len_1.Visible = true;
                        Mui_ten_len_1.Text = "j=" + j;
                        Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y + 2 * Size + 5);
                        pnNut.Controls.Add(Mui_ten_len_1);
                        Mui_ten_len_1.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 100);
                        Mui_ten_len_3.Visible = true;
                        Mui_ten_len_3.Text = "i=" + i;
                        Mui_ten_len_3.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
                        pnNut.Controls.Add(Mui_ten_len_3);
                        Mui_ten_len_3.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 100);
                        SwapInts(array, i, j);
						Hoan_vi(Bn, i, j);
						Hoan_Tri_Node(i, j);
                        SwapInts(Pos, i, j);
                        i = j;
						j = 2 * i + 1;
						x = array[i];
					}
				}
			}
		}
		private void CreateHeap(int[] array, int n)
		{
			int l;
            lb_code.SelectedIndex = 37;
            l = n / 2 - 1;
            if (l >= 0)
            {
                Mui_ten_xuong_1.Visible = true;
                Mui_ten_xuong_1.Text = "Left=" + l;
                Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * l) + (Size / 2) - 30, Bn[l].Location.Y - Size - 70);
                pnNut.Controls.Add(Mui_ten_xuong_1);
                Mui_ten_xuong_1.Refresh();
                Tre((10 - trb_Tocdo.Value) * 100);
            }
            while (l >= 0)
			{
				shift(array, l, n - 1);
				l = l - 1;
                lb_code.SelectedIndex = 41;
                if (l >= 0)
                {
                    Mui_ten_xuong_1.Visible = true;
                    Mui_ten_xuong_1.Text = "Left=" + l;
                    Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * l) + (Size / 2) - 30, Bn[l].Location.Y - Size - 70);
                    pnNut.Controls.Add(Mui_ten_xuong_1);
                    Mui_ten_xuong_1.Refresh();
                    Tre((10 - trb_Tocdo.Value) * 100);
                }
            }
		}
		private void HeapSort(int[] array, int n)
		{
            int r;
			CreateHeap(array, n);
			r = n - 1;
            lb_code.SelectedIndex = 4;
            Tre((10 - trb_Tocdo.Value) * 100);
            Mui_ten_len_2.Visible = true;
            Mui_ten_len_2.Text = "r=" + r;
            Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * r) + (Size / 2) - 30, Bn[r].Location.Y + 2 * Size + 5);
            pnNut.Controls.Add(Mui_ten_len_2);
            Mui_ten_len_2.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            while (r > 0)
			{
                Mui_ten_len_1.Visible = false;
                Mui_ten_len_3.Visible = false;
                Mui_ten_xuong_2.Visible = false;
                Mui_ten_xuong_1.Visible = false;
                pnNut.Refresh();
                if (rad_Tang.Checked == true)
				{
					if (array[0] > array[r])
					{
                        lb_code.SelectedIndex = 7;
                        Mui_ten_len_2.Visible = true;
                        Mui_ten_len_2.Text = "r=" + r;
                        Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * r) + (Size / 2) - 30, Bn[r].Location.Y + 2 * Size + 5);
                        pnNut.Controls.Add(Mui_ten_len_2);
                        Mui_ten_len_2.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 100);
                        SwapInts(array, 0, r);
						Hoan_vi(Bn, 0, r);
						Hoan_Tri_Node(0, r);
                        SwapInts(Pos, 0, r);
                    }
				}
				else
				{
					if (array[0] < array[r])
					{
						lb_code.SelectedIndex = 7;
                        Mui_ten_len_2.Visible = true;
                        Mui_ten_len_2.Text = "r=" + r;
                        Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * r) + (Size / 2) - 30, Bn[r].Location.Y + 2 * Size + 5);
                        pnNut.Controls.Add(Mui_ten_len_2);
                        Mui_ten_len_2.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 100);
                        SwapInts(array, 0, r);
						Hoan_vi(Bn, 0, r);
						Hoan_Tri_Node(0, r);
                        SwapInts(Pos, 0, r);
                    }
				}
                Bn[r].ForeColor = Color.White;
                Bn[r].FlatStyle = FlatStyle.Flat;
                Bn[r].BackgroundImage = Properties.Resources.daxep;
                Bn[r].BackgroundImageLayout = ImageLayout.Stretch;
                Bn[r].Refresh();
                lb_code.SelectedIndex = 8;
                r--;
                Tre((10 - trb_Tocdo.Value) * 100);
                Mui_ten_len_2.Visible = true;
                Mui_ten_len_2.Text = "r=" + r;
                Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * r) + (Size / 2) - 30, Bn[r].Location.Y + 2 * Size + 5);
                pnNut.Controls.Add(Mui_ten_len_2);
                Mui_ten_len_2.Refresh();
                if (r == 0)
                {
                    Bn[0].ForeColor = Color.White;
                    Bn[0].FlatStyle = FlatStyle.Flat;
                    Bn[0].BackgroundImage = Properties.Resources.daxep;
                    Bn[0].BackgroundImageLayout = ImageLayout.Stretch;
                    Bn[0].Refresh();
                }
                Tre((10 - trb_Tocdo.Value) * 100);
                if (r > 0)
				{
					CreateHeap(array, r);
				}
			}
		}
		private void HeapSort_Batdau(Button[] M)
		{
            HeapSort(Array, M.Length);
            for (int i = 0; i < M.Length; i++)
            {
                Bn[i].ForeColor = Color.White;
                Bn[i].FlatStyle = FlatStyle.Flat;
                Bn[i].BackgroundImage = Properties.Resources.daxep;
                Bn[i].BackgroundImageLayout = ImageLayout.Stretch;
                Bn[i].Refresh();
            }
            MessageBox.Show("Sap xep xong");
		}
		#endregion

		#region MergeSort
        private void MergeSort_Batdau(Button[] M)
        {
            MergeSort(Array, 0, M.Length - 1);
            for (int i = 0; i < M.Length; i++)
            {
                Bn[i].ForeColor = Color.White;
                Bn[i].FlatStyle = FlatStyle.Flat;
                Bn[i].BackgroundImage = Properties.Resources.daxep;
                Bn[i].BackgroundImageLayout = ImageLayout.Stretch;
                Bn[i].Refresh();
            }
            MessageBox.Show("Sap xep xong");
        }
        private void Merge(int[] array, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;
            Bn1 = new Button[n1];
            Bn2 = new Button[n2];
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
                L[i] = Array[l + 1];
            for (j = 0; j < n2; j++)
                R[j] = Array[m + 1 + j];
            i = 0;
            j = 0;
            k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    Array[k] = L[i];
                    i++;
                }
                else
                {
                    Array[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                Array[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                Array[k] = R[j];
                j++;
                k++;
            }
        }
		private void MergeSort(int[] array, int l,int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                MergeSort(array, l, m);
                MergeSort(array, m + 1, r);
                Merge(array, l, m, r);
            }
        }

        #endregion





        #endregion

        //hoan doi vi tri 2 phan tu trong mang
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

        private void btnxoamang_Click(object sender, EventArgs e)
        {
            pnNut.Controls.Clear();
        }

        private void lb_code_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Xoa_mang(Button[] Node)
        {
            btn_Ngaunhien.Enabled = false;
            btn_Batdau.Enabled = false;
            button5.Enabled = false;
            if (kttaomang == true)
            {
                for (int i = 0; i < SoPT; i++)
                {
                    this.Controls.Remove(Node[i]);
                    this.Controls.Remove(Chi_so[i]);

                }
                kttaomang = false;
            }
            if (kttaomang1 == true)
            {
                for (int i = 0; i < SoPT; i++)
                {
                    this.Controls.Remove(Bn1[i]);
                    this.Controls.Remove(Chi_so[i]);

                }
                kttaomang1 = false;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

            Xoa_mang(Bn);
            StreamReader Re = File.OpenText("TEST.txt");
            string input = null;
            int i = 0;
            int kt = 0;
            while ((kt < 1) && ((input = Re.ReadLine()) != null))
            {
                SoPT = Convert.ToInt32(input);
                kt++;
            }
            Tao_Mang(Properties.Resources.chuaxep);
            while (((input = Re.ReadLine()) != null) && (i < SoPT))
            {
                Array[i] = Convert.ToInt32(input);
                Bn[i].Text = Array[i].ToString();
                i++;
            }
            Re.Close();
            btn_Batdau.Enabled = true;
            rad_BubbleSort.Enabled = true;
            rad_HeapSort.Enabled = true;
            rad_InsertionSort.Enabled = true;
            rad_MergeSort.Enabled = true;
            rad_InterchangeSort.Enabled = true;
            rad_QuickSort.Enabled = true;
            rad_HeapSort.Enabled = true;
            rad_Giam.Enabled = true;
            rad_Tang.Enabled = true;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {

        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Mui_ten_xanh_len_1_Click(object sender, EventArgs e)
        {

        }

        private void Mui_ten_len_2_Click(object sender, EventArgs e)
        {

        }

        private void btn_xuatgip_Click(object sender, EventArgs e)
        {

        }

        private void text_ytuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}