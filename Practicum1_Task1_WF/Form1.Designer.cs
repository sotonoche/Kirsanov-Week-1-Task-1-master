namespace Practicum1_Task1_WF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericFirst = new System.Windows.Forms.NumericUpDown();
            this.NumericSecond = new System.Windows.Forms.NumericUpDown();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите 1-е число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите 2-е число:";
            // 
            // NumericFirst
            // 
            this.NumericFirst.DecimalPlaces = 2;
            this.NumericFirst.Location = new System.Drawing.Point(120, 18);
            this.NumericFirst.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericFirst.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.NumericFirst.Name = "NumericFirst";
            this.NumericFirst.Size = new System.Drawing.Size(120, 20);
            this.NumericFirst.TabIndex = 2;
            // 
            // NumericSecond
            // 
            this.NumericSecond.DecimalPlaces = 2;
            this.NumericSecond.Location = new System.Drawing.Point(120, 57);
            this.NumericSecond.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericSecond.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.NumericSecond.Name = "NumericSecond";
            this.NumericSecond.Size = new System.Drawing.Size(120, 20);
            this.NumericSecond.TabIndex = 3;
            // 
            // ButtonResult
            // 
            this.ButtonResult.Location = new System.Drawing.Point(91, 124);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(75, 23);
            this.ButtonResult.TabIndex = 4;
            this.ButtonResult.Text = "Вычислить";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат вычислений:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(135, 162);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(105, 20);
            this.textBoxResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 195);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.NumericSecond);
            this.Controls.Add(this.NumericFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Практикум 1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericFirst;
        private System.Windows.Forms.NumericUpDown NumericSecond;
        private System.Windows.Forms.Button ButtonResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

