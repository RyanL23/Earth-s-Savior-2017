using System;
namespace ShootEmUpGame
{
	public class Enemy : Unit
	{
        public int TimeBetweenMoves = 1000000;
        private int timeSinceLastMoved = 0;
		private int x = 0;
        private int y = 0;
        private char unitGraphic;

		public Enemy(char Graphic)
            :base(Graphic)
		{
			unitGraphic = Graphic;
			Console.SetCursorPosition(this.X, this.Y);
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
                    //throw (new Exception("X out of bounds"));
                }
                else
                {
                    this.Undraw();
                    value = x;
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
                    //throw (new Exception("Y out of bounds"));
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
			this.Draw(200);
		}

        public override void Draw(int deltaTime)
		{
			this.Move(deltaTime);
            Console.SetCursorPosition(this.X, this.Y);
			Console.Write(this.unitGraphic.ToString());
        }

        protected override void Undraw()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(" ");
        }

        protected override void Move(int deltaTimeMS)
		{
            timeSinceLastMoved += deltaTimeMS;
            if(timeSinceLastMoved < TimeBetweenMoves)
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







