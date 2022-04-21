﻿
namespace UI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ribbonDataGridView = new System.Windows.Forms.DataGridView();
            this.commandDataGridView = new System.Windows.Forms.DataGridView();
            this.alphabetTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.commandLenghtNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.leftBorderRibbonNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.changeRibbonLenghtButton = new System.Windows.Forms.Button();
            this.changeCommandLenghtButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rightBorderRibbonNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.startCellNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandLenghtNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorderRibbonNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBorderRibbonNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startCellNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Команды";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Алфавит";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Лента";
            // 
            // ribbonDataGridView
            // 
            this.ribbonDataGridView.AllowUserToAddRows = false;
            this.ribbonDataGridView.AllowUserToDeleteRows = false;
            this.ribbonDataGridView.AllowUserToResizeRows = false;
            this.ribbonDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ribbonDataGridView.Location = new System.Drawing.Point(12, 75);
            this.ribbonDataGridView.Name = "ribbonDataGridView";
            this.ribbonDataGridView.RowTemplate.Height = 25;
            this.ribbonDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ribbonDataGridView.Size = new System.Drawing.Size(776, 67);
            this.ribbonDataGridView.TabIndex = 3;
            this.ribbonDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ribbonDataGridView_CellValueChanged);
            // 
            // commandDataGridView
            // 
            this.commandDataGridView.AllowUserToAddRows = false;
            this.commandDataGridView.AllowUserToDeleteRows = false;
            this.commandDataGridView.AllowUserToResizeColumns = false;
            this.commandDataGridView.AllowUserToResizeRows = false;
            this.commandDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commandDataGridView.Location = new System.Drawing.Point(12, 258);
            this.commandDataGridView.Name = "commandDataGridView";
            this.commandDataGridView.RowTemplate.Height = 25;
            this.commandDataGridView.Size = new System.Drawing.Size(776, 180);
            this.commandDataGridView.TabIndex = 4;
            this.commandDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.commandDataGridView_CellValueChanged);
            // 
            // alphabetTextBox
            // 
            this.alphabetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alphabetTextBox.Location = new System.Drawing.Point(12, 193);
            this.alphabetTextBox.Name = "alphabetTextBox";
            this.alphabetTextBox.Size = new System.Drawing.Size(776, 23);
            this.alphabetTextBox.TabIndex = 5;
            this.alphabetTextBox.TextChanged += new System.EventHandler(this.AlphabetTextBox_TextChanged);
            this.alphabetTextBox.Leave += new System.EventHandler(this.AlphabetTextBox_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.stepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.startToolStripMenuItem.Text = "Запустить";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.stopToolStripMenuItem.Text = "Остановить";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.stepToolStripMenuItem.Text = "Шаг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Скорость:";
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Location = new System.Drawing.Point(80, 24);
            this.speedTrackBar.Maximum = -1;
            this.speedTrackBar.Minimum = -5;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(212, 45);
            this.speedTrackBar.TabIndex = 13;
            this.speedTrackBar.Value = -5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "%";
            // 
            // commandLenghtNumericUpDown
            // 
            this.commandLenghtNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commandLenghtNumericUpDown.Location = new System.Drawing.Point(645, 229);
            this.commandLenghtNumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.commandLenghtNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.commandLenghtNumericUpDown.Name = "commandLenghtNumericUpDown";
            this.commandLenghtNumericUpDown.Size = new System.Drawing.Size(68, 23);
            this.commandLenghtNumericUpDown.TabIndex = 17;
            this.commandLenghtNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // leftBorderRibbonNumericUpDown
            // 
            this.leftBorderRibbonNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leftBorderRibbonNumericUpDown.Location = new System.Drawing.Point(575, 46);
            this.leftBorderRibbonNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.leftBorderRibbonNumericUpDown.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.leftBorderRibbonNumericUpDown.Name = "leftBorderRibbonNumericUpDown";
            this.leftBorderRibbonNumericUpDown.Size = new System.Drawing.Size(51, 23);
            this.leftBorderRibbonNumericUpDown.TabIndex = 18;
            // 
            // changeRibbonLenghtButton
            // 
            this.changeRibbonLenghtButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeRibbonLenghtButton.Location = new System.Drawing.Point(719, 47);
            this.changeRibbonLenghtButton.Name = "changeRibbonLenghtButton";
            this.changeRibbonLenghtButton.Size = new System.Drawing.Size(69, 23);
            this.changeRibbonLenghtButton.TabIndex = 19;
            this.changeRibbonLenghtButton.Text = "Задать";
            this.changeRibbonLenghtButton.UseVisualStyleBackColor = true;
            this.changeRibbonLenghtButton.Click += new System.EventHandler(this.ChangeRibbonLenghtButton_Click);
            // 
            // changeCommandLenghtButton
            // 
            this.changeCommandLenghtButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeCommandLenghtButton.Location = new System.Drawing.Point(719, 229);
            this.changeCommandLenghtButton.Name = "changeCommandLenghtButton";
            this.changeCommandLenghtButton.Size = new System.Drawing.Size(69, 23);
            this.changeCommandLenghtButton.TabIndex = 20;
            this.changeCommandLenghtButton.Text = "Изменить";
            this.changeCommandLenghtButton.UseVisualStyleBackColor = true;
            this.changeCommandLenghtButton.Click += new System.EventHandler(this.ChangeCommandLenghtButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "лента от";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "до";
            // 
            // rightBorderRibbonNumericUpDown
            // 
            this.rightBorderRibbonNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightBorderRibbonNumericUpDown.Location = new System.Drawing.Point(657, 46);
            this.rightBorderRibbonNumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.rightBorderRibbonNumericUpDown.Name = "rightBorderRibbonNumericUpDown";
            this.rightBorderRibbonNumericUpDown.Size = new System.Drawing.Size(51, 23);
            this.rightBorderRibbonNumericUpDown.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Кол-во";
            // 
            // startCellNumericUpDown
            // 
            this.startCellNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startCellNumericUpDown.Location = new System.Drawing.Point(459, 46);
            this.startCellNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.startCellNumericUpDown.Name = "startCellNumericUpDown";
            this.startCellNumericUpDown.Size = new System.Drawing.Size(51, 23);
            this.startCellNumericUpDown.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "начать с";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.startCellNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rightBorderRibbonNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.changeCommandLenghtButton);
            this.Controls.Add(this.changeRibbonLenghtButton);
            this.Controls.Add(this.leftBorderRibbonNumericUpDown);
            this.Controls.Add(this.commandLenghtNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.speedTrackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alphabetTextBox);
            this.Controls.Add(this.commandDataGridView);
            this.Controls.Add(this.ribbonDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandLenghtNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorderRibbonNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBorderRibbonNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startCellNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ribbonDataGridView;
        private System.Windows.Forms.DataGridView commandDataGridView;
        private System.Windows.Forms.TextBox alphabetTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown commandLenghtNumericUpDown;
        private System.Windows.Forms.NumericUpDown leftBorderRibbonNumericUpDown;
        private System.Windows.Forms.Button changeRibbonLenghtButton;
        private System.Windows.Forms.Button changeCommandLenghtButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown rightBorderRibbonNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown startCellNumericUpDown;
        private System.Windows.Forms.Label label9;
    }
}

