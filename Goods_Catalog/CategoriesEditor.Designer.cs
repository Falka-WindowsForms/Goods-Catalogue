
namespace Goods_Catalog
{
    partial class CategoriesEditor
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
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_field = new System.Windows.Forms.TextBox();
            this.execute_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Charlemagne Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(26, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(401, 36);
            this.title.TabIndex = 0;
            this.title.Text = "Category operation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Charlemagne Std", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_field
            // 
            this.name_field.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_field.Location = new System.Drawing.Point(120, 48);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(280, 53);
            this.name_field.TabIndex = 2;
            // 
            // execute_button
            // 
            this.execute_button.Location = new System.Drawing.Point(120, 104);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(188, 53);
            this.execute_button.TabIndex = 3;
            this.execute_button.Text = "Execute";
            this.execute_button.UseVisualStyleBackColor = true;
            this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
            // 
            // CategoriesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(452, 169);
            this.Controls.Add(this.execute_button);
            this.Controls.Add(this.name_field);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Charlemagne Std", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "CategoriesEditor";
            this.Text = "CategoriesEditor";
            this.Load += new System.EventHandler(this.CategoriesEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.Button execute_button;
    }
}