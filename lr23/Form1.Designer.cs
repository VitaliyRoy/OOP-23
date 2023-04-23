namespace lr23
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
            this.ButtonDrawOnClick = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonDrawOnClick
            // 
            this.ButtonDrawOnClick.Location = new System.Drawing.Point(104, 99);
            this.ButtonDrawOnClick.Name = "ButtonDrawOnClick";
            this.ButtonDrawOnClick.Size = new System.Drawing.Size(75, 23);
            this.ButtonDrawOnClick.TabIndex = 0;
            this.ButtonDrawOnClick.Text = "ОК";
            this.ButtonDrawOnClick.UseVisualStyleBackColor = true;
            this.ButtonDrawOnClick.Click += new System.EventHandler(this.ButtonDrawOnClick_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(104, 47);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 1;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(346, 207);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 2;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(104, 73);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 20);
            this.textBoxT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "t";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.ButtonDrawOnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDrawOnClick;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

