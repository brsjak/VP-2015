using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2GameOfLife
{
    public class DeluxeLife :Game
    {
        public enum GameType
        {
            MiserableLife,
            HappyLife,
            BabyLife,
            RealLife
        }
        public GameType Type { get; set; }
        public DeluxeLife(GameType gameType, int maxGenerations)
            : base(maxGenerations)
        {
            Type = gameType;
            if (gameType == GameType.MiserableLife)
            {
                grid = new Grid(5, 5);
                grid.ToggleCell(0, 3, true);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(1, 4, true);
                grid.ToggleCell(2, 3, true);
                grid.ToggleCell(3, 0, true);
                grid.ToggleCell(4, 1, true);
                grid.ToggleCell(4, 3, true);
                grid.ToggleCell(4, 4, true);
              
                
            }

            if (gameType == GameType.HappyLife)
            {
                grid = new Grid(7, 7);
                grid.ToggleCell(1, 0, true);
                grid.ToggleCell(2, 0, true);
                grid.ToggleCell(2, 3, true);
                grid.ToggleCell(2, 4, true);
                grid.ToggleCell(2, 5, true);
                grid.ToggleCell(3, 5, true);
                grid.ToggleCell(3, 6, true);
                grid.ToggleCell(4, 5, true);
                grid.ToggleCell(5, 1, true);
                grid.ToggleCell(5, 2, true);
                grid.ToggleCell(5,5, true);
                grid.ToggleCell(6, 1, true);
                grid.ToggleCell(6, 2, true);
                grid.ToggleCell(6, 4, true);
                
            }
            if (gameType == GameType.BabyLife) {
                grid = new Grid(3, 3);
                grid.ToggleCell(0, 3,true);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
            }
            if (gameType == GameType.RealLife)
            {
                grid = new Grid(6, 6);
                grid.ToggleCell(0, 4, true);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(1, 3, true);
                grid.ToggleCell(1, 4, true);
                grid.ToggleCell(2, 0, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
                grid.ToggleCell(2, 3, true);
                grid.ToggleCell(2, 5, true);
                grid.ToggleCell(3, 1, true);
                grid.ToggleCell(3, 5, true);
                grid.ToggleCell(5, 2, true);
                grid.ToggleCell(4, 3, true);
                grid.ToggleCell(4, 5, true);

            }

        }
        override public void Show()
        {
            Console.Title = String.Format("DeluXe Life Game: {0}", Type);
            base.Show();
        }
    }
}
