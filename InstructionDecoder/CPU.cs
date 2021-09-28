using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace InstructionDecoder
{
    class CPU
    {
        //attributes here
        private int programCounter;
        const byte INSTRUCTION_SIZE = 2;

        /// <summary>
        /// Default constructor
        /// </summary>
        public CPU()
        {
            programCounter = 0;
        }

        /// <summary>
        /// Decodes the passed instruction
        /// </summary>
        /// <param name="instruction">Int value of instruction (think in terms of bits)</param>
        /// <returns>Formated string of the instruction for output</returns>
        public string DecodeInstruction(int instruction)
        {
            //Note: add private methods that are called from here for decoding,
            // all decoding should originate from this method call
            string strInstruction = "";
            int opcode = instruction & 15;
            switch (opcode)
            {
                case 0:
                    // Halt
                    break;
                case 1:
                    // Load
                    break;
                case 2:
                    // Store
                    break;
                case 3:
                    // Add
                    strInstruction = Add(instruction);
                    break;
                case 4:
                    // Sub
                    break;
                case 5:
                    // Jmp
                    break;
                case 6:
                    // Je
                    break;
                case 7:
                    // Jne
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
            programCounter += INSTRUCTION_SIZE;
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

        #region Opcodes

        /// <summary>
        /// Translates the given increment instruction to a string. 
        /// </summary>
        /// <param name="instruction">16-bit instruction</param>
        /// <returns>String value of given increment instruction.</returns>
        private string Increment(int instruction)
        {
            string strInstruction = programCounter.ToString("0000") + "\t";
            strInstruction += "08\t";
            strInstruction += "INC\t";
            strInstruction += getRegister(instruction, 4);

            return strInstruction;
        }

        /// <summary>
        /// Translates the given AND instruction to a string. 
        /// </summary>
        /// <param name="instruction">16-bit instruction.</param>
        /// <returns>String value of given AND instruction.</returns>
        private string And(int instruction)
        {
            string strInstruction = programCounter.ToString("0000") + "\t";
            strInstruction += "0D\t";
            strInstruction += "AND\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            return strInstruction;
        }

        /// <summary>
        /// Translates the given OR instruction to a string.
        /// </summary>
        /// <param name="instruction">16-bit instruction.</param>
        /// <returns>String value of given OR instruction.</returns>
        private string Or(int instruction)
        {
            string strInstruction = programCounter.ToString("0000") + "\t";
            strInstruction += "0E\t";
            strInstruction += "OR\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            return strInstruction;
        }

        /// <summary>
        /// Translates the given XOR instruction to a string. 
        /// </summary>
        /// <param name="instruction">16-bit instruction.</param>
        /// <returns>String value of given XOR instruction.</returns>
        private string Xor(int instruction)
        {
            string strInstruction = programCounter.ToString("0000") + "\t";
            strInstruction += "0F\t";
            strInstruction += "XOR\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            return strInstruction;
        }

        private string Add(int instruction)
        {
            string strInstruction = programCounter.ToString("0000") + "\t";
            strInstruction += "03\t";
            strInstruction += "ADD\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            return strInstruction;
        }

        private string Sub(int instruction)
        {
            string strInstruction = programCounter.ToString("0000") + "\t";
            strInstruction += "04\t";
            strInstruction += "SUB\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            return strInstruction;
        }

        private string Je(int instruction)
        {
            string strInstruction = programCounter.ToString("0000") + "\t";
            strInstruction += "06\t";
            strInstruction += "JE\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            return strInstruction;
        }

        private string Jne(int instruction)
        {
            string strInstruction = programCounter.ToString("0000") + "\t";
            strInstruction += "07\t";
            strInstruction += "JNE\t";
            strInstruction += getRegister(instruction, 4) + ", ";
            strInstruction += getRegister(instruction, 8) + ", ";
            strInstruction += getRegister(instruction, 12);

            return strInstruction;
        }

        /// <summary>
        /// Decoder for the decrement opcode
        /// </summary>
        /// <param name="instruction">The instruction.</param>
        /// <returns>String of decoded information</returns>
        private string Dec(int instruction)
        {
            string strInstruction = programCounter.ToString("0000" + "\t");
            strInstruction += "09\t";
            strInstruction += "DEC\t";
            strInstruction += getRegister(instruction , 4);

            return strInstruction;
        }

        /// <summary>
        /// Shift right instruction
        /// </summary>
        /// <param name="instruction">The instruction.</param>
        /// <returns>string of opcode results</returns>
        private string Lsr(int instruction)
        {
            string strInstruction = programCounter.ToString("0000" + "\t");
            strInstruction += "0A\t";
            strInstruction += "LSR\t";
            strInstruction += getRegister(instruction , 4) + ", ";
            strInstruction += getRegister(instruction , 8) + ", ";
            strInstruction += getRegister(instruction , 12) + ", ";

            return strInstruction;
        }

        /// <summary>
        /// Shift left opcode
        /// </summary>
        /// <param name="instruction">The instruction.</param>
        /// <returns>string of results from instruction</returns>
        private string Lsl(int instruction)
        {
            string strInstruction = programCounter.ToString("0000" + "\t");
            strInstruction += "0B\t";
            strInstruction += "LSL\t";
            strInstruction += getRegister(instruction , 4) + ", ";
            strInstruction += getRegister(instruction , 8) + ", ";
            strInstruction += getRegister(instruction , 12);

            return strInstruction;
        }

        /// <summary>
        /// Arithmetic shift right
        /// </summary>
        /// <param name="instruction">The instruction.</param>
        /// <returns>string of results from instruction</returns>
        private string Asr(int instruction)
        {
            string strInstruction = programCounter.ToString("0000" + "\t");
            strInstruction += "0C\t";
            strInstruction += "ASR\t";
            strInstruction += getRegister(instruction , 4) + ", ";
            strInstruction += getRegister(instruction , 8) + ", ";
            strInstruction += getRegister(instruction , 12);

            return strInstruction;
        }

        #endregion
    }
}
