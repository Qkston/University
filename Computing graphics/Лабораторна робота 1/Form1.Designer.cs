
namespace Лабораторна_робота_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.first_x = new System.Windows.Forms.TextBox();
            this.first_y = new System.Windows.Forms.TextBox();
            this.second_x = new System.Windows.Forms.TextBox();
            this.second_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.default_algorithm = new System.Windows.Forms.TextBox();
            this.Bresenhems = new System.Windows.Forms.TextBox();
            this.CDAs = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // first_x
            // 
            this.first_x.Location = new System.Drawing.Point(54, 495);
            this.first_x.Name = "first_x";
            this.first_x.Size = new System.Drawing.Size(112, 20);
            this.first_x.TabIndex = 0;
            // 
            // first_y
            // 
            this.first_y.Location = new System.Drawing.Point(212, 495);
            this.first_y.Name = "first_y";
            this.first_y.Size = new System.Drawing.Size(112, 20);
            this.first_y.TabIndex = 1;
            // 
            // second_x
            // 
            this.second_x.Location = new System.Drawing.Point(54, 527);
            this.second_x.Name = "second_x";
            this.second_x.Size = new System.Drawing.Size(112, 20);
            this.second_x.TabIndex = 2;
            // 
            // second_y
            // 
            this.second_y.Location = new System.Drawing.Point(212, 527);
            this.second_y.Name = "second_y";
            this.second_y.Size = new System.Drawing.Size(112, 20);
            this.second_y.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y2";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(672, 487);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 34);
            this.start.TabIndex = 9;
            this.start.Text = "Побудувати";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // default_algorithm
            // 
            this.default_algorithm.Enabled = false;
            this.default_algorithm.Location = new System.Drawing.Point(438, 491);
            this.default_algorithm.Name = "default_algorithm";
            this.default_algorithm.Size = new System.Drawing.Size(39, 20);
            this.default_algorithm.TabIndex = 10;
            // 
            // Bresenhems
            // 
            this.Bresenhems.Enabled = false;
            this.Bresenhems.Location = new System.Drawing.Point(438, 527);
            this.Bresenhems.Name = "Bresenhems";
            this.Bresenhems.Size = new System.Drawing.Size(39, 20);
            this.Bresenhems.TabIndex = 11;
            // 
            // CDAs
            // 
            this.CDAs.Enabled = false;
            this.CDAs.Location = new System.Drawing.Point(586, 510);
            this.CDAs.Name = "CDAs";
            this.CDAs.Size = new System.Drawing.Size(39, 20);
            this.CDAs.TabIndex = 12;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(672, 527);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 23);
            this.clear.TabIndex = 13;
            this.clear.Text = "Очистити";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 469);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Вбудований \r\nалгоритм";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Алгоритм \r\nБрезенхема";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Алгоритм \r\nЦДА";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "мс";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "мс";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(631, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "мс";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.CDAs);
            this.Controls.Add(this.Bresenhems);
            this.Controls.Add(this.default_algorithm);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.second_y);
            this.Controls.Add(this.second_x);
            this.Controls.Add(this.first_y);
            this.Controls.Add(this.first_x);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Растрова графіка. Алгоритми растрового подання відрізків.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_x;
        private System.Windows.Forms.TextBox first_y;
        private System.Windows.Forms.TextBox second_x;
        private System.Windows.Forms.TextBox second_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox default_algorithm;
        private System.Windows.Forms.TextBox Bresenhems;
        private System.Windows.Forms.TextBox CDAs;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

