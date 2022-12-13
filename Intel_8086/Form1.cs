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

        //short CS = 0;   // Code Segment
        //short DS = 0;   // Data Segment
        //short SS = 0;   // Stack Segment
        //short ES = 0;   // Extra Segment

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

        Stack<byte> the_stack = new Stack<byte>();

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

        // DIV --> %
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
            if (Instruction.Text == "")
            {
                MessageBox.Show("Please,\nenter a instruction!");
            }
            else
            {
                string inst = Instruction.Text;
                string ops_input = (Operation.Text).Replace(" ", "");

                List<string> ops = new List<string>(2);
                string x = "";              // helping variable
                byte last_mov_reg = 0;      // contain value of last register used in MOV --> "MOV   _this_, _sth_"

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
                Asm_operations(inst, ops, last_mov_reg);

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
            flagsReg.Text = "";
        }

        // View --> shows the contents of the register 
        private void Stack_box_TextChanged(object sender, EventArgs e)
        {

        }

        // flags --> contains flags values
        private void flagsReg_TextChanged(object sender, EventArgs e)
        {

        }

        // Following tasks

        private void Asm_operations(string inst, List<string> ops, byte last_reg_val)
        {
            switch (inst)
            {
                // DATA TRANSFER

                case "MOV":
                    if (ops.Count == 2)
                    {
                        if (Is_register(ops[0]) && !Is_register(ops[1]) && ops[1] != "mem")
                        {
                            if (ops[0] == "AX" || ops[0] == "AH")
                            {
                                AH = Convert.ToByte(Limits(ops[0], ops[1]));
                                last_reg_val = AH;
                            }
                            else if (ops[0] == "AL")
                            {
                                AL = Convert.ToByte(Limits(ops[0], ops[1]));
                                last_reg_val = AL;
                            }
                            else if (ops[0] == "BX" || ops[0] == "BH")
                            {
                                BH = Convert.ToByte(Limits(ops[0], ops[1]));
                                last_reg_val = BH;
                            }
                            else if (ops[0] == "BL")
                            {
                                BL = Convert.ToByte(Limits(ops[0], ops[1]));
                                last_reg_val = BL;
                            }
                            else if (ops[0] == "CX" || ops[0] == "CH")
                            {
                                CH = Convert.ToByte(Limits(ops[0], ops[1]));
                                last_reg_val = CH;
                            }
                            else if (ops[0] == "CL")
                            {
                                CL = Convert.ToByte(Limits(ops[0], ops[1]));
                                last_reg_val = CL;
                            }
                            else if (ops[0] == "DX" || ops[0] == "DH")
                            {
                                DH = Convert.ToByte(Limits(ops[0], ops[1]));
                                last_reg_val = DH;
                            }
                            else if (ops[0] == "DL")
                            {
                                DL = Convert.ToByte(Limits(ops[0], ops[1]));
                                last_reg_val = DL;
                            }
                            else if (ops[0] == "SP")
                            {
                                SP = Convert.ToInt16(Limits(ops[0], ops[1]));
                                last_reg_val = Convert.ToByte(SP);
                            }
                            else if (ops[0] == "BP")
                            {
                                BP = Convert.ToInt16(Limits(ops[0], ops[1]));
                                last_reg_val = Convert.ToByte(BP);
                            }
                            else if (ops[0] == "SI")
                            {
                                SI = Convert.ToInt16(Limits(ops[0], ops[1]));
                                last_reg_val = Convert.ToByte(SI);
                            }
                            else if (ops[0] == "DI")
                            {
                                DI = Convert.ToInt16(Limits(ops[0], ops[1]));
                                last_reg_val = Convert.ToByte(DI);
                            }
                            else if (ops[0] == "IP")
                            {
                                IP = Convert.ToInt16(Limits(ops[0], ops[1]));
                                last_reg_val = Convert.ToByte(IP);
                            }
                        }
                        else if (Is_register(ops[0]) && (Is_register(ops[1]) || ops[1] == "mem"))
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

                                last_reg_val = AH;
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

                                last_reg_val = AL;
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

                                last_reg_val = BH;
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

                                last_reg_val = BL;
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

                                last_reg_val = CH;
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

                                last_reg_val = CL;
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

                                last_reg_val = DH;
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

                                last_reg_val = DL;
                            }
                        }
                        else
                        {
                            if (ops[0] == "mem")
                            {
                                if (!Is_register(ops[1])) { mem = Converter_to_int16(ops[1]); }
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
                    }
                    else
                    {
                        MessageBox.Show("MOV must contain two operands.");
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

                            SP = Convert.ToInt16(the_stack.Count);
                        }
                        else
                        {
                            the_stack.Push(Convert.ToByte(ops[0]));
                        }
                    }
                    break;

                case "PUSHF":
                    the_stack.Push(Higher_byte(OF, DF, IF, TF));
                    the_stack.Push(Lower_byte(SF, ZF, AF, PF, CF));

                    SP = Convert.ToInt16(the_stack.Count - 2);
                    break;

                case "POP":
                    if (ops.Count == 1)
                    {
                        if (Is_register(ops[0]))
                        {
                            switch(ops[0])
                            {
                                case "AX":
                                    AL = the_stack.ElementAt(SP - 1);
                                    AH = the_stack.ElementAt(SP - 2);
                                    the_stack.Pop();
                                    break;
                                case "BX":
                                    BL = the_stack.ElementAt(SP - 1);
                                    BH = the_stack.ElementAt(SP - 2);
                                    the_stack.Pop();
                                    break;
                                case "CX":
                                    CL = the_stack.ElementAt(SP - 1);
                                    CH = the_stack.ElementAt(SP - 2);
                                    the_stack.Pop();
                                    break;
                                case "DX":
                                    DL = the_stack.ElementAt(SP - 1);
                                    DH = the_stack.ElementAt(SP - 2);
                                    the_stack.Pop();
                                    break;
                                default:
                                    MessageBox.Show("ONLY: AX, BX, CX, DX");
                                    break;
                            }

                            SP = Convert.ToInt16(the_stack.Count);
                        }
                        else
                        {
                            MessageBox.Show("ONLY: AX, BX, CX, DX");
                        }
                    }
                    else
                    {
                        MessageBox.Show("POP should contain one operand.");
                    }
                    break;

                case "POPF":
                    the_stack.Pop();
                    the_stack.Pop();

                    SP = Convert.ToInt16(the_stack.Count);
                    break;

                case "XCHG":
                    if (ops.Count == 2)
                    {
                        if (Is_register(ops[0]) && Is_register(ops[1]))
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
                                    (DL, BL) = (BL, DL);
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
                    }
                    else
                    {
                        MessageBox.Show("XCHG must contain two operands.");
                    }
                    break;

                case "LEA":
                    if (ops.Count > 1 && ops[1] == "mem")
                    {
                        unsafe
                        {
                            Int64 z = mem;
                            Int64* x = &z;

                            MessageBox.Show("Offset: " + Convert.ToString((long)x, 16));

                            if (ops[0] == "AH" || ops[0] == "AX")
                            {
                                AH = Convert.ToByte((byte)x);
                            }
                            else if (ops[0] == "AL")
                            {
                                AL = Convert.ToByte((byte)x);
                            }
                            else if (ops[0] == "BH" || ops[0] == "BX")
                            {
                                BH = Convert.ToByte((byte)x);
                            }
                            else if (ops[0] == "BL")
                            {
                                BL = Convert.ToByte((byte)x);
                            }
                            else if (ops[0] == "CH" || ops[0] == "CX")
                            {
                                CH = Convert.ToByte((byte)x);
                            }
                            else if (ops[0] == "CL")
                            {
                                CL = Convert.ToByte((byte)x);
                            }
                            else if (ops[0] == "DH" || ops[0] == "DX")
                            {
                                DH = Convert.ToByte((byte)x);
                            }
                            else if (ops[0] == "DL")
                            {
                                DL = Convert.ToByte((byte)x);
                            }
                            else if (ops[0] == "SP") { SP = Convert.ToByte((byte)x); }
                            else if (ops[0] == "BP") { BP = Convert.ToByte((byte)x); }
                            else if (ops[0] == "IP") { IP = Convert.ToByte((byte)x); }
                            else if (ops[0] == "DI") { DI = Convert.ToByte((byte)x); }
                            else if (ops[0] == "SI") { SI = Convert.ToByte((byte)x); }
                            else { MessageBox.Show("Wrong operand!"); }
                        }
                    }
                    else { MessageBox.Show("Use -->\n{LEA   REG, mem}"); }
                    break;

                case "LAHF":
                    AH = Lower_byte(SF, ZF, AF, PF, CF);
                    break;

                case "SAHF":
                    Store(AH);
                    break;

                // ARITHMETIC

                case "ADD":
                    if (ops.Count() == 2)
                    {
                        if (Is_register(ops[0]) && !Is_register(ops[1]))
                        {
                            byte second_param;

                            if (ops[0] == "AX" || ops[0] == "AH")
                            {
                                if (ops[1] == "mem")
                                { AH = Limits_arith(AH, Convert.ToByte(mem), '+'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); AH = Limits_arith(AH, second_param, '+'); }
                            }
                            else if (ops[0] == "AL")
                            {
                                if (ops[1] == "mem")
                                { AL = Limits_arith(AL, Convert.ToByte(mem), '+'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); AL = Limits_arith(AL, second_param, '+'); }
                            }
                            else if (ops[0] == "BX" || ops[0] == "BH")
                            {
                                if (ops[1] == "mem")
                                { BH = Limits_arith(BH, Convert.ToByte(mem), '+'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); BH = Limits_arith(BH, second_param, '+'); }
                            }
                            else if (ops[0] == "BL")
                            {
                                if (ops[1] == "mem")
                                { BL = Limits_arith(BL, Convert.ToByte(mem), '+'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); BL = Limits_arith(BL, second_param, '+'); }
                            }
                            else if (ops[0] == "CX" || ops[0] == "CH")
                            {
                                if (ops[1] == "mem")
                                { CH = Limits_arith(CH, Convert.ToByte(mem), '+'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); CH = Limits_arith(CH, second_param, '+'); }
                            }
                            else if (ops[0] == "CL")
                            {
                                if (ops[1] == "mem")
                                { CL = Limits_arith(CL, Convert.ToByte(mem), '+'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); CL = Limits_arith(CL, second_param, '+'); }
                            }
                            else if (ops[0] == "DX" || ops[0] == "DH")
                            {
                                if (ops[1] == "mem")
                                { DH = Limits_arith(DH, Convert.ToByte(mem), '+'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); DH = Limits_arith(DH, second_param, '+'); }
                            }
                            else if (ops[0] == "DL")
                            {
                                if (ops[1] == "mem")
                                { DL = Limits_arith(DL, Convert.ToByte(mem), '+'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); DL = Limits_arith(DL, second_param, '+'); }
                            }
                        }
                        else if (Is_register(ops[0]) && Is_register(ops[1]))
                        {
                            if (ops[0] == "AX" || ops[0] == "AH")
                            {
                                if (ops[1] == "AL") { AH = Limits_arith(AH, AL, '+'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { AH = Limits_arith(AH, BH, '+'); }
                                else if (ops[1] == "BL") { AH = Limits_arith(AH, BL, '+'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { AH = Limits_arith(AH, CH, '+'); }
                                else if (ops[1] == "CL") { AH = Limits_arith(AH, CL, '+'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { AH = Limits_arith(AH, DH, '+'); }
                                else if (ops[1] == "DL") { AH = Limits_arith(AH, DL, '+'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "AL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { AL = Limits_arith(AL, AH, '+'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { AL = Limits_arith(AL, BH, '+'); }
                                else if (ops[1] == "BL") { AL = Limits_arith(AL, BL, '+'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { AL = Limits_arith(AL, CH, '+'); }
                                else if (ops[1] == "CL") { AL = Limits_arith(AL, CL, '+'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { AL = Limits_arith(AL, DH, '+'); }
                                else if (ops[1] == "DL") { AL = Limits_arith(AL, DL, '+'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "BX" || ops[0] == "BH")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { BH = Limits_arith(BH, AH, '+'); }
                                else if (ops[1] == "AL") { BH = Limits_arith(BH, AL, '+'); }
                                else if (ops[1] == "BL") { BH = Limits_arith(BH, BL, '+'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { BH = Limits_arith(BH, CH, '+'); }
                                else if (ops[1] == "CL") { BH = Limits_arith(BH, CL, '+'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { BH = Limits_arith(BH, DH, '+'); }
                                else if (ops[1] == "DL") { BH = Limits_arith(BH, DL, '+'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "BL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { BL = Limits_arith(BL, AH, '+'); }
                                else if (ops[1] == "AL") { BL = Limits_arith(BL, AL, '+'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { BL = Limits_arith(BL, BH, '+'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { BL = Limits_arith(BL, CH, '+'); }
                                else if (ops[1] == "CL") { BL = Limits_arith(BL, CL, '+'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { BL = Limits_arith(BL, DH, '+'); }
                                else if (ops[1] == "DL") { BL = Limits_arith(BL, DL, '+'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "CX" || ops[0] == "CH")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { CH = Limits_arith(CH, AH, '+'); }
                                else if (ops[1] == "AL") { CH = Limits_arith(CH, AL, '+'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { CH = Limits_arith(CH, BH, '+'); }
                                else if (ops[1] == "BL") { CH = Limits_arith(CH, BL, '+'); }
                                else if (ops[1] == "CL") { CH = Limits_arith(CH, CL, '+'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { CH = Limits_arith(CH, DH, '+'); }
                                else if (ops[1] == "DL") { CH = Limits_arith(CH, DL, '+'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "CL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { CL = Limits_arith(CL, AH, '+'); }
                                else if (ops[1] == "AL") { CL = Limits_arith(CL, AL, '+'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { CL = Limits_arith(CL, BH, '+'); }
                                else if (ops[1] == "BL") { CL = Limits_arith(CL, BL, '+'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { CL = Limits_arith(CL, CH, '+'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { CL = Limits_arith(CL, DH, '+'); }
                                else if (ops[1] == "DL") { CL = Limits_arith(CL, DL, '+'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "DX" || ops[0] == "DH")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { DH = Limits_arith(DH, AH, '+'); }
                                else if (ops[1] == "AL") { DH = Limits_arith(DH, AL, '+'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { DH = Limits_arith(DH, BH, '+'); }
                                else if (ops[1] == "BL") { DH = Limits_arith(DH, BL, '+'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { DH = Limits_arith(DH, CH, '+'); }
                                else if (ops[1] == "CL") { DH = Limits_arith(DH, CL, '+'); }
                                else if (ops[1] == "DL") { DH = Limits_arith(DH, DL, '+'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "DL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { DL = Limits_arith(DL, AH, '+'); }
                                else if (ops[1] == "AL") { DL = Limits_arith(DL, AL, '+'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { DL = Limits_arith(DL, BH, '+'); }
                                else if (ops[1] == "BL") { DL = Limits_arith(DL, BL, '+'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { DL = Limits_arith(DL, CH, '+'); }
                                else if (ops[1] == "CL") { DL = Limits_arith(DL, CL, '+'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { DL = Limits_arith(DL, DH, '+'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                        }
                        else { MessageBox.Show("You will not see that operation in \"View\" window."); }
                    }
                    else
                    {
                        MessageBox.Show("You are obligated to enter two operands.");
                    }
                    break;

                case "SUB":
                    if (ops.Count() == 2)
                    {
                        if (Is_register(ops[0]) && !Is_register(ops[1]))
                        {
                            byte second_param;

                            if (ops[0] == "AX" || ops[0] == "AH")
                            {
                                if (ops[1] == "mem")
                                { AH = Limits_arith(AH, Convert.ToByte(mem), '-'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); AH = Limits_arith(AH, second_param, '-'); }
                            }
                            else if (ops[0] == "AL")
                            {
                                if (ops[1] == "mem")
                                { AL = Limits_arith(AL, Convert.ToByte(mem), '-'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); AL = Limits_arith(AL, second_param, '-'); }
                            }
                            else if (ops[0] == "BX" || ops[0] == "BH")
                            {
                                if (ops[1] == "mem")
                                { BH = Limits_arith(BH, Convert.ToByte(mem), '-'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); BH = Limits_arith(BH, second_param, '-'); }
                            }
                            else if (ops[0] == "BL")
                            {
                                if (ops[1] == "mem")
                                { BL = Limits_arith(BL, Convert.ToByte(mem), '-'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); BL = Limits_arith(BL, second_param, '-'); }
                            }
                            else if (ops[0] == "CX" || ops[0] == "CH")
                            {
                                if (ops[1] == "mem")
                                { CH = Limits_arith(CH, Convert.ToByte(mem), '-'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); CH = Limits_arith(CH, second_param, '-'); }
                            }
                            else if (ops[0] == "CL")
                            {
                                if (ops[1] == "mem")
                                { CL = Limits_arith(CL, Convert.ToByte(mem), '-'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); CL = Limits_arith(CL, second_param, '-'); }
                            }
                            else if (ops[0] == "DX" || ops[0] == "DH")
                            {
                                if (ops[1] == "mem")
                                { DH = Limits_arith(DH, Convert.ToByte(mem), '-'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); DH = Limits_arith(DH, second_param, '-'); }
                            }
                            else if (ops[0] == "DL")
                            {
                                if (ops[1] == "mem")
                                { DL = Limits_arith(DL, Convert.ToByte(mem), '-'); }
                                else { second_param = Convert.ToByte(Converter_to_int16(ops[1])); DL = Limits_arith(DL, second_param, '-'); }
                            }
                        }
                        else if (Is_register(ops[0]) && Is_register(ops[1]))
                        {
                            if (ops[0] == "AX" || ops[0] == "AH")
                            {
                                if (ops[1] == "AL") { AH = Limits_arith(AH, AL, '-'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { AH = Limits_arith(AH, BH, '-'); }
                                else if (ops[1] == "BL") { AH = Limits_arith(AH, BL, '-'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { AH = Limits_arith(AH, CH, '-'); }
                                else if (ops[1] == "CL") { AH = Limits_arith(AH, CL, '-'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { AH = Limits_arith(AH, DH, '-'); }
                                else if (ops[1] == "DL") { AH = Limits_arith(AH, DL, '-'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "AL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { AL = Limits_arith(AL, AH, '-'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { AL = Limits_arith(AL, BH, '-'); }
                                else if (ops[1] == "BL") { AL = Limits_arith(AL, BL, '-'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { AL = Limits_arith(AL, CH, '-'); }
                                else if (ops[1] == "CL") { AL = Limits_arith(AL, CL, '-'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { AL = Limits_arith(AL, DH, '-'); }
                                else if (ops[1] == "DL") { AL = Limits_arith(AL, DL, '-'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "BX" || ops[0] == "BH")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { BH = Limits_arith(BH, AH, '-'); }
                                else if (ops[1] == "AL") { BH = Limits_arith(BH, AL, '-'); }
                                else if (ops[1] == "BL") { BH = Limits_arith(BH, BL, '-'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { BH = Limits_arith(BH, CH, '-'); }
                                else if (ops[1] == "CL") { BH = Limits_arith(BH, CL, '-'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { BH = Limits_arith(BH, DH, '-'); }
                                else if (ops[1] == "DL") { BH = Limits_arith(BH, DL, '-'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "BL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { BL = Limits_arith(BL, AH, '-'); }
                                else if (ops[1] == "AL") { BL = Limits_arith(BL, AL, '-'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { BL = Limits_arith(BL, BH, '-'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { BL = Limits_arith(BL, CH, '-'); }
                                else if (ops[1] == "CL") { BL = Limits_arith(BL, CL, '-'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { BL = Limits_arith(BL, DH, '-'); }
                                else if (ops[1] == "DL") { BL = Limits_arith(BL, DL, '-'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "CX" || ops[0] == "CH")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { CH = Limits_arith(CH, AH, '-'); }
                                else if (ops[1] == "AL") { CH = Limits_arith(CH, AL, '-'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { CH = Limits_arith(CH, BH, '-'); }
                                else if (ops[1] == "BL") { CH = Limits_arith(CH, BL, '-'); }
                                else if (ops[1] == "CL") { CH = Limits_arith(CH, CL, '-'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { CH = Limits_arith(CH, DH, '-'); }
                                else if (ops[1] == "DL") { CH = Limits_arith(CH, DL, '-'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "CL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { CL = Limits_arith(CL, AH, '-'); }
                                else if (ops[1] == "AL") { CL = Limits_arith(CL, AL, '-'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { CL = Limits_arith(CL, BH, '-'); }
                                else if (ops[1] == "BL") { CL = Limits_arith(CL, BL, '-'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { CL = Limits_arith(CL, CH, '-'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { CL = Limits_arith(CL, DH, '-'); }
                                else if (ops[1] == "DL") { CL = Limits_arith(CL, DL, '-'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "DX" || ops[0] == "DH")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { DH = Limits_arith(DH, AH, '-'); }
                                else if (ops[1] == "AL") { DH = Limits_arith(DH, AL, '-'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { DH = Limits_arith(DH, BH, '-'); }
                                else if (ops[1] == "BL") { DH = Limits_arith(DH, BL, '-'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { DH = Limits_arith(DH, CH, '-'); }
                                else if (ops[1] == "CL") { DH = Limits_arith(DH, CL, '-'); }
                                else if (ops[1] == "DL") { DH = Limits_arith(DH, DL, '-'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                            else if (ops[0] == "DL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH") { DL = Limits_arith(DL, AH, '-'); }
                                else if (ops[1] == "AL") { DL = Limits_arith(DL, AL, '-'); }
                                else if (ops[1] == "BX" || ops[1] == "BH") { DL = Limits_arith(DL, BH, '-'); }
                                else if (ops[1] == "BL") { DL = Limits_arith(DL, BL, '-'); }
                                else if (ops[1] == "CX" || ops[1] == "CH") { DL = Limits_arith(DL, CH, '-'); }
                                else if (ops[1] == "CL") { DL = Limits_arith(DL, CL, '-'); }
                                else if (ops[1] == "DX" || ops[1] == "DH") { DL = Limits_arith(DL, DH, '-'); }
                                else { MessageBox.Show("Wrong operands."); }
                            }
                        }
                        else { MessageBox.Show("You will not see that operation in \"View\" window."); }
                    }
                    else
                    {
                        MessageBox.Show("You are obligated to enter two operands.");
                    }
                    break;

                case "MUL":
                    if (ops.Count() == 1)
                    {
                        if (Is_register(ops[0]) || ops[0] == "mem")
                        {
                            if (ops[0] == "AX" || ops[0] == "AH")
                            {
                                AH = Limits_arith(AL, AH, '*');
                            }
                            else if (ops[0] == "AL")
                            {
                                AH = Limits_arith(AL, AL, '*');
                            }
                            else if (ops[0] == "BX" || ops[0] == "BH")
                            {
                                AH = Limits_arith(AL, BH, '*');
                            }
                            else if (ops[0] == "BL")
                            {
                                AH = Limits_arith(AL, BL, '*');
                            }
                            else if (ops[0] == "CX" || ops[0] == "CH")
                            {
                                AH = Limits_arith(AL, CH, '*');
                            }
                            else if (ops[0] == "CL")
                            {
                                AH = Limits_arith(AL, CL, '*');
                            }
                            else if (ops[0] == "DX" || ops[0] == "DH")
                            {
                                AH = Limits_arith(AL, DH, '*');
                            }
                            else if (ops[0] == "DL")
                            {
                                AH = Limits_arith(AL, DL, '*');
                            }
                            else
                            {
                                AH = Limits_arith(AL, Convert.ToByte(mem), '*');
                            }
                        }
                        else { MessageBox.Show("You are obligated to use registers or memory."); }
                    }
                    else
                    {
                        MessageBox.Show("You are obligated to enter only one operand.");
                    }
                    break;

                case "DIV":
                    if (ops.Count() == 1)
                    {
                        if (Is_register(ops[0]) || ops[0] == "mem")
                        {
                            byte ah = AH;       // AH value before operation;

                            if (ops[0] == "AX" || ops[0] == "AH")
                            {
                                AH = Limits_arith(AH, AH, '/');
                                DH = Limits_arith(ah, AH, '%');
                            }
                            else if (ops[0] == "AL")
                            {
                                AH = Limits_arith(AH, AL, '/');
                                DH = Limits_arith(ah, AL, '%');
                            }
                            else if (ops[0] == "BX" || ops[0] == "BH")
                            {
                                AH = Limits_arith(AH, BH, '/');
                                DH = Limits_arith(ah, BH, '%');
                            }
                            else if (ops[0] == "BL")
                            {
                                AH = Limits_arith(AH, BL, '/');
                                DH = Limits_arith(ah, BL, '%');
                            }
                            else if (ops[0] == "CX" || ops[0] == "CH")
                            {
                                AH = Limits_arith(AH, CH, '/');
                                DH = Limits_arith(ah, CH, '%');
                            }
                            else if (ops[0] == "CL")
                            {
                                AH = Limits_arith(AH, CL, '/');
                                DH = Limits_arith(ah, CL, '%');
                            }
                            else if (ops[0] == "DX" || ops[0] == "DH")
                            {
                                AH = Limits_arith(AH, DH, '/');
                                DH = Limits_arith(ah, DH, '%');
                            }
                            else if (ops[0] == "DL")
                            {
                                AH = Limits_arith(AH, DL, '/');
                                DH = Limits_arith(ah, DL, '%');
                            }
                            else
                            {
                                AH = Limits_arith(AH, Convert.ToByte(mem), '/');
                                DH = Limits_arith(ah, Convert.ToByte(mem), '%');
                            }
                        }
                        else { MessageBox.Show("You are obligated to use registers or memory."); }
                    }
                    else
                    {
                        MessageBox.Show("You are obligated to enter only one operand.");
                    }
                    break;

                case "INC":
                    if (ops.Count() == 1)
                    {
                        if (Is_register(ops[0]) || ops[0] == "mem")
                        {
                            if (ops[0] == "AX" || ops[0] == "AH")
                            {
                                AH++;
                            }
                            else if (ops[0] == "AL")
                            {
                                AL++;
                            }
                            else if (ops[0] == "BX" || ops[0] == "BH")
                            {
                                BH++;
                            }
                            else if (ops[0] == "BL")
                            {
                                BL++;
                            }
                            else if (ops[0] == "CX" || ops[0] == "CH")
                            {
                                CH++;
                            }
                            else if (ops[0] == "CL")
                            {
                                CL++;
                            }
                            else if (ops[0] == "DX" || ops[0] == "DH")
                            {
                                DH++;
                            }
                            else if (ops[0] == "DL")
                            {
                                DL++;
                            }
                            else
                            {
                                mem++;
                            }
                        }
                        else { MessageBox.Show("You are obligated to use registers or memory."); }
                    }
                    else
                    {
                        MessageBox.Show("You are obligated to enter only one operand.");
                    }
                    break;

                case "DEC":
                    if (ops.Count() == 1)
                    {
                        if (Is_register(ops[0]) || ops[0] == "mem")
                        {
                            if (ops[0] == "AX" || ops[0] == "AH")
                            {
                                AH--;
                            }
                            else if (ops[0] == "AL")
                            {
                                AL--;
                            }
                            else if (ops[0] == "BX" || ops[0] == "BH")
                            {
                                BH--;
                            }
                            else if (ops[0] == "BL")
                            {
                                BL--;
                            }
                            else if (ops[0] == "CX" || ops[0] == "CH")
                            {
                                CH--;
                            }
                            else if (ops[0] == "CL")
                            {
                                CL--;
                            }
                            else if (ops[0] == "DX" || ops[0] == "DH")
                            {
                                DH--;
                            }
                            else if (ops[0] == "DL")
                            {
                                DL--;
                            }
                            else
                            {
                                mem--;
                            }
                        }
                        else { MessageBox.Show("You are obligated to use registers or memory."); }
                    }
                    else
                    {
                        MessageBox.Show("You are obligated to enter only one operand.");
                    }
                    break;

                case "AAA":
                    if (AL > 9 || AF == true)
                    {
                        AL += 6;
                        AH++;
                        CF = true;
                        AF = true;
                    }
                    else
                    {
                        AF = false;
                        CF = false;
                    }
                    break;

                case "AAS":
                    if (AL > 9 || AF == true)
                    {
                        AL -= 6;
                        AH -= 1;
                    }
                    else
                    {
                        AF = false;
                        CF = false;
                    }
                    break;

                case "IMUL":
                    if (ops.Count() == 1)
                    {
                        if (Is_register(ops[0]) || ops[0] == "mem")
                        {
                            if (ops[0] == "AX" || ops[0] == "AH")
                            {
                                AH = Limits_arith(AL, AH, '*');
                            }
                            else if (ops[0] == "AL")
                            {
                                AH = Limits_arith(AL, AL, '*');
                            }
                            else if (ops[0] == "BX" || ops[0] == "BH")
                            {
                                AH = Limits_arith(AL, BH, '*');
                            }
                            else if (ops[0] == "BL")
                            {
                                AH = Limits_arith(AL, BL, '*');
                            }
                            else if (ops[0] == "CX" || ops[0] == "CH")
                            {
                                AH = Limits_arith(AL, CH, '*');
                            }
                            else if (ops[0] == "CL")
                            {
                                AH = Limits_arith(AL, CL, '*');
                            }
                            else if (ops[0] == "DX" || ops[0] == "DH")
                            {
                                AH = Limits_arith(AL, DH, '*');
                            }
                            else if (ops[0] == "DL")
                            {
                                AH = Limits_arith(AL, DL, '*');
                            }
                            else
                            {
                                AH = Limits_arith(AL, Convert.ToByte(mem), '*');
                            }
                        }
                        else { MessageBox.Show("You are obligated to use registers or memory."); }
                    }
                    else
                    {
                        MessageBox.Show("You are obligated to enter only one operand.");
                    }
                    break;

                case "IDIV":
                    if (ops.Count() == 1)
                    {
                        if (Is_register(ops[0]) || ops[0] == "mem")
                        {
                            byte ah = AH;       // AH value before operation;

                            if (ops[0] == "AX" || ops[0] == "AH")
                            {
                                AH = Limits_arith(AH, AH, '/');
                                DH = Limits_arith(ah, AH, '%');
                            }
                            else if (ops[0] == "AL")
                            {
                                AH = Limits_arith(AH, AL, '/');
                                DH = Limits_arith(ah, AL, '%');
                            }
                            else if (ops[0] == "BX" || ops[0] == "BH")
                            {
                                AH = Limits_arith(AH, BH, '/');
                                DH = Limits_arith(ah, BH, '%');
                            }
                            else if (ops[0] == "BL")
                            {
                                AH = Limits_arith(AH, BL, '/');
                                DH = Limits_arith(ah, BL, '%');
                            }
                            else if (ops[0] == "CX" || ops[0] == "CH")
                            {
                                AH = Limits_arith(AH, CH, '/');
                                DH = Limits_arith(ah, CH, '%');
                            }
                            else if (ops[0] == "CL")
                            {
                                AH = Limits_arith(AH, CL, '/');
                                DH = Limits_arith(ah, CL, '%');
                            }
                            else if (ops[0] == "DX" || ops[0] == "DH")
                            {
                                AH = Limits_arith(AH, DH, '/');
                                DH = Limits_arith(ah, DH, '%');
                            }
                            else if (ops[0] == "DL")
                            {
                                AH = Limits_arith(AH, DL, '/');
                                DH = Limits_arith(ah, DL, '%');
                            }
                            else
                            {
                                AH = Limits_arith(AH, Convert.ToByte(mem), '/');
                                DH = Limits_arith(ah, Convert.ToByte(mem), '%');
                            }
                        }
                        else { MessageBox.Show("You are obligated to use registers or memory."); }
                    }
                    else
                    {
                        MessageBox.Show("You are obligated to enter only one operand.");
                    }
                    break;

                // LOGICAL

                case "NOT":
                    if(ops.Count == 1 && (Is_register(ops[0]) || ops[0] == "mem"))
                    {
                        if (ops[0] == "AH" || ops[0] == "AX")
                        {
                            AH = L_NOT(Convert.ToString(AH, 2));
                        }
                        else if (ops[0] == "AL")
                        {
                            AL = L_NOT(Convert.ToString(AL, 2));
                        }
                        else if (ops[0] == "BX" || ops[0] == "BH")
                        {
                            BH = L_NOT(Convert.ToString(BH, 2));
                        }
                        else if (ops[0] == "BL")
                        {
                            BL = L_NOT(Convert.ToString(BL, 2));
                        }
                        else if (ops[0] == "CX" || ops[0] == "CH")
                        {
                            CH = L_NOT(Convert.ToString(CH, 2));
                        }
                        else if (ops[0] == "CL")
                        {
                            CL = L_NOT(Convert.ToString(CL, 2));
                        } 
                        else if (ops[0] == "DX" || ops[0] == "DH")
                        {
                            DH = L_NOT(Convert.ToString(DH, 2));
                        }
                        else if (ops[0] == "DL")
                        {
                            DL = L_NOT(Convert.ToString(DL, 2));
                        }
                        else if (ops[0] == "IP")
                        {
                            IP = L_NOT(Convert.ToString(IP, 2));
                        }
                        else if (ops[0] == "BP")
                        {
                            BP = L_NOT(Convert.ToString(BP, 2));
                        }
                        else if (ops[0] == "SP")
                        {
                            SP = L_NOT(Convert.ToString(SP, 2));
                        }
                        else if (ops[0] == "DI")
                        {
                            DI = L_NOT(Convert.ToString(DI, 2));
                        }
                        else if (ops[0] == "SI")
                        {
                            SI = L_NOT(Convert.ToString(SI, 2));
                        }
                    }
                    else { MessageBox.Show("You are allowed to enter registers or memory."); }
                    break;

                case "AND":
                    if (ops.Count == 2)
                    {
                        if (Is_register(ops[0]) && (Is_register(ops[1]) || ops[1] == "mem"))
                        {
                            if (ops[0] == "AH" || ops[0] == "AX")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    AH = L_AND(Convert.ToString(AH, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    AH = L_AND(Convert.ToString(AH, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    AH = L_AND(Convert.ToString(AH, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    AH = L_AND(Convert.ToString(AH, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    AH = L_AND(Convert.ToString(AH, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    AH = L_AND(Convert.ToString(AH, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    AH = L_AND(Convert.ToString(AH, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    AH = L_AND(Convert.ToString(AH, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    AH = L_AND(Convert.ToString(AH, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "AL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    AL = L_AND(Convert.ToString(AL, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    AL = L_AND(Convert.ToString(AL, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    AL = L_AND(Convert.ToString(AL, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    AL = L_AND(Convert.ToString(AL, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    AL = L_AND(Convert.ToString(AL, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    AL = L_AND(Convert.ToString(AL, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    AL = L_AND(Convert.ToString(AL, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    AL = L_AND(Convert.ToString(AL, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    AL = L_AND(Convert.ToString(AL, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "BH" || ops[0] == "BX")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    BH = L_AND(Convert.ToString(BH, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    BH = L_AND(Convert.ToString(BH, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    BH = L_AND(Convert.ToString(BH, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    BH = L_AND(Convert.ToString(BH, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    BH = L_AND(Convert.ToString(BH, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    BH = L_AND(Convert.ToString(BH, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    BH = L_AND(Convert.ToString(BH, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    BH = L_AND(Convert.ToString(BH, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    BH = L_AND(Convert.ToString(BH, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "BL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    BL = L_AND(Convert.ToString(BL, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    BL = L_AND(Convert.ToString(BL, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    BL = L_AND(Convert.ToString(BL, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    BL = L_AND(Convert.ToString(BL, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    BL = L_AND(Convert.ToString(BL, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    BL = L_AND(Convert.ToString(BL, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    BL = L_AND(Convert.ToString(BL, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    BL = L_AND(Convert.ToString(BL, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    BL = L_AND(Convert.ToString(BL, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "CH" || ops[0] == "CX")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    CH = L_AND(Convert.ToString(CH, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    CH = L_AND(Convert.ToString(CH, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    CH = L_AND(Convert.ToString(CH, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    CH = L_AND(Convert.ToString(CH, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    CH = L_AND(Convert.ToString(CH, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    CH = L_AND(Convert.ToString(CH, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    CH = L_AND(Convert.ToString(CH, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    CH = L_AND(Convert.ToString(CH, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    CH = L_AND(Convert.ToString(CH, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "CL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    CL = L_AND(Convert.ToString(CL, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    CL = L_AND(Convert.ToString(CL, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    CL = L_AND(Convert.ToString(CL, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    CL = L_AND(Convert.ToString(CL, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    CL = L_AND(Convert.ToString(CL, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    CL = L_AND(Convert.ToString(CL, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    CL = L_AND(Convert.ToString(CL, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    CL = L_AND(Convert.ToString(CL, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    CL = L_AND(Convert.ToString(CL, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "DH" || ops[0] == "DX")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    DH = L_AND(Convert.ToString(DH, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    DH = L_AND(Convert.ToString(DH, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    DH = L_AND(Convert.ToString(DH, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    DH = L_AND(Convert.ToString(DH, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    DH = L_AND(Convert.ToString(DH, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    DH = L_AND(Convert.ToString(DH, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    DH = L_AND(Convert.ToString(DH, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    DH = L_AND(Convert.ToString(DH, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    DH = L_AND(Convert.ToString(DH, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "DL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    DL = L_AND(Convert.ToString(DL, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    DL = L_AND(Convert.ToString(DL, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    DL = L_AND(Convert.ToString(DL, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    DL = L_AND(Convert.ToString(DL, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    DL = L_AND(Convert.ToString(DL, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    DL = L_AND(Convert.ToString(DL, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    DL = L_AND(Convert.ToString(DL, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    DL = L_AND(Convert.ToString(DL, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    DL = L_AND(Convert.ToString(DL, 2), Convert.ToString(mem, 2));
                                }
                            }
                        }
                        else if (ops[0] == "mem")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                mem = L_AND(Convert.ToString(mem, 2), Convert.ToString(AH, 2));
                            }
                            else if (ops[1] == "AL")
                            {
                                mem = L_AND(Convert.ToString(mem, 2), Convert.ToString(AL, 2));
                            }
                            else if (ops[1] == "BH" || ops[1] == "BX")
                            {
                                mem = L_AND(Convert.ToString(mem, 2), Convert.ToString(BH, 2));
                            }
                            else if (ops[1] == "BL")
                            {
                                mem = L_AND(Convert.ToString(mem, 2), Convert.ToString(BL, 2));
                            }
                            else if (ops[1] == "CH" || ops[1] == "CX")
                            {
                                mem = L_AND(Convert.ToString(mem, 2), Convert.ToString(CH, 2));
                            }
                            else if (ops[1] == "CL")
                            {
                                mem = L_AND(Convert.ToString(mem, 2), Convert.ToString(CL, 2));
                            }
                            else if (ops[1] == "DH" || ops[1] == "DX")
                            {
                                mem = L_AND(Convert.ToString(mem, 2), Convert.ToString(DH, 2));
                            }
                            else if (ops[1] == "DL")
                            {
                                mem = L_AND(Convert.ToString(mem, 2), Convert.ToString(DL, 2));
                            }
                            else
                            {
                                mem = L_AND(Convert.ToString(mem, 2), ops[1]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Use -->\n{ AND   REG, mem }\n{ AND   REG, REG }\n{ AND   mem, REG }");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Use -->\n{ AND   REG, mem }\n{ AND   REG, REG }\n{ AND   mem, REG }");
                    }
                    break;

                case "OR":
                    if (ops.Count == 2)
                    {
                        if (Is_register(ops[0]) && (Is_register(ops[1]) || ops[1] == "mem"))
                        {
                            if (ops[0] == "AH" || ops[0] == "AX")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    AH = L_OR(Convert.ToString(AH, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    AH = L_OR(Convert.ToString(AH, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    AH = L_OR(Convert.ToString(AH, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    AH = L_OR(Convert.ToString(AH, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    AH = L_OR(Convert.ToString(AH, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    AH = L_OR(Convert.ToString(AH, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    AH = L_OR(Convert.ToString(AH, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    AH = L_OR(Convert.ToString(AH, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    AH = L_OR(Convert.ToString(AH, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "AL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    AL = L_OR(Convert.ToString(AL, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    AL = L_OR(Convert.ToString(AL, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    AL = L_OR(Convert.ToString(AL, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    AL = L_OR(Convert.ToString(AL, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    AL = L_OR(Convert.ToString(AL, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    AL = L_OR(Convert.ToString(AL, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    AL = L_OR(Convert.ToString(AL, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    AL = L_OR(Convert.ToString(AL, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    AL = L_OR(Convert.ToString(AL, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "BH" || ops[0] == "BX")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    BH = L_OR(Convert.ToString(BH, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    BH = L_OR(Convert.ToString(BH, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    BH = L_OR(Convert.ToString(BH, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    BH = L_OR(Convert.ToString(BH, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    BH = L_OR(Convert.ToString(BH, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    BH = L_OR(Convert.ToString(BH, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    BH = L_OR(Convert.ToString(BH, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    BH = L_OR(Convert.ToString(BH, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    BH = L_OR(Convert.ToString(BH, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "BL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    BL = L_OR(Convert.ToString(BL, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    BL = L_OR(Convert.ToString(BL, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    BL = L_OR(Convert.ToString(BL, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    BL = L_OR(Convert.ToString(BL, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    BL = L_OR(Convert.ToString(BL, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    BL = L_OR(Convert.ToString(BL, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    BL = L_OR(Convert.ToString(BL, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    BL = L_OR(Convert.ToString(BL, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    BL = L_OR(Convert.ToString(BL, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "CH" || ops[0] == "CX")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    CH = L_OR(Convert.ToString(CH, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    CH = L_OR(Convert.ToString(CH, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    CH = L_OR(Convert.ToString(CH, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    CH = L_OR(Convert.ToString(CH, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    CH = L_OR(Convert.ToString(CH, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    CH = L_OR(Convert.ToString(CH, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    CH = L_OR(Convert.ToString(CH, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    CH = L_OR(Convert.ToString(CH, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    CH = L_OR(Convert.ToString(CH, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "CL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    CL = L_OR(Convert.ToString(CL, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    CL = L_OR(Convert.ToString(CL, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    CL = L_OR(Convert.ToString(CL, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    CL = L_OR(Convert.ToString(CL, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    CL = L_OR(Convert.ToString(CL, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    CL = L_OR(Convert.ToString(CL, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    CL = L_OR(Convert.ToString(CL, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    CL = L_OR(Convert.ToString(CL, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    CL = L_OR(Convert.ToString(CL, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "DH" || ops[0] == "DX")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    DH = L_OR(Convert.ToString(DH, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    DH = L_OR(Convert.ToString(DH, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    DH = L_OR(Convert.ToString(DH, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    DH = L_OR(Convert.ToString(DH, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    DH = L_OR(Convert.ToString(DH, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    DH = L_OR(Convert.ToString(DH, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    DH = L_OR(Convert.ToString(DH, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    DH = L_OR(Convert.ToString(DH, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    DH = L_OR(Convert.ToString(DH, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "DL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    DL = L_OR(Convert.ToString(DL, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    DL = L_OR(Convert.ToString(DL, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    DL = L_OR(Convert.ToString(DL, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    DL = L_OR(Convert.ToString(DL, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    DL = L_OR(Convert.ToString(DL, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    DL = L_OR(Convert.ToString(DL, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    DL = L_OR(Convert.ToString(DL, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    DL = L_OR(Convert.ToString(DL, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    DL = L_OR(Convert.ToString(DL, 2), Convert.ToString(mem, 2));
                                }
                            }
                        }
                        else if (ops[0] == "mem")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                mem = L_OR(Convert.ToString(mem, 2), Convert.ToString(AH, 2));
                            }
                            else if (ops[1] == "AL")
                            {
                                mem = L_OR(Convert.ToString(mem, 2), Convert.ToString(AL, 2));
                            }
                            else if (ops[1] == "BH" || ops[1] == "BX")
                            {
                                mem = L_OR(Convert.ToString(mem, 2), Convert.ToString(BH, 2));
                            }
                            else if (ops[1] == "BL")
                            {
                                mem = L_OR(Convert.ToString(mem, 2), Convert.ToString(BL, 2));
                            }
                            else if (ops[1] == "CH" || ops[1] == "CX")
                            {
                                mem = L_OR(Convert.ToString(mem, 2), Convert.ToString(CH, 2));
                            }
                            else if (ops[1] == "CL")
                            {
                                mem = L_OR(Convert.ToString(mem, 2), Convert.ToString(CL, 2));
                            }
                            else if (ops[1] == "DH" || ops[1] == "DX")
                            {
                                mem = L_OR(Convert.ToString(mem, 2), Convert.ToString(DH, 2));
                            }
                            else if (ops[1] == "DL")
                            {
                                mem = L_OR(Convert.ToString(mem, 2), Convert.ToString(DL, 2));
                            }
                            else
                            {
                                mem = L_OR(Convert.ToString(mem, 2), ops[1]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Use -->\n{ OR   REG, mem }\n{ OR   REG, REG }\n{ OR   mem, REG }");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Use -->\n{ OR   REG, mem }\n{ OR   REG, REG }\n{ OR   mem, REG }");
                    }
                    break;

                case "XOR":
                    if (ops.Count == 2)
                    {
                        if (Is_register(ops[0]) && (Is_register(ops[1]) || ops[1] == "mem"))
                        {
                            if (ops[0] == "AH" || ops[0] == "AX")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    AH = L_XOR(Convert.ToString(AH, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    AH = L_XOR(Convert.ToString(AH, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    AH = L_XOR(Convert.ToString(AH, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    AH = L_XOR(Convert.ToString(AH, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    AH = L_XOR(Convert.ToString(AH, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    AH = L_XOR(Convert.ToString(AH, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    AH = L_XOR(Convert.ToString(AH, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    AH = L_XOR(Convert.ToString(AH, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    AH = L_XOR(Convert.ToString(AH, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "AL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    AL = L_XOR(Convert.ToString(AL, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    AL = L_XOR(Convert.ToString(AL, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    AL = L_XOR(Convert.ToString(AL, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    AL = L_XOR(Convert.ToString(AL, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    AL = L_XOR(Convert.ToString(AL, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    AL = L_XOR(Convert.ToString(AL, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    AL = L_XOR(Convert.ToString(AL, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    AL = L_XOR(Convert.ToString(AL, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    AL = L_XOR(Convert.ToString(AL, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "BH" || ops[0] == "BX")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    BH = L_XOR(Convert.ToString(BH, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    BH = L_XOR(Convert.ToString(BH, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    BH = L_XOR(Convert.ToString(BH, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    BH = L_XOR(Convert.ToString(BH, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    BH = L_XOR(Convert.ToString(BH, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    BH = L_XOR(Convert.ToString(BH, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    BH = L_XOR(Convert.ToString(BH, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    BH = L_XOR(Convert.ToString(BH, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    BH = L_XOR(Convert.ToString(BH, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "BL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    BL = L_XOR(Convert.ToString(BL, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    BL = L_XOR(Convert.ToString(BL, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    BL = L_XOR(Convert.ToString(BL, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    BL = L_XOR(Convert.ToString(BL, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    BL = L_XOR(Convert.ToString(BL, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    BL = L_XOR(Convert.ToString(BL, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    BL = L_XOR(Convert.ToString(BL, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    BL = L_XOR(Convert.ToString(BL, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    BL = L_XOR(Convert.ToString(BL, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "CH" || ops[0] == "CX")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    CH = L_XOR(Convert.ToString(CH, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    CH = L_XOR(Convert.ToString(CH, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    CH = L_XOR(Convert.ToString(CH, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    CH = L_XOR(Convert.ToString(CH, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    CH = L_XOR(Convert.ToString(CH, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    CH = L_XOR(Convert.ToString(CH, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    CH = L_XOR(Convert.ToString(CH, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    CH = L_XOR(Convert.ToString(CH, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    CH = L_XOR(Convert.ToString(CH, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "CL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    CL = L_XOR(Convert.ToString(CL, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    CL = L_XOR(Convert.ToString(CL, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    CL = L_XOR(Convert.ToString(CL, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    CL = L_XOR(Convert.ToString(CL, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    CL = L_XOR(Convert.ToString(CL, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    CL = L_XOR(Convert.ToString(CL, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    CL = L_XOR(Convert.ToString(CL, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    CL = L_XOR(Convert.ToString(CL, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    CL = L_XOR(Convert.ToString(CL, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "DH" || ops[0] == "DX")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    DH = L_XOR(Convert.ToString(DH, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    DH = L_XOR(Convert.ToString(DH, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    DH = L_XOR(Convert.ToString(DH, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    DH = L_XOR(Convert.ToString(DH, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    DH = L_XOR(Convert.ToString(DH, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    DH = L_XOR(Convert.ToString(DH, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    DH = L_XOR(Convert.ToString(DH, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    DH = L_XOR(Convert.ToString(DH, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    DH = L_XOR(Convert.ToString(DH, 2), Convert.ToString(mem, 2));
                                }
                            }
                            else if (ops[0] == "DL")
                            {
                                if (ops[1] == "AX" || ops[1] == "AH")
                                {
                                    DL = L_XOR(Convert.ToString(DL, 2), Convert.ToString(AH, 2));
                                }
                                else if (ops[1] == "AL")
                                {
                                    DL = L_XOR(Convert.ToString(DL, 2), Convert.ToString(AL, 2));
                                }
                                else if (ops[1] == "BH" || ops[1] == "BX")
                                {
                                    DL = L_XOR(Convert.ToString(DL, 2), Convert.ToString(BH, 2));
                                }
                                else if (ops[1] == "BL")
                                {
                                    DL = L_XOR(Convert.ToString(DL, 2), Convert.ToString(BL, 2));
                                }
                                else if (ops[1] == "CH" || ops[1] == "CX")
                                {
                                    DL = L_XOR(Convert.ToString(DL, 2), Convert.ToString(CH, 2));
                                }
                                else if (ops[1] == "CL")
                                {
                                    DL = L_XOR(Convert.ToString(DL, 2), Convert.ToString(CL, 2));
                                }
                                else if (ops[1] == "DH" || ops[1] == "DX")
                                {
                                    DL = L_XOR(Convert.ToString(DL, 2), Convert.ToString(DH, 2));
                                }
                                else if (ops[1] == "DL")
                                {
                                    DL = L_XOR(Convert.ToString(DL, 2), Convert.ToString(DL, 2));
                                }
                                else
                                {
                                    DL = L_XOR(Convert.ToString(DL, 2), Convert.ToString(mem, 2));
                                }
                            }
                        }
                        else if (ops[0] == "mem")
                        {
                            if (ops[1] == "AX" || ops[1] == "AH")
                            {
                                mem = L_XOR(Convert.ToString(mem, 2), Convert.ToString(AH, 2));
                            }
                            else if (ops[1] == "AL")
                            {
                                mem = L_XOR(Convert.ToString(mem, 2), Convert.ToString(AL, 2));
                            }
                            else if (ops[1] == "BH" || ops[1] == "BX")
                            {
                                mem = L_XOR(Convert.ToString(mem, 2), Convert.ToString(BH, 2));
                            }
                            else if (ops[1] == "BL")
                            {
                                mem = L_XOR(Convert.ToString(mem, 2), Convert.ToString(BL, 2));
                            }
                            else if (ops[1] == "CH" || ops[1] == "CX")
                            {
                                mem = L_XOR(Convert.ToString(mem, 2), Convert.ToString(CH, 2));
                            }
                            else if (ops[1] == "CL")
                            {
                                mem = L_XOR(Convert.ToString(mem, 2), Convert.ToString(CL, 2));
                            }
                            else if (ops[1] == "DH" || ops[1] == "DX")
                            {
                                mem = L_XOR(Convert.ToString(mem, 2), Convert.ToString(DH, 2));
                            }
                            else if (ops[1] == "DL")
                            {
                                mem = L_XOR(Convert.ToString(mem, 2), Convert.ToString(DL, 2));
                            }
                            else
                            {
                                mem = L_XOR(Convert.ToString(mem, 2), ops[1]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Use -->\n{ XOR   REG, mem }\n{ XOR   REG, REG }\n{ XOR   mem, REG }");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Use -->\n{ XOR   REG, mem }\n{ XOR   REG, REG }\n{ XOR   mem, REG }");
                    }
                    break;

                case "TEST":
                    break;

                case "SHL":
                    break;

                case "SHR":
                    break;

                case "SAL":
                    break;

                case "SAR":
                    break;

                case "ROL":
                    break;

                case "ROR":
                    break;

                case "RCL":
                    break;

                case "RCR":
                    break;

                // FLAGS MANIPULATIONS

                case "CLC":
                    CF = false;
                    break;

                case "CLD":
                    DF = false;
                    break;

                case "CLI":
                    IF = false;
                    break;

                case "CMC":
                    if (CF == true) { CF = false; }
                    else { CF = true; }
                    break;

                case "STC":
                    CF = true;
                    break;

                case "STD":
                    DF = true;
                    break;

                case "STI":
                    IF = true;
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

            flagsReg.Text = "SF = " + Is_True(SF);
            flagsReg.Text += "\tZF = " + Is_True(ZF);
            flagsReg.Text += "\tPF = " + Is_True(PF);
            flagsReg.Text += "\nAF = " + Is_True(AF);
            flagsReg.Text += "\tCF = " + Is_True(CF);
            flagsReg.Text += "\tOF = " + Is_True(OF);
            flagsReg.Text += "\nIF = " + Is_True(IF);
            flagsReg.Text += "\tDF = " + Is_True(DF);
            flagsReg.Text += "\tTF = " + Is_True(TF);
        }

        private int Is_True(bool x)
        {
            if(x) { return 1; }
            else { return 0; }
        }

        private short Converter_to_int16(string number)
        {
            short new_number;

            if (!Int16.TryParse(number, out new_number))
            {
                for (int i = 0; i < number.Length; i++)
                {
                    new_number += Convert.ToInt16(number[0]);
                }
            }
            else
            {
                new_number = Convert.ToInt16(number);
            }

            return new_number;
        }

        private short Limits(string ops ,string n)  // TO MOV
        {
            short numb = Converter_to_int16(n);

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

        private byte Limits_arith(byte a, byte b, char x)
        {
            switch(x)
            {
                case '+':
                    if (a + b > 127)
                    {
                        OF = true;
                        return (byte)((a + b) % 127);
                    }
                    else
                    {
                        return (byte)(a + b);
                    }
                case '-':
                    if (a - b > 127)
                    {
                        OF = true;
                        return (byte)((a - b) % 127);
                    }
                    else if (a - b < 0)
                    {
                        OF = true;
                        return (byte)((a - b) * -1);
                    }
                    else
                    {
                        return (byte)(a - b);
                    }
                case '*':
                    if (a * b > 127)
                    {
                        OF = true;
                        return (byte)((a * b) % 127);
                    }
                    else if (a * b < 0)
                    {
                        OF = true;
                        return (byte)(((a * b) % 127) * (-1));
                    }
                    else
                    {
                        return (byte)(a * b);
                    }
                case '/':
                    if (b == 0)
                    {
                        MessageBox.Show("ERROR!");
                        return a;
                    }
                    else
                    {
                        if (a / b > 127)
                        {
                            OF = true;
                            return (byte)((a / b) % 127);
                        }
                        else if (a / b < 127)
                        {
                            OF = true;
                            return (byte)((a / b) % 127);
                        }
                        else
                        {
                            return (byte)(a / b);
                        }
                    }
                case '%':
                    if (b == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        if (a % b > 127)
                        {
                            OF = true;
                            return (byte)((a % b) % 127);
                        }
                        else if (a % b < 127)
                        {
                            OF = true;
                            return (byte)((a % b) % 127);
                        }
                        else
                        {
                            return (byte)(a % b);
                        }
                    }
                default:
                    return 0;
            }
        }

        private byte Lower_byte(bool SF, bool ZF, bool AF, bool PF, bool CF)
        {
            string lower = "";

            if (SF) { lower += "1"; }
            else { lower += "0"; }

            if (ZF) { lower += "1"; }
            else { lower += "0"; }

            lower += "0";

            if (AF) { lower += "1"; }
            else { lower += "0"; }

            lower += 0;

            if (PF) { lower += "1"; }
            else { lower += "0"; }

            lower += 1;

            if (CF) { lower += "1"; }
            else { lower += "0"; }

            return (Convert.ToByte(lower, 2));
        }

        private byte Higher_byte(bool OF, bool DF, bool IF, bool TF)
        {
            string higher = "0000";

            if (OF) { higher += "1"; }
            else { higher += "0"; }

            if (DF) { higher += "1"; }
            else { higher += "0"; }

            if (IF) { higher += "1"; }
            else { higher += "0"; }

            if (TF) { higher += "1"; }
            else { higher += "0"; }

            return (Convert.ToByte(higher, 2));
        }

        private void Store(byte AH_reg)
        {
            string flag_lowerB = Convert.ToString(AH_reg, 2).PadLeft(8, '0');

            if (flag_lowerB[0] == '0') { SF = false; }
            else { SF = true; }

            if (flag_lowerB[1] == '0') { ZF = false; }
            else { SF = true; }

            if (flag_lowerB[3] == '0') { AF = false; }
            else { SF = true; }

            if (flag_lowerB[5] == '0') { PF = false; }
            else { SF = true; }

            if (flag_lowerB[7] == '0') { CF = false; }
            else { SF = true; }
        }

        private byte L_NOT(string x)
        {
            string x_ = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == '1') { x_ += '0'; }
                else if (x[i] == '0') { x_ += '1'; }
            }

            byte y = Convert.ToByte(x_, 2);

            return y;
        }

        private byte L_AND(string a, string b)
        {
            string x = "";

            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == '1' && b[i] == '1') { x += '1'; }
                    else { x += '0'; }
                }
            }
            else if (a.Length > b.Length)
            {
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    if (b[i] == '1' && a[i] == '1') { x = '1' + x; }
                    else { x = '0' + x; }
                }
            }
            else
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    if (a[i] == '1' && b[i] == '1') { x = '1' + x; }
                    else { x = '0' + x; }
                }
            }

            byte z = Convert.ToByte(x, 2);

            return z;
        }

        private byte L_OR(string a, string b)
        {
            string x = "";

            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == '1' || b[i] == '1') { x += '1'; }
                    else { x += '0'; }
                }
            }
            else if (a.Length > b.Length)
            {
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    if (b[i] == '1' || a[i] == '1') { x = '1' + x; }
                    else { x = '0' + x; }
                }
            }
            else
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    if (a[i] == '1' || b[i] == '1') { x = '1' + x; }
                    else { x = '0' + x; }
                }
            }

            byte z = Convert.ToByte(x, 2);

            return z;
        }

        private byte L_XOR(string a, string b)
        {
            string x = "";

            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if ( (a[i] == '1' && b[i] == '1') || (a[i] == '0' && b[1] == '0')) { x += '0'; }
                    else { x += '1'; }
                }
            }
            else if (a.Length > b.Length)
            {
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    if ((a[i] == '1' && b[i] == '1') || (a[i] == '0' && b[1] == '0')) { x += '0'; }
                    else { x += '1'; }
                }
            }
            else
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    if ((a[i] == '1' && b[i] == '1') || (a[i] == '0' && b[1] == '0')) { x += '0'; }
                    else { x += '1'; }
                }
            }

            byte z = Convert.ToByte(x, 2);

            return z;
        }
    }
}