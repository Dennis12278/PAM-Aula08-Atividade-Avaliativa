namespace AV;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void ConverterParaFahrenheit(object sender, EventArgs e)
    {
    
    }

    private void ConverterParaCelsius(object sender, EventArgs e)
    {
      
    }

    private void SliderTemp_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valor = e.NewValue;


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