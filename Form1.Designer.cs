namespace KohiClickTest_Port
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clickcount = new System.Windows.Forms.Label();
            this.clickbutton = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Timer(this.components);
            this.restart = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kohi Click Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(664, 36);
            this.label2.TabIndex = 1;
            this.label2.Tag = "";
            this.label2.Text = "This is the click test that was featured on Kohi. Simply click the box below as f" +
    "ast as you can for \r\n10 seconds, and you\'ll be given your average CPS.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KohiClickTest_Port.Properties.Resources.kohi_click_test;
            this.pictureBox1.Location = new System.Drawing.Point(664, -7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 177);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // clickcount
            // 
            this.clickcount.AutoSize = true;
            this.clickcount.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickcount.Location = new System.Drawing.Point(2, 148);
            this.clickcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clickcount.Name = "clickcount";
            this.clickcount.Size = new System.Drawing.Size(90, 22);
            this.clickcount.TabIndex = 3;
            this.clickcount.Text = "Clicks: 0";
            // 
            // clickbutton
            // 
            this.clickbutton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickbutton.Location = new System.Drawing.Point(5, 174);
            this.clickbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clickbutton.Name = "clickbutton";
            this.clickbutton.Size = new System.Drawing.Size(857, 339);
            this.clickbutton.TabIndex = 4;
            this.clickbutton.Text = "Click Here";
            this.clickbutton.UseVisualStyleBackColor = true;
            this.clickbutton.Click += new System.EventHandler(this.clickbutton_Click);
            // 
            // count
            // 
            this.count.Interval = 1000;
            this.count.Tick += new System.EventHandler(this.counttick);
            // 
            // restart
            // 
            this.restart.Font = new System.Drawing.Font("Arial", 10F);
            this.restart.Location = new System.Drawing.Point(9, 174);
            this.restart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(95, 27);
            this.restart.TabIndex = 5;
            this.restart.Text = "Restart Test";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Arial", 11F);
            this.time.Location = new System.Drawing.Point(3, 521);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(65, 17);
            this.time.TabIndex = 6;
            this.time.Text = "timehere";
            this.time.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 547);
            this.Controls.Add(this.clickbutton);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.time);
            this.Controls.Add(this.clickcount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Kohi Click Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label clickcount;
        private System.Windows.Forms.Button clickbutton;
        private System.Windows.Forms.Timer count;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label time;
    }
}

