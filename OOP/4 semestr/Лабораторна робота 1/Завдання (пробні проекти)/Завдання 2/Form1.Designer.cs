
namespace Завдання_2
{
    partial class Form
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.surNameText = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.yearOld = new System.Windows.Forms.TextBox();
            this.surName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.yearOldText = new System.Windows.Forms.Label();
            this.sendButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(185, 166);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(109, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Видалити текст";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // surNameText
            // 
            this.surNameText.AutoSize = true;
            this.surNameText.Location = new System.Drawing.Point(129, 44);
            this.surNameText.Name = "surNameText";
            this.surNameText.Size = new System.Drawing.Size(84, 13);
            this.surNameText.TabIndex = 1;
            this.surNameText.Text = "Ваше призвіще";
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Location = new System.Drawing.Point(33, 44);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(55, 13);
            this.nameText.TabIndex = 2;
            this.nameText.Text = "Ваше ім\'я";
            // 
            // yearOld
            // 
            this.yearOld.Location = new System.Drawing.Point(232, 60);
            this.yearOld.Name = "yearOld";
            this.yearOld.Size = new System.Drawing.Size(100, 20);
            this.yearOld.TabIndex = 3;
            // 
            // surName
            // 
            this.surName.Location = new System.Drawing.Point(118, 60);
            this.surName.Name = "surName";
            this.surName.Size = new System.Drawing.Size(108, 20);
            this.surName.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(12, 60);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 5;
            // 
            // yearOldText
            // 
            this.yearOldText.AutoSize = true;
            this.yearOldText.Location = new System.Drawing.Point(229, 44);
            this.yearOldText.Name = "yearOldText";
            this.yearOldText.Size = new System.Drawing.Size(105, 13);
            this.yearOldText.TabIndex = 6;
            this.yearOldText.Text = "Скільки Вам років?";
            // 
            // sendButtom
            // 
            this.sendButtom.Location = new System.Drawing.Point(48, 166);
            this.sendButtom.Name = "sendButtom";
            this.sendButtom.Size = new System.Drawing.Size(124, 23);
            this.sendButtom.TabIndex = 7;
            this.sendButtom.Text = "Відправити анкету";
            this.sendButtom.UseVisualStyleBackColor = true;
            this.sendButtom.Click += new System.EventHandler(this.sendButtom_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.sendButtom);
            this.Controls.Add(this.yearOldText);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.surName);
            this.Controls.Add(this.yearOld);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.surNameText);
            this.Controls.Add(this.DeleteButton);
            this.Text = "Анкета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label surNameText;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.TextBox yearOld;
        private System.Windows.Forms.TextBox surName;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label yearOldText;
        private System.Windows.Forms.Button sendButtom;
    }
}

