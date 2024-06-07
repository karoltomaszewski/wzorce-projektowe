class Program
{
    static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
        ForecastDisplay forecastDisplay = new ForecastDisplay();

        weatherStation.RegisterObserver(currentDisplay);
        weatherStation.RegisterObserver(forecastDisplay);

        weatherStation.SetMeasurements(26.5f, 65f, 1015f);
        weatherStation.SetMeasurements(28.1f, 70f, 1012f);
        weatherStation.SetMeasurements(22.3f, 90f, 1013f);
    }
}