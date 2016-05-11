using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemEvidence.Model;

namespace ItemEvidence.PresentationLayer
{
    public partial class MainForm : Form
    {
        private IMainController _controller;

        public MainForm(IMainController controller)
        {
            _controller = controller;
            InitializeComponent();
            statusStrip_Text.Text = "Data successfully loaded!";
            //IsMdiContainer = true;
            //foreach(Control ctl in this.Controls)
            //{
            //    try
            //    {
            //        Control mdi = (MdiClient)ctl;
            //        mdi.BackColor = SystemColors.ControlLight;
            //    }
            //    catch { }
            //}
        }

        private void StartForm(Form form)
        {
            //form.MdiParent = this;
            form.Show();
        }

        private bool isOpened(string text)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.Text == text) return true;
            }
            return false;
        }

        private void ViewEmployees_Click(object sender, EventArgs e)
        {
            _controller.ListAllEmployees();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            _controller.AddNewEmployee();
        }

        static void Main() { }

        private void ListOfItems_Click(object sender, EventArgs e)
        {
            _controller.ListAllItems();
        }

        private void AddNewItem_Click(object sender, EventArgs e)
        {
            _controller.AddNewItem();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
