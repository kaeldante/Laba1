/*
 * Создано в SharpDevelop.
 * Пользователь: 123
 * Дата: 16.01.2021
 * Время: 10:44
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace laba1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.Write("Введите имя пользователя: " );
			string name = Console.ReadLine();
			Console.WriteLine("Добро пожаловать: " + name);
			Console.WriteLine("Для выхода нажмите любую клавишу!");
			
			Console.ReadKey();
			
		}
	}
}