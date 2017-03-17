using System;
namespace ShootEmUpGame
{
	public abstract class Unit
	{	
		private int x = 0;
		private int y = 0;
		private Game curGame;
		private char unitGraphic;

		protected Unit(char graphic)
		{
		}

		public int X
		{
			get
			{
				return this.x;
			}
		}

		public int Y
		{
			get
			{
				return this.y;
			}
		}

		public virtual void Draw()
		{
		}

		public virtual void Draw(int deltaTime)
		{
		}


		protected virtual void Move(int deltaTimeMS)
		{
		}

        protected virtual void Undraw()
        {
        }

		protected void SetUnitPostion(int x, int y)
		{
			if (x >= 0 && x < Console.WindowWidth && y >= 0 && y < Console.WindowHeight)
			{
				this.x = x;
				this.y = y;
			}
		}

		public Boolean Equals(Unit compare)
		{
			return (this.GetType().Equals(compare.GetType()));
		}
	}
}






