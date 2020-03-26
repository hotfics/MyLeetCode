using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace a
{
	class Solution
	{
		static void Main(string[] args)
		{
			char[,] nums = new char[,] {
				{ '.', '.', '.', '.', '.', '.', '.', '.' }, {
					'.',
					'.',
					'.',
					'p',
					'.',
					'.',
					'.',
					'.'
				}, {
					'.',
					'.',
					'.',
					'p',
					'.',
					'.',
					'.',
					'.'
				}, {
					'p',
					'p',
					'.',
					'R',
					'.',
					'p',
					'B',
					'.'
				},
				 {
					'.',
					'.',
					'.',
					'.',
					'.',
					'.',
					'.',
					'.'
				},
				 {
					'.',
					'.',
					'.',
					'B',
					'.',
					'.',
					'.',
					'.'
				},
				 {
					'.',
					'.',
					'.',
					'p',
					'.',
					'.',
					'.',
					'.'
				},
				 {
					'.',
					'.',
					'.',
					'.',
					'.',
					'.',
					'.',
					'.'
				}
			};
			Console.ReadKey();
		}
		private static int fineLineIndex(char[][] board){

			for (int i = 0; i < 8; i++) {
				for (int j = 0; j < 8; j++) {
					if (board[i][j]=='R') {
					return i;
					}
				}
			}
			return 0;
		}
		public static int NumRookCaptures(char[][] board)
		{			 
			int pLineIndex=fineLineIndex(board);	 
			var rookLine =	board.Where(x => new String(x, 0, 8).Contains('R')).ToList().First();
			int j = 0;
			for (int i = 0; i < 8; i++) {
				if (rookLine[i] == 'R') {
					j = i;
				}
			}
			IList<char> hLine = new List<char>();
			for (int i = 0; i < 8; i++) {
				hLine.Add(board[i][j]);
			}
			int vnum = num(rookLine.ToList(), j);
			int hnum = num(hLine, pLineIndex);			
			return vnum + hnum;
		}
		
		 
		public static int num(IList<char> line, int j)
		{
			int pCount = 0;
			for (int a = j; a >= 0; a--) {
				if (line[a] == 'B') {
					break;
				}
				if (line[a] == 'p') {
					pCount++;
					break;
				}
			}
			for (int b = j; b < 8; b++) {
				if (line[b] == 'B') {
					break;
				}
				if (line[b] == 'p') {
					pCount++;
					break;
				}
			}
			return pCount;
		}
	} 
}