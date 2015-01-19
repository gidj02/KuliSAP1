using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlisapSAP_1
{
    public partial class Emulator : Form
    {
        private int iIncrement = 0, currentTop = 0, currentLeft = 0;
        private string[,] machineCode;
        private string direction = "";

        public Emulator(string[,] machineCode)
        {
            InitializeComponent();

            this.machineCode = machineCode;
            setLabel();
        }

        private void setLabel()
        {
            string sLabel = "";
            for (int i = 0; i < 16; i++)
            {
                if (machineCode[i, 2] == "-")
                    break;
                else
                {
                    sLabel += machineCode[i, 2] + "\n";
                }
            }

            AssemblyLabel.Text = sLabel;
        }

        private void State1()
        {
            lblMoving.Text = machineCode[iIncrement, 0];

            direction = "LEFT";
            currentTop = lblMoving.Top;
            currentLeft = lblMoving.Left;

            timer1.Start();
        }

        private void State2()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case "LEFT":
                    {
                        if (lblMoving.Left < 320 && lblMoving.Left < 350)
                            lblMoving.Left += 10;
                        else direction = "DOWN";
                        break;
                    }
                case "DOWN":
                    {
                        if (lblMoving.Top < currentTop + 90 && lblMoving.Top < currentTop + 110)
                            lblMoving.Top += 10;
                        else direction = "RIGHT";
                        break;
                    }
                case "RIGHT":
                    {
                        if (lblMoving.Left > currentLeft + 30 && lblMoving.Left > currentLeft)
                            lblMoving.Left -= 10;
                        else timer1.Stop();
                        break;
                    }
                
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            State1();
        }
    }
}
