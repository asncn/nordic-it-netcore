using System;
using System.Collections.Generic;
using System.Text;

namespace L12_C10_BaseDerivedDemo
{
	public class Rectangle
	{
		public int SideA { get; set; }
		public int SideB { get; set; }

		public override string ToString()
		{
			return $"Rectangle {SideA}×{SideB}";
		}
	}
}
