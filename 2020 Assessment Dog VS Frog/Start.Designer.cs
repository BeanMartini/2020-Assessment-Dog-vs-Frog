namespace _2020_Assessment_Dog_VS_Frog
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEnter1 = new System.Windows.Forms.Label();
            this.lblEnter2 = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.txtEnterLives = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(23, -7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(679, 123);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dog VS Frog";
            // 
            // lblEnter1
            // 
            this.lblEnter1.AutoSize = true;
            this.lblEnter1.BackColor = System.Drawing.Color.Transparent;
            this.lblEnter1.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter1.ForeColor = System.Drawing.Color.White;
            this.lblEnter1.Location = new System.Drawing.Point(147, 221);
            this.lblEnter1.Name = "lblEnter1";
            this.lblEnter1.Size = new System.Drawing.Size(115, 45);
            this.lblEnter1.TabIndex = 1;
            this.lblEnter1.Text = "Lives";
            // 
            // lblEnter2
            // 
            this.lblEnter2.AutoSize = true;
            this.lblEnter2.BackColor = System.Drawing.Color.Transparent;
            this.lblEnter2.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter2.ForeColor = System.Drawing.Color.White;
            this.lblEnter2.Location = new System.Drawing.Point(477, 221);
            this.lblEnter2.Name = "lblEnter2";
            this.lblEnter2.Size = new System.Drawing.Size(124, 45);
            this.lblEnter2.TabIndex = 2;
            this.lblEnter2.Text = "Name";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.White;
            this.lblInstructions.Location = new System.Drawing.Point(90, 128);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(545, 100);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEnterName
            // 
            this.txtEnterName.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterName.Location = new System.Drawing.Point(494, 269);
            this.txtEnterName.MaxLength = 3;
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(91, 49);
            this.txtEnterName.TabIndex = 1;
            this.txtEnterName.TextChanged += new System.EventHandler(this.txtEnterName_TextChanged);
            // 
            // txtEnterLives
            // 
            this.txtEnterLives.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterLives.Location = new System.Drawing.Point(184, 269);
            this.txtEnterLives.MaxLength = 1;
            this.txtEnterLives.Name = "txtEnterLives";
            this.txtEnterLives.Size = new System.Drawing.Size(31, 49);
            this.txtEnterLives.TabIndex = 0;
            this.txtEnterLives.TextChanged += new System.EventHandler(this.txtEnterLives_TextChanged);
            this.txtEnterLives.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterLives_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(230, 344);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 31);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(413, 344);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 31);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 387);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtEnterLives);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblEnter2);
            this.Controls.Add(this.lblEnter1);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEnter1;
        private System.Windows.Forms.Label lblEnter2;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.TextBox txtEnterLives;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnQuit;
    }
}