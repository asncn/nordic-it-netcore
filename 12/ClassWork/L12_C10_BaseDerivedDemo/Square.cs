using System;
using System.Collections.Generic;
using System.Text;

namespace L12_C10_BaseDerivedDemo
{
	public class Square
	{
		public int SideA { get; set; }

		public override string ToString()
		{
			return $"Square with side {SideA}";
		}
	}
}
