namespace PrjTradutorList
{
    partial class Tradutor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            lblResultado = new Label();
            btn = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(23, 81);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(74, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Português";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(23, 116);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(186, 27);
            txtBox1.TabIndex = 1;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(264, 116);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(186, 27);
            txtBox2.TabIndex = 3;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(264, 81);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(48, 20);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Inglês";
            // 
            // btn
            // 
            btn.Location = new Point(23, 161);
            btn.Name = "btn";
            btn.Size = new Size(427, 29);
            btn.TabIndex = 4;
            btn.Text = "Traduzir";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // Tradutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 234);
            Controls.Add(btn);
            Controls.Add(txtBox2);
            Controls.Add(lblResultado);
            Controls.Add(txtBox1);
            Controls.Add(lblTitulo);
            Name = "Tradutor";
            Text = "Tradutor";
            Load += Tradutor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtBox1;
        private TextBox txtBox2;
        private Label lblResultado;
        private Button btn;
    }
}
