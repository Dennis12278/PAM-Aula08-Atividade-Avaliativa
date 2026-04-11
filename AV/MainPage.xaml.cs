namespace AV;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void ConverterParaFahrenheit(object sender, EventArgs e)
    {
        if (double.TryParse(EntradaTemp.Text, out double celsius))
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            TemperaturaConvertida.Text = $"{fahrenheit:F2} °F";
        }
        else
        {
            TemperaturaConvertida.Text = "Valor inválido";
        }
    }

    private void ConverterParaCelsius(object sender, EventArgs e)
    {
        if (double.TryParse(EntradaTemp.Text, out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            TemperaturaConvertida.Text = $"{celsius:F2} °C";
        }
        else
        {
            TemperaturaConvertida.Text = "Valor inválido";
        }
    }

    private void SliderTemp_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valor = e.NewValue;

        EntradaTemp.Text = valor.ToString("F0");

        TemperaturaConvertida.Text = $"{valor:F0} °C";

        if (valor > 26)
        {
            ImagemClima.Source = "sol.png";
        }
        else if (valor > 18)
        {
            ImagemClima.Source = "nublado.png";
        }
        else
        {
            ImagemClima.Source = "floco.png";
        }
    }
}