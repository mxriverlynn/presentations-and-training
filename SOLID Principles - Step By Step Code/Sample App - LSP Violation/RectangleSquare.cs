using System.Diagnostics;

namespace SOLID.SampleApp
{

	public class Rectangle
	{

		public virtual int Height { get; set; }

		public virtual int Width { get; set; }

		public int Area()
		{
			return Height * Width;
		}

	}

	public class Square : Rectangle
	{

		public override int Height
		{
			get
			{
				return base.Height;
			}
			set
			{
				base.Height = value;
				base.Width = value;
			}
		}

		public override int Width
		{
			get
			{
				return base.Width;
			}
			set
			{
				base.Width = value;
				base.Height = value;
			}
		}

	}

	public class DoStuff
	{
		
		public void DoTheRectangleStuff()
		{
			Rectangle rectangle = new Rectangle();
			rectangle.Height = 4;
			rectangle.Width = 5;
			AssertTheArea(rectangle);
		}
		
		public void DoTheSquareStuff()
		{
			Rectangle square = new Square();
			square.Height = 4;
			AssertTheArea(square);
		}

		private void AssertTheArea(Rectangle rectangle)
		{
			int expectedArea = 20;
			int actualArea = rectangle.Area();
			Debug.Assert(expectedArea == actualArea);
		}

	}

}
