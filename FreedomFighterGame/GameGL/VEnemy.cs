using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreedomFighterGame.Framework;

namespace FreedomFighterGame.GameGL
{
    internal class VEnemy:Enemy
    {
       // private bool isMoving;
        public VEnemy(Image displayCharacter, GameCell g, GameDirection direction, int h):base(displayCharacter, g, h) {

            this.CurrentCell = g;
            this.DisplayCharacter = displayCharacter;
            //this.isMoving = true;
            this.Direction = direction;
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
            if (nextCell == currentCell)
                if (Direction == GameDirection.Up)
                {
                    Direction = GameDirection.Down;
                }
                else
                {
                    Direction = GameDirection.Up;
                }
            return nextCell.nextCell(Direction);
            /*GameCell cell;
            if(isMoving)
            {
                cell = this.CurrentCell.nextCell(GameDirection.Up);
                if(cell != null && cell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                { 
                    CurrentCell = cell;
                    if (CurrentCell != cell)
                    {
                        currentCell.setGameCbject(Game.GetBlankObject());
                    }
                }
                else
                {
                    isMoving = false;
                    cell = this.CurrentCell.nextCell(GameDirection.Down);
                    if (cell != null && cell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        CurrentCell = cell;
                        if (CurrentCell != cell)
                        {
                            currentCell.setGameCbject(Game.GetBlankObject());
                        }
                    }
                }
            }
            else
            {
                cell = this.CurrentCell.nextCell(GameDirection.Down);
                if (cell != null && cell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    CurrentCell = cell;
                    if (CurrentCell != cell)
                    {
                        currentCell.setGameCbject(Game.GetBlankObject());
                    }
                }
                else
                {
                    isMoving = true;
                    cell = this.CurrentCell.nextCell(GameDirection.Up);
                    if (cell != null && cell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        CurrentCell = cell;
                        if (CurrentCell != cell)
                        {
                            currentCell.setGameCbject(Game.GetBlankObject());
                        }
                    }
                }
            }
            return cell;*/
        }
    }
}
