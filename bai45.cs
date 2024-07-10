using System.Collections.Generic;
using System;

try
{
    // Dictionary<TKey, TValue>
    Dictionary<string, int> personAges = new Dictionary<string, int>();
    personAges.Add("John", 30);
    personAges.Add("Jane", 25);
    int johnAge = personAges["John"]; // Lấy giá trị của key "John"
    Console.WriteLine($"John's age: {johnAge}");

    // List<T>
    List<string> names = new List<string>();
    names.Add("John");
    names.Add("Jane");
    names.Sort(); // Sắp xếp danh sách
    string secondName = names[1]; // Lấy phần tử thứ 2 trong danh sách
    Console.WriteLine($"Second name: {secondName}");

    // Queue<T>
    Queue<int> numberQueue = new Queue<int>();
    numberQueue.Enqueue(1);
    numberQueue.Enqueue(2);
    numberQueue.Enqueue(3);
    int firstNumber = numberQueue.Dequeue(); // Lấy và xóa phần tử đầu tiên
    Console.WriteLine($"First number: {firstNumber}");

    // SortedList<TKey, TValue>
    SortedList<string, int> sortedPersonAges = new SortedList<string, int>();
    sortedPersonAges.Add("John", 30);
    sortedPersonAges.Add("Jane", 25);
    int janeAge = sortedPersonAges["Jane"]; // Lấy giá trị của key "Jane"
    Console.WriteLine($"Jane's age: {janeAge}");

    // Stack<T>
    Stack<string> nameStack = new Stack<string>();
    nameStack.Push("John");
    nameStack.Push("Jane");
    string topName = nameStack.Pop(); // Lấy và xóa phần tử ở đỉnh stack
    Console.WriteLine($"Top name: {topName}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}