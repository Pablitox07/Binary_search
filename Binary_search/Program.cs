using System;
class Program
{
    static int[] create_list(int length)
    {
        int[] list = new int[length + 1];

        for (int i = 0;  i <= length; i++)
        {
            list[i] = i;
        }
        return list;
    }

    static int binary_search(int[] my_list, int target)
    {
        int start = 0; 
        int end = my_list.Length - 1;
        int test_num;

        while (start <= end)
        {
            test_num = (start + end) / 2;

            if (my_list[test_num] == target)
            {
                return test_num;
            }
            else if (my_list[test_num] < target)
            {
                start = test_num + 1;
            }
            else if (my_list[test_num] > target)
            {
                end = test_num - 1;
            }

        }
        return -1;


    }
    static void Main(string[] args)
    {
        int len;
        int find_number;
        while (true) 
        {
            try
            {
                Console.Write("Write the amount a numbers that will fit your list: ");
                len = int.Parse(Console.ReadLine());

                Console.Write("Write the number you want to search: ");
                find_number = int.Parse(Console.ReadLine());
                break;
            } 
            catch 
            {
                Console.WriteLine("Number not valid.");
            }
        }

        int[] list = create_list(len);
        int n = binary_search(list, find_number);
        Console.WriteLine(n);

    }
}
