using System;

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
