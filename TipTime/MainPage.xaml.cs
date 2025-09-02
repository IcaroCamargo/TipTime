namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        private int _valor;

        public MainPage()
        {
            InitializeComponent();
        }
        
       
        private void Porcentagem15_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
            _valor = 15;
            ValorGorjetaLabel.Text = _valor + "%";

        }

        private void Porcentagem20_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
            _valor = 20;
            ValorGorjetaLabel.Text = _valor + "%";
        }

        private void ArredondamentoAcima_Clicked(object sender, EventArgs e)
        {

        }

        private void ArredondamentoAbaixo_Clicked(object sender, EventArgs e)
        {

        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

             
        }

        private void ValorTotalEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(e.NewTextValue, out double numero))
            
                ValorTotalLabel.Text = numero.ToString();
            
        }
    }

}
