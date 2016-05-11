using ItemEvidence.DAL;
using ItemEvidence.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemEvidence.PresentationLayer
{
    public partial class ItemAdd : Form
    {
        private IMainController _controller;
        private ItemRepositoryMemory _itemRepo;
        public ItemAdd(IMainController ctr, ItemRepositoryMemory irm)
        {
            _controller = ctr;
            _itemRepo = irm;
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            _controller.AddNewItem((ItemTypes)ItemType_ComboBox.SelectedValue, textBox_Name.Text, textBox_Description.Text, (int)numericUpDown_Quantity.Value, textBox_Author.Text);
            this.Close();
        }

        private void ItemType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            int selectedIndex = (int)comboBox.SelectedIndex;
            if (selectedIndex == 1) textBox_Author.ReadOnly = false;
            else textBox_Author.ReadOnly = true;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.ClearAllTextBoxes();
        }

        private void ItemAdd_Load(object sender, EventArgs e)
        {
            var itemTypes = new BindingList<KeyValuePair<string, int>>();
            itemTypes.Add(new KeyValuePair<string, int>("<< All Items >>", 6));
            itemTypes.Add(new KeyValuePair<string, int>("Book", 5));
            itemTypes.Add(new KeyValuePair<string, int>("Headset", 3));
            itemTypes.Add(new KeyValuePair<string, int>("Keyboard", 1));
            itemTypes.Add(new KeyValuePair<string, int>("Laptop", 4));
            itemTypes.Add(new KeyValuePair<string, int>("Monitor", 0));
            itemTypes.Add(new KeyValuePair<string, int>("Mouse", 2));

            ItemType_ComboBox.DataSource = itemTypes;
            ItemType_ComboBox.ValueMember = "Value";
            ItemType_ComboBox.DisplayMember = "Key";
        }
    }
}
