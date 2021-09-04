
namespace Goods_Catalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryCreate_item = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCategory_item = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCategory_item = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProducers_item = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProducers_item = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProducers_item = new System.Windows.Forms.ToolStripMenuItem();
            this.createProducts_item = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProduct_item = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProduct_item = new System.Windows.Forms.ToolStripMenuItem();
            this.author_button = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_filters = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.category_comboBox = new System.Windows.Forms.ComboBox();
            this.manufacturer_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.select_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inStock_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.order_button = new System.Windows.Forms.Button();
            this.Goods_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exit_item = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_filters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.producersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(788, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit_item});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.programmToolStripMenuItem.Text = "&Programm";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryCreate_item,
            this.updateCategory_item,
            this.deleteCategory_item});
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.categoriesToolStripMenuItem.Text = "&Categories";
            // 
            // producersToolStripMenuItem
            // 
            this.producersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProducers_item,
            this.updateProducers_item,
            this.deleteProducers_item});
            this.producersToolStripMenuItem.Name = "producersToolStripMenuItem";
            this.producersToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.producersToolStripMenuItem.Text = "&Producers";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProducts_item,
            this.updateProduct_item,
            this.deleteProduct_item});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.productsToolStripMenuItem.Text = "&Products";
            // 
            // categoryCreate_item
            // 
            this.categoryCreate_item.Name = "categoryCreate_item";
            this.categoryCreate_item.Size = new System.Drawing.Size(224, 26);
            this.categoryCreate_item.Text = "&Create category";
            // 
            // updateCategory_item
            // 
            this.updateCategory_item.Name = "updateCategory_item";
            this.updateCategory_item.Size = new System.Drawing.Size(224, 26);
            this.updateCategory_item.Text = "&Update category";
            // 
            // deleteCategory_item
            // 
            this.deleteCategory_item.Name = "deleteCategory_item";
            this.deleteCategory_item.Size = new System.Drawing.Size(224, 26);
            this.deleteCategory_item.Text = "&Delete category";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.author_button});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // createProducers_item
            // 
            this.createProducers_item.Name = "createProducers_item";
            this.createProducers_item.Size = new System.Drawing.Size(224, 26);
            this.createProducers_item.Text = "&Create producer";
            // 
            // updateProducers_item
            // 
            this.updateProducers_item.Name = "updateProducers_item";
            this.updateProducers_item.Size = new System.Drawing.Size(224, 26);
            this.updateProducers_item.Text = "&Update producer";
            // 
            // deleteProducers_item
            // 
            this.deleteProducers_item.Name = "deleteProducers_item";
            this.deleteProducers_item.Size = new System.Drawing.Size(224, 26);
            this.deleteProducers_item.Text = "&Delete producer";
            // 
            // createProducts_item
            // 
            this.createProducts_item.Name = "createProducts_item";
            this.createProducts_item.Size = new System.Drawing.Size(224, 26);
            this.createProducts_item.Text = "&Create product";
            // 
            // updateProduct_item
            // 
            this.updateProduct_item.Name = "updateProduct_item";
            this.updateProduct_item.Size = new System.Drawing.Size(224, 26);
            this.updateProduct_item.Text = "&Update product";
            // 
            // deleteProduct_item
            // 
            this.deleteProduct_item.Name = "deleteProduct_item";
            this.deleteProduct_item.Size = new System.Drawing.Size(224, 26);
            this.deleteProduct_item.Text = "&Delete product";
            // 
            // author_button
            // 
            this.author_button.Name = "author_button";
            this.author_button.Size = new System.Drawing.Size(224, 26);
            this.author_button.Text = "&Author";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Goods_Catalog.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(311, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Goods control system";
            // 
            // groupBox_filters
            // 
            this.groupBox_filters.Controls.Add(this.select_button);
            this.groupBox_filters.Controls.Add(this.manufacturer_comboBox);
            this.groupBox_filters.Controls.Add(this.label3);
            this.groupBox_filters.Controls.Add(this.category_comboBox);
            this.groupBox_filters.Controls.Add(this.label2);
            this.groupBox_filters.Location = new System.Drawing.Point(0, 203);
            this.groupBox_filters.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox_filters.Name = "groupBox_filters";
            this.groupBox_filters.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox_filters.Size = new System.Drawing.Size(788, 94);
            this.groupBox_filters.TabIndex = 4;
            this.groupBox_filters.TabStop = false;
            this.groupBox_filters.Text = "Filters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category:";
            // 
            // category_comboBox
            // 
            this.category_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category_comboBox.FormattingEnabled = true;
            this.category_comboBox.Location = new System.Drawing.Point(135, 36);
            this.category_comboBox.Name = "category_comboBox";
            this.category_comboBox.Size = new System.Drawing.Size(145, 33);
            this.category_comboBox.TabIndex = 1;
            // 
            // manufacturer_comboBox
            // 
            this.manufacturer_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturer_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturer_comboBox.FormattingEnabled = true;
            this.manufacturer_comboBox.Location = new System.Drawing.Point(469, 36);
            this.manufacturer_comboBox.Name = "manufacturer_comboBox";
            this.manufacturer_comboBox.Size = new System.Drawing.Size(145, 33);
            this.manufacturer_comboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(305, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturer:";
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(652, 35);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(109, 34);
            this.select_button.TabIndex = 4;
            this.select_button.Text = "Select";
            this.select_button.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Goods_list);
            this.groupBox1.Location = new System.Drawing.Point(0, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 239);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Goods list";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.order_button);
            this.groupBox2.Controls.Add(this.inStock_textBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.price_textBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.name_textBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 542);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 121);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(8, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textBox.Location = new System.Drawing.Point(98, 34);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(100, 30);
            this.name_textBox.TabIndex = 1;
            // 
            // price_textBox
            // 
            this.price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_textBox.Location = new System.Drawing.Point(382, 35);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(100, 30);
            this.price_textBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(292, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price:";
            // 
            // inStock_textBox
            // 
            this.inStock_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inStock_textBox.Location = new System.Drawing.Point(640, 34);
            this.inStock_textBox.Name = "inStock_textBox";
            this.inStock_textBox.Size = new System.Drawing.Size(100, 30);
            this.inStock_textBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(534, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "In stock:";
            // 
            // order_button
            // 
            this.order_button.Location = new System.Drawing.Point(316, 71);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(144, 38);
            this.order_button.TabIndex = 6;
            this.order_button.Text = "Order";
            this.order_button.UseVisualStyleBackColor = true;
            // 
            // Goods_list
            // 
            this.Goods_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.Goods_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Goods_list.HideSelection = false;
            this.Goods_list.Location = new System.Drawing.Point(3, 30);
            this.Goods_list.Name = "Goods_list";
            this.Goods_list.Size = new System.Drawing.Size(782, 206);
            this.Goods_list.TabIndex = 0;
            this.Goods_list.UseCompatibleStateImageBehavior = false;
            this.Goods_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 305;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "In stock";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "shelf life";
            this.columnHeader5.Width = 117;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Delivery";
            this.columnHeader6.Width = 105;
            // 
            // exit_item
            // 
            this.exit_item.Name = "exit_item";
            this.exit_item.Size = new System.Drawing.Size(224, 26);
            this.exit_item.Text = "&Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_filters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Goods list";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_filters.ResumeLayout(false);
            this.groupBox_filters.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryCreate_item;
        private System.Windows.Forms.ToolStripMenuItem updateCategory_item;
        private System.Windows.Forms.ToolStripMenuItem deleteCategory_item;
        private System.Windows.Forms.ToolStripMenuItem producersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProducers_item;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProducers_item;
        private System.Windows.Forms.ToolStripMenuItem deleteProducers_item;
        private System.Windows.Forms.ToolStripMenuItem createProducts_item;
        private System.Windows.Forms.ToolStripMenuItem updateProduct_item;
        private System.Windows.Forms.ToolStripMenuItem deleteProduct_item;
        private System.Windows.Forms.ToolStripMenuItem author_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_filters;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.ComboBox manufacturer_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox category_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.TextBox inStock_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView Goods_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem exit_item;
    }
}

