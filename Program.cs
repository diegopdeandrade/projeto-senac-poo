class Program
{
    public static void Main(string[] args)
    {
        Carro carro1 = new Carro();
        double resultadoCarro = carro1.CalcularValorTotal(10);
        Console.WriteLine("Valor de 10 diarias(carro):" + carro1.CalcularValorTotal(10));

        Moto moto1 = new Moto();
        Console.WriteLine("Valor de 10 diarias(moto):" + moto1.CalcularValorTotal(10));
    }
}

public abstract class Veiculo
{
    protected double TaxaDiaria {get;set;}
    public abstract double CalcularValorTotal(int numDiaria);
}

public class Carro : Veiculo    
{
    protected double taxaDiaria = 50;

    public override double CalcularValorTotal(int numDiaria)
    {
        return taxaDiaria * numDiaria;
    }
}

public class Moto : Veiculo
{
    double taxaDiaria = 25;

    public override double CalcularValorTotal(int numDiaria)
    {
        return (taxaDiaria * numDiaria);
    }
}
