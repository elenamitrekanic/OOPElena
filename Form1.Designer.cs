namespace OOP.projekat
{
    partial class Form1
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
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtbxime = new System.Windows.Forms.TextBox();
            this.lblime = new System.Windows.Forms.Label();
            this.lbllozinka = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.txtbxlozinka = new System.Windows.Forms.TextBox();
            this.lblknjiga = new System.Windows.Forms.Label();
            this.lblimeknjige = new System.Windows.Forms.Label();
            this.lblpisac = new System.Windows.Forms.Label();
            this.lblbrojstrana = new System.Windows.Forms.Label();
            this.txtbximeknjige = new System.Windows.Forms.TextBox();
            this.txtbximepisca = new System.Windows.Forms.TextBox();
            this.txtbxbrojstrana = new System.Windows.Forms.TextBox();
            this.rdbtn1 = new System.Windows.Forms.RadioButton();
            this.rdbtn2 = new System.Windows.Forms.RadioButton();
            this.rdbtn3 = new System.Windows.Forms.RadioButton();
            this.btnpotvrda = new System.Windows.Forms.Button();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl2
            // 
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl2.Location = new System.Drawing.Point(658, 0);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(595, 603);
            this.pnl2.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(266, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(79, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "InterBook";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(53, 60);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(200, 20);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Unesite podatke za prijavu:";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // txtbxime
            // 
            this.txtbxime.Location = new System.Drawing.Point(187, 113);
            this.txtbxime.Name = "txtbxime";
            this.txtbxime.Size = new System.Drawing.Size(100, 26);
            this.txtbxime.TabIndex = 2;
            this.txtbxime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblime
            // 
            this.lblime.AutoSize = true;
            this.lblime.Location = new System.Drawing.Point(53, 119);
            this.lblime.Name = "lblime";
            this.lblime.Size = new System.Drawing.Size(114, 20);
            this.lblime.TabIndex = 3;
            this.lblime.Text = "Korisničko ime:";
            this.lblime.Click += new System.EventHandler(this.lblime_Click);
            // 
            // lbllozinka
            // 
            this.lbllozinka.AutoSize = true;
            this.lbllozinka.Location = new System.Drawing.Point(53, 167);
            this.lbllozinka.Name = "lbllozinka";
            this.lbllozinka.Size = new System.Drawing.Size(68, 20);
            this.lbllozinka.TabIndex = 4;
            this.lbllozinka.Text = "Lozinka:";
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btnpotvrda);
            this.pnl1.Controls.Add(this.rdbtn3);
            this.pnl1.Controls.Add(this.rdbtn2);
            this.pnl1.Controls.Add(this.rdbtn1);
            this.pnl1.Controls.Add(this.txtbxbrojstrana);
            this.pnl1.Controls.Add(this.txtbximepisca);
            this.pnl1.Controls.Add(this.txtbximeknjige);
            this.pnl1.Controls.Add(this.lblbrojstrana);
            this.pnl1.Controls.Add(this.lblpisac);
            this.pnl1.Controls.Add(this.lblimeknjige);
            this.pnl1.Controls.Add(this.lblknjiga);
            this.pnl1.Controls.Add(this.txtbxlozinka);
            this.pnl1.Controls.Add(this.lbllozinka);
            this.pnl1.Controls.Add(this.lblime);
            this.pnl1.Controls.Add(this.txtbxime);
            this.pnl1.Controls.Add(this.lbl2);
            this.pnl1.Controls.Add(this.lbl1);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(598, 603);
            this.pnl1.TabIndex = 0;
            this.pnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl1_Paint);
            // 
            // txtbxlozinka
            // 
            this.txtbxlozinka.Location = new System.Drawing.Point(187, 161);
            this.txtbxlozinka.Name = "txtbxlozinka";
            this.txtbxlozinka.Size = new System.Drawing.Size(100, 26);
            this.txtbxlozinka.TabIndex = 5;
            this.txtbxlozinka.TextChanged += new System.EventHandler(this.txtbxlozinka_TextChanged);
            // 
            // lblknjiga
            // 
            this.lblknjiga.AutoSize = true;
            this.lblknjiga.Location = new System.Drawing.Point(53, 216);
            this.lblknjiga.Name = "lblknjiga";
            this.lblknjiga.Size = new System.Drawing.Size(181, 20);
            this.lblknjiga.TabIndex = 6;
            this.lblknjiga.Text = "Unesite podatke o knjizi:";
            this.lblknjiga.Click += new System.EventHandler(this.lblknjiga_Click);
            // 
            // lblimeknjige
            // 
            this.lblimeknjige.AutoSize = true;
            this.lblimeknjige.Location = new System.Drawing.Point(53, 266);
            this.lblimeknjige.Name = "lblimeknjige";
            this.lblimeknjige.Size = new System.Drawing.Size(85, 20);
            this.lblimeknjige.TabIndex = 7;
            this.lblimeknjige.Text = "Ime knjige:";
            // 
            // lblpisac
            // 
            this.lblpisac.AutoSize = true;
            this.lblpisac.Location = new System.Drawing.Point(53, 313);
            this.lblpisac.Name = "lblpisac";
            this.lblpisac.Size = new System.Drawing.Size(81, 20);
            this.lblpisac.TabIndex = 8;
            this.lblpisac.Text = "Ime pisca:";
            // 
            // lblbrojstrana
            // 
            this.lblbrojstrana.AutoSize = true;
            this.lblbrojstrana.Location = new System.Drawing.Point(53, 358);
            this.lblbrojstrana.Name = "lblbrojstrana";
            this.lblbrojstrana.Size = new System.Drawing.Size(90, 20);
            this.lblbrojstrana.TabIndex = 9;
            this.lblbrojstrana.Text = "Broj strana:";
            // 
            // txtbximeknjige
            // 
            this.txtbximeknjige.Location = new System.Drawing.Point(187, 260);
            this.txtbximeknjige.Name = "txtbximeknjige";
            this.txtbximeknjige.Size = new System.Drawing.Size(100, 26);
            this.txtbximeknjige.TabIndex = 10;
            // 
            // txtbximepisca
            // 
            this.txtbximepisca.Location = new System.Drawing.Point(187, 307);
            this.txtbximepisca.Name = "txtbximepisca";
            this.txtbximepisca.Size = new System.Drawing.Size(100, 26);
            this.txtbximepisca.TabIndex = 11;
            // 
            // txtbxbrojstrana
            // 
            this.txtbxbrojstrana.Location = new System.Drawing.Point(187, 352);
            this.txtbxbrojstrana.Name = "txtbxbrojstrana";
            this.txtbxbrojstrana.Size = new System.Drawing.Size(100, 26);
            this.txtbxbrojstrana.TabIndex = 12;
            // 
            // rdbtn1
            // 
            this.rdbtn1.AutoSize = true;
            this.rdbtn1.Location = new System.Drawing.Point(57, 404);
            this.rdbtn1.Name = "rdbtn1";
            this.rdbtn1.Size = new System.Drawing.Size(101, 24);
            this.rdbtn1.TabIndex = 13;
            this.rdbtn1.TabStop = true;
            this.rdbtn1.Text = "Pročitano";
            this.rdbtn1.UseVisualStyleBackColor = true;
            // 
            // rdbtn2
            // 
            this.rdbtn2.AutoSize = true;
            this.rdbtn2.Location = new System.Drawing.Point(57, 449);
            this.rdbtn2.Name = "rdbtn2";
            this.rdbtn2.Size = new System.Drawing.Size(116, 24);
            this.rdbtn2.TabIndex = 14;
            this.rdbtn2.TabStop = true;
            this.rdbtn2.Text = "Na listi želja";
            this.rdbtn2.UseVisualStyleBackColor = true;
            // 
            // rdbtn3
            // 
            this.rdbtn3.AutoSize = true;
            this.rdbtn3.Location = new System.Drawing.Point(57, 496);
            this.rdbtn3.Name = "rdbtn3";
            this.rdbtn3.Size = new System.Drawing.Size(140, 24);
            this.rdbtn3.TabIndex = 15;
            this.rdbtn3.TabStop = true;
            this.rdbtn3.Text = "Trenutno čitam";
            this.rdbtn3.UseVisualStyleBackColor = true;
            // 
            // btnpotvrda
            // 
            this.btnpotvrda.Location = new System.Drawing.Point(57, 538);
            this.btnpotvrda.Name = "btnpotvrda";
            this.btnpotvrda.Size = new System.Drawing.Size(75, 37);
            this.btnpotvrda.TabIndex = 16;
            this.btnpotvrda.Text = "Potvrdi";
            this.btnpotvrda.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 603);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtbxime;
        private System.Windows.Forms.Label lblime;
        private System.Windows.Forms.Label lbllozinka;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TextBox txtbxlozinka;
        private System.Windows.Forms.Label lblpisac;
        private System.Windows.Forms.Label lblimeknjige;
        private System.Windows.Forms.Label lblknjiga;
        private System.Windows.Forms.RadioButton rdbtn3;
        private System.Windows.Forms.RadioButton rdbtn2;
        private System.Windows.Forms.RadioButton rdbtn1;
        private System.Windows.Forms.TextBox txtbxbrojstrana;
        private System.Windows.Forms.TextBox txtbximepisca;
        private System.Windows.Forms.TextBox txtbximeknjige;
        private System.Windows.Forms.Label lblbrojstrana;
        private System.Windows.Forms.Button btnpotvrda;
    }
}

