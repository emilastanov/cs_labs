namespace bcit_lab4
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonExact = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxElapsedTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCountWords = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxThreads = new System.Windows.Forms.TextBox();
            this.labelThreading = new System.Windows.Forms.Label();
            this.buttonReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(57, 26);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(128, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Загрузить файл...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonExact
            // 
            this.buttonExact.Location = new System.Drawing.Point(311, 144);
            this.buttonExact.Name = "buttonExact";
            this.buttonExact.Size = new System.Drawing.Size(128, 20);
            this.buttonExact.TabIndex = 1;
            this.buttonExact.Text = "Поиск";
            this.buttonExact.UseVisualStyleBackColor = true;
            this.buttonExact.Click += new System.EventHandler(this.buttonExact_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(57, 144);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(239, 20);
            this.textBoxFind.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Время загрузки: ";
            // 
            // textBoxElapsedTime
            // 
            this.textBoxElapsedTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxElapsedTime.Enabled = false;
            this.textBoxElapsedTime.Location = new System.Drawing.Point(315, 29);
            this.textBoxElapsedTime.Name = "textBoxElapsedTime";
            this.textBoxElapsedTime.Size = new System.Drawing.Size(89, 20);
            this.textBoxElapsedTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Слов в файле:";
            // 
            // textBoxCountWords
            // 
            this.textBoxCountWords.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCountWords.Enabled = false;
            this.textBoxCountWords.Location = new System.Drawing.Point(315, 65);
            this.textBoxCountWords.Name = "textBoxCountWords";
            this.textBoxCountWords.Size = new System.Drawing.Size(89, 20);
            this.textBoxCountWords.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Время поиска: ";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(156, 218);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(0, 13);
            this.labelSearch.TabIndex = 8;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(48, 324);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(382, 225);
            this.listBoxResult.TabIndex = 9;
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(269, 179);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxDist.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Максимальное расстояние: ";
            // 
            // textBoxThreads
            // 
            this.textBoxThreads.Location = new System.Drawing.Point(269, 242);
            this.textBoxThreads.Name = "textBoxThreads";
            this.textBoxThreads.Size = new System.Drawing.Size(100, 20);
            this.textBoxThreads.TabIndex = 12;
            // 
            // labelThreading
            // 
            this.labelThreading.AutoSize = true;
            this.labelThreading.Location = new System.Drawing.Point(66, 245);
            this.labelThreading.Name = "labelThreading";
            this.labelThreading.Size = new System.Drawing.Size(110, 13);
            this.labelThreading.TabIndex = 13;
            this.labelThreading.Text = "Количество потоков";
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(138, 282);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(131, 30);
            this.buttonReport.TabIndex = 14;
            this.buttonReport.Text = "Сохранить отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 581);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.labelThreading);
            this.Controls.Add(this.textBoxThreads);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCountWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxElapsedTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.buttonExact);
            this.Controls.Add(this.buttonLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonExact;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxElapsedTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCountWords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxThreads;
        private System.Windows.Forms.Label labelThreading;
        private System.Windows.Forms.Button buttonReport;
    }
}

