namespace graphics
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
            this.button_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxw1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxw0 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_xmax = new System.Windows.Forms.TextBox();
            this.textBox_xmin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(776, 239);
            this.button_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(220, 95);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "построить";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.Построить_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(896, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "w1=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(771, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите параметры:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBoxw1
            // 
            this.textBoxw1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxw1.Location = new System.Drawing.Point(952, 142);
            this.textBoxw1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxw1.Name = "textBoxw1";
            this.textBoxw1.Size = new System.Drawing.Size(59, 22);
            this.textBoxw1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(771, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "w0=";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBoxw0
            // 
            this.textBoxw0.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxw0.Location = new System.Drawing.Point(831, 142);
            this.textBoxw0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxw0.Name = "textBoxw0";
            this.textBoxw0.Size = new System.Drawing.Size(59, 22);
            this.textBoxw0.TabIndex = 7;
            this.textBoxw0.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(89, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 492);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(897, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "xmax=";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(771, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "xmin=";
            // 
            // textBox_xmax
            // 
            this.textBox_xmax.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_xmax.Location = new System.Drawing.Point(971, 201);
            this.textBox_xmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_xmax.Name = "textBox_xmax";
            this.textBox_xmax.Size = new System.Drawing.Size(59, 22);
            this.textBox_xmax.TabIndex = 10;
            // 
            // textBox_xmin
            // 
            this.textBox_xmin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_xmin.Location = new System.Drawing.Point(829, 201);
            this.textBox_xmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_xmin.Name = "textBox_xmin";
            this.textBox_xmin.Size = new System.Drawing.Size(59, 22);
            this.textBox_xmin.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(771, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "A=";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxA.Location = new System.Drawing.Point(829, 102);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(59, 22);
            this.textBoxA.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(209, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "график вида : Asin(w1*t)sin(w0*t)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(776, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 74);
            this.button2.TabIndex = 15;
            this.button2.Text = "Построить по точкам";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(799, 408);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 30);
            this.textBox1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(782, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Путь к файлу:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 596);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_xmin);
            this.Controls.Add(this.textBox_xmax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxw0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxw1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Построение графика";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxw1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxw0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_xmax;
        private System.Windows.Forms.TextBox textBox_xmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}

