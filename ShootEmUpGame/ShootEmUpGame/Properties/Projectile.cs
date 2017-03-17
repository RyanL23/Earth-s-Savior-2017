using System;
namespace ShootEmUpGame
{
	public class  Projectile: Unit
	{
		private char unitGraphic; // Create indivual enemy and player projectile classes
		private int TimeBetweenMoves = 10000;
		private int timeSinceLastMoved = 0;
		private Boolean type;
		private int x = 9;
		private int y = 0;

		public Projectile(char Graphic, Boolean type)
			:base(Graphic)
		{
			this.type = type;
			unitGraphic = Graphic;
			Console.SetCursorPosition(this.X,this.Y);
			Console.WriteLine(unitGraphic);
		}

		public int X
		{
			get
			{
				return this.x;
			}

			set
			{
				if (value < 0 || value >= Console.WindowWidth)
				{
					// throws (new Exception("X out of bounds"));
				}
				else
				{
					this.Undraw();
					x = value;
				}
			}
		}

		public int Y
		{
			get
			{
				return y;
			}

			set
			{
				if (value < 0 || value >= Console.WindowHeight)
				{
					// throws (new Exception("Y out of bounds"));
				}
				else
				{
					this.Undraw();
					y = value;
				}
			}
		}


		public override void Draw()
		{
			if (type == true)
			{
				this.DrawEnemy();
			}
			else
			{
				this.DrawPlayer();
			}
		}


		private void DrawEnemy()
		{
			this.Move(10);
			Console.SetCursorPosition(this.X, this.Y);
			Console.Write(this.unitGraphic);
		}

		private void DrawPlayer()
		{
			this.Move(10);
			Console.SetCursorPosition(this.X, this.Y);
			Console.Write(this.unitGraphic);
		}

		protected override void Undraw()
		{
			Console.SetCursorPosition(this.X, this.Y);
			Console.Write(" ");
		}

		protected override void Move(int deltaTimeMS)
		{
			timeSinceLastMoved += deltaTimeMS;
			if (timeSinceLastMoved < TimeBetweenMoves)
			{
				//do nothing!
				return;
			}
			else
			{
				timeSinceLastMoved -= TimeBetweenMoves;
				Y++;
			}
		}
	}
}
