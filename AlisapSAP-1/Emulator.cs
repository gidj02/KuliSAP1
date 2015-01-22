using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kuliSAP1
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

            lblAssembly.Text = sLabel;
        }

        private void State1()
        {
            setLblMoving(1);

            currentState = 1;
            direction = "LEFT";

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
            setLblMoving(2);

            currentState = 3;           
            direction = "LEFT";
  
            timer1.Start();
        }

        private void State4()
        {
            if (iStateController == -1)
            {
                setLblMoving(6);
                direction = "RIGHT";

                currentState = 4;
                timer1.Start();
            }
            else if (iStateController == -2)
            {
                MessageBox.Show("System Halted!"); // END OF SYNCHRONOUS
                btnSync.Enabled = true;
                btnJump.Enabled = true;
            }
            else
            {
                setLblMoving(3);
                direction = "LEFT";

                currentState = 4;
                timer1.Start();
            }
        }

        private void State5()
        {
            setLblMoving(4);
            iStateController = machineCode[iIncrement, 0] == "0001" ? 2 : 0;
            
            currentState = 5;   
            direction = "LEFT";

            timer1.Start();
        }

        public void State6()
        {
            if (iIncrement == 0)
            {
                State1();
            }
            else if (lblAddSub.Text != "")
            {
                setLblMoving(5);

                currentState = 6;
                direction = "RIGHT";

                timer1.Start();
            }

            iIncrement++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case "LEFT":
                    {
                        if (currentState == 5 && iStateController == 1) //data going to accumulator
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
                        else if (currentState == 5 && iStateController == 2) // data going to register
                        {
                            if (lblMoving.Left < 500 && lblMoving.Left < 520)
                                lblMoving.Left += 10;
                            else
                            {
                                lblReg.Text = lblMoving.Text;
                                lblMoving.Text = "";

                                int value = Convert.ToInt32(lblAccu.Text, 2) + Convert.ToInt32(lblReg.Text, 2);
                                lblAddSub.Text = Convert.ToString(value, 2);

                                iStateController = 0;

                                timer1.Stop();
                                State6();
                            }
                        }
                        else if (currentState == 4 && iStateController == -1) // out
                        {
                            if (lblMoving.Left < 500 && lblMoving.Left < 520)
                                lblMoving.Left += 10;
                            else
                            {
                                lblOR.Text = lblMoving.Text;
                                lblMoving.Text = "";

                                iStateController = 0;

                                lblBO.Text = Convert.ToInt32(lblOR.Text, 2).ToString();
                                timer1.Stop();

                                iIncrement++;
                                State1();// OUT straight to state 1
                            }
                        }
                        else if (currentState == 6) // data going to accumulator
                        {
                            if (lblMoving.Left < 500 && lblMoving.Left < 520)
                                lblMoving.Left += 10;
                            else
                            {
                                iStateController = 0;
                                lblAccu.Text = lblMoving.Text;
                                lblMoving.Text = "";

                                timer1.Stop();
                                State1();
                            } 
                            
                        }
                        else // data are moving (not stable)
                        {
                            if (lblMoving.Left < 320 && lblMoving.Left < 350)
                                lblMoving.Left += 10;
                            else
                            {
                                if (currentState == 4|| currentState == 5) direction = "UP";
                                else direction = "DOWN";
                            } 
                        }
                        
                        break;
                    }
                case "DOWN":
                    {
                        if (currentState == 4 && iStateController == -1)
                        {
                            if (lblMoving.Top < lblOR.Top && lblMoving.Top < lblOR.Top + 20)
                                lblMoving.Top += 10;
                            else direction = "LEFT";
                        }
                        else
                        {
                            if (lblMoving.Top < currentTop + 90 && lblMoving.Top < currentTop + 110)
                                lblMoving.Top += 10;
                            else direction = "RIGHT";
                        }
                        
                        break;
                    }
                case "UP":
                    {
                        if (currentState == 5) // on the way to accumulator
                        {
                            iStateController = 1;
                            if (lblMoving.Top > lblPC.Top && lblMoving.Top > lblPC.Top - 20)
                                lblMoving.Top -= 10;
                            else direction = "LEFT";
                        }
                        else if (currentState == 6) // on the way to accumulator
                        {
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
                        if (currentState == 6) 
                        {
                            if (lblMoving.Left > currentLeft - 190 && lblMoving.Left > currentLeft - 210)
                                lblMoving.Left -= 10;
                            else direction = "UP";
                        }
                        else if (currentState == 4 && iStateController == -1) // OUT
                        {
                            if (lblMoving.Left > currentLeft - 190 && lblMoving.Left > currentLeft - 210)
                                lblMoving.Left -= 10;
                            else direction = "DOWN";
                        }
                        else if (lblMoving.Left > currentLeft + 40 && lblMoving.Left > currentLeft)
                            lblMoving.Left -= 10;
                        else
                        {
                            switch (currentState)
                            {
                                case 1: //state 1
                                    {
                                        lblIM.Text = lblMoving.Text;
                                        lblMoving.Text = "";
                                        lblRam.Text = machineCode[iIncrement, 1];

                                        timer1.Stop();
                                        State2();
                                        break;
                                    }
                                case 3: //state 3
                                    {
                                        if (iStateController == 0)
                                        {
                                            lblIR.Text = lblMoving.Text;
                                            lblMoving.Text = lblMoving.Text.Substring(0, 4);

                                            direction = "DOWN";
                                            currentTop = lblIR.Top;

                                            iStateController = 1; // go to Control Sequencer
                                        }
                                        else if (iStateController == 1) 
                                        {
                                            lblCS.Text = lblMoving.Text;
                                            lblMoving.Text = "";
                                            iStateController = 0;

                                            if (lblCS.Text == "1110")
                                            {
                                                iStateController = -1; // OUT
                                            }
                                            else if(lblCS.Text == "1111")
                                            {
                                                iStateController = -2; // HALTED
                                            }
                                            timer1.Stop();
                                            State4();
                                        }
                                        break;
                                    }
                                case 4: //state 4
                                    {
                                        lblIM.Text = lblMoving.Text;
                                        lblMoving.Text = "";
                                        lblRam.Text = searchAddress();

                                        timer1.Stop();
                                        State5();
                                        break;
                                    }
                            }// switch for states
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
            btnSync.Enabled = false;
            btnJump.Enabled = false;

            lblMoving.Visible = true;
            State1();
        }

        private void setLblMoving(int reference)
        {
            switch (reference)
            {
                case 1: //Program Counter (state 1)
                    {
                        lblMoving.Text = machineCode[iIncrement, 0];
                        lblMoving.Top = lblPC.Top;
                        lblMoving.Left = lblPC.Left;
                        currentTop = lblMoving.Top;
                        currentLeft = lblMoving.Left;
                        lblPC.Text = "";
                        break;
                    }
                case 2: //Ram (state 3)
                    {
                        lblMoving.Top = lblRam.Top;
                        lblMoving.Left = lblRam.Left;
                        currentTop = lblMoving.Top;
                        currentLeft = lblMoving.Left;
                        lblMoving.Text = lblRam.Text;
                        lblRam.Text = "";
                        break;
                    }
                case 3: //Instruction Register (state 4)
                    {
                        lblMoving.Top = lblIR.Top;
                        lblMoving.Text = lblIR.Text.Substring(4, 4);
                        currentTop = lblMoving.Top;
                        currentLeft = lblMoving.Left;
                        break;
                    }
                case 4: //Ram (state 5)
                    {
                        lblMoving.Top = lblRam.Top;
                        lblMoving.Left = lblRam.Left;
                        lblMoving.Text = lblRam.Text;
                        currentTop = lblMoving.Top;
                        currentLeft = lblMoving.Left;
                        lblRam.Text = "";
                        break;
                    }
                case 5: //Adder/Subtractor (state 6)
                    {
                        lblMoving.Top = lblAddSub.Top;
                        lblMoving.Left = lblAddSub.Left;
                        lblMoving.Text = lblAddSub.Text;
                        currentTop = lblMoving.Top;
                        currentLeft = lblMoving.Left;
                        lblAddSub.Text = "";
                        break;
                    }
                case 6: // Accumulator (OUT - State 4)
                    {
                        lblMoving.Top = lblAccu.Top;
                        lblMoving.Left = lblAccu.Left;
                        lblMoving.Text = lblAccu.Text;
                        currentTop = lblMoving.Top;
                        currentLeft = lblMoving.Left;
                        lblAccu.Text = "";
                        break;
                    }
            }
        }

        
    }
}
