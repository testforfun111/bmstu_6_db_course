using BL.Services;
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

namespace GUI.AppForm
{
    public partial class FormClient : Form
    {
        private UserService _userService;
        private ProductService _productService;
        private PromoService _promoService;
        private OrderService _orderService;
        private CartService _cartService;
        private ItemCartService _itemCartService;
        private ItemOrderService _itemOrderService;
        private int id_user;
        public FormClient(int id_user, UserService userService, ProductService productService, PromoService promoService, OrderService orderService, CartService cartService,
                        ItemOrderService itemOrderService, ItemCartService itemCartService)
        {
            InitializeComponent();
            this.id_user = id_user;
            this._cartService = cartService;
            this._userService = userService;
            this._productService = productService;
            this._promoService = promoService;
            this._orderService = orderService;
            this._itemCartService = itemCartService;
            this._itemOrderService = itemOrderService;
        }
        private Form activeForm = null;

        private void openChildForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.AutoScaleMode = AutoScaleMode.None;  // Adjust scaling
            form.Size = panelMain.ClientSize;
            panelMain.Controls.Add(activeForm);
            panelMain.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new FormInfo(id_user, _userService));
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            openChildForm(new FormViewProductsByClient(id_user, _productService, _cartService, _itemCartService));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin(_userService, _productService, _promoService, _orderService, _cartService, _itemOrderService, _itemCartService);
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }
            frm.Show();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            openChildForm(new FormViewOrdersByClient(id_user, _orderService, _userService, _promoService, _productService, _itemOrderService));
        }

        private void btnViewPromos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormViewPromosByClient(id_user, _promoService));
        }

        private void btnViewCarts_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCarts(id_user, _cartService, _promoService, _userService, _itemCartService, _productService, _orderService, _itemOrderService));
        }
    }
}
