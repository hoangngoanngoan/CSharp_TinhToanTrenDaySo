namespace CSharp_TinhToanTrenDaySo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtSKT = new TextBox();
            txtSBD = new TextBox();
            label = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            butTinh = new Button();
            panel7 = new Panel();
            txtTongLe = new TextBox();
            label8 = new Label();
            panel6 = new Panel();
            txtTongChan = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            txtTich = new TextBox();
            label6 = new Label();
            panel8 = new Panel();
            label9 = new Label();
            labKQ = new Label();
            panel4 = new Panel();
            txtTong = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 98);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yuongblood-designed", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(423, 81);
            label1.TabIndex = 0;
            label1.Text = "Tính toán trên dãy số";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSKT);
            panel2.Controls.Add(txtSBD);
            panel2.Controls.Add(label);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 63);
            panel2.TabIndex = 1;
            // 
            // txtSKT
            // 
            txtSKT.Location = new Point(593, 17);
            txtSKT.Name = "txtSKT";
            txtSKT.Size = new Size(157, 26);
            txtSKT.TabIndex = 3;
            // 
            // txtSBD
            // 
            txtSBD.Location = new Point(300, 17);
            txtSBD.Name = "txtSBD";
            txtSBD.Size = new Size(157, 26);
            txtSBD.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(477, 20);
            label.Name = "label";
            label.Size = new Size(97, 18);
            label.TabIndex = 2;
            label.Text = "Số kết thúc : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 20);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 1;
            label3.Text = "Số bắt đầu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 20);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 0;
            label2.Text = "Giới hạn dãy số :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Moccasin;
            panel3.Controls.Add(butTinh);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(0, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(786, 482);
            panel3.TabIndex = 2;
            // 
            // butTinh
            // 
            butTinh.Location = new Point(353, 418);
            butTinh.Name = "butTinh";
            butTinh.Size = new Size(111, 37);
            butTinh.TabIndex = 2;
            butTinh.Text = "Tính toán";
            butTinh.UseVisualStyleBackColor = true;
            butTinh.Click += butTinh_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtTongLe);
            panel7.Controls.Add(label8);
            panel7.Location = new Point(3, 344);
            panel7.Name = "panel7";
            panel7.Size = new Size(780, 62);
            panel7.TabIndex = 0;
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(207, 16);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.ReadOnly = true;
            txtTongLe.Size = new Size(286, 26);
            txtTongLe.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 19);
            label8.Name = "label8";
            label8.Size = new Size(109, 18);
            label8.TabIndex = 0;
            label8.Text = "Tổng các số lẻ:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtTongChan);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(3, 277);
            panel6.Name = "panel6";
            panel6.Size = new Size(780, 62);
            panel6.TabIndex = 0;
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(207, 16);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.ReadOnly = true;
            txtTongChan.Size = new Size(286, 26);
            txtTongChan.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 19);
            label7.Name = "label7";
            label7.Size = new Size(130, 18);
            label7.TabIndex = 0;
            label7.Text = "Tổng các số chẳn:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtTich);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(3, 209);
            panel5.Name = "panel5";
            panel5.Size = new Size(780, 62);
            panel5.TabIndex = 0;
            // 
            // txtTich
            // 
            txtTich.Location = new Point(207, 16);
            txtTich.Name = "txtTich";
            txtTich.ReadOnly = true;
            txtTich.Size = new Size(286, 26);
            txtTich.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 19);
            label6.Name = "label6";
            label6.Size = new Size(92, 18);
            label6.TabIndex = 0;
            label6.Text = "Tích các số :";
            // 
            // panel8
            // 
            panel8.Controls.Add(label9);
            panel8.Controls.Add(labKQ);
            panel8.Location = new Point(3, 72);
            panel8.Name = "panel8";
            panel8.Size = new Size(780, 62);
            panel8.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(81, 19);
            label9.Name = "label9";
            label9.Size = new Size(69, 18);
            label9.TabIndex = 3;
            label9.Text = "Kết quả :";
            // 
            // labKQ
            // 
            labKQ.AutoSize = true;
            labKQ.Location = new Point(207, 19);
            labKQ.Name = "labKQ";
            labKQ.Size = new Size(53, 18);
            labKQ.TabIndex = 0;
            labKQ.Text = "kjkhnkj";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtTong);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(3, 140);
            panel4.Name = "panel4";
            panel4.Size = new Size(780, 62);
            panel4.TabIndex = 0;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(207, 16);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(286, 26);
            txtTong.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 24);
            label5.Name = "label5";
            label5.Size = new Size(99, 18);
            label5.TabIndex = 0;
            label5.Text = "Tổng các số :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 599);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txtSKT;
        private TextBox txtSBD;
        private Label label;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Button butTinh;
        private Panel panel7;
        private TextBox txtTongLe;
        private Label label8;
        private Panel panel6;
        private TextBox txtTongChan;
        private Label label7;
        private Panel panel5;
        private TextBox txtTich;
        private Label label6;
        private Panel panel4;
        private TextBox txtTong;
        private Label label5;
        private Panel panel8;
        private Label label9;
        private Label labKQ;
    }
}
