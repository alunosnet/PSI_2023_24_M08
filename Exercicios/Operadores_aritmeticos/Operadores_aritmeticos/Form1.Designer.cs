namespace Operadores_aritmeticos
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
            this.components = new System.ComponentModel.Container();
            this.tb_n1 = new System.Windows.Forms.TextBox();
            this.tb_n2 = new System.Windows.Forms.TextBox();
            this.cb_operadores = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_resultado = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tb_n1
            // 
            this.tb_n1.Location = new System.Drawing.Point(98, 55);
            this.tb_n1.Name = "tb_n1";
            this.tb_n1.Size = new System.Drawing.Size(90, 20);
            this.tb_n1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tb_n1, "Introduza um número");
            // 
            // tb_n2
            // 
            this.tb_n2.Location = new System.Drawing.Point(264, 55);
            this.tb_n2.Name = "tb_n2";
            this.tb_n2.Size = new System.Drawing.Size(90, 20);
            this.tb_n2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tb_n2, "Introduza outro número");
            // 
            // cb_operadores
            // 
            this.cb_operadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_operadores.FormattingEnabled = true;
            this.cb_operadores.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cb_operadores.Location = new System.Drawing.Point(211, 55);
            this.cb_operadores.Name = "cb_operadores";
            this.cb_operadores.Size = new System.Drawing.Size(29, 21);
            this.cb_operadores.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cb_operadores, "Escolha a operação");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 18);
            this.button1.TabIndex = 3;
            this.button1.Text = "=";
            this.toolTip1.SetToolTip(this.button1, "Clique para obter o resultado");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_resultado
            // 
            this.tb_resultado.Location = new System.Drawing.Point(438, 58);
            this.tb_resultado.Name = "tb_resultado";
            this.tb_resultado.Size = new System.Drawing.Size(67, 20);
            this.tb_resultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 134);
            this.Controls.Add(this.tb_resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_operadores);
            this.Controls.Add(this.tb_n2);
            this.Controls.Add(this.tb_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_n1;
        private System.Windows.Forms.TextBox tb_n2;
        private System.Windows.Forms.ComboBox cb_operadores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_resultado;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

