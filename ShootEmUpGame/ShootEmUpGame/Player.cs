using System;

namespace ShootEmUpGame
{
    class Player : Unit
    {
        private int x = 5;
        private int y = 0;
        private char unitGraphic;
		private Game myGame;

        public Player(char Graphic, Game game)
            :base(Graphic)
        {
            unitGraphic = Graphic;
			Console.SetCursorPosition(this.X, this.Y);
            Console.WriteLine(Graphic);
			myGame = game;
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
                    // throw (new Exception("X out of bounds"));
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
                    // throw (new Exception("Y out of bounds"));
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
            this.Move(4);
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
            if (Console.KeyAvailable)
            { 
			ConsoleKeyInfo input = Console.ReadKey(true);
                switch (input.Key) { 
            
                case ConsoleKey.DownArrow:
                    Y++;
                    break;

                case ConsoleKey.UpArrow:
                    Y--;
                    break;

                case ConsoleKey.RightArrow:
                    X++;
                    break;

                case ConsoleKey.LeftArrow:
                    X--;
                    break;
                }
			}
        }

			     
    }
}



