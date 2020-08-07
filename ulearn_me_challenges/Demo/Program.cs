using System;

namespace RandomFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ShouldFire2(true, "boss", 50));
		}
		static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
		{
			return (!enemyInFront) ? false : (enemyName == "boss") ? ((robotHealth < 50) ? false : true) : true;
			// Simple solution
			// return enemyInFront && (enemyName != "boss" || robotHealth  >= 50);
		}
		public static int MiddleOf(int a, int b, int c)
		{
			int[] numbers;
			numbers = new int[] { a, b, c };
			Array.Sort(numbers);
			return numbers[1];

			// Another option
			/* if ((a > b && a < c) || (a > c && a < b) || a == b) return a;
			   else if ((b > a && b < c) || (b > c && b < a)) return b;
			   else return c; */
		}
		public static bool IsCorrectMove(string from, string to)
		{
			//Checking is it corrent move for queen in chess
			var dx = Math.Abs(to[0] - from[0]); //Horz
			var dy = Math.Abs(to[1] - from[1]); //Vert
			return (dy == dx && dy >= 1) || (dx == 0 && dy >= 1) || (dy == 0 && dx >= 1);
		}
		public static bool IsLeapYear(int year)
		{
			return (year % 400 == 0) ? true : year % 100 == 0 ? false : year % 4 == 0 ? true : false;
			// Another variant
			// return ((year%400==0) || (year%4==0) &&  (year%100!=0));
		}
		static void RightFloatPoint()
		{
			//Right way to handle operations with floating point.
			double x = 1.0 / 10;
			double sum = 0;
			for (int i = 0; i < 10; i++)
				sum += x;
			Console.WriteLine(Math.Abs(sum - 1) < 1e-9);
		}
	}
}
