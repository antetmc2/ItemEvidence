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
    public partial class ItemList : Form, IObserver
    {
        private IMainController _controller;
        private ItemRepositoryMemory _itemRepo;
        private IOrderedEnumerable<Item> _items;

        private void LoadAllData(IOrderedEnumerable<Item> it = null)
        {
            itemBindingSource.Clear();
            if(it == null)
            {
                foreach (var item in _itemRepo.Items.OrderBy(i => i.Name))
                {
                    itemBindingSource.Add(item);
                }
            }
            else
            {
                foreach (var item in it)
                {
                    itemBindingSource.Add(item);
                }
            }
            ItemList_DataGridView.AutoGenerateColumns = false;
            ItemList_DataGridView.AutoSize = true;
            ItemList_DataGridView.DataSource = itemBindingSource;
        }

        public ItemList(IMainController ctr, ItemRepositoryMemory irm)
        {
            _controller = ctr;
            _itemRepo = irm;
            InitializeComponent();
        }

        private void RefreshView(IOrderedEnumerable<Item> it = null)
        {
            LoadAllData(it);
            ItemList_DataGridView.Refresh();
            ItemList_DataGridView.Update();
            itemBindingSource.ResetBindings(true);
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            var itemTypes = new BindingList<KeyValuePair<string, int>>();
            itemTypes.Add(new KeyValuePair<string, int>("<< All Items >>", 6));
            itemTypes.Add(new KeyValuePair<string, int>("Book", 5));
            itemTypes.Add(new KeyValuePair<string, int>("Headset", 3));
            itemTypes.Add(new KeyValuePair<string, int>("Keyboard", 1));
            itemTypes.Add(new KeyValuePair<string, int>("Laptop", 4));
            itemTypes.Add(new KeyValuePair<string, int>("Monitor", 0));
            itemTypes.Add(new KeyValuePair<string, int>("Mouse", 2));

            comboBox_ItemList.DataSource = itemTypes;
            comboBox_ItemList.ValueMember = "Value";
            comboBox_ItemList.DisplayMember = "Key";

            LoadAllData();
            DeleteSelectedItem.Enabled = false;
            EditSelectedItem.Enabled = false;
            DetailsItem.Enabled = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewItem_Click(object sender, EventArgs e)
        {
            _controller.AddNewItem("Items");
        }

        private void DeleteSelectedItem_Click(object sender, EventArgs e)
        {
            Item item = itemBindingSource.Current as Item;
            _controller.DeleteCurrentItem(item.ItemId);
        }

        private void EditSelectedItem_Click(object sender, EventArgs e)
        {
            Item item = itemBindingSource.Current as Item;
            _controller.EditCurrentItem(item);
        }

        private void ItemList_DataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DeleteSelectedItem.Enabled = true;
            EditSelectedItem.Enabled = true;
            DetailsItem.Enabled = true;

            var item = itemBindingSource.Current as Item;
            textBox_Item.Text = item.Name;
            if (item is Monitor) textBox_Type.Text = "Monitor";
            else if (item is Keyboard) textBox_Type.Text = "Keyboard";
            else if (item is Mouse) textBox_Type.Text = "Mouse";
            else if (item is Headset) textBox_Type.Text = "Headset";
            else if (item is Laptop) textBox_Type.Text = "Laptop";
            else if (item is Book) textBox_Type.Text = "Book";
        }

        private void DetailsItem_Click(object sender, EventArgs e)
        {
            Item item = itemBindingSource.Current as Item;
            _controller.ItemDetails(item);
            
        }

        public void UpdateView()
        {
            RefreshView();
            comboBox_ItemList.SelectedValue = 6;
        }

        private void comboBox_ItemList_DropDownClosed(object sender, EventArgs e)
        {
            var chosen = (ItemTypes)comboBox_ItemList.SelectedValue;
            switch (chosen)
            {
                case ItemTypes.Book:
                    _items = _itemRepo.Items.Where(i => i is Book).OrderBy(i => i.Name);
                    RefreshView(_items);
                    break;
                case ItemTypes.Headset:
                    _items = _itemRepo.Items.Where(i => i is Headset).OrderBy(i => i.Name);
                    RefreshView(_items);
                    break;
                case ItemTypes.Keyboard:
                    _items = _itemRepo.Items.Where(i => i is Keyboard).OrderBy(i => i.Name);
                    RefreshView(_items);
                    break;
                case ItemTypes.Laptop:
                    _items = _itemRepo.Items.Where(i => i is Laptop).OrderBy(i => i.Name);
                    RefreshView(_items);
                    break;
                case ItemTypes.Monitor:
                    _items = _itemRepo.Items.Where(i => i is Monitor).OrderBy(i => i.Name);
                    RefreshView(_items);
                    break;
                case ItemTypes.Mouse:
                    _items = _itemRepo.Items.Where(i => i is Mouse).OrderBy(i => i.Name);
                    RefreshView(_items);
                    break;
                default:
                    _items = _itemRepo.Items.OrderBy(i => i.Name);
                    RefreshView(_items);
                    break;
            }
        }
    }
}
