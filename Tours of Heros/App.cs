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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        // Heroes Button Click Event.
        private void button1_Click_1(object sender, EventArgs e)
        {
            Heroes heroes = new Heroes();
            heroes.ShowDialog();
        }

        // Top Heroes List on Select.
        private void topHeroesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.Write(sender);
            Console.Write(e);
        }

        // App Init.
        private void App_Load(object sender, EventArgs e)
        {
            loadTopHeroes();
        }

        // Load top heroes.
        private void loadTopHeroes ()
        {
            topHeroesList.Items.Clear();
            Hero[] topHeroes = HeroesService.topHeroes();
            foreach (var item in topHeroes)
            {
                ListViewItem newItem = new ListViewItem();
                newItem.Text = "Name: " + item.fullname + " | Level: " + item.level;
                topHeroesList.Items.Add(newItem);
            }
        }
        
    }
}
