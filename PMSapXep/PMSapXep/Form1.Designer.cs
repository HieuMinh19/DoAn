namespace PMSapXep
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rad_InterchangeSort = new System.Windows.Forms.RadioButton();
            this.rad_SelectionSort = new System.Windows.Forms.RadioButton();
            this.rad_BubbleSort = new System.Windows.Forms.RadioButton();
            this.rad_ShakerSort = new System.Windows.Forms.RadioButton();
            this.rad_InsertionSort = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_MergeSort = new System.Windows.Forms.RadioButton();
            this.rad_QuickSort = new System.Windows.Forms.RadioButton();
            this.rad_HeapSort = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.rad_BinaryInsertionSort = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Ngaunhien = new System.Windows.Forms.Button();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.lbSophantu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnNut = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtNhapPT = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_Giam = new System.Windows.Forms.RadioButton();
            this.rad_Tang = new System.Windows.Forms.RadioButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Batdau = new System.Windows.Forms.Button();
            this.btn_xuatgip = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.trb_Tocdo = new System.Windows.Forms.TrackBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Tocdo)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // rad_InterchangeSort
            // 
            this.rad_InterchangeSort.AutoSize = true;
            this.rad_InterchangeSort.Checked = true;
            this.rad_InterchangeSort.Location = new System.Drawing.Point(8, 23);
            this.rad_InterchangeSort.Margin = new System.Windows.Forms.Padding(4);
            this.rad_InterchangeSort.Name = "rad_InterchangeSort";
            this.rad_InterchangeSort.Size = new System.Drawing.Size(134, 21);
            this.rad_InterchangeSort.TabIndex = 0;
            this.rad_InterchangeSort.TabStop = true;
            this.rad_InterchangeSort.Text = "Interchange Sort";
            this.rad_InterchangeSort.UseVisualStyleBackColor = true;
            this.rad_InterchangeSort.CheckedChanged += new System.EventHandler(this.rad_InterchangeSort_CheckedChanged);
            // 
            // rad_SelectionSort
            // 
            this.rad_SelectionSort.AutoSize = true;
            this.rad_SelectionSort.Location = new System.Drawing.Point(8, 52);
            this.rad_SelectionSort.Margin = new System.Windows.Forms.Padding(4);
            this.rad_SelectionSort.Name = "rad_SelectionSort";
            this.rad_SelectionSort.Size = new System.Drawing.Size(117, 21);
            this.rad_SelectionSort.TabIndex = 10;
            this.rad_SelectionSort.TabStop = true;
            this.rad_SelectionSort.Text = "Selection Sort";
            this.rad_SelectionSort.UseVisualStyleBackColor = true;
            this.rad_SelectionSort.CheckedChanged += new System.EventHandler(this.rad_SelectionSort_CheckedChanged);
            // 
            // rad_BubbleSort
            // 
            this.rad_BubbleSort.AutoSize = true;
            this.rad_BubbleSort.Location = new System.Drawing.Point(8, 80);
            this.rad_BubbleSort.Margin = new System.Windows.Forms.Padding(4);
            this.rad_BubbleSort.Name = "rad_BubbleSort";
            this.rad_BubbleSort.Size = new System.Drawing.Size(103, 21);
            this.rad_BubbleSort.TabIndex = 11;
            this.rad_BubbleSort.TabStop = true;
            this.rad_BubbleSort.Text = "Bubble Sort";
            this.rad_BubbleSort.UseVisualStyleBackColor = true;
            this.rad_BubbleSort.CheckedChanged += new System.EventHandler(this.rad_BubbleSort_CheckedChanged);
            // 
            // rad_ShakerSort
            // 
            this.rad_ShakerSort.AutoSize = true;
            this.rad_ShakerSort.Location = new System.Drawing.Point(8, 108);
            this.rad_ShakerSort.Margin = new System.Windows.Forms.Padding(4);
            this.rad_ShakerSort.Name = "rad_ShakerSort";
            this.rad_ShakerSort.Size = new System.Drawing.Size(104, 21);
            this.rad_ShakerSort.TabIndex = 12;
            this.rad_ShakerSort.TabStop = true;
            this.rad_ShakerSort.Text = "Shaker Sort";
            this.rad_ShakerSort.UseVisualStyleBackColor = true;
            this.rad_ShakerSort.CheckedChanged += new System.EventHandler(this.rad_ShakerSort_CheckedChanged);
            // 
            // rad_InsertionSort
            // 
            this.rad_InsertionSort.AutoSize = true;
            this.rad_InsertionSort.Location = new System.Drawing.Point(8, 137);
            this.rad_InsertionSort.Margin = new System.Windows.Forms.Padding(4);
            this.rad_InsertionSort.Name = "rad_InsertionSort";
            this.rad_InsertionSort.Size = new System.Drawing.Size(113, 21);
            this.rad_InsertionSort.TabIndex = 13;
            this.rad_InsertionSort.TabStop = true;
            this.rad_InsertionSort.Text = "Insertion Sort";
            this.rad_InsertionSort.UseVisualStyleBackColor = true;
            this.rad_InsertionSort.CheckedChanged += new System.EventHandler(this.rad_InsertionSort_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_MergeSort);
            this.groupBox1.Controls.Add(this.rad_QuickSort);
            this.groupBox1.Controls.Add(this.rad_HeapSort);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.rad_BinaryInsertionSort);
            this.groupBox1.Controls.Add(this.rad_InterchangeSort);
            this.groupBox1.Controls.Add(this.rad_SelectionSort);
            this.groupBox1.Controls.Add(this.rad_BubbleSort);
            this.groupBox1.Controls.Add(this.rad_ShakerSort);
            this.groupBox1.Controls.Add(this.rad_InsertionSort);
            this.groupBox1.Location = new System.Drawing.Point(377, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(353, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thuật toán";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // rad_MergeSort
            // 
            this.rad_MergeSort.AutoSize = true;
            this.rad_MergeSort.Location = new System.Drawing.Point(149, 137);
            this.rad_MergeSort.Margin = new System.Windows.Forms.Padding(4);
            this.rad_MergeSort.Name = "rad_MergeSort";
            this.rad_MergeSort.Size = new System.Drawing.Size(99, 21);
            this.rad_MergeSort.TabIndex = 28;
            this.rad_MergeSort.TabStop = true;
            this.rad_MergeSort.Text = "Merge Sort";
            this.rad_MergeSort.UseVisualStyleBackColor = true;
            this.rad_MergeSort.CheckedChanged += new System.EventHandler(this.rad_MergeSort_CheckedChanged);
            // 
            // rad_QuickSort
            // 
            this.rad_QuickSort.AutoSize = true;
            this.rad_QuickSort.Location = new System.Drawing.Point(149, 108);
            this.rad_QuickSort.Margin = new System.Windows.Forms.Padding(4);
            this.rad_QuickSort.Name = "rad_QuickSort";
            this.rad_QuickSort.Size = new System.Drawing.Size(95, 21);
            this.rad_QuickSort.TabIndex = 27;
            this.rad_QuickSort.TabStop = true;
            this.rad_QuickSort.Text = "Quick Sort";
            this.rad_QuickSort.UseVisualStyleBackColor = true;
            this.rad_QuickSort.CheckedChanged += new System.EventHandler(this.rad_QuickSort_CheckedChanged);
            // 
            // rad_HeapSort
            // 
            this.rad_HeapSort.AutoSize = true;
            this.rad_HeapSort.Location = new System.Drawing.Point(149, 79);
            this.rad_HeapSort.Margin = new System.Windows.Forms.Padding(4);
            this.rad_HeapSort.Name = "rad_HeapSort";
            this.rad_HeapSort.Size = new System.Drawing.Size(93, 21);
            this.rad_HeapSort.TabIndex = 26;
            this.rad_HeapSort.TabStop = true;
            this.rad_HeapSort.Text = "Heap Sort";
            this.rad_HeapSort.UseVisualStyleBackColor = true;
            this.rad_HeapSort.CheckedChanged += new System.EventHandler(this.rad_HeapSort_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(149, 50);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(90, 21);
            this.radioButton7.TabIndex = 25;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Shell Sort";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.rad_ShellSort_CheckedChanged);
            // 
            // rad_BinaryInsertionSort
            // 
            this.rad_BinaryInsertionSort.AutoSize = true;
            this.rad_BinaryInsertionSort.Location = new System.Drawing.Point(149, 23);
            this.rad_BinaryInsertionSort.Margin = new System.Windows.Forms.Padding(4);
            this.rad_BinaryInsertionSort.Name = "rad_BinaryInsertionSort";
            this.rad_BinaryInsertionSort.Size = new System.Drawing.Size(161, 21);
            this.rad_BinaryInsertionSort.TabIndex = 24;
            this.rad_BinaryInsertionSort.TabStop = true;
            this.rad_BinaryInsertionSort.Text = " Binary Insertion Sort";
            this.rad_BinaryInsertionSort.UseVisualStyleBackColor = true;
            this.rad_BinaryInsertionSort.CheckedChanged += new System.EventHandler(this.rad_BinaryInsertionSort_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(167, 94);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 31);
            this.button4.TabIndex = 8;
            this.button4.Text = "Đọc File";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(11, 94);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Mở File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Ngaunhien
            // 
            this.btn_Ngaunhien.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ngaunhien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Ngaunhien.Location = new System.Drawing.Point(11, 57);
            this.btn_Ngaunhien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ngaunhien.Name = "btn_Ngaunhien";
            this.btn_Ngaunhien.Size = new System.Drawing.Size(119, 31);
            this.btn_Ngaunhien.TabIndex = 6;
            this.btn_Ngaunhien.Text = "Ngẫu Nhiên";
            this.btn_Ngaunhien.UseVisualStyleBackColor = true;
            this.btn_Ngaunhien.Click += new System.EventHandler(this.btn_Ngaunhien_Click);
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMang.ForeColor = System.Drawing.Color.Blue;
            this.btnTaoMang.Location = new System.Drawing.Point(84, 129);
            this.btnTaoMang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(127, 31);
            this.btnTaoMang.TabIndex = 5;
            this.btnTaoMang.Text = "Tạo Mảng";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // lbSophantu
            // 
            this.lbSophantu.AutoSize = true;
            this.lbSophantu.Location = new System.Drawing.Point(7, 27);
            this.lbSophantu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSophantu.Name = "lbSophantu";
            this.lbSophantu.Size = new System.Drawing.Size(146, 17);
            this.lbSophantu.TabIndex = 1;
            this.lbSophantu.Text = "số phần tử (max = 15)";
            this.lbSophantu.Click += new System.EventHandler(this.lbSophantu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(80, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 34);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(961, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mô Phỏng Thuật Toán Sắp Xếp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnNut
            // 
            this.pnNut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnNut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnNut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnNut.Location = new System.Drawing.Point(41, 337);
            this.pnNut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnNut.Name = "pnNut";
            this.pnNut.Size = new System.Drawing.Size(1460, 276);
            this.pnNut.TabIndex = 5;
            this.pnNut.Click += new System.EventHandler(this.pnNut_Click);
            this.pnNut.Paint += new System.Windows.Forms.PaintEventHandler(this.pnNut_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.txtNhapPT);
            this.groupBox2.Controls.Add(this.lbSophantu);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btnTaoMang);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btn_Ngaunhien);
            this.groupBox2.Location = new System.Drawing.Point(41, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(329, 166);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khởi Tạo";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(168, 57);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 31);
            this.button5.TabIndex = 11;
            this.button5.Text = "Bằng tay";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtNhapPT
            // 
            this.txtNhapPT.Location = new System.Drawing.Point(167, 22);
            this.txtNhapPT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhapPT.Name = "txtNhapPT";
            this.txtNhapPT.Size = new System.Drawing.Size(119, 22);
            this.txtNhapPT.TabIndex = 9;
            this.txtNhapPT.Text = "5";
            this.txtNhapPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNhapPT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNhapPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoPT_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rad_Giam);
            this.groupBox3.Controls.Add(this.rad_Tang);
            this.groupBox3.Location = new System.Drawing.Point(41, 228);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(140, 103);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "hướng sắp xếp";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rad_Giam
            // 
            this.rad_Giam.AutoSize = true;
            this.rad_Giam.Location = new System.Drawing.Point(15, 64);
            this.rad_Giam.Margin = new System.Windows.Forms.Padding(4);
            this.rad_Giam.Name = "rad_Giam";
            this.rad_Giam.Size = new System.Drawing.Size(62, 21);
            this.rad_Giam.TabIndex = 1;
            this.rad_Giam.TabStop = true;
            this.rad_Giam.Text = "Giảm";
            this.rad_Giam.UseVisualStyleBackColor = true;
            this.rad_Giam.CheckedChanged += new System.EventHandler(this.rad_Giam_CheckedChanged);
            // 
            // rad_Tang
            // 
            this.rad_Tang.AutoSize = true;
            this.rad_Tang.Checked = true;
            this.rad_Tang.Location = new System.Drawing.Point(13, 31);
            this.rad_Tang.Margin = new System.Windows.Forms.Padding(4);
            this.rad_Tang.Name = "rad_Tang";
            this.rad_Tang.Size = new System.Drawing.Size(62, 21);
            this.rad_Tang.TabIndex = 0;
            this.rad_Tang.TabStop = true;
            this.rad_Tang.Text = "Tăng";
            this.rad_Tang.UseVisualStyleBackColor = true;
            this.rad_Tang.CheckedChanged += new System.EventHandler(this.rad_Tang_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btn_Batdau);
            this.groupBox4.Controls.Add(this.btn_xuatgip);
            this.groupBox4.Controls.Add(this.btnPause);
            this.groupBox4.Location = new System.Drawing.Point(189, 226);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(248, 105);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Điều khiển";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btn_Batdau
            // 
            this.btn_Batdau.Location = new System.Drawing.Point(140, 23);
            this.btn_Batdau.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Batdau.Name = "btn_Batdau";
            this.btn_Batdau.Size = new System.Drawing.Size(100, 28);
            this.btn_Batdau.TabIndex = 2;
            this.btn_Batdau.Text = "Bắt đầu";
            this.btn_Batdau.UseVisualStyleBackColor = true;
            this.btn_Batdau.Click += new System.EventHandler(this.btn_Batdau_Click);
            // 
            // btn_xuatgip
            // 
            this.btn_xuatgip.Location = new System.Drawing.Point(63, 66);
            this.btn_xuatgip.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xuatgip.Name = "btn_xuatgip";
            this.btn_xuatgip.Size = new System.Drawing.Size(136, 28);
            this.btn_xuatgip.TabIndex = 1;
            this.btn_xuatgip.Text = "Xuất Giphy";
            this.btn_xuatgip.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(21, 23);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 28);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Tạm dừng";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.trb_Tocdo);
            this.groupBox5.Location = new System.Drawing.Point(445, 226);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(285, 105);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tốc độ";
            // 
            // trb_Tocdo
            // 
            this.trb_Tocdo.Location = new System.Drawing.Point(21, 30);
            this.trb_Tocdo.Margin = new System.Windows.Forms.Padding(4);
            this.trb_Tocdo.Name = "trb_Tocdo";
            this.trb_Tocdo.Size = new System.Drawing.Size(213, 56);
            this.trb_Tocdo.TabIndex = 0;
            this.trb_Tocdo.Value = 5;
            this.trb_Tocdo.Scroll += new System.EventHandler(this.trb_Tocdo_Scroll);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.listBox2);
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Location = new System.Drawing.Point(739, 54);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(413, 277);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CodeC/C++";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Location = new System.Drawing.Point(1160, 54);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(341, 277);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ý tưởng";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(58, 220);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(8, 4);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(33, 41);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(320, 84);
            this.listBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 625);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnNut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "mô phỏng giải thuật sắp xếp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Tocdo)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rad_InterchangeSort;
        private System.Windows.Forms.RadioButton rad_SelectionSort;
        private System.Windows.Forms.RadioButton rad_BubbleSort;
        private System.Windows.Forms.RadioButton rad_ShakerSort;
        private System.Windows.Forms.RadioButton rad_InsertionSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_MergeSort;
        private System.Windows.Forms.RadioButton rad_QuickSort;
        private System.Windows.Forms.RadioButton rad_HeapSort;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton rad_BinaryInsertionSort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Ngaunhien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbSophantu;
        private System.Windows.Forms.Panel pnNut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNhapPT;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rad_Giam;
        private System.Windows.Forms.RadioButton rad_Tang;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btn_Batdau;
        private System.Windows.Forms.Button btn_xuatgip;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar trb_Tocdo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

