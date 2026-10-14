namespace Blackjack.GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            player_score = new Label();
            dealer_score = new Label();
            P_score = new Label();
            D_score = new Label();
            P_hand = new Label();
            D_hand = new Label();
            Hit_button = new Button();
            Stay_button = new Button();
            Result = new Label();
            NG_button = new Button();
            SuspendLayout();
            // 
            // player_score
            // 
            player_score.AutoSize = true;
            player_score.Font = new Font("Segoe UI", 20F);
            player_score.Location = new Point(12, 9);
            player_score.Name = "player_score";
            player_score.Size = new Size(139, 37);
            player_score.TabIndex = 0;
            player_score.Text = "your score";
            // 
            // dealer_score
            // 
            dealer_score.AutoSize = true;
            dealer_score.Font = new Font("Segoe UI", 20F);
            dealer_score.Location = new Point(1092, 9);
            dealer_score.Name = "dealer_score";
            dealer_score.Size = new Size(160, 37);
            dealer_score.TabIndex = 1;
            dealer_score.Text = "dealer score";
            // 
            // P_score
            // 
            P_score.AutoSize = true;
            P_score.Font = new Font("Segoe UI", 30F);
            P_score.Location = new Point(21, 46);
            P_score.Name = "P_score";
            P_score.Size = new Size(130, 54);
            P_score.TabIndex = 3;
            P_score.Text = "label1";
            // 
            // D_score
            // 
            D_score.AutoSize = true;
            D_score.Font = new Font("Segoe UI", 30F);
            D_score.Location = new Point(1092, 46);
            D_score.Name = "D_score";
            D_score.Size = new Size(77, 54);
            D_score.TabIndex = 4;
            D_score.Text = "???";
            // 
            // P_hand
            // 
            P_hand.AutoSize = true;
            P_hand.Font = new Font("Segoe UI", 24F);
            P_hand.Location = new Point(145, 144);
            P_hand.Name = "P_hand";
            P_hand.Size = new Size(177, 45);
            P_hand.TabIndex = 5;
            P_hand.Text = "playerhand";
            // 
            // D_hand
            // 
            D_hand.AutoSize = true;
            D_hand.Font = new Font("Segoe UI", 24F);
            D_hand.Location = new Point(907, 144);
            D_hand.Name = "D_hand";
            D_hand.Size = new Size(179, 45);
            D_hand.TabIndex = 6;
            D_hand.Text = "dealerhand\r\n";
            // 
            // Hit_button
            // 
            Hit_button.Cursor = Cursors.Hand;
            Hit_button.Font = new Font("Segoe UI", 30F);
            Hit_button.Location = new Point(393, 448);
            Hit_button.Name = "Hit_button";
            Hit_button.Size = new Size(192, 83);
            Hit_button.TabIndex = 7;
            Hit_button.Text = "Hit";
            Hit_button.UseVisualStyleBackColor = true;
            Hit_button.Click += Hit_button_Click;
            // 
            // Stay_button
            // 
            Stay_button.Cursor = Cursors.Hand;
            Stay_button.Font = new Font("Segoe UI", 30F);
            Stay_button.Location = new Point(672, 448);
            Stay_button.Name = "Stay_button";
            Stay_button.Size = new Size(192, 83);
            Stay_button.TabIndex = 8;
            Stay_button.Text = "Stay";
            Stay_button.UseVisualStyleBackColor = true;
            Stay_button.Click += Stay_button_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Segoe UI", 40F);
            Result.Location = new Point(498, 76);
            Result.Name = "Result";
            Result.Size = new Size(185, 72);
            Result.TabIndex = 9;
            Result.Text = "results";
            // 
            // NG_button
            // 
            NG_button.Font = new Font("Segoe UI", 40F);
            NG_button.Location = new Point(415, 271);
            NG_button.Name = "NG_button";
            NG_button.Size = new Size(409, 144);
            NG_button.TabIndex = 10;
            NG_button.Text = "Új játék";
            NG_button.UseVisualStyleBackColor = true;
            NG_button.Visible = false;
            NG_button.Click += Button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(NG_button);
            Controls.Add(Result);
            Controls.Add(Stay_button);
            Controls.Add(Hit_button);
            Controls.Add(D_hand);
            Controls.Add(P_hand);
            Controls.Add(D_score);
            Controls.Add(P_score);
            Controls.Add(dealer_score);
            Controls.Add(player_score);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label player_score;
        private Label dealer_score;
        private Label P_score;
        private Label D_score;
        private Label P_hand;
        private Label D_hand;
        private Button Hit_button;
        private Button Stay_button;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label Result;
        private Button NG_button;
    }
}
