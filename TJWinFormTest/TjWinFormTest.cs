using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TJWinFormTest
{
    public partial class TjWinFormTest : Form
    {
        private string[] Suggestions = new[]
        {
            "Rick",
            "Roger",
            "Richard",
            "Chuck",
            "Larry",
            "Dave",
            "Jerry"
        };
        public TjWinFormTest()
        {
            InitializeComponent();

            this.cmbSuggest.AutoCompleteCustomSource.AddRange(Suggestions);
            this.txtSuggest.AutoCompleteCustomSource.AddRange(Suggestions);
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            this.lblHello.Text = $"Hello, {this.txtName.Text}!";
        }

        private void txtSuggest_TextChanged(object sender, EventArgs e)
        {
            this.lblSuggest.Text = this.txtSuggest.Text;
        }

        private void cmbSuggest_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblSuggest.Text = this.cmbSuggest.Text;
        }
    }
}
