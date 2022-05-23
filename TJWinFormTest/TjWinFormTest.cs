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
        private readonly List<string> _cmbData = new List<string>()
        {
            "Rick",
            "Roger",
            "Richard",
            "Chuck",
            "Larry",
            "Dave",
            "Jerry"
        };
        private BindingList<string> cmbDataBound;

        private readonly AutoCompleteStringCollection _txtSuggestions = new AutoCompleteStringCollection();

        public TjWinFormTest()
        {
            InitializeComponent();

            _txtSuggestions.AddRange(_cmbData.ToArray());

            cmbDataBound = new BindingList<string>(_cmbData);
            this.cmbSuggest.DataSource = cmbDataBound;
            this.cmbSuggest.SelectedIndex = -1;
            this.txtSuggest.AutoCompleteCustomSource = _txtSuggestions;
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            this.lblHello.Text = $"Hello, {this.txtName.Text}!";
            cmbDataBound.Add(this.txtName.Text);
            _txtSuggestions.Add(this.txtName.Text);
            cmbSuggest.Refresh();

            var popup = new ToolStripDropDown();
            popup.Padding = Padding.Empty;

            var cmbKeyword = new ComboBox();
            cmbKeyword.Name = "cmbKeyword";
            cmbKeyword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbKeyword.IntegralHeight = false;
            cmbKeyword.MaxDropDownItems = 10;
            cmbKeyword.Size = new Size(150, 20);
            cmbKeyword.DataSource = cmbDataBound;
            cmbKeyword.BindingContext = this.BindingContext;

            var popupContents = new ToolStripControlHost(cmbKeyword);
            popupContents.Margin = Padding.Empty;
            popup.Items.Add(popupContents);
            popup.Closed += (s, a) =>
            {
                //cmbKeyword = null;
                //Focus();
            };
            popup.Show(btnHello, new Point(btnHello.Width - cmbKeyword.Size.Width, btnHello.Height));
        }

        private void txtSuggest_Click(object sender, EventArgs e)
        {
            this.lblSuggest.Text = this.txtSuggest.Text;
        }

        private void txtSuggest_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbSuggest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var newEntry = this.cmbSuggest.Text;
                if (!cmbDataBound.Contains(newEntry))
                {
                    //cmbDataBound.Add(newEntry);
                    //selectedIndex gets reset when DataSource refreshes, so set it back
                    //this.cmbSuggest.SelectedIndex = this.cmbSuggest.FindStringExact(newEntry);
                }
            }
        }

        private void cmbSuggest_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblSuggest.Text = this.cmbSuggest.Text;
            cmbDataBound.Remove(this.cmbSuggest.Text);
        }

        private void cmbSuggest_TextChanged(object sender, EventArgs e)
        {
            if (cmbSuggest.Text == "")
            {
                //cmbSuggest.Text = "Enter name";
            }
        }
    }
}
