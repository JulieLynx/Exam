using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Solo Learn Game";
			//ConsoleKey key;
			char buff;

			do
			{
				Random rand = new Random();
				int counter = 0;
				int size = 0;
				Console.WriteLine("{0,50}", "Press ANY KEY to START this game");
				Console.WriteLine("{0,50}", "--------------------------------");
				Console.ReadKey(true);
				//--------------------------------------------------------------------------
				Console.WriteLine("Выберите сложность игры:\n1.легкая\n2.средняя\n3.сложная\nНажмите 1, 2 или 3 чтобы начать...");
				buff = Console.ReadKey(true).KeyChar; ;
				if (buff == '1') size = 5;
				else if (buff == '2') size = 10;
				else if (buff == '3') size = 20;

				char[] arr = new char[size];
				char[] arr1 = new char[size];
				//--------------------------------------------------------------------------
				for (int i = 0; i < size; i++)
				{
					if (i % 5 == 0 && i > 0)
					{
						arr[i] = ' ';
						i++;
					}
					arr[i] = Convert.ToChar(rand.Next(97, 122));
				}
				//--------------------------------------------------------------------------
				for (int i = 0; i < size; i++)
				{
					Console.Write(arr[i]);
				}
				Console.WriteLine();
				//--------------------------------------------------------------------------

				for (int i = 0; i < size; i++)
				{
					buff = Console.ReadKey(true).KeyChar;
					//----------


					//-----------
					if (buff != arr[i])
					//Не правильные
					{
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write('\a');
						arr1[counter] = arr[i];
						counter++;
						if (buff == ' ')
						{
							buff = '_';
						}
					}
					//Правильные
					else if (buff == arr[i])
					{
						Console.ForegroundColor = ConsoleColor.Green;
					}
					Console.Write(buff);
				}
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("\n\nВы сделали ошибок: " + counter);

				////////////////////работа над ошибками//////////////////
				Array.Resize<char>(ref arr1, counter);
				do
				{
					int counter1 = 0;
					Console.WriteLine("{Хотите ли Вы сделать работу над ошибками? \nНажмите ANY KEY (если да) / Escape (если нет)");
					ConsoleKey key = Console.ReadKey(true).Key;
					if (key == ConsoleKey.Escape) break;

					Console.WriteLine();
					for (int i = 0; i < arr1.Length; i++)
					{
						Console.Write(arr1[i]);
					}
					Console.WriteLine();

					for (int i = 0; i < arr1.Length; i++)
					{
						buff = Console.ReadKey(true).KeyChar;
						if (buff != arr1[i])
						//Не правильные
						{
							Console.ForegroundColor = ConsoleColor.White;
							Console.Write('\a');
							counter1++;
							if (buff == ' ')
							{
								buff = '_';
							}
						}
						//Правильные
						else if (buff == arr1[i])
						{
							Console.ForegroundColor = ConsoleColor.Green;
						}
						Console.Write(buff);
					}
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("\n\nВы сделали ошибок: " + counter1);
					//---------------------------------------------------------

					Console.WriteLine("\n\nВы хотите сделать работу над ошибками заново?\nНажмите ANY KEY (если да) / N (если нет)");
					buff = Console.ReadKey(true).KeyChar;
					Console.Clear();
					if (buff == 'n' && buff == 'N' || buff == 'т' || buff == 'Т') break;
				} while (buff != 'n');


				/////////////////////////////////////////////////////////


				Console.WriteLine("\n\nВы хотите начать эту игру заново?\nНажмите ANY KEY (если да) / N (если нет)");
				buff = Console.ReadKey(true).KeyChar;
				Console.Clear();
				if (buff == 'n' && buff == 'N' || buff == 'т' || buff == 'Т') break;

			} while (buff != 'n');
		}
	}
}

