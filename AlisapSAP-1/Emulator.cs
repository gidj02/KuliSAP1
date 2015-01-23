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
                    iCurrentTop = 0,
                    iCurrentLeft = 0,
                    iCurrentState = 0,
                    iStateController = 0,
                    iJumpStateController = -1;
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

        private void btnSync_Click(object sender, EventArgs e)
        {
            Reset();
            btnSync.Enabled = false;
            btnJump.Enabled = false;

            lblMoving.Visible = true;
            SyncState1();
        }

        private void btnJump_Click(object sender, EventArgs e)
        {
            if (iJumpStateController == -1)
            {
                Reset();
                iJumpStateController++;
            }
            btnSync.Enabled = false;
            btnJump.Enabled = false;

            lblMoving.Visible = true;
            JumpController(++iJumpStateController);
        }

        /* 
         * 
         * Start of Synchronous Part
         * 
         */

        private void SyncState1()
        {
            setLblMoving(1);

            iCurrentState = 1;
            direction = "LEFT";

            timerSynchronous.Start();
        }

        private void SyncState2()
        {
            iCurrentState = 2;
            lblPC.Text = machineCode[iIncrement + 1, 0];
            SyncState3();
        }

        private void SyncState3()
        {
            setLblMoving(2);

            iCurrentState = 3;           
            direction = "LEFT";
  
            timerSynchronous.Start();
        }

        private void SyncState4()
        {
            if (iStateController == -1)
            {
                setLblMoving(6);
                direction = "RIGHT";

                iCurrentState = 4;
                timerSynchronous.Start();
            }
            else if (iStateController == -2)
            {
                MessageBox.Show("System Halted!"); // END OF SYNCHRONOUS
                iJumpStateController = -1;
                btnSync.Enabled = true;
                btnJump.Enabled = true;
            }
            else
            {
                setLblMoving(3);
                direction = "LEFT";

                iCurrentState = 4;
                timerSynchronous.Start();
            }
        }

        private void SyncState5()
        {
            setLblMoving(4);
            iStateController = machineCode[iIncrement, 0] == "0001" ? 2 : 0;
            
            iCurrentState = 5;   
            direction = "LEFT";

            timerSynchronous.Start();
        }

        public void SyncState6()
        {
            if (iIncrement == 0)
            {
                SyncState1();
            }
            else if (lblAddSub.Text != "")
            {
                setLblMoving(5);

                iCurrentState = 6;
                direction = "RIGHT";

                timerSynchronous.Start();
            }

            iIncrement++;
        }

        private void timerSynchronous_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case "LEFT":
                    {
                        if (iCurrentState == 5 && iStateController == 1) //data going to accumulator
                        {
                            if (lblMoving.Left < 500 && lblMoving.Left < 520)
                                lblMoving.Left += 10;
                            else
                            {
                                iStateController = 0;
                                lblAccu.Text = lblMoving.Text;
                                lblMoving.Text = "";

                                timerSynchronous.Stop();
                                SyncState6();
                            } 
                        }
                        else if (iCurrentState == 5 && iStateController == 2) // data going to register
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

                                timerSynchronous.Stop();
                                SyncState6();
                            }
                        }
                        else if (iCurrentState == 4 && iStateController == -1) // out
                        {
                            if (lblMoving.Left < 500 && lblMoving.Left < 520)
                                lblMoving.Left += 10;
                            else
                            {
                                lblOR.Text = lblMoving.Text;
                                lblMoving.Text = "";

                                iStateController = 0;

                                lblBO.Text = Convert.ToInt32(lblOR.Text, 2).ToString();
                                timerSynchronous.Stop();

                                iIncrement++;
                                SyncState1();// OUT straight to state 1
                            }
                        }
                        else if (iCurrentState == 6) // data going to accumulator
                        {
                            if (lblMoving.Left < 500 && lblMoving.Left < 520)
                                lblMoving.Left += 10;
                            else
                            {
                                iStateController = 0;
                                lblAccu.Text = lblMoving.Text;
                                lblMoving.Text = "";

                                timerSynchronous.Stop();
                                SyncState1();
                            } 
                            
                        }
                        else // data are moving (not stable)
                        {
                            if (lblMoving.Left < 320 && lblMoving.Left < 350)
                                lblMoving.Left += 10;
                            else
                            {
                                if (iCurrentState == 4|| iCurrentState == 5) direction = "UP";
                                else direction = "DOWN";
                            } 
                        }
                        
                        break;
                    }
                case "DOWN":
                    {
                        if (iCurrentState == 4 && iStateController == -1)
                        {
                            if (lblMoving.Top < lblOR.Top && lblMoving.Top < lblOR.Top + 20)
                                lblMoving.Top += 10;
                            else direction = "LEFT";
                        }
                        else
                        {
                            if (lblMoving.Top < iCurrentTop + 90 && lblMoving.Top < iCurrentTop + 110)
                                lblMoving.Top += 10;
                            else direction = "RIGHT";
                        }
                        
                        break;
                    }
                case "UP":
                    {
                        if (iCurrentState == 5) // on the way to accumulator
                        {
                            iStateController = 1;
                            if (lblMoving.Top > lblPC.Top && lblMoving.Top > lblPC.Top - 20)
                                lblMoving.Top -= 10;
                            else direction = "LEFT";
                        }
                        else if (iCurrentState == 6) // on the way to accumulator
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
                        if (iCurrentState == 6) 
                        {
                            if (lblMoving.Left > iCurrentLeft - 190 && lblMoving.Left > iCurrentLeft - 210)
                                lblMoving.Left -= 10;
                            else direction = "UP";
                        }
                        else if (iCurrentState == 4 && iStateController == -1) // OUT
                        {
                            if (lblMoving.Left > iCurrentLeft - 190 && lblMoving.Left > iCurrentLeft - 210)
                                lblMoving.Left -= 10;
                            else direction = "DOWN";
                        }
                        else if (lblMoving.Left > iCurrentLeft + 40 && lblMoving.Left > iCurrentLeft)
                            lblMoving.Left -= 10;
                        else
                        {
                            switch (iCurrentState)
                            {
                                case 1: //state 1
                                    {
                                        lblIM.Text = lblMoving.Text;
                                        lblMoving.Text = "";
                                        lblRam.Text = machineCode[iIncrement, 1];

                                        timerSynchronous.Stop();
                                        SyncState2();
                                        break;
                                    }
                                case 3: //state 3
                                    {
                                        if (iStateController == 0)
                                        {
                                            lblIR.Text = lblMoving.Text;
                                            lblMoving.Text = lblMoving.Text.Substring(0, 4);

                                            direction = "DOWN";
                                            iCurrentTop = lblIR.Top;

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
                                            timerSynchronous.Stop();
                                            SyncState4();
                                        }
                                        break;
                                    }
                                case 4: //state 4
                                    {
                                        lblIM.Text = lblMoving.Text;
                                        lblMoving.Text = "";
                                        lblRam.Text = searchAddress();

                                        timerSynchronous.Stop();
                                        SyncState5();
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

        /* 
         * 
         * End of Synchronous Part
         *  
         */


        /* 
         * 
         * Start of Jump Part
         * 
         */
        private void JumpController(int iTempController)
        {
            switch (iTempController)
            {
                case 1: JumpState1(); break;
                case 2: JumpState2(); break;
                case 3: JumpState3(); break;
                case 4: JumpState4(); break;
                case 5: JumpState5(); break;
                case 6: JumpState6(); break;
            }
        }

        private void JumpState1()
        {
            setLblMoving(1);

            iCurrentState = 1;
            direction = "LEFT";

            lblState.Text = "State 1";
            timerJump.Start();
        }

        private void JumpState2()
        {
            lblState.Text = "State 2";

            iCurrentState = 2;
            lblPC.Text = machineCode[iIncrement + 1, 0];

            btnSync.Enabled = true;
            btnJump.Enabled = true;
        }

        private void JumpState3()
        {
            lblState.Text = "State 3";
            setLblMoving(2);

            iCurrentState = 3;
            direction = "LEFT";

            timerJump.Start();
        }

        private void JumpState4()
        {
            lblState.Text = "State 4";
            if (iStateController == -1)
            {
                setLblMoving(6);
                direction = "RIGHT";

                iCurrentState = 4;
                timerJump.Start();
            }
            else if (iStateController == -2)
            {
                MessageBox.Show("System Halted!"); // END OF SYNCHRONOUS
                btnSync.Enabled = true;
                btnJump.Enabled = true;
                iCurrentState = 0;
            }
            else
            {
                setLblMoving(3);
                direction = "LEFT";

                iCurrentState = 4;
                timerJump.Start();
            }
        }

        private void JumpState5()
        {
            lblState.Text = "State 5";
            setLblMoving(4);
            iStateController = machineCode[iIncrement, 0] == "0001" ? 2 : 0;

            iCurrentState = 5;
            direction = "LEFT";

            timerJump.Start();
        }

        public void JumpState6()
        {
           lblState.Text = "State 6";
           if (lblAddSub.Text != "")
            {
                setLblMoving(5);

                iCurrentState = 6;
                direction = "RIGHT";

                timerJump.Start();
            }
            if (iIncrement == 0)
            {
                btnSync.Enabled = true;
                btnJump.Enabled = true;
            }
            iIncrement++;
            iJumpStateController = 0;
        }

        private void timerJump_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case "LEFT":
                    {
                        if (iCurrentState == 5 && iStateController == 1) //data going to accumulator
                        {
                            if (lblMoving.Left < 500 && lblMoving.Left < 520)
                                lblMoving.Left += 10;
                            else
                            {
                                iStateController = 0;
                                lblAccu.Text = lblMoving.Text;
                                lblMoving.Text = "";

                                timerJump.Stop();
                                btnSync.Enabled = true;
                                btnJump.Enabled = true;
                            }
                        }
                        else if (iCurrentState == 5 && iStateController == 2) // data going to register
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

                                timerJump.Stop();
                                btnSync.Enabled = true;
                                btnJump.Enabled = true;
                            }
                        }
                        else if (iCurrentState == 4 && iStateController == -1) // out
                        {
                            if (lblMoving.Left < 500 && lblMoving.Left < 520)
                                lblMoving.Left += 10;
                            else
                            {
                                lblOR.Text = lblMoving.Text;
                                lblMoving.Text = "";

                                iStateController = 0;

                                lblBO.Text = Convert.ToInt32(lblOR.Text, 2).ToString();
                                timerJump.Stop();

                                btnSync.Enabled = true;
                                btnJump.Enabled = true;

                                iJumpStateController = 0;
                                iIncrement++;
                            }
                        }
                        else if (iCurrentState == 6) // data going to accumulator
                        {
                            if (lblMoving.Left < 500 && lblMoving.Left < 520)
                                lblMoving.Left += 10;
                            else
                            {
                                iStateController = 0;
                                lblAccu.Text = lblMoving.Text;
                                lblMoving.Text = "";

                                timerJump.Stop();
                                btnSync.Enabled = true;
                                btnJump.Enabled = true;
                            }

                        }
                        else // data are moving (not stable)
                        {
                            if (lblMoving.Left < 320 && lblMoving.Left < 350)
                                lblMoving.Left += 10;
                            else
                            {
                                if (iCurrentState == 4 || iCurrentState == 5) direction = "UP";
                                else direction = "DOWN";
                            }
                        }

                        break;
                    }
                case "DOWN":
                    {
                        if (iCurrentState == 4 && iStateController == -1)
                        {
                            if (lblMoving.Top < lblOR.Top && lblMoving.Top < lblOR.Top + 20)
                                lblMoving.Top += 10;
                            else direction = "LEFT";
                        }
                        else
                        {
                            if (lblMoving.Top < iCurrentTop + 90 && lblMoving.Top < iCurrentTop + 110)
                                lblMoving.Top += 10;
                            else direction = "RIGHT";
                        }

                        break;
                    }
                case "UP":
                    {
                        if (iCurrentState == 5) // on the way to accumulator
                        {
                            iStateController = 1;
                            if (lblMoving.Top > lblPC.Top && lblMoving.Top > lblPC.Top - 20)
                                lblMoving.Top -= 10;
                            else direction = "LEFT";
                        }
                        else if (iCurrentState == 6) // on the way to accumulator
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
                        if (iCurrentState == 6)
                        {
                            if (lblMoving.Left > iCurrentLeft - 190 && lblMoving.Left > iCurrentLeft - 210)
                                lblMoving.Left -= 10;
                            else direction = "UP";
                        }
                        else if (iCurrentState == 4 && iStateController == -1) // OUT
                        {
                            if (lblMoving.Left > iCurrentLeft - 190 && lblMoving.Left > iCurrentLeft - 210)
                                lblMoving.Left -= 10;
                            else direction = "DOWN";
                        }
                        else if (lblMoving.Left > iCurrentLeft + 40 && lblMoving.Left > iCurrentLeft)
                            lblMoving.Left -= 10;
                        else
                        {
                            switch (iCurrentState)
                            {
                                case 1: //state 1
                                    {
                                        lblIM.Text = lblMoving.Text;
                                        lblMoving.Text = "";
                                        lblRam.Text = machineCode[iIncrement, 1];

                                        timerJump.Stop();
                                        btnSync.Enabled = true;
                                        btnJump.Enabled = true;
                                        break;
                                    }
                                case 3: //state 3
                                    {
                                        if (iStateController == 0)
                                        {
                                            lblIR.Text = lblMoving.Text;
                                            lblMoving.Text = lblMoving.Text.Substring(0, 4);

                                            direction = "DOWN";
                                            iCurrentTop = lblIR.Top;

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
                                            else if (lblCS.Text == "1111")
                                            {
                                                iStateController = -2; // HALTED
                                            }
                                            timerJump.Stop();
                                            btnSync.Enabled = true;
                                            btnJump.Enabled = true;
                                        }
                                        break;
                                    }
                                case 4: //state 4
                                    {
                                        lblIM.Text = lblMoving.Text;
                                        lblMoving.Text = "";
                                        lblRam.Text = searchAddress();

                                        timerJump.Stop();
                                        btnSync.Enabled = true;
                                        btnJump.Enabled = true;
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

        /* 
         * 
         * End of Jump Part
         *  
         */

        private void setLblMoving(int reference)
        {
            switch (reference)
            {
                case 1: //Program Counter (state 1)
                    {
                        lblMoving.Text = machineCode[iIncrement, 0];
                        lblMoving.Top = lblPC.Top;
                        lblMoving.Left = lblPC.Left;
                        iCurrentTop = lblMoving.Top;
                        iCurrentLeft = lblMoving.Left;
                        lblPC.Text = "";
                        break;
                    }
                case 2: //Ram (state 3)
                    {
                        lblMoving.Top = lblRam.Top;
                        lblMoving.Left = lblRam.Left;
                        iCurrentTop = lblMoving.Top;
                        iCurrentLeft = lblMoving.Left;
                        lblMoving.Text = lblRam.Text;
                        lblRam.Text = "";
                        break;
                    }
                case 3: //Instruction Register (state 4)
                    {
                        lblMoving.Top = lblIR.Top;
                        lblMoving.Text = lblIR.Text.Substring(4, 4);
                        iCurrentTop = lblMoving.Top;
                        iCurrentLeft = lblMoving.Left;
                        break;
                    }
                case 4: //Ram (state 5)
                    {
                        lblMoving.Top = lblRam.Top;
                        lblMoving.Left = lblRam.Left;
                        lblMoving.Text = lblRam.Text;
                        iCurrentTop = lblMoving.Top;
                        iCurrentLeft = lblMoving.Left;
                        lblRam.Text = "";
                        break;
                    }
                case 5: //Adder/Subtractor (state 6)
                    {
                        lblMoving.Top = lblAddSub.Top;
                        lblMoving.Left = lblAddSub.Left;
                        lblMoving.Text = lblAddSub.Text;
                        iCurrentTop = lblMoving.Top;
                        iCurrentLeft = lblMoving.Left;
                        lblAddSub.Text = "";
                        break;
                    }
                case 6: // Accumulator (OUT - State 4)
                    {
                        lblMoving.Top = lblAccu.Top;
                        lblMoving.Left = lblAccu.Left;
                        lblMoving.Text = lblAccu.Text;
                        iCurrentTop = lblMoving.Top;
                        iCurrentLeft = lblMoving.Left;
                        lblAccu.Text = "";
                        break;
                    }
            }
        }//SetlblMoving 

        private string searchAddress()
        {
            for (int i = 0; i < 16; i++)
            {
                if (machineCode[i, 0].Substring(0, 4) == lblIM.Text) return machineCode[i, 1];
            }
            return "";
        }

        private void Reset()
        {
            lblPC.Text = lblAccu.Text = lblAddSub.Text = lblBO.Text = lblCS.Text = lblIM.Text = lblIR.Text = lblMoving.Text = lblOR.Text = lblRam.Text = lblReg.Text = "";
            lblMoving.Left = lblPC.Left;
            lblMoving.Top = lblPC.Top;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnJump.Enabled = true;
            btnSync.Enabled = true;

            timerJump.Stop();
            timerSynchronous.Stop();

            Reset();

            iIncrement = 0;
            iStateController = 0;
            iJumpStateController = -1;
        }
    }
}
