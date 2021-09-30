using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyNhanVien.web.Data;

namespace QuanLyNhanVien.web.Pages
{
    public class FetchDataBase : ComponentBase
    {
        public WeatherForecast[] forecasts;
        private readonly WeatherForecastService _weatherForecastService = new WeatherForecastService();

        protected override async Task OnInitializedAsync()
        {
            forecasts = await _weatherForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
