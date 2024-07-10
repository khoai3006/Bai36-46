using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();

        // Bổ sung các số 3.5,-1.2, 7.8,-5 vào cuối danh sách
        numbers.Add(3.5f);
        numbers.Add(-1.2f);
        numbers.Add(7.8f);
        numbers.Add(-5f);

        // Duyệt danh sách theo chỉ số (không sử dụng foreach) để hiển thị các phần tử
        Console.WriteLine("Danh sách các số:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Sắp xếp danh sách theo thứ tự tăng dần
        numbers.Sort();

        Console.WriteLine("\nDanh sách sau khi sắp xếp:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}