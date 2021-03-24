
namespace Індивідуальне_завдання
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
            this.Red = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Red.ForeColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(12, 395);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(189, 43);
            this.Red.TabIndex = 0;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Green
            // 
            this.Green.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Green.ForeColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(207, 395);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(189, 43);
            this.Green.TabIndex = 1;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Yellow
            // 
            this.Yellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yellow.ForeColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(597, 395);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(191, 43);
            this.Yellow.TabIndex = 2;
            this.Yellow.Text = "Yellow";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Blue
            // 
            this.Blue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Blue.ForeColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(402, 395);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(189, 43);
            this.Blue.TabIndex = 2;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Blue;
    }
}

