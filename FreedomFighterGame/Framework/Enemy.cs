using FreedomFighterGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreedomFighterGame.Framework
{
    internal abstract class Enemy:GameObject
    {
        protected GameDirection Direction;
        private int Health;
        public GameObjectType prevObject = GameObjectType.REWARD;
        private ProgressBar progressBar = new ProgressBar();

        public int Healths { get => Health; set => Health = value; }
        public ProgressBar ProgressBar { get => progressBar; set => progressBar = value; }

        public Enemy(Image displayCharacter, GameCell g, int Health):base(GameObjectType.ENEMY, displayCharacter)
        {
            this.Health = Health;
            progressBar.Minimum = 0;
            progressBar.Maximum = Health;
            progressBar.Value = Health;
            progressBar.Width = 100;
            progressBar.Height = 10;
        }
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if(Health  < 0)
            {
                Health = 0;
            }
            if(progressBar != null)
            {
                progressBar.Value = Health;
            }
        }
        public abstract GameCell move();
    }
}
