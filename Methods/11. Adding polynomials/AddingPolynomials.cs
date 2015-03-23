using System;

/* Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:

x^2 + 5 = 1x^2 + 0x + 5 => {5, 0, 1}
 */

class AddingPolynomials
{
    static void Main()
    {
        Console.WriteLine("Program that adds two polynomials.\n");

        int[] firstPolynomial = { 5, 4, 3, 2 };
        int[] secondPolynomial = { 6, 0, 0 };

        //Console.Write("Please enter a size of the first polynomial: ");
        //int firstSize = int.Parse(Console.ReadLine());
        //int[] firstPolynomial = new int[firstSize];
        //Console.WriteLine("Enter a coefficients:");

        //for (int i = 0; i < firstSize; i++)
        //{
        //    Console.WriteLine("Coefficient {0}: ", i+1);
        //    firstPolynomial[i] = int.Parse(Console.ReadLine());
        //}

        //Console.Write("Please enter a size of the second polynomial: ");
        //int secondSize = int.Parse(Console.ReadLine());
        //int[] secondPolynomial = new int[secondSize];
        //Console.WriteLine("Enter a coefficients:");

        //for (int i = 0; i < secondSize; i++)
        //{
        //    Console.WriteLine("Coefficient {0}: ", i + 1);
        //    secondPolynomial[i] = int.Parse(Console.ReadLine());
        //}

        int[] sum = AddPolynomials(firstPolynomial, secondPolynomial);
        
        PrintPolynomials(firstPolynomial);
        Console.Write(" + ");
        PrintPolynomials(secondPolynomial);
        Console.Write(" = ");
        PrintPolynomials(sum);


        Console.ReadLine();
    }

    static int[] AddPolynomials(int[] firstPolynomial, int[] secondPolynomial)
    {
        if (secondPolynomial.Length < firstPolynomial.Length)
            return AddPolynomials(secondPolynomial, firstPolynomial);

        int[] sum = new int[secondPolynomial.Length];
        int i = firstPolynomial.Length - 1;
        int j = secondPolynomial.Length - 1;

        for (i = firstPolynomial.Length - 1; i >= 0; i--, j--)
        {
            sum[j] = firstPolynomial[i] + secondPolynomial[j];
        }

        if (j >= 0)
        {
            for (; j >= 0; j--)
            {
                sum[j] = secondPolynomial[j];
            }
        }
        return sum;
    }

    static void PrintPolynomials(int[] polynomial)
    {
        int powerX = polynomial.Length - 1;

        if (polynomial[0] != 0)
            Console.Write("{0}x^{1}", polynomial[0], powerX);

        --powerX;
        
        for (int i = 1; i < polynomial.Length - 1; i++)
        {
            if (polynomial[i] != 0)
                Console.Write(" + {0}x^{1}", polynomial[i], powerX);
            
            --powerX; 
        }
        if(polynomial[polynomial.Length - 1] != 0)
            Console.Write(" + {0}", polynomial[polynomial.Length - 1]);
    }
}
