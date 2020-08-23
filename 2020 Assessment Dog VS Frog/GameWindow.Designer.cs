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
            this.btnStart = new System.Windows.Forms.Button();
            this.TmrFrog = new System.Windows.Forms.Timer(this.components);
            this.lblLives = new System.Windows.Forms.Label();
            this.txtLives = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.TmrDog = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TmrTime = new System.Windows.Forms.Timer(this.components);
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.AutoSize = true;
            this.PnlGame.BackColor = System.Drawing.Color.White;
            this.PnlGame.Controls.Add(this.btnStart);
            this.PnlGame.Location = new System.Drawing.Point(12, 12);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(1897, 864);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(207, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // TmrFrog
            // 
            this.TmrFrog.Interval = 120;
            this.TmrFrog.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(-9, 886);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(345, 123);
            this.lblLives.TabIndex = 1;
            this.lblLives.Text = "Lives:";
            // 
            // txtLives
            // 
            this.txtLives.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLives.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLives.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLives.ForeColor = System.Drawing.Color.White;
            this.txtLives.Location = new System.Drawing.Point(315, 890);
            this.txtLives.Name = "txtLives";
            this.txtLives.ReadOnly = true;
            this.txtLives.Size = new System.Drawing.Size(100, 124);
            this.txtLives.TabIndex = 2;
            this.txtLives.Text = "5";
            this.txtLives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(474, 890);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(339, 123);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time:";
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblElapsed.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsed.ForeColor = System.Drawing.Color.White;
            this.lblElapsed.Location = new System.Drawing.Point(780, 890);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(484, 123);
            this.lblElapsed.TabIndex = 4;
            this.lblElapsed.Text = "00:00:0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(1296, 890);
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
            this.txtName.Location = new System.Drawing.Point(1633, 890);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 123);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "NUL";
            // 
            // TmrDog
            // 
            this.TmrDog.Interval = 50;
            this.TmrDog.Tick += new System.EventHandler(this.TmrDog_Tick_1);
            // 
            // TmrTime
            // 
            this.TmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1918, 1022);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblElapsed);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtLives);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.PnlGame);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "GameWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            this.PnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrFrog;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Timer TmrDog;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer TmrTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtLives;
    }
}

