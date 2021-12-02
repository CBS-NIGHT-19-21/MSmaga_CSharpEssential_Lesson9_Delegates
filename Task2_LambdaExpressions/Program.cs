#region Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – 
//вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два 
//аргумента и возвращать результат вычисления. Лямбда оператор деления должен делать проверку 
//деления на ноль. 
//Написать программу, которая будет выполнять арифметические действия, указанные пользователем.
#endregion

// Instance the class delegates and define lambda expressions as the delegates.
Add Add;
Add = (operand1, operand2) => { return operand1 + operand2; };

Sub Sub;
Sub = (operand1, operand2) => { return operand1 - operand2; };

Mul Mul;
Mul = (operand1, operand2) => { return operand1 * operand2; };

Div Div;
Div = (operand1, operand2) =>
{
    if (operand2 != 0)
    { return operand1 / operand2; }
    else
    { return 0; }
};

double operand1 = 13.0d;
double operand2 = 19.0d;

Console.WriteLine($"Sum: {Add(operand1, operand2)}, Sub: {Sub(operand1, operand2)}, " +
                  $"Mul: {Mul(operand1, operand2)}, Div: {Div(operand1, operand2):F2}");

Console.ReadLine();