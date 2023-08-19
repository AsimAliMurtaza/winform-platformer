using FreedomFighterGame.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreedomFighterGame.GameGL
{
    internal class REnemy:Enemy
    {
        public REnemy(Image displayCharacter, GameCell g, int h) : base(displayCharacter, g, h)
        {

            this.CurrentCell = g;
            this.DisplayCharacter = displayCharacter;
        }
        public override GameCell move()
        {
            if (prevObject == GameObjectType.REWARD)
            {
                CurrentCell.setGameObject(Game.GetRewardObject());
            }
            else if (prevObject == GameObjectType.NONE)
            {
                CurrentCell.setGameObject(Game.GetBlankObject());
            }
            int value = ghostDirection();
            Direction = (GameDirection)value;
            //if (value == 0)
            //{
            //    Direction = GameDirection.Right;
            //}
            //if (value == 1)
            //{
            //    Direction = GameDirection.Left;
            //}
            //if (value == 2)
            //{
            //    Direction = GameDirection.Down;
            //}
            //if (value == 3)
            //{
            //    Direction = GameDirection.Up;
            //}
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
            CurrentCell = nextCell;
            /*if (currentCell != nextCell)
            {
                currentCell.setGameCbject(Game.GetBlankObject());

            }*/
            return CurrentCell.nextCell(Direction);
        }

        public int ghostDirection()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }
    }
}
