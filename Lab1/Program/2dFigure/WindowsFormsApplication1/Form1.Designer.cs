using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class Main
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DrawBtn = new System.Windows.Forms.Button();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.X_Lbl = new System.Windows.Forms.Label();
            this.Y_Lbl = new System.Windows.Forms.Label();
            this.ChooseColorBtn = new System.Windows.Forms.Button();
            this.A_X_TextBox = new System.Windows.Forms.NumericUpDown();
            this.A_Y_TextBox = new System.Windows.Forms.NumericUpDown();
            this.B_Y_TextBox = new System.Windows.Forms.NumericUpDown();
            this.B_X_TextBox = new System.Windows.Forms.NumericUpDown();
            this.D_Y_TextBox = new System.Windows.Forms.NumericUpDown();
            this.D_X_TextBox = new System.Windows.Forms.NumericUpDown();
            this.C_Y_TextBox = new System.Windows.Forms.NumericUpDown();
            this.C_X_TextBox = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.очиститиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.A_X_TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_Y_TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Y_TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_X_TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_Y_TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_X_TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_Y_TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_X_TextBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Перша вершина (А):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Друга вершина (B):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Третя вершина (С):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Четверта вершина (D):";
            // 
            // DrawBtn
            // 
            this.DrawBtn.Location = new System.Drawing.Point(129, 153);
            this.DrawBtn.Name = "DrawBtn";
            this.DrawBtn.Size = new System.Drawing.Size(106, 32);
            this.DrawBtn.TabIndex = 0;
            this.DrawBtn.Text = "Малювати";
            this.DrawBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawPanel.Location = new System.Drawing.Point(241, 27);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(522, 522);
            this.DrawPanel.TabIndex = 14;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            // 
            // X_Lbl
            // 
            this.X_Lbl.Location = new System.Drawing.Point(129, 23);
            this.X_Lbl.Name = "X_Lbl";
            this.X_Lbl.Size = new System.Drawing.Size(50, 20);
            this.X_Lbl.TabIndex = 15;
            this.X_Lbl.Text = "X";
            this.X_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Y_Lbl
            // 
            this.Y_Lbl.Location = new System.Drawing.Point(185, 23);
            this.Y_Lbl.Name = "Y_Lbl";
            this.Y_Lbl.Size = new System.Drawing.Size(50, 20);
            this.Y_Lbl.TabIndex = 16;
            this.Y_Lbl.Text = "Y";
            this.Y_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseColorBtn
            // 
            this.ChooseColorBtn.Location = new System.Drawing.Point(7, 153);
            this.ChooseColorBtn.Name = "ChooseColorBtn";
            this.ChooseColorBtn.Size = new System.Drawing.Size(104, 32);
            this.ChooseColorBtn.TabIndex = 13;
            this.ChooseColorBtn.Text = "Вибрати колір";
            this.ChooseColorBtn.UseVisualStyleBackColor = true;
            this.ChooseColorBtn.Click += new System.EventHandler(this.ChooseColorBtn_Click);
            // 
            // A_X_TextBox
            // 
            this.A_X_TextBox.Location = new System.Drawing.Point(129, 44);
            this.A_X_TextBox.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.A_X_TextBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.A_X_TextBox.Name = "A_X_TextBox";
            this.A_X_TextBox.Size = new System.Drawing.Size(50, 20);
            this.A_X_TextBox.TabIndex = 17;
            this.A_X_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A_X_TextBox.Enter += new System.EventHandler(this.Coordinates_Enter);
            this.A_X_TextBox.Leave += new System.EventHandler(this.Coordinates_Leave);
            // 
            // A_Y_TextBox
            // 
            this.A_Y_TextBox.Location = new System.Drawing.Point(185, 44);
            this.A_Y_TextBox.Name = "A_Y_TextBox";
            this.A_Y_TextBox.Size = new System.Drawing.Size(50, 20);
            this.A_Y_TextBox.TabIndex = 18;
            this.A_Y_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A_Y_TextBox.Enter += new System.EventHandler(this.Coordinates_Enter);
            this.A_Y_TextBox.Leave += new System.EventHandler(this.Coordinates_Leave);
            // 
            // B_Y_TextBox
            // 
            this.B_Y_TextBox.Location = new System.Drawing.Point(185, 70);
            this.B_Y_TextBox.Name = "B_Y_TextBox";
            this.B_Y_TextBox.Size = new System.Drawing.Size(50, 20);
            this.B_Y_TextBox.TabIndex = 20;
            this.B_Y_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.B_Y_TextBox.Enter += new System.EventHandler(this.Coordinates_Enter);
            this.B_Y_TextBox.Leave += new System.EventHandler(this.Coordinates_Leave);
            // 
            // B_X_TextBox
            // 
            this.B_X_TextBox.Location = new System.Drawing.Point(129, 70);
            this.B_X_TextBox.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.B_X_TextBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.B_X_TextBox.Name = "B_X_TextBox";
            this.B_X_TextBox.Size = new System.Drawing.Size(50, 20);
            this.B_X_TextBox.TabIndex = 19;
            this.B_X_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.B_X_TextBox.Enter += new System.EventHandler(this.Coordinates_Enter);
            this.B_X_TextBox.Leave += new System.EventHandler(this.Coordinates_Leave);
            // 
            // D_Y_TextBox
            // 
            this.D_Y_TextBox.Location = new System.Drawing.Point(185, 122);
            this.D_Y_TextBox.Name = "D_Y_TextBox";
            this.D_Y_TextBox.Size = new System.Drawing.Size(50, 20);
            this.D_Y_TextBox.TabIndex = 24;
            this.D_Y_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.D_Y_TextBox.Enter += new System.EventHandler(this.Coordinates_Enter);
            this.D_Y_TextBox.Leave += new System.EventHandler(this.Coordinates_Leave);
            // 
            // D_X_TextBox
            // 
            this.D_X_TextBox.Location = new System.Drawing.Point(129, 122);
            this.D_X_TextBox.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.D_X_TextBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.D_X_TextBox.Name = "D_X_TextBox";
            this.D_X_TextBox.Size = new System.Drawing.Size(50, 20);
            this.D_X_TextBox.TabIndex = 23;
            this.D_X_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.D_X_TextBox.Enter += new System.EventHandler(this.Coordinates_Enter);
            this.D_X_TextBox.Leave += new System.EventHandler(this.Coordinates_Leave);
            // 
            // C_Y_TextBox
            // 
            this.C_Y_TextBox.Location = new System.Drawing.Point(185, 96);
            this.C_Y_TextBox.Name = "C_Y_TextBox";
            this.C_Y_TextBox.Size = new System.Drawing.Size(50, 20);
            this.C_Y_TextBox.TabIndex = 22;
            this.C_Y_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.C_Y_TextBox.Enter += new System.EventHandler(this.Coordinates_Enter);
            this.C_Y_TextBox.Leave += new System.EventHandler(this.Coordinates_Leave);
            // 
            // C_X_TextBox
            // 
            this.C_X_TextBox.Location = new System.Drawing.Point(129, 96);
            this.C_X_TextBox.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.C_X_TextBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.C_X_TextBox.Name = "C_X_TextBox";
            this.C_X_TextBox.Size = new System.Drawing.Size(50, 20);
            this.C_X_TextBox.TabIndex = 21;
            this.C_X_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.C_X_TextBox.Enter += new System.EventHandler(this.Coordinates_Enter);
            this.C_X_TextBox.Leave += new System.EventHandler(this.Coordinates_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститиToolStripMenuItem,
            this.проПрограмуToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // очиститиToolStripMenuItem
            // 
            this.очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            this.очиститиToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.очиститиToolStripMenuItem.Text = "Очистити";
            this.очиститиToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 552);
            this.Controls.Add(this.D_Y_TextBox);
            this.Controls.Add(this.D_X_TextBox);
            this.Controls.Add(this.C_Y_TextBox);
            this.Controls.Add(this.C_X_TextBox);
            this.Controls.Add(this.B_Y_TextBox);
            this.Controls.Add(this.B_X_TextBox);
            this.Controls.Add(this.A_Y_TextBox);
            this.Controls.Add(this.A_X_TextBox);
            this.Controls.Add(this.ChooseColorBtn);
            this.Controls.Add(this.Y_Lbl);
            this.Controls.Add(this.X_Lbl);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2D Фігура";
            ((System.ComponentModel.ISupportInitialize)(this.A_X_TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_Y_TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Y_TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_X_TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_Y_TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_X_TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_Y_TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_X_TextBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DrawBtn;
        private System.Windows.Forms.Panel DrawPanel;
        private Label X_Lbl;
        private Label Y_Lbl;
        private Button ChooseColorBtn;
        private NumericUpDown A_X_TextBox;
        private NumericUpDown A_Y_TextBox;
        private NumericUpDown B_Y_TextBox;
        private NumericUpDown B_X_TextBox;
        private NumericUpDown D_Y_TextBox;
        private NumericUpDown D_X_TextBox;
        private NumericUpDown C_Y_TextBox;
        private NumericUpDown C_X_TextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem очиститиToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private ToolStripMenuItem вихідToolStripMenuItem;
    }
}

