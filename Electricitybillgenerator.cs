using System;
<<<<<<< HEAD
using System.Collections.Generic;

class ConsumerBill
{
    public string ConsumerID { get; set; }
    public int Units { get; set; }
    public int ConnType { get; set; } 
    public double BaseCharge { get; set; }
    public double Surcharge { get; set; }
    public double Penalty { get; set; }
    public double Discount { get; set; }
    public double FinalBill { get; set; }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter number of consumers: ");
        int N = int.Parse(Console.ReadLine());

        List<ConsumerBill> list = new List<ConsumerBill>();
        int countDomestic = 0, countCommercial = 0;
        double totalRevenue = 0;
        double highestBill = 0;
        string highestID = "";

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"\nEnter details for Consumer {i + 1}:");
            Console.Write("ConsumerID: ");
            string id = Console.ReadLine();

            Console.Write("Units Consumed: ");
            int units = int.Parse(Console.ReadLine());

            Console.Write("ConnectionType (1=Domestic, 2=Commercial): ");
            int type = int.Parse(Console.ReadLine());

            ConsumerBill cb = new ConsumerBill();
            cb.ConsumerID = id;
            cb.Units = units;
            cb.ConnType = type;

            
            double baseCharge = 0;

            if (type == 1)   
            {
                countDomestic++;
                if (units <= 100) baseCharge = units * 1.50;
                else if (units <= 300) baseCharge = units * 2.50;
                else baseCharge = units * 4.00;
            }
            else if (type == 2)  
            {
                countCommercial++;
                if (units <= 200) baseCharge = units * 5.00;
                else if (units <= 500) baseCharge = units * 6.50;
                else baseCharge = units * 8.00;
            }

            cb.BaseCharge = baseCharge;

            
            cb.Surcharge = baseCharge * 0.03;

            
            cb.Penalty = (units > 500) ? 200 : 0;

            
            double totalBeforeDiscount = cb.BaseCharge + cb.Surcharge + cb.Penalty;

            
            if (totalBeforeDiscount > 2000)
                cb.Discount = totalBeforeDiscount * 0.05;
            else
                cb.Discount = 0;

            
            cb.FinalBill = totalBeforeDiscount - cb.Discount;

         
            if (cb.FinalBill > highestBill)
            {
                highestBill = cb.FinalBill;
                highestID = cb.ConsumerID;
            }

            totalRevenue += cb.FinalBill;

            list.Add(cb);
        }

        Console.WriteLine("\n--- Detailed Bills ---");

        foreach (var c in list)
        {
            string typeName = (c.ConnType == 1) ? "Domestic" : "Commercial";

            Console.WriteLine(
                $"{c.ConsumerID} {typeName} Units:{c.Units} " +
                $"Base:{c.BaseCharge:F2} Surcharge:{c.Surcharge:F2} " +
                $"Penalty:{c.Penalty:F2} Discount:{c.Discount:F2} Final:{c.FinalBill:F2}");
        }

        Console.WriteLine("\n--- Summary ---");
        Console.WriteLine($"Total Consumers: {N}");
        Console.WriteLine($"Total Revenue: ₹{totalRevenue:F2}");
        Console.WriteLine($"Highest Bill: {highestID} ₹{highestBill:F2}");
        Console.WriteLine($"Domestic: {countDomestic}  Commercial: {countCommercial}");
    }
}
=======

<<<<<<< HEAD
namespace DeviceMonitor
{
    class TemperatureModule
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Temperature Module is running...");

            VibrationModule.Run();
        }
    }

    class VibrationModule
    {
        public static void Run()
        {
            Console.WriteLine("Vibration Module helper function executed.");
        }
    }
}
=======
class TransactionDemo
{
    static void Main()
    {
        string transactionId = "TRX123456";
        decimal amount = 1000000.25m;
        bool isinternational = true;
        DateTime transactiontimestamp = DateTime.Now;
        int rewardpoints = 1500;

        Console.WriteLine("Transaction ID:{0}",transactionId);
        Console.WriteLine("Amount: {0}",amount);
        Console.WriteLine("Is International:{0}",isinternational);
        Console.WriteLine("Transaction Timestamp:{0}",transactiontimestamp);
        Console.WriteLine("Reward Points: {0}",rewardpoints);
    }

}
>>>>>>> a0d8b1cacf371995eff68ce7cee7be5eb5ecb29d
>>>>>>> 188678bc3149f4053cf2329fd295547d8f1015cb
