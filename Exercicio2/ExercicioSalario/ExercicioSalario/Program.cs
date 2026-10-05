using ExercicioSalario;
using System.Globalization;

Funcionario func1, func2;
func1 = new Funcionario(); 
func2 = new Funcionario();

Console.WriteLine("Entre com os dados do primeiro funcionario");

func1.Nome = Console.ReadLine();
func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com os dados do segundo funcionario");

func2.Nome = Console.ReadLine();
func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salarioMedio = (func1.Salario + func2.Salario) / 2.0; 

Console.WriteLine("Salario Medio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
