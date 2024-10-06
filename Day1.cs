using System;
using System.IO;

string filePath = "./Resources/Day1.txt";
string[] lines = File.ReadAllLines(filePath);
Console.WriteLine(lines.Length);

List<int> numbersOnlyList = new List<int>();

foreach(string stringLine in lines) { 
        var charArray = stringLine.ToCharArray();
        var isDigit = charArray.Where(isNumber());

        var onlyDigitArray = string.Join("", isDigit);
        var doubleDigit = Int32.Parse($"{onlyDigitArray.First()}{onlyDigitArray.Last()}");

        numbersOnlyList.Add(doubleDigit);
}

var totalSum = numbersOnlyList.Sum();

// final sum
Console.WriteLine(totalSum);

// ------------------
// | Helper Function
// ------------------

Func<char, bool> isNumber() {
    return (char x) => Char.IsDigit(x);
}