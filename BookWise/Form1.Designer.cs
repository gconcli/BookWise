namespace BookWise
{
    partial class Cadastros
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastros));
            this.iblNome = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.checkBAceitar = new System.Windows.Forms.CheckBox();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.botao_Cadastrar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iblNome
            // 
            this.iblNome.AutoSize = true;
            this.iblNome.BackColor = System.Drawing.Color.Transparent;
            this.iblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblNome.ForeColor = System.Drawing.Color.White;
            this.iblNome.Location = new System.Drawing.Point(46, 82);
            this.iblNome.Name = "iblNome";
            this.iblNome.Size = new System.Drawing.Size(101, 36);
            this.iblNome.TabIndex = 0;
            this.iblNome.Text = "Nome:";
            this.iblNome.Click += new System.EventHandler(this.iblNome_Click);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.ForeColor = System.Drawing.Color.White;
            this.lblBirthday.Location = new System.Drawing.Point(46, 139);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(278, 36);
            this.lblBirthday.TabIndex = 1;
            this.lblBirthday.Text = "Ano de nascimento:";
            this.lblBirthday.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(46, 200);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(82, 36);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(46, 265);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(122, 36);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.Transparent;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.White;
            this.lblCEP.Location = new System.Drawing.Point(46, 327);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(84, 36);
            this.lblCEP.TabIndex = 4;
            this.lblCEP.Text = "CEP:";
            this.lblCEP.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNome.Location = new System.Drawing.Point(153, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(217, 32);
            this.txtNome.TabIndex = 5;
            this.txtNome.Text = "Nome Completo";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCPF.Location = new System.Drawing.Point(134, 204);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(217, 32);
            this.txtCPF.TabIndex = 7;
            this.txtCPF.Text = "000.000.000-00";
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCEP.Location = new System.Drawing.Point(134, 331);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(171, 32);
            this.txtCEP.TabIndex = 9;
            this.txtCEP.Text = "00000-000";
            // 
            // checkBAceitar
            // 
            this.checkBAceitar.AutoSize = true;
            this.checkBAceitar.BackColor = System.Drawing.Color.Transparent;
            this.checkBAceitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBAceitar.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBAceitar.Location = new System.Drawing.Point(52, 456);
            this.checkBAceitar.Name = "checkBAceitar";
            this.checkBAceitar.Size = new System.Drawing.Size(166, 17);
            this.checkBAceitar.TabIndex = 10;
            this.checkBAceitar.Text = "Aceitar os termos de uso";
            this.checkBAceitar.UseVisualStyleBackColor = false;
            this.checkBAceitar.CheckedChanged += new System.EventHandler(this.cbTermos_CheckedChanged);
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereço.ForeColor = System.Drawing.Color.White;
            this.lblEndereço.Location = new System.Drawing.Point(46, 384);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(151, 36);
            this.lblEndereço.TabIndex = 11;
            this.lblEndereço.Text = "Endereço:";
            this.lblEndereço.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtEndereço
            // 
            this.txtEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereço.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtEndereço.Location = new System.Drawing.Point(203, 388);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(250, 32);
            this.txtEndereço.TabIndex = 12;
            this.txtEndereço.Text = "Av. Brasil, 00";
            // 
            // botao_Cadastrar
            // 
            this.botao_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_Cadastrar.Location = new System.Drawing.Point(352, 445);
            this.botao_Cadastrar.Name = "botao_Cadastrar";
            this.botao_Cadastrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.botao_Cadastrar.Size = new System.Drawing.Size(101, 34);
            this.botao_Cadastrar.TabIndex = 13;
            this.botao_Cadastrar.Text = "Cadastrar";
            this.botao_Cadastrar.UseVisualStyleBackColor = true;
            this.botao_Cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "",
            "Cisgênero",
            "Transgênero",
            "Não Binário"});
            this.listBox1.Location = new System.Drawing.Point(174, 268);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 29);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd.mm.yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 32);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2023, 7, 28, 11, 16, 56, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.BackColor = System.Drawing.Color.Transparent;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.ForeColor = System.Drawing.Color.White;
            this.lblBook.Location = new System.Drawing.Point(161, 25);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(190, 36);
            this.lblBook.TabIndex = 16;
            this.lblBook.Text = "BIBLIOTECA";
            this.lblBook.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Cadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(490, 516);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.botao_Cadastrar);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.checkBAceitar);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.iblNome);
            this.Name = "Cadastros";
            this.Text = "Sistema de Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iblNome;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.CheckBox checkBAceitar;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.Button botao_Cadastrar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblBook;
    }
}

