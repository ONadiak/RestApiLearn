using System;
using System.Collections.Generic;
using APILearn.FrameWork;
using APILearn.FrameWork.JSonStructure;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;

namespace APILearn
{
    public class Tests
    {
        
        [Test]
        public void IdCheckTest()
        {
            string Responce = null;
            string LondonId = "2643743";
            Deserealizator deserealizator = new Deserealizator();
            Responce = APIRequest.SentRequest("http://api.openweathermap.org/data/2.5/weather?q=London&appid=271780897c953bf67d06a95d2cd8b78e");
            WeatherInfo weatherInfo = deserealizator.getWeatherInfoFromJson(Responce);
            Assert.AreEqual(weatherInfo.id,LondonId,"Id does not match");
        }
        
        [Test]
        public void TownCheckTest()
        {
            string Responce = null;
            string Town = "Ukraine";
            Deserealizator deserealizator = new Deserealizator();
            Responce = APIRequest.SentRequest("http://api.openweathermap.org/data/2.5/weather?id=690791&appid=271780897c953bf67d06a95d2cd8b78e");
            WeatherInfo weatherInfo = deserealizator.getWeatherInfoFromJson(Responce);
            Assert.AreEqual(weatherInfo.Name,Town,"Town does not match");
        }
        
        
        
        
    }
}