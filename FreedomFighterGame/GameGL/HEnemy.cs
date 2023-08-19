using FreedomFighterGame.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreedomFighterGame.GameGL
{
    internal class HEnemy : Enemy
    {
        //private bool isMoving;
        public HEnemy(Image displayCharacter, GameCell g, GameDirection Direction, int h) : base(displayCharacter, g, h)
        {
            this.CurrentCell = g;
            this.DisplayCharacter = displayCharacter;
            this.Direction = Direction;
            /*this.isMoving = true;*/
        }

        public override GameCell move()
        {
            if(prevObject == GameObjectType.REWARD)
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
            CurrentCell = nextCell;
            /*if (currentCell != nextCell)
            {
                currentCell.setGameCbject(Game.GetBlankObject());

            }*/
            if(nextCell==currentCell)
                if(Direction == GameDirection.Left)
                {
                    Direction = GameDirection.Right;
                }
                else if (Direction == GameDirection.Right) 
                {
                    Direction = GameDirection.Left;
                }
            return nextCell.nextCell(Direction);
            /*if (isMoving)
            {
                cell = this.CurrentCell.nextCell(Direction);
                if (cell != null && cell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {
                    CurrentCell = cell;
                    if(CurrentCell != cell)
                    {
                        currentCell.setGameCbject(Game.GetBlankObject());
                    }
                }
                
                else
                {
                    isMoving = false;
                    cell = this.CurrentCell.nextCell(GameDirection.Right);
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
                cell = this.CurrentCell.nextCell(GameDirection.Right);
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
                    cell = this.CurrentCell.nextCell(GameDirection.Left);
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
