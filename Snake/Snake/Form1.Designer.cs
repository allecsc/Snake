namespace Snake
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pause_panel = new System.Windows.Forms.Panel();
            this.pause_label = new System.Windows.Forms.Label();
            this.gameOver_panel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.gameOver_label = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.pause_panel.SuspendLayout();
            this.gameOver_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(300, 20);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 15);
            this.toolStripStatusLabel1.Text = "Score : ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 15);
            this.toolStripStatusLabel2.Text = "0";
            // 
            // pause_panel
            // 
            this.pause_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pause_panel.Controls.Add(this.pause_label);
            this.pause_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pause_panel.Location = new System.Drawing.Point(0, 0);
            this.pause_panel.Name = "pause_panel";
            this.pause_panel.Size = new System.Drawing.Size(300, 318);
            this.pause_panel.TabIndex = 1;
            this.pause_panel.Visible = false;
            // 
            // pause_label
            // 
            this.pause_label.AutoSize = true;
            this.pause_label.BackColor = System.Drawing.Color.Transparent;
            this.pause_label.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_label.Location = new System.Drawing.Point(29, 91);
            this.pause_label.Name = "pause_label";
            this.pause_label.Size = new System.Drawing.Size(241, 46);
            this.pause_label.TabIndex = 0;
            this.pause_label.Text = "Game Paused";
            this.pause_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOver_panel
            // 
            this.gameOver_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gameOver_panel.Controls.Add(this.exitButton);
            this.gameOver_panel.Controls.Add(this.restartButton);
            this.gameOver_panel.Controls.Add(this.gameOver_label);
            this.gameOver_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOver_panel.Location = new System.Drawing.Point(0, 0);
            this.gameOver_panel.Name = "gameOver_panel";
            this.gameOver_panel.Size = new System.Drawing.Size(300, 298);
            this.gameOver_panel.TabIndex = 2;
            this.gameOver_panel.Visible = false;
            this.gameOver_panel.VisibleChanged += new System.EventHandler(this.gameOver_panel_VisibleChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(162, 140);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(62, 140);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "&Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // gameOver_label
            // 
            this.gameOver_label.AutoSize = true;
            this.gameOver_label.BackColor = System.Drawing.Color.Transparent;
            this.gameOver_label.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver_label.Location = new System.Drawing.Point(54, 91);
            this.gameOver_label.Name = "gameOver_label";
            this.gameOver_label.Size = new System.Drawing.Size(194, 46);
            this.gameOver_label.TabIndex = 0;
            this.gameOver_label.Text = "Game Over";
            this.gameOver_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 318);
            this.Controls.Add(this.gameOver_panel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pause_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pause_panel.ResumeLayout(false);
            this.pause_panel.PerformLayout();
            this.gameOver_panel.ResumeLayout(false);
            this.gameOver_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel pause_panel;
        private System.Windows.Forms.Label pause_label;
        public System.Windows.Forms.Panel gameOver_panel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label gameOver_label;
    }
}

