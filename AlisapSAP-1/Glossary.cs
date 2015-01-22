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
    public partial class Glossary : Form
    {
        Dictionary<string, string> glossaryList = new Dictionary<string, string>();
        
        public Glossary()
        {
            InitializeComponent();
           
            glossaryList.Add("Accumulator", "A buffer register that stores immediate answers during a computer  runs. It has two outputs, one directly goes to theadder/subtractor, and the other  is to the W-Bus.");
            glossaryList.Add("Adder", "It is synchronous. This means that its contents can change as  soon as the input word change.When EU is High, these contents appears on the  W BUS.");
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
    }
}
