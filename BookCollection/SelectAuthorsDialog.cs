using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookCollection.Items;

namespace BookCollection
{
    public partial class SelectAuthorsDialog : Form
    {
        private List<Author> Authors { get; set; }

        public List<int> SelectedAuthorIds { get; private set; }

        public SelectAuthorsDialog(List<Author> authors)
        {
            InitializeComponent();
            Authors = authors;
            SelectedAuthorIds = new List<int>();
            InitializeListComponent();
        }

        private void InitializeListComponent()
        {
            listBoxAuthors.DataSource = Authors;
            listBoxAuthors.DisplayMember = "Name";
            listBoxAuthors.ValueMember = "AuthorId";
            listBoxAuthors.SelectionMode = SelectionMode.MultiExtended;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            listBoxAuthors.ClearSelected();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            var selectedItems = listBoxAuthors.SelectedItems.Cast<Author>().ToList();

            if (selectedItems.Any())
            {
                SelectedAuthorIds = selectedItems.Select(author => author.AuthorId).ToList();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Please select at least one author.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
