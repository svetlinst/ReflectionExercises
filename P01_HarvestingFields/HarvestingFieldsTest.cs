 namespace P01_HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var classType = typeof(HarvestingFields);
            var bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            var fields = classType.GetFields(bindingFlags);
            string input;
            while ((input=Console.ReadLine()) != "HARVEST")
            {
                switch (input)
                {
                    case "private":
                        foreach (var field in fields.Where(f=>f.IsPrivate == true))
                        {
                            Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "public":
                        foreach (var field in fields.Where(f => f.IsPublic == true))
                        {
                            Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "protected":
                        foreach (var field in fields.Where(f => f.IsFamily == true))
                        {
                            Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                        }
                        break;
                }
            }
        }
    }
}
