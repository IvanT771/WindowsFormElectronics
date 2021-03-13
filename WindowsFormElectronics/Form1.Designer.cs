
namespace WindowsFormElectronics
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMaterial = new System.Windows.Forms.Panel();
            this.buttonSi = new System.Windows.Forms.Button();
            this.buttonGe = new System.Windows.Forms.Button();
            this.buttonGaAs = new System.Windows.Forms.Button();
            this.buttonInP = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлыToolStripMenuItem
            // 
            this.файлыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлыToolStripMenuItem.Name = "файлыToolStripMenuItem";
            this.файлыToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.файлыToolStripMenuItem.Text = "Файлы";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "сохранить как";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "выход";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelLeft);
            this.panel3.Controls.Add(this.panelRight);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 437);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 392);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 45);
            this.panel4.TabIndex = 3;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Info;
            this.panelRight.Controls.Add(this.panel6);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(384, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(400, 392);
            this.panelRight.TabIndex = 4;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelLeft.Controls.Add(this.panelMaterial);
            this.panelLeft.Controls.Add(this.panel5);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(380, 392);
            this.panelLeft.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 30);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 30);
            this.panel6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходные данные";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Результат";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMaterial
            // 
            this.panelMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelMaterial.Controls.Add(this.buttonInP);
            this.panelMaterial.Controls.Add(this.buttonGaAs);
            this.panelMaterial.Controls.Add(this.buttonGe);
            this.panelMaterial.Controls.Add(this.buttonSi);
            this.panelMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaterial.Location = new System.Drawing.Point(0, 30);
            this.panelMaterial.Name = "panelMaterial";
            this.panelMaterial.Size = new System.Drawing.Size(380, 55);
            this.panelMaterial.TabIndex = 1;
            // 
            // buttonSi
            // 
            this.buttonSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSi.FlatAppearance.BorderSize = 0;
            this.buttonSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSi.Location = new System.Drawing.Point(12, 6);
            this.buttonSi.Name = "buttonSi";
            this.buttonSi.Size = new System.Drawing.Size(45, 45);
            this.buttonSi.TabIndex = 0;
            this.buttonSi.Text = "Si";
            this.buttonSi.UseVisualStyleBackColor = false;
            // 
            // buttonGe
            // 
            this.buttonGe.BackColor = System.Drawing.Color.Aqua;
            this.buttonGe.FlatAppearance.BorderSize = 0;
            this.buttonGe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGe.Location = new System.Drawing.Point(63, 5);
            this.buttonGe.Name = "buttonGe";
            this.buttonGe.Size = new System.Drawing.Size(52, 45);
            this.buttonGe.TabIndex = 1;
            this.buttonGe.Text = "Ge";
            this.buttonGe.UseVisualStyleBackColor = false;
            // 
            // buttonGaAs
            // 
            this.buttonGaAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonGaAs.FlatAppearance.BorderSize = 0;
            this.buttonGaAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGaAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGaAs.Location = new System.Drawing.Point(121, 5);
            this.buttonGaAs.Name = "buttonGaAs";
            this.buttonGaAs.Size = new System.Drawing.Size(59, 49);
            this.buttonGaAs.TabIndex = 2;
            this.buttonGaAs.Text = "GaAs";
            this.buttonGaAs.UseVisualStyleBackColor = false;
            // 
            // buttonInP
            // 
            this.buttonInP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonInP.FlatAppearance.BorderSize = 0;
            this.buttonInP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInP.Location = new System.Drawing.Point(186, 9);
            this.buttonInP.Name = "buttonInP";
            this.buttonInP.Size = new System.Drawing.Size(45, 45);
            this.buttonInP.TabIndex = 3;
            this.buttonInP.Text = "InP";
            this.buttonInP.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проводимость полупроводника";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelMaterial.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelMaterial;
        private System.Windows.Forms.Button buttonGe;
        private System.Windows.Forms.Button buttonSi;
        private System.Windows.Forms.Button buttonInP;
        private System.Windows.Forms.Button buttonGaAs;
    }
}

