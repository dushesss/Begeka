namespace Lab2SoftWare
{
    partial class FormLab2
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
            this.lbxContent = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxContent
            // 
            this.lbxContent.FormattingEnabled = true;
            this.lbxContent.Items.AddRange(new object[] {
            "Раз, Два. Три! Четыре; Пять$",
            "Туда\' Сюда . Куда\"\"б",
            ",./?\'\";:!@#$%^&*()"});
            this.lbxContent.Location = new System.Drawing.Point(13, 13);
            this.lbxContent.Name = "lbxContent";
            this.lbxContent.Size = new System.Drawing.Size(329, 277);
            this.lbxContent.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 297);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Пуск";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(94, 302);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(59, 13);
            this.lResult.TabIndex = 2;
            this.lResult.Text = "Результат";
            // 
            // FormLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 328);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxContent);
            this.Name = "FormLab2";
            this.Text = "Лабораторная работа 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxContent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lResult;
    }
}

