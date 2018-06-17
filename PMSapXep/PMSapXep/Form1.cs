using System;
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

//thu vien dung de ghi man hinh
using Microsoft.Expression.Encoder;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.ScreenCapture;


namespace PMSapXep
{
    public partial class Form1 : Form
    {

        private ScreenCaptureJob job;


        public Form1()
        {
            InitializeComponent();

            //auto load thuật toán và ý tưởng của thuật toán InterchangeSort
            rad_InsertionSort.Checked = true;
            rad_InterchangeSort.Checked = true;

        }

        void StartRecording()
        {
            job = new ScreenCaptureJob();
            System.Drawing.Size WorkingArea = SystemInformation.WorkingArea.Size; //full screen
            Rectangle captureRect = new Rectangle(0, 0, WorkingArea.Width, WorkingArea.Height);
            // -(WorkingArea.Width%4 )   -(WorkingArea.Height%4)
            job.CaptureRectangle = captureRect;
            job.ShowFlashingBoundary = true;
            job.ShowCountdown = true;
            job.CaptureMouseCursor = true;
            job.OutputPath = @"C:\Output";
            job.Start();
        }


        #region Khai bao bien toan cuc
        bool gif = false;
        public static int SoPT = 0;
        public static int[] Array; // mang chua m so nguyen
        public static Button[] Bn, Bn1, Bn2; //tao ra mang 

        public static Label[] Chi_so;
        public static int[] Pos; //vi tri cua   button trong mang
        int HEIGHT; //chieu cao luc di chuyen button
        int DemQuickSort = 0;// d?m s? l?n dich chuy?n qua trái ph?a c?a button\
        //bien dung check huy chuong trinh
        bool CheckHuy = false;

        int Size; // kich thuoc NUt
        int KhoangCachNut;//  
        int Canh_le;
        bool kttaomang, kttaomang1;
        #endregion 

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            btn_Ngaunhien.Enabled = true;
            //btnDocFile.Enabled = true;
            btnBangTay.Enabled = true;

            //khoi tao kich thuoc mang
            SoPT = int.Parse(txtNhapPT.Text.Trim());
            //tính toán vị trí phần tử dựa trên số phần tử
            Tao_Mang(Properties.Resources.chuaxep);
        }

        #region các hàm khác
        public void StopRecording()
        {
            if (job.Status == RecordStatus.Running)
                job.Stop();
            job.Dispose();
        }

        //Không cho phép nhập kí tự trong textbox
        private void txt_SoPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            rad_InterchangeSort.Checked = true;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnDocFile.Enabled = true;
            //this.TopMost = true;
            ////this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            //StartRecording();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NhapPT fr = new NhapPT();
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.Cancel)
            {
                btn_Batdau.Enabled = true;
            }
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
            notePad.StartInfo.Arguments = "\\ThuatToanSapXep\\DoAn\\PMSapXep\\PMSapXep/TEST.txt";
            notePad.Start();
        }

        private void btn_Batdau_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = true;
            btnhuy.Enabled = true;
            grbThuatToan.Enabled = false;
            grbTG.Enabled = false;
            btnDocFile.Enabled = false;
            btnBangTay.Enabled = false;
            btn_Ngaunhien.Enabled = false;
            btnTaoMang.Enabled = false;
            btn_Batdau.Enabled = false;
            btn_xuatgip.Enabled = false;
            btnDocFile.Enabled = false;


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
            if (rad_MergeSort.Checked == true)
                MergeSort_Batdau(Bn);

            btnTaoMang.Enabled = true;
            btnDocFile.Enabled = true;
            grbThuatToan.Enabled = true;
            grbTG.Enabled = true;
            btnPause.Enabled = false;
            btnhuy.Enabled = false;
            btn_xuatgip.Enabled = true;

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
            for (int i = 0; i < Size + 5; i++)
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

                //huy chuong trinh
                if (CheckHuy)
                {
                    pnNut.Controls.Clear();
                    break;
                }


                //Mui_ten_xanh_xuong_1.Visible = true;
                //Mui_ten_xanh_xuong_1.Text = "i=" + i;
                //Mui_ten_xanh_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y - Size - 70);
                //pnNut.Controls.Add(Mui_ten_xanh_xuong_1);
                //Mui_ten_xanh_xuong_1.Refresh();

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

                    //huy chuong trinh
                    if (CheckHuy)
                    {
                        pnNut.Controls.Clear();
                        break;
                    }

                    //Mui_ten_xanh_xuong_2.Visible = true;
                    //Mui_ten_xanh_xuong_2.Text = "j=" + j;
                    //Mui_ten_xanh_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y - Size - 70);
                    //pnNut.Controls.Add(Mui_ten_xanh_xuong_2);
                    //Mui_ten_xanh_xuong_2.Refresh();

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
            if (CheckHuy)
                CheckHuy = false;
            else
                MessageBox.Show("sắp xếp xong");
        }


        #endregion

        #region SelectionSort        
        private void SelectionSort(Button[] M)
        {
            int min;

            for (int i = 0; i < M.Length - 1; i++)
            {
                //huy chuong trinh
                if (CheckHuy)
                {
                    pnNut.Controls.Clear();
                    break;
                }
                lb_code.SelectedIndex = 5;

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
                    //huy chuong trinh
                    if (CheckHuy)
                    {
                        pnNut.Controls.Clear();
                        break;
                    }
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
            if (CheckHuy)
                CheckHuy = false;
            else
                MessageBox.Show("sắp xếp xong");
        }

        #endregion

        #region BubbleSort
        private void BubbleSort(Button[] M)
        {

            for (int i = 0; i < M.Length - 1; i++)
            {
                //huy chuong trinh
                if (CheckHuy)
                {
                    pnNut.Controls.Clear();
                    break;
                }

                Mui_ten_xuong_1.Visible = true;
                Mui_ten_xuong_1.Text = "i=" + i;
                Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + 5, Bn[i].Location.Y - Size - 80);
                pnNut.Controls.Add(Mui_ten_xuong_1);
                Mui_ten_xuong_1.Refresh();
                for (int j = M.Length - 1; j > i; j--)
                {
                    //huy chuong trinh
                    if (CheckHuy)
                    {
                        pnNut.Controls.Clear();
                        break;
                    }

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
                        Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * x) + 5, Bn[j].Location.Y + Size + 70);
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
                        Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * x) + 5, Bn[j].Location.Y + Size + 70);
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
            if (CheckHuy)
                CheckHuy = false;
            else
                MessageBox.Show("sắp xếp xong");
        }
        #endregion

        #region ShakerSort
        private void ShakerSort(Button[] M)
        {
            int Left = 0;
            lb_code.SelectedIndex = 4;

            int Right = M.Length - 1;
            lb_code.SelectedIndex = 5;
            Tre((10 - trb_Tocdo.Value) * 50);

            int k = 0;
            while (Left < Right)
            {
                //huy chuong trinh
                if (CheckHuy)
                {
                    pnNut.Controls.Clear();
                    break;
                }
                // Tre((10 - trb_Tocdo.Value) * 50);
                Mui_ten_xuong_1.Visible = true;
                Mui_ten_xuong_1.Text = "Left=" + Left;
                Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * Left) + 5, Bn[Left].Location.Y - Size - 80);
                pnNut.Controls.Add(Mui_ten_xuong_1);
                Mui_ten_xuong_1.Refresh();

                Mui_ten_len_1.Visible = true;
                Mui_ten_len_1.Text = "Right=" + Right;
                Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * Right) + 5, Bn[Right].Location.Y + Size + 70);
                pnNut.Controls.Add(Mui_ten_len_1);
                Mui_ten_len_1.Refresh();



                if (rad_Tang.Checked == true)
                {

                    for (int i = Left; i < Right; i++)
                    {
                        lb_code.SelectedIndex = 12;
                        Tre((10 - trb_Tocdo.Value) * 50);
                        Mui_ten_xuong_2.Visible = true;
                        Mui_ten_xuong_2.Text = "i=" + i;
                        Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + 5, Bn[i].Location.Y - Size - 80);
                        pnNut.Controls.Add(Mui_ten_xuong_2);
                        Mui_ten_xuong_2.Refresh();


                        Mui_ten_len_2.Visible = true;
                        Mui_ten_len_2.Text = "i+1=" + (i + 1);
                        Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * (i + 1)) + 5, Bn[i + 1].Location.Y + Size + 70);
                        pnNut.Controls.Add(Mui_ten_len_2);
                        Mui_ten_len_2.Refresh();


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
                        //huy chuong trinh
                        if (CheckHuy)
                        {
                            pnNut.Controls.Clear();
                            break;
                        }

                        Mui_ten_xuong_2.Visible = true;
                        Mui_ten_xuong_2.Text = "i=" + i;
                        Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + 5, Bn[i].Location.Y - Size - 80);
                        pnNut.Controls.Add(Mui_ten_xuong_2);
                        Mui_ten_xuong_2.Refresh();

                        Mui_ten_len_2.Visible = true;
                        Mui_ten_len_2.Text = "i-1=" + (i - 1);
                        Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * (i - 1)) + 5, Bn[i - 1].Location.Y + Size + 70);
                        pnNut.Controls.Add(Mui_ten_len_2);
                        Mui_ten_len_2.Refresh();
                        if (Array[i] < Array[i - 1])
                        {
                            SwapInts(Array, i, i - 1);
                            Hoan_vi(Bn, Pos[i - 1], Pos[i]);
                            SwapInts(Pos, i, i - 1);
                            k = i;
                        }
                    }
                    Left = k;
                }
                if (rad_Giam.Checked == true)
                {
                    for (int i = Left; i < Right; i++)
                    {
                        lb_code.SelectedIndex = 12;
                        Tre((10 - trb_Tocdo.Value) * 50);
                        Mui_ten_xuong_2.Visible = true;
                        Mui_ten_xuong_2.Text = "i=" + i;
                        Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + 5, Bn[i].Location.Y - Size - 80);
                        pnNut.Controls.Add(Mui_ten_xuong_2);
                        Mui_ten_xuong_2.Refresh();

                        Mui_ten_len_2.Visible = true;
                        Mui_ten_len_2.Text = "i+1=" + (i + 1);
                        Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * (i + 1)) + 5, Bn[i + 1].Location.Y + Size + 70);
                        pnNut.Controls.Add(Mui_ten_len_2);
                        Mui_ten_len_2.Refresh();
                        if (Array[i] < Array[i + 1])
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
                        Mui_ten_xuong_2.Visible = true;
                        Mui_ten_xuong_2.Text = "i=" + i;
                        Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + 5, Bn[i].Location.Y - Size - 80);
                        pnNut.Controls.Add(Mui_ten_xuong_2);
                        Mui_ten_xuong_2.Refresh();

                        Mui_ten_len_2.Visible = true;
                        Mui_ten_len_2.Text = "i-1=" + (i - 1);
                        Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * (i - 1)) + 5, Bn[i - 1].Location.Y + Size + 70);
                        pnNut.Controls.Add(Mui_ten_len_2);
                        Mui_ten_len_2.Refresh();
                        if (Array[i] > Array[i - 1])
                        {
                            SwapInts(Array, i, i - 1);
                            Hoan_vi(Bn, Pos[i - 1], Pos[i]);
                            SwapInts(Pos, i, i - 1);
                            k = i;
                        }
                    }
                    Left = k;

                }

            }
            for (int i = 0; i < M.Length; i++)
            {
                //huy chuong trinh
                if (CheckHuy)
                {
                    pnNut.Controls.Clear();
                    break;
                }

                Bn[i].ForeColor = Color.White;
                Bn[i].FlatStyle = FlatStyle.Flat;
                Bn[i].BackgroundImage = Properties.Resources.daxep;
                Bn[i].BackgroundImageLayout = ImageLayout.Stretch;
                Bn[i].Refresh();
            }
            if (CheckHuy)
                CheckHuy = false;
            else
                MessageBox.Show("sắp xếp xong");
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
                //huy chuong trinh
                if (CheckHuy)
                {
                    pnNut.Controls.Clear();
                    break;
                }

                Mui_ten_xuong_1.Visible = true;
                Mui_ten_xuong_1.Text = "i=" + i;
                Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * i), Bn[i].Location.Y - Size - 80);
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
                        Tre((10 - trb_Tocdo.Value) * 100);
                        DiLen(M[j]);
                        //

                        //
                        while (j > 0 && Array[j - 1] > x)
                        {
                            //huy chuong trinh
                            if (CheckHuy)
                            {
                                pnNut.Controls.Clear();
                                break;
                            }

                            int y = j - 1;
                            lb_code.SelectedIndex = 9;
                            Tre((10 - trb_Tocdo.Value) * 100);
                            Mui_ten_len_1.Visible = true;
                            Mui_ten_len_1.Text = "j-1=" + y;
                            Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * (j - 1)) , Bn[j - 1].Location.Y + Size + 10);
                            pnNut.Controls.Add(Mui_ten_len_1);
                            Mui_ten_len_1.Refresh();

                            QuaPhai(M[j - 1]);
                            Hoan_Tri_Node(j, j - 1);
                            SwapInts(Array, j, j - 1);


                            j--;
                            DemQuickSort++;
                        }
                        lb_code.SelectedIndex = 12;
                        Tre((10 - trb_Tocdo.Value) * 100);
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
                        Tre((10 - trb_Tocdo.Value) * 100);
                        DiLen(M[j]);
                        while (j > 0 && Array[j - 1] < x)
                        {
                            //huy chuong trinh
                            if (CheckHuy)
                            {
                                pnNut.Controls.Clear();
                                break;
                            }

                            int y = j - 1;
                            lb_code.SelectedIndex = 9;
                            Tre((10 - trb_Tocdo.Value) * 100);
                            Mui_ten_len_1.Visible = true;
                            Mui_ten_len_1.Text = "j-1=" + y;
                            Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * (j - 1)) + 5, Bn[j - 1].Location.Y + Size+10);
                            pnNut.Controls.Add(Mui_ten_len_1);
                            Mui_ten_len_1.Refresh();
                            lb_code.SelectedIndex = 9;
                            Tre((10 - trb_Tocdo.Value) * 100);
                            QuaPhai(M[j - 1]);
                            Hoan_Tri_Node(j, j - 1);
                            SwapInts(Array, j, j - 1);
                            j--;
                            DemQuickSort++;
                        }
                        lb_code.SelectedIndex = 12;
                        Tre((10 - trb_Tocdo.Value) * 100);
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
            if (CheckHuy)
                CheckHuy = false;
            else
                MessageBox.Show("sắp xếp xong");
        }
        #endregion

        #region BinaryInsertionSort
        private void BinaryInsertionSort(Button[] M)
        {
            int a = 10 - trb_Tocdo.Value;
            //   int a = 500;
            lb_code.SelectedIndex = 0;
            System.Threading.Thread.Sleep(a);
            int l, r, m, i = 1, j = -1, x;
            Mui_ten_xuong_1.Visible = true;
            Mui_ten_xuong_1.Text = "i=" + i;
            Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 20, Bn[i].Location.Y - Size - 70);
            pnNut.Controls.Add(Mui_ten_xuong_1);
            Mui_ten_xuong_1.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            lb_code.SelectedIndex = 2;
            System.Threading.Thread.Sleep(a);
            int DoiCho = 0;
            for (i = 1; i < M.Length; i++)
            {
                //huy chuong trinh
                if (CheckHuy)
                {
                    pnNut.Controls.Clear();
                    break;
                }

                //doi mau node
                Bn[i - 1].ForeColor = Color.White;
                Bn[i - 1].FlatStyle = FlatStyle.Flat;
                Bn[i - 1].BackgroundImage = Properties.Resources.daxep;
                Bn[i - 1].BackgroundImageLayout = ImageLayout.Stretch;
                Bn[i - 1].Refresh();

                lb_code.SelectedIndex = 3;
                Tre((10 - trb_Tocdo.Value) * 100);
                Mui_ten_xuong_1.Visible = true;
                Mui_ten_xuong_1.Text = "i=" + i;
                Mui_ten_xuong_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 20, Bn[i].Location.Y - Size - 70);
                Mui_ten_xuong_1.Refresh();
                Tre((10 - trb_Tocdo.Value) * 100);
                DemQuickSort = 0;
                DoiCho = 0;
                x = Array[i];
                lb_code.SelectedIndex = 5;
                System.Threading.Thread.Sleep(a);
                lb_code.SelectedIndex = 6;
                System.Threading.Thread.Sleep(a);
                l = 0;
                Mui_ten_len_1.Visible = true;
                Mui_ten_len_1.Text = "Left = " + l;
                Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * l) + (Size / 2) - 20, Bn[l].Location.Y + Size + 20);
                pnNut.Controls.Add(Mui_ten_len_1);
                Mui_ten_len_1.Refresh();
                Tre((10 - trb_Tocdo.Value) * 100);
                lb_code.SelectedIndex = 7;
                System.Threading.Thread.Sleep(a);
                lb_code.SelectedIndex = 8;
                System.Threading.Thread.Sleep(a);
                r = i;
                 Mui_ten_len_2 .Visible = true;
                Mui_ten_len_2.Text = "Right = " + r;
                Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * r) + (Size / 2) - 20, Bn[r].Location.Y + Size + 10);
                pnNut.Controls.Add(Mui_ten_len_2);
                Mui_ten_len_2.Refresh();
                Tre((10 - trb_Tocdo.Value) * 100);

                lb_code.SelectedIndex = 9;
                System.Threading.Thread.Sleep(a);

                while (l <= r) // tìm vị trí chèn x
                {
                    //huy chuong trinh
                    if (CheckHuy)
                    {
                        pnNut.Controls.Clear();
                        break;
                    }

                    lb_code.SelectedIndex = 10;
                    System.Threading.Thread.Sleep(a);

                    m = (l + r) / 2;
                    lb_code.SelectedIndex = 12;
                    System.Threading.Thread.Sleep(a);
                    Mui_ten_len_2.Visible = true;
                    Mui_ten_len_2.Text = "Mid = " + m;
                    Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * m) + (Size / 2) - 20, Bn[m].Location.Y + Size + 50);
                    pnNut.Controls.Add(Mui_ten_len_2);
                    Mui_ten_len_2.Refresh();
                    Tre((10 - trb_Tocdo.Value) * 100);


                    if (rad_Tang.Checked == true)
                    {

                        if (x < Array[m])
                        {

                            r = m - 1;
                            lb_code.SelectedIndex = 13;
                            System.Threading.Thread.Sleep(a);
                            if (r >= 0)
                            {
                                Mui_ten_len_2.Text = "Right = " + r;
                                Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * r) + (Size / 2) - 20, Bn[r].Location.Y + Size + 10);
                                Mui_ten_len_2.Refresh();
                            }
                            Tre((10 - trb_Tocdo.Value) * 100);
                            DoiCho++;
                        }
                        else
                        {
                            l = m + 1;
                            Mui_ten_len_1.Text = "Left = " + l;
                            Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * l) + (Size / 2) - 20, Bn[l].Location.Y + Size + 5);
                            Mui_ten_len_1.Refresh();
                            Tre((10 - trb_Tocdo.Value) * 100);
                            lb_code.SelectedIndex = 14;
                            System.Threading.Thread.Sleep(a);
                        }
                    }
                    else if (rad_Giam.Checked == true)
                    {

                        if (x > Array[m])
                        {
                            r = m - 1;
                            lb_code.SelectedIndex = 13;
                            System.Threading.Thread.Sleep(a);

                            if (r >= 0)
                            {
                                Mui_ten_len_2.Text = "Right = " + r;
                                Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * r) + (Size / 2) - 20, Bn[r].Location.Y + Size + 17);
                                Mui_ten_len_2.Refresh();
                            }

                            Tre((10 - trb_Tocdo.Value) * 100);

                            DoiCho++;
                        }
                        else
                        {
                            l = m + 1;
                            lb_code.SelectedIndex = 14;
                            System.Threading.Thread.Sleep(a);
                            Mui_ten_len_1.Text = "Left = " + l;
                            Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * l) + (Size / 2) - 20, Bn[l].Location.Y + Size + 20);
                            Mui_ten_len_1.Refresh();
                            Tre((10 - trb_Tocdo.Value) * 100);
                        }
                    }

                }
                if (DoiCho == 0)
                    continue;
                DiLen(M[i]);
                for (j = i - 1; j >= l; j--)
                {
                    //huy chuong trinh
                    if (CheckHuy)
                    {
                        pnNut.Controls.Clear();
                        break;
                    }

                    lb_code.SelectedIndex = 16;
                    Tre((10 - trb_Tocdo.Value) * 100);
                    lb_code.SelectedIndex = 17;
                    System.Threading.Thread.Sleep(a);

                    QuaPhai(M[j]);
                    SwapInts(Array, j, j + 1);
                    Hoan_Tri_Node(j, j + 1);

                    Mui_ten_xuong_2.Visible = true;
                    Mui_ten_xuong_2.Text = "j=" + j;
                    Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 20, Bn[j].Location.Y - Size - 50); ;
                    pnNut.Controls.Add(Mui_ten_xuong_2);
                    Mui_ten_xuong_2.Refresh();
                    Tre((10 - trb_Tocdo.Value) * 100);

                    DemQuickSort++;
                }
                lb_code.SelectedIndex = 18;
                System.Threading.Thread.Sleep(a);
                QuaTrai(M[l], DemQuickSort);

                DiXuong(M[l]);

                Bn[l].ForeColor = Color.White;
                Bn[l].FlatStyle = FlatStyle.Flat;
                Bn[l].BackgroundImage = Properties.Resources.daxep;
                Bn[l].BackgroundImageLayout = ImageLayout.Stretch;
                Bn[l].Refresh();

            }
            if (CheckHuy)
                CheckHuy = false;
            else
                MessageBox.Show("sắp xếp xong");
        }
        #endregion

        #region ShellSort
        private void ShellSort(Button[] M)
        {
            lb_code.SelectedIndex = 0;
            Tre((10 - trb_Tocdo.Value) * 100);
            int i = 0, j = 0, step, temp;
            lb_code.SelectedIndex = 2;
            Mui_ten_len_1.Visible = true;
            Mui_ten_len_1.Text = "i=" + i;
            Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
            pnNut.Controls.Add(Mui_ten_len_1);
            Mui_ten_xuong_1.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            Mui_ten_xuong_2.Visible = true;
            Mui_ten_xuong_2.Text = "j=" + j;
            Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y - Size - 80);
            pnNut.Controls.Add(Mui_ten_xuong_2);
            Mui_ten_xuong_2.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);

            for (step = SoPT / 2; step > 0; step = step / 2)
            {
                if (CheckHuy)
                {
                    pnNut.Controls.Clear();
                    break;
                }

                txtStep.Visible = true;
                pnNut.Controls.Add(txtStep);
                txtStep.Text = step.ToString();
                panel1.Refresh();
                lb_code.SelectedIndex = 3;
                Tre((10 - trb_Tocdo.Value) * 100);
                for (i = 0; i < SoPT; i = i + step)
                {
                    if (CheckHuy)
                    {
                        pnNut.Controls.Clear();
                        break;
                    }

                    lb_code.SelectedIndex = 5;
                    Tre((10 - trb_Tocdo.Value) * 100);
                    Mui_ten_len_1.Text = "i=" + i;
                    Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
                    Mui_ten_len_1.Refresh();
                    Tre((10 - trb_Tocdo.Value) * 100);
                    lb_code.SelectedIndex = 7;
                    Tre((10 - trb_Tocdo.Value) * 100);
                    temp = Array[i];
                    if (rad_Tang.Checked == true)
                    {
                        for (j = i; j > 0 && Array[j - step] > temp; j = j - step)
                        {
                            if (CheckHuy)
                            {
                                pnNut.Controls.Clear();
                                break;
                            }

                            lb_code.SelectedIndex = 8;
                            Tre((10 - trb_Tocdo.Value) * 100);
                            Mui_ten_xuong_2.Visible = true;
                            Mui_ten_xuong_2.Text = "j=" + j;
                            Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y - Size - 80);
                            Mui_ten_xuong_2.Refresh();
                            Tre((10 - trb_Tocdo.Value) * 100);
                            lb_code.SelectedIndex = 10;
                            Tre((10 - trb_Tocdo.Value) * 100);
                            Array[j] = Array[j - step];
                            SwapInts(Array, j - step, j);
                            Hoan_vi(Bn, Pos[j - step], Pos[j]);
                            SwapInts(Pos, j - step, j);
                        }

                        lb_code.SelectedIndex = 12;
                        Tre((10 - trb_Tocdo.Value) * 100);
                        Array[j] = temp;

                    }
                    else if (rad_Giam.Checked == true)
                    {
                        for (j = i; j > 0 && Array[j - step] < temp; j = j - step)
                        {
                            if (CheckHuy)
                            {
                                pnNut.Controls.Clear();
                                break;
                            }

                            lb_code.SelectedIndex = 8;
                            Tre((10 - trb_Tocdo.Value) * 100);
                            Mui_ten_xuong_2.Visible = true;
                            Mui_ten_xuong_2.Text = "j=" + j;
                            Mui_ten_xuong_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y - Size - 80);
                            Mui_ten_xuong_2.Refresh();
                            Tre((10 - trb_Tocdo.Value) * 100);
                            lb_code.SelectedIndex = 10;
                            Tre((10 - trb_Tocdo.Value) * 100);
                            Array[j] = Array[j - step];
                            SwapInts(Array, j - step, j);
                            Hoan_vi(Bn, Pos[j - step], Pos[j]);
                            SwapInts(Pos, j - step, j);
                        }
                        lb_code.SelectedIndex = 12;
                        Tre((10 - trb_Tocdo.Value) * 100);
                        Array[j] = temp;

                    }

                }

            }
            for (int a = 0; a < M.Length; a++)
            {
                M[a].ForeColor = Color.White;
                M[a].FlatStyle = FlatStyle.Flat;
                M[a].BackgroundImage = Properties.Resources.daxep;
                M[a].BackgroundImageLayout = ImageLayout.Stretch;
                M[a].Refresh();
            }
            if (CheckHuy)
                CheckHuy = false;
            else
                MessageBox.Show("sắp xếp xong");
        }
        #endregion

        #region quick sort
        private void Quicksort_Batdau(Button[] M)
        {
            Quicksort(Array, 0, M.Length - 1);
            pnNut.Controls.Remove(Mui_ten_len_1);
            pnNut.Controls.Remove(Mui_ten_len_2);
            pnNut.Controls.Remove(Mui_ten_len_2);
            pnNut.Controls.Remove(Mui_ten_xuong_1);
            pnNut.Controls.Remove(Mui_ten_xuong_2);
            for (int r = 0; r < M.Length; r++)
            {
                Bn[r].ForeColor = Color.White;
                Bn[r].FlatStyle = FlatStyle.Flat;
                Bn[r].BackgroundImage = Properties.Resources.daxep;
                Bn[r].BackgroundImageLayout = ImageLayout.Stretch;
                Bn[r].Refresh();
            }

            if (CheckHuy)
                CheckHuy = false;
            else
                MessageBox.Show("sắp xếp xong");
        }

        private void Quicksort(int[] array, int l, int r)
        {
            if (CheckHuy)
            {
                pnNut.Controls.Clear();
                return;
            }
            pnNut.Controls.Remove(Mui_ten_len_1);
            pnNut.Controls.Remove(Mui_ten_len_2);
            pnNut.Controls.Remove(Mui_ten_len_2);
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
            Mui_ten_len_2.Visible = true;
            Mui_ten_len_2.Text = "i=" + i;
            Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
            pnNut.Controls.Add(Mui_ten_len_2);
            Mui_ten_len_2.Refresh();
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
            Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * X) + (Size / 2) - 30, Bn[X].Location.Y + 2 * Size + 5 + 170);
            pnNut.Controls.Add(Mui_ten_len_2);
            Mui_ten_len_2.Refresh();
            Tre((10 - trb_Tocdo.Value) * 100);
            while (i <= j)
            {
                if (CheckHuy)
                {
                    pnNut.Controls.Clear();
                    return;
                }
                if (rad_Tang.Checked == true)
                {
                    while (array[i] < x)
                    {
                        if (CheckHuy)
                        {
                            pnNut.Controls.Clear();
                            return;
                        }
                        lb_code.SelectedIndex = 8;
                        i++;
                        Mui_ten_len_2.Text = "i=" + i;
                        Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
                        Mui_ten_len_2.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 100);
                    }
                    while (array[j] > x)
                    {
                        if (CheckHuy)
                        {
                            pnNut.Controls.Clear();
                            return;
                        }
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
                    while (array[i] > x)
                    {
                        if (CheckHuy)
                        {
                            pnNut.Controls.Clear();
                            return;
                        }
                        lb_code.SelectedIndex = 8;
                        i++;
                        Mui_ten_len_2.Text = "i=" + i;
                        Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
                        Mui_ten_len_2.Refresh();
                        Tre((10 - trb_Tocdo.Value) * 100);
                    }
                    while (array[j] < x)
                    {
                        if (CheckHuy)
                        {
                            pnNut.Controls.Clear();
                            return;
                        }
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
                        Mui_ten_len_2.Text = "i=" + i;
                        Mui_ten_len_1.Location = new Point((Canh_le + (Size + KhoangCachNut) * j) + (Size / 2) - 30, Bn[j].Location.Y + 2 * Size + 5);
                        Mui_ten_len_1.Refresh();
                        Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
                        Mui_ten_len_2.Refresh();
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
            Mui_ten_len_2.Visible = true;
            Mui_ten_len_2.Text = "i=" + i;
            Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
            pnNut.Controls.Add(Mui_ten_len_2);
            Mui_ten_len_2.Refresh();
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
                    if (CheckHuy)
                    {
                        pnNut.Controls.Clear();
                        pnNut.Refresh();
                        return;
                    }
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
                        Mui_ten_len_2.Visible = true;
                        Mui_ten_len_2.Text = "i=" + i;
                        Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
                        pnNut.Controls.Add(Mui_ten_len_2);
                        Mui_ten_len_2.Refresh();
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
                    if (CheckHuy)
                    {
                        pnNut.Controls.Clear();
                        pnNut.Refresh();
                        return;
                    }
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
                        Mui_ten_len_2.Visible = true;
                        Mui_ten_len_2.Text = "i=" + i;
                        Mui_ten_len_2.Location = new Point((Canh_le + (Size + KhoangCachNut) * i) + (Size / 2) - 30, Bn[i].Location.Y + 2 * Size + 5);
                        pnNut.Controls.Add(Mui_ten_len_2);
                        Mui_ten_len_2.Refresh();
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
                if (CheckHuy)
                {
                    pnNut.Controls.Clear();
                    pnNut.Refresh();
                    return;
                }
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
                if (CheckHuy)
                {
                    pnNut.Controls.Clear();
                    pnNut.Refresh();
                    return;
                }
                Mui_ten_len_1.Visible = false;
                Mui_ten_len_2.Visible = false;
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
            if (CheckHuy)
                CheckHuy = false;
            else
                MessageBox.Show("sắp xếp xong");
        }
        #endregion

        #region merge sort
        private void MergeSort_Batdau(Button[] M)
        {
            for (int i = 0; i < M.Length; i++)
                pnNut.Controls.Remove(Chi_so[i]);
            //Tre(1000);
            Tre((10 - trb_Tocdo.Value) * 100);
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
            {
                L[i] = array[l + i];
                Button btn = new Button();
                btn.Text = Bn[l + i].Text;
                btn.Width = btn.Height = Size;
                btn.Location = new Point(Bn[l + i].Location.X, 0);
                pnNut.Controls.Add(btn);
                Bn1[i] = btn;
                Bn1[i].ForeColor = Color.White;
                Bn1[i].FlatStyle = FlatStyle.Flat;
                Bn1[i].BackgroundImage = Bn[0].BackgroundImage;
                Bn1[i].BackgroundImageLayout = ImageLayout.Stretch;
            }
            //re(1500);
            Tre((10 - trb_Tocdo.Value) * 100);
            for (j = 0; j < n2; j++)
            {
                R[j] = array[m + 1 + j];
                Button btn = new Button();
                btn.Text = Bn[m + 1 + j].Text;
                btn.Width = btn.Height = Size;
                btn.Location = new Point(Bn[m + 1 + j].Location.X, pnNut.Height - 90);
                pnNut.Controls.Add(btn);
                Bn2[j] = btn;
                Bn2[j].ForeColor = Color.White;
                Bn2[j].FlatStyle = FlatStyle.Flat;
                Bn2[j].BackgroundImage = Bn[0].BackgroundImage;
                Bn2[j].BackgroundImageLayout = ImageLayout.Stretch;
            }
            //Tre(1500);
            Tre((10 - trb_Tocdo.Value) * 100);
            i = 0;
            j = 0;
            k = l;
            int Y1 = Bn[0].Location.Y / 2;
            int Y2 = (Bn2[0].Location.Y + Bn[0].Location.Y) / 2;
            while (i < n1 && j < n2)
            {
                if (rad_Tang.Checked == true)
                {
                    if (L[i] <= R[j])
                    {
                        array[k] = L[i];
                        while (Bn1[i].Location.Y != Y1)
                        {
                            Bn1[i].Location = new Point(Bn1[i].Location.X, Bn1[i].Location.Y + 1);
                            Tre((10 - trb_Tocdo.Value) / 3);
                        }
                        while (Bn1[i].Location.X != Bn[k].Location.X)
                        {
                            if (Bn1[i].Location.X < Bn[k].Location.X)
                                Bn1[i].Location = new Point(Bn1[i].Location.X + 1, Bn1[i].Location.Y);
                            else
                                Bn1[i].Location = new Point(Bn1[i].Location.X - 1, Bn1[i].Location.Y);
                            Tre((10 - trb_Tocdo.Value) / 3);
                        }
                        while (Bn1[i].Location.Y != Bn[k].Location.Y)
                        {
                            Bn1[i].Location = new Point(Bn1[i].Location.X, Bn1[i].Location.Y + 1);
                            Tre((10 - trb_Tocdo.Value) / 3);
                        }
                        pnNut.Controls.Remove(Bn1[i]);
                        pnNut.Refresh();
                        Bn[k].Text = array[k].ToString();
                        i++;
                    }
                    else
                    {
                        array[k] = R[j];
                        while (Bn2[j].Location.Y != Y2)
                        {
                            Bn2[j].Location = new Point(Bn2[j].Location.X, Bn2[j].Location.Y - 1);
                            Tre((10 - trb_Tocdo.Value) / 3);
                        }
                        while (Bn2[j].Location.X != Bn[k].Location.X)
                        {
                            if (Bn2[j].Location.X < Bn[k].Location.X)
                                Bn2[j].Location = new Point(Bn2[j].Location.X + 1, Bn2[j].Location.Y);
                            else
                                Bn2[j].Location = new Point(Bn2[j].Location.X - 1, Bn2[j].Location.Y);
                            Tre((10 - trb_Tocdo.Value) / 3);
                        }
                        while (Bn2[j].Location.Y != Bn[k].Location.Y)
                        {
                            Bn2[j].Location = new Point(Bn2[j].Location.X, Bn2[j].Location.Y - 1);
                            Tre((10 - trb_Tocdo.Value) / 3);
                        }
                        pnNut.Controls.Remove(Bn2[j]);
                        pnNut.Refresh();
                        Bn[k].Text = array[k].ToString();
                        j++;
                    }
                }
                else
                {
                    if (L[i] >= R[j])
                    {
                        array[k] = L[i];
                        while (Bn1[i].Location.Y != Y1)
                        {
                            Bn1[i].Location = new Point(Bn1[i].Location.X, Bn1[i].Location.Y + 1);
                            Tre((10 - trb_Tocdo.Value) / 3);
                        }
                        while (Bn1[i].Location.X != Bn[k].Location.X)
                        {
                            if (Bn1[i].Location.X < Bn[k].Location.X)
                                Bn1[i].Location = new Point(Bn1[i].Location.X + 1, Bn1[i].Location.Y);
                            else
                                Bn1[i].Location = new Point(Bn1[i].Location.X - 1, Bn1[i].Location.Y);
                            Tre((10 - trb_Tocdo.Value) / 3);
                        }
                        while (Bn1[i].Location.Y != Bn[k].Location.Y)
                        {
                            Bn1[i].Location = new Point(Bn1[i].Location.X, Bn1[i].Location.Y + 1);
                            Tre((10 - trb_Tocdo.Value) / 3);
                        }
                        pnNut.Controls.Remove(Bn1[i]);
                        pnNut.Refresh();
                        Bn[k].Text = array[k].ToString();
                        i++;
                    }
                    else
                    {
                        array[k] = R[j];
                        while (Bn2[j].Location.Y != Y2)
                        {
                            Bn2[j].Location = new Point(Bn2[j].Location.X, Bn2[j].Location.Y - 1);
                            Tre((10 - trb_Tocdo.Value) / 3);
                        }
                        while (Bn2[j].Location.X != Bn[k].Location.X)
                        {
                            if (Bn2[j].Location.X < Bn[k].Location.X)
                                Bn2[j].Location = new Point(Bn2[j].Location.X + 1, Bn2[j].Location.Y);
                            else
                                Bn2[j].Location = new Point(Bn2[j].Location.X - 1, Bn2[j].Location.Y);
                            Tre((10 - trb_Tocdo.Value) / 3);
                        }
                        while (Bn2[j].Location.Y != Bn[k].Location.Y)
                        {
                            Bn2[j].Location = new Point(Bn2[j].Location.X, Bn2[j].Location.Y - 1);
                            Tre((10 - trb_Tocdo.Value) / 3);
                        }
                        pnNut.Controls.Remove(Bn2[j]);
                        pnNut.Refresh();
                        Bn[k].Text = array[k].ToString();
                        j++;
                    }
                }
                k++;
            }
            while (i < n1)
            {
                array[k] = L[i];
                while (Bn1[i].Location.Y != Y1)
                {
                    Bn1[i].Location = new Point(Bn1[i].Location.X, Bn1[i].Location.Y + 1);
                    Tre((10 - trb_Tocdo.Value) / 3);
                }
                while (Bn1[i].Location.X != Bn[k].Location.X)
                {
                    if (Bn1[i].Location.X < Bn[k].Location.X)
                        Bn1[i].Location = new Point(Bn1[i].Location.X + 1, Bn1[i].Location.Y);
                    else
                        Bn1[i].Location = new Point(Bn1[i].Location.X - 1, Bn1[i].Location.Y);
                    Tre((10 - trb_Tocdo.Value) / 3);
                }
                while (Bn1[i].Location.Y != Bn[k].Location.Y)
                {
                    Bn1[i].Location = new Point(Bn1[i].Location.X, Bn1[i].Location.Y + 1);
                    Tre((10 - trb_Tocdo.Value) / 3);
                }
                pnNut.Controls.Remove(Bn1[i]);
                pnNut.Refresh();
                Bn[k].Text = array[k].ToString();
                i++;
                k++;
            }
            while (j < n2)
            {
                array[k] = R[j];
                while (Bn2[j].Location.Y != Y2)
                {
                    Bn2[j].Location = new Point(Bn2[j].Location.X, Bn2[j].Location.Y - 1);
                    Tre((10 - trb_Tocdo.Value) / 3);
                }
                while (Bn2[j].Location.X != Bn[k].Location.X)
                {
                    if (Bn2[j].Location.X < Bn[k].Location.X)
                        Bn2[j].Location = new Point(Bn2[j].Location.X + 1, Bn2[j].Location.Y);
                    else
                        Bn2[j].Location = new Point(Bn2[j].Location.X - 1, Bn2[j].Location.Y);
                    Tre((10 - trb_Tocdo.Value) / 3);
                }
                while (Bn2[j].Location.Y != Bn[k].Location.Y)
                {
                    Bn2[j].Location = new Point(Bn2[j].Location.X, Bn2[j].Location.Y - 1);
                    Tre((10 - trb_Tocdo.Value) / 3);
                }
                pnNut.Controls.Remove(Bn2[j]);
                pnNut.Refresh();
                Bn[k].Text = array[k].ToString();
                j++;
                k++;
            }
            for (i = 0; i < n1; i++)
                pnNut.Controls.Remove(Bn1[i]);
            for (j = 0; j < n2; j++)
                pnNut.Controls.Remove(Bn2[j]);
            pnNut.Refresh();
        }
        private void MergeSort(int[] array, int l, int r)
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


        private void groupBox3_Enter(object sender, EventArgs e)
        {
            rad_Tang.Checked = true;
        }


        public void Xoa_mang(Button[] Node)
        {
            btn_Ngaunhien.Enabled = false;
            btn_Batdau.Enabled = false;
            btnBangTay.Enabled = true;
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

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            CheckHuy = true;
            btn_xuatgip.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (job != null)
            {
                if (job.Status == RecordStatus.Running)
                    job.Stop();
                job.Dispose();
            }
            if (gif == true)
            {
                MessageBox.Show("Bạn đã lưu file gif ở! C:\\OutPut ");
            }
            else
            {
                string path = @"C:\Output";
                DeleteDirectory(path);
            }
        }

        private void Mui_ten_xanh_xuong_2_Click(object sender, EventArgs e)
        {

        }

        void DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                //Delete all files from the Directory
                foreach (string file in Directory.GetFiles(path))
                {
                    File.Delete(file);
                }
                //Delete all child Directories
                foreach (string directory in Directory.GetDirectories(path))
                {
                    DeleteDirectory(directory);
                }
                //Delete a Directory
                Directory.Delete(path);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Xoa_mang(Bn);
            string LocationFile = null;     //biến lưu địa chỉ file  
            string input = null;
            int i = 0;
            int kt = 0;
            StreamReader Re;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //lấy đị chỉ của file
                LocationFile = openFileDialog1.FileName;
            }

            try
            {
                //bắt lỗi cancel dialog
                Re = File.OpenText(LocationFile);

                while ((kt < 1) && ((input = Re.ReadLine()) != null))
                {
                    try
                    {
                        SoPT = Convert.ToInt32(input);
                    }
                    catch
                    {
                        MessageBox.Show("file nhập vào không hợp lệ!");
                        return;
                    }
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
            }
            catch
            {
                MessageBox.Show("Bạn cần mở File ");
            }

        }

        private void btn_xuatgip_Click(object sender, EventArgs e)
        {
            if (job != null)
            {
                if (job.Status == RecordStatus.Running)
                    job.Stop();
                job.Dispose();
            }
            gif = true;
        }
    }
}

