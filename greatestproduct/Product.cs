using Calculate;
namespace Product
{
    class ProductClass
    {
        public void product(string inputString)
        {
            if (inputString == "")
            {
                throw new Exception("Input Should not be Empty");
            }
            int maxProduct = 0;
            string digits = "";
            for (int i = 0; i <= inputString.Length - 4; i++)
            {
                string substring = inputString.Substring(i, 4);

                int product = Calculateclass.calculate(substring); //Converting Characters into Integers

                if (product > maxProduct)
                {
                    maxProduct = product;
                    digits = substring;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"{digits.Substring(0, 1)}*" +
                              $"{digits.Substring(1, 1)}*" +
                              $"{digits.Substring(2, 1)}*" +
                              $"{digits.Substring(3, 1)} = " + maxProduct);
        }
    }
}