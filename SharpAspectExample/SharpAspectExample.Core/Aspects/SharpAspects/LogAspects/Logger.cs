using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace SharpAspectExample.Core.Aspects.SharpAspects.LogAspects
{
    public class Logger
    {
        public void LogInfo(LogDetail logObj)
        {
           
            string fullPath = @"C:\Temp\test.json";
            var readJson = File.Exists(fullPath) ? File.ReadAllText(fullPath) : ""; //dosyada olan veriler alınıyor
            var obj = new List<LogDetail>(); //dosyaboşsa 
            if (readJson != "")
            {
                //dosya boş degilse ise 
                obj = JsonSerializer.Deserialize<List<LogDetail>>(readJson);
            }
            obj.Add(logObj);

            var json = JsonSerializer.Serialize(obj);


            File.WriteAllText(fullPath, json);
        }
    }
}
