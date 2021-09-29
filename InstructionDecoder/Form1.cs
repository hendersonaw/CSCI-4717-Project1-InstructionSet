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

        /// <summary>
        /// Loads the register text boxes
        /// </summary>
        private void loadRegisters()
        {
            textBoxx0.Text = cpu.Registers[0].Value.ToString("X");
            textBoxx1.Text = cpu.Registers[1].Value.ToString("X");
            textBoxx2.Text = cpu.Registers[2].Value.ToString("X");
            textBoxx3.Text = cpu.Registers[3].Value.ToString("X");
            textBoxx4.Text = cpu.Registers[4].Value.ToString("X");
            textBoxx5.Text = cpu.Registers[5].Value.ToString("X");
            textBoxx6.Text = cpu.Registers[6].Value.ToString("X");
            textBoxx7.Text = cpu.Registers[7].Value.ToString("X");
            textBoxx8.Text = cpu.Registers[8].Value.ToString("X");
            textBoxx9.Text = cpu.Registers[9].Value.ToString("X");
            textBoxx10.Text = cpu.Registers[10].Value.ToString("X");
            textBoxx11.Text = cpu.Registers[11].Value.ToString("X");
            textBoxx12.Text = cpu.Registers[12].Value.ToString("X");
            textBoxx13.Text = cpu.Registers[13].Value.ToString("X");
            textBoxx14.Text = cpu.Registers[14].Value.ToString("X");
            textBoxx15.Text = cpu.Registers[15].Value.ToString("X");
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
            }
                
        }

        /// <summary>
        /// Displays decode instructions when index has changed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxInputStream_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool loadImediate = false;
            string temp = listBoxInputStream.SelectedItem.ToString();
            int instruction = Convert.ToInt32(temp, 2);
            temp = "";
            textBoxAddrMode.Clear();
            textBoxHex.Clear();
            textBoxInstruction.Clear();
            textBoxProgramCounter.Clear();
            textBoxRegisters.Clear();
            textBoxAddrMode.Clear();
            int programCounter = listBoxInputStream.SelectedIndex * cpu.GetInstructionSize();
            cpu.Registers[13].Value = programCounter;
            loadRegisters();
            temp = cpu.DecodeInstruction(instruction, ref loadImediate);
            string[] values = temp.Split('\t');
            if (loadImediate)
            {
                listBoxInputStream.SelectedIndex++;
                temp = listBoxInputStream.SelectedItem.ToString();
                instruction = Convert.ToInt32(temp, 2);
                temp = cpu.DecodeInstruction(instruction, ref loadImediate);
            }
            else
                temp = "";

            if (values.Length >= 1)
                textBoxProgramCounter.Text = programCounter.ToString("0000");
            if (values.Length >= 2)
                textBoxHex.Text = values[1];
            if (values.Length >= 3)
                textBoxInstruction.Text = values[2];
            if (values.Length >= 4)
                textBoxRegisters.Text = values[3] + temp;
            if (values.Length >= 5)
                textBoxAddrMode.Text = values[4];
        }

        /// <summary>
        /// Clears all decode information and input file ListBox. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearInput_Click(object sender, EventArgs e)
        {
            listBoxInputStream.Items.Clear();
            textBoxAddrMode.Clear();
            textBoxHex.Clear();
            textBoxInstruction.Clear();
            textBoxProgramCounter.Clear();
            textBoxRegisters.Clear();
            textBoxAddrMode.Clear();
        }

        /// <summary>
        /// displays all the lines of instructions in the text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDecodeAll_Click(object sender, EventArgs e)
        {
            bool loadImediate = false;
            textBoxAddrMode.Clear();
            textBoxHex.Clear();
            textBoxInstruction.Clear();
            textBoxProgramCounter.Clear();
            textBoxRegisters.Clear();
            textBoxAddrMode.Clear();
            for (int i = 0; i < listBoxInputStream.Items.Count; i++)
            {
                string temp = listBoxInputStream.Items[i].ToString();
                int instruction = Convert.ToInt32(temp, 2);
                int programCounter = i * cpu.GetInstructionSize();

                temp = cpu.DecodeInstruction(instruction, ref loadImediate);
                string[] values = temp.Split('\t');
                textBoxProgramCounter.Text += programCounter.ToString("0000") + Environment.NewLine;
                if (loadImediate)
                {
                    i++;
                    temp = listBoxInputStream.Items[i].ToString();
                    instruction = Convert.ToInt32(temp, 2);
                    temp = cpu.DecodeInstruction(instruction, ref loadImediate);
                }
                else
                    temp = "";

                textBoxHex.Text += values[1] + Environment.NewLine;
                textBoxInstruction.Text += values[2] + Environment.NewLine;
                textBoxRegisters.Text += values[3] + temp + Environment.NewLine;
            }

        }
    }
}
