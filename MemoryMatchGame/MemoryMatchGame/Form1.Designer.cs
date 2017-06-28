namespace MemoryMatchGame
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
            this.card1 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card6 = new System.Windows.Forms.PictureBox();
            this.card7 = new System.Windows.Forms.PictureBox();
            this.card8 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).BeginInit();
            this.SuspendLayout();
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.Black;
            this.card1.Location = new System.Drawing.Point(48, 87);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(149, 221);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.card1.TabIndex = 0;
            this.card1.TabStop = false;
            this.card1.Click += new System.EventHandler(this.card1_Click);
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.Black;
            this.card2.Location = new System.Drawing.Point(243, 87);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(149, 221);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.card2.TabIndex = 1;
            this.card2.TabStop = false;
            this.card2.Click += new System.EventHandler(this.card2_Click);
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.Black;
            this.card3.Location = new System.Drawing.Point(441, 87);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(149, 221);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.card3.TabIndex = 2;
            this.card3.TabStop = false;
            this.card3.Click += new System.EventHandler(this.card3_Click);
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.Color.Black;
            this.card4.Location = new System.Drawing.Point(662, 87);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(149, 221);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.card4.TabIndex = 3;
            this.card4.TabStop = false;
            this.card4.Click += new System.EventHandler(this.card4_Click);
            // 
            // card5
            // 
            this.card5.BackColor = System.Drawing.Color.Black;
            this.card5.Location = new System.Drawing.Point(48, 364);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(149, 221);
            this.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.card5.TabIndex = 4;
            this.card5.TabStop = false;
            this.card5.Click += new System.EventHandler(this.card5_Click);
            // 
            // card6
            // 
            this.card6.BackColor = System.Drawing.Color.Black;
            this.card6.Location = new System.Drawing.Point(243, 364);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(149, 221);
            this.card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.card6.TabIndex = 5;
            this.card6.TabStop = false;
            this.card6.Click += new System.EventHandler(this.card6_Click);
            // 
            // card7
            // 
            this.card7.BackColor = System.Drawing.Color.Black;
            this.card7.Location = new System.Drawing.Point(441, 364);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(149, 221);
            this.card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.card7.TabIndex = 6;
            this.card7.TabStop = false;
            this.card7.Click += new System.EventHandler(this.card7_Click);
            // 
            // card8
            // 
            this.card8.BackColor = System.Drawing.Color.Black;
            this.card8.Location = new System.Drawing.Point(662, 364);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(149, 221);
            this.card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.card8.TabIndex = 7;
            this.card8.TabStop = false;
            this.card8.Click += new System.EventHandler(this.card8_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 671);
            this.Controls.Add(this.card8);
            this.Controls.Add(this.card7);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card5;
        private System.Windows.Forms.PictureBox card6;
        private System.Windows.Forms.PictureBox card7;
        private System.Windows.Forms.PictureBox card8;
        private System.Windows.Forms.Timer timer1;
    }
}

