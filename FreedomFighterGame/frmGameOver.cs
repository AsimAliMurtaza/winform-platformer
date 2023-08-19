﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreedomFighterGame
{
    public partial class frmGameOver : Form
    {
        public frmGameOver(Image BackgroundScreen)
        {
            InitializeComponent();
            this.BackgroundImage = BackgroundScreen;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {

        }
    }
}
