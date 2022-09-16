/*
 * Ухватов Владислав 22-ИСП-2/1
 * 1.2. Программирование линейных алгоритмов
 * Высокий уровень, 18 вариант (14 страница)
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

double CalculateBisector (double linkedSide, double firstAnotherSide, double secondAnotherSide) {
    var numerator = Math.Sqrt(firstAnotherSide*secondAnotherSide*(linkedSide + firstAnotherSide + secondAnotherSide)*(firstAnotherSide + secondAnotherSide - linkedSide));
    var denominator = (firstAnotherSide + secondAnotherSide);
    return numerator/denominator;
}

var a = GetDoubleFromCommandLine("<a>");
var b = GetDoubleFromCommandLine("<b>");
var c = GetDoubleFromCommandLine("<c>");

Console.WriteLine($"Bisector drawn to side <a> = {CalculateBisector(a, b, c):F2}");
Console.WriteLine($"Bisector drawn to side <b> = {CalculateBisector(b, a, c):F2}");
Console.WriteLine($"Bisector drawn to side <c> = {CalculateBisector(c, a, b):F2}");