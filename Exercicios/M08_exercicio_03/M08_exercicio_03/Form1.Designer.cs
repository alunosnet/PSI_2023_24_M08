namespace M08_exercicio_03
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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_nomes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(128, 63);
            this.tb_nome.MaxLength = 20;
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(252, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_nomes
            // 
            this.cb_nomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nomes.FormattingEnabled = true;
            this.cb_nomes.Location = new System.Drawing.Point(115, 118);
            this.cb_nomes.Name = "cb_nomes";
            this.cb_nomes.Size = new System.Drawing.Size(264, 21);
            this.cb_nomes.TabIndex = 3;
            this.cb_nomes.SelectedIndexChanged += new System.EventHandler(this.cb_nomes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_nomes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_nomes;
    }
}

