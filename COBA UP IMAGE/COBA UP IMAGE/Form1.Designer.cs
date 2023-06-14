namespace COBA_UP_IMAGE
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
            btnUpload = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            image1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(374, 246);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(94, 29);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Browse";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // image1
            // 
            image1.Location = new Point(6, 1);
            image1.Name = "image1";
            image1.Size = new Size(191, 198);
            image1.SizeMode = PictureBoxSizeMode.StretchImage;
            image1.TabIndex = 3;
            image1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 45);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 4;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 124);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Nama";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(image1);
            panel1.Location = new Point(322, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 203);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(80, 246);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(671, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 202);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(743, 255);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 10;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 592);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnUpload);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpload;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox image1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}