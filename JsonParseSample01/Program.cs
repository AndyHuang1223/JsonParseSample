using System;
using JsonParseSample01.Extension;
using JsonParseSample01.Models;

namespace JsonParseSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonString = CreateMockJsonString();
            var isJsonFormat = jsonString.JsonTryParse<BaseModel<User>>(out var jsonResult);
            if (!isJsonFormat)
            {
                Console.WriteLine($"{jsonString} is not JSON format !");
            }
            else
            {
                Console.WriteLine($"{jsonString} is JSON format");
                Console.WriteLine($"Code : {jsonResult.Code}");
                Console.WriteLine($"Msg : {jsonResult.Message}");
                Console.WriteLine($"Name : {jsonResult.Response.Name}");
                Console.WriteLine($"Age : {jsonResult.Response.Age}");
            }

        }
        private static string CreateMockJsonString()
        {
            return @"{""Code"":0,""Msg"":""Success!"",""Response"": {""Name"":""Andy"",""Age"": 30}}";
        }
    }
}