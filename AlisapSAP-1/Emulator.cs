﻿using System;
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
        private int iIncrement = 0,
                    currentTop = 0, 
                    currentLeft = 0,
                    currentState = 0,
                    iStateController = 0;
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

            currentState = 1;
            direction = "LEFT";

            lblMoving.Top = lblPC.Top;
            lblMoving.Left = lblPC.Left;

            currentTop = lblMoving.Top;
            currentLeft = lblMoving.Left;
            lblPC.Text = "";

            timer1.Start();
        }

        private void State2()
        {
            currentState = 2;
            lblPC.Text = machineCode[iIncrement + 1, 0];
            State3();
        }

        private void State3()
        {
            currentState = 3;
            lblMoving.Top = currentTop = lblRam.Top;
            lblMoving.Left = currentLeft = lblRam.Left;

            lblMoving.Text = lblRam.Text;
            lblRam.Text = "";
            direction = "LEFT";
     
            timer1.Start();
        }

        private void State4()
        {
            currentState = 4;

            lblMoving.Top = lblIR.Top;
            lblMoving.Text = lblIR.Text.Substring(4, 4);

            direction = "LEFT";
            currentTop = lblMoving.Top;

            timer1.Start();
        }

        private void State5()
        {
            currentState = 5;            
           
            lblMoving.Top = lblRam.Top;
            lblMoving.Left = lblRam.Left;

            lblMoving.Text = lblRam.Text;

            iStateController = machineCode[iIncrement, 0] == "0001" ? 2 : 0;
            
            lblRam.Text = "";
            direction = "LEFT";

            timer1.Start();
        }

        public void State6()
        {
            if (iIncrement == 0)
            {
                iIncrement++;
                State1();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case "LEFT":
                    {
                        if (currentState == 5 && iStateController == 1)
                        {
                            if (lblMoving.Left < 500 && lblMoving.Left < 520)
                                lblMoving.Left += 10;
                            else
                            {
                                iStateController = 0;
                                lblAccu.Text = lblMoving.Text;
                                lblMoving.Text = "";

                                timer1.Stop();
                                State6();
                            } 
                        }
                        else if (currentState == 5 && iStateController == 2)
                        {
                            if (lblMoving.Left < 500 && lblMoving.Left < 520)
                                lblMoving.Left += 10;
                            else
                            {
                                lblReg.Text = lblMoving.Text;
                                lblMoving.Text = "";
                            }
                        }
                        else
                        {
                            if (lblMoving.Left < 320 && lblMoving.Left < 350)
                                lblMoving.Left += 10;
                            else
                            {
                                if (currentState == 4
                                    || currentState == 5) direction = "UP";
                                else direction = "DOWN";
                            } 
                        }
                        
                        break;
                    }
                case "DOWN":
                    {
                        if (lblMoving.Top < currentTop + 90 && lblMoving.Top < currentTop + 110)
                            lblMoving.Top += 10;
                        else direction = "RIGHT";
                        break;
                    }
                case "UP":
                    {
                        if (currentState == 5)
                        {
                            iStateController = 1;
                            if (lblMoving.Top > lblPC.Top && lblMoving.Top > lblPC.Top - 20)
                                lblMoving.Top -= 10;
                            else direction = "LEFT";
                        }
                        else
                        {
                            if (lblMoving.Top > lblIM.Top && lblMoving.Top > lblIM.Top - 20)
                                lblMoving.Top -= 10;
                            else direction = "RIGHT";
                        }
                        break;
                        
                    }
                case "RIGHT":
                    {
                        if (lblMoving.Left > currentLeft + 40 && lblMoving.Left > currentLeft)
                            lblMoving.Left -= 10;
                        else
                        {
                            
                            if (currentState == 1)
                            {
                                timer1.Stop();
                                lblIM.Text = lblMoving.Text;
                                lblMoving.Text = "";
                                lblRam.Text = machineCode[iIncrement, 1];

                                State2();
                            }
                            else if (currentState == 3)
                            {
                                if (iStateController == 0)
                                {
                                    lblIR.Text = lblMoving.Text;
                                    lblMoving.Text = lblMoving.Text.Substring(0, 4);

                                    direction = "DOWN";
                                    currentTop = lblIR.Top;

                                    iStateController = 1;
                                }
                                else if (iStateController == 1)
                                {
                                    lblCS.Text = lblMoving.Text;
                                    lblMoving.Text = "";
                                    iStateController = 0;

                                    timer1.Stop();
                                    State4();
                                }
                            }
                            else if (currentState == 4)
                            {
                                lblIM.Text = lblMoving.Text;
                                lblMoving.Text = "";
                                lblRam.Text = searchAddress();

                                timer1.Stop();
                                State5();
                            }
                        }
                        break;
                    }
                
                default:
                    break;
            }
        }

        private string searchAddress()
        {
            for (int i = 0; i < 16; i++)
            {
                if (machineCode[i, 0].Substring(0, 4) == lblIM.Text) return machineCode[i, 1];
            }

            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            State1();
        }
    }
}
