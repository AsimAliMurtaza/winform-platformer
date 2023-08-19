using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreedomFighterGame.Properties;

namespace FreedomFighterGame.Framework
{
    internal class Game
    {
        public static Image GetGameObjectImage(char displayCharacter)
        {
            Image img = Resources.simplebox;
            if(displayCharacter == '#')
            {
                img = Resources.block;
                return img;
            }
            if (displayCharacter == 'O')
             {
                 img = Resources.life;
                 return img;
             }
            /*if (displayCharacter == 'p')
            {
                img = Resources.pacman_open;
                return img;
            }*/
            return null;
        }
        public static GameObject GetBlankObject()
        {
            GameObject blank = new GameObject(GameObjectType.NONE, Resources.simplebox);
            return blank;
        }
        public static GameObject GetRewardObject()
        {
            GameObject blank = new GameObject(GameObjectType.REWARD, Resources.life);
            return blank;
        }
    }
}
