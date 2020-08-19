namespace _2020_Assessment_Dog_VS_Frog
{
    partial class GameWindow
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
            this.PnlGame = new System.Windows.Forms.Panel();
            this.TmrFrog = new System.Windows.Forms.Timer(this.components);
            this.lblLives = new System.Windows.Forms.Label();
            this.txtLives = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.TmrDog = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.AutoSize = true;
            this.PnlGame.BackColor = System.Drawing.Color.White;
            this.PnlGame.Location = new System.Drawing.Point(12, 12);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(1897, 864);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // TmrFrog
            // 
            this.TmrFrog.Enabled = true;
            this.TmrFrog.Interval = 120;
            this.TmrFrog.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(12, 886);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(345, 123);
            this.lblLives.TabIndex = 1;
            this.lblLives.Text = "Lives:";
            // 
            // txtLives
            // 
            this.txtLives.Enabled = false;
            this.txtLives.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLives.Location = new System.Drawing.Point(336, 882);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(100, 131);
            this.txtLives.TabIndex = 2;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(654, 886);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(362, 123);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score:";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtScore.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(982, 886);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(126, 123);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(1260, 886);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(370, 123);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(1606, 890);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 123);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "NUL";
            // 
            // TmrDog
            // 
            this.TmrDog.Enabled = true;
            this.TmrDog.Tick += new System.EventHandler(this.TmrDog_Tick_1);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1918, 1022);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtLives);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.PnlGame);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "GameWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrFrog;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.TextBox txtLives;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Timer TmrDog;
    }
}

