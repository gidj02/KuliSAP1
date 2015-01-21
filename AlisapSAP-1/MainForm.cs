using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace AlisapSAP_1
{
    public partial class MainForm : Form
    {
        bool isCurrentFile = false;
        string currentFileDirectory=" ";
        string currentFileName=" ";
        bool cancelled = false;
        int prevCount = 16;
        int currCount = 0;

        HashSet<string> reserved = new HashSet<string>();
        HashSet<string> reserved1 = new HashSet<string>();
        HashSet<string> reserved2 = new HashSet<string>();
        String[,] machineCode = new String[16, 3];
        Label[,] labels = new Label[16, 3];
        String binFile;
            
     

        public MainForm()
        {
            InitializeComponent();


            this.Text = "kuliSAP-1";
            reserve();
            
            //Labels 
           

            int m = 0;
            for (int i=0; i < 3; i++) {
                for (int j=0; j < 16; j++)
                {
                    labels[j, i] = new Label();
                    labels[j,i].AutoSize = true;
                    labels[j, i].Size = new System.Drawing.Size(35, 13);
                    labels[j, i].TabIndex = m;
                    labels[j, i].Dock = DockStyle.Fill;
                    labels[j, i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    labels[j, i].Font = new System.Drawing.Font("Source Code Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                    if (i == 0){
                        labels[j, i].Text = Convert.ToString(j, 2).PadLeft(4, '0'); ;
                        machineCode[j, i] = labels[j, i].Text;
           
                    }
                    else if (i == 1){
                        labels[j, i].Text = "1111 1111";
                        machineCode[j, i] = "11111111";
                

                    }
                    else {
                        labels[j, i].Text = "-";
                        machineCode[j, i] = labels[j, i].Text;
              
                    }
                    
                    
                    m++;
                    
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    tableLayoutPanel1.Controls.Add(labels[j, i], i, j);

                }
            }

        }
        
        private void loadViewSAP1FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                //tabPage1.Text = openFileDialog1.FileName;
                tabPage1.Text = openFileDialog1.SafeFileName;
                this.Text = openFileDialog1.FileName + " - AlisapSAP-1";
                currentFileDirectory = openFileDialog1.FileName;
                currentFileName = openFileDialog1.SafeFileName;
                isCurrentFile = true;

                
            }
            catch (IOException) { 
            }
            
        }
       
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                saveAsToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
            }
            else {
                saveAsToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
            }
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcNewOrExit();
            if (cancelled == false)
            {
                System.Windows.Forms.Application.Exit();
            }
            else { 
                cancelled = false;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
            tabPage1.Text = Path.GetFileName(saveFileDialog1.FileName);
            this.Text = Path.GetDirectoryName(saveFileDialog1.FileName) + "\\" + Path.GetFileName(saveFileDialog1.FileName) + " - AlisapSAP-1";
            currentFileDirectory = Path.GetDirectoryName(saveFileDialog1.FileName) + "\\" + Path.GetFileName(saveFileDialog1.FileName);
            currentFileName = Path.GetFileName(saveFileDialog1.FileName);
            isCurrentFile = true;

        }
      
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isCurrentFile==false)
            {
                saveFileDialog1.ShowDialog();
                
            }
            else 
            {
                File.WriteAllText(currentFileDirectory, richTextBox1.Text);  
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            funcNewOrExit();
        }

        private void funcNewOrExit() 
        {
            if (isCurrentFile == true)
            {

                if (richTextBox1.Text != File.ReadAllText(currentFileDirectory))
                {

                    DialogResult result = MessageBox.Show("Do you want to save your current work ?", "Warning",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                    }
                    else if (result == DialogResult.No)
                    {
                        File.WriteAllText(currentFileDirectory, richTextBox1.Text);
                        tabPage1.Text = "new 1";
                        isCurrentFile = false;
                        currentFileDirectory = "";
                        currentFileName = "";
                        richTextBox1.Text = "";
                        this.Text = "AlisapSAP-1";

                    }
                    else { cancelled = true; }

                }
                else {

                    tabPage1.Text = "new 1";
                    isCurrentFile = false;
                    currentFileDirectory = "";
                    currentFileName = "";
                    richTextBox1.Text = "";
                    this.Text = "AlisapSAP-1";
                }
     
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(richTextBox1.Text))
                {
                    DialogResult result = MessageBox.Show("Do you want to save your current work ?", "Warning",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        saveFileDialog1.ShowDialog();
                        richTextBox1.Text = "";
                    }
                    else if (result == DialogResult.No)
                    {
                        richTextBox1.Text = "";
                    }
                    else {
                        cancelled = true;
                    }

                }
            }
        }
        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
     
                File.WriteAllText(saveFileDialog2.FileName, binFile);
                TabPage binPage = new TabPage(saveFileDialog2.FileName);
                tabControl2.TabPages.Add(binPage);
                RichTextBox binRichTextbox = new RichTextBox();
                binRichTextbox.Text = File.ReadAllText(saveFileDialog2.FileName);
                binRichTextbox.Dock = DockStyle.Fill;
                binPage.Controls.Add(binRichTextbox);
                tabControl2.SelectedTab = binPage;
          
        }

        private void assembleCreateBinFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isCurrentFile == true)
            {

                if (listBox1.Items.Count == 0)
                {
                    //a.assemble(File.ReadAllText(currentFileDirectory));  
                    //File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);              
                   
                    Assembler a = new Assembler();
                    binFile = a.assemble(machineCode);
                    MessageBox.Show(binFile);
                    //File.WriteAllText(currentFileDirectory, binFile);
                    saveFileDialog2.InitialDirectory = currentFileDirectory;
                    saveFileDialog2.FileName = currentFileName.Remove(currentFileName.Length - 5);
                    saveFileDialog2.ShowDialog(); 
                    
                }
                else {
                    MessageBox.Show( listBox1.Items.Count+" Error/s found", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);        
                }

            }
            else
            {
                MessageBox.Show("Load/Create your SAP-1 First !", "",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }
        public void reserve() {

            for (int i = 0; i <= 255; i++)
            {
                string hexValue;
                if (i <= 15)
                {
                    hexValue = i.ToString("X") + "H";
                    hexValue = "0" + i.ToString("X") + "H";
                }
                else
                {
                    hexValue = i.ToString("X") + "H";
                }
                reserved2.Add(hexValue);
            }
            for (int i = 0; i <= 15; i++) {
                string hexValue = i.ToString("X") + "H";
                hexValue = "0" + i.ToString("X") + "H";
                reserved1.Add(hexValue);
            
            }           

            reserved.Add("ORG");
            reserved.Add("LDA");
            reserved.Add("ADD");
            reserved.Add("SUB");
            reserved.Add("OUT");
            reserved.Add("HLT");
            reserved.Add(",");

        }

        private void openSAP1EmulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emulator em = new Emulator(machineCode);
            em.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateAssembleGUI();
        }
        private void updateAssembleGUI() {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (i == 0)
                    {
                        labels[j, i].Text = Convert.ToString(j, 2).PadLeft(4, '0'); ;
                        //machineCode[j, i] = labels[j, i].Text;
                    }
                    else if (i == 1)
                    {
                        labels[j, i].Text = "1111 1111";
                        //machineCode[j, i] = labels[j, i].Text;

                    }
                    else
                    {
                        labels[j, i].Text = "-";
                        // machineCode[j, i] = labels[j, i].Text;
                    }
                }

            }

            for (int i = 0; i <= 15; i++)
            {
                if (machineCode[i, 2] != "-")
                {
                    labels[i, 2].Text = machineCode[i, 2];
                    labels[i, 1].Text = machineCode[i, 1];
                    labels[i, 1].Text = labels[i, 1].Text.Insert(4, " ");
                }


            }
        
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 16; j++)
                {

                    if (i == 0)
                    {
                        machineCode[j, i] = Convert.ToString(j, 2).PadLeft(4, '0');
                    }
                    else if (i == 1)
                    {
                        machineCode[j, i] = "11111111";
                    }
                    else
                    {
                        machineCode[j, i] = "-";
                    }
                }
            }
            listBox1.Text = "";
            int line = 1 + richTextBox1.GetLineFromCharIndex(richTextBox1.GetFirstCharIndexOfCurrentLine());
            int column = 1 + richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine();
            label2.Text = "Line: " + line.ToString();
            label3.Text = "Column: " + column.ToString();
            label1.Text = "Length: " + richTextBox1.TextLength.ToString();

            String[,] words = new String[100, 100];
            String holder = "";
            int wordcount = 0;
            int lineword = 0;
            int columnword = 0;


            //Lexical Analyzer
            for (int i = 0; i <= richTextBox1.TextLength; i++)
            {
                columnword++;
                if (i == richTextBox1.TextLength)
                {
                    if (holder != "")
                    {
                        words[wordcount, 0] = holder;
                        //Errors.Add(words[wordcount, 0]);
                    }
                    break;
                }
                if (richTextBox1.Text[i] == ' ' || richTextBox1.Text[i] == '\t' || richTextBox1.Text[i] == '\n')
                {
                    if (richTextBox1.Text[i] == '\n')
                    {
                        columnword = 0;
                    }

                    if (holder != "")
                    {
                        words[wordcount, 0] = holder;
                        //Errors.Add(words[wordcount, 0]);
                        //Errors.Add(words[wordcount, 0] + "   " + words[wordcount, 1] + "   " + words[wordcount, 2]);
                        holder = "";
                        wordcount++;
                        if (i != 0 && holder.Length != 1)
                        {
                            lineword = 1 + richTextBox1.GetLineFromCharIndex(i + 1);
                            words[wordcount, 1] = lineword.ToString();
                            words[wordcount, 2] = columnword.ToString();
                        }
                    }

                }
                else if (richTextBox1.Text[i] == ',')
                {
                    if (holder != "")
                    {
                        words[wordcount, 0] = holder;
                        //Errors.Add(words[wordcount, 0]);
                        wordcount++;
                    }

                    words[wordcount, 0] = ",";
                    //Errors.Add(words[wordcount, 0]);
                    lineword = 1 + richTextBox1.GetLineFromCharIndex(i);
                    words[wordcount, 1] = lineword.ToString();
                    words[wordcount, 2] = columnword.ToString();
                    //Errors.Add(words[wordcount, 0] + "   " + words[wordcount, 1] + "   " + words[wordcount, 2]);
                    holder = "";
                    wordcount++;

                }
                else
                {
                    holder = holder + richTextBox1.Text[i].ToString();
                    if (holder.Length == 1)
                    {
                        lineword = 1 + richTextBox1.GetLineFromCharIndex(i);
                        words[wordcount, 1] = lineword.ToString();
                        words[wordcount, 2] = columnword.ToString();

                    }

                    if (i == 0)
                    {
                        lineword = 1;

                        words[wordcount, 1] = lineword.ToString();
                        words[wordcount, 2] = columnword.ToString();

                        // Errors.Add(words[wordcount, 0] + "   " + words[wordcount, 1] + "   " + words[wordcount, 2]);
                    }
                }
            }

            CheckSyntaxLexicalError ce = new CheckSyntaxLexicalError();
            CheckAssemblerError ca = new CheckAssemblerError();

            //String[,] assembler = new String[16,3];

            List<String> assemblerError = new List<String>();
            List<String> Errors = new List<String>();

            if (!String.IsNullOrEmpty(richTextBox1.Text) && !String.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                Errors = ce.checkError(reserved, reserved1, reserved2, words, wordcount);
                assemblerError = ca.checkError(reserved, reserved1, reserved2, words, wordcount, machineCode);


            }
            /*
            for (int i = 0; i <= 15; i++)
            {
                if (machineCode[i, 2] != "-")
                {
                    MessageBox.Show("wenks");
                    labels[i, 2].Text = machineCode[i, 2];
                    labels[i, 1].Text = machineCode[i, 1];
                    labels[i, 1].Text = labels[i, 1].Text.Insert(4, " ");
                }


            }*/
            for (int i = 0; i <= 15; i++) {
                if (machineCode[i, 2] == "-") {
                    currCount++;
                    //MessageBox.Show("wew");
                
                }
            }

            if (prevCount != currCount)
            {
                updateAssembleGUI();
                prevCount = currCount;
                currCount = 0;
                
            }
            else {
                currCount = 0;
                
            }

            Errors.AddRange(assemblerError);
            listBox1.DataSource = Errors;
        }

        private void richTextBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            int line = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
            int column = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(line);
            //MessageBox.Show(column.ToString());
            label2.Text = "Line: " + (line+1).ToString();
            label3.Text = "Column: " + (column+1).ToString();
        }
    
    }
}
