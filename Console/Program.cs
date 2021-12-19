using System;
using System.Collections.Generic;
using System.Linq;
using Tokenizit.Test;
using Tokenizit.Core;
using Rhetos.Utilities;
using System.IO;

namespace Chinook.ConsoleApp
{
    class Program
    {
        
     

        public string CClassPropDef = "public <type> <name> = { get; set; }";
        public string CInterfacePropDef = "public <type> <name>;";
        public string JClassPropDef = "public <name>: <type>; ";
        public string JInterfacePropDef = "public <name>: <type>;";

        // new KeyValuePair<string, string>("VARCHAR","string"),
        //     new KeyValuePair<string, string>("INTEGER","int"),
        //     new KeyValuePair<string, string>("NUMERIC","decimal"),
        //     new KeyValuePair<string, string>("DATETIME","DateTime"),
        //     new KeyValuePair<string, string>("BIT","bool"),
        // };



        static void Main(string[] args)
        {
            //Testinator.TestStringHelper();
            List<ColumnDefinitions> AllTables = new List<ColumnDefinitions>  {
            new ColumnDefinitions{ Table="FirstEntity", Name="Column1", Ordinal=1, Type="NVARCHAR", TypeSize=null, isNull=false},
            new ColumnDefinitions{ Table="FirstEntity", Name="Column2", Ordinal=2, Type="VARCHAR", TypeSize=null, isNull=false},
            new ColumnDefinitions{ Table="FirstEntity", Name="Column3", Ordinal=3, Type="INTEGER", TypeSize=null, isNull=false},
            new ColumnDefinitions{ Table="FirstEntity", Name="Column4", Ordinal=4, Type="NUMERIC", TypeSize=null, isNull=false},
            new ColumnDefinitions{ Table="FirstEntity", Name="Column5", Ordinal=5, Type="DATETIME", TypeSize=null, isNull=false},
            new ColumnDefinitions{ Table="FirstEntity", Name="Column6", Ordinal=6, Type="BIT", TypeSize=null, isNull=false},
            new ColumnDefinitions{ Table="FirstEntity", Name="Column7", Ordinal=7, Type="INTEGER", TypeSize=null, isNull=true},
            new ColumnDefinitions{ Table="FirstEntity", Name="Column8", Ordinal=8, Type="NVARCHAR", TypeSize=null, isNull=true},
            new ColumnDefinitions{ Table="FirstEntity", Name="Column9", Ordinal=9, Type="DATETIME", TypeSize=null, isNull=true},
            new ColumnDefinitions{ Table="SecondEntity", Name="Column1", Ordinal=1, Type="NVARCHAR", TypeSize=null, isNull=false},
            new ColumnDefinitions{ Table="SecondEntity", Name="Column2", Ordinal=2, Type="VARCHAR", TypeSize=null, isNull=false},
            new ColumnDefinitions{ Table="SecondEntity", Name="Column3", Ordinal=3, Type="INTEGER", TypeSize=null, isNull=false},
            new ColumnDefinitions{ Table="SecondEntity", Name="Column4", Ordinal=4, Type="NUMERIC", TypeSize=null, isNull=false},
            new ColumnDefinitions{ Table="SecondEntity", Name="Column5", Ordinal=5, Type="DATETIME", TypeSize=null, isNull=false},
            new ColumnDefinitions{ Table="SecondEntity", Name="Column6", Ordinal=6, Type="BIT", TypeSize=null, isNull=false},
            new ColumnDefinitions{ Table="SecondEntity", Name="Column7", Ordinal=7, Type="INTEGER", TypeSize=null, isNull=true},
            new ColumnDefinitions{ Table="SecondEntity", Name="Column8", Ordinal=8, Type="NVARCHAR", TypeSize=null, isNull=true},
            new ColumnDefinitions{ Table="SecondEntity", Name="Column9", Ordinal=9, Type="DATETIME", TypeSize=null, isNull=true},
                      };
            var tables = AllTables.OrderBy(c => c.Table)
                .ThenBy(c => c.Ordinal)
                .GroupBy(c => c.Table);

            foreach (var table in tables)
            {
                BuildProject(table);
            }
            // html
            // component ts

        }
        
        private static void BuildProject(IGrouping<string, ColumnDefinitions> table)
        {
           TemplatStore _templateStore = new TemplatStore();
           List<PayloadDef> PayloadDefs = new List<PayloadDef>  
           {
                new PayloadDef{ Template="", Language="ts", TargetFilenameTemplate="~!kebab!~.ts", TargetPathTemplate=@"c:\projects\chinook\console\src\app\shared\models\", TemplatePath=@"\templates\client\interface.template"},
                new PayloadDef{ Template="", Language="ts", TargetFilenameTemplate="~!kebab!~.service.ts", TargetPathTemplate=@"c:\projects\chinook\console\src\app\core\", TemplatePath=@"\templates\client\service.template"},
                new PayloadDef{ Template="", Language="ts", TargetFilenameTemplate="~!kebab!~.component.ts", TargetPathTemplate=@"c:\projects\chinook\console\src\app\~!kebab!~\", TemplatePath=@"\templates\client\component.template"},
                new PayloadDef{  Template="",Language="html", TargetFilenameTemplate="~!kebab!~.component.html", TargetPathTemplate=@"c:\projects\chinook\console\src\app\~!kebab!~\", TemplatePath=@"\templates\client\view.template"},
                new PayloadDef{  Template="",Language="scss", TargetFilenameTemplate="~!kebab!~.component.scss", TargetPathTemplate=@"c:\projects\chinook\console\src\app\~!kebab!~\", TemplatePath=@"\templates\client\style.template"},
                new PayloadDef{ Template="", Language="ts", TargetFilenameTemplate="~!detail-kebab!~.component.ts", TargetPathTemplate=@"c:\projects\chinook\console\src\app\~!kebab!~\~!detail-kebab!~\", TemplatePath=@"\templates\client\detail-component.template"},
                new PayloadDef{  Template="",Language="html", TargetFilenameTemplate="~!detail-kebab!~.component.html", TargetPathTemplate=@"c:\projects\chinook\console\src\app\~!kebab!~\~!detail-kebab!~\", TemplatePath=@"\templates\client\detail-view.template"}
           };
    
            var nameVariations = new EntityNameVariations(table.Key, table.ToList());

            foreach (var payloadDef in PayloadDefs)
            {
                // get template from store
                // templateStoreGet(target.TemplatePath);

                ////generate payload
                var template = _templateStore.GetTemplate(payloadDef.TemplatePath);
                var payload = ReplaceTokens(nameVariations,template);
                var targetPath = ReplaceTokens(nameVariations,payloadDef.TargetPathTemplate);
                var targetFilename = ReplaceTokens(nameVariations,payloadDef.TargetFilenameTemplate);
                
                SavePayload(payload,targetPath, targetFilename);

            }
        }

        private static void SavePayload(string payload, string targetPath,string targetFilename)
        {
            new FileInfo(targetPath).Directory.Create();
            var fullPath = targetPath + targetFilename;
            
            if(File.Exists(fullPath))
               File.Move(fullPath, $"{fullPath}.{DateTime.Now.ToString("yyyyMMdd'_'HHmmss")}.bak");
        
            File.WriteAllText(fullPath, payload);          
        }

        private static string ReplaceTokens( Dictionary<string,string> nameVariations,string template)
        {
                FastReplacer fr = new FastReplacer("~!", "!~");

                fr.Append(template);

                foreach (var nameVariation in nameVariations)
                {
                    fr.Replace(nameVariation.Key, nameVariation.Value);
                }

               return fr.ToString();
        }

        private static string CreatePayload(string template, PayloadDef payloadDef)
        {
            // throw new NotImplementedException();
            return "";
        }

      //  public TemplatStore TemplateStore { get => _templateStore; set => _templateStore = value; }


    }

    public class PayloadDef
    {
        public string Template { get; set; }
        public string Language { get; set; }
        public string TemplatePath { get; set; }
        public string TargetPathTemplate { get; set; }
       public string TargetFilenameTemplate { get; set; }
    }



    public class ColumnDefinitions
    {
        public string Table { get; set; }
        public string Name { get; set; }
        public int Ordinal { get; set; }
        public string Type { get; set; }
        public string TypeSize { get; set; }
        public bool isNull { get; set; }
    }


}