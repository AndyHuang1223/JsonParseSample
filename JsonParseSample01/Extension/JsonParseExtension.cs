using System;
using System.Diagnostics;
using System.Text.Json;

namespace JsonParseSample01.Extension
{
    public static class JsonParseExtension
    {
        public static bool JsonTryParse<T>(this string jsonString, out T result) where T : class
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(jsonString);
                return true;
            }
            catch(Exception e)
            {
                result = default;
                Debug.WriteLine(e.Message);
                return false;
            }
        }
    }
}