// See https://aka.ms/new-console-template for more information
using EmployeePayrollUsingThreads;

Console.WriteLine("Hello, World!");
Console.WriteLine("Employee Payroll using Threads");
string[] words =Demo.CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");

#region ParallelTasks
Parallel.Invoke(() =>
{
    Console.WriteLine("Begin first task...");
    Demo.GetLongestWord(words);
},// close 1st action
() =>
{
    Console.WriteLine("Begin second task...");
    Demo.GetMostCommonWords(words);
},
() =>
{
    Console.WriteLine("Begin third task...");
    Demo.GetMostCommonWords(words);
}// close third action
);// close parallel.invoke
#endregion
//Console.ReadKey();

