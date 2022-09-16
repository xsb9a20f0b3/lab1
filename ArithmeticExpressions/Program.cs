/*
 * Ухватов Владислав 22-ИСП-2/1
 * 1.1. Арифметические выражения
 * Высокий уровень, 18 вариант (8 страница)
 */ 


string GetNotNullableVariable(string variableName) {
    while (true) {
        Console.Write($"Enter {variableName} value: ");
        var input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input)) {
            return input;
        }

        Console.WriteLine("The entered value cannot be null.");
    }
}

double GetDoubleFromCommandLine(string variableName = "variable") {
    while (true) {
        var stringNumber = GetNotNullableVariable(variableName);

        if (double.TryParse(stringNumber, out var parsed)) return parsed;
        
        Console.WriteLine("The entered number must be of type double.");
    }
}

double Calculate (double y, double t) {
    var numerator = 4.351 * Math.Pow(y, 3) + 2 * t * Math.Log(t);
    var denominator = Math.Sqrt(Math.Cos(2 * y) + 4.351);
    return numerator/denominator;
}

var y = GetDoubleFromCommandLine("y");
var t = GetDoubleFromCommandLine("t");

Console.WriteLine(Calculate(y, t));



