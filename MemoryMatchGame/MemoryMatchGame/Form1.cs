using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryMatchGame
{
   
    public partial class Form1 : Form
    {
        Image img1 = Image.FromFile("Images/card_heart.png");
        Image img2 = Image.FromFile("Images/card_x.png");
        Image img3 = Image.FromFile("Images/card_star.png");
        Image img4 = Image.FromFile("Images/card_thunder.png");

        Image hidden = Image.FromFile("Images/card_back.png");
    
        PictureBox firstClick = null;
        PictureBox secondClick = null;


        public Form1()
        {
            InitializeComponent();
            card1.Click += cardClick;
            card2.Click += cardClick;
            card3.Click += cardClick;
            card4.Click += cardClick;
            card5.Click += cardClick;
            card6.Click += cardClick;
            card7.Click += cardClick;
            card8.Click += cardClick;

            foreach (Control control in this.Controls)
            {
                PictureBox pb = control as PictureBox;

                pb.Image = hidden;
            }
        }

        private void cardClick(object sender, EventArgs e)
        {
            //Using this, you can check which box was clicked and distinguish each one
            PictureBox clickBox = sender as PictureBox;

            if (clickBox != null)
            {
                //Ignore the click of an already shown card
                if (clickBox.Image != hidden)
                {

                    if (firstClick == null)
                    {
                        firstClick = clickBox;
                        
                        return;
                    }

                    secondClick = clickBox;
                    Winner();

                    //If player chose two matches, keep them flipped over and reset the first and second clicks for more matches
                    if (firstClick.Image == secondClick.Image)
                    {
                        firstClick = null;
                        secondClick = null;
                        return;
                    }

                    timer1.Start();
                }

            }
        }
        


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            //Hide cards if there is no match
            firstClick.Image = hidden;
            secondClick.Image = hidden;

            firstClick.BackColor = Color.Black;
            secondClick.BackColor = Color.Black;

            //Reset clicks
            firstClick = null;
            secondClick = null;
        }


        /*Reference instances for the clicked images instead of having a direct image reference
          Having direct image references in DIFFERENT instances will return FALSE when comparing even if they are the same
          Having the SAME INSTANCES will return TRUE when comparing*/
        private void card1_Click(object sender, EventArgs e)
        {
            card1.Image = img1;
        }

        private void card2_Click(object sender, EventArgs e)
        {
            card2.Image = img2;
        }


        private void card3_Click(object sender, EventArgs e)
        {
            card3.Image = img4;
        }

        private void card4_Click(object sender, EventArgs e)
        {
            card4.Image = img4;
        }

        private void card5_Click(object sender, EventArgs e)
        {
            card5.Image = img3;
        }

        private void card6_Click(object sender, EventArgs e)
        {
            card6.Image = img1;
        }

        private void card7_Click(object sender, EventArgs e)
        {
            card7.Image = img3;
        }

        private void card8_Click(object sender, EventArgs e)
        {
            card8.Image = img2;
        }

        //If every icon is matched, players wins
        private void Winner()
        {
            foreach (Control control in this.Controls)
            {
                PictureBox pb2 = control as PictureBox;

                if (pb2 != null)
                {
                    if (pb2.Image == hidden)
                        return;
                }
            }

            MessageBox.Show("You won! Hurray!");
            Close();
        }
    }
}
