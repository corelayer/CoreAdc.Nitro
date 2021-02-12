﻿using System.Text.Json.Serialization;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroModel.Configuration.System.SystemFile
{
    public class SystemFileAddRequestData : INitroRequestData
    {
        [JsonPropertyName("filename")]
        public string FileName { get; }

        [JsonPropertyName("filecontent")]
        public string FileContent { get; }

        [JsonPropertyName("filelocation")]
        public string FileLocation { get; set; }

        [JsonPropertyName("fileencoding")]
        public string FileEncoding { get; set; } = "BASE64";


        public SystemFileAddRequestData() { }

        public SystemFileAddRequestData(string fileName, string fileLocation, string fileContent)
        {
            FileName = fileName;
            FileLocation = fileLocation;
            FileContent = fileContent;
        }
    }
}