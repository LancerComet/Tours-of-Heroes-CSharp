using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tours_of_Heros
{
    public partial class Heroes : Form
    {
        public Heroes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // ListBox Item on Select.
        private void heroesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.Write(sender);
            Console.Write(e);
        }

        // Window onload.
        private void Heroes_Load (object sender, EventArgs e)
        {
            loadHeroes();
        }
        
        // Load Heroes Data.
        private void loadHeroes ()
        {
            heroesListView.Items.Clear();
            foreach (var item in HeroesService.heroes)
            {
                ListViewItem newItem = new ListViewItem();
                newItem.Text = "Name: " + item.fullname + " | Level: " + item.level;
                heroesListView.Items.Add(newItem);
            }
        }
    }
}
