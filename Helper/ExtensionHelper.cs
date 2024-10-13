namespace OOP.Helper
{
    public static class ExtensionHelper
    {
        public static void ExtensionMethod(this List<int> elements)
        {
            elements.ForEach(element =>
            {
                Console.WriteLine(element);
            });
        }

        // if we do not use this kwyword before type then that is considered as a parameter
        public static void ExtensionMethodWithParams(int number)
        {
            Console.WriteLine(number);
        }

        // if we do not use this kwyword before type then that is considered as a parameter
        public static void ExtensionMethodWithParamsAndExtension(this List<int> elements, int number)
        {
            elements.ForEach(element =>
            {
                Console.WriteLine(element + number);
            });
        }
    }
}