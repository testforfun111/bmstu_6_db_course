using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Models;
using BL.Services;
using BL.MyException;
using MyException;

namespace GUI.AppForm
{
    public partial class FormLogin : Form
    {
        private UserService _userService;
        private ProductService _productService;
        private PromoService _promoService;
        private OrderService _orderService;
        private CartService _cartService;
        private ItemCartService _itemCartService;
        private ItemOrderService _itemOrderService;

        public FormLogin(UserService userService, ProductService productService, PromoService promoService, OrderService orderService, CartService cartService,
                        ItemOrderService itemOrderService, ItemCartService itemCartService)
        {
            InitializeComponent();
            this._cartService = cartService;
            this._userService = userService;
            this._productService = productService;
            this._promoService = promoService;
            this._orderService = orderService;
            this._itemCartService = itemCartService;
            this._itemOrderService = itemOrderService;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp frm = new FormSignUp(_userService, _productService, _promoService, _orderService, _cartService, _itemOrderService, _itemCartService);
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            frm.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string login = tbUsername.Text;
                string password = tbPassword.Text;
                if (login == "" || password == "")
                {
                    throw new Exception("Input error");
                }
                User user = _userService.LogIn(login, password);
                switch (user.Role)
                {
                    case Role.Admin:
                        FormAdmin frm_admin = new FormAdmin(user.Id, _userService, _productService, _promoService, _orderService, _cartService, _itemOrderService, _itemCartService);
                        frm_admin.Show();
                        break;
                    case Role.Seller:
                        FormSelller frm_seller = new FormSelller(user.Id, _userService, _productService, _promoService, _orderService, _cartService, _itemOrderService, _itemCartService);
                        frm_seller.Show();
                        break;
                    case Role.Client:
                        FormClient frm_client = new FormClient(user.Id, _userService, _productService, _promoService, _orderService, _cartService, _itemOrderService, _itemCartService);
                        frm_client.Show();
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }
    }
}
