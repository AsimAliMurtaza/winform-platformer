using FreedomFighterGame.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreedomFighterGame.GameGL
{
    class GameAtlas : GameObject
    {
        public int Score = 0;
        public bool isJumping;
        public int Health = 100;
        public GameAtlas(Image displayCharacter,GameCell startCell):base (GameObjectType.PLAYER,displayCharacter) {
            this.CurrentCell = startCell;
        }
        public GameCell move(GameDirection direction) {

            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.GetBlankObject());
            }
            return nextCell.nextCell(direction);
        }
    }

    
}
