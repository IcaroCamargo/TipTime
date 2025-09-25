namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        private double valorNumerico;
        private double valorSlider;

        public MainPage()
        {
            InitializeComponent();
        }
        
       
        private void Porcentagem15_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
            double porcento15;
            porcento15 = valorNumerico * 0.15;
            double valtotal;
            valtotal = porcento15 + valorNumerico;
            PorcentagemGorjetaLabel.Text = PorcentagemSlider.Value + "%";
            ValorGorjetaLabel.Text = porcento15.ToString();
            ValorTotalLabel.Text = valtotal.ToString();


        }

        private void Porcentagem20_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
            double porcento20;
            porcento20 = valorNumerico * 0.2;
            double valtotal;
            valtotal = porcento20 + valorNumerico;
            PorcentagemGorjetaLabel.Text = PorcentagemSlider.Value + "%";
            ValorGorjetaLabel.Text = porcento20.ToString();
            ValorTotalLabel.Text = valtotal.ToString();
        }

        private void ArredondamentoAcima_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = Math.Ceiling(PorcentagemSlider.Value);
        }

        private void ArredondamentoAbaixo_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = Math.Floor(PorcentagemSlider.Value);
        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            valorSlider = e.NewValue;
            double valgorjeta, valtotal;
            valgorjeta = valorNumerico * (valorSlider / 100);
            valtotal = valorNumerico + valgorjeta;
            PorcentagemGorjetaLabel.Text = $"{valorSlider:F1}%";
            ValorTotalLabel.Text =(valtotal.ToString("F1"));
            ValorGorjetaLabel.Text = (valgorjeta.ToString("F1"));

        }

        private void ValorTotalEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(e.NewTextValue, out int numero))
            {
                valorNumerico = numero;
            }
            else
            {
                valorNumerico = 0;
            }
        }

        private void ArredondarAcimaValorTotal_Clicked(object sender, EventArgs e)
        {
            double valgorjeta, valtotal;
            valgorjeta = valorNumerico * (valorSlider / 100);
            valtotal = valorNumerico + valgorjeta;
            double arac = Math.Ceiling(valtotal);
            ValorGorjetaLabel.Text = (arac - valorNumerico).ToString();
            ValorTotalLabel.Text = arac.ToString();
        }

        private void ArredondarAbaixoValorTotal_Clicked(object sender, EventArgs e)
        {
            double valgorjeta, valtotal;
            valgorjeta = valorNumerico * (valorSlider / 100);
            valtotal = valorNumerico + valgorjeta;
            double arac = Math.Floor(valtotal);
            ValorGorjetaLabel.Text = (arac - valorNumerico).ToString();
            ValorTotalLabel.Text = arac.ToString();
        }
    }

}
