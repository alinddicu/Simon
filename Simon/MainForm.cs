namespace Simon
{
    using Simon.Components;
    using Simon.Objects;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /* Description: 
     * 
     * Four colored buttons light up in a specific pattern. 
     * After displaying the pattern, the player must repeat the pattern by clicking the buttons in proper order. 
     * The pattern gets longer each time the player completes the pattern. 
     * If the player presses a wrong button, the game ends. 
     * 
     * http://inventwithpython.com/blog/2012/02/20/i-need-practice-programming-49-ideas-for-game-clones-to-code/
     * 
     */
    public partial class MainForm : Form
    {
        #region Components

        private SimonButton buttonRed;
        private SimonButton buttonBlue;
        private SimonButton buttonGreen;
        private SimonButton buttonYellow;

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;

        #endregion

        private readonly Game _game;

        public MainForm()
        {
            StartPosition= FormStartPosition.CenterScreen;
            InitializeComponent();

            buttonRed.OriginalBackColor = Color.Red;
            buttonBlue.OriginalBackColor = Color.Blue;
            buttonGreen.OriginalBackColor = Color.Green;
            buttonYellow.OriginalBackColor = Color.Yellow;

            _game = new Game(buttonRed, buttonBlue, buttonGreen, buttonYellow);
        }

        #region InitializeComponent

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRed = new Simon.Components.SimonButton();
            this.buttonBlue = new Simon.Components.SimonButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonGreen = new Simon.Components.SimonButton();
            this.buttonYellow = new Simon.Components.SimonButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonRed);
            this.flowLayoutPanel1.Controls.Add(this.buttonBlue);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 178);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(3, 3);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.OriginalBackColor = System.Drawing.Color.Empty;
            this.buttonRed.Size = new System.Drawing.Size(186, 175);
            this.buttonRed.TabIndex = 0;
            this.buttonRed.UseVisualStyleBackColor = false;
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(195, 3);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.OriginalBackColor = System.Drawing.Color.Empty;
            this.buttonBlue.Size = new System.Drawing.Size(186, 175);
            this.buttonBlue.TabIndex = 1;
            this.buttonBlue.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.buttonGreen);
            this.flowLayoutPanel2.Controls.Add(this.buttonYellow);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 184);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(384, 178);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Location = new System.Drawing.Point(3, 3);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.OriginalBackColor = System.Drawing.Color.Empty;
            this.buttonGreen.Size = new System.Drawing.Size(186, 175);
            this.buttonGreen.TabIndex = 2;
            this.buttonGreen.UseVisualStyleBackColor = false;
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Location = new System.Drawing.Point(195, 3);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.OriginalBackColor = System.Drawing.Color.Empty;
            this.buttonYellow.Size = new System.Drawing.Size(186, 175);
            this.buttonYellow.TabIndex = 3;
            this.buttonYellow.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Simon";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void MainForm_Shown(object sender, EventArgs e)
        {
            _game.Blink();
        }
    }
}
