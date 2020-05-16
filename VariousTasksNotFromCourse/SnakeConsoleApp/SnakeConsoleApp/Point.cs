﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeConsoleApp.Enums;

namespace SnakeConsoleApp
{
	class Point
	{
		int _left;
		int _top;
		char _symbol;

		public char Sympol
		{
			get { return _symbol; }
			set { _symbol = value; }
		}

		public Point(int left, int top, char symbol)
		{
			_left = left;
			_top = top;
			_symbol = symbol;
		}

		public void SetDirection(int i, DirectionEnum direction)
		{
			switch (direction)
			{
				case DirectionEnum.Right:
					_left = _left + i;
					break;
				case DirectionEnum.Left:
					_left = _left - i;
					break;
				case DirectionEnum.Up:
					_top = _top - i;
					break;
				case DirectionEnum.Down:
					_top = _top + i;
					break;
			}
		}

		internal void ClearPoint()
		{
			MyProperty = ' ';
			DrawPoint();
		}

		public void DrawPoint()
		{
			Console.SetCursorPosition(_left, _top);
			Console.Write(MyProperty);
		}
	
	}
}
