using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreedomFighterGame.Framework;

namespace FreedomFighterGame.GameDL
{
    internal class EnemyDL
    {
        public static List<Enemy> enemies = new List<Enemy>();

        public static void AddEnemy(Enemy e)
        { enemies.Add(e); }
    }
}
