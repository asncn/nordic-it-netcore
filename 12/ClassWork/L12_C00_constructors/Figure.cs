namespace L12_C00_constructors
{
	public class Figure
	{
		public string FigureType { get; private set; }

		public Figure(string figureType)
		{
			FigureType = figureType;
		}
	}
}
