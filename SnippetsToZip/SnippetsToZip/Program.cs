﻿using System;
using System.Configuration;
using System.IO;
using System.IO.Compression;

namespace SnippetsToZip
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToSnippets = ConfigurationManager.AppSettings["pathToSnippets"];
            string currentDirectory = Environment.CurrentDirectory;

            string pathToOutputFile = ConfigurationManager.AppSettings["pathToOutputFile"];

            File.Delete(currentDirectory + pathToOutputFile);
            ZipFile.CreateFromDirectory(currentDirectory + pathToSnippets, 
                                        currentDirectory + pathToOutputFile);
        }
    }
}
