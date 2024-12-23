namespace Oganesyan_OOPP_lab6
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.TextBox();
            this.release_year = new System.Windows.Forms.TextBox();
            this.publishing_house = new System.Windows.Forms.TextBox();
            this.in_stock = new System.Windows.Forms.TextBox();
            this.rating = new System.Windows.Forms.TextBox();
            this.link = new System.Windows.Forms.TextBox();
            this.loadfilebutton = new System.Windows.Forms.Button();
            this.savefilebutton = new System.Windows.Forms.Button();
            this.addebutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(23, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 404);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(470, 467);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(210, 23);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "Добавить книгу (обычную)";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(674, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(293, 22);
            this.title.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Год выпуска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Издательство";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "В наличии";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Рейтинг";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ссылка";
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(674, 87);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(293, 22);
            this.author.TabIndex = 11;
            // 
            // release_year
            // 
            this.release_year.Location = new System.Drawing.Point(674, 152);
            this.release_year.Name = "release_year";
            this.release_year.Size = new System.Drawing.Size(293, 22);
            this.release_year.TabIndex = 12;
            // 
            // publishing_house
            // 
            this.publishing_house.Location = new System.Drawing.Point(674, 221);
            this.publishing_house.Name = "publishing_house";
            this.publishing_house.Size = new System.Drawing.Size(293, 22);
            this.publishing_house.TabIndex = 13;
            // 
            // in_stock
            // 
            this.in_stock.Location = new System.Drawing.Point(674, 285);
            this.in_stock.Name = "in_stock";
            this.in_stock.Size = new System.Drawing.Size(293, 22);
            this.in_stock.TabIndex = 14;
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(674, 342);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(293, 22);
            this.rating.TabIndex = 15;
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(674, 403);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(293, 22);
            this.link.TabIndex = 16;
            // 
            // loadfilebutton
            // 
            this.loadfilebutton.Location = new System.Drawing.Point(23, 467);
            this.loadfilebutton.Name = "loadfilebutton";
            this.loadfilebutton.Size = new System.Drawing.Size(409, 23);
            this.loadfilebutton.TabIndex = 20;
            this.loadfilebutton.Text = "Загрузить данные из файла";
            this.loadfilebutton.UseVisualStyleBackColor = true;
            this.loadfilebutton.Click += new System.EventHandler(this.loadfilebutton_Click);
            // 
            // savefilebutton
            // 
            this.savefilebutton.Location = new System.Drawing.Point(23, 517);
            this.savefilebutton.Name = "savefilebutton";
            this.savefilebutton.Size = new System.Drawing.Size(409, 23);
            this.savefilebutton.TabIndex = 21;
            this.savefilebutton.Text = "Сохранить данные в файл";
            this.savefilebutton.UseVisualStyleBackColor = true;
            this.savefilebutton.Click += new System.EventHandler(this.savefilebutton_Click);
            // 
            // addebutton
            // 
            this.addebutton.Location = new System.Drawing.Point(470, 516);
            this.addebutton.Name = "addebutton";
            this.addebutton.Size = new System.Drawing.Size(210, 23);
            this.addebutton.TabIndex = 22;
            this.addebutton.Text = "Добавить электронную книгу";
            this.addebutton.UseVisualStyleBackColor = true;
            this.addebutton.Click += new System.EventHandler(this.addebutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(719, 516);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(108, 23);
            this.savebutton.TabIndex = 23;
            this.savebutton.Text = "Сохранить";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(859, 467);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(108, 23);
            this.deletebutton.TabIndex = 24;
            this.deletebutton.Text = "Удалить";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(859, 516);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(108, 23);
            this.cancelbutton.TabIndex = 25;
            this.cancelbutton.Text = "Отменить";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 570);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.addebutton);
            this.Controls.Add(this.savefilebutton);
            this.Controls.Add(this.loadfilebutton);
            this.Controls.Add(this.link);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.in_stock);
            this.Controls.Add(this.publishing_house);
            this.Controls.Add(this.release_year);
            this.Controls.Add(this.author);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox release_year;
        private System.Windows.Forms.TextBox publishing_house;
        private System.Windows.Forms.TextBox in_stock;
        private System.Windows.Forms.TextBox rating;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Button loadfilebutton;
        private System.Windows.Forms.Button savefilebutton;
        private System.Windows.Forms.Button addebutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button cancelbutton;
    }
}

