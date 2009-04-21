using System.Diagnostics;

namespace SOLID.SampleApp
{

	public interface Shape
	{

		int Area();
		
	}

	public class Rectangle: Shape
	{

		public virtual int Height { get; set; }

		public virtual int Width { get; set; }

		public int Area()
		{
			return Height * Width;
		}

	}

	public class Square : Shape
	{

		public int LengthOfSides { get; set; }

		public int Area()
		{
			return LengthOfSides ^ 2;
		}
	}

	public class DoStuff
	{
		
		public void DoTheRectangleStuff()
		{
			Rectangle rectangle = new Rectangle();
			rectangle.Height = 4;
			rectangle.Width = 5;
			AssertTheArea(rectangle, 20);
		}
		
		public void DoTheSquareStuff()
		{
			Square square = new Square();
			square.LengthOfSides = 4;
			AssertTheArea(square, 16);
		}

		private void AssertTheArea(Shape shape, int expectedArea)
		{
			int actualArea = shape.Area();
			Debug.Assert(expectedArea == actualArea);
		}

	}

}
