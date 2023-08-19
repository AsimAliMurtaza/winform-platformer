namespace FreedomFighterGame
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.pbarAtlasHealth = new Guna.UI.WinForms.GunaProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeathE1 = new System.Windows.Forms.Label();
            this.lblHeathE2 = new System.Windows.Forms.Label();
            this.lblHeathE3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 50;
            this.GameLoop.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbarAtlasHealth
            // 
            this.pbarAtlasHealth.BorderColor = System.Drawing.Color.Black;
            this.pbarAtlasHealth.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.pbarAtlasHealth.IdleColor = System.Drawing.Color.Gainsboro;
            this.pbarAtlasHealth.Location = new System.Drawing.Point(119, 526);
            this.pbarAtlasHealth.Name = "pbarAtlasHealth";
            this.pbarAtlasHealth.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pbarAtlasHealth.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pbarAtlasHealth.Size = new System.Drawing.Size(200, 23);
            this.pbarAtlasHealth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atlas Health";
            // 
            // lblHeathE1
            // 
            this.lblHeathE1.AutoSize = true;
            this.lblHeathE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHeathE1.Location = new System.Drawing.Point(499, 487);
            this.lblHeathE1.Name = "lblHeathE1";
            this.lblHeathE1.Size = new System.Drawing.Size(144, 20);
            this.lblHeathE1.TabIndex = 6;
            this.lblHeathE1.Text = "Mechanoid Health";
            // 
            // lblHeathE2
            // 
            this.lblHeathE2.AutoSize = true;
            this.lblHeathE2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHeathE2.Location = new System.Drawing.Point(499, 507);
            this.lblHeathE2.Name = "lblHeathE2";
            this.lblHeathE2.Size = new System.Drawing.Size(110, 20);
            this.lblHeathE2.TabIndex = 7;
            this.lblHeathE2.Text = "Xenon Health";
            // 
            // lblHeathE3
            // 
            this.lblHeathE3.AutoSize = true;
            this.lblHeathE3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHeathE3.Location = new System.Drawing.Point(499, 529);
            this.lblHeathE3.Name = "lblHeathE3";
            this.lblHeathE3.Size = new System.Drawing.Size(122, 20);
            this.lblHeathE3.TabIndex = 8;
            this.lblHeathE3.Text = "Shadow Health";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::FreedomFighterGame.Properties.Resources.cosmic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 567);
            this.Controls.Add(this.lblHeathE3);
            this.Controls.Add(this.lblHeathE2);
            this.Controls.Add(this.lblHeathE1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbarAtlasHealth);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freedom Fighter";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private Guna.UI.WinForms.GunaProgressBar pbarAtlasHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeathE1;
        private System.Windows.Forms.Label lblHeathE2;
        private System.Windows.Forms.Label lblHeathE3;
    }
}

