namespace sport_shop
{
    partial class FormMenu
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
            paneltop = new Panel();
            lblUserName = new Label();
            btnLogout = new Button();
            panel1 = new Panel();
            btnOrders = new Button();
            btnProducts = new Button();
            paneltop.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // paneltop
            // 
            paneltop.Controls.Add(lblUserName);
            paneltop.Controls.Add(btnLogout);
            paneltop.Dock = DockStyle.Top;
            paneltop.Location = new Point(0, 0);
            paneltop.Margin = new Padding(4);
            paneltop.Name = "paneltop";
            paneltop.Padding = new Padding(5, 0, 0, 0);
            paneltop.Size = new Size(784, 27);
            paneltop.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(491, 0);
            lblUserName.Margin = new Padding(15, 15, 5, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(45, 19);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(67, 97, 238);
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(536, 0);
            btnLogout.Margin = new Padding(5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(248, 27);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnProducts);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 27);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 0, 0, 0);
            panel1.Size = new Size(784, 377);
            panel1.TabIndex = 11;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.FromArgb(67, 97, 238);
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Location = new Point(73, 204);
            btnOrders.Margin = new Padding(4);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(645, 32);
            btnOrders.TabIndex = 12;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(67, 97, 238);
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Location = new Point(73, 139);
            btnProducts.Margin = new Padding(4);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(645, 32);
            btnProducts.TabIndex = 11;
            btnProducts.Text = "Товары";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(784, 404);
            Controls.Add(panel1);
            Controls.Add(paneltop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormMenu";
            Text = "Меню";
            paneltop.ResumeLayout(false);
            paneltop.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel paneltop;
        private Label lblUserName;
        private Button btnLogout;
        private Panel panel1;
        private Button btnOrders;
        private Button btnProducts;
    }
}