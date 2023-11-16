namespace CarsDesktop
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picture = new PictureBox();
            brand = new Label();
            name = new Label();
            price = new Label();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Location = new Point(10, 8);
            picture.Name = "picture";
            picture.Size = new Size(133, 126);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // brand
            // 
            brand.AutoSize = true;
            brand.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brand.Location = new Point(167, 11);
            brand.Name = "brand";
            brand.Size = new Size(78, 30);
            brand.TabIndex = 1;
            brand.Text = "Brand: ";
            brand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(167, 51);
            name.Name = "name";
            name.Size = new Size(80, 30);
            name.TabIndex = 2;
            name.Text = "Name: ";
            name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price.Location = new Point(167, 93);
            price.Name = "price";
            price.Size = new Size(80, 30);
            price.TabIndex = 3;
            price.Text = "Price: $";
            price.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(price);
            Controls.Add(name);
            Controls.Add(brand);
            Controls.Add(picture);
            Name = "UserControl1";
            Size = new Size(560, 143);
            DoubleClick += UserControl1_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picture;
        private Label brand;
        private Label name;
        private Label price;
    }
}
