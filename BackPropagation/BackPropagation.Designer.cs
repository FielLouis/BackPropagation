namespace BackPropagation
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(215, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 52);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(215, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 52);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(215, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 52);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(112, 334);
            button1.Name = "button1";
            button1.Size = new Size(194, 87);
            button1.TabIndex = 4;
            button1.Text = "Create BPNN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(399, 334);
            button2.Name = "button2";
            button2.Size = new Size(194, 87);
            button2.TabIndex = 5;
            button2.Text = "Train the NeuralNet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(686, 334);
            button3.Name = "button3";
            button3.Size = new Size(194, 87);
            button3.TabIndex = 6;
            button3.Text = "Test";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 20F);
            textBox4.Location = new Point(215, 253);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 52);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 20F);
            textBox5.Location = new Point(547, 147);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(333, 52);
            textBox5.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 83);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 8;
            label1.Text = "Total Epoch: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Back Propagation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
    }
}
