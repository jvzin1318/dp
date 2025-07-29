namespace dp
{
    partial class Form1
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
            salariobruto = new Label();
            txtsalariobruto = new TextBox();
            inss = new Label();
            txtinss = new TextBox();
            fgts = new Label();
            txtfgts = new TextBox();
            ir = new Label();
            txtir = new TextBox();
            vt = new Label();
            txtvt = new TextBox();
            salarioliquido = new Label();
            txtsalarioliquido = new TextBox();
            ENVIAR = new Button();
            SuspendLayout();
            // 
            // salariobruto
            // 
            salariobruto.AutoSize = true;
            salariobruto.Location = new Point(37, 25);
            salariobruto.Name = "salariobruto";
            salariobruto.Size = new Size(112, 25);
            salariobruto.TabIndex = 0;
            salariobruto.Text = "salario bruto";
            // 
            // txtsalariobruto
            // 
            txtsalariobruto.Location = new Point(37, 53);
            txtsalariobruto.Name = "txtsalariobruto";
            txtsalariobruto.Size = new Size(150, 31);
            txtsalariobruto.TabIndex = 1;
            // 
            // inss
            // 
            inss.AutoSize = true;
            inss.Location = new Point(37, 109);
            inss.Name = "inss";
            inss.Size = new Size(42, 25);
            inss.TabIndex = 2;
            inss.Text = "inss";
            // 
            // txtinss
            // 
            txtinss.Location = new Point(37, 137);
            txtinss.Name = "txtinss";
            txtinss.Size = new Size(150, 31);
            txtinss.TabIndex = 3;
            txtinss.TextChanged += txtinss_TextChanged;
            // 
            // fgts
            // 
            fgts.AutoSize = true;
            fgts.Location = new Point(37, 184);
            fgts.Name = "fgts";
            fgts.Size = new Size(43, 25);
            fgts.TabIndex = 4;
            fgts.Text = "fgts";
            // 
            // txtfgts
            // 
            txtfgts.Location = new Point(37, 212);
            txtfgts.Name = "txtfgts";
            txtfgts.Size = new Size(150, 31);
            txtfgts.TabIndex = 5;
            txtfgts.TextChanged += txtfgts_TextChanged;
            // 
            // ir
            // 
            ir.AutoSize = true;
            ir.Location = new Point(37, 259);
            ir.Name = "ir";
            ir.Size = new Size(22, 25);
            ir.TabIndex = 6;
            ir.Text = "ir";
            // 
            // txtir
            // 
            txtir.Location = new Point(37, 287);
            txtir.Name = "txtir";
            txtir.Size = new Size(150, 31);
            txtir.TabIndex = 7;
            // 
            // vt
            // 
            vt.AutoSize = true;
            vt.Location = new Point(37, 336);
            vt.Name = "vt";
            vt.Size = new Size(27, 25);
            vt.TabIndex = 8;
            vt.Text = "vt";
            // 
            // txtvt
            // 
            txtvt.Location = new Point(37, 364);
            txtvt.Name = "txtvt";
            txtvt.Size = new Size(150, 31);
            txtvt.TabIndex = 9;
            // 
            // salarioliquido
            // 
            salarioliquido.AutoSize = true;
            salarioliquido.Location = new Point(561, 156);
            salarioliquido.Name = "salarioliquido";
            salarioliquido.Size = new Size(123, 25);
            salarioliquido.TabIndex = 10;
            salarioliquido.Text = "salario liquido";
            // 
            // txtsalarioliquido
            // 
            txtsalarioliquido.Location = new Point(561, 193);
            txtsalarioliquido.Name = "txtsalarioliquido";
            txtsalarioliquido.Size = new Size(150, 31);
            txtsalarioliquido.TabIndex = 11;
            // 
            // ENVIAR
            // 
            ENVIAR.Location = new Point(327, 194);
            ENVIAR.Name = "ENVIAR";
            ENVIAR.Size = new Size(112, 34);
            ENVIAR.TabIndex = 12;
            ENVIAR.Text = "ENVIAR";
            ENVIAR.UseVisualStyleBackColor = true;
            ENVIAR.Click += ENVIAR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ENVIAR);
            Controls.Add(txtsalarioliquido);
            Controls.Add(salarioliquido);
            Controls.Add(txtvt);
            Controls.Add(vt);
            Controls.Add(txtir);
            Controls.Add(ir);
            Controls.Add(txtfgts);
            Controls.Add(fgts);
            Controls.Add(txtinss);
            Controls.Add(inss);
            Controls.Add(txtsalariobruto);
            Controls.Add(salariobruto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label salariobruto;
        private TextBox txtsalariobruto;
        private Label inss;
        private TextBox txtinss;
        private Label fgts;
        private TextBox txtfgts;
        private Label ir;
        private TextBox txtir;
        private Label vt;
        private TextBox txtvt;
        private Label salarioliquido;
        private TextBox txtsalarioliquido;
        private Button ENVIAR;
    }
}
