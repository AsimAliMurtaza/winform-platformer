using FreedomFighterGame.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreedomFighterGame.GameGL
{
    internal class Bullet:GameObject
    {
        public GameDirection Direction;
        public int damage = 20;
        public Bullet(Image displayCharacter, GameCell startCell, GameDirection direction) : base(GameObjectType.FIRE, displayCharacter)
        {
            this.CurrentCell = startCell;
            this.Direction = direction;
            //this.DisplayCharacter = displayCharacter;
        }
        public GameCell move(GameDirection direction)
        {

            GameCell currentCell = this.CurrentCell;
            GameCell prev = new GameCell(this.currentCell.X, this.currentCell.Y, currentCell.grid);
            GameCell nextCell = currentCell.nextCell(direction);
            CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.GetBlankObject());
            }
            if (currentCell == nextCell)
            {
                currentCell.setGameObject(Game.GetBlankObject());
            }

            return prev;//nextCell.nextCell(direction);
        }
    }
}
