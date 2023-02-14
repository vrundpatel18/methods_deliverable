// Vrund Patel
// 2/13
// methods deliverable assignment
namespace methods_deliverable
{
    internal class Program
    {
        static int[] random_array(int array_lens)
        {
            Random random = new Random();
            int[] MyArrary = new int[array_lens];
            for (int i = 0; i < array_lens; i++)
            {
                MyArrary[i] = random.Next(10, 50);
            }
            return MyArrary;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer between 5 and 15.");
                int input = int.Parse(Console.ReadLine());

                int[] MyArray = random_array(input);

                if (input >= 5 && input <= 15)
                {
                    Console.WriteLine("");
                    Console.WriteLine("The elements in the array are: ");
                    foreach (int i in MyArray)
                    {
                        Console.WriteLine(i + " ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("The sum of the array is: " + sum(MyArray));
                }
                else
                {
                    Console.WriteLine("Did not enter an integer between 5 and 15.");
                }

            }
            catch 
            {
                Console.WriteLine("Enter an integer between 5 and 15");
            }

            
            

            
        }

    }
}