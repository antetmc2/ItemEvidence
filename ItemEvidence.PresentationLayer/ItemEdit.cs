using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemEvidence.DAL;
using ItemEvidence.Model;

namespace ItemEvidence.PresentationLayer
{
    public partial class ItemEdit : Form
    {
        private IMainController _controller;
        private ItemRepositoryMemory _itemRepo;
        private Item _item;

        public ItemEdit(IMainController ctr, ItemRepositoryMemory irm, Item item)
        {
            _controller = ctr;
            _itemRepo = irm;
            _item = item;
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemEdit_Load(object sender, EventArgs e)
        {
            textBox_ItemType.Text = _item.GetType().Name;
            textBox_Name.Text = _item.Name;
            textBox_Description.Text = _item.Description;
            textBox_Author.Text = _item.Author;
            numericUpDown_Quantity.Value = _item.Quantity;

            if (textBox_ItemType.Text == "Book") textBox_Author.ReadOnly = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            _item.Name = textBox_Name.Text;
            _item.Description = textBox_Description.Text;
            _item.Author = textBox_Author.Text;
            _controller.SaveEditedChanges(_item);
            this.Close();
        }

        private void OrderItems_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.OrderMoreItems(_item.ItemId, (int)numericUpDown_Order.Value);
            }
            catch(ItemEvidenceException exc)
            {
                MessageBox.Show(exc.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _item = _controller.GetItemDetails(_item.ItemId);
            numericUpDown_Quantity.Value = _item.Quantity;
        }

        private void ReturnItems_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.ReturnSomeItems(_item.ItemId, (int)numericUpDown_Return.Value);
            }
            catch (ItemEvidenceException exc)
            {
                MessageBox.Show(exc.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _item = _controller.GetItemDetails(_item.ItemId);
            numericUpDown_Quantity.Value = _item.Quantity;
        }

        private void ReturnAllItems_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.ReturnAllItems(_item.ItemId);
            }
            catch (ItemEvidenceException exc)
            {
                MessageBox.Show(exc.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _item = _controller.GetItemDetails(_item.ItemId);
            numericUpDown_Quantity.Value = _item.Quantity;
        }
    }
}
