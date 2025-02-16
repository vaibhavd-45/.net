using System;

public class CentralBank
{
    public virtual void InterestRate()
    {
        Console.WriteLine("Central Bank interest rate is 4%");
    }
}

public class NationalBank : CentralBank
{
    public override void InterestRate()
    {
        Console.WriteLine("National Bank interest rate is 6%");
    }
}

public class LocalBank : NationalBank
{
    public override void InterestRate()
    {
        Console.WriteLine("Local Bank interest rate is 8%");
    }
}

public class Program
{
    public static void Main()
    {
        CentralBank centralBank = new CentralBank();
        centralBank.InterestRate();

        NationalBank nationalBank = new NationalBank();
        nationalBank.InterestRate();

        LocalBank localBank = new LocalBank();
        localBank.InterestRate();
    }
}
