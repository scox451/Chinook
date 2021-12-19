using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Tokenizit.Core
{
    public static class StingHelper
    {

        public static string Capitolize(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }


        public static string ToTitleCase(this string str)
        {
            string pattern = @"/[A-Z]{2,}(?=[A-Z][a-z]+[0-9]*|\b)|[A-Z]?[a-z]+[0-9]*|[A-Z]|[0-9]+/g";

            var result = string.Join(' ',
                new Regex(pattern)
                    .Matches(str)
                    .Select(x => x.Value.ToLower().Capitolize())
                );

            return result;
        }

        public static string ToSentenceCase(this string str)
        {
            string pattern = @"/[A-Z]{2,}(?=[A-Z][a-z]+[0-9]*|\b)|[A-Z]?[a-z]+[0-9]*|[A-Z]|[0-9]+/g";

            var result = string.Join(' ',
                new Regex(pattern)
                    .Matches(str)
                    .Select(x => x.Value.ToLower())
                );

            return result.Capitolize();
        }
        public static string ToSnakeCase(this string str)
        {
            string pattern = @"/[A-Z]{2,}(?=[A-Z][a-z]+[0-9]*|\b)|[A-Z]?[a-z]+[0-9]*|[A-Z]|[0-9]+/g";

            var result = string.Join('_',
                new Regex(pattern)
                    .Matches(str)
                    .Select(x => x.Value.ToLower())
                );

            return result;
        }

        public static string ToKebabCase(this string str)
        {
            string pattern = @"/[A-Z]{2,}(?=[A-Z][a-z]+[0-9]*|\b)|[A-Z]?[a-z]+[0-9]*|[A-Z]|[0-9]+/g";

            var result = string.Join('-',
                new Regex(pattern)
                    .Matches(str)
                    .Select(x => x.Value.ToLower())
                );

            return result;
        }
        public static string ToPascalCase(this string str)
        {
            // string pattern = @"/\w\S*/g";

            // str = str.Replace('-',' ');
            // str = str.Replace('_',' ');
            string pattern = @"/[A-Z]{2,}(?=[A-Z][a-z]+[0-9]*|\b)|[A-Z]?[a-z]+[0-9]*|[A-Z]|[0-9]+/g";

            var result = string.Concat(
                new Regex(pattern)
                    .Matches(str)
                    .Select(match =>
                    {
                        var word = match.Value.ToString();

                        return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();


                    })
                );

            return result;
        }

        public static string ToCamelCase(this string str)
        {
            str = str.ToPascalCase();

            return char.ToLower(str[0]) + str.Substring(1);
        }

        public static string ToPlural(this string str)
        {

            return str + "s";
        }



        public static void TestStringHelper()
        {


            string titleCase = "Model Name";
            string sentenceCase = "Model name";
            string lowerCase = "model name";
            string pascalCase = "ModelName";
            string camelCase = "modelName";
            string snakeCase = "model_name";
            string kebabCase = "model-name";

            Console.WriteLine("\nstring.ToTitleCase()");
            Console.WriteLine($"({titleCase}) => {titleCase.ToTitleCase()}");
            Console.WriteLine($"({sentenceCase}) => {sentenceCase.ToTitleCase()}");
            Console.WriteLine($"({lowerCase}) => {lowerCase.ToTitleCase()}");
            Console.WriteLine($"({pascalCase}) => {pascalCase.ToTitleCase()}");
            Console.WriteLine($"({camelCase}) => {camelCase.ToTitleCase()}");
            Console.WriteLine($"({snakeCase}) => {snakeCase.ToTitleCase()}");
            Console.WriteLine($"({kebabCase}) => {kebabCase.ToTitleCase()}");

            Console.WriteLine("\nstring.ToSentenceCase()");
            Console.WriteLine($"({titleCase}) => {titleCase.ToSentenceCase()}");
            Console.WriteLine($"({sentenceCase}) => {sentenceCase.ToSentenceCase()}");
            Console.WriteLine($"({lowerCase}) => {lowerCase.ToSentenceCase()}");
            Console.WriteLine($"({pascalCase}) => {pascalCase.ToSentenceCase()}");
            Console.WriteLine($"({camelCase}) => {camelCase.ToSentenceCase()}");
            Console.WriteLine($"({snakeCase}) => {snakeCase.ToSentenceCase()}");
            Console.WriteLine($"({kebabCase}) => {kebabCase.ToSentenceCase()}");

            Console.WriteLine("\nstring.ToPascalCase()");
            Console.WriteLine($"({titleCase}) => {titleCase.ToPascalCase()}");
            Console.WriteLine($"({sentenceCase}) => {sentenceCase.ToPascalCase()}");
            Console.WriteLine($"({lowerCase}) => {lowerCase.ToPascalCase()}");
            Console.WriteLine($"({pascalCase}) => {pascalCase.ToPascalCase()}");
            Console.WriteLine($"({camelCase}) => {camelCase.ToPascalCase()}");
            Console.WriteLine($"({snakeCase}) => {snakeCase.ToPascalCase()}");
            Console.WriteLine($"({kebabCase}) => {kebabCase.ToPascalCase()}");

            Console.WriteLine("\nstring.ToCamelCase()");
            Console.WriteLine($"({titleCase}) => {titleCase.ToCamelCase()}");
            Console.WriteLine($"({sentenceCase}) => {sentenceCase.ToCamelCase()}");
            Console.WriteLine($"({lowerCase}) => {lowerCase.ToCamelCase()}");
            Console.WriteLine($"({pascalCase}) => {pascalCase.ToCamelCase()}");
            Console.WriteLine($"({camelCase}) => {camelCase.ToCamelCase()}");
            Console.WriteLine($"({snakeCase}) => {snakeCase.ToCamelCase()}");
            Console.WriteLine($"({kebabCase}) => {kebabCase.ToCamelCase()}");

            Console.WriteLine("\nstring.ToSnakeCase()");
            Console.WriteLine($"({titleCase}) => {titleCase.ToSnakeCase()}");
            Console.WriteLine($"({sentenceCase}) => {sentenceCase.ToSnakeCase()}");
            Console.WriteLine($"({lowerCase}) => {lowerCase.ToSnakeCase()}");
            Console.WriteLine($"({pascalCase}) => {pascalCase.ToSnakeCase()}");
            Console.WriteLine($"({camelCase}) => {camelCase.ToSnakeCase()}");
            Console.WriteLine($"({snakeCase}) => {snakeCase.ToSnakeCase()}");
            Console.WriteLine($"({kebabCase}) => {kebabCase.ToSnakeCase()}");

            Console.WriteLine("\nstring.ToKebabCase()");
            Console.WriteLine($"({titleCase}) => {titleCase.ToKebabCase()}");
            Console.WriteLine($"({sentenceCase}) => {sentenceCase.ToKebabCase()}");
            Console.WriteLine($"({lowerCase}) => {lowerCase.ToKebabCase()}");
            Console.WriteLine($"({pascalCase}) => {pascalCase.ToKebabCase()}");
            Console.WriteLine($"({camelCase}) => {camelCase.ToKebabCase()}");
            Console.WriteLine($"({snakeCase}) => {snakeCase.ToKebabCase()}");
            Console.WriteLine($"({kebabCase}) => {kebabCase.ToKebabCase()}");

        }
    }

}