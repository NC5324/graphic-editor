namespace CourseProject
{
    partial class BucketToolOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.myCheckBox1 = new MyCheckBox();
            this.myCheckBox2 = new MyCheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Outline Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fill Color";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(123, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(123, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // myCheckBox1
            // 
            this.myCheckBox1.Checked = true;
            this.myCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.myCheckBox1.Location = new System.Drawing.Point(204, 21);
            this.myCheckBox1.Name = "myCheckBox1";
            this.myCheckBox1.Size = new System.Drawing.Size(26, 23);
            this.myCheckBox1.TabIndex = 4;
            this.myCheckBox1.Text = "myCheckBox1";
            this.myCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myCheckBox1.UseVisualStyleBackColor = true;
            this.myCheckBox1.CheckedChanged += new System.EventHandler(this.myCheckBox1_CheckedChanged);
            // 
            // myCheckBox2
            // 
            this.myCheckBox2.Checked = true;
            this.myCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.myCheckBox2.Location = new System.Drawing.Point(204, 55);
            this.myCheckBox2.Name = "myCheckBox2";
            this.myCheckBox2.Size = new System.Drawing.Size(26, 23);
            this.myCheckBox2.TabIndex = 5;
            this.myCheckBox2.Text = "myCheckBox2";
            this.myCheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myCheckBox2.UseVisualStyleBackColor = true;
            this.myCheckBox2.CheckedChanged += new System.EventHandler(this.myCheckBox2_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BucketToolOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 126);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.myCheckBox2);
            this.Controls.Add(this.myCheckBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BucketToolOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bucket Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MyCheckBox myCheckBox1;
        private MyCheckBox myCheckBox2;
        private System.Windows.Forms.Button button3;
    }
}