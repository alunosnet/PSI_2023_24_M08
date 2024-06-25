namespace Checks_Radio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_ativo = new System.Windows.Forms.RadioButton();
            this.rb_bloqueado = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ckb_admin = new System.Windows.Forms.CheckBox();
            this.ckb_cliente = new System.Windows.Forms.CheckBox();
            this.ckb_gestor = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.nd_idade = new System.Windows.Forms.NumericUpDown();
            this.lb_mensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nd_idade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado da conta:";
            // 
            // rb_ativo
            // 
            this.rb_ativo.AutoSize = true;
            this.rb_ativo.Checked = true;
            this.rb_ativo.Location = new System.Drawing.Point(212, 135);
            this.rb_ativo.Name = "rb_ativo";
            this.rb_ativo.Size = new System.Drawing.Size(49, 17);
            this.rb_ativo.TabIndex = 3;
            this.rb_ativo.TabStop = true;
            this.rb_ativo.Text = "Ativo";
            this.rb_ativo.UseVisualStyleBackColor = true;
            // 
            // rb_bloqueado
            // 
            this.rb_bloqueado.AutoSize = true;
            this.rb_bloqueado.Location = new System.Drawing.Point(324, 135);
            this.rb_bloqueado.Name = "rb_bloqueado";
            this.rb_bloqueado.Size = new System.Drawing.Size(76, 17);
            this.rb_bloqueado.TabIndex = 4;
            this.rb_bloqueado.Text = "Bloqueado";
            this.rb_bloqueado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Perfil de utilizador";
            // 
            // ckb_admin
            // 
            this.ckb_admin.AutoSize = true;
            this.ckb_admin.Location = new System.Drawing.Point(210, 184);
            this.ckb_admin.Name = "ckb_admin";
            this.ckb_admin.Size = new System.Drawing.Size(89, 17);
            this.ckb_admin.TabIndex = 6;
            this.ckb_admin.Text = "Administrador";
            this.ckb_admin.UseVisualStyleBackColor = true;
            // 
            // ckb_cliente
            // 
            this.ckb_cliente.AutoSize = true;
            this.ckb_cliente.Location = new System.Drawing.Point(322, 184);
            this.ckb_cliente.Name = "ckb_cliente";
            this.ckb_cliente.Size = new System.Drawing.Size(58, 17);
            this.ckb_cliente.TabIndex = 7;
            this.ckb_cliente.Text = "Cliente";
            this.ckb_cliente.UseVisualStyleBackColor = true;
            // 
            // ckb_gestor
            // 
            this.ckb_gestor.AutoSize = true;
            this.ckb_gestor.Location = new System.Drawing.Point(406, 184);
            this.ckb_gestor.Name = "ckb_gestor";
            this.ckb_gestor.Size = new System.Drawing.Size(57, 17);
            this.ckb_gestor.TabIndex = 8;
            this.ckb_gestor.Text = "Gestor";
            this.ckb_gestor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 59);
            this.button2.TabIndex = 10;
            this.button2.Text = "Validar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(212, 49);
            this.tb_nome.MaxLength = 50;
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(230, 20);
            this.tb_nome.TabIndex = 11;
            // 
            // nd_idade
            // 
            this.nd_idade.Location = new System.Drawing.Point(212, 90);
            this.nd_idade.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nd_idade.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nd_idade.Name = "nd_idade";
            this.nd_idade.Size = new System.Drawing.Size(101, 20);
            this.nd_idade.TabIndex = 12;
            this.nd_idade.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lb_mensagem
            // 
            this.lb_mensagem.AutoSize = true;
            this.lb_mensagem.Location = new System.Drawing.Point(91, 223);
            this.lb_mensagem.Name = "lb_mensagem";
            this.lb_mensagem.Size = new System.Drawing.Size(0, 13);
            this.lb_mensagem.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 406);
            this.Controls.Add(this.lb_mensagem);
            this.Controls.Add(this.nd_idade);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckb_gestor);
            this.Controls.Add(this.ckb_cliente);
            this.Controls.Add(this.ckb_admin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_bloqueado);
            this.Controls.Add(this.rb_ativo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nd_idade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_ativo;
        private System.Windows.Forms.RadioButton rb_bloqueado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckb_admin;
        private System.Windows.Forms.CheckBox ckb_cliente;
        private System.Windows.Forms.CheckBox ckb_gestor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.NumericUpDown nd_idade;
        private System.Windows.Forms.Label lb_mensagem;
    }
}

