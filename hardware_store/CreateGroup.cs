using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hardware_store
{
    public partial class CreateGroup : Form
    {
        private Store store { get; set; }
        public CreateGroup(Store store)
        {
            InitializeComponent();
            this.store = store;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if ((textBox1.TextLength != 0) && (store.checkedListBox1.Items.Contains(textBox1.Text) == false) && textBox1.Text.Any(Char.IsLetter))
            {
                store.chekListGroups.Items.Add(textBox1.Text);
                store.checkedListBox1.Items.Add(textBox1.Text);
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
