using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace PMSapXep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Khai bao bien toan cuc
        public static int SoPT = 0;

        public static int[] Array; // mang chua m so nguyen
        public static Button[] Bn; //tao ra mang 
        public static Label[] Chi_so;
        public static int[] Pos; //vi tri cua button trong mang
        int HEIGHT = 100; //chieu cao luc di chuyen button
        int DemQuickSort = 0;// d?m s? l?n dich chuy?n qua trái ph?a c?a button
        // siZE luc d?u là 60, t s?a thành 47 

        int Size; // kich thuoc NUt
        int KhoangCachNut;//  
        int Canh_le;
        #endregion KHAI BÁO BI?N TOÀN C?C

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            btn_Ngaunhien.Enabled = true;
            btnxoamang.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;



            //khoi tao kich thuoc mang
            SoPT = int.Parse(txtNhapPT.Text.Trim());
            //tính toán v? tí ph?n t? d?a trên s? ph?n t?

            Tao_Mang(Properties.Resources.chuaxep);


        }

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
                    Bn[i].FlatStyle = FlatStyle.Flat;
                    Bn[i].BackgroundImage = nen;
                    Bn[i].BackgroundImageLayout = ImageLayout.Stretch;
                    //tao chi_So
                    Label lbChiSo = new Label();
                    lbChiSo.Text = i.ToString();
                    lbChiSo.Width = lbChiSo.Height = Size;
                    lbChiSo.Location = new Point(Canh_le + i * (btn.Width + KhoangCachNut) + Size / 2, btn.Location.Y + btn.Height * 3);
                    pnNut.Controls.Add(lbChiSo);
                    Chi_so[i] = lbChiSo;
                    Chi_so[i].ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("M?ng t? 2 -> 15 ph?n t?");
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
            text_ytuong.Text = "Xu?t phát t? d?u dãy, tìm t?t các các c?p ngh?ch th?, tri?t tiêu b?ng cách d?i ch? 2 ph?n t? trong c?p ngh?ch th?.\r\nL?p l?i x? lý trên v?i ph?n t? k? trong dãy.  ";
            lb_code.Items.Clear();
            code x = new code();
            x.Interchangesort(lb_code, true);
        }

        private void rad_SelectionSort_CheckedChanged(object sender, EventArgs e)
        {
            lb_code.Items.Clear();
            code x = new code();
            x.Selectionsort(lb_code, true);
            text_ytuong.Text = "Ch?n ph?n t? nh? nh?t trong N ph?n t? trong dãy hi?n hành ban d?u.Ðua ph?n t? này v? v? trí d?u dãy hi?n hành\r\nXem dãy hi?n hành ch? còn N-1 ph?n t? c?a dãy hi?n hành ban d?uB?t d?u t? v? trí th? 2\r\nL?p l?i quá trình trên cho dãy hi?n hành d?n khi dãy hi?n hành ch? còn 1 ph?n t?";

        }

        private void rad_HeapSort_CheckedChanged(object sender, EventArgs e)
        {
            lb_code.Items.Clear();
            text_ytuong.Text = "Heap Sort t?n d?ng du?c các phép so sánh ? bu?c i-1, mà thu?t toán s?p x?p ch?n tr?c ti?p không t?n d?ng du?c\r\nÐ? làm du?c di?u này Heap sort thao tác d?a trên cây.\r\n? cây trên, ph?n t? ? m?c i chính là ph?n t? l?n trong c?p ph?n t? ? m?c i +1, do dó ph?n t? ? nút g?c là ph?n t? l?n nh?t.\r\nN?u lo?i b? g?c ra kh?i cây, thì vi?c c?p  nh?t cây ch? xãy ra trên nh?ng nh?n liên quan d?n ph?n t? m?i lo?i b?, còn các nhánh khác thì b?o toàn.\r\nBu?c k? ti?p có th? s? d?ng l?i k?t qu? so sánh c?a bu?c hi?n t?i. ";
            code x = new code();
            x.heapsort(lb_code, true);
        }

        private void rad_MergeSort_CheckedChanged(object sender, EventArgs e)
        {
            lb_code.Items.Clear();
            code x = new code();
            x.Mergesort(lb_code, true);
            text_ytuong.Text = "Gi?i thu?t Merge sort s?p x?p dãy a1, a2, ..., an d?a trên nh?n xét sau: \r\n    +M?i dãy a1, a2, ..., an b?t k? là m?t t?p h?p các dãy con liên ti?p mà m?i dãy con d?u dã có th? t?. \r\n    +Dãy dã có th? t? coi nhu có 1 dãy con.\r\nM?ng A chia làm 02 ph?n b?ng nhau\r\nS?p x?p 02 ph?n\r\nTr?n 02 n?a l?i ";
        }

        private void rad_BubbleSort_CheckedChanged(object sender, EventArgs e)
        {
            lb_code.Items.Clear();
            code x = new code();
            x.bubblesort(lb_code, true);
            text_ytuong.Text = "Xu?t phát t? cu?i dãy, d?i ch? các c?p ph?n t? k? c?n d? dua ph?n t? nh? hon trong c?p ph?n t? dó v? v? trí dúng d?u dãy hi?n hành, sau dó s? không xét d?n nó ? bu?c ti?p theo, do v?y ? l?n x? lý th? i s? có v? trí d?u dãy là i.\r\nL?p l?i x? lý trên cho d?n khi không còn c?p ph?n t? nào d? xét.";

        }

        private void rad_ShakerSort_CheckedChanged(object sender, EventArgs e)
        {
            text_ytuong.Text = "Trong m?i l?n s?p x?p, duy?t m?ng theo 2 lu?t t? 2 phía khác nhau:\r\n    +Lu?t di: d?y ph?n t? nh? v? d?u m?ng.\r\n    +Lu?t v?: d?y ph?n t? l?n v? cu?i m?ng. \r\nGhi nh?n l?i nh?ng do?n dã s?p x?p nh?m ti?t ki?m các phép so sánh th?a.";
            lb_code.Items.Clear();
            code x = new code();
            x.ShakerSort(lb_code, true);
        }

        private void rad_InsertionSort_CheckedChanged(object sender, EventArgs e)
        {
            lb_code.Items.Clear();
            text_ytuong.Text = "Gi? s? có m?t dãy a0 , a1 ,... ,an-1 trong dó i ph?n t? d?u tiên a0 , a1 ,... ,ai-1 dã có th?\r\nTìm cách chèn ph?n t?  ai vào v? trí thích h?p c?a do?n dã du?c s?p d? có dãy m?i a0 , a1,... ,ai tr? nên có th? t?. V? trí này chính là v? trí gi?a hai ph?n t? ak-1 và ak th?a ak-1 < ai < ak (1=k=i). ";
            code x = new code();
            x.insertionsort(lb_code, true);
        }

        private void rad_BinaryInsertionSort_CheckedChanged(object sender, EventArgs e)
        {
            lb_code.Items.Clear();
            code x = new code();
            x.Binaryinsertionsort(lb_code, true);
            text_ytuong.Text = "Gi? s? có m?t dãy a0 , a1 ,... ,an-1 trong dó i ph?n t? d?u tiên a0 , a1 ,... ,ai-1 dã có th?\r\nChúng tas? d?ng tìm ki?m nh? phân d? chèn ph?n t?  ai vào v? trí thích h?p c?a do?n dã du?c s?p d? có dãy m?i a0 , a1,... ,ai tr? nên có th? t?. V? trí này chính là v? trí gi?a hai ph?n t? ak-1 và ak th?a ak-1 < ai < ak (1=k=i). .";
        }

        private void rad_ShellSort_CheckedChanged(object sender, EventArgs e)
        {
            text_ytuong.Text = "Phân ho?ch dãy thành các dãy con \r\nS?p x?p các dãy con theo phuong pháp chèn tr?c ti?p \r\nDùng phuong pháp chèn tr?c ti?p s?p x?p l?i c? dãy. ";
            lb_code.Items.Clear();
            code x = new code();
            x.shellsort(lb_code, true);
        }

        private void rad_QuickSort_CheckedChanged(object sender, EventArgs e)
        {
            lb_code.Items.Clear();
            code x = new code();
            x.quicksort(lb_code, true);
            text_ytuong.Text = "Gi?i thu?t QuickSort s?p x?p dãy a1, a2 ..., aN d?a trên vi?c phân ho?ch dãy ban d?u thành 3 ph?n\r\n    +Ph?n 1: G?m các ph?n t?  có giá tr? bé hon x \r\n    +Ph?n 2: G?m các ph?n t?  có giá tr? b?ng  x\r\n    +Ph?n 3: G?m các ph?n t?  có giá tr? l?n hon \r\nSau khi th?c hi?n phân ho?ch, dãy ban d?u du?c phân thành 3 do?n:\r\n    •1. ak  = x , v?i k = 1 .. j\r\n    • 2.ak = x , v?i k = j + 1..i - 1\r\n    • 3.ak  ? x , v?i k = i..N\r\nKhi do?n th? 2 dã có th? t?.\r\n    +N?u các do?n 1 và 3 ch? có 1 ph?n t? thì khi dó dãy con ban d?u dã du?c s?p.\r\n    +N?u các do?n 1 và 3  có nhi?u hon 1 ph?n t?  thì dãy ban d?u ch? có th? t? khi các do?n 1, 3 du?c s?p x?p.\r\n    +Ð? s?p x?p các do?n 1 và 3,ta phân ho?ch dãy theo phuong pháp ban d?u    ";
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


        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hàng d?u tiên ch?a s? ph?n t? m?ng, các hàng ti?p theo ch?a các ph?n t?", "Hu?ng d?n");
        }

        private void rad_Tang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Batdau_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = true;

            btnhuy.Enabled = true;
            button3.Enabled = false;
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
                MergeSort(Bn);

            btnTaoMang.Enabled = true;
            btnhuy.Enabled = true;
            button3.Enabled = false;
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
            for (int i = 0; i < 100; i++)
            {
                btn.Top = btn.Top - 1;
                System.Threading.Thread.Sleep((10 - trb_Tocdo.Value) / 3);
                Application.DoEvents();
            }
        }

        public void DiXuong(Control btn)
        {
            for (int i = 0; i < 100; i++)
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
                for (int j = i + 1; j < M.Length; j++)
                {

                    if (Array[i] > Array[j] && rad_Tang.Checked == true)
                    {
                        SwapInts(Array, i, j);
                        Hoan_vi(Bn, Pos[i], Pos[j]);
                        SwapInts(Pos, i, j);
                    }
                    else if (Array[i] < Array[j] && rad_Giam.Checked == true)
                    {
                        SwapInts(Array, i, j);
                        Hoan_vi(Bn, Pos[i], Pos[j]);
                        SwapInts(Pos, i, j);
                    }
                }
                //Dat_mau_node(Bn[i], Properties.Resources.daxep);
            }
            MessageBox.Show("S?p X?p Xong");
        }


        #endregion

        //#region SelectionSort        
        //private void SelectionSort(Button[] M)
        //{
        //    int min;
        //    for (int i = 0; i < M.Length - 1; i++)
        //    {
        //        min = i;
        //        for (int j = i + 1; j < M.Length; j++)
        //        {
        //            if (Array[j] < Array[min] && rad_Tang.Checked == true)
        //                min = j;
        //            if (Array[j] > Array[min] && rad_Giam.Checked == true)
        //                min = j;
        //        }
        //        if(i != min)
        //        {
        //            SwapInts(Array, i, min);
        //            Hoan_vi(Bn, Pos[i], Pos[min]);
        //            SwapInts(Pos, i, min);
        //        }


        //    }
        //    MessageBox.Show("S?p X?p Xong");
        //}

        //#endregion

        #region SelectionSort        
        private void SelectionSort(Button[] M)
        {
            int min;
            for (int i = 0; i < M.Length - 1; i++)
            {
                lb_code.SelectedIndex = 5;
                Thread.Sleep(3000);
                min = i;
                for (int j = i + 1; j < M.Length; j++)
                {
                    lb_code.SelectedIndex = 7;
                    Thread.Sleep(3000);
                    if (Array[j] < Array[min] && rad_Tang.Checked == true)
                    {
                        lb_code.SelectedIndex = 8;
                        Thread.Sleep(3000);
                        min = j;
                    }

                    if (Array[j] > Array[min] && rad_Giam.Checked == true)
                        min = j;
                    lb_code.SelectedIndex = 6;
                    Thread.Sleep(3000);
                }
                lb_code.SelectedIndex = 9;
                Thread.Sleep(3000);
                if (i != min)
                {

                    SwapInts(Array, i, min);
                    Hoan_vi(Bn, Pos[i], Pos[min]);
                    lb_code.SelectedIndex = 10;
                    Thread.Sleep(2000);
                    SwapInts(Pos, i, min);
                }
                lb_code.SelectedIndex = 3;
                Thread.Sleep(3000);

            }

        }

        #endregion

        #region BubbleSort
        private void BubbleSort(Button[] M)
        {
            for (int i = 1; i < M.Length; i++)
            {
                for (int j = M.Length - 1; j >= i; j--)
                {
                    if (Array[j - 1] > Array[j] && rad_Tang.Checked == true)
                    {
                        SwapInts(Array, j - 1, j);
                        Hoan_vi(Bn, Pos[j - 1], Pos[j]);
                        SwapInts(Pos, j - 1, j);
                    }
                    if (Array[j - 1] < Array[j] && rad_Giam.Checked == true)
                    {
                        SwapInts(Array, j - 1, j);
                        Hoan_vi(Bn, Pos[j - 1], Pos[j]);
                        SwapInts(Pos, j - 1, j);
                    }
                }
            }
            MessageBox.Show("S?p X?p Xong");
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
            for (int i = 1; i < M.Length; i++)
            {
                DemQuickSort = 0;
                int x = Array[i];
                int j = i;
                if (rad_Tang.Checked == true)
                {
                    if (j > 0 && Array[j - 1] > x)
                    {
                        DiLen(M[j]);
                        while (j > 0 && Array[j - 1] > x)
                        {
                            QuaPhai(M[j - 1]);
                            Hoan_Tri_Node(j, j - 1);
                            SwapInts(Array, j, j - 1);
                            j--;
                            DemQuickSort++;
                        }
                        QuaTrai(M[j], DemQuickSort);
                        DiXuong(M[j]);

                    }
                }
                if (rad_Giam.Checked == true)
                {
                    if (j > 0 && Array[j - 1] < x)
                    {
                        DiLen(M[j]);
                        while (j > 0 && Array[j - 1] < x)
                        {
                            QuaPhai(M[j - 1]);
                            Hoan_Tri_Node(j, j - 1);
                            SwapInts(Array, j, j - 1);
                            j--;
                            DemQuickSort++;
                        }
                        QuaTrai(M[j], DemQuickSort);
                        DiXuong(M[j]);

                    }
                }

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
            MessageBox.Show("Sap xep xong");
        }

        private void Quicksort(int[] array, int l, int r)
        {
            int i = l;
            int j = r;
            int x = array[(i + j) / 2];
            while (i <= j)
            {
                if (rad_Tang.Checked == true)
                {
                    while (array[i] < x)
                        i++;
                    while (array[j] > x)
                        j--;
                }
                if (rad_Giam.Checked == true)
                {
                    while (array[i] > x)
                        i++;
                    while (array[j] < x)
                        j--;
                }
                if (i <= j)
                {
                    if (array[i] != array[j])
                    {
                        SwapInts(array, i, j);
                        Hoan_vi(Bn, i, j);
                        Hoan_Tri_Node(i, j);
                    }
                    i++;
                    j--;
                }
            }
            if (j > l)
                Quicksort(array, l, j);
            if (i < r)
                Quicksort(array, i, r);
        }
        #endregion

        #region heap sort
        private void shift(int[] array, int l, int r)
        {
            int x, i, j;
            i = l;
            j = 2 * i + 1;
            x = array[i];
            if (rad_Tang.Checked == true)
            {
                while (j <= r)
                {
                    if (j < r)
                        if (array[j] < array[j + 1])
                            j++;
                    if (array[j] <= x)
                        return;
                    else
                    {
                        SwapInts(array, i, j);
                        Hoan_vi(Bn, i, j);
                        Hoan_Tri_Node(i, j);
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
                    if (j < r)
                        if (array[j] > array[j + 1])
                            j++;
                    if (array[j] >= x)
                        return;
                    else
                    {
                        SwapInts(array, i, j);
                        Hoan_vi(Bn, i, j);
                        Hoan_Tri_Node(i, j);
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
            l = n / 2 - 1;
            while (l >= 0)
            {
                shift(array, l, n - 1);
                l = l - 1;
            }
        }
        private void HeapSort(int[] array, int n)
        {
            int r;
            CreateHeap(array, n);
            r = n - 1;
            while (r > 0)
            {
                if (rad_Tang.Checked == true)
                {
                    if (array[0] > array[r])
                    {
                        SwapInts(array, 0, r);
                        Hoan_vi(Bn, 0, r);
                        Hoan_Tri_Node(0, r);
                    }
                }
                else
                {
                    if (array[0] < array[r])
                    {
                        SwapInts(array, 0, r);
                        Hoan_vi(Bn, 0, r);
                        Hoan_Tri_Node(0, r);
                    }
                }
                r--;
                if (r > 0)
                    CreateHeap(array, r);
            }
        }
        private void HeapSort_Batdau(Button[] M)
        {
            HeapSort(Array, M.Length);
        }
        #endregion

        #region MergeSort
        private void MergeSort(Button[] M)
        {

            switch (SoPT)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                    {
                        for (int i = 0; i < M.Length / 2; i++)
                        {
                            DiLen(M[i]);

                            DiLen(M[i + 1]);
                            if (Array[i] > Array[i + 1])
                            {
                                Hoan_vi(Bn, i, i + 1);
                                Hoan_Tri_Node(i, i + 1);
                            }

                        }
                    }

                    break;

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

        private void button4_Click(object sender, EventArgs e)
        {




            btn_Batdau.Enabled = true;

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {

        }

        private void btn_xuatgip_Click(object sender, EventArgs e)
        {

        }

    }
}