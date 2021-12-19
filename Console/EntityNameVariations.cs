using System.Collections.Generic;
using System.Text;
using Chinook.ConsoleApp;


namespace Tokenizit.Core
{
    public class EntityNameVariations : Dictionary<string, string>
    {
        public Dictionary<string, string> EntitNames { get; set; }
        //readonly string rootPath = @"c:\projects\chinook\console\template";

        public EntityNameVariations(string entityName, List<ColumnDefinitions> columns)
        {
            string entityDetailName = $"{entityName}Detail";

            this.Add("~!sentence!~", entityName.ToSentenceCase());
            this.Add("~!pascal!~", entityName.ToPascalCase());
            this.Add("~!kebab!~", entityName.ToKebabCase());
            this.Add("~!snake!~", entityName.ToSnakeCase());
            this.Add("~!camel!~", entityName.ToCamelCase());

            this.Add("~!detail-sentence!~", entityDetailName.ToSentenceCase());
            this.Add("~!detail-pascal!~", entityDetailName.ToPascalCase());
            this.Add("~!detail-kebab!~", entityDetailName.ToKebabCase());
            this.Add("~!detail-snake!~", entityDetailName.ToSnakeCase());
            this.Add("~!detail-camel!~", entityDetailName.ToCamelCase());

            this.Add("~!plural-camel!~", entityName.ToPlural().ToCamelCase());
            this.Add("~!detail-plural-camel!~", entityDetailName.ToPlural().ToCamelCase());
            this.Add("~!plural-pascal!~", entityName.ToPlural().ToPascalCase());
            this.Add("~!detail-plural-pascal!~", entityDetailName.ToPlural().ToPascalCase());

            BuildFeildControls(columns);
            this.Add("~!form-control-defs!~", _formCtrlDefs);
            this.Add("~!init-form-controls!~", _initFormCtrls);
            this.Add("~!map-form-controls!~", _mapFormCtrls);
            this.Add("~!map-control-values!~", _formCtrlValue);
            this.Add("~!ts-interface-def!~", _tsInterfaceDefs);

        }
        string _formCtrlDefs;
        string _initFormCtrls;
        string _mapFormCtrls;
        string _formCtrlValue;
        string _tsInterfaceDefs;

        private void BuildFeildControls(List<ColumnDefinitions> columnDefs)
        {
            string result = string.Empty;
            StringBuilder formCtrlDefs = new StringBuilder();
            List<string> initFormCtrls = new List<string>();
            StringBuilder mapFormCtrls = new StringBuilder();
            StringBuilder formCtrlValue = new StringBuilder();
            List<string> tsInterfaceDefs = new List<string>();

            foreach (var columnDef in columnDefs)
            {
                var camelCase = columnDef.Name.ToCamelCase();
                formCtrlDefs.AppendLine($"{camelCase}Field: FormControl = new FormControl({{ value: null, disabled: false }}{BuildValidators(columnDef)} );");
                initFormCtrls.Add($" {camelCase}Field: this.{camelCase}Field");
                mapFormCtrls.AppendLine($"this.{camelCase}Field.setValue(this.model.{camelCase});");
                formCtrlValue.AppendLine($"this.model.{camelCase}=this.{camelCase}Field.value;");
                tsInterfaceDefs.Add($"{camelCase} : {TypeMaps[columnDef.Type].JType}");
            }

            _formCtrlDefs = formCtrlDefs.ToString();
            _initFormCtrls = string.Join(",\n", initFormCtrls);
            _mapFormCtrls = mapFormCtrls.ToString();
            _formCtrlValue = formCtrlValue.ToString();
            _tsInterfaceDefs = string.Join(",\n", tsInterfaceDefs);
        }

        string BuildValidators(ColumnDefinitions column)
        {
            List<string> validators = new List<string>();

            if (column.isNull)
                validators.Add("Validators.required");
            if (column.Type == "DECIMAL")
                validators.Add("Validators.min(0.01), Validators.max(99999.99)");

            return validators.Count > 0 ?
                $", [{string.Join(',', validators)}]" :
                string.Empty;
        }

        public static Dictionary<string, TypeMap> TypeMaps = new Dictionary<string, TypeMap>
        {
               { "NVARCHAR", new TypeMap() { SourceType = "NVARCHAR",CType = "string",JType="string" }},
               { "VARCHAR",new TypeMap() { SourceType = "VARCHAR",CType = "string",JType="string" }},
               { "INTEGER",new TypeMap() { SourceType = "INTEGER",CType = "int",JType="number" }},
               { "NUMERIC",new TypeMap() { SourceType = "NUMERIC",CType = "decimal",JType="number" }},
               { "DATETIME",new TypeMap() { SourceType = "DATETIME",CType = "DateTime",JType="Date" }},
               { "BIT",new TypeMap() { SourceType = "BIT",  CType = "bool",JType="Boolean" }}
        };

        public class TypeMap
        {
            public string CType { get; set; }
            public string JType { get; set; }
            public string SourceType { get; set; }

        }

    }
}

