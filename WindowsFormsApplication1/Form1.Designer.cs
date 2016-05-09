namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RollDice = new System.Windows.Forms.Button();
            this.p1XP = new System.Windows.Forms.Label();
            this.p2XP = new System.Windows.Forms.Label();
            this.p2HP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.SkipTurn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p1HP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RollDice
            // 
            this.RollDice.AutoSize = true;
            this.RollDice.BackColor = System.Drawing.SystemColors.Control;
            this.RollDice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RollDice.BackgroundImage")));
            this.RollDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RollDice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RollDice.Location = new System.Drawing.Point(41, 72);
            this.RollDice.Name = "RollDice";
            this.RollDice.Size = new System.Drawing.Size(266, 114);
            this.RollDice.TabIndex = 0;
            this.RollDice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.RollDice.UseVisualStyleBackColor = false;
            this.RollDice.Click += new System.EventHandler(this.Player1_Click);
            // 
            // p1XP
            // 
            this.p1XP.AutoSize = true;
            this.p1XP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1XP.Location = new System.Drawing.Point(179, 281);
            this.p1XP.Name = "p1XP";
            this.p1XP.Size = new System.Drawing.Size(36, 26);
            this.p1XP.TabIndex = 2;
            this.p1XP.Text = "__";
            this.p1XP.Click += new System.EventHandler(this.p1XP_Click);
            // 
            // p2XP
            // 
            this.p2XP.AutoSize = true;
            this.p2XP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p2XP.Location = new System.Drawing.Point(487, 281);
            this.p2XP.Name = "p2XP";
            this.p2XP.Size = new System.Drawing.Size(36, 26);
            this.p2XP.TabIndex = 4;
            this.p2XP.Text = "__";
            this.p2XP.Click += new System.EventHandler(this.p2XP_Click);
            // 
            // p2HP
            // 
            this.p2HP.AutoSize = true;
            this.p2HP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p2HP.Location = new System.Drawing.Point(487, 336);
            this.p2HP.Name = "p2HP";
            this.p2HP.Size = new System.Drawing.Size(36, 26);
            this.p2HP.TabIndex = 5;
            this.p2HP.Text = "__";
            this.p2HP.Click += new System.EventHandler(this.p2HP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(94, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(402, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player 2";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.turnLabel.Location = new System.Drawing.Point(189, 9);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(258, 46);
            this.turnLabel.TabIndex = 8;
            this.turnLabel.Text = "Turn: Player1";
            // 
            // SkipTurn
            // 
            this.SkipTurn.BackColor = System.Drawing.Color.Red;
            this.SkipTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SkipTurn.Location = new System.Drawing.Point(348, 72);
            this.SkipTurn.Name = "SkipTurn";
            this.SkipTurn.Size = new System.Drawing.Size(266, 114);
            this.SkipTurn.TabIndex = 9;
            this.SkipTurn.Text = "SkipTurn";
            this.SkipTurn.UseVisualStyleBackColor = false;
            this.SkipTurn.Click += new System.EventHandler(this.SkipTurn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(130, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "XP";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(438, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "XP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(97, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(405, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Health";
            // 
            // p1HP
            // 
            this.p1HP.AutoSize = true;
            this.p1HP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1HP.Location = new System.Drawing.Point(179, 336);
            this.p1HP.Name = "p1HP";
            this.p1HP.Size = new System.Drawing.Size(36, 26);
            this.p1HP.TabIndex = 3;
            this.p1HP.Text = "__";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(657, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SkipTurn);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2HP);
            this.Controls.Add(this.p2XP);
            this.Controls.Add(this.p1HP);
            this.Controls.Add(this.p1XP);
            this.Controls.Add(this.RollDice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RollDice;
        private System.Windows.Forms.Label p1XP;
        private System.Windows.Forms.Label p2XP;
        private System.Windows.Forms.Label p2HP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Button SkipTurn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label p1HP;
    }
}

