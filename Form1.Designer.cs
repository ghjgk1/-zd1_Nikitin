namespace pr1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.name = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.profit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.addBoxButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.prices = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.getProductsListBox = new System.Windows.Forms.ListBox();
            this.boxListBox = new System.Windows.Forms.ListBox();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addSongButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.indexButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.overloadRemoveButton = new System.Windows.Forms.Button();
            this.clearButton1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 627);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.historyListBox);
            this.tabPage1.Controls.Add(this.boxListBox);
            this.tabPage1.Controls.Add(this.getProductsListBox);
            this.tabPage1.Controls.Add(this.prices);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.clearButton);
            this.tabPage1.Controls.Add(this.addBoxButton);
            this.tabPage1.Controls.Add(this.buyButton);
            this.tabPage1.Controls.Add(this.searchTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.profit);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.countNumericUpDown);
            this.tabPage1.Controls.Add(this.priceNumericUpDown);
            this.tabPage1.Controls.Add(this.count);
            this.tabPage1.Controls.Add(this.price);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Магазин";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clearButton1);
            this.tabPage2.Controls.Add(this.overloadRemoveButton);
            this.tabPage2.Controls.Add(this.removeButton);
            this.tabPage2.Controls.Add(this.startButton);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.indexButton);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lastButton);
            this.tabPage2.Controls.Add(this.nextButton);
            this.tabPage2.Controls.Add(this.filenameLabel);
            this.tabPage2.Controls.Add(this.authorLabel);
            this.tabPage2.Controls.Add(this.titleLabel);
            this.tabPage2.Controls.Add(this.filenameTextBox);
            this.tabPage2.Controls.Add(this.authorTextBox);
            this.tabPage2.Controls.Add(this.addSongButton);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.author);
            this.tabPage2.Controls.Add(this.titleTextBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Плейлист";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(34, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 16);
            this.name.TabIndex = 0;
            this.name.Text = "Название";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(36, 46);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(175, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(33, 81);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(40, 16);
            this.price.TabIndex = 2;
            this.price.Text = "Цена";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(142, 81);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(51, 16);
            this.count.TabIndex = 3;
            this.count.Text = "Кол-во";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Location = new System.Drawing.Point(36, 100);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(75, 22);
            this.priceNumericUpDown.TabIndex = 4;
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Location = new System.Drawing.Point(145, 100);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(75, 22);
            this.countNumericUpDown.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(37, 140);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(183, 30);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Добавить товар";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Прибыль магазина";
            // 
            // profit
            // 
            this.profit.AutoSize = true;
            this.profit.Location = new System.Drawing.Point(537, 211);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(14, 16);
            this.profit.TabIndex = 9;
            this.profit.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Найти по названию";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(540, 259);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(175, 22);
            this.searchTextBox.TabIndex = 11;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(681, 287);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(94, 60);
            this.buyButton.TabIndex = 14;
            this.buyButton.Text = "Купить продукты";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // addBoxButton
            // 
            this.addBoxButton.Location = new System.Drawing.Point(479, 287);
            this.addBoxButton.Name = "addBoxButton";
            this.addBoxButton.Size = new System.Drawing.Size(94, 60);
            this.addBoxButton.TabIndex = 15;
            this.addBoxButton.Text = "Добавить товар в корину";
            this.addBoxButton.UseVisualStyleBackColor = true;
            this.addBoxButton.Click += new System.EventHandler(this.addBoxButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(579, 287);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 60);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Очистить корзину";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Корзина";
            // 
            // prices
            // 
            this.prices.AutoSize = true;
            this.prices.Location = new System.Drawing.Point(490, 409);
            this.prices.Name = "prices";
            this.prices.Size = new System.Drawing.Size(14, 16);
            this.prices.TabIndex = 20;
            this.prices.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "К оплате";
            // 
            // getProductsListBox
            // 
            this.getProductsListBox.FormattingEnabled = true;
            this.getProductsListBox.ItemHeight = 16;
            this.getProductsListBox.Location = new System.Drawing.Point(36, 186);
            this.getProductsListBox.Name = "getProductsListBox";
            this.getProductsListBox.Size = new System.Drawing.Size(413, 164);
            this.getProductsListBox.TabIndex = 21;
            // 
            // boxListBox
            // 
            this.boxListBox.FormattingEnabled = true;
            this.boxListBox.ItemHeight = 16;
            this.boxListBox.Location = new System.Drawing.Point(36, 386);
            this.boxListBox.Name = "boxListBox";
            this.boxListBox.Size = new System.Drawing.Size(413, 164);
            this.boxListBox.TabIndex = 22;
            // 
            // historyListBox
            // 
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 16;
            this.historyListBox.Location = new System.Drawing.Point(388, 37);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(387, 100);
            this.historyListBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "История покупок";
            // 
            // addSongButton
            // 
            this.addSongButton.Location = new System.Drawing.Point(24, 198);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(183, 30);
            this.addSongButton.TabIndex = 13;
            this.addSongButton.Text = "Добавить песню";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Путь до файла с мелодией";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(21, 75);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(47, 16);
            this.author.TabIndex = 9;
            this.author.Text = "Автор";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(24, 40);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(175, 22);
            this.titleTextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Название";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(24, 94);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(175, 22);
            this.authorTextBox.TabIndex = 14;
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Location = new System.Drawing.Point(24, 155);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(175, 22);
            this.filenameTextBox.TabIndex = 15;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(505, 46);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 25);
            this.titleLabel.TabIndex = 16;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(505, 75);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(0, 25);
            this.authorLabel.TabIndex = 17;
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filenameLabel.Location = new System.Drawing.Point(505, 103);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(0, 25);
            this.filenameLabel.TabIndex = 18;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(565, 139);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(68, 55);
            this.nextButton.TabIndex = 19;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastButton.Location = new System.Drawing.Point(414, 139);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(68, 55);
            this.lastButton.TabIndex = 20;
            this.lastButton.Text = "<";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Введите индекс";
            // 
            // indexButton
            // 
            this.indexButton.Location = new System.Drawing.Point(250, 103);
            this.indexButton.Name = "indexButton";
            this.indexButton.Size = new System.Drawing.Size(124, 30);
            this.indexButton.TabIndex = 22;
            this.indexButton.Text = "Перейти";
            this.indexButton.UseVisualStyleBackColor = true;
            this.indexButton.Click += new System.EventHandler(this.indexButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(250, 75);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 23;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(461, 214);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(124, 30);
            this.startButton.TabIndex = 24;
            this.startButton.Text = "Начало";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(250, 139);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(124, 30);
            this.removeButton.TabIndex = 25;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // overloadRemoveButton
            // 
            this.overloadRemoveButton.Location = new System.Drawing.Point(25, 234);
            this.overloadRemoveButton.Name = "overloadRemoveButton";
            this.overloadRemoveButton.Size = new System.Drawing.Size(182, 30);
            this.overloadRemoveButton.TabIndex = 26;
            this.overloadRemoveButton.Text = "Удалить песню";
            this.overloadRemoveButton.UseVisualStyleBackColor = true;
            this.overloadRemoveButton.Click += new System.EventHandler(this.overloadRemoveButton_Click);
            // 
            // clearButton1
            // 
            this.clearButton1.Location = new System.Drawing.Point(461, 250);
            this.clearButton1.Name = "clearButton1";
            this.clearButton1.Size = new System.Drawing.Size(124, 30);
            this.clearButton1.TabIndex = 27;
            this.clearButton1.Text = "Очистить";
            this.clearButton1.UseVisualStyleBackColor = true;
            this.clearButton1.Click += new System.EventHandler(this.clearButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label profit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addBoxButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label prices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox getProductsListBox;
        private System.Windows.Forms.ListBox boxListBox;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button indexButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button overloadRemoveButton;
        private System.Windows.Forms.Button clearButton1;
    }
}

