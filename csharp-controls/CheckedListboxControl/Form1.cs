using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListboxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string generateRecordString(string name, string surname, string eid)
        {
            return name + " " + surname + " [" + eid + "]";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string record = generateRecordString(textboxName.Text, textboxSurname.Text, textboxEid.Text);

            checkedListBoxRegisteredPeople.Items.Add(record);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (checkedListBoxRegisteredPeople.CheckedItems.Count > 0)
            {
                for (int i = checkedListBoxRegisteredPeople.CheckedItems.Count - 1; i >= 0; i--)
                {
                    checkedListBoxRegisteredPeople.Items.Remove(checkedListBoxRegisteredPeople.CheckedItems[i]);
                }

            }
        }

        private void checkedListBoxRegisteredPeople_SelectedIndexChanged(object sender, EventArgs e)
        {

            checkedListBoxSelectedPeople.Items.Clear();

            for (int i = 0; i < checkedListBoxRegisteredPeople.CheckedItems.Count; i++)
            {
                checkedListBoxSelectedPeople.Items.Add(checkedListBoxRegisteredPeople.CheckedItems[i]);
            }
            
        }
    }
}
