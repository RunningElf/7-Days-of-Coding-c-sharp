using System;


namespace DaysCoding
{
	public class Day
	{
		/*                DAY 1
		 * Brie’s Drawing teacher asks her class to open their n-page book to page number p. 
		 * Brie can either start turning pages from the front of the book (i.e., page number 1) 
		 * or from the back of the book (i.e., page number n), and she always turns pages 
		 * one-by-one (as opposed to skipping through multiple pages at once). 
		 * When she opens the book, page 1 is always on the right side:
		 * 
		 * Each page in the book has two sides, front and back, except for the last page which 
		 * may only have a front side depending on the total number of pages of the book.
		 * 
		 * Given n and p, find and print the minimum number of pages Brie must turn in 
		 * order to arrive at page p.
		 * 
		 * Input Format
		 * 
		 * The first line contains an integer, n, denoting the number of pages in the book. 
		 * The second line contains an integer, p, denoting the page that Brie's teacher wants her to turn to.
		 * 
		 * https://www.hackerrank.com/contests/w27/challenges/drawing-book
		 */
		public void beginDay1()
		{
			//read n and p from user
			int n = Convert.ToInt32(Console.ReadLine());
			int p = Convert.ToInt32(Console.ReadLine());

			//find the number of pages user must turn from the front of the book and the back 
			int turnBeginning = p / 2;
			int turnEnding = (n - p) / 2;

			//if the number of pages turning from the beginning is larger than that of turning
			//from the back, then turning from the back is smaller and is to be printed. 
			//Else, the beginning is the smalles and should be printed. 
			Console.WriteLine((turnBeginning >= turnEnding ? turnEnding : turnBeginning));
		}


		/*         Day 2 - Currently times out 8,9 and 10 test results
		 * 	Jaime the Tailor's new customer wants to add n distinct clusters of buttons to her dress, 
		 * where each cluster is filled with a distinct number of buttons of a certain color.
		 * 
		 * The customer also has specific ideas about how much she wants to pay for each cluster 
		 * in that for some cluster i, she wants to pay at least a_i dollars. In addition, she wants 
		 * each cluster to contain a distinct number of buttons. And, finally, she wants to 
		 * minimize her total cost.
		 * 
		 * Jaime stocks an infinite number of buttons in an infinite number of colors at his 
		 * shop, and each button costs p dollars. Given n, p, and the amount of money that the 
		 * customer wants to pay for each respective cluster, help Jaime by finding and 
		 * printing a long integer denoting the minimum number of buttons he can use to 
		 * satisfy her request.
		 * 
		 * The first line contains two space-separated integers denoting the respective 
		 * values of n and p. 
		 * The second line contains n space-separated integers where each integer i denotes 
		 * the value of a_i (i.e., the minimum amount of money she wants to spend on cluster i).
		 */

		public void beginDay2()
		{


				string[] tokens_n = Console.ReadLine().Split(' ');
				int n = Convert.ToInt32(tokens_n[0]);
				int p = Convert.ToInt32(tokens_n[1]);
				string[] a_temp = Console.ReadLine().Split(' ');
				//int[] a = Array.ConvertAll(a_temp,Int32.Parse);
				long total = 0;
				int[] a = new int[n];

				for (int x = 0; x < n; x++)
				{
					double temp = Double.Parse(a_temp[x]) / p;
					a[x] = (int)Math.Ceiling(temp);

					while (Array.IndexOf(a, a[x], 0, x) >= 0)
					{
						a[x]++;
					}

					total += a[x];
				}


				Console.WriteLine(total);

		


		}

	}
}
