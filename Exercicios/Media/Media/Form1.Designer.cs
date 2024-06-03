namespace Media
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
            this.tb_n1 = new System.Windows.Forms.TextBox();
            this.tb_n2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_n3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_media = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N1";
            // 
            // tb_n1
            // 
            this.tb_n1.Location = new System.Drawing.Point(143, 69);
            this.tb_n1.Name = "tb_n1";
            this.tb_n1.Size = new System.Drawing.Size(137, 20);
            this.tb_n1.TabIndex = 1;
            // 
            // tb_n2
            // 
            this.tb_n2.Location = new System.Drawing.Point(143, 119);
            this.tb_n2.Name = "tb_n2";
            this.tb_n2.Size = new System.Drawing.Size(137, 20);
            this.tb_n2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N2";
            // 
            // tb_n3
            // 
            this.tb_n3.Location = new System.Drawing.Point(143, 167);
            this.tb_n3.Name = "tb_n3";
            this.tb_n3.Size = new System.Drawing.Size(137, 20);
            this.tb_n3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "N3";
            // 
            // lb_media
            // 
            this.lb_media.AutoSize = true;
            this.lb_media.Location = new System.Drawing.Point(89, 287);
            this.lb_media.Name = "lb_media";
            this.lb_media.Size = new System.Drawing.Size(39, 13);
            this.lb_media.TabIndex = 6;
            this.lb_media.Text = "Label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Média";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_media);
            this.Controls.Add(this.tb_n3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_n2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_n1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Média";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_n1;
        private System.Windows.Forms.TextBox tb_n2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_n3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_media;
        private System.Windows.Forms.Button button1;
    }
}

