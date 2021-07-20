using APILearn.FrameWork.JSonStructure;
using Newtonsoft.Json;

namespace APILearn.FrameWork
{
    public class Deserealizator
    {
        public WeatherInfo getWeatherInfoFromJson(string responce)
        {
            WeatherInfo weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(responce);
            return weatherInfo;
        }
       
    }
} 