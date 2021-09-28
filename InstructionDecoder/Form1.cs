using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstructionDecoder
{
    public partial class Form1 : Form
    {

        CPU cpu = new CPU();
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = "";
            string fileContent = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                StreamReader sr = new StreamReader(filePath);
                fileContent = sr.ReadToEnd();  
            }
            string[] values = fileContent.Split('\n');

            foreach(string value in values)
            {
                listBoxInputStream.Items.Add(value.Trim());
            }
        }

        /// <summary>
        /// displays the next line of instructions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender , EventArgs e)
        {
            if (listBoxInputStream.Items.Count - 1 > 0)
            {
                if (listBoxInputStream.SelectedIndex == -1)
                    listBoxInputStream.SelectedIndex = 0;
                else if (listBoxInputStream.SelectedIndex < listBoxInputStream.Items.Count - 1)
                    listBoxInputStream.SelectedIndex++;
                string temp = listBoxInputStream.SelectedItem.ToString();
                int instruction = Convert.ToInt32(temp, 2);
                temp = "";
                textBoxAddrMode.Clear();
                textBoxHex.Clear();
                textBoxInstruction.Clear();
                textBoxProgramCounter.Clear();
                temp = cpu.DecodeInstruction(instruction);
                string[] values = temp.Split('\t');
                if(values.Length >= 1)
                    textBoxProgramCounter.Text = values[0];
                if (values.Length >= 2)
                    textBoxHex.Text = values[1];
                if (values.Length >= 3)
                    textBoxInstruction.Text = values[2];
                if (values.Length >= 4)
                    textBoxRegisters.Text = values[3];
            }
        }

        /// <summary>
        /// displays all the lines of instructions in the text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDecodeAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxInputStream.Items.Count; i++)
            {
                string temp = listBoxInputStream.Items[i].ToString();
                int instruction = Convert.ToInt32(temp,2);

                temp = cpu.DecodeInstruction(instruction);
                string[] values = temp.Split('\t');
                textBoxProgramCounter.Text +=  values[0] + Environment.NewLine;
                textBoxHex.Text +=  values[1]+ Environment.NewLine;
                textBoxInstruction.Text +=  values[2] + Environment.NewLine;
                textBoxRegisters.Text +=  values[3] + Environment.NewLine;
            }
        }
    }
}
