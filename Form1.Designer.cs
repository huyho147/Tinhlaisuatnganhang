namespace Tinhlaisuatnganhang
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SoTienTxt = new TextBox();
            LsCbB = new ComboBox();
            SonamNR = new NumericUpDown();
            label5 = new Label();
            KetQuaLb = new ListBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)SonamNR).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(205, 48);
            label1.Name = "label1";
            label1.Size = new Size(666, 41);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG TÍNH LÃI SUẤT TIẾT KIỆM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            label2.Location = new Point(205, 141);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 1;
            label2.Text = "Số tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            label3.Location = new Point(205, 195);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 1;
            label3.Text = "Lãi suất:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            label4.Location = new Point(205, 241);
            label4.Name = "label4";
            label4.Size = new Size(163, 30);
            label4.TabIndex = 1;
            label4.Text = "Số năm gửi:";
            // 
            // SoTienTxt
            // 
            SoTienTxt.Font = new Font("Tahoma", 15F);
            SoTienTxt.Location = new Point(404, 133);
            SoTienTxt.Name = "SoTienTxt";
            SoTienTxt.Size = new Size(420, 38);
            SoTienTxt.TabIndex = 2;
            SoTienTxt.Text = "10000000";
            // 
            // LsCbB
            // 
            LsCbB.DropDownStyle = ComboBoxStyle.DropDownList;
            LsCbB.Font = new Font("Tahoma", 15F);
            LsCbB.FormattingEnabled = true;
            LsCbB.Location = new Point(404, 187);
            LsCbB.MaxDropDownItems = 10;
            LsCbB.MaxLength = 10;
            LsCbB.Name = "LsCbB";
            LsCbB.Size = new Size(420, 38);
            LsCbB.TabIndex = 3;
            // 
            // SonamNR
            // 
            SonamNR.Font = new Font("Tahoma", 15F);
            SonamNR.Location = new Point(404, 233);
            SonamNR.Margin = new Padding(2);
            SonamNR.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            SonamNR.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SonamNR.Name = "SonamNR";
            SonamNR.Size = new Size(420, 38);
            SonamNR.TabIndex = 4;
            SonamNR.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 20F);
            label5.Location = new Point(39, 274);
            label5.Name = "label5";
            label5.Size = new Size(134, 41);
            label5.TabIndex = 5;
            label5.Text = "Kết quả";
            label5.Click += label5_Click;
            // 
            // KetQuaLb
            // 
            KetQuaLb.FormattingEnabled = true;
            KetQuaLb.ItemHeight = 21;
            KetQuaLb.Location = new Point(37, 331);
            KetQuaLb.Name = "KetQuaLb";
            KetQuaLb.Size = new Size(1035, 340);
            KetQuaLb.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 15F);
            button1.Location = new Point(404, 286);
            button1.Name = "button1";
            button1.Size = new Size(221, 39);
            button1.TabIndex = 7;
            button1.Text = "TÍNH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 15F);
            button2.Location = new Point(648, 286);
            button2.Name = "button2";
            button2.Size = new Size(176, 39);
            button2.TabIndex = 8;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 554);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(KetQuaLb);
            Controls.Add(label5);
            Controls.Add(SonamNR);
            Controls.Add(LsCbB);
            Controls.Add(SoTienTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 10F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)SonamNR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox SoTienTxt;
        private ComboBox LsCbB;
        private NumericUpDown SonamNR;
        private Label label5;
        private ListBox KetQuaLb;
        private Button button1;
        private Button button2;
    }
}
