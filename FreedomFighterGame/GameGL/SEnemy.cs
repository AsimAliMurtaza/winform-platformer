using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreedomFighterGame.Framework;

namespace FreedomFighterGame.GameGL
{
    internal class SEnemy : Enemy
    {
        private GameAtlas Atlas;
        public SEnemy(Image displayCharacter, GameCell g, GameAtlas p, int h) : base(displayCharacter, g, h)
        {

            this.CurrentCell = g;
            this.DisplayCharacter = displayCharacter;
            this.Atlas = p;
        }
        public override GameCell move()
        {
            List<double> distance = new List<double>();
            distance.Add(CalculateDistance(this.CurrentCell.nextCell(GameDirection.Left), Atlas.CurrentCell));
            distance.Add(CalculateDistance(this.CurrentCell.nextCell(GameDirection.Right), Atlas.CurrentCell));
            distance.Add(CalculateDistance(this.CurrentCell.nextCell(GameDirection.Down), Atlas.CurrentCell));
            distance.Add(CalculateDistance(this.CurrentCell.nextCell(GameDirection.Up), Atlas.CurrentCell));

            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {
                Direction = GameDirection.Left;
            }
            else if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {
                Direction = GameDirection.Right;
            }
            else if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                Direction = GameDirection.Down;
            }
            else
            {
                Direction = GameDirection.Up;
            }

            if (prevObject == GameObjectType.REWARD)
            {
                CurrentCell.setGameObject(Game.GetRewardObject());
            }
            else if (prevObject == GameObjectType.NONE)
            {
                CurrentCell.setGameObject(Game.GetBlankObject());
            }
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(Direction);
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                prevObject = GameObjectType.REWARD;
            }
            else if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.NONE)
            {
                prevObject = GameObjectType.NONE;
            }
            nextCell.setGameObject(this);
            this.CurrentCell = nextCell;
            /*if (currentCell != nextCell)
            {
                currentCell.setGameCbject(Game.GetBlankObject());

            }*/
            return nextCell.nextCell(Direction);
            /*GameCell cell;
                cell = CurrentCell;
                double shortestDistance = CalculateDistance(CurrentCell, pacman.CurrentCell);

              List<GameCell> neighborCell = new List<GameCell>();
              neighborCells.Add(this.CurrentCell.nextCell(GameDirection.Right));
              neighborCells.Add(this.CurrentCell.nextCell(GameDirection.Left));
              neighborCells.Add(this.CurrentCell.nextCell(GameDirection.Up));
              neighborCells.Add(this.CurrentCell.nextCell(GameDirection.Down));

              foreach (GameCell neighborCell in neighborCells)
              {
                  if (neighborCell.CurrentGameObject.GameObjectType == GameObjectType.NONE || neighborCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
                  {
                  double distance = CalculateDistance(neighborCell, pacman.CurrentCell);
                  if (distance < shortestDistance)
                  {
                      shortestDistance = distance;
                      cell = neighborCell;
                  }
                  }
            }
            CurrentCell = cell;
            if (CurrentCell != cell)
            {
                CurrentCell.setGameCbject(Game.GetBlankObject());
            }

            return CurrentCell;*/
        }
        private double CalculateDistance(GameCell cell1, GameCell cell2)
        {
            int x1 = cell1.X;
            int y1 = cell1.Y;
            int x2 = cell2.X;
            int y2 = cell2.Y;
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
