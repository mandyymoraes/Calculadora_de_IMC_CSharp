namespace CalculadoraIMC
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
            labelPeso = new Label();
            inputPeso = new TextBox();
            inputAltura = new TextBox();
            alturaLabel = new Label();
            resultado = new Button();
            imcValor = new Label();
            classificacaoImc = new Label();
            labelImc = new Label();
            labelClassificacao = new Label();
            SuspendLayout();
            // 
            // labelPeso
            // 
            labelPeso.AutoSize = true;
            labelPeso.ForeColor = Color.White;
            labelPeso.Location = new Point(43, 40);
            labelPeso.Name = "labelPeso";
            labelPeso.Size = new Size(119, 21);
            labelPeso.TabIndex = 0;
            labelPeso.Text = "Digite seu peso:";
            // 
            // inputPeso
            // 
            inputPeso.BackColor = SystemColors.Window;
            inputPeso.Location = new Point(43, 80);
            inputPeso.Name = "inputPeso";
            inputPeso.PlaceholderText = "58,00";
            inputPeso.Size = new Size(307, 29);
            inputPeso.TabIndex = 1;
            // 
            // inputAltura
            // 
            inputAltura.BackColor = SystemColors.Window;
            inputAltura.Location = new Point(43, 185);
            inputAltura.Name = "inputAltura";
            inputAltura.PlaceholderText = "1,58";
            inputAltura.Size = new Size(307, 29);
            inputAltura.TabIndex = 3;
            // 
            // alturaLabel
            // 
            alturaLabel.AutoSize = true;
            alturaLabel.ForeColor = Color.White;
            alturaLabel.Location = new Point(42, 142);
            alturaLabel.Name = "alturaLabel";
            alturaLabel.Size = new Size(126, 21);
            alturaLabel.TabIndex = 2;
            alturaLabel.Text = "Digite sua altura:";
            // 
            // resultado
            // 
            resultado.BackColor = Color.FromArgb(102, 155, 188);
            resultado.ForeColor = Color.FromArgb(254, 254, 254);
            resultado.Location = new Point(383, 120);
            resultado.Name = "resultado";
            resultado.Size = new Size(147, 53);
            resultado.TabIndex = 4;
            resultado.Text = "Calcular IMC";
            resultado.UseVisualStyleBackColor = false;
            resultado.Click += resultado_Click;
            // 
            // imcValor
            // 
            imcValor.AutoSize = true;
            imcValor.BackColor = Color.FromArgb(102, 155, 188);
            imcValor.Font = new Font("Segoe UI", 18F);
            imcValor.ForeColor = Color.FromArgb(34, 34, 34);
            imcValor.Location = new Point(59, 328);
            imcValor.Name = "imcValor";
            imcValor.Size = new Size(57, 32);
            imcValor.TabIndex = 5;
            imcValor.Text = "IMC";
            imcValor.Visible = false;
            // 
            // classificacaoImc
            // 
            classificacaoImc.AutoSize = true;
            classificacaoImc.BackColor = Color.FromArgb(102, 155, 188);
            classificacaoImc.Font = new Font("Segoe UI", 18F);
            classificacaoImc.ForeColor = Color.FromArgb(34, 34, 34);
            classificacaoImc.Location = new Point(271, 324);
            classificacaoImc.Name = "classificacaoImc";
            classificacaoImc.Size = new Size(147, 32);
            classificacaoImc.TabIndex = 6;
            classificacaoImc.Text = "Classificação";
            classificacaoImc.Visible = false;
            // 
            // labelImc
            // 
            labelImc.AutoSize = true;
            labelImc.ForeColor = Color.White;
            labelImc.Location = new Point(49, 275);
            labelImc.Name = "labelImc";
            labelImc.Size = new Size(104, 21);
            labelImc.TabIndex = 7;
            labelImc.Text = "Valor do IMC ";
            labelImc.Visible = false;
            // 
            // labelClassificacao
            // 
            labelClassificacao.AutoSize = true;
            labelClassificacao.ForeColor = Color.White;
            labelClassificacao.Location = new Point(271, 275);
            labelClassificacao.Name = "labelClassificacao";
            labelClassificacao.Size = new Size(152, 21);
            labelClassificacao.TabIndex = 8;
            labelClassificacao.Text = "Classificação do IMC";
            labelClassificacao.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 48, 73);
            ClientSize = new Size(558, 411);
            Controls.Add(labelClassificacao);
            Controls.Add(labelImc);
            Controls.Add(classificacaoImc);
            Controls.Add(imcValor);
            Controls.Add(resultado);
            Controls.Add(inputAltura);
            Controls.Add(alturaLabel);
            Controls.Add(inputPeso);
            Controls.Add(labelPeso);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Calculadora IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPeso;
        private TextBox inputPeso;
        private TextBox inputAltura;
        private Label alturaLabel;
        private Button resultado;
        private Label imcValor;
        private Label classificacaoImc;
        private Label labelImc;
        private Label labelClassificacao;
    }
}
