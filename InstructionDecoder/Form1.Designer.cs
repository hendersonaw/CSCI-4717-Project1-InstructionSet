
namespace InstructionDecoder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelProgramCounter = new System.Windows.Forms.Label();
            this.labelHex = new System.Windows.Forms.Label();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.labelRegisters = new System.Windows.Forms.Label();
            this.labelAddrMode = new System.Windows.Forms.Label();
            this.textBoxProgramCounter = new System.Windows.Forms.TextBox();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.textBoxInstruction = new System.Windows.Forms.TextBox();
            this.textBoxRegisters = new System.Windows.Forms.TextBox();
            this.textBoxAddrMode = new System.Windows.Forms.TextBox();
            this.labelx0 = new System.Windows.Forms.Label();
            this.labelx7 = new System.Windows.Forms.Label();
            this.labelx6 = new System.Windows.Forms.Label();
            this.labelx5 = new System.Windows.Forms.Label();
            this.labelx4 = new System.Windows.Forms.Label();
            this.labelx3 = new System.Windows.Forms.Label();
            this.labelx2 = new System.Windows.Forms.Label();
            this.labelx1 = new System.Windows.Forms.Label();
            this.labelx9 = new System.Windows.Forms.Label();
            this.labelx10 = new System.Windows.Forms.Label();
            this.labelx11 = new System.Windows.Forms.Label();
            this.labelx12 = new System.Windows.Forms.Label();
            this.labelx13 = new System.Windows.Forms.Label();
            this.labelx14 = new System.Windows.Forms.Label();
            this.labelx15 = new System.Windows.Forms.Label();
            this.labelx8 = new System.Windows.Forms.Label();
            this.textBoxx0 = new System.Windows.Forms.TextBox();
            this.textBoxx1 = new System.Windows.Forms.TextBox();
            this.textBoxx2 = new System.Windows.Forms.TextBox();
            this.textBoxx3 = new System.Windows.Forms.TextBox();
            this.textBoxx4 = new System.Windows.Forms.TextBox();
            this.textBoxx5 = new System.Windows.Forms.TextBox();
            this.textBoxx6 = new System.Windows.Forms.TextBox();
            this.textBoxx7 = new System.Windows.Forms.TextBox();
            this.textBoxx15 = new System.Windows.Forms.TextBox();
            this.textBoxx14 = new System.Windows.Forms.TextBox();
            this.textBoxx13 = new System.Windows.Forms.TextBox();
            this.textBoxx12 = new System.Windows.Forms.TextBox();
            this.textBoxx11 = new System.Windows.Forms.TextBox();
            this.textBoxx10 = new System.Windows.Forms.TextBox();
            this.textBoxx9 = new System.Windows.Forms.TextBox();
            this.textBoxx8 = new System.Windows.Forms.TextBox();
            this.buttonDecodeAll = new System.Windows.Forms.Button();
            this.buttonDecodeNext = new System.Windows.Forms.Button();
            this.buttonInputFile = new System.Windows.Forms.Button();
            this.listBoxInputStream = new System.Windows.Forms.ListBox();
            this.buttonClearInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProgramCounter
            // 
            this.labelProgramCounter.AutoSize = true;
            this.labelProgramCounter.Location = new System.Drawing.Point(144, 728);
            this.labelProgramCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProgramCounter.Name = "labelProgramCounter";
            this.labelProgramCounter.Size = new System.Drawing.Size(140, 82);
            this.labelProgramCounter.TabIndex = 0;
            this.labelProgramCounter.Text = "Program \r\nCounter";
            this.labelProgramCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHex
            // 
            this.labelHex.AutoSize = true;
            this.labelHex.Location = new System.Drawing.Point(340, 769);
            this.labelHex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHex.Name = "labelHex";
            this.labelHex.Size = new System.Drawing.Size(69, 41);
            this.labelHex.TabIndex = 1;
            this.labelHex.Text = "Hex";
            this.labelHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(525, 769);
            this.labelInstruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(159, 41);
            this.labelInstruction.TabIndex = 2;
            this.labelInstruction.Text = "Instruction";
            this.labelInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegisters
            // 
            this.labelRegisters.AutoSize = true;
            this.labelRegisters.Location = new System.Drawing.Point(799, 728);
            this.labelRegisters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegisters.Name = "labelRegisters";
            this.labelRegisters.Size = new System.Drawing.Size(238, 82);
            this.labelRegisters.TabIndex = 3;
            this.labelRegisters.Text = "Registers\r\n(Dest, Src1, Src2)";
            this.labelRegisters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAddrMode
            // 
            this.labelAddrMode.AutoSize = true;
            this.labelAddrMode.Location = new System.Drawing.Point(1179, 728);
            this.labelAddrMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddrMode.Name = "labelAddrMode";
            this.labelAddrMode.Size = new System.Drawing.Size(167, 82);
            this.labelAddrMode.TabIndex = 4;
            this.labelAddrMode.Text = "Addressing\r\nMode\r\n";
            this.labelAddrMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxProgramCounter
            // 
            this.textBoxProgramCounter.Location = new System.Drawing.Point(144, 830);
            this.textBoxProgramCounter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProgramCounter.Multiline = true;
            this.textBoxProgramCounter.Name = "textBoxProgramCounter";
            this.textBoxProgramCounter.ReadOnly = true;
            this.textBoxProgramCounter.Size = new System.Drawing.Size(140, 248);
            this.textBoxProgramCounter.TabIndex = 5;
            // 
            // textBoxHex
            // 
            this.textBoxHex.Location = new System.Drawing.Point(323, 830);
            this.textBoxHex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxHex.Multiline = true;
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.ReadOnly = true;
            this.textBoxHex.Size = new System.Drawing.Size(132, 248);
            this.textBoxHex.TabIndex = 5;
            // 
            // textBoxInstruction
            // 
            this.textBoxInstruction.Location = new System.Drawing.Point(493, 830);
            this.textBoxInstruction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInstruction.Multiline = true;
            this.textBoxInstruction.Name = "textBoxInstruction";
            this.textBoxInstruction.ReadOnly = true;
            this.textBoxInstruction.Size = new System.Drawing.Size(210, 248);
            this.textBoxInstruction.TabIndex = 5;
            // 
            // textBoxRegisters
            // 
            this.textBoxRegisters.Location = new System.Drawing.Point(740, 830);
            this.textBoxRegisters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRegisters.Multiline = true;
            this.textBoxRegisters.Name = "textBoxRegisters";
            this.textBoxRegisters.ReadOnly = true;
            this.textBoxRegisters.Size = new System.Drawing.Size(355, 248);
            this.textBoxRegisters.TabIndex = 5;
            // 
            // textBoxAddrMode
            // 
            this.textBoxAddrMode.Location = new System.Drawing.Point(1135, 830);
            this.textBoxAddrMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddrMode.Multiline = true;
            this.textBoxAddrMode.Name = "textBoxAddrMode";
            this.textBoxAddrMode.ReadOnly = true;
            this.textBoxAddrMode.Size = new System.Drawing.Size(257, 248);
            this.textBoxAddrMode.TabIndex = 5;
            // 
            // labelx0
            // 
            this.labelx0.AutoSize = true;
            this.labelx0.Location = new System.Drawing.Point(988, 82);
            this.labelx0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx0.Name = "labelx0";
            this.labelx0.Size = new System.Drawing.Size(48, 41);
            this.labelx0.TabIndex = 6;
            this.labelx0.Text = "x0";
            // 
            // labelx7
            // 
            this.labelx7.AutoSize = true;
            this.labelx7.Location = new System.Drawing.Point(988, 445);
            this.labelx7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx7.Name = "labelx7";
            this.labelx7.Size = new System.Drawing.Size(48, 41);
            this.labelx7.TabIndex = 6;
            this.labelx7.Text = "x7";
            // 
            // labelx6
            // 
            this.labelx6.AutoSize = true;
            this.labelx6.Location = new System.Drawing.Point(988, 396);
            this.labelx6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx6.Name = "labelx6";
            this.labelx6.Size = new System.Drawing.Size(48, 41);
            this.labelx6.TabIndex = 6;
            this.labelx6.Text = "x6";
            // 
            // labelx5
            // 
            this.labelx5.AutoSize = true;
            this.labelx5.Location = new System.Drawing.Point(988, 344);
            this.labelx5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx5.Name = "labelx5";
            this.labelx5.Size = new System.Drawing.Size(48, 41);
            this.labelx5.TabIndex = 6;
            this.labelx5.Text = "x5";
            // 
            // labelx4
            // 
            this.labelx4.AutoSize = true;
            this.labelx4.Location = new System.Drawing.Point(988, 293);
            this.labelx4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx4.Name = "labelx4";
            this.labelx4.Size = new System.Drawing.Size(48, 41);
            this.labelx4.TabIndex = 6;
            this.labelx4.Text = "x4";
            // 
            // labelx3
            // 
            this.labelx3.AutoSize = true;
            this.labelx3.Location = new System.Drawing.Point(988, 240);
            this.labelx3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx3.Name = "labelx3";
            this.labelx3.Size = new System.Drawing.Size(48, 41);
            this.labelx3.TabIndex = 6;
            this.labelx3.Text = "x3";
            this.labelx3.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelx2
            // 
            this.labelx2.AutoSize = true;
            this.labelx2.Location = new System.Drawing.Point(988, 184);
            this.labelx2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx2.Name = "labelx2";
            this.labelx2.Size = new System.Drawing.Size(48, 41);
            this.labelx2.TabIndex = 6;
            this.labelx2.Text = "x2";
            // 
            // labelx1
            // 
            this.labelx1.AutoSize = true;
            this.labelx1.Location = new System.Drawing.Point(988, 131);
            this.labelx1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx1.Name = "labelx1";
            this.labelx1.Size = new System.Drawing.Size(48, 41);
            this.labelx1.TabIndex = 6;
            this.labelx1.Text = "x1";
            // 
            // labelx9
            // 
            this.labelx9.AutoSize = true;
            this.labelx9.Location = new System.Drawing.Point(1220, 131);
            this.labelx9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx9.Name = "labelx9";
            this.labelx9.Size = new System.Drawing.Size(48, 41);
            this.labelx9.TabIndex = 6;
            this.labelx9.Text = "x9";
            // 
            // labelx10
            // 
            this.labelx10.AutoSize = true;
            this.labelx10.Location = new System.Drawing.Point(1220, 184);
            this.labelx10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx10.Name = "labelx10";
            this.labelx10.Size = new System.Drawing.Size(64, 41);
            this.labelx10.TabIndex = 6;
            this.labelx10.Text = "x10";
            // 
            // labelx11
            // 
            this.labelx11.AutoSize = true;
            this.labelx11.Location = new System.Drawing.Point(1220, 240);
            this.labelx11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx11.Name = "labelx11";
            this.labelx11.Size = new System.Drawing.Size(64, 41);
            this.labelx11.TabIndex = 6;
            this.labelx11.Text = "x11";
            this.labelx11.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelx12
            // 
            this.labelx12.AutoSize = true;
            this.labelx12.Location = new System.Drawing.Point(1220, 293);
            this.labelx12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx12.Name = "labelx12";
            this.labelx12.Size = new System.Drawing.Size(64, 41);
            this.labelx12.TabIndex = 6;
            this.labelx12.Text = "x12";
            // 
            // labelx13
            // 
            this.labelx13.AutoSize = true;
            this.labelx13.Location = new System.Drawing.Point(1220, 344);
            this.labelx13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx13.Name = "labelx13";
            this.labelx13.Size = new System.Drawing.Size(64, 41);
            this.labelx13.TabIndex = 6;
            this.labelx13.Text = "x13";
            // 
            // labelx14
            // 
            this.labelx14.AutoSize = true;
            this.labelx14.Location = new System.Drawing.Point(1220, 396);
            this.labelx14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx14.Name = "labelx14";
            this.labelx14.Size = new System.Drawing.Size(64, 41);
            this.labelx14.TabIndex = 6;
            this.labelx14.Text = "x14";
            // 
            // labelx15
            // 
            this.labelx15.AutoSize = true;
            this.labelx15.Location = new System.Drawing.Point(1220, 445);
            this.labelx15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx15.Name = "labelx15";
            this.labelx15.Size = new System.Drawing.Size(64, 41);
            this.labelx15.TabIndex = 6;
            this.labelx15.Text = "x15";
            // 
            // labelx8
            // 
            this.labelx8.AutoSize = true;
            this.labelx8.Location = new System.Drawing.Point(1220, 84);
            this.labelx8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelx8.Name = "labelx8";
            this.labelx8.Size = new System.Drawing.Size(48, 41);
            this.labelx8.TabIndex = 6;
            this.labelx8.Text = "x8";
            // 
            // textBoxx0
            // 
            this.textBoxx0.Location = new System.Drawing.Point(1054, 82);
            this.textBoxx0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx0.Name = "textBoxx0";
            this.textBoxx0.Size = new System.Drawing.Size(134, 47);
            this.textBoxx0.TabIndex = 7;
            // 
            // textBoxx1
            // 
            this.textBoxx1.Location = new System.Drawing.Point(1054, 135);
            this.textBoxx1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx1.Name = "textBoxx1";
            this.textBoxx1.Size = new System.Drawing.Size(134, 47);
            this.textBoxx1.TabIndex = 7;
            // 
            // textBoxx2
            // 
            this.textBoxx2.Location = new System.Drawing.Point(1054, 189);
            this.textBoxx2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx2.Name = "textBoxx2";
            this.textBoxx2.Size = new System.Drawing.Size(134, 47);
            this.textBoxx2.TabIndex = 7;
            // 
            // textBoxx3
            // 
            this.textBoxx3.Location = new System.Drawing.Point(1054, 242);
            this.textBoxx3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx3.Name = "textBoxx3";
            this.textBoxx3.Size = new System.Drawing.Size(134, 47);
            this.textBoxx3.TabIndex = 7;
            // 
            // textBoxx4
            // 
            this.textBoxx4.Location = new System.Drawing.Point(1054, 293);
            this.textBoxx4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx4.Name = "textBoxx4";
            this.textBoxx4.Size = new System.Drawing.Size(134, 47);
            this.textBoxx4.TabIndex = 7;
            // 
            // textBoxx5
            // 
            this.textBoxx5.Location = new System.Drawing.Point(1054, 346);
            this.textBoxx5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx5.Name = "textBoxx5";
            this.textBoxx5.Size = new System.Drawing.Size(134, 47);
            this.textBoxx5.TabIndex = 7;
            // 
            // textBoxx6
            // 
            this.textBoxx6.Location = new System.Drawing.Point(1054, 400);
            this.textBoxx6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx6.Name = "textBoxx6";
            this.textBoxx6.Size = new System.Drawing.Size(134, 47);
            this.textBoxx6.TabIndex = 7;
            // 
            // textBoxx7
            // 
            this.textBoxx7.Location = new System.Drawing.Point(1054, 453);
            this.textBoxx7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx7.Name = "textBoxx7";
            this.textBoxx7.Size = new System.Drawing.Size(134, 47);
            this.textBoxx7.TabIndex = 7;
            // 
            // textBoxx15
            // 
            this.textBoxx15.Location = new System.Drawing.Point(1294, 453);
            this.textBoxx15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx15.Name = "textBoxx15";
            this.textBoxx15.Size = new System.Drawing.Size(134, 47);
            this.textBoxx15.TabIndex = 7;
            // 
            // textBoxx14
            // 
            this.textBoxx14.Location = new System.Drawing.Point(1294, 400);
            this.textBoxx14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx14.Name = "textBoxx14";
            this.textBoxx14.Size = new System.Drawing.Size(134, 47);
            this.textBoxx14.TabIndex = 7;
            // 
            // textBoxx13
            // 
            this.textBoxx13.Location = new System.Drawing.Point(1294, 346);
            this.textBoxx13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx13.Name = "textBoxx13";
            this.textBoxx13.Size = new System.Drawing.Size(134, 47);
            this.textBoxx13.TabIndex = 7;
            // 
            // textBoxx12
            // 
            this.textBoxx12.Location = new System.Drawing.Point(1294, 293);
            this.textBoxx12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx12.Name = "textBoxx12";
            this.textBoxx12.Size = new System.Drawing.Size(134, 47);
            this.textBoxx12.TabIndex = 7;
            // 
            // textBoxx11
            // 
            this.textBoxx11.Location = new System.Drawing.Point(1294, 242);
            this.textBoxx11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx11.Name = "textBoxx11";
            this.textBoxx11.Size = new System.Drawing.Size(134, 47);
            this.textBoxx11.TabIndex = 7;
            // 
            // textBoxx10
            // 
            this.textBoxx10.Location = new System.Drawing.Point(1294, 189);
            this.textBoxx10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx10.Name = "textBoxx10";
            this.textBoxx10.Size = new System.Drawing.Size(134, 47);
            this.textBoxx10.TabIndex = 7;
            // 
            // textBoxx9
            // 
            this.textBoxx9.Location = new System.Drawing.Point(1294, 135);
            this.textBoxx9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx9.Name = "textBoxx9";
            this.textBoxx9.Size = new System.Drawing.Size(134, 47);
            this.textBoxx9.TabIndex = 7;
            // 
            // textBoxx8
            // 
            this.textBoxx8.Location = new System.Drawing.Point(1294, 82);
            this.textBoxx8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxx8.Name = "textBoxx8";
            this.textBoxx8.Size = new System.Drawing.Size(134, 47);
            this.textBoxx8.TabIndex = 7;
            // 
            // buttonDecodeAll
            // 
            this.buttonDecodeAll.Location = new System.Drawing.Point(357, 564);
            this.buttonDecodeAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDecodeAll.Name = "buttonDecodeAll";
            this.buttonDecodeAll.Size = new System.Drawing.Size(234, 57);
            this.buttonDecodeAll.TabIndex = 9;
            this.buttonDecodeAll.Text = "Decode All";
            this.buttonDecodeAll.UseVisualStyleBackColor = true;
            this.buttonDecodeAll.Click += new System.EventHandler(this.buttonDecodeAll_Click);
            // 
            // buttonDecodeNext
            // 
            this.buttonDecodeNext.Location = new System.Drawing.Point(654, 564);
            this.buttonDecodeNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDecodeNext.Name = "buttonDecodeNext";
            this.buttonDecodeNext.Size = new System.Drawing.Size(234, 57);
            this.buttonDecodeNext.TabIndex = 9;
            this.buttonDecodeNext.Text = "Decode Next";
            this.buttonDecodeNext.UseVisualStyleBackColor = true;
            this.buttonDecodeNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonInputFile
            // 
            this.buttonInputFile.Location = new System.Drawing.Point(60, 564);
            this.buttonInputFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInputFile.Name = "buttonInputFile";
            this.buttonInputFile.Size = new System.Drawing.Size(234, 57);
            this.buttonInputFile.TabIndex = 9;
            this.buttonInputFile.Text = "Input File";
            this.buttonInputFile.UseVisualStyleBackColor = true;
            this.buttonInputFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxInputStream
            // 
            this.listBoxInputStream.FormattingEnabled = true;
            this.listBoxInputStream.ItemHeight = 41;
            this.listBoxInputStream.Location = new System.Drawing.Point(60, 27);
            this.listBoxInputStream.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxInputStream.Name = "listBoxInputStream";
            this.listBoxInputStream.Size = new System.Drawing.Size(877, 496);
            this.listBoxInputStream.TabIndex = 10;
            this.listBoxInputStream.SelectedIndexChanged += new System.EventHandler(this.listBoxInputStream_SelectedIndexChanged);
            // 
            // buttonClearInput
            // 
            this.buttonClearInput.Location = new System.Drawing.Point(451, 275);
            this.buttonClearInput.Margin = new System.Windows.Forms.Padding(1);
            this.buttonClearInput.Name = "buttonClearInput";
            this.buttonClearInput.Size = new System.Drawing.Size(110, 28);
            this.buttonClearInput.TabIndex = 11;
            this.buttonClearInput.Text = "Clear Input";
            this.buttonClearInput.UseVisualStyleBackColor = true;
            this.buttonClearInput.Click += new System.EventHandler(this.buttonClearInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 1121);
            this.Controls.Add(this.listBoxInputStream);
            this.Controls.Add(this.buttonInputFile);
            this.Controls.Add(this.buttonDecodeNext);
            this.Controls.Add(this.buttonDecodeAll);
            this.Controls.Add(this.buttonClearInput);
            this.Controls.Add(this.textBoxx8);
            this.Controls.Add(this.textBoxx9);
            this.Controls.Add(this.textBoxx10);
            this.Controls.Add(this.textBoxx11);
            this.Controls.Add(this.textBoxx12);
            this.Controls.Add(this.textBoxx13);
            this.Controls.Add(this.textBoxx14);
            this.Controls.Add(this.textBoxx15);
            this.Controls.Add(this.textBoxx7);
            this.Controls.Add(this.textBoxx6);
            this.Controls.Add(this.textBoxx5);
            this.Controls.Add(this.textBoxx4);
            this.Controls.Add(this.textBoxx3);
            this.Controls.Add(this.textBoxx2);
            this.Controls.Add(this.textBoxx1);
            this.Controls.Add(this.textBoxx0);
            this.Controls.Add(this.labelx8);
            this.Controls.Add(this.labelx15);
            this.Controls.Add(this.labelx14);
            this.Controls.Add(this.labelx13);
            this.Controls.Add(this.labelx12);
            this.Controls.Add(this.labelx11);
            this.Controls.Add(this.labelx10);
            this.Controls.Add(this.labelx9);
            this.Controls.Add(this.labelx1);
            this.Controls.Add(this.labelx2);
            this.Controls.Add(this.labelx3);
            this.Controls.Add(this.labelx4);
            this.Controls.Add(this.labelx5);
            this.Controls.Add(this.labelx6);
            this.Controls.Add(this.labelx7);
            this.Controls.Add(this.labelx0);
            this.Controls.Add(this.textBoxAddrMode);
            this.Controls.Add(this.textBoxRegisters);
            this.Controls.Add(this.textBoxInstruction);
            this.Controls.Add(this.textBoxHex);
            this.Controls.Add(this.textBoxProgramCounter);
            this.Controls.Add(this.labelAddrMode);
            this.Controls.Add(this.labelRegisters);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.labelHex);
            this.Controls.Add(this.labelProgramCounter);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProgramCounter;
        private System.Windows.Forms.Label labelHex;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Label labelRegisters;
        private System.Windows.Forms.Label labelAddrMode;
        private System.Windows.Forms.TextBox textBoxProgramCounter;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.TextBox textBoxInstruction;
        private System.Windows.Forms.TextBox textBoxRegisters;
        private System.Windows.Forms.TextBox textBoxAddrMode;
        private System.Windows.Forms.Label labelx0;
        private System.Windows.Forms.Label labelx7;
        private System.Windows.Forms.Label labelx6;
        private System.Windows.Forms.Label labelx5;
        private System.Windows.Forms.Label labelx4;
        private System.Windows.Forms.Label labelx3;
        private System.Windows.Forms.Label labelx2;
        private System.Windows.Forms.Label labelx1;
        private System.Windows.Forms.Label labelx9;
        private System.Windows.Forms.Label labelx10;
        private System.Windows.Forms.Label labelx11;
        private System.Windows.Forms.Label labelx12;
        private System.Windows.Forms.Label labelx13;
        private System.Windows.Forms.Label labelx14;
        private System.Windows.Forms.Label labelx15;
        private System.Windows.Forms.Label labelx8;
        private System.Windows.Forms.TextBox textBoxx0;
        private System.Windows.Forms.TextBox textBoxx1;
        private System.Windows.Forms.TextBox textBoxx2;
        private System.Windows.Forms.TextBox textBoxx3;
        private System.Windows.Forms.TextBox textBoxx4;
        private System.Windows.Forms.TextBox textBoxx5;
        private System.Windows.Forms.TextBox textBoxx6;
        private System.Windows.Forms.TextBox textBoxx7;
        private System.Windows.Forms.TextBox textBoxx15;
        private System.Windows.Forms.TextBox textBoxx14;
        private System.Windows.Forms.TextBox textBoxx13;
        private System.Windows.Forms.TextBox textBoxx12;
        private System.Windows.Forms.TextBox textBoxx11;
        private System.Windows.Forms.TextBox textBoxx10;
        private System.Windows.Forms.TextBox textBoxx9;
        private System.Windows.Forms.TextBox textBoxx8;
        private System.Windows.Forms.Button buttonDecodeAll;
        private System.Windows.Forms.Button buttonDecodeNext;
        private System.Windows.Forms.Button buttonInputFile;
        private System.Windows.Forms.ListBox listBoxInputStream;
        private System.Windows.Forms.Button buttonClearInput;
    }
}

