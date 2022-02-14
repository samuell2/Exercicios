using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite o salario de cada funcionario: ");
		double [] salario = new double [10];
		for (int i = 0; i <= 9; i++){
			Console.Write($"Funcionario {i + 1}: ");
			salario[i] = int.Parse(Console.ReadLine());
			if (salario[i] <= 300){
				salario[i] = salario [i] + (salario[i] / 2);
				Console.WriteLine($"O novo salário é do Funcionário {i + 1} é: {salario[i]}");
			}else{
				salario[i] = salario [i] + (salario[i] * 0.3);
				Console.WriteLine($"O novo salário é do Funcionário {i + 1} é: {salario[i]}");
			}
		}
	}
}
