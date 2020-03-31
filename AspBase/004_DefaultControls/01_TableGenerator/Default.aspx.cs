using System;
using System.Web.UI.WebControls;

namespace _01_TableGenerator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Generate_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int rowCount = int.Parse(RowCount.Text);
                int columnCount = int.Parse(ColumnCount.Text);

                var table = new Table();
                table.BorderWidth = 1;

                TableRow row;
                TableCell cell;

                for (int i = 0; i < rowCount; i++)
                {
                    row = new TableRow();
                    for (int j = 0; j < columnCount; j++)
                    {
                        cell = new TableCell();
                        cell.Height = Unit.Parse("50");
                        cell.Width = Unit.Parse("50");
                        cell.BorderWidth = 1;
                        row.Cells.Add(cell);
                        row.BorderWidth = 1;
                    }
                    table.Rows.Add(row);
                }

                TablePlaceHolder.Controls.Add(table);
            }
        }
    }
}