
namespace Intel_8086
{
    partial class Int_8086
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Int_8086));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.RUN = new System.Windows.Forms.Button();
            this.Operation = new System.Windows.Forms.TextBox();
            this.Instruction = new System.Windows.Forms.TextBox();
            this.CMC = new System.Windows.Forms.Button();
            this.STI = new System.Windows.Forms.Button();
            this.STD = new System.Windows.Forms.Button();
            this.STC = new System.Windows.Forms.Button();
            this.CLI = new System.Windows.Forms.Button();
            this.CLD = new System.Windows.Forms.Button();
            this.CLC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.XOR = new System.Windows.Forms.Button();
            this.OR = new System.Windows.Forms.Button();
            this.AND = new System.Windows.Forms.Button();
            this.NOT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Label();
            this.SAHF = new System.Windows.Forms.Button();
            this.LAHF = new System.Windows.Forms.Button();
            this.LEA = new System.Windows.Forms.Button();
            this.POPF = new System.Windows.Forms.Button();
            this.PUSHF = new System.Windows.Forms.Button();
            this.POP = new System.Windows.Forms.Button();
            this.PUSH = new System.Windows.Forms.Button();
            this.XCHG = new System.Windows.Forms.Button();
            this.MOV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.IDIV = new System.Windows.Forms.Button();
            this.IMUL = new System.Windows.Forms.Button();
            this.AAS = new System.Windows.Forms.Button();
            this.AAA = new System.Windows.Forms.Button();
            this.DEC = new System.Windows.Forms.Button();
            this.INC = new System.Windows.Forms.Button();
            this.DIV = new System.Windows.Forms.Button();
            this.MUL = new System.Windows.Forms.Button();
            this.SUB = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Stack_box = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flagsReg = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Clear);
            this.tabPage1.Controls.Add(this.RUN);
            this.tabPage1.Controls.Add(this.Operation);
            this.tabPage1.Controls.Add(this.Instruction);
            this.tabPage1.Controls.Add(this.CMC);
            this.tabPage1.Controls.Add(this.STI);
            this.tabPage1.Controls.Add(this.STD);
            this.tabPage1.Controls.Add(this.STC);
            this.tabPage1.Controls.Add(this.CLI);
            this.tabPage1.Controls.Add(this.CLD);
            this.tabPage1.Controls.Add(this.CLC);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.XOR);
            this.tabPage1.Controls.Add(this.OR);
            this.tabPage1.Controls.Add(this.AND);
            this.tabPage1.Controls.Add(this.NOT);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.line3);
            this.tabPage1.Controls.Add(this.SAHF);
            this.tabPage1.Controls.Add(this.LAHF);
            this.tabPage1.Controls.Add(this.LEA);
            this.tabPage1.Controls.Add(this.POPF);
            this.tabPage1.Controls.Add(this.PUSHF);
            this.tabPage1.Controls.Add(this.POP);
            this.tabPage1.Controls.Add(this.PUSH);
            this.tabPage1.Controls.Add(this.XCHG);
            this.tabPage1.Controls.Add(this.MOV);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.line2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.line1);
            this.tabPage1.Controls.Add(this.IDIV);
            this.tabPage1.Controls.Add(this.IMUL);
            this.tabPage1.Controls.Add(this.AAS);
            this.tabPage1.Controls.Add(this.AAA);
            this.tabPage1.Controls.Add(this.DEC);
            this.tabPage1.Controls.Add(this.INC);
            this.tabPage1.Controls.Add(this.DIV);
            this.tabPage1.Controls.Add(this.MUL);
            this.tabPage1.Controls.Add(this.SUB);
            this.tabPage1.Controls.Add(this.ADD);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Name = "label7";
            // 
            // Clear
            // 
            resources.ApplyResources(this.Clear, "Clear");
            this.Clear.Name = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // RUN
            // 
            resources.ApplyResources(this.RUN, "RUN");
            this.RUN.Name = "RUN";
            this.RUN.UseVisualStyleBackColor = true;
            this.RUN.Click += new System.EventHandler(this.RUN_Click);
            // 
            // Operation
            // 
            this.Operation.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.Operation, "Operation");
            this.Operation.Name = "Operation";
            this.Operation.TextChanged += new System.EventHandler(this.Operation_TextChanged);
            // 
            // Instruction
            // 
            this.Instruction.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.Instruction, "Instruction");
            this.Instruction.Name = "Instruction";
            this.Instruction.ReadOnly = true;
            this.Instruction.TextChanged += new System.EventHandler(this.Instruction_TextChanged);
            // 
            // CMC
            // 
            resources.ApplyResources(this.CMC, "CMC");
            this.CMC.Name = "CMC";
            this.CMC.UseVisualStyleBackColor = true;
            this.CMC.Click += new System.EventHandler(this.CMC_Click);
            // 
            // STI
            // 
            resources.ApplyResources(this.STI, "STI");
            this.STI.Name = "STI";
            this.STI.UseVisualStyleBackColor = true;
            this.STI.Click += new System.EventHandler(this.STI_Click);
            // 
            // STD
            // 
            resources.ApplyResources(this.STD, "STD");
            this.STD.Name = "STD";
            this.STD.UseVisualStyleBackColor = true;
            this.STD.Click += new System.EventHandler(this.STD_Click);
            // 
            // STC
            // 
            resources.ApplyResources(this.STC, "STC");
            this.STC.Name = "STC";
            this.STC.UseVisualStyleBackColor = true;
            this.STC.Click += new System.EventHandler(this.STC_Click);
            // 
            // CLI
            // 
            resources.ApplyResources(this.CLI, "CLI");
            this.CLI.Name = "CLI";
            this.CLI.UseVisualStyleBackColor = true;
            this.CLI.Click += new System.EventHandler(this.CLI_Click);
            // 
            // CLD
            // 
            resources.ApplyResources(this.CLD, "CLD");
            this.CLD.Name = "CLD";
            this.CLD.UseVisualStyleBackColor = true;
            this.CLD.Click += new System.EventHandler(this.CLD_Click);
            // 
            // CLC
            // 
            resources.ApplyResources(this.CLC, "CLC");
            this.CLC.Name = "CLC";
            this.CLC.UseVisualStyleBackColor = true;
            this.CLC.Click += new System.EventHandler(this.CLC_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // XOR
            // 
            resources.ApplyResources(this.XOR, "XOR");
            this.XOR.Name = "XOR";
            this.XOR.UseVisualStyleBackColor = true;
            this.XOR.Click += new System.EventHandler(this.XOR_Click);
            // 
            // OR
            // 
            resources.ApplyResources(this.OR, "OR");
            this.OR.Name = "OR";
            this.OR.UseVisualStyleBackColor = true;
            this.OR.Click += new System.EventHandler(this.OR_Click);
            // 
            // AND
            // 
            resources.ApplyResources(this.AND, "AND");
            this.AND.Name = "AND";
            this.AND.UseVisualStyleBackColor = true;
            this.AND.Click += new System.EventHandler(this.AND_Click);
            // 
            // NOT
            // 
            resources.ApplyResources(this.NOT, "NOT");
            this.NOT.Name = "NOT";
            this.NOT.UseVisualStyleBackColor = true;
            this.NOT.Click += new System.EventHandler(this.NOT_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // line3
            // 
            this.line3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.line3, "line3");
            this.line3.Name = "line3";
            // 
            // SAHF
            // 
            resources.ApplyResources(this.SAHF, "SAHF");
            this.SAHF.Name = "SAHF";
            this.SAHF.UseVisualStyleBackColor = true;
            this.SAHF.Click += new System.EventHandler(this.SAHF_Click);
            // 
            // LAHF
            // 
            resources.ApplyResources(this.LAHF, "LAHF");
            this.LAHF.Name = "LAHF";
            this.LAHF.UseVisualStyleBackColor = true;
            this.LAHF.Click += new System.EventHandler(this.LAHF_Click);
            // 
            // LEA
            // 
            resources.ApplyResources(this.LEA, "LEA");
            this.LEA.Name = "LEA";
            this.LEA.UseVisualStyleBackColor = true;
            this.LEA.Click += new System.EventHandler(this.LEA_Click);
            // 
            // POPF
            // 
            resources.ApplyResources(this.POPF, "POPF");
            this.POPF.Name = "POPF";
            this.POPF.UseVisualStyleBackColor = true;
            this.POPF.Click += new System.EventHandler(this.POPF_Click);
            // 
            // PUSHF
            // 
            resources.ApplyResources(this.PUSHF, "PUSHF");
            this.PUSHF.Name = "PUSHF";
            this.PUSHF.UseVisualStyleBackColor = true;
            this.PUSHF.Click += new System.EventHandler(this.button1_Click);
            // 
            // POP
            // 
            resources.ApplyResources(this.POP, "POP");
            this.POP.Name = "POP";
            this.POP.UseVisualStyleBackColor = true;
            this.POP.Click += new System.EventHandler(this.POP_Click);
            // 
            // PUSH
            // 
            resources.ApplyResources(this.PUSH, "PUSH");
            this.PUSH.Name = "PUSH";
            this.PUSH.UseVisualStyleBackColor = true;
            this.PUSH.Click += new System.EventHandler(this.PUSH_Click);
            // 
            // XCHG
            // 
            resources.ApplyResources(this.XCHG, "XCHG");
            this.XCHG.Name = "XCHG";
            this.XCHG.UseVisualStyleBackColor = true;
            this.XCHG.Click += new System.EventHandler(this.XCHG_Click);
            // 
            // MOV
            // 
            resources.ApplyResources(this.MOV, "MOV");
            this.MOV.Name = "MOV";
            this.MOV.UseVisualStyleBackColor = true;
            this.MOV.Click += new System.EventHandler(this.MOV_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // line2
            // 
            this.line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.line2, "line2");
            this.line2.Name = "line2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.line1, "line1");
            this.line1.Name = "line1";
            // 
            // IDIV
            // 
            resources.ApplyResources(this.IDIV, "IDIV");
            this.IDIV.Name = "IDIV";
            this.IDIV.UseVisualStyleBackColor = true;
            this.IDIV.Click += new System.EventHandler(this.IDIV_Click);
            // 
            // IMUL
            // 
            resources.ApplyResources(this.IMUL, "IMUL");
            this.IMUL.Name = "IMUL";
            this.IMUL.UseVisualStyleBackColor = true;
            this.IMUL.Click += new System.EventHandler(this.IMUL_Click);
            // 
            // AAS
            // 
            resources.ApplyResources(this.AAS, "AAS");
            this.AAS.Name = "AAS";
            this.AAS.UseVisualStyleBackColor = true;
            this.AAS.Click += new System.EventHandler(this.AAS_Click);
            // 
            // AAA
            // 
            resources.ApplyResources(this.AAA, "AAA");
            this.AAA.Name = "AAA";
            this.AAA.UseVisualStyleBackColor = true;
            this.AAA.Click += new System.EventHandler(this.AAA_Click);
            // 
            // DEC
            // 
            resources.ApplyResources(this.DEC, "DEC");
            this.DEC.Name = "DEC";
            this.DEC.UseVisualStyleBackColor = true;
            this.DEC.Click += new System.EventHandler(this.DEC_Click);
            // 
            // INC
            // 
            resources.ApplyResources(this.INC, "INC");
            this.INC.Name = "INC";
            this.INC.UseVisualStyleBackColor = true;
            this.INC.Click += new System.EventHandler(this.INC_Click);
            // 
            // DIV
            // 
            resources.ApplyResources(this.DIV, "DIV");
            this.DIV.Name = "DIV";
            this.DIV.UseVisualStyleBackColor = true;
            this.DIV.Click += new System.EventHandler(this.DIV_Click);
            // 
            // MUL
            // 
            resources.ApplyResources(this.MUL, "MUL");
            this.MUL.Name = "MUL";
            this.MUL.UseVisualStyleBackColor = true;
            this.MUL.Click += new System.EventHandler(this.MUL_Click);
            // 
            // SUB
            // 
            resources.ApplyResources(this.SUB, "SUB");
            this.SUB.Name = "SUB";
            this.SUB.UseVisualStyleBackColor = true;
            this.SUB.Click += new System.EventHandler(this.SUB_Click);
            // 
            // ADD
            // 
            resources.ApplyResources(this.ADD, "ADD");
            this.ADD.Name = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Stack_box
            // 
            this.Stack_box.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.Stack_box, "Stack_box");
            this.Stack_box.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Stack_box.Name = "Stack_box";
            this.Stack_box.ReadOnly = true;
            this.Stack_box.TextChanged += new System.EventHandler(this.Stack_box_TextChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // flagsReg
            // 
            this.flagsReg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.flagsReg, "flagsReg");
            this.flagsReg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.flagsReg.Name = "flagsReg";
            this.flagsReg.ReadOnly = true;
            this.flagsReg.TextChanged += new System.EventHandler(this.flagsReg_TextChanged);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Int_8086
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.flagsReg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Stack_box);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Int_8086";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button DIV;
        private System.Windows.Forms.Button MUL;
        private System.Windows.Forms.Button SUB;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button IDIV;
        private System.Windows.Forms.Button IMUL;
        private System.Windows.Forms.Button AAS;
        private System.Windows.Forms.Button AAA;
        private System.Windows.Forms.Button DEC;
        private System.Windows.Forms.Button INC;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SAHF;
        private System.Windows.Forms.Button LAHF;
        private System.Windows.Forms.Button LEA;
        private System.Windows.Forms.Button POPF;
        private System.Windows.Forms.Button PUSHF;
        private System.Windows.Forms.Button POP;
        private System.Windows.Forms.Button PUSH;
        private System.Windows.Forms.Button XCHG;
        private System.Windows.Forms.Button MOV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label line3;
        private System.Windows.Forms.Button NOT;
        private System.Windows.Forms.Button XOR;
        private System.Windows.Forms.Button OR;
        private System.Windows.Forms.Button AND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CLC;
        private System.Windows.Forms.Button STI;
        private System.Windows.Forms.Button STD;
        private System.Windows.Forms.Button STC;
        private System.Windows.Forms.Button CLI;
        private System.Windows.Forms.Button CLD;
        private System.Windows.Forms.Button CMC;
        private System.Windows.Forms.TextBox Operation;
        private System.Windows.Forms.TextBox Instruction;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button RUN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Stack_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox flagsReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}

