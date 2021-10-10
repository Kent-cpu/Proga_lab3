
namespace Prog_lab_3
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculateBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.nextMinPointBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.backMinPointBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFieldBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomBorderField = new System.Windows.Forms.TextBox();
            this.topBorderField = new System.Windows.Forms.TextBox();
            this.accuracyField = new System.Windows.Forms.TextBox();
            this.formulaField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.answerField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateBtn,
            this.nextMinPointBtn,
            this.backMinPointBtn,
            this.clearFieldBtn,
            this.exitBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(98, 24);
            this.calculateBtn.Text = "Рассчитать";
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // nextMinPointBtn
            // 
            this.nextMinPointBtn.Enabled = false;
            this.nextMinPointBtn.Name = "nextMinPointBtn";
            this.nextMinPointBtn.Size = new System.Drawing.Size(74, 24);
            this.nextMinPointBtn.Text = "Вперед";
            this.nextMinPointBtn.Click += new System.EventHandler(this.nextMinPointBtn_Click);
            // 
            // backMinPointBtn
            // 
            this.backMinPointBtn.Enabled = false;
            this.backMinPointBtn.Name = "backMinPointBtn";
            this.backMinPointBtn.Size = new System.Drawing.Size(65, 24);
            this.backMinPointBtn.Text = "Назад";
            this.backMinPointBtn.Click += new System.EventHandler(this.backMinPointBtn_Click);
            // 
            // clearFieldBtn
            // 
            this.clearFieldBtn.Enabled = false;
            this.clearFieldBtn.Name = "clearFieldBtn";
            this.clearFieldBtn.Size = new System.Drawing.Size(87, 24);
            this.clearFieldBtn.Text = "Очистить";
            this.clearFieldBtn.Click += new System.EventHandler(this.clearFieldBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(67, 24);
            this.exitBtn.Text = "Выход";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // bottomBorderField
            // 
            this.bottomBorderField.Location = new System.Drawing.Point(52, 66);
            this.bottomBorderField.Name = "bottomBorderField";
            this.bottomBorderField.Size = new System.Drawing.Size(100, 22);
            this.bottomBorderField.TabIndex = 1;
            // 
            // topBorderField
            // 
            this.topBorderField.Location = new System.Drawing.Point(219, 66);
            this.topBorderField.Name = "topBorderField";
            this.topBorderField.Size = new System.Drawing.Size(100, 22);
            this.topBorderField.TabIndex = 2;
            // 
            // accuracyField
            // 
            this.accuracyField.Location = new System.Drawing.Point(381, 66);
            this.accuracyField.Name = "accuracyField";
            this.accuracyField.Size = new System.Drawing.Size(100, 22);
            this.accuracyField.TabIndex = 3;
            // 
            // formulaField
            // 
            this.formulaField.Location = new System.Drawing.Point(534, 66);
            this.formulaField.Name = "formulaField";
            this.formulaField.Size = new System.Drawing.Size(144, 22);
            this.formulaField.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "e";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "f(x)";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(31, 175);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(685, 463);
            this.zedGraphControl1.TabIndex = 9;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // answerField
            // 
            this.answerField.Location = new System.Drawing.Point(52, 131);
            this.answerField.Name = "answerField";
            this.answerField.Size = new System.Drawing.Size(192, 22);
            this.answerField.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Точка минимума";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 677);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.answerField);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formulaField);
            this.Controls.Add(this.accuracyField);
            this.Controls.Add(this.topBorderField);
            this.Controls.Add(this.bottomBorderField);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculateBtn;
        private System.Windows.Forms.ToolStripMenuItem nextMinPointBtn;
        private System.Windows.Forms.ToolStripMenuItem backMinPointBtn;
        private System.Windows.Forms.ToolStripMenuItem clearFieldBtn;
        private System.Windows.Forms.ToolStripMenuItem exitBtn;
        private System.Windows.Forms.TextBox bottomBorderField;
        private System.Windows.Forms.TextBox topBorderField;
        private System.Windows.Forms.TextBox accuracyField;
        private System.Windows.Forms.TextBox formulaField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TextBox answerField;
        private System.Windows.Forms.Label label5;
    }
}

