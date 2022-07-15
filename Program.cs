namespace Calculator
{



  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Menu();
        var operation = ReadOperation();

        float firstNumber = ReadNumber("Digite o primeiro número: ");
        float secondNumber = ReadNumber("Digite o segundo número: ");
        float result;

        switch (operation)
        {
          case 1:
            result = Sum(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
            break;
          case 2:
            result = Sub(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
            break;
          case 3:
            result = Mult(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} * {secondNumber} = {result}"); break;
          case 4:
            result = Div(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} / {secondNumber} = {result}"); break;
          default:
            Console.WriteLine("Invalid operation. Please try again.");
            break;
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();

      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Bem vindo a sua Calculadora!");
      Console.WriteLine("Operações disponíveis: ");
      Console.WriteLine("1- Adição");
      Console.WriteLine("2- Subtração");
      Console.WriteLine("3- Multiplicação");
      Console.WriteLine("4- Divisão");
      Console.WriteLine("5- Sair");
      Console.Write("Digite a operação desejada: ");
    }

    static float ReadOperation()
    {
      string? operation = null;

      while (operation == null)
      {
        try
        {
          operation = Console.ReadLine();
          ValidateOperation(operation);
        }
        catch (Exception e)
        {
          Console.Write(e.Message);
          operation = null;
        }
      }

      return float.Parse(operation);
    }

    static void ValidateOperation(string? operation)
    {
      string[] operations = new string[4] { "1", "2", "3", "4" };


      if (operation == null)
      {
        throw new Exception("Operação inválida. Digite novamente: ");
      }

      if (operation == "5")
      {
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
      }


      if (!operations.Any(operation.Contains))
      {
        throw new Exception("Operação inválida. Digite novamente: ");
      }
    }

    static float ReadNumber(string? message)
    {
      string? number = null;

      if (message != null)
      {
        Console.Write(message);
      }


      while (number == null)
      {
        try
        {
          number = Console.ReadLine();
          ValidateValue(number);
        }
        catch (Exception e)
        {
          Console.Write(e.Message);
          number = null;
        }
      }

      return float.Parse(number);
    }

    static void ValidateValue(string? a)
    {
      if (a?.Length <= 0)
      {
        throw new Exception("Número inválido. Digite novamente: ");
      }
    }

    static float Sum(float a, float b)
    {
      return a + b;
    }

    static float Sub(float a, float b)
    {
      return a - b;
    }

    static float Mult(float a, float b)
    {
      return a * b;
    }

    static float Div(float a, float b)
    {
      return a / b;
    }
  }
}