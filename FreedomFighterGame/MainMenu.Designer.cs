namespace FreedomFighterGame
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new Guna.UI.WinForms.GunaButton();
            this.btnOption = new Guna.UI.WinForms.GunaButton();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Freedom Fighter";
            // 
            // btnStart
            // 
            this.btnStart.Animated = true;
            this.btnStart.AnimationHoverSpeed = 0.07F;
            this.btnStart.AnimationSpeed = 0.03F;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BaseColor = System.Drawing.Color.DarkSlateBlue;
            this.btnStart.BorderColor = System.Drawing.Color.Black;
            this.btnStart.BorderSize = 1;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStart.FocusedColor = System.Drawing.Color.Empty;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Image = global::FreedomFighterGame.Properties.Resources.player_ship;
            this.btnStart.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStart.Location = new System.Drawing.Point(91, 185);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnStart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStart.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStart.OnHoverImage = null;
            this.btnStart.OnPressedColor = System.Drawing.Color.Black;
            this.btnStart.Radius = 20;
            this.btnStart.Size = new System.Drawing.Size(160, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOption
            // 
            this.btnOption.Animated = true;
            this.btnOption.AnimationHoverSpeed = 0.07F;
            this.btnOption.AnimationSpeed = 0.03F;
            this.btnOption.BackColor = System.Drawing.Color.Transparent;
            this.btnOption.BaseColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOption.BorderColor = System.Drawing.Color.Black;
            this.btnOption.BorderSize = 1;
            this.btnOption.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOption.FocusedColor = System.Drawing.Color.Empty;
            this.btnOption.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnOption.ForeColor = System.Drawing.Color.White;
            this.btnOption.Image = ((System.Drawing.Image)(resources.GetObject("btnOption.Image")));
            this.btnOption.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOption.Location = new System.Drawing.Point(91, 259);
            this.btnOption.Name = "btnOption";
            this.btnOption.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOption.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOption.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOption.OnHoverImage = null;
            this.btnOption.OnPressedColor = System.Drawing.Color.Black;
            this.btnOption.Radius = 20;
            this.btnOption.Size = new System.Drawing.Size(160, 42);
            this.btnOption.TabIndex = 2;
            this.btnOption.Text = "Option";
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.BorderSize = 1;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::FreedomFighterGame.Properties.Resources.alien_blue;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(91, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Radius = 20;
            this.btnExit.Size = new System.Drawing.Size(160, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FreedomFighterGame.Properties.Resources.cosmic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 520);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnStart;
        private Guna.UI.WinForms.GunaButton btnOption;
        private Guna.UI.WinForms.GunaButton btnExit;
    }
}