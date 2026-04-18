namespace AV;

public partial class MainPage : ContentPage
{
    double temperaturaEntry = 0;
    public MainPage()
    {
        InitializeComponent();
    }

    private void TemperaturaInicialSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valor = e.NewValue;

        TemperaturaInicialEntry.Text = valor.ToString("F");
    }

    private void ConverterCelsiusButton_Clicked(object sender, EventArgs e)
    {
        double temperaturaInicial = Convert.ToDouble(TemperaturaInicialEntry.Text);
        double resultado = (temperaturaInicial - 32) * 5 / 9;
        TemperaturaConvertidaLabel.Text = resultado.ToString("F");
        
        // se for quente
        if( resultado > 24 )
        {
            ClimaImagem.Source = "sol.png";
        // se for ameno
        }
        else if( resultado > 18)
        {
            ClimaImagem.Source = "nublado.png";
        }
        // se for frio
        else
        {
            ClimaImagem.Source = "floco.png";
        }
    }

    private void ConverterFahrenheitButton_Clicked(object sender, EventArgs e)
    {
        temperaturaEntry = Convert.ToDouble(TemperaturaInicialEntry.Text);
        double resultado = (temperaturaEntry * 9 / 5) + 32;

        TemperaturaConvertidaLabel.Text = resultado.ToString("F");

        // se for quente
        if (resultado > 24)
        {
            ClimaImagem.Source = "sol.png";
            // se for ameno
        }
        else if (resultado > 18)
        {
            ClimaImagem.Source = "nublado.png";
        }
        // se for frio
        else
        {
            ClimaImagem.Source = "floco.png";
        }
    }
}