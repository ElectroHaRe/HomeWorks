using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace _02_Shop
{
    public partial class Default : System.Web.UI.Page
    {
        private List<ListItem> storage
        {
            get
            {
                List<ListItem> storage = new List<ListItem>();

                storage.Add(new ListItem("Печеньки"));
                storage.Add(new ListItem("Батончик"));
                storage.Add(new ListItem("Колбаска"));
                storage.Add(new ListItem("Сладкая булочка"));
                storage.Add(new ListItem("Сосисочки"));
                storage.Add(new ListItem("Что-то непонятненькое"));

                return storage;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Shop.Items.Count == 0 && Basket.Items.Count == 0)
                Shop.Items.AddRange(storage.ToArray());
        }

        protected void MoveToShop_Click(object sender, EventArgs e)
        {
            MoveItems(Basket, Shop, true);
        }


        protected void MoveToBasket_Click(object sender, EventArgs e)
        {
            MoveItems(Shop, Basket, true);
        }

        protected void AllToBasket_Click(object sender, EventArgs e)
        {
            MoveItems(Shop, Basket);
        }

        protected void AllToShop_Click(object sender, EventArgs e)
        {
            MoveItems(Basket, Shop);
        }

        private void MoveItems(ListBox from, ListBox to, bool onlySelected = false)
        {
            for (int i = from.Items.Count - 1; i >= 0; i--)
            {
                if (onlySelected && !from.Items[i].Selected)
                    continue;

                to.Items.Add(from.Items[i]);
                from.Items.Remove(from.Items[i]);
            }
        }
    }
}