using HomeWork14.Contracts;
using HomeWork14.Models;
using HomeWork14.Settings;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace HomeWork14.FileOperations
{
    public class FileOperation : IFile
    {
        private readonly ISetting _setting;

        public FileOperation(ISetting setting)
        {
            _setting = setting;
        }

        public List<PersonData> Read()
        {
            if (File.Exists(_setting.Path))
            {
                using var reader = new StreamReader(_setting.Path);
                string jsonString = reader.ReadToEnd();

                if (!string.IsNullOrEmpty(jsonString))
                    return JsonSerializer.Deserialize<List<PersonData>>(jsonString);
            }
            return new List<PersonData>();
        }

        public void Write(List<PersonData> list)
        {
            string json = JsonSerializer.Serialize(list);
            File.WriteAllText(_setting.Path, json);
        }
    }
}
