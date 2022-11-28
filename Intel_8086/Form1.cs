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

        // POINTERS & INDEX REGISTERS

        short SP = 0;   // Stack Pointer
        short BP = 0;   // Base Pointer
        short SI = 0;   // Source Index
        short DI = 0;   // Destination Index
        short IP = 0;   // Instruction Pointer

        // SEGMENT REGISTERS:

        short CS = 0;   // Code Segment
        short DS = 0;   // Data Segment
        short SS = 0;   // Stack Segment
        short ES = 0;   // Extra Segment

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

                List<string> ops = new List<string>(2);
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

                Print();
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
            switch (inst)
            {
                // DATA TRANSFER

                case "MOV":
                    if ( Is_register(ops[0]) && !Is_register(ops[1]) && ops[1] != "mem" )
                    {
                        if (ops[0] == "AX" || ops[0] == "AH")
                        {
                            AH = Convert.ToByte(Limits(ops[0], ops[1]));
                        }
                        else if (ops[0] == "AL")
                        {
                            AL = Convert.ToByte(Limits(ops[0], ops[1]));
                        }
                        else if (ops[0] == "BX" || ops[0] == "BH")
                        {
                            BH = Convert.ToByte(Limits(ops[0], ops[1]));
                        }
                        else if (ops[0] == "BL")
                        {
                            BL = Convert.ToByte(Limits(ops[0], ops[1]));
                        }
                        else if (ops[0] == "CX" || ops[0] == "CH")
                        {
                            CH = Convert.ToByte(Limits(ops[0], ops[1]));
                        }
                        else if (ops[0] == "CL")
                        {
                            CL = Convert.ToByte(Limits(ops[0], ops[1]));
                        }
                        else if (ops[0] == "DX" || ops[0] == "DH")
                        {
                            DH = Convert.ToByte(Limits(ops[0], ops[1]));
                        }
                        else if (ops[0] == "DL")
                        {
                            DL = Convert.ToByte(Limits(ops[0], ops[1]));
                        }
                        else if (ops[0] == "SP")
                        {
                            SP = Convert.ToInt16(Limits(ops[0], ops[1]));
                        }
                        else if (ops[0] == "BP")
                        {
                            BP = Convert.ToInt16(Limits(ops[0], ops[1]));
                        }
                        else if (ops[0] == "SI")
                        {
                            SI = Convert.ToInt16(Limits(ops[0], ops[1]));
                        }
                        else if (ops[0] == "DI")
                        {
                            DI = Convert.ToInt16(Limits(ops[0], ops[1]));
                        }
                        else if (ops[0] == "IP")
                        {
                            IP = Convert.ToInt16(Limits(ops[0], ops[1]));
                        }
                    }
                    else if ( Is_register(ops[0]) && (Is_register(ops[1]) || ops[1] == "mem") )
                    {
                        if (ops[0] == "AX" || ops[0] == "AH")
                        {
                            if (ops[1] == "BX") { AH = Convert.ToByte(BH + BL); }
                            else if (ops[1] == "BH") { AH = BH; }
                            else if (ops[1] == "BL") { AH = BL; }
                            else if (ops[1] == "CX") { AH = Convert.ToByte(CH + CL); }
                            else if (ops[1] == "CH") { AH = CH; }
                            else if (ops[1] == "CL") { AH = CL; }
                            else if (ops[1] == "DX") { AH = Convert.ToByte(DH + DL); }
                            else if (ops[1] == "DH") { AH = DH; }
                            else if (ops[1] == "DL") { AH = DL; }
                            else if (ops[1] == "SP") { AH = Convert.ToByte(SP); }
                            else if (ops[1] == "BP") { AH = Convert.ToByte(BP); }
                            else if (ops[1] == "SI") { AH = Convert.ToByte(SI); }
                            else if (ops[1] == "DI") { AH = Convert.ToByte(DI); }
                            else if (ops[1] == "IP") { AH = Convert.ToByte(IP); }
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
                            else if (ops[1] == "SP") { AL = Convert.ToByte(SP); }
                            else if (ops[1] == "BP") { AL = Convert.ToByte(BP); }
                            else if (ops[1] == "SI") { AL = Convert.ToByte(SI); }
                            else if (ops[1] == "DI") { AL = Convert.ToByte(DI); }
                            else if (ops[1] == "IP") { AL = Convert.ToByte(IP); }
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
                            else if (ops[1] == "SP") { BH = Convert.ToByte(SP); }
                            else if (ops[1] == "BP") { BH = Convert.ToByte(BP); }
                            else if (ops[1] == "SI") { BH = Convert.ToByte(SI); }
                            else if (ops[1] == "DI") { BH = Convert.ToByte(DI); }
                            else if (ops[1] == "IP") { BH = Convert.ToByte(IP); }
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
                            else if (ops[1] == "SP") { BL = Convert.ToByte(SP); }
                            else if (ops[1] == "BP") { BL = Convert.ToByte(BP); }
                            else if (ops[1] == "SI") { BL = Convert.ToByte(SI); }
                            else if (ops[1] == "DI") { BL = Convert.ToByte(DI); }
                            else if (ops[1] == "IP") { BL = Convert.ToByte(IP); }
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
                            else if (ops[1] == "SP") { CH = Convert.ToByte(SP); }
                            else if (ops[1] == "BP") { CH = Convert.ToByte(BP); }
                            else if (ops[1] == "SI") { CH = Convert.ToByte(SI); }
                            else if (ops[1] == "DI") { CH = Convert.ToByte(DI); }
                            else if (ops[1] == "IP") { CH = Convert.ToByte(IP); }
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
                            else if (ops[1] == "SP") { CL = Convert.ToByte(SP); }
                            else if (ops[1] == "BP") { CL = Convert.ToByte(BP); }
                            else if (ops[1] == "SI") { CL = Convert.ToByte(SI); }
                            else if (ops[1] == "DI") { CL = Convert.ToByte(DI); }
                            else if (ops[1] == "IP") { CL = Convert.ToByte(IP); }
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
                            else if (ops[1] == "SP") { DH = Convert.ToByte(SP); }
                            else if (ops[1] == "BP") { DH = Convert.ToByte(BP); }
                            else if (ops[1] == "SI") { DH = Convert.ToByte(SI); }
                            else if (ops[1] == "DI") { DH = Convert.ToByte(DI); }
                            else if (ops[1] == "IP") { DH = Convert.ToByte(IP); }
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
                            else if (ops[1] == "SP") { DL = Convert.ToByte(SP); }
                            else if (ops[1] == "BP") { DL = Convert.ToByte(BP); }
                            else if (ops[1] == "SI") { DL = Convert.ToByte(SI); }
                            else if (ops[1] == "DI") { DL = Convert.ToByte(DI); }
                            else if (ops[1] == "IP") { DL = Convert.ToByte(IP); }
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
                                else if (ops[1] == "SP") { mem = SP; }
                                else if (ops[1] == "BP") { mem = BP; }
                                else if (ops[1] == "SI") { mem = SI; }
                                else if (ops[1] == "DI") { mem = DI; }
                                else if (ops[1] == "IP") { mem = IP; }
                                else { MessageBox.Show("Probably you enter Wrong operation!"); }
                            }
                        }
                        else { MessageBox.Show("You enter Wrong operations!"); }  
                    }

                    break;

                case "PUSH":
                    if (ops.Count() != 1)
                    {
                        MessageBox.Show("Only one operand.");
                    }
                    else
                    {
                        if (Is_register(ops[0]))
                        {
                            switch(ops[0])
                            {
                                case "AX":
                                    the_stack.Push(AH);
                                    the_stack.Push(AL);
                                    break;
                                case "BX":
                                    the_stack.Push(BH);
                                    the_stack.Push(BL);
                                    break;
                                case "CX":
                                    the_stack.Push(CH);
                                    the_stack.Push(CL);
                                    break;
                                case "DX":
                                    the_stack.Push(DH);
                                    the_stack.Push(DL);
                                    break;
                                default:
                                    MessageBox.Show("Wrong operand.");
                                    break;
                            }
                        }
                        else
                        {
                            the_stack.Push(Convert.ToInt16(ops[0]));
                        }
                    }
                    SP = Convert.ToInt16(the_stack.Count);

                    break;
                case "PUSHF":

                    SP = Convert.ToInt16(the_stack.Count);

                    break;

                case "POP":
                    the_stack.Pop();
                    SP = Convert.ToInt16(the_stack.Count);

                    break;

                case "POPF":

                    SP = Convert.ToInt16(the_stack.Count);

                    break;
                case "XCHG":
                    if(Is_register(ops[0]) && Is_register(ops[1]))
                    {
                        if (ops[0] == "AX" || ops[0] == "AH")
                        {
                            if (ops[1] == "AL")
                            {
                                (AH, AL) = (AL, AH);
                            }
                            else if (ops[1] == "BX" || ops[1] == "BH")
                            {
                                (AH, BH) = (BH, AH);
                            }
                            else if (ops[1] == "BL")
                            {
                                (AH, BL) = (BL, AH);
                            }
                            else if (ops[1] == "CX" || ops[1] == "CH")
                            {
                                (AH, CH) = (CH, AH);
                            }
                            else if (ops[1] == "CL")
                            {
                                (AH, CL) = (CL, AH);
                            }
                            else if (ops[1] == "DX" || ops[1] == "DH")
                            {
                                (AH, DH) = (DH, AH);
                            }
                            else if (ops[1] == "DL")
                            {
                                (AH, DL) = (DL, AH);
                            }
                            else if (ops[1] == "SP")
                            {
                                (AH, SP) = (Convert.ToByte(SP), AH);
                            }
                            else if (ops[1] == "BP")
                            {
                                (AH, BP) = (Convert.ToByte(BP), AH);
                            }
                            else if (ops[1] == "IP")
                            {
                                (AH, IP) = (Convert.ToByte(IP), AH);
                            }
                            else if (ops[1] == "SI")
                            {
                                (AH, SI) = (Convert.ToByte(SI), AH);
                            }
                            else if (ops[1] == "DI")
                            {
                                (AH, DI) = (Convert.ToByte(DI), AH);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                        else if (ops[0] == "AL")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                (AL, AH) = (AH, AL);
                            }
                            else if (ops[1] == "BX" || ops[1] == "BH")
                            {
                                (AL, BH) = (BH, AL);
                            }
                            else if (ops[1] == "BL")
                            {
                                (AL, BL) = (BL, AL);
                            }
                            else if (ops[1] == "CX" || ops[1] == "CH")
                            {
                                (AL, CH) = (CH, AL);
                            }
                            else if (ops[1] == "CL")
                            {
                                (AL, CL) = (CL, AL);
                            }
                            else if (ops[1] == "DX" || ops[1] == "DH")
                            {
                                (AL, DH) = (DH, AL);
                            }
                            else if (ops[1] == "DL")
                            {
                                (AL, DL) = (DL, AL);
                            }
                            else if (ops[1] == "SP")
                            {
                                (AL, SP) = (Convert.ToByte(SP), AL);
                            }
                            else if (ops[1] == "BP")
                            {
                                (AL, BP) = (Convert.ToByte(BP), AL);
                            }
                            else if (ops[1] == "IP")
                            {
                                (AL, IP) = (Convert.ToByte(IP), AL);
                            }
                            else if (ops[1] == "SI")
                            {
                                (AL, SI) = (Convert.ToByte(SI), AL);
                            }
                            else if (ops[1] == "DI")
                            {
                                (AL, DI) = (Convert.ToByte(DI), AL);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                        else if (ops[0] == "BX" || ops[0] == "BH")
                        {
                            if (ops[1] == "AX" || ops[1] == "BH")
                            {
                                (BH, AH) = (AH, BH);
                            }
                            else if (ops[1] == "AL")
                            {
                                (BH, AL) = (AL, BH);
                            }
                            else if (ops[1] == "BL")
                            {
                                (BH, BL) = (BL, BH);
                            }
                            else if (ops[1] == "CX" || ops[1] == "CH")
                            {
                                (BH, CH) = (CH, BH);
                            }
                            else if (ops[1] == "CL")
                            {
                                (BH, CL) = (CL, BH);
                            }
                            else if (ops[1] == "DX" || ops[1] == "DH")
                            {
                                (BH, DH) = (DH, BH);
                            }
                            else if (ops[1] == "DL")
                            {
                                (BH, DL) = (DL, BH);
                            }
                            else if (ops[1] == "SP")
                            {
                                (BH, SP) = (Convert.ToByte(SP), BH);
                            }
                            else if (ops[1] == "BP")
                            {
                                (BH, BP) = (Convert.ToByte(BP), BH);
                            }
                            else if (ops[1] == "IP")
                            {
                                (BH, IP) = (Convert.ToByte(IP), BH);
                            }
                            else if (ops[1] == "SI")
                            {
                                (BH, SI) = (Convert.ToByte(SI), BH);
                            }
                            else if (ops[1] == "DI")
                            {
                                (BH, DI) = (Convert.ToByte(DI), BH);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                        else if (ops[0] == "BL")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                (BL, AH) = (AH, BL);
                            }
                            if (ops[1] == "AL")
                            {
                                (BL, AL) = (AL, BL);
                            }
                            else if (ops[1] == "BX" || ops[1] == "BH")
                            {
                                (BL, BH) = (BH, BL);
                            }
                            else if (ops[1] == "CX" || ops[1] == "CH")
                            {
                                (BL, CH) = (CH, BL);
                            }
                            else if (ops[1] == "CL")
                            {
                                (BL, CL) = (CL, BL);
                            }
                            else if (ops[1] == "DX" || ops[1] == "DH")
                            {
                                (BL, DH) = (DH, BL);
                            }
                            else if (ops[1] == "DL")
                            {
                                (BL, DL) = (DL, BL);
                            }
                            else if (ops[1] == "SP")
                            {
                                (BL, SP) = (Convert.ToByte(SP), BL);
                            }
                            else if (ops[1] == "BP")
                            {
                                (BL, BP) = (Convert.ToByte(BP), BL);
                            }
                            else if (ops[1] == "IP")
                            {
                                (BL, IP) = (Convert.ToByte(IP), BL);
                            }
                            else if (ops[1] == "SI")
                            {
                                (BL, SI) = (Convert.ToByte(SI), BL);
                            }
                            else if (ops[1] == "DI")
                            {
                                (BL, DI) = (Convert.ToByte(DI), BL);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                        else if (ops[0] == "CX" || ops[0] == "CH")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                (CH, AH) = (AH, CH);
                            }
                            else if (ops[1] == "AL")
                            {
                                (CH, AL) = (AL, CH);
                            }
                            else if (ops[1] == "BX" || ops[1] == "BH")
                            {
                                (CH, BH) = (BH, CH);
                            }
                            else if (ops[1] == "BL")
                            {
                                (CH, BL) = (BL, CH);
                            }
                            else if (ops[1] == "CL")
                            {
                                (CH, CL) = (CL, CH);
                            }
                            else if (ops[1] == "DX" || ops[1] == "DH")
                            {
                                (CH, DH) = (DH, CH);
                            }
                            else if (ops[1] == "DL")
                            {
                                (CH, DL) = (DL, CH);
                            }
                            else if (ops[1] == "SP")
                            {
                                (CH, SP) = (Convert.ToByte(SP), CH);
                            }
                            else if (ops[1] == "BP")
                            {
                                (CH, BP) = (Convert.ToByte(BP), CH);
                            }
                            else if (ops[1] == "IP")
                            {
                                (CH, IP) = (Convert.ToByte(IP), CH);
                            }
                            else if (ops[1] == "SI")
                            {
                                (CH, SI) = (Convert.ToByte(SI), CH);
                            }
                            else if (ops[1] == "DI")
                            {
                                (CH, DI) = (Convert.ToByte(DI), CH);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                        else if (ops[0] == "CL")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                (CL, AH) = (AH, CL);
                            }
                            if (ops[1] == "AL")
                            {
                                (CL, AL) = (AL, CL);
                            }
                            else if (ops[1] == "BX" || ops[1] == "BH")
                            {
                                (CL, BH) = (BH, CL);
                            }
                            else if (ops[1] == "CX" || ops[1] == "CH")
                            {
                                (CL, CH) = (CH, CL);
                            }
                            else if (ops[1] == "DX" || ops[1] == "DH")
                            {
                                (CL, DH) = (DH, CL);
                            }
                            else if (ops[1] == "DL")
                            {
                                (CL, DL) = (DL, CL);
                            }
                            else if (ops[1] == "SP")
                            {
                                (CL, SP) = (Convert.ToByte(SP), CL);
                            }
                            else if (ops[1] == "BP")
                            {
                                (CL, BP) = (Convert.ToByte(BP), CL);
                            }
                            else if (ops[1] == "IP")
                            {
                                (CL, IP) = (Convert.ToByte(IP), CL);
                            }
                            else if (ops[1] == "SI")
                            {
                                (CL, SI) = (Convert.ToByte(SI), CL);
                            }
                            else if (ops[1] == "DI")
                            {
                                (CL, DI) = (Convert.ToByte(DI), CL);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                        else if (ops[0] == "DX" || ops[0] == "DH")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                (DH, AH) = (AH, DH);
                            }
                            else if (ops[1] == "AL")
                            {
                                (DH, AL) = (AL, DH);
                            }
                            else if (ops[1] == "BX" || ops[1] == "BH")
                            {
                                (DH, BH) = (BH, DH);
                            }
                            else if (ops[1] == "BL")
                            {
                                (DH, BL) = (BL, DH);
                            }
                            else if (ops[1] == "CX" || ops[1] == "CH")
                            {
                                (DH, CH) = (CH, DH);
                            }
                            else if (ops[1] == "CL")
                            {
                                (DH, CL) = (CL, DH);
                            }
                            else if (ops[1] == "DL")
                            {
                                (DH, DL) = (DL, DH);
                            }
                            else if (ops[1] == "SP")
                            {
                                (DH, SP) = (Convert.ToByte(SP), DH);
                            }
                            else if (ops[1] == "BP")
                            {
                                (DH, BP) = (Convert.ToByte(BP), DH);
                            }
                            else if (ops[1] == "IP")
                            {
                                (DH, IP) = (Convert.ToByte(IP), DH);
                            }
                            else if (ops[1] == "SI")
                            {
                                (DH, SI) = (Convert.ToByte(SI), DH);
                            }
                            else if (ops[1] == "DI")
                            {
                                (DH, DI) = (Convert.ToByte(DI), DH);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                        else if (ops[0] == "DL")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                (DL, AH) = (AH, DL);
                            }
                            if (ops[1] == "AL")
                            {
                                (DL, AL) = (AL, DL);
                            }
                            else if (ops[1] == "BX" || ops[1] == "BH")
                            {
                                (DL, BH) = (BH, DL);
                            }
                            else if (ops[1] == "BL")
                            {
                                (DL, BL)  = (BL, DL);
                            }
                            else if (ops[1] == "CX" || ops[1] == "CH")
                            {
                                (DL, CH) = (CH, DL);
                            }
                            else if (ops[1] == "CL")
                            {
                                (DL, CL) = (CL, DL);
                            }
                            else if (ops[1] == "DX" || ops[1] == "DH")
                            {
                                (DL, DH) = (DH, DL);
                            }
                            else if (ops[1] == "SP")
                            {
                                (DL, SP) = (Convert.ToByte(SP), DL);
                            }
                            else if (ops[1] == "BP")
                            {
                                (DL, BP) = (Convert.ToByte(BP), DL);
                            }
                            else if (ops[1] == "IP")
                            {
                                (DL, IP) = (Convert.ToByte(IP), DL);
                            }
                            else if (ops[1] == "SI")
                            {
                                (DL, SI) = (Convert.ToByte(SI), DL);
                            }
                            else if (ops[1] == "DI")
                            {
                                (DL, DI) = (Convert.ToByte(DI), DL);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                        else if (ops[0] == "IP")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                (IP, AH) = (AH, Convert.ToByte(IP));
                            }
                            if (ops[1] == "AL")
                            {
                                (IP, AL) = (AL, Convert.ToByte(IP));
                            }
                            else if (ops[1] == "BX" || ops[1] == "BH")
                            {
                                (IP, BH) = (BH, Convert.ToByte(IP));
                            }
                            else if (ops[1] == "BL")
                            {
                                (IP, BL) = (BL, Convert.ToByte(IP));
                            }
                            else if (ops[1] == "CX" || ops[1] == "CH")
                            {
                                (IP, CH) = (CH, Convert.ToByte(IP));
                            }
                            else if (ops[1] == "CL")
                            {
                                (IP, CL) = (CL, Convert.ToByte(IP));
                            }
                            else if (ops[1] == "DX" || ops[1] == "DH")
                            {
                                (IP, DH) = (DH, Convert.ToByte(IP));
                            }
                            else if (ops[1] == "DL")
                            {
                                (IP, DL) = (DL, Convert.ToByte(IP));
                            }
                            else if (ops[1] == "SP")
                            {
                                (IP, SP) = (SP, IP);
                            }
                            else if (ops[1] == "BP")
                            {
                                (IP, BP) = (BP, IP);
                            }
                            else if (ops[1] == "SI")
                            {
                                (IP, SI) = (SI, IP);
                            }
                            else if (ops[1] == "DI")
                            {
                                (IP, DI) = (DI, IP);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                        else if (ops[0] == "SP")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                (SP, AH) = (AH, Convert.ToByte(SP));
                            }
                            if (ops[1] == "AL")
                            {
                                (SP, AL) = (AL, Convert.ToByte(SP));
                            }
                            else if (ops[1] == "BX" || ops[1] == "BH")
                            {
                                (SP, BH) = (BH, Convert.ToByte(SP));
                            }
                            else if (ops[1] == "BL")
                            {
                                (SP, BL) = (BL, Convert.ToByte(SP));
                            }
                            else if (ops[1] == "CX" || ops[1] == "CH")
                            {
                                (SP, CH) = (CH, Convert.ToByte(SP));
                            }
                            else if (ops[1] == "CL")
                            {
                                (SP, CL) = (CL, Convert.ToByte(SP));
                            }
                            else if (ops[1] == "DX" || ops[1] == "DH")
                            {
                                (SP, DH) = (DH, Convert.ToByte(SP));
                            }
                            else if (ops[1] == "DL")
                            {
                                (SP, DL) = (DL, Convert.ToByte(SP));
                            }
                            else if (ops[1] == "IP")
                            {
                                (SP, IP) = (IP, SP);
                            }
                            else if (ops[1] == "BP")
                            {
                                (SP, BP) = (BP, SP);
                            }
                            else if (ops[1] == "SI")
                            {
                                (SP, SI) = (SI, SP);
                            }
                            else if (ops[1] == "DI")
                            {
                                (SP, DI) = (DI, SP);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                        else if (ops[0] == "BP")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                (BP, AH) = (AH, Convert.ToByte(BP));
                            }
                            if (ops[1] == "AL")
                            {
                                (BP, AL) = (AL, Convert.ToByte(BP));
                            }
                            else if (ops[1] == "BX" || ops[1] == "BH")
                            {
                                (BP, BH) = (BH, Convert.ToByte(BP));
                            }
                            else if (ops[1] == "BL")
                            {
                                (BP, BL) = (BL, Convert.ToByte(BP));
                            }
                            else if (ops[1] == "CX" || ops[1] == "CH")
                            {
                                (BP, CH) = (CH, Convert.ToByte(BP));
                            }
                            else if (ops[1] == "CL")
                            {
                                (BP, CL) = (CL, Convert.ToByte(BP));
                            }
                            else if (ops[1] == "DX" || ops[1] == "DH")
                            {
                                (BP, DH) = (DH, Convert.ToByte(BP));
                            }
                            else if (ops[1] == "DL")
                            {
                                (BP, DL) = (DL, Convert.ToByte(BP));
                            }
                            else if (ops[1] == "SP")
                            {
                                (BP, SP) = (SP, BP);
                            }
                            else if (ops[1] == "IP")
                            {
                                (BP, IP) = (IP, BP);
                            }
                            else if (ops[1] == "SI")
                            {
                                (BP, SI) = (SI, BP);
                            }
                            else if (ops[1] == "DI")
                            {
                                (BP, DI) = (DI, BP);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                        else if (ops[0] == "SI")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                (SI, AH) = (AH, Convert.ToByte(SI));
                            }
                            if (ops[1] == "AL")
                            {
                                (SI, AL) = (AL, Convert.ToByte(SI));
                            }
                            else if (ops[1] == "BX" || ops[1] == "BH")
                            {
                                (SI, BH) = (BH, Convert.ToByte(SI));
                            }
                            else if (ops[1] == "BL")
                            {
                                (SI, BL) = (BL, Convert.ToByte(SI));
                            }
                            else if (ops[1] == "CX" || ops[1] == "CH")
                            {
                                (SI, CH) = (CH, Convert.ToByte(SI));
                            }
                            else if (ops[1] == "CL")
                            {
                                (SI, CL) = (CL, Convert.ToByte(SI));
                            }
                            else if (ops[1] == "DX" || ops[1] == "DH")
                            {
                                (SI, DH) = (DH, Convert.ToByte(SI));
                            }
                            else if (ops[1] == "DL")
                            {
                                (SI, DL) = (DL, Convert.ToByte(SI));
                            }
                            else if (ops[1] == "SP")
                            {
                                (SI, SP) = (SP, SI);
                            }
                            else if (ops[1] == "BP")
                            {
                                (SI, BP) = (BP, SI);
                            }
                            else if (ops[1] == "IP")
                            {
                                (SI, IP) = (IP, SI);
                            }
                            else if (ops[1] == "DI")
                            {
                                (SI, DI) = (DI, SI);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                        else if (ops[0] == "DI")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                (DI, AH) = (AH, Convert.ToByte(DI));
                            }
                            if (ops[1] == "AL")
                            {
                                (DI, AL) = (AL, Convert.ToByte(DI));
                            }
                            else if (ops[1] == "BX" || ops[1] == "BH")
                            {
                                (DI, BH) = (BH, Convert.ToByte(DI));
                            }
                            else if (ops[1] == "BL")
                            {
                                (DI, BL) = (BL, Convert.ToByte(DI));
                            }
                            else if (ops[1] == "CX" || ops[1] == "CH")
                            {
                                (DI, CH) = (CH, Convert.ToByte(DI));
                            }
                            else if (ops[1] == "CL")
                            {
                                (DI, CL) = (CL, Convert.ToByte(DI));
                            }
                            else if (ops[1] == "DX" || ops[1] == "DH")
                            {
                                (DI, DH) = (DH, Convert.ToByte(DI));
                            }
                            else if (ops[1] == "DL")
                            {
                                (DI, DL) = (DL, Convert.ToByte(DI));
                            }
                            else if (ops[1] == "SP")
                            {
                                (DI, SP) = (SP, DI);
                            }
                            else if (ops[1] == "BP")
                            {
                                (DI, BP) = (BP, DI);
                            }
                            else if (ops[1] == "SI")
                            {
                                (DI, SI) = (SI, DI);
                            }
                            else if (ops[1] == "DI")
                            {
                                (DI, IP) = (IP, DI);
                            }
                            else { MessageBox.Show("Nothing happend if you swap the same registers."); }
                        }
                    }
                    else { MessageBox.Show("You need to specify two registers."); }

                    break;
                case "LEA":

                    break;
                case "LAHF":

                    break;
                case "SAHF":

                    break;

                // ARITHMETIC

                case "ADD":
                    if (ops.Count() == 2)
                    {
                        Arithmetics(ops, '+');
                    }
                    else
                    {
                        MessageBox.Show("You are obligated to enter two operands.");
                    }

                    break;
                case "SUB":
                    if (ops.Count() == 2)
                    {
                        Arithmetics(ops, '-');
                    }
                    else
                    {
                        MessageBox.Show("You are obligated to enter two operands.");
                    }

                    break;
                case "MUL":
                    if (ops.Count() == 2)
                    {
                        Arithmetics(ops, '*');
                    }
                    else
                    {
                        MessageBox.Show("You are obligated to enter two operands.");
                    }

                    break;
                case "DIV":
                    if (ops.Count() == 2)
                    {
                        Arithmetics(ops, '/');
                    }
                    else
                    {
                        MessageBox.Show("You are obligated to enter two operands.");
                    }

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
                case "IP":
                    return true;

                case "CS":
                    return true;
                case "DS":
                    return true;
                case "SS":
                    return true;
                case "ES":
                    return true;

                default:
                    return false;
            }
        }

        private void Print()
        {
            Stack_box.Text = "AX\t=\t" + (AH + AL);
            Stack_box.Text += "\nBX\t=\t" + (BH + BL);
            Stack_box.Text += "\nCX\t=\t" + (CH + CL);
            Stack_box.Text += "\nDX\t=\t" + (DH + DL);

            Stack_box.Text += "\n\nSP\t=\t" + SP;
            Stack_box.Text += "\nBP\t=\t" + BP;
            Stack_box.Text += "\nIP\t=\t" + IP;
            Stack_box.Text += "\nSI\t=\t" + SI;
            Stack_box.Text += "\nDI\t=\t" + DI;

            Stack_box.Text += "\n\nMemory\t=\t" + mem;

            Stack_box.Text += "\nStack:\n";

            foreach (var x in the_stack)
            {
                Stack_box.Text += " " + x;
            }
        }

        private short Limits(string ops ,string n)  // TO MOV
        {
            short numb = Convert.ToInt16(n);

            if (ops == "AX" || ops == "AH" || ops == "AL" || ops == "BX" || ops == "BH" || ops == "BL" || ops == "CX" || ops == "CH" || ops == "CL" || ops == "DX" || ops == "DH" || ops == "DL")
            {
                if (numb > 127) { numb %= 127; OF = true; }
                else if (numb < 0) { numb += 127; OF = true; }
            }
            else
            {
                if (numb > 255) { numb %= 255; OF = true; }
                else if (numb < 0) { numb += 255; OF = true; }
            }

            return numb;
        }

        private byte Flag_reg(bool O, bool D, bool I, bool T, bool S, bool Z, bool AC, bool P, bool CY)
        {
            string flags = "";

            return Convert.ToByte(flags);
        }

        private void Arithmetics(List<string> ops, char operation)
        {
            if (Is_register(ops[0]) && !Is_register(ops[1]))
            {
                if (ops[0] == "AX" || ops[0] == "AH") { if (ops[1] == "mem") { AL += Convert.ToByte(mem); } else { AL += Convert.ToByte(ops[1]); } }
                else if (ops[0] == "AL") { if (ops[1] == "mem") { AL += Convert.ToByte(mem); } else { AL += Convert.ToByte(ops[1]); } }
                else if (ops[0] == "BX" || ops[0] == "BH") { if (ops[1] == "mem") { BH += Convert.ToByte(mem); } else { BH += Convert.ToByte(ops[1]); } }
                else if (ops[0] == "BL") { if (ops[1] == "mem") { BL += Convert.ToByte(mem); } else { BL += Convert.ToByte(ops[1]); } }
                else if (ops[0] == "CX" || ops[0] == "CH") { if (ops[1] == "mem") { CH += Convert.ToByte(mem); } else { CH += Convert.ToByte(ops[1]); } }
                else if (ops[0] == "CL") { if (ops[1] == "mem") { CL += Convert.ToByte(mem); } else { CL += Convert.ToByte(ops[1]); } }
                else if (ops[0] == "DX" || ops[0] == "DH") { if (ops[1] == "mem") { DH += Convert.ToByte(mem); } else { DH += Convert.ToByte(ops[1]); } }
                else if (ops[0] == "DL") { if (ops[1] == "mem") { DL += Convert.ToByte(mem); } else { DL += Convert.ToByte(ops[1]); } }
            }
            else if (Is_register(ops[0]) && Is_register(ops[1]))
            {
                if (ops[0] == "AX" || ops[0] == "AH")
                {
                    if (ops[1] == "AL") { AH += AL; }
                    else if (ops[1] == "BX" || ops[1] == "BH") { AH += BH; }
                    else if (ops[1] == "BL") { AH += BL; }
                    else if (ops[1] == "CX" || ops[1] == "CH") { AH += CH; }
                    else if (ops[1] == "CL") { AH += CL; }
                    else if (ops[1] == "DX" || ops[1] == "DH") { AH += DH; }
                    else if (ops[1] == "DL") { AH += DL; }
                    else { MessageBox.Show("Wrong operands."); }
                }
                else if (ops[0] == "AL")
                {
                    if (ops[1] == "AX" || ops[1] == "AH") { AL += AH; }
                    else if (ops[1] == "BX" || ops[1] == "BH") { AL += BH; }
                    else if (ops[1] == "BL") { AL += BL; }
                    else if (ops[1] == "CX" || ops[1] == "CH") { AL += CH; }
                    else if (ops[1] == "CL") { AL += CL; }
                    else if (ops[1] == "DX" || ops[1] == "DH") { AL += DH; }
                    else if (ops[1] == "DL") { AL += DL; }
                    else { MessageBox.Show("Wrong operands."); }
                }
                else if (ops[0] == "BX" || ops[0] == "BH")
                {
                    if (ops[1] == "AX" || ops[1] == "AH") { BH += AH; }
                    else if (ops[1] == "AL") { BH += AL; }
                    else if (ops[1] == "BL") { BH += BL; }
                    else if (ops[1] == "CX" || ops[1] == "CH") { BH += CH; }
                    else if (ops[1] == "CL") { BH += CL; }
                    else if (ops[1] == "DX" || ops[1] == "DH") { BH += DH; }
                    else if (ops[1] == "DL") { BH += DL; }
                    else { MessageBox.Show("Wrong operands."); }
                }
                else if (ops[0] == "BL")
                {
                    if (ops[1] == "AX" || ops[1] == "AH") { BL += AH; }
                    else if (ops[1] == "AL") { BL += BL; }
                    else if (ops[1] == "BX" || ops[1] == "BH") { BL += BH; }
                    else if (ops[1] == "CX" || ops[1] == "CH") { BL += CH; }
                    else if (ops[1] == "CL") { BL += CL; }
                    else if (ops[1] == "DX" || ops[1] == "DH") { BL += DH; }
                    else if (ops[1] == "DL") { BL += DL; }
                    else { MessageBox.Show("Wrong operands."); }
                }
                else if (ops[0] == "CX" || ops[0] == "CH")
                {
                    if (ops[1] == "AX" || ops[1] == "AH") { CH += AH; }
                    else if (ops[1] == "AL") { CH += AL; }
                    else if (ops[1] == "BX" || ops[1] == "BH") { CH += BH; }
                    else if (ops[1] == "BL") { CH += BL; }
                    else if (ops[1] == "CL") { CH += CL; }
                    else if (ops[1] == "DX" || ops[1] == "DH") { CH += DH; }
                    else if (ops[1] == "DL") { CH += DL; }
                    else { MessageBox.Show("Wrong operands."); }
                }
                else if (ops[0] == "CL")
                {
                    if (ops[1] == "AX" || ops[1] == "AH") { CL += AH; }
                    else if (ops[1] == "AL") { CL += AL; }
                    else if (ops[1] == "BX" || ops[1] == "BH") { CL += BH; }
                    else if (ops[1] == "BL") { CL += BL; }
                    else if (ops[1] == "CX" || ops[1] == "CH") { CL += CH; }
                    else if (ops[1] == "DX" || ops[1] == "DH") { CL += DH; }
                    else if (ops[1] == "DL") { CL += DL; }
                    else { MessageBox.Show("Wrong operands."); }
                }
                else if (ops[0] == "DX" || ops[0] == "DH")
                {
                    if (ops[1] == "AX" || ops[1] == "AH") { DH += AH; }
                    else if (ops[1] == "AL") { DH += AL; }
                    else if (ops[1] == "BX" || ops[1] == "BH") { DH += BH; }
                    else if (ops[1] == "BL") { DH += BL; }
                    else if (ops[1] == "CX" || ops[1] == "CH") { DH += CH; }
                    else if (ops[1] == "CL") { DH += CL; }
                    else if (ops[1] == "DL") { DH += DL; }
                    else { MessageBox.Show("Wrong operands."); }
                }
                else if (ops[0] == "DL")
                {
                    if (ops[1] == "AX" || ops[1] == "AH") { DL += AH; }
                    else if (ops[1] == "AL") { DL += AL; }
                    else if (ops[1] == "BX" || ops[1] == "BH") { DL += BH; }
                    else if (ops[1] == "BL") { DL += BL; }
                    else if (ops[1] == "CX" || ops[1] == "CH") { DL += CH; }
                    else if (ops[1] == "CL") { DL += CL; }
                    else if (ops[1] == "DX" || ops[1] == "DH") { DL += DH; }
                    else { MessageBox.Show("Wrong operands."); }
                }
            }
            else { MessageBox.Show("You will not see that operation in \"View\" window."); }
        }

    }
}

/*  TO DO:
 *  
 *  1. MAKE ARYTHMETIC INSTRUCTIONS
 *  3. XCHG
 *  
 */