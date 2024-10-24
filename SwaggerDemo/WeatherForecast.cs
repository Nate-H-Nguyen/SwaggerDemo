namespace SwaggerDemo
{
    public class WeatherForecast
    {
        /// <summary>
        /// Temperature date
        /// </summary>
        public DateOnly Date { get; set; }
        /// <summary>
        /// Temperature in Celsius
        /// </summary>
        public int TemperatureC { get; set; }
        /// <summary>
        /// Temperature in Fahrenheit
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        /// <summary>
        /// Summary of the weather
        /// </summary>
        public string? Summary { get; set; }
    }
}
