namespace DBproject
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            textBoxN2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            errorProvider1 = new ErrorProvider(components);
            button6 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 55);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 102);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 1;
            label2.Text = "city";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 147);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 2;
            label3.Text = "country";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            textBox1.Validating += textBox1_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.Enter += textBox2_Enter;
            textBox2.KeyDown += textBox2_KeyDown;
            textBox2.KeyPress += textBox2_KeyPress;
            textBox2.KeyUp += textBox2_KeyUp;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(189, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            textBox3.Enter += textBox3_Enter;
            textBox3.KeyDown += textBox3_KeyDown;
            textBox3.KeyPress += textBox3_KeyPress;
            textBox3.KeyUp += textBox3_KeyUp;
            textBox3.Leave += textBox3_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(33, 244);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseClick += button1_MouseClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(189, 244);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Cyan;
            button3.Location = new Point(324, 244);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "display";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(35, 290);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 255, 128);
            button5.Location = new Point(189, 290);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 7;
            button5.Text = "update";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(489, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(446, 259);
            dataGridView1.TabIndex = 11;
            // 
            // textBoxN2
            // 
            textBoxN2.Location = new Point(334, 56);
            textBoxN2.Name = "textBoxN2";
            textBoxN2.Size = new Size(125, 27);
            textBoxN2.TabIndex = 12;
            textBoxN2.DoubleClick += textBoxN2_DoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(338, 86);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 13;
            label4.Text = "(only for update)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Lime;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(338, 9);
            label5.Name = "label5";
            label5.Size = new Size(218, 28);
            label5.TabIndex = 14;
            label5.Text = "Student Details Form ";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(189, 194);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 15;
            textBox4.Enter += textBox4_Enter;
            textBox4.KeyUp += textBox4_KeyUp;
            textBox4.Leave += textBox4_Leave;
            textBox4.Validated += textBox4_Validated;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 198);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 16;
            label6.Text = "email";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button6
            // 
            button6.Location = new Point(81, 356);
            button6.Name = "button6";
            button6.Size = new Size(116, 70);
            button6.TabIndex = 17;
            button6.Text = "Mouse";
            button6.UseVisualStyleBackColor = true;
            button6.MouseCaptureChanged += button6_MouseCaptureChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(266, 375);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 18;
            label7.Text = "events";
            label7.MouseDoubleClick += label7_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(947, 495);
            Controls.Add(label7);
            Controls.Add(button6);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxN2);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private TextBox textBoxN2;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private ErrorProvider errorProvider1;
        private Button button6;
        private Label label7;
    }
}