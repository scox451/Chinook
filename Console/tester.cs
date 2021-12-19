using System;
using Tokenizit.Core;

namespace Tokenizit.Test
{
  public class Testinator
  {
public static void TestStringHelper(){
            string titleCase = "Model Name";
            string sentenceCase = "Model name";
            string lowerCase = "model name";
            string pascalCase = "ModelName";
            string camelCase = "modelName";
            string snakeCase = "model_name";
            string kebabCase = "model-name";


            Console.WriteLine("\nstring.toPascalCase()");
            Console.WriteLine($"({titleCase}) => {titleCase.ToPascalCase()}");
            Console.WriteLine($"({sentenceCase}) => {sentenceCase.ToPascalCase()}");
            Console.WriteLine($"({lowerCase}) => {lowerCase.ToPascalCase()}");
            Console.WriteLine($"({pascalCase}) => {pascalCase.ToPascalCase()}");
            Console.WriteLine($"({camelCase}) => {camelCase.ToPascalCase()}");
            Console.WriteLine($"({snakeCase}) => {snakeCase.ToPascalCase()}");
            Console.WriteLine($"({kebabCase}) => {kebabCase.ToPascalCase()}");

            Console.WriteLine("\nstring.toCamelCase()");
            Console.WriteLine($"({titleCase}) => {titleCase.ToCamelCase()}");
            Console.WriteLine($"({sentenceCase}) => {sentenceCase.ToCamelCase()}");
            Console.WriteLine($"({lowerCase}) => {lowerCase.ToCamelCase()}");
            Console.WriteLine($"({pascalCase}) => {pascalCase.ToCamelCase()}");
            Console.WriteLine($"({camelCase}) => {camelCase.ToCamelCase()}");
            Console.WriteLine($"({snakeCase}) => {snakeCase.ToCamelCase()}");
            Console.WriteLine($"({kebabCase}) => {kebabCase.ToCamelCase()}");

            Console.WriteLine("\nstring.toSnakeCase()");
            Console.WriteLine($"({titleCase}) => {titleCase.ToSnakeCase()}");
            Console.WriteLine($"({sentenceCase}) => {sentenceCase.ToSnakeCase()}");
            Console.WriteLine($"({lowerCase}) => {lowerCase.ToSnakeCase()}");
            Console.WriteLine($"({pascalCase}) => {pascalCase.ToSnakeCase()}");
            Console.WriteLine($"({camelCase}) => {camelCase.ToSnakeCase()}");
            Console.WriteLine($"({snakeCase}) => {snakeCase.ToSnakeCase()}");
            Console.WriteLine($"({kebabCase}) => {kebabCase.ToSnakeCase()}");
          
            Console.WriteLine("\nstring.toKebabCase()");
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