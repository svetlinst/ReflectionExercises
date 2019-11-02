namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var classType = typeof(BlackBoxInteger);
            var classInstance = Activator.CreateInstance(classType, true);
            var bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

            string input;
            while((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split('_', StringSplitOptions.RemoveEmptyEntries);
                var method = classType.GetMethod(tokens[0], bindingFlags);
                method.Invoke(classInstance, new object[] { int.Parse(tokens[1])});
                var result = classType.GetField("innerValue", bindingFlags).GetValue(classInstance);
                Console.WriteLine(result);
            }
        }
    }
}
