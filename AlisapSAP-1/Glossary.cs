using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace kuliSAP1
{
    public partial class Glossary : Form
    {
        Dictionary<string, string> glossaryList = new Dictionary<string, string>();
        
        public Glossary()
        {
            InitializeComponent();
            addGlossaryItem();

        }

        private void Glossary_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (glossaryList.ContainsKey(textBox1.Text))
            {
                richTextBox1.Text = glossaryList[textBox1.Text];
              
            }
        }
        private void addGlossaryItem() {
            glossaryList.Add("Accumulator", "A buffer register that stores immediate answers during a computer runs. It has two outputs, one directly goes to theadder/subtractor, and the other is to the W-Bus.");
            glossaryList.Add("Adder", "It is synchronous. This means that its contents can change as soon as the input word change.When EU is High, these contents appears on the W BUS.");
            glossaryList.Add("Subtractor", "It is synchronous. This means that its contents can change as soon as the input word change.When EU is High, these contents appears on the W BUS.");
            glossaryList.Add("Address State(T1)", "One of the three states in Fetch cycle where the address is sent to the memory.");
            glossaryList.Add("ADD", "A mnemonics where it add RAM data to accumulator. It has OP code of  0001.");
            glossaryList.Add("Assembly Code", "A code containing 3 or 4 mnemonics with a corresponding OP codes.Specifically, these are the LDA, ADD, SUB , OUT and HLT ");
            glossaryList.Add("Assembler", "It assemble the file written as Assembly code and will save it in a file extension of .bin.It transforms the Assembly language to machine language");
            glossaryList.Add("Assembly Source File", "It contains the written Assembly code with a file extension of .sap1.");
            glossaryList.Add("B Register", "It is another buffer register and is used in arithmetic operations.It is used in Arithmetic operation.");
            glossaryList.Add("Bin File", "It is the file created by the assembler with an file extension of .bin.");
            glossaryList.Add("Controller/Sequencer ", " This resets the program counter to 0000 and wipes out the last instruction in the Instruction Register.");
            glossaryList.Add("Control Unit", "It composed of Program Counter, Input and MAR(Memory  Address Register), RAM(Random Access Memory), Instruction Register and Controller/Sequencer.");
            glossaryList.Add("Emulator", "It is capable of loading any . bin file which is created by the Assembler. It can be run via Jog Mode or Continuous Mode. It shows the content of each registers of the Instruction Cycle(the Fetching and Execution Cycle) and also shows the content of the 16x8 RAM. Also , in this mode, the result is shown through a Binary display that is represented by animated 8-bit LED");
            glossaryList.Add("Execution Cycle(T4-T6)", "It is a cycle where the register transfers and depends on the particular instruction being executed.");
            glossaryList.Add("Fetch cycle", "It is the first part of the instruction cycle. During the fetch cycle, the address is sent to the memory, the program counter is incremented, and the instruction is transferred from the memory to the instruction register.");
            glossaryList.Add("HLT", "It stops the processing. Its OP code is 1111.");
            glossaryList.Add("Increment State (T2)", " One of the states in Fetch Cycle where the program counter is incremented.");
            glossaryList.Add("Instruction Register", "It is setup for loading the next positive edge clock.Its  contents are split into two nibbles- the upper nibble and lower nibble.");
            glossaryList.Add("Jump Mode", "It is also called as Jog Mode, one of the mode in the emulator where it shows every process noncontinuous  manner.");
            glossaryList.Add("LDA", "It stands for ‘Load RAM’.It loads RAM data into accumulator. Its OP code is 0000.");
            glossaryList.Add("Lower Nibble", "It is one of content of Instruction Register.It is a three-state output that is read onto the WBus when needed.");
            glossaryList.Add("Memory Address Register (MAR)", "It a is part of the SAP-1 memory. During a computer runs, the address in the Program Counter is latched into it and a  bit later it applies this 4-bit address to the RAM, where a read operation is performed.");
            glossaryList.Add("Memory State (T3)", "One of the states in Fetch cycle where the instruction is transferred from the memory to the instruction register.");
            glossaryList.Add("ORG", "It is the address command which contains the RAM address followed by the data value. It is an internal command that not supported by SAP-1 Assembly Instruction Set");
            glossaryList.Add("OUT", "It loads the accumulator data into output register.Its OP code is 1110.");
            glossaryList.Add("Output Register", "It is used when transferring the answer to the outside world  after the computer run such that the accumulator contains the answer to the  problem being solved.");
            glossaryList.Add("Program Counter", "It  is a part of the Control Unit counts from 0000-1111. Its job is to send to the memory the address of the next instruction to be fetched  and executed.");
            glossaryList.Add("RAM", "It stands for ‘Random Access Memory’.It is a 16 x 8 static TTL RAM. The RAM can be programmed by means of the address and data switch registers.This allows you to store program and data in the memory before a computer  runs.");
            glossaryList.Add("Upper Nibble", "It is one of content of Instruction Register. It is the two-state  output that goes directly to the block labelled “Controller/Sequencer”.");
            glossaryList.Add("SUB", "Subtract RAM data from accumulator. Its OP code is 0010.");
            glossaryList.Add("Synchronous Mode", "It is also called as Continuous Mode, one of the mode in the emulator where it shows every process continuously.");


          
        }

        private void Glossary_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(this.ClientRectangle,
               Color.White, Color.SkyBlue, LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

       
    }
}
