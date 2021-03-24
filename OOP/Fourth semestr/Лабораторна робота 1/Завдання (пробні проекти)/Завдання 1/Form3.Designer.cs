
namespace Завдання
{
    partial class Form3
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
            this.close2and3form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close2and3form
            // 
            this.close2and3form.Location = new System.Drawing.Point(74, 91);
            this.close2and3form.Name = "close2and3form";
            this.close2and3form.Size = new System.Drawing.Size(185, 23);
            this.close2and3form.TabIndex = 0;
            this.close2and3form.Text = "Close second and third forms";
            this.close2and3form.UseVisualStyleBackColor = true;
            this.close2and3form.Click += new System.EventHandler(this.close2and3form_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.close2and3form);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close2and3form;
    }
}