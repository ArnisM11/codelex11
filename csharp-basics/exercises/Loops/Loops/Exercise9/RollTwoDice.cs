using System;

class RollTwoDice
{
    private int sum;
    private int rolledSum, dice1, dice2;
    Random rand = new Random();
    public RollTwoDice()
    {
        Console.Write("Desired sum : ");
        sum = Convert.ToInt32(Console.ReadLine());
        do
        {
            dice1 = rand.Next(1, 7);
            dice2 = rand.Next(1, 7);
            rolledSum = dice1 + dice2;
            Console.WriteLine(dice1 + " and " + dice2 + " = " + (dice1 + dice2));
        } while (sum != rolledSum);
    }
}