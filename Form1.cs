namespace dp
{
    public partial class Form1 : Form
    {
        private double CalcularINSS(double salario)
        {
            double inss;

            if (salario <= 1320.00)
            {
                inss = salario * 0.075;
            }
            else if (salario <= 2571.29)
            {
                inss = 1320.00 * 0.075 +
                       (salario - 1320.00) * 0.09;
            }
            else if (salario <= 3856.94)
            {
                inss = 1320.00 * 0.075 +
                       (2571.29 - 1320.00) * 0.09 +
                       (salario - 2571.29) * 0.12;
            }
            else if (salario <= 7507.49)
            {
                inss = 1320.00 * 0.075 +
                       (2571.29 - 1320.00) * 0.09 +
                       (3856.94 - 2571.29) * 0.12 +
                       (salario - 3856.94) * 0.14;
            }
            else
            {
                
                inss = 1320.00 * 0.075 +
                       (2571.29 - 1320.00) * 0.09 +
                       (3856.94 - 2571.29) * 0.12 +
                       (7507.49 - 3856.94) * 0.14;
            }

            return inss;
        }
        private double CalcularIRRF(double salarioBruto, double inss)
        {
            double baseCalculo = salarioBruto - inss;
            double irrf = 0;

            if (baseCalculo <= 2112.00)
            {
                irrf = 0;
            }
            else if (baseCalculo <= 2826.65)
            {
                irrf = (baseCalculo * 0.075) - 158.40;
            }
            else if (baseCalculo <= 3751.05)
            {
                irrf = (baseCalculo * 0.15) - 370.40;
            }
            else if (baseCalculo <= 4664.68)
            {
                irrf = (baseCalculo * 0.225) - 651.73;
            }
            else
            {
                irrf = (baseCalculo * 0.275) - 884.96;
            }

           
            return Math.Max(irrf, 0);
        }

        public Form1()
        {

            InitializeComponent();
        }

        public void ENVIAR_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtsalariobruto.Text, out double salarioBruto))
            {
                double fgts = salarioBruto * 0.08;
                txtfgts.Text = fgts.ToString("f2");
            }

            double inss = CalcularINSS(salarioBruto);
            txtinss.Text = inss.ToString("f2");

            if (double.TryParse(txtsalariobruto.Text, out double salariobruto))
            {
                double vt = salariobruto * 0.06;
                txtvt.Text = vt.ToString("f2");
            }
            double irrf = CalcularIRRF(salarioBruto, inss);
            double salarioLiquido = salarioBruto - inss - irrf;

            txtir.Text = irrf.ToString("F2");
            txtsalarioliquido.Text = salarioLiquido.ToString("F2");

        }

        public void txtinss_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtfgts_TextChanged(object sender, EventArgs e)
        {
          
            
        }
    }
}
