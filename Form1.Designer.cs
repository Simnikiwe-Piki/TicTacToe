namespace TicTacToe
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
            menuStrip1 = new MenuStrip();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(648, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(77, 20);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(40, 20);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3344421F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.334446F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3311157F));
            tableLayoutPanel1.Controls.Add(b9, 2, 2);
            tableLayoutPanel1.Controls.Add(b8, 1, 2);
            tableLayoutPanel1.Controls.Add(b7, 0, 2);
            tableLayoutPanel1.Controls.Add(b6, 2, 1);
            tableLayoutPanel1.Controls.Add(b5, 1, 1);
            tableLayoutPanel1.Controls.Add(b4, 0, 1);
            tableLayoutPanel1.Controls.Add(b3, 2, 0);
            tableLayoutPanel1.Controls.Add(b2, 1, 0);
            tableLayoutPanel1.Controls.Add(b1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3344421F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.334446F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3311157F));
            tableLayoutPanel1.Size = new Size(648, 474);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // b1
            // 
            b1.Dock = DockStyle.Fill;
            b1.FlatAppearance.BorderSize = 5;
            b1.FlatStyle = FlatStyle.Flat;
            b1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            b1.Location = new Point(3, 3);
            b1.Name = "b1";
            b1.Size = new Size(210, 152);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.Dock = DockStyle.Fill;
            b2.FlatAppearance.BorderSize = 5;
            b2.FlatStyle = FlatStyle.Flat;
            b2.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            b2.Location = new Point(219, 3);
            b2.Name = "b2";
            b2.Size = new Size(210, 152);
            b2.TabIndex = 1;
            b2.UseVisualStyleBackColor = true;
            b2.Click += b1_Click;
            // 
            // b3
            // 
            b3.Dock = DockStyle.Fill;
            b3.FlatAppearance.BorderSize = 5;
            b3.FlatStyle = FlatStyle.Flat;
            b3.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            b3.Location = new Point(435, 3);
            b3.Name = "b3";
            b3.Size = new Size(210, 152);
            b3.TabIndex = 2;
            b3.UseVisualStyleBackColor = true;
            b3.Click += b1_Click;
            // 
            // b4
            // 
            b4.Dock = DockStyle.Fill;
            b4.FlatAppearance.BorderSize = 5;
            b4.FlatStyle = FlatStyle.Flat;
            b4.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            b4.Location = new Point(3, 161);
            b4.Name = "b4";
            b4.Size = new Size(210, 152);
            b4.TabIndex = 3;
            b4.UseVisualStyleBackColor = true;
            b4.Click += b1_Click;
            // 
            // b5
            // 
            b5.Dock = DockStyle.Fill;
            b5.FlatAppearance.BorderSize = 5;
            b5.FlatStyle = FlatStyle.Flat;
            b5.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            b5.Location = new Point(219, 161);
            b5.Name = "b5";
            b5.Size = new Size(210, 152);
            b5.TabIndex = 4;
            b5.UseVisualStyleBackColor = true;
            b5.Click += b1_Click;
            // 
            // b6
            // 
            b6.Dock = DockStyle.Fill;
            b6.FlatAppearance.BorderSize = 5;
            b6.FlatStyle = FlatStyle.Flat;
            b6.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            b6.Location = new Point(435, 161);
            b6.Name = "b6";
            b6.Size = new Size(210, 152);
            b6.TabIndex = 5;
            b6.UseVisualStyleBackColor = true;
            b6.Click += b1_Click;
            // 
            // b7
            // 
            b7.Dock = DockStyle.Fill;
            b7.FlatAppearance.BorderSize = 5;
            b7.FlatStyle = FlatStyle.Flat;
            b7.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            b7.Location = new Point(3, 319);
            b7.Name = "b7";
            b7.Size = new Size(210, 152);
            b7.TabIndex = 6;
            b7.UseVisualStyleBackColor = true;
            b7.Click += b1_Click;
            // 
            // b8
            // 
            b8.Dock = DockStyle.Fill;
            b8.FlatAppearance.BorderSize = 5;
            b8.FlatStyle = FlatStyle.Flat;
            b8.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            b8.Location = new Point(219, 319);
            b8.Name = "b8";
            b8.Size = new Size(210, 152);
            b8.TabIndex = 7;
            b8.UseVisualStyleBackColor = true;
            b8.Click += b1_Click;
            // 
            // b9
            // 
            b9.Dock = DockStyle.Fill;
            b9.FlatAppearance.BorderSize = 5;
            b9.FlatStyle = FlatStyle.Flat;
            b9.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            b9.Location = new Point(435, 319);
            b9.Name = "b9";
            b9.Size = new Size(210, 152);
            b9.TabIndex = 8;
            b9.UseVisualStyleBackColor = true;
            b9.Click += b1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 498);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1000, 1000);
            MinimumSize = new Size(350, 500);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Button b1;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button b3;
        private Button b2;
    }
}