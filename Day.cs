using System;

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
namespace DaysCoding
{
	public class Day1
	{
		//public Day1()
		//{
			
		//}

		public void beginDay1()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int p = Convert.ToInt32(Console.ReadLine());

			int turnBeginning = p / 2;
			int turnEnding = (n - p) / 2;

			Console.WriteLine((turnBeginning >= turnEnding ? turnEnding : turnBeginning));
		}
	}
}
