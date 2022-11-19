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
        // REGISTERS
        
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

        public Int_8086()
        {
            InitializeComponent();
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

        }

        // Clear Button
        private void Clear_Click(object sender, EventArgs e)
        {

        }

        // STACK --> shows the contents of the register 
        private void Stack_box_TextChanged(object sender, EventArgs e)
        {

        }

        // DATA TRANSFER INSTRUCTIONS:

        // MOV
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

    }
}
