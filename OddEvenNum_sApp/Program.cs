int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
foreach (var item in arr)
    Console.WriteLine($"{item} is " + ((item % 2 == 0) ? "Even" : "Odd"));