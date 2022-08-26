internal class Program
{
 
    private static void Main(string[] args)
    {
        Console.WriteLine("Seja bem vindo!");
        // Testando operações matemáticas para fazer cálculo do salário.
        Console.WriteLine("Vamos calcular seu salário?\n");
        double num1, num2, num3, num4, num5;
        num1 = 2500;
        num2 = 30;
        num3 = 4;
        num4 = 0;
        num5 = 12;
       
        Console.WriteLine(" Insira aqui o valor:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escolha a opçao que deseja saber:");
        Console.WriteLine("d - dia");
        Console.WriteLine("s - semana");
        Console.WriteLine("m - mês");
        Console.WriteLine("a - ano");

        switch (Console.ReadLine())
        {
            case "d":
                Console.Write($" O seu dia de trabalho vale:\nR$ {num1} / {num2} = " + (num1 / num2));
                break;

            case "s":
                Console.Write($" A sua semana de trabalho vale:\nR$ {num1} / {num3} = " + (num1 / num3));
                break;

            case "m":
                Console.Write($" O seu mês de trabalho vale: \nR$ {num1} + {num4} = " + (num1 + num4));
                break;

            case "a":
                Console.Write($" O seu ano de trabalho vale\nR$ {num1} * {num5} = " + (num1 * num5));
                break;
        }
    }
}
