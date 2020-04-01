using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_ListBox
{
    public partial class Default : System.Web.UI.Page
    {
        private void ChangeSubMenuState(bool visible, string header = null)
        {
            SubMenuHeader.Text = header;
            ElementName.Visible = visible;
            ElementNameLabel.Visible = visible;
            ElementValue.Visible = visible;
            ElementValueLabel.Visible = visible;
            NameValidator.Visible = visible;
            ValueValidator.Visible = visible;
            Cancel.Visible = visible;
            Confirm.Visible = visible;
        }

        private void UpdateSelectedElementInfo()
        {
            NameLiteral.Text = ItemsBox.SelectedItem?.Text;
            ValueLiteral.Text = ItemsBox.SelectedValue;
            IndexLiteral.Text = ItemsBox.SelectedIndex.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                UpdateSelectedElementInfo();
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            ChangeSubMenuState(true, "Добавление элемента");
            Session.Add("position", ItemsBox.Items.Count);
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Session.Remove("position");
            ChangeSubMenuState(false);
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            if (ItemsBox.SelectedItem == null)
                return;

            Session.Add("position", ItemsBox.SelectedIndex);
            ElementName.Text = ItemsBox.SelectedItem.Text;
            ElementValue.Text = ItemsBox.SelectedValue;

            ChangeSubMenuState(true, "Изменение элемента");
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            if (Session["position"] == null
                || (int)Session["position"] == ItemsBox.Items.Count)
            {
                if (ItemsBox.Items.FindByText(ElementName.Text) != null ||
                    ItemsBox.Items.FindByValue(ElementValue.Text) != null)
                    return;

                ItemsBox.Items.Add(new ListItem(ElementName.Text, ElementValue.Text));
            }
            else
            {
                ItemsBox.Items[(int)Session["position"]].Text = ElementName.Text;
                ItemsBox.Items[(int)Session["position"]].Value = ElementValue.Text;
            }

            ChangeSubMenuState(false);
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            if (ItemsBox.SelectedItem == null)
                return;

            ItemsBox.Items.Remove(ItemsBox.SelectedItem);
            UpdateSelectedElementInfo();
        }
    }
}