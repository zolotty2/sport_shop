using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sport_shop.Models;

namespace sport_shop
{
    public partial class FormMenu : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public User UserFio { get; private set; }
        public FormMenu(User user, bool isGuest)
        {
            InitializeComponent();

            CurrentUser = user;
            IsGuest = isGuest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.UserFio;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenProductsForm();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenOrdersForm();
        }
        private void OpenProductsForm()
        {
            this.Hide();

            using (var formProducts = new FormProducts(CurrentUser, IsGuest))
            {
                formProducts.ShowDialog();
            }

            this.Show();
        }

        private void OpenOrdersForm()
        {
            this.Hide();

            using (var formOrders = new FormOrders(CurrentUser, IsGuest))
            {
                formOrders.ShowDialog();
            }

            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
