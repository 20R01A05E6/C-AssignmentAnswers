﻿using Product;
class GreatestProduct
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Digits : ");
        string inputString = Console.ReadLine();
        ProductClass productClass = new ProductClass();
        productClass.product(inputString);
   
    }
}