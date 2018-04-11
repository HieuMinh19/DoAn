using System.Windows.Forms;
namespace PMSapXep
{
    partial class NhapPT
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
            this.txt_Vitri = new System.Windows.Forms.TextBox();
            this.lb_nhap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Giatri = new System.Windows.Forms.TextBox();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.btn_exits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Vitri
            // 
            this.txt_Vitri.HideSelection = false;
            this.txt_Vitri.Location = new System.Drawing.Point(106, 39);
            this.txt_Vitri.Name = "txt_Vitri";
            this.txt_Vitri.Size = new System.Drawing.Size(61, 20);
            this.txt_Vitri.TabIndex = 0;
            this.txt_Vitri.Text = "0";
            this.txt_Vitri.TextChanged += new System.EventHandler(this.txt_Vitri_TextChanged);
            this.txt_Vitri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Vitri_KeyPress);
            // 
            // lb_nhap
            // 
            this.lb_nhap.AutoSize = true;
            this.lb_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhap.Location = new System.Drawing.Point(12, 38);
            this.lb_nhap.Name = "lb_nhap";
            this.lb_nhap.Size = new System.Drawing.Size(88, 17);
            this.lb_nhap.TabIndex = 1;
            this.lb_nhap.Text = "Vị trí phần tử";
            this.lb_nhap.Click += new System.EventHandler(this.lb_nhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giá trị";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Giatri
            // 
            this.txt_Giatri.Location = new System.Drawing.Point(238, 40);
            this.txt_Giatri.Name = "txt_Giatri";
            this.txt_Giatri.Size = new System.Drawing.Size(66, 20);
            this.txt_Giatri.TabIndex = 3;
            this.txt_Giatri.Text = "10";
            this.txt_Giatri.TextChanged += new System.EventHandler(this.txt_Giatri_TextChanged);
            this.txt_Giatri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Vitri_KeyPress);
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Nhap.Location = new System.Drawing.Point(49, 109);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(80, 24);
            this.btn_Nhap.TabIndex = 4;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = false;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // btn_exits
            // 
            this.btn_exits.Location = new System.Drawing.Point(199, 109);
            this.btn_exits.Name = "btn_exits";
            this.btn_exits.Size = new System.Drawing.Size(75, 24);
            this.btn_exits.TabIndex = 5;
            this.btn_exits.Text = "Đóng";
            this.btn_exits.UseVisualStyleBackColor = true;
            this.btn_exits.Click += new System.EventHandler(this.btn_exits_Click);
            // 
            // NhapPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 157);
            this.Controls.Add(this.btn_exits);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.txt_Giatri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_nhap);
            this.Controls.Add(this.txt_Vitri);
            this.Name = "NhapPT";
            this.Text = "Nhập phần tử";
            this.Load += new System.EventHandler(this.NhapPT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Vitri;
        private System.Windows.Forms.Label lb_nhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Giatri;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.Button btn_exits;
    }
}