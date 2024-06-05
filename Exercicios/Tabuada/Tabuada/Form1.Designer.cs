namespace Tabuada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.lb_tabuada = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabuada de";
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(128, 31);
            this.tb_numero.MaxLength = 2;
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(129, 20);
            this.tb_numero.TabIndex = 1;
            this.tb_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_numero_KeyPress);
            // 
            // lb_tabuada
            // 
            this.lb_tabuada.FormattingEnabled = true;
            this.lb_tabuada.Location = new System.Drawing.Point(34, 86);
            this.lb_tabuada.Name = "lb_tabuada";
            this.lb_tabuada.Size = new System.Drawing.Size(222, 212);
            this.lb_tabuada.TabIndex = 2;
            this.lb_tabuada.SelectedIndexChanged += new System.EventHandler(this.lb_tabuada_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tabuada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_tabuada);
            this.Controls.Add(this.tb_numero);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.ListBox lb_tabuada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

