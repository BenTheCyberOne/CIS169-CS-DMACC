/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Product Queries
 The user can click buttons and make queries accordingly
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteSQLStatementBreshears
{
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDBDataSet);

        }

        private void Query_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sortPriceButton_Click(object sender, EventArgs e)//query order by price
        {
            this.productTableAdapter.FillByPrice(this.productDBDataSet.Product);
        }

        private void sortUnitsOver100Button_Click(object sender, EventArgs e)//query where Units_On_Hand > 100
        {
            this.productTableAdapter.FillByUnits(this.productDBDataSet.Product);
        }

        private void sortPriceOver40Button_Click(object sender, EventArgs e)//query where Price > 40
        {
            this.productTableAdapter.FillByPriceOver40(this.productDBDataSet.Product);
        }

        private void sortHighestPriceButton_Click(object sender, EventArgs e)//query maximum price
        {
            this.productTableAdapter.FillByMaxPrice(this.productDBDataSet.Product);
        }
    }
}
