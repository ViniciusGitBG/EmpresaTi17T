namespace EmpresaTi17T
{
    partial class cadastrar
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
            this.cpf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.UF = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cidade = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(41, 58);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(27, 13);
            this.cpf.TabIndex = 0;
            this.cpf.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "UF";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(104, 55);
            this.maskedTextBox1.Mask = "999999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(228, 20);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // UF
            // 
            this.UF.Location = new System.Drawing.Point(104, 251);
            this.UF.Mask = "aa";
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(228, 20);
            this.UF.TabIndex = 6;
            this.UF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.UF_MaskInputRejected);
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(104, 146);
            this.telefone.Mask = "(99) 0000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(228, 20);
            this.telefone.TabIndex = 7;
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefone_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(104, 200);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(228, 20);
            this.cidade.TabIndex = 9;
            this.cidade.TextChanged += new System.EventHandler(this.cidade_TextChanged);
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(104, 102);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(228, 20);
            this.Nome.TabIndex = 10;
            this.Nome.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "cadastrar pessoa";
            // 
            // cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.UF);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpf);
            this.Name = "cadastrar";
            this.Text = "cadastrar";
            this.Load += new System.EventHandler(this.cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox UF;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label5;
    }
}