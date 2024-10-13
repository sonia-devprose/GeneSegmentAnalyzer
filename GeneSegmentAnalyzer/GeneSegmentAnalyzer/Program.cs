using System;

namespace GeneSegmentAnalyzer

{

    class Program

    {

        static void Main (string[] args)

        {
            // Print message to prompt user to enter the length of the gene segment
            Console.WriteLine("Enter the length of the gene segment: ");

            // Read the input from the user and store it as a double (for decimal values)
            double geneLength = Convert.ToDouble(Console.ReadLine());

            // Display the length of the gene segment entered by the user
            Console.WriteLine("The length of the gene segment is: " +  geneLength);

            // Prompt the user to enter the count of gene segments in the DNA sequence
            Console.WriteLine("Enter the count of gene segments in the DNA sequence: ");

            // Read the input from the user and store it as an integer
            int geneCount = Convert.ToInt32(Console.ReadLine());

            // Display the count of the gene segments entered by the user
            Console.WriteLine("The count of gene segments is: " + geneCount);

            // Prompt the user to enter the name of the gene segment
            Console.WriteLine("Enter the name of gene segment: ");

            // Read the input from the user and store it as a string
            string geneSegmentName = Console.ReadLine();

            // Display the result, showing the gene segment's name, count, and length
            Console.WriteLine("The name of the gene segment is: " + geneSegmentName);





        }



    }




}
