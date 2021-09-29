using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace InstructionDecoder
{
    class CPU
    {
        //attributes here
        const byte INSTRUCTION_SIZE = 2;

        private int BusNum;
        private int Addrmode;

        public List<Register> Registers = new List<Register>();

        /// <summary>
        /// Default constructor
        /// </summary>
        public CPU()
        {
            for (int i = 0; i < 16; i++)
                Registers.Add(new Register("x" + i));
            Registers[14].Value = 0xFFFF;
        }

        /// <summary>
        /// Gets the INSTRUCTION_SIZE constant. 
        /// </summary>
        /// <returns>Integer value of instruction size.</returns>
        public int GetInstructionSize() { return INSTRUCTION_SIZE;  }

        /// <summary>
        /// Decodes the passed instruction
        /// </summary>
        /// <param name="instruction">Int value of instruction (think in terms of bits)</param>
        /// <returns>Formated string of the instruction for output</returns>
        public string DecodeInstruction(int instruction, ref bool loadImediate)
        {
            //Note: add private methods that are called from here for decoding,
            // all decoding should originate from this method call
            Registers[13].Value += INSTRUCTION_SIZE;
            //If already reading operand
            if (loadImediate)
            {
                loadImediate = false;
                if (Addrmode == 0)
                    Registers[BusNum].Value = instruction;
                return instruction.ToString();
            }

            string strInstruction = "";
            int opcode = instruction & 15;
            switch (opcode)
            {
                case 0:
                    strInstruction = Halt(instruction);
                    break;
                case 1:
                    strInstruction = Load(instruction, out loadImediate);
                    break;
                case 2:
                    strInstruction = Store(instruction, out loadImediate);
                    break;
                case 3:
                    // Add
                    strInstruction = Add(instruction);
                    break;
                case 4:
                    // Sub
                    strInstruction = Sub(instruction);
                    break;
                case 5:
                    // Jmp
                    strInstruction = Jump(instruction);
                    break;
                case 6:
                    // Je
                    strInstruction = Je(instruction);
                    break;
                case 7:
                    // Jne
                    strInstruction = Jne(instruction);
                    break;
                case 8:
                    strInstruction = Increment(instruction);
                    break;
                case 9:
                    strInstruction = Dec(instruction);
                    break;
                case 10:
                    strInstruction = Lsr(instruction);
                    break;
                case 11:
                    strInstruction = Lsl(instruction);
                    break;
                case 12:
                    strInstruction = Asr(instruction);
                    break;
                case 13:
                    strInstruction = And(instruction);
                    break;
                case 14:
                    strInstruction = Or(instruction);
                    break;
                case 15:
                    strInstruction = Xor(instruction);
                    break;
                default:
                    break;
            }
            return strInstruction;
        }

        /// <summary>
        /// Retrieves the register in the given instruction and an offset. 
        /// Offset should place desired bits in last nibble of instruction.
        /// </summary>
        /// <param name="instruction">16-bit instruction.</param>
        /// <param name="offset">Number of bits to shift right.</param>
        /// <returns></returns>
        private string getRegister(int instruction, int offset)
        {
            int register = (instruction >> offset) & 15;
            string strRegister = "x" + register.ToString();

            return strRegister;
        }

        /// <summary>
        /// Returns the value of the specified bits
        /// </summary>
        /// <param name="instruction">Full 16 bit instruction</param>
        /// <param name="offset">Offset into the instruction</param>
        /// <param name="length">Number of bits wanted</param>
        /// <returns></returns>
        private int getBits(int instruction, int offset, int length)
        {
            int value = 0;
            int numBits = (int)Math.Pow(2, length) - 1;

            value = (instruction >> offset) & numBits;

            return value;
        }

        #region Opcodes

        /// <summary>
        /// Translate the given Halt instruction to a string
        /// </summary>
        /// <param name="instruction">16 bit instruction</param>
        /// <returns>String value of given Halt instruction.</returns>
        private string Halt(int instruction)
        {
            string strInstruction = Registers[13].Value.ToString("0000") + "\t";
            strInstruction += "00\t";
            strInstruction += "HLT\t";

            return strInstruction;
        }

        /// <summary>
        /// Translates the given Load instruction to a string
        /// </summary>
        /// <param name="instruction">16 bit instruction.</param>
        /// <param name="loadNext">If next 16 bits is operand</param>
        /// <returns>String value of given Load instruction.</returns>
        private string Load(int instruction, out bool loadNext)
        {
            loadNext = false;
            int regDest = getBits(instruction, 4, 4);
            int regSource = getBits(instruction, 12, 4);

            string strInstruction = Registers[13].Value.ToString("0000") + "\t";
            strInstruction += "01\t";

            if (getBits(instruction, 8, 1) == 1)
            {
                strInstruction += "LDR\t";
                strInstruction += getRegister(instruction, 4) + ", ";
                strInstruction += getRegister(instruction, 12) + "\t";
                //addressing mode
                switch(getBits(instruction, 9, 3))
                {
                    case 1:
                        strInstruction += "Direct";
                        Registers[regDest].Value = Registers[regSource].Value;
                        break;
                    case 2:
                        strInstruction += "Indirect";
                        Registers[regDest].Value = 0;
                        break;
                    case 3:
                        strInstruction += "Stack-Rel";
                        Registers[regDest].Value = 0;
                        break;
                    case 4:
                        strInstruction += "Stack-Rel Deferred";
                        Registers[regDest].Value = 0;
                        break;
                    case 5:
                        strInstruction += "Indexed";
                        Registers[regDest].Value = 0;
                        break;
                    case 6:
                        strInstruction += "Stack Indexed";
                        Registers[regDest].Value = 0;
                        break;
                    case 7:
                        strInstruction += "Stack Ind Deferred";
                        Registers[regDest].Value = 0;
                        break;
                }
            }
            else
            {
                loadNext = true;
                strInstruction += "LD\t";
                BusNum = getBits(instruction, 4, 4);
                strInstruction += getRegister(instruction, 4) + ", \t";
                //addressing mode
                switch (getBits(instruction, 9, 3))
                {
                    case 0:
                        strInstruction += "Immediate";
                        Addrmode = 0;
                        break;
                    case 2:
                        strInstruction += "Indirect";
                        Addrmode = 2;
                        break;
                    case 3:
                        strInstruction += "Stack-Rel";
                        Addrmode = 3;
                        break;
                    case 4:
                        strInstruction += "Stack-Rel Deferred";
                        Addrmode = 4;
                        break;
                    case 5:
                        strInstruction += "Indexed";
                        Addrmode = 5;
                        break;
                    case 6:
                        strInstruction += "Stack Indexed";
                        Addrmode = 6;
                        break;
                    case 7:
                        strInstruction += "Stack Ind Deferred";
                        Addrmode = 7;
                        break;
                }
            }

            return strInstruction;
        }

        /// <summary>
        /// Translates the given Store instruction to a string
        /// </summary>
        /// <param name="instruction">16 bit instruction.</param>
        /// <param name="storeNext">Next 16 bits is operand.</param>
        /// <returns>String value of given Store instruction.</returns>
        private string Store(int instruction, out bool storeNext)
        {
            storeNext = false;
            int regSource = getBits(instruction, 4, 4);
            int regDest = getBits(instruction, 12, 4);

            string strInstruction = Registers[13].Value.ToString("0000") + "\t";
            strInstruction += "02\t";

            if (getBits(instruction, 8, 1) == 1)
            {
                strInstruction += "STR\t";
                strInstruction += getRegister(instruction, 4) + ", ";
                strInstruction += getRegister(instruction, 12) + "\t";

                //addressing mode
                switch (getBits(instruction, 9, 3))
                {
                    case 1:
                        strInstruction += "Direct";
                        Registers[regDest].Value = Registers[regSource].Value;
                        break;
                    case 2:
                        strInstruction += "Indirect";
                        break;
                    case 3:
                        strInstruction += "Stack-Rel";
                        break;
                    case 4:
                        strInstruction += "Stack-Rel Deferred";
                        break;
                    case 5:
                        strInstruction += "Indexed";
                        break;
                    case 6:
                        strInstruction += "Stack Indexed";
                        break;
                    case 7:
                        strInstruction += "Stack Ind Deferred";
                        break;
                }
            }
            else
            {
                storeNext = true;
                strInstruction += "ST\t";
                BusNum = getBits(instruction, 4, 4);
                strInstruction += getRegister(instruction, 4) + ", \t";

                //addressing mode
                switch (getBits(instruction, 9, 3))
                {
                    case 1:
                        strInstruction += "Direct";
                        Registers[regDest].Value = Registers[regSource].Value;
                        break;
                    case 2:
                        strInstruction += "Indirect";
                        Addrmode = 2;
                        break;
                    case 3:
                        strInstruction += "Stack-Rel";
                        Addrmode = 3;
                        break;
                    case 4:
                        strInstruction += "Stack-Rel Deferred";
                        Addrmode = 4;
                        break;
                    case 5:
                        strInstruction += "Indexed";
                        Addrmode = 5;
                        break;
                    case 6:
                        strInstruction += "Stack Indexed";
                        Addrmode = 6;
                        break;
                    case 7:
                        strInstruction += "Stack Ind Deferred";
                        Addrmode = 7;
                        break;
                }
            }

            return strInstruction;
        }

        /// <summary>
        /// Translates the given Jump instruction to a string. 
        /// </summary>
        /// <param name="instruction">16-bit instruction</param>
        /// <returns>String value of given Jump instruction.</returns>
        private string Jump(int instruction)
        {
            string strInstruction = Registers[13].Value.ToString("0000") + "\t";
            strInstruction += "05\t";
            strInstruction += "JMP\t";
            strInstruction += getRegister(instruction, 4);
            Registers[13].Value = getBits(instruction, 4, 4);

            return strInstruction;
        }

        /// <summary>
        /// Translates the given increment instruction to a string. 
        /// </summary>
        /// <param name="instruction">16-bit instruction</param>
        /// <returns>String value of given increment instruction.</returns>
        private string Increment(int instruction)
        {
            string strInstruction = Registers[13].Value.ToString("0000") + "\t";
            strInstruction += "08\t";
            strInstruction += "INC\t";
            strInstruction += getRegister(instruction, 4);
            Registers[getBits(instruction, 4, 4)].Value++;

            return strInstruction;
        }

        /// <summary>
        /// Translates the given AND instruction to a string. 
        /// </summary>
        /// <param name="instruction">16-bit instruction.</param>
        /// <returns>String value of given AND instruction.</returns>
        private string And(int instruction)
        {
            int destReg = getBits(instruction, 4, 4);
            int sourceReg1 = getBits(instruction, 8, 4);
            int sourceReg2 = getBits(instruction, 12, 4);
            string strInstruction = Registers[13].Value.ToString("0000") + "\t";
            strInstruction += "0D\t";
            strInstruction += "AND\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            Registers[destReg].Value = Registers[sourceReg1].Value & Registers[sourceReg2].Value;

            return strInstruction;
        }

        /// <summary>
        /// Translates the given OR instruction to a string.
        /// </summary>
        /// <param name="instruction">16-bit instruction.</param>
        /// <returns>String value of given OR instruction.</returns>
        private string Or(int instruction)
        {
            int destReg = getBits(instruction, 4, 4);
            int sourceReg1 = getBits(instruction, 8, 4);
            int sourceReg2 = getBits(instruction, 12, 4);
            string strInstruction = Registers[13].Value.ToString("0000") + "\t";
            strInstruction += "0E\t";
            strInstruction += "OR\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            Registers[destReg].Value = Registers[sourceReg1].Value | Registers[sourceReg2].Value;

            return strInstruction;
        }

        /// <summary>
        /// Translates the given XOR instruction to a string. 
        /// </summary>
        /// <param name="instruction">16-bit instruction.</param>
        /// <returns>String value of given XOR instruction.</returns>
        private string Xor(int instruction)
        {
            int destReg = getBits(instruction, 4, 4);
            int sourceReg1 = getBits(instruction, 8, 4);
            int sourceReg2 = getBits(instruction, 12, 4);
            string strInstruction = Registers[13].Value.ToString("0000") + "\t";
            strInstruction += "0F\t";
            strInstruction += "XOR\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            Registers[destReg].Value = Registers[sourceReg1].Value ^ Registers[sourceReg2].Value;

            return strInstruction;
        }

        /// <summary>
        /// Translates the given ADD instruction to a string. 
        /// </summary>
        /// <param name="instruction">16-bit instruction.</param>
        /// <returns>String value of given ADD instruction.</returns>
        private string Add(int instruction)
        {
            int destReg = getBits(instruction, 4, 4);
            int sourceReg1 = getBits(instruction, 8, 4);
            int sourceReg2 = getBits(instruction, 12, 4);
            string strInstruction = Registers[13].Value.ToString("0000") + "\t";
            strInstruction += "03\t";
            strInstruction += "ADD\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            Registers[destReg].Value = Registers[sourceReg1].Value + Registers[sourceReg2].Value;

            return strInstruction;
        }

        /// <summary>
        /// Translates the given SUB instruction to a string. 
        /// </summary>
        /// <param name="instruction">16-bit instruction.</param>
        /// <returns>String value of given SUB instruction.</returns>
        private string Sub(int instruction)
        {
            int destReg = getBits(instruction, 4, 4);
            int sourceReg1 = getBits(instruction, 8, 4);
            int sourceReg2 = getBits(instruction, 12, 4);
            string strInstruction = Registers[13].Value.ToString("0000") + "\t";
            strInstruction += "04\t";
            strInstruction += "SUB\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            Registers[destReg].Value = Registers[sourceReg1].Value - Registers[sourceReg2].Value;

            return strInstruction;
        }

        /// <summary>
        /// Translates the given JE instruction to a string. 
        /// </summary>
        /// <param name="instruction">16-bit instruction.</param>
        /// <returns>String value of given JE instruction.</returns>
        private string Je(int instruction)
        {
            int destReg = getBits(instruction, 4, 4);
            int sourceReg1 = getBits(instruction, 8, 4);
            int sourceReg2 = getBits(instruction, 12, 4);
            string strInstruction = Registers[13].Value.ToString("0000") + "\t";
            strInstruction += "06\t";
            strInstruction += "JE\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            if (Registers[sourceReg1].Value == Registers[sourceReg2].Value)
                Registers[13].Value = Registers[destReg].Value;

            return strInstruction;
        }

        /// <summary>
        /// Translates the given JNE instruction to a string. 
        /// </summary>
        /// <param name="instruction">16-bit instruction.</param>
        /// <returns>String value of given JNE instruction.</returns>
        private string Jne(int instruction)
        {
            int destReg = getBits(instruction, 4, 4);
            int sourceReg1 = getBits(instruction, 8, 4);
            int sourceReg2 = getBits(instruction, 12, 4);
            string strInstruction = Registers[13].Value.ToString("0000") + "\t";
            strInstruction += "07\t";
            strInstruction += "JNE\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            if (Registers[sourceReg1].Value != Registers[sourceReg2].Value)
                Registers[13].Value = Registers[destReg].Value;

            return strInstruction;
        }

        /// <summary>
        /// Decoder for the decrement opcode
        /// </summary>
        /// <param name="instruction">The instruction.</param>
        /// <returns>String of decoded information</returns>
        private string Dec(int instruction)
        {
            string strInstruction = Registers[13].Value.ToString("0000" + "\t");
            strInstruction += "09\t";
            strInstruction += "DEC\t";
            strInstruction += getRegister(instruction , 4);
            Registers[getBits(instruction, 4, 4)].Value--;

            return strInstruction;
        }

        /// <summary>
        /// Shift right instruction
        /// </summary>
        /// <param name="instruction">The instruction.</param>
        /// <returns>string of opcode results</returns>
        private string Lsr(int instruction)
        {
            int destReg = getBits(instruction, 4, 4);
            int sourceReg1 = getBits(instruction, 8, 4);
            int sourceReg2 = getBits(instruction, 12, 4);
            string strInstruction = Registers[13].Value.ToString("0000" + "\t");
            strInstruction += "0A\t";
            strInstruction += "LSR\t";
            strInstruction += getRegister(instruction , 4) + ", ";
            strInstruction += getRegister(instruction , 8) + ", ";
            strInstruction += getRegister(instruction , 12) + ", ";

            Registers[destReg].Value = (int)((uint)(Registers[sourceReg1].Value) >> Registers[sourceReg2].Value);

            return strInstruction;
        }

        /// <summary>
        /// Shift left opcode
        /// </summary>
        /// <param name="instruction">The instruction.</param>
        /// <returns>string of results from instruction</returns>
        private string Lsl(int instruction)
        {
            int destReg = getBits(instruction, 4, 4);
            int sourceReg1 = getBits(instruction, 8, 4);
            int sourceReg2 = getBits(instruction, 12, 4);
            string strInstruction = Registers[13].Value.ToString("0000" + "\t");
            strInstruction += "0B\t";
            strInstruction += "LSL\t";
            strInstruction += getRegister(instruction , 4) + ", ";
            strInstruction += getRegister(instruction , 8) + ", ";
            strInstruction += getRegister(instruction , 12);

            Registers[destReg].Value = Registers[sourceReg1].Value << Registers[sourceReg2].Value;

            return strInstruction;
        }

        /// <summary>
        /// Arithmetic shift right
        /// </summary>
        /// <param name="instruction">The instruction.</param>
        /// <returns>string of results from instruction</returns>
        private string Asr(int instruction)
        {
            int destReg = getBits(instruction, 4, 4);
            int sourceReg1 = getBits(instruction, 8, 4);
            int sourceReg2 = getBits(instruction, 12, 4);
            string strInstruction = Registers[13].Value.ToString("0000" + "\t");
            strInstruction += "0C\t";
            strInstruction += "ASR\t";
            strInstruction += getRegister(instruction , 4) + ", ";
            strInstruction += getRegister(instruction , 8) + ", ";
            strInstruction += getRegister(instruction , 12);

            Registers[destReg].Value = Registers[sourceReg1].Value >> Registers[sourceReg2].Value;

            return strInstruction;
        }

        #endregion
    }
}
