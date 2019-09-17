using System.Windows.Forms;

namespace Prova
{
    partial class frmPong
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(307, 224);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(657, 140);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Player 1 v Player 2\r\n       0 - 0";
            this.scoreLabel.Visible = false;
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPress.Location = new System.Drawing.Point(316, 172);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(640, 51);
            this.lblPress.TabIndex = 1;
            this.lblPress.Text = "Pressione espaço para começar";
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.Location = new System.Drawing.Point(316, 21);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(652, 51);
            this.lblPause.TabIndex = 2;
            this.lblPause.Text = "Pressione espaço para continuar";
            // 
            // jogoPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 677);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.lblPress);
            this.Controls.Add(this.scoreLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPong";
            this.Text = "PongGame";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PongForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pongForm_sobeBola);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JogoPong_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pongForm_desceBola);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label scoreLabel;
        private Label lblPress;
        private Label lblPause;
    }
}