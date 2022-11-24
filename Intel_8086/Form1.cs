using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel_8086
{
    public partial class Int_8086 : Form
    {
        // REGISTERS:

        // AX
        byte AH = 0;
        byte AL = 0;

        // BX
        byte BH = 0;
        byte BL = 0;

        // CX
        byte CH = 0;
        byte CL = 0;

        //DX
        byte DH = 0;
        byte DL = 0;

        short SP = 0;
        short BP = 0;
        short SI = 0;
        short DI = 0;

        // SEGMENT REGISTERS:

        short CS = 0;
        short DS = 0;
        short SS = 0;
        short ES = 0;
        short IP = 0;
        short FLAGS = 0;

        // FLAGS

        bool SF = false;    // Sign Flag
        bool ZF = false;    // Zero Flag
        bool PF = false;    // Parity Flag
        bool AF = false;    // Auxiliary Carry Flag
        bool CF = false;    // Carry Flag
        bool OF = false;    // Overflow Flag
        bool IF = false;    // Interrupt Flag
        bool DF = false;    // Direction Flag
        bool TF = false;    // Trap Flag

        // MEMEORY
        Int64 mem = 0;

        Stack<short> the_stack = new Stack<short>();

        public Int_8086()
        {
            InitializeComponent();
        }


        
// DATA TRANSFER INSTRUCTIONS:

        // MOV --> =
        private void MOV_Click(object sender, EventArgs e)
        {
            Instruction.Text = "MOV";
        }

        // XCHG
        private void XCHG_Click(object sender, EventArgs e)
        {
            Instruction.Text = "XCHG";
        }

        // LEA
        private void LEA_Click(object sender, EventArgs e)
        {
            Instruction.Text = "LEA";
        }

        // PUSH
        private void PUSH_Click(object sender, EventArgs e)
        {
            Instruction.Text = "PUSH";
        }

        // PUSHF
        private void button1_Click(object sender, EventArgs e)
        {
            Instruction.Text = "PUSHF";
        }

        // POP
        private void POP_Click(object sender, EventArgs e)
        {
            Instruction.Text = "POP";
        }

        // POPF
        private void POPF_Click(object sender, EventArgs e)
        {
            Instruction.Text = "POPF";
        }

        // LAHF
        private void LAHF_Click(object sender, EventArgs e)
        {
            Instruction.Text = "LAHF";
        }

        // SAHF
        private void SAHF_Click(object sender, EventArgs e)
        {
            Instruction.Text = "SAHF";
        }

// ARITHMETIC INSTRUCTIONS:

        // ADD --> +
        private void ADD_Click(object sender, EventArgs e)
        {
            Instruction.Text = "ADD";
        }

        // SUB --> -
        private void SUB_Click(object sender, EventArgs e)
        {
            Instruction.Text = "SUB";
        }

        // MUL --> *
        private void MUL_Click(object sender, EventArgs e)
        {
            Instruction.Text = "MUL";
        }

        // DIV --> /
        private void DIV_Click(object sender, EventArgs e)
        {
            Instruction.Text = "DIV";
        }

        // INC --> ++
        private void INC_Click(object sender, EventArgs e)
        {
            Instruction.Text = "INC";
        }

        // DEC --> --
        private void DEC_Click(object sender, EventArgs e)
        {
            Instruction.Text = "DEC";
        }

        // AAA
        private void AAA_Click(object sender, EventArgs e)
        {
            Instruction.Text = "AAA";
        }

        //AAS
        private void AAS_Click(object sender, EventArgs e)
        {
            Instruction.Text = "AAS";
        }

        // IMUL
        private void IMUL_Click(object sender, EventArgs e)
        {
            Instruction.Text = "IMUL";
        }

        // IDIV
        private void IDIV_Click(object sender, EventArgs e)
        {
            Instruction.Text = "IDIV";
        }

// LOGICAL INSTRUCTIONS:

        // NOT
        private void NOT_Click(object sender, EventArgs e)
        {
            Instruction.Text = "NOT";
        }

        // AND
        private void AND_Click(object sender, EventArgs e)
        {
            Instruction.Text = "AND";
        }

        // OR
        private void OR_Click(object sender, EventArgs e)
        {
            Instruction.Text = "OR";
        }

        // XOR
        private void XOR_Click(object sender, EventArgs e)
        {
            Instruction.Text = "XOR";
        }

        // TEST
        private void TEST_Click(object sender, EventArgs e)
        {
            Instruction.Text = "TEST";
        }

        // SHL
        private void SHL_Click(object sender, EventArgs e)
        {
            Instruction.Text = "SHL";
        }

        // SHR
        private void SHR_Click(object sender, EventArgs e)
        {
            Instruction.Text = "SHR";
        }

        // SAL
        private void SAL_Click(object sender, EventArgs e)
        {
            Instruction.Text = "SAL";
        }

        // SAR
        private void SAR_Click(object sender, EventArgs e)
        {
            Instruction.Text = "SAR";
        }

        // ROL
        private void ROL_Click(object sender, EventArgs e)
        {
            Instruction.Text = "ROL";
        }

        // ROR
        private void ROR_Click(object sender, EventArgs e)
        {
            Instruction.Text = "ROR";
        }

        // RCL
        private void RCL_Click(object sender, EventArgs e)
        {
            Instruction.Text = "RCL";
        }

        // RCR
        private void RCR_Click(object sender, EventArgs e)
        {
            Instruction.Text = "RCR";
        }

// FLAGS MANIPULATION INSTRUCTIONS:

        // CLC
        private void CLC_Click(object sender, EventArgs e)
        {
            Instruction.Text = "CLC";
        }

        // CLD
        private void CLD_Click(object sender, EventArgs e)
        {
            Instruction.Text = "CLD";
        }

        // CLI
        private void CLI_Click(object sender, EventArgs e)
        {
            Instruction.Text = "CLI";
        }

        // STC
        private void STC_Click(object sender, EventArgs e)
        {
            Instruction.Text = "STC";
        }

        // STD
        private void STD_Click(object sender, EventArgs e)
        {
            Instruction.Text = "STD";
        }

        // STI
        private void STI_Click(object sender, EventArgs e)
        {
            Instruction.Text = "STI";
        }

        // CMC
        private void CMC_Click(object sender, EventArgs e)
        {
            Instruction.Text = "CMC";
        }

// JUMP INSTRUCTIONS:

        // JE/JZ
        private void JE_JZ_Click(object sender, EventArgs e)
        {
            Instruction.Text = "JE/JZ";
        }

        // JL/JNEG
        private void JL_JNEG_Click(object sender, EventArgs e)
        {
            Instruction.Text = "JL/JNEG";
        }

        // JLE/JNG
        private void JLE_JNG_Click(object sender, EventArgs e)
        {
            Instruction.Text = "JLE/JNG";
        }

        // JB/JNAF
        private void JB_JNAF_Click(object sender, EventArgs e)
        {
            Instruction.Text = "JB/JNAF";
        }

        // JBE/JNA
        private void JBE_JNA_Click(object sender, EventArgs e)
        {
            Instruction.Text = "JBE/JNA";
        }

        // JNE/JNZ
        private void JNE_JNZ_Click(object sender, EventArgs e)
        {
            Instruction.Text = "JNE/JNZ";
        }

        // JNL/JGE
        private void JNL_JGE_Click(object sender, EventArgs e)
        {
            Instruction.Text = "JNL/JGE";
        }

        // JNLE/JG
        private void JNLE_JG_Click(object sender, EventArgs e)
        {
            Instruction.Text = "JNLE/JG";
        }

        // JNB/JAE
        private void JNB_JAE_Click(object sender, EventArgs e)
        {
            Instruction.Text = "JNB/JAE";
        }

        // JNBE/JA
        private void JNBE_JA_Click(object sender, EventArgs e)
        {
            Instruction.Text = "JNBE/JA";
        }

        // CALL
        private void CALL_Click(object sender, EventArgs e)
        {
            Instruction.Text = "CALL";
        }

        // JMP
        private void JMP_Click(object sender, EventArgs e)
        {
            Instruction.Text = "JMP";
        }

        // CMP
        private void CMP_Click(object sender, EventArgs e)
        {
            Instruction.Text = "CMP";
        }

// INTERRUPT INSTRUCTIONS:

        // INT
        private void INT_Click(object sender, EventArgs e)
        {
            Instruction.Text = "INT";
        }

        // INTO
        private void INTO_Click(object sender, EventArgs e)
        {
            Instruction.Text = "INTO";
        }

        // RET
        private void RET_Click(object sender, EventArgs e)
        {
            Instruction.Text = "RET";
        }

        // IRET
        private void IRET_Click(object sender, EventArgs e)
        {
            Instruction.Text = "IRET";
        }

// ENTER & EXIT INSTRUCTIONS:

        // IN
        private void IN_Click(object sender, EventArgs e)
        {
            Instruction.Text = "IN";
        }

        // OUT
        private void OUT_Click(object sender, EventArgs e)
        {
            Instruction.Text = "OUT";
        }



// Main block

        // Instruction block
        private void Instruction_TextChanged(object sender, EventArgs e)
        {

        }

        // Operations block
        private void Operation_TextChanged(object sender, EventArgs e)
        {

        }

        // Run Button
        private void RUN_Click(object sender, EventArgs e)
        {
            if (Instruction.Text == "" || Operation.Text == "")
            {
                MessageBox.Show("Please,\nenter a instruction and operations!");
            }
            else
            {
                string inst = Instruction.Text;
                string ops_input = (Operation.Text).Replace(" ", "");

                List<string> ops = new List<string>();
                string x = "";      // helping variable

                for (int i = 0; i < ops_input.Length; i++)
                {
                    if (ops_input[i] != ';')
                    {
                        if (ops_input[i] == ',')
                        {
                            ops.Add(x);
                            x = "";
                        }
                        else
                        {
                            x += ops_input[i];
                        }
                    }
                    else { break; }
                }

                ops.Add(x);
                Asm_operations(inst, ops);

                x = "";

                // STACK & REGISTERS VALUES:

                Stack_box.Text = "AX\t=\t" + (AH + AL);
                Stack_box.Text += "\nBX\t=\t" + (BH + BL);
                Stack_box.Text += "\nCX\t=\t" + (CH + CL);
                Stack_box.Text += "\nDX\t=\t" + (DH + DL);

                Stack_box.Text += "\nSP\t=\t" + SP;
                Stack_box.Text += "\nBP\t=\t" + BP;
                Stack_box.Text += "\nSI\t=\t" + SI;
                Stack_box.Text += "\nDI\t=\t" + DI;

                Stack_box.Text += "\n\nMemory\t=\t" + mem;
            }


            Instruction.Text = "";
            Operation.Text = "";
        }

        // Clear Button
        private void Clear_Click(object sender, EventArgs e)
        {
            Instruction.Text = "";
            Operation.Text = "";
            Stack_box.Text = "";
        }

        // STACK --> shows the contents of the register 
        private void Stack_box_TextChanged(object sender, EventArgs e)
        {

        }



// Following tasks

        private void Asm_operations(string inst, List<string> ops)
        {
            //if (!Is_register(ops[0]))
            //{
            //    short ops_1 = Convert.ToInt16(ops[0]);
            //}
            //if (!Is_register(ops[1]))
            //{
            //    short ops_2 = Convert.ToInt16(ops[1]);
            //}

            switch (inst)
            {
                // DATA TRANSFER

                case "MOV":
                    if ( Is_register(ops[0]) && !Is_register(ops[1]) )
                    {
                        if (ops[0] == "AX" || ops[0] == "AH")
                        {
                            AH = Convert.ToByte(ops[1]);
                        }
                        else if (ops[0] == "AL")
                        {
                            AL = Convert.ToByte(ops[1]);
                        }
                        else if (ops[0] == "BX" || ops[0] == "BH")
                        {
                            BH = Convert.ToByte(ops[1]);
                        }
                        else if (ops[0] == "BL")
                        {
                            BL = Convert.ToByte(ops[1]);
                        }
                        else if (ops[0] == "CX" || ops[0] == "CH")
                        {
                            CH = Convert.ToByte(ops[1]);
                        }
                        else if (ops[0] == "CL")
                        {
                            CL = Convert.ToByte(ops[1]);
                        }
                        else if (ops[0] == "DX" || ops[0] == "DH")
                        {
                            DH = Convert.ToByte(ops[1]);
                        }
                        else if (ops[0] == "DL")
                        {
                            DL = Convert.ToByte(ops[1]);
                        }
                    }
                    else if ( Is_register(ops[0]) && (Is_register(ops[1]) || ops[1] == "mem") )     //          <-- mem / registers don't save mem value
                    {
                        if (ops[0] == "AX" || ops[0] == "AH")
                        {
                            if (ops[1] == "BX") { AH = Convert.ToByte(BH + BL); }
                            else if (ops[1] == "BH") { AH = BH; }
                            else if(ops[1] == "BL") { AH = BL; }
                            else if(ops[1] == "CX") { AH = Convert.ToByte(CH + CL); }
                            else if(ops[1] == "CH") { AH = CH; }
                            else if(ops[1] == "CL") { AH = CL; }
                            else if(ops[1] == "DX") { AH = Convert.ToByte(DH + DL); }
                            else if(ops[1] == "DH") { AH = DH; }
                            else if(ops[1] == "DL") { AH = DL; }
                            else { AH = Convert.ToByte(mem); }
                        }
                        else if (ops[0] == "AL")
                        {
                            if (ops[1] == "BX") { AL = Convert.ToByte(BH + BL); }
                            else if (ops[1] == "BH") { AL = BH; }
                            else if (ops[1] == "BL") { AL = BL; }
                            else if (ops[1] == "CX") { AL = Convert.ToByte(CH + CL); }
                            else if (ops[1] == "CH") { AL = CH; }
                            else if (ops[1] == "CL") { AL = CL; }
                            else if (ops[1] == "DX") { AL = Convert.ToByte(DH + DL); }
                            else if (ops[1] == "DH") { AL = DH; }
                            else if (ops[1] == "DL") { AL = DL; }
                            else { AL = Convert.ToByte(mem); }
                        }
                        else if (ops[0] == "BX" || ops[0] == "BH")
                        {
                            if (ops[1] == "AX") { BH = Convert.ToByte(AH + AL); }
                            else if (ops[1] == "AH") { BH = AH; }
                            else if (ops[1] == "AL") { BH = AL; }
                            else if (ops[1] == "CX") { BH = Convert.ToByte(CH + CL); }
                            else if (ops[1] == "CH") { BH = CH; }
                            else if (ops[1] == "CL") { BH = CL; }
                            else if (ops[1] == "DX") { BH = Convert.ToByte(DH + DL); }
                            else if (ops[1] == "DH") { BH = DH; }
                            else if (ops[1] == "DL") { BH = DL; }
                            else { BH = Convert.ToByte(mem); }
                        }
                        else if (ops[0] == "BL")
                        {
                            if (ops[1] == "AX") { BL = Convert.ToByte(AH + AL); }
                            else if (ops[1] == "AH") { BL = AH; }
                            else if (ops[1] == "AL") { BL = AL; }
                            else if (ops[1] == "CX") { BL = Convert.ToByte(CH + CL); }
                            else if (ops[1] == "CH") { BL = CH; }
                            else if (ops[1] == "CL") { BL = CL; }
                            else if (ops[1] == "DX") { BL = Convert.ToByte(DH + DL); }
                            else if (ops[1] == "DH") { BL = DH; }
                            else if (ops[1] == "DL") { BL = DL; }
                            else { BL = Convert.ToByte(mem); }
                        }
                        else if (ops[0] == "CX" || ops[0] == "CH")
                        {
                            if (ops[1] == "BX") { CH = Convert.ToByte(BH + BL); }
                            else if (ops[1] == "BH") { CH = BH; }
                            else if (ops[1] == "BL") { CH = BL; }
                            else if (ops[1] == "AX") { CH = Convert.ToByte(AH + AL); }
                            else if (ops[1] == "AH") { CH = AH; }
                            else if (ops[1] == "AL") { CH = AL; }
                            else if (ops[1] == "DX") { CH = Convert.ToByte(DH + DL); }
                            else if (ops[1] == "DH") { CH = DH; }
                            else if (ops[1] == "DL") { CH = DL; }
                            else { CH = Convert.ToByte(mem); }
                        }
                        else if (ops[0] == "CL")
                        {
                            if (ops[1] == "BX") { CL = Convert.ToByte(BH + BL); }
                            else if (ops[1] == "BH") { CL = BH; }
                            else if (ops[1] == "BL") { CL = BL; }
                            else if (ops[1] == "AX") { CL = Convert.ToByte(AH + AL); }
                            else if (ops[1] == "AH") { CL = AH; }
                            else if (ops[1] == "AL") { CL = AL; }
                            else if (ops[1] == "DX") { CL = Convert.ToByte(DH + DL); }
                            else if (ops[1] == "DH") { CL = DH; }
                            else if (ops[1] == "DL") { CL = DL; }
                            else { CL = Convert.ToByte(mem); }
                        }
                        else if (ops[0] == "DX" || ops[0] == "DH")
                        {
                            if (ops[1] == "BX") { DH = Convert.ToByte(BH + BL); }
                            else if (ops[1] == "BH") { DH = BH; }
                            else if (ops[1] == "BL") { DH = BL; }
                            else if (ops[1] == "CX") { DH = Convert.ToByte(CH + CL); }
                            else if (ops[1] == "CH") { DH = CH; }
                            else if (ops[1] == "CL") { DH = CL; }
                            else if (ops[1] == "AX") { DH = Convert.ToByte(AH + AL); }
                            else if (ops[1] == "AH") { DH = AH; }
                            else if (ops[1] == "AL") { DH = AL; }
                            else { DH = Convert.ToByte(mem); }
                        }
                        else if (ops[0] == "DL")
                        {
                            if (ops[1] == "BX") { DL = Convert.ToByte(BH + BL); }
                            else if (ops[1] == "BH") { DL = BH; }
                            else if (ops[1] == "BL") { DL = BL; }
                            else if (ops[1] == "CX") { DL = Convert.ToByte(CH + CL); }
                            else if (ops[1] == "CH") { DL = CH; }
                            else if (ops[1] == "CL") { DL = CL; }
                            else if (ops[1] == "AX") { DL = Convert.ToByte(AH + AL); }
                            else if (ops[1] == "AH") { DL = AH; }
                            else if (ops[1] == "AL") { DL = AL; }
                            else { DL = Convert.ToByte(mem); }
                        }
                    }
                    else
                    {
                        if(ops[0] == "mem")
                        {
                            if ( !Is_register(ops[1]) ) { mem = Convert.ToByte(ops[1]); }
                            else 
                            {
                                if (ops[1] == "AX") { mem = AH + AL; }
                                else if (ops[1] == "AH") { mem = AH; }
                                else if (ops[1] == "AL") { mem = AL; }
                                else if (ops[1] == "BX") { mem = BH + BL; }
                                else if (ops[1] == "BH") { mem = BH; }
                                else if (ops[1] == "BL") { mem = BL; }
                                else if (ops[1] == "CX") { mem = CH + CL; }
                                else if (ops[1] == "CH") { mem = CH; }
                                else if (ops[1] == "CL") { mem = CL; }
                                else if (ops[1] == "DX") { mem = DH + DL; }
                                else if (ops[1] == "DH") { mem = DH; }
                                else if (ops[1] == "DL") { mem = DL; }
                                else { MessageBox.Show("Probably you enter Wrong operation!"); }
                            }
                        }
                        else { MessageBox.Show("You enter Wrong operations!"); }  
                    }

                    break;

                case "PUSH":
                    the_stack.Push(Convert.ToInt16(ops[1]));

                    break;
                case "PUSHF":

                    break;

                case "POP":
                    the_stack.Pop();
                    break;

                case "POPF":

                    break;
                case "XCHG":

                    break;
                case "LEA":

                    break;
                case "LAHF":

                    break;
                case "SAHF":

                    break;

                // ARITHMETIC

                case "ADD":
                     
                    break;
                case "SUB":

                    break;
                case "MUL":

                    break;
                case "DIV":

                    break;
                case "INC":

                    break;
                case "DEC":

                    break;
                case "AAA":

                    break;
                case "AAS":

                    break;
                case "IMUL":

                    break;
                case "IDIV":

                    break;
            }
        }

        // WRITE FUNCTION CONVERTING STRING TO SHORT & STRING TO BYTE

        /*
          HERE put the code!
        */

        private bool Is_register(string ops)
        {
            switch (ops)
            {
                case "AX":
                    return true;
                case "AH":
                    return true;
                case "AL":
                    return true;
                case "BX":
                    return true;
                case "BH":
                    return true;
                case "BL":
                    return true;
                case "CX":
                    return true;
                case "CH":
                    return true;
                case "CL":
                    return true;
                case "DX":
                    return true;
                case "DH":
                    return true;
                case "DL":
                    return true;

                case "SP":
                    return true;
                case "BP":
                    return true;
                case "SI":
                    return true;
                case "DI":
                    return true;

                case "CS":
                    return true;
                case "DS":
                    return true;
                case "SS":
                    return true;
                case "ES":
                    return true;
                case "IP":
                    return true;
                case "FLAGS":
                    return true;

                default:
                    return false;
            }
        }

        //private object Register_sercher(string regd, byte AH, byte AL, byte BH, byte BL, byte CH, byte CL, byte DH, byte DL, short SP, short BP, short SI, short DI, short CS, short DS, short SS, short ES, short IP, short FLAG)
        //{
        //    switch (regd)
        //    {
        //        case "AX":
        //            return AH;
        //    }
        //}
        //Register_sercher(ops[0], AH, AL, BH, BL, CH, CL, DH, DL, SP, BP, SI, DI, CS, DS, SS, ES, IP, FLAGS) = 2;

    }
}