namespace Exercicio_de_multiplas_janelas
{
    partial class CriarCliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Endereço = new GroupBox();
            cepCliente = new TextBox();
            ufCliente = new TextBox();
            cidadeCliente = new TextBox();
            complementoCliente = new TextBox();
            numeroCliente = new TextBox();
            logradouroCliente = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            nomeCliente = new TextBox();
            telefoneCliente = new TextBox();
            emailCliente = new TextBox();
            cancelarbutton1 = new Button();
            okbutton2 = new Button();
            Endereço.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 57);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 98);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "E-mail:";
            // 
            // Endereço
            // 
            Endereço.Controls.Add(cepCliente);
            Endereço.Controls.Add(ufCliente);
            Endereço.Controls.Add(cidadeCliente);
            Endereço.Controls.Add(complementoCliente);
            Endereço.Controls.Add(numeroCliente);
            Endereço.Controls.Add(logradouroCliente);
            Endereço.Controls.Add(label10);
            Endereço.Controls.Add(label9);
            Endereço.Controls.Add(label8);
            Endereço.Controls.Add(label7);
            Endereço.Controls.Add(label6);
            Endereço.Controls.Add(label5);
            Endereço.Location = new Point(26, 127);
            Endereço.Name = "Endereço";
            Endereço.Size = new Size(270, 311);
            Endereço.TabIndex = 4;
            Endereço.TabStop = false;
            Endereço.Text = "groupBox1";
            // 
            // cepCliente
            // 
            cepCliente.Location = new Point(112, 275);
            cepCliente.Name = "cepCliente";
            cepCliente.Size = new Size(152, 23);
            cepCliente.TabIndex = 11;
            // 
            // ufCliente
            // 
            ufCliente.Location = new Point(112, 221);
            ufCliente.Name = "ufCliente";
            ufCliente.Size = new Size(158, 23);
            ufCliente.TabIndex = 10;
            // 
            // cidadeCliente
            // 
            cidadeCliente.Location = new Point(112, 171);
            cidadeCliente.Name = "cidadeCliente";
            cidadeCliente.Size = new Size(158, 23);
            cidadeCliente.TabIndex = 9;
            // 
            // complementoCliente
            // 
            complementoCliente.Location = new Point(112, 112);
            complementoCliente.Name = "complementoCliente";
            complementoCliente.Size = new Size(158, 23);
            complementoCliente.TabIndex = 8;
            // 
            // numeroCliente
            // 
            numeroCliente.Location = new Point(112, 63);
            numeroCliente.Name = "numeroCliente";
            numeroCliente.Size = new Size(158, 23);
            numeroCliente.TabIndex = 7;
            // 
            // logradouroCliente
            // 
            logradouroCliente.Location = new Point(112, 22);
            logradouroCliente.Name = "logradouroCliente";
            logradouroCliente.Size = new Size(158, 23);
            logradouroCliente.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 283);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 5;
            label10.Text = "CEP:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 224);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 4;
            label9.Text = "UF (Estado):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 174);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 3;
            label8.Text = "Cidade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 115);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 2;
            label7.Text = "Complemento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 63);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 1;
            label6.Text = "Número:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 0;
            label5.Text = "Logradouro(Rua):";
            // 
            // nomeCliente
            // 
            nomeCliente.Location = new Point(94, 16);
            nomeCliente.Name = "nomeCliente";
            nomeCliente.Size = new Size(202, 23);
            nomeCliente.TabIndex = 5;
            // 
            // telefoneCliente
            // 
            telefoneCliente.Location = new Point(94, 54);
            telefoneCliente.Name = "telefoneCliente";
            telefoneCliente.Size = new Size(202, 23);
            telefoneCliente.TabIndex = 6;
            // 
            // emailCliente
            // 
            emailCliente.Location = new Point(94, 98);
            emailCliente.Name = "emailCliente";
            emailCliente.Size = new Size(202, 23);
            emailCliente.TabIndex = 7;
            // 
            // cancelarbutton1
            // 
            cancelarbutton1.Location = new Point(233, 454);
            cancelarbutton1.Name = "cancelarbutton1";
            cancelarbutton1.Size = new Size(75, 23);
            cancelarbutton1.TabIndex = 8;
            cancelarbutton1.Text = "Cancelar";
            cancelarbutton1.UseVisualStyleBackColor = true;
            cancelarbutton1.Click += cancelarbutton1_Click;
            // 
            // okbutton2
            // 
            okbutton2.Location = new Point(126, 454);
            okbutton2.Name = "okbutton2";
            okbutton2.Size = new Size(75, 23);
            okbutton2.TabIndex = 9;
            okbutton2.Text = "Ok";
            okbutton2.UseVisualStyleBackColor = true;
            okbutton2.Click += okbutton2_Click;
            // 
            // CriarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 484);
            Controls.Add(okbutton2);
            Controls.Add(cancelarbutton1);
            Controls.Add(emailCliente);
            Controls.Add(telefoneCliente);
            Controls.Add(nomeCliente);
            Controls.Add(Endereço);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CriarCliente";
            Text = "CriarCliente";
            Load += CriarCliente_Load;
            Endereço.ResumeLayout(false);
            Endereço.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox Endereço;
        private TextBox nomeCliente;
        private TextBox telefoneCliente;
        private TextBox emailCliente;
        private TextBox cepCliente;
        private TextBox ufCliente;
        private TextBox cidadeCliente;
        private TextBox complementoCliente;
        private TextBox numeroCliente;
        private TextBox logradouroCliente;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button cancelarbutton1;
        private Button okbutton2;
    }
}