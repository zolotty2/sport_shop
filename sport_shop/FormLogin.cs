using Microsoft.VisualBasic.ApplicationServices;
using sport_shop.Models;

namespace sport_shop
{
    public partial class FormLogin : Form
    {
        public Models.User CurretUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите логи или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            using (var db = new SportShopDbContext())
            {
                var user = db.Users.Where(w => w.UserLogin == txtLogin.Text && w.UserPassword == txtPassword.Text).FirstOrDefault();
                if (user != null)
                {
                    CurretUser = user;
                    IsGuest = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnGuest_Click(object sender, EventArgs e)
        {
            CurretUser = null;
            IsGuest = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
