using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2GameOfLife
{
    /// <summary>
    /// Implementacija na igrata so pochetna sostojba so statichki raspored na zhivi kletki
    ///  koi ne se menuvaat pri evolucija.
    /// </summary>
    class StillLifeGame : Game
    {
        public enum GameType
        {
            Block,
            Beehive,
            Loaf,
            Boat
        }

        public GameType Type { get; set; }

        public StillLifeGame(GameType gameType, int maxGenerations) : base(maxGenerations)
        {
            Type = gameType;
            if (Type == GameType.Block)
            {
                grid = new Grid(4, 4);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
            }

            if (Type == GameType.Beehive)
            {
                grid = new Grid(5, 6);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(1, 3, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 4, true);
                grid.ToggleCell(3, 2, true);
                grid.ToggleCell(3, 3, true);
            }
        }

        override public void Show()
        {
            Console.Title = String.Format("Still Game of Life: {0}", Type);
            base.Show();
        }
    }
}
