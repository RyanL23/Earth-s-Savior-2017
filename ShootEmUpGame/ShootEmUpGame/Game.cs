using System.Collections.Generic;
using System;
namespace ShootEmUpGame
{
	public class Game
	{
		private Player play;
		private Enemy enem;
		private Projectile proj;
		private List<Unit> unitsList;

		public List<Unit> UnitsList
		{
			get
			{
				return new List<Unit>(unitsList);
			}
		}

		public Game()
		{
			play =  new Player('^',this);
			enem = new Enemy('@');
			proj = new Projectile('¿', true);
			unitsList = new List<Unit> {play, enem, proj};
		}


		public void Run()
		{
			while (true)
			{
				play.Draw();
				enem.Draw();
				proj.Draw();
				//Collide(unitsList[0]);
			}
		}

		public bool Collide(Unit u)
		{ 
			//index of the sent unit
			int index = unitsList.IndexOf(u);

			if (unitsList[index].Equals(play))
			{
				if ((unitsList[index].X == unitsList[unitsList.IndexOf(enem)].X)
				    || (unitsList[index].Y == unitsList[unitsList.IndexOf(enem)].Y)) //compares the x and y cordinates of the given object(player) to one enemy object
				{
					
				}
			}
			//else
				return false;
			
		}

		
	}
}







