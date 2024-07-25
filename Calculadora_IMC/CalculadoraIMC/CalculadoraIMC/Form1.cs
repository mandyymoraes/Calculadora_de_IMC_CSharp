namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        private enum Classificacoes
        {
            MuitoAbaixodoPeso,
            AbaixodoPeso,
            PesoNormal,
            AcimadoPeso,
            ObesidadeI,
            ObesidadeII,
            ObesidadeIII
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            // Leitura dos valores de peso e altura dos campos de entrada
            double peso = Convert.ToDouble(inputPeso.Text);
            double altura = Convert.ToDouble(inputAltura.Text);

            // Cálculo do IMC
            double imc = peso / (altura * altura);
            imcValor.Text = imc.ToString("F2"); // Formatação do IMC com duas casas decimais
            imcValor.Visible = true;
            labelImc.Visible = true;

            // Classificação do IMC
            string categoria;
            if (imc <= 16.9)
            {
                categoria = "Muito Abaixo do Peso";
            }
            else if (imc >= 17 && imc <= 18.4)
            {
                categoria = "Abaixo do Peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                categoria = "Peso Normal";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                categoria = "Acima do Peso";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                categoria = "Obesidade I";
            }
            else if (imc >= 35 && imc <= 40)
            {
                categoria = "Obesidade II";
            }
            else
            {
                categoria = "Obesidade III";
            }

            classificacaoImc.Text = categoria;
            classificacaoImc.Visible = true;
            labelClassificacao.Visible = true;
        }
    }
}
