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
        public static Label[] Chi_so;
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
            //tính toán vị tí phần tử dựa trên số phần tử
            switch(SoPT)
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
                Bn = new Button[SoPT]; //khoi tao Button Bn gom n Button
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
                    Bn[i].ForeColor = Color.White;
                    Bn[i].BackColor = Color.OrangeRed;

                    //tao chi_So
                    Label lbChiSo = new Label();
                    lbChiSo.Text = i.ToString();
                    lbChiSo.Width = lbChiSo.Height = Size;
                    lbChiSo.Location = new Point(Canh_le + i * (btn.Width + KhoangCachNut) + Size/2, btn.Location.Y + 100);
                    pnNut.Controls.Add(lbChiSo);
                    Chi_so[i] = lbChiSo;
                    Chi_so[i].ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Mảng từ 2 -> 15 phần tử");
                txtNhapPT.Focus();
            }
            #endregion 


        }

        #region di chuyển Node
        public void DiLen(Control btn)
        {
            //di len do cao 50
            for (int i = 0; i < 100; i++)
            {
                btn.Top = btn.Top - 1;
                System.Threading.Thread.Sleep(trb_Tocdo.Value);

            }
        }

        public void DiXuong(Control btn)
        {
            for (int i = 0; i < 100; i++)
            {
                btn.Top = btn.Top + 1;
                System.Threading.Thread.Sleep(trb_Tocdo.Value);
            }
        }


        public void HoanVi(Control btn1, Control btn2)
        {
            Point p1 = btn1.Location;
            Point p2 = btn2.Location;

            if (p1 != p2)
            {
                for (int i = p1.X; i < p2.X; i++)
                {
                    btn2.Left = btn2.Left - 1;
                    System.Threading.Thread.Sleep(trb_Tocdo.Value);
                    btn1.Left = btn1.Left + 1;
                    System.Threading.Thread.Sleep(trb_Tocdo.Value);
                }
            }


        }

        public void Hoan_vi(Control btn1, Control btn2)
        {


            DiLen(btn1);
            DiXuong(btn2);

            HoanVi(btn1, btn2);

            DiXuong(btn1);
            DiLen(btn2);

            btn1.Refresh();
            btn2.Refresh();


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

        private void rad_InterchangeSort_CheckedChanged(object sender, EventArgs e)
        {
			text_ytuong.Text = "Như đã biết, để sắp xếp một dãy số, ta có thể xét các nghịch thế có trong dãy và triệt tiêu dần chúng đi. Ý tưởng chính của giải thuật là xuất phát từ đầu dãy, tìm tất cả nghịch thế chứa phần tử này, triệt tiêu chúng bằng cách đổi chổ phần tử này với phần tử tương ứng trong cặp nghịch thế. Lặp lại xử lý trên với các phần tử kế tiếp theo trong dãy. ";


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
			lb_code.Items.Clear();
			code x = new code();
			x.Selectionsort(lb_code, true);
			text_ytuong.Text = "Chọn phần tử nhỏ nhất trong N phần tử trong dãy hiện hành ban đầu.Đưa phần tử này về vị trí đầu dãy hiện hành\r\nXem dãy hiện hành chỉ còn N-1 phần tử của dãy hiện hành ban đầuBắt đầu từ vị trí thứ 2Lặp lại quá trình trên cho dãy hiện hành đến khi dãy hiện hành chỉ còn 1 phần tử";

		}

		private void rad_HeapSort_CheckedChanged(object sender, EventArgs e)
        {
			lb_code.Items.Clear();
			text_ytuong.Text = "Heapsort còn được gọi là giải thuật vun đống, nó có thể được xem như bản cải tiến của Selection sort khi chia các phần tử thành 2 mảng con, 1 mảng các phần tử đã được sắp xếp và mảng còn lại các phần tử chưa được sắp xếp. Trong mảng chưa được sắp xếp, các phần tử lớn nhất sẽ được tách ra và đưa vào mảng đã được sắp xếp. Điều cải tiến ở Heapsort so với Selection sort ở việc sử dụng cấu trúc dữ liệu heap thay vì tìm kiếm tuyến tính (linear-time search) như Selection sort để tìm ra phần tử lớn nhất.Heapsort là thuật toán in-place, nghĩa là không cần thêm bất cứ cấu trúc dữ liệu phụ trợ trong quá trình chạy thuật toán.Tuy nhiên, giải thuật này không có độ ổn định(stability).";
			code x = new code();
			x.heapsort(lb_code, true);
		}

        private void rad_MergeSort_CheckedChanged(object sender, EventArgs e)
        {
			lb_code.Items.Clear();
			code x = new code();
			x.Mergesort(lb_code, true);
			text_ytuong.Text = "Ý tưởng chúng ta sẽ chia mảng lớn thành những mảng con nhỏ hơn bằng cách chia đôi mảng lớn và chúng ta tiếp tục chia đôi các mảng con cho tới khi mảng con nhỏ nhất chỉ còn 1 phần tử. Sau đó chúng ta sẽ tiếng hành so sánh 2 mảng con có cùng mảng cơ sở (khi chúng ta chia đôi mảng lớn thành 2 mảng con thì mảng lớn đó chúng ta gọi là mảng cơ sở của 2 mảng con đó) khi so sánh chúng sẽ vừa sắp xếp vừa ghép 2 mảng con đó lại thành mảng cơ sở, chúng ta tiếp tục so sánh và ghép các mảng con lại đến khi còn lại mảng duy nhất thì đó là mảng đã được sắp xếp.";
		}

		private void rad_BubbleSort_CheckedChanged(object sender, EventArgs e)
        {
			lb_code.Items.Clear();
			code x = new code();
			x.bubblesort(lb_code, true);
			text_ytuong.Text = "Xuất phát từ cuối dãy, đổi chỗ các cặp phần tử kế cận để đưa phần tử nhỏ hơn trong cặp phần tử đó về vị trí đúng đầu dãy hiện hành, sau đó sẽ không xét đến nó ở bước tiếp theo, do vậy ở lần xử lý thứ i sẽ có vị trí đầu dãy là i.\r\nLặp lại xử lý trên cho đến khi không còn cặp phần tử nào để xét.";

		}

		private void rad_ShakerSort_CheckedChanged(object sender, EventArgs e)
        {
			text_ytuong.Text = "Shaker Sort là một cải tiến của Bubble Sort. Sau khi đưa phần tử nhỏ nhất về đầu dãy, thuật toán sẽ giúp chúng ta đưa phần tử lớn nhất về cuối dãy. Do đưa các phần tử về đúng vị trí ở cả hai đầu và ghi nhận những đoạn được sắp xếp nên Shaker Sort sẽ giúp cải thiện thời gian sắp xếp dãy số.";

		}

		private void rad_InsertionSort_CheckedChanged(object sender, EventArgs e)
        {
			lb_code.Items.Clear();
			text_ytuong.Text = "Sắp xếp chèn(insertion sort) là một thuật toán sắp xếp bắt chước cách sắp xếp quân bài của những người chơi bài. Muốn sắp một bộ bài theo trật tự người chơi bài rút lần lượt từ quân thứ 2, so với các quân đứng trước nó để chèn vào vị trí thích hợp.";
			code x = new code();
			x.insertionsort(lb_code, true);
		}

		private void rad_BinaryInsertionSort_CheckedChanged(object sender, EventArgs e)
        {
			text_ytuong.Text = "Chúng ta có thể sử dụng tìm kiếm nhị phân để giảm số lần so sánh trong phân loại chèn thông thường. Binary Insertion Sort là cải tiến của Insertion Sort khi sử dụng tìm kiếm nhị phân để tìm vị trí thích hợp để chèn các mục đã chọn ở mỗi lần lặp.";
		}

		private void rad_ShellSort_CheckedChanged(object sender, EventArgs e)
        {
			text_ytuong.Text = "Shell Sort là một giải thuật sắp xếp mang lại hiệu quả cao dựa trên giải thuật sắp xếp chèn (Insertion Sort). Giải thuật này tránh các trường hợp phải tráo đổi vị trí của hai phần tử xa nhau trong giải thuật sắp xếp chọn (nếu như phần tử nhỏ hơn ở vị trí bên phải khá xa so với phần tử lớn hơn bên trái).Đầu tiên, giải thuật này sử dụng giải thuật sắp xếp chọn trên các phần tử có khoảng cách xa nhau, sau đó sắp xếp các phần tử có khoảng cách hẹp hơn.Khoảng cách này còn được gọi là khoảng(interval) – là số vị trí từ phần tử này tới phần tử khác";
		}

		private void rad_QuickSort_CheckedChanged(object sender, EventArgs e)
        {
			lb_code.Items.Clear();
			code x = new code();
			x.quicksort(lb_code, true);
			text_ytuong.Text = "QuickSort là một thuật toán Divide and Conquer. Nó chọn một phần tử như là trục và phân chia mảng cho trước quanh trục nhặt được chọn.Có rất nhiều phiên bản khác nhau của quickSort chọn trục pivot bằng nhiều cách khác nhau.Luôn chọn yếu tố đầu tiên làm trục chính.Luôn chọn phần tử cuối cùng làm trục chính.Chọn một phần tử ngẫu nhiên như trục quay.Chọn trung vị làm trục.Quá trình quan trọng trong quickSort là phân vùng.Mục tiêu của các phân vùng là, cho mảng và một phần tử x của mảng là trục chính, đặt x tại vị trí chính xác của nó trong mảng sắp xếp và đặt tất cả các phần tử nhỏ hơn(nhỏ hơn x) trước x và đặt tất cả các phần tử lớn hơn(lớn hơn x) x.Tất cả điều này nên được thực hiện trong thời gian tuyến tính.";
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
            Hoan_vi(Bn[0], Bn[2]);
            Hoan_vi(Bn[2], Bn[4]);
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

        private void btnxoamang_Click(object sender, EventArgs e)
        {

        }

        private void lb_code_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
