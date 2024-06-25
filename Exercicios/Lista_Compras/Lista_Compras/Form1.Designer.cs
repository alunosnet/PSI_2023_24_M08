namespace Lista_Compras
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
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_total_pagar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_lista_compras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(948, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Compras";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label1, "Lista de Compras");
            // 
            // tb_produto
            // 
            this.tb_produto.Location = new System.Drawing.Point(117, 81);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(192, 20);
            this.tb_produto.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tb_produto, "Produto a comprar");
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(115, 120);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(128, 20);
            this.tb_preco.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tb_preco, "Preço do produto");
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(115, 159);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(128, 20);
            this.tb_quantidade.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tb_quantidade, "Quantidade a comprar do produto");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = ">>";
            this.toolTip1.SetToolTip(this.button1, "Adicionar à lista de compras");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(433, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpar";
            this.toolTip1.SetToolTip(this.button2, "Limpar a lista de compras");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_total_pagar
            // 
            this.lbl_total_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_pagar.ForeColor = System.Drawing.Color.Red;
            this.lbl_total_pagar.Location = new System.Drawing.Point(371, 166);
            this.lbl_total_pagar.Name = "lbl_total_pagar";
            this.lbl_total_pagar.Size = new System.Drawing.Size(105, 34);
            this.lbl_total_pagar.TabIndex = 10;
            this.lbl_total_pagar.Text = "0";
            this.lbl_total_pagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lbl_total_pagar, "Total a pagar");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantidade";
            // 
            // lb_lista_compras
            // 
            this.lb_lista_compras.FormattingEnabled = true;
            this.lb_lista_compras.Location = new System.Drawing.Point(554, 77);
            this.lb_lista_compras.Name = "lb_lista_compras";
            this.lb_lista_compras.Size = new System.Drawing.Size(434, 82);
            this.lb_lista_compras.TabIndex = 7;
            this.lb_lista_compras.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 266);
            this.Controls.Add(this.lbl_total_pagar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_lista_compras);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_produto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.ListBox lb_lista_compras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_total_pagar;
    }
}

