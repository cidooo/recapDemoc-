using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buton = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i =0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    buton[i, j] = new Button();
                    buton[i, j].Left += left;
                    buton[i, j].Top += top;
                    buton[i, j].Width = 50;
                    buton[i, j].Height = 50;
                    left += 50;
                    this.Controls.Add(buton[i, j]);
                    if((j+i)%2==0)
                    {
                        buton[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buton[i, j].BackColor = Color.White;
                    }


                }
                left=0;
                top += 50;
                
            }
           
        }
    }
}
