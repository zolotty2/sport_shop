using Microsoft.EntityFrameworkCore;
using sport_shop.Models;
using sport_shop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace sport_shop
{
    public partial class FormProducts : Form
    {
        public User CurretUser { get; private set; }
        public bool IsGuest { get; private set; }
        public User UserFio { get; private set; }
        public FormProducts(User user, bool isGuest)
        {
            InitializeComponent();
            InitializeDataGridView();
            CurretUser = user;
            IsGuest = isGuest;

            lblUserName.Text = IsGuest ? "Гость" : $"{UserFio}";
            LoadProducts();
        }

        private void InitializeDataGridView()
        {
            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "Фото товара";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 30;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "Информация о товаре";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "Скидка";
            colDiscount.FillWeight = 60;
            colDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.Columns.AddRange(new DataGridViewColumn[] {
                colPhoto, colInfo, colDiscount
            });
        }

        private void LoadProducts()
        {
            try
            {
                using (var db = new SportShopDbContext())
                {
                    var SportTovars = db.SportTovars
                        .Include(i => i.TovarCategoryNavigation)
                        .Include(i => i.TovarManufactureNavigation)
                        .Include(i => i.TovarSupliersNavigation)
                        .ToList();

                    dgvProducts.SuspendLayout();
                    dgvProducts.Rows.Clear();

                    foreach (var SportTovar in SportTovars)
                    {
                        int rowIndex = dgvProducts.Rows.Add();
                        var row = dgvProducts.Rows[rowIndex];

                        row.Cells["Фото товара"].Value = LoadImage(SportTovar.PhotoUrl);
                        row.Cells["Информация о товаре"].Value = FormatProductInfo(SportTovar);
                        row.Cells["Скидка"].Value = $"{SportTovar.Discount}%";
                        row.Cells["Скидка"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        ApplyRowStyles(row, SportTovar);
                    }

                    dgvProducts.ResumeLayout();
                    dgvProducts.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyRowStyles(DataGridViewRow row, SportTovar SportTovar)
        {
            if (int.Parse(SportTovar.Discount) > 15)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");
                row.DefaultCellStyle.ForeColor = Color.White;
            }

            if (SportTovar.QuantityInStock <= 0)
            {
                row.DefaultCellStyle.BackColor = Color.LightBlue;
                if (int.Parse(SportTovar.Discount) <= 15)
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            if (int.Parse(SportTovar.Discount) > 0)
            {
                row.Cells["Скидка"].Style.ForeColor = Color.Red;
                row.Cells["Скидка"].Style.Font = new Font(
                    "Times New Roman",
                    12,
                    FontStyle.Bold);
            }
        }

        private string FormatProductInfo(SportTovar SportTovar)
        {
            string priceText;
            if (int.Parse(SportTovar.Discount) > 0)
            {
                decimal finalPrice = SportTovar.Price * (100 - int.Parse(SportTovar.Discount)) / 100;
                priceText = $"Цена {SportTovar.Price:C} -> {finalPrice:C}";
            }
            else
            {
                priceText = $"Цена {SportTovar.Price:C}";
            }

            
            return $"{SportTovar.TovarName} | {SportTovar.Category.Value}\n"  +
                $"Информация о товаре: {SportTovar.Description}\n" +
                $"Информация о производителе: {SportTovar.TovarManufacture}\n" +
                $"Поставщик: {SportTovar.TovarSupliers}\n" + 
                $"Цена товара: {SportTovar.Price}\n" + 
                $"Единица измерения: {SportTovar.UnitOfMeasurement}\n" + 
                $"Количество на складе: {SportTovar.QuantityInStock}";


        }

        private Image LoadImage(string img)
        {
            if (!String.IsNullOrEmpty(img))
            {
                object obj = Resources.ResourceManager.GetObject(img);

                if (obj is Image i)
                {

                    return i;

                }
            }

            return Resources._1;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
        }
    }
}
