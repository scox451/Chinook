using System.Collections.Generic;
using System.IO;

namespace Tokenizit.Core
{
    public class TemplatStore
    {
        public Dictionary<string, string> TemplateCache { get; set; } 
        readonly string rootPath = @"c:\projects\chinook\console\templates";

        public TemplatStore()
        {
            TemplateCache = new Dictionary<string, string>();

            foreach (var filePath in Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories))
            {
                string fileContents =  File.ReadAllText(filePath);
                string key = filePath.Remove(0,27);
               TemplateCache.Add(key,fileContents);

            }
            
        }

        public string GetTemplate(string templatePath)
        {
            string result = null;

            if (TemplateCache.ContainsKey(templatePath))
                return TemplateCache[templatePath];

            var fullpath = rootPath + templatePath;
            if (File.Exists(fullpath))
            {
                result = File.ReadAllText(fullpath);
                TemplateCache.Add(templatePath, result);
            }

            return result;

        }
    }
}