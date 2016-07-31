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

        // Dashboard Button Click Event.
        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }


        // Heroes Button Click Event.
        private void button1_Click_1(object sender, EventArgs e)
        {
            Heroes heroes = new Heroes();
            heroes.ShowDialog();
        }

        // App Init.
        private void App_Load(object sender, EventArgs e)
        {
            loadTopHeroes();
        }

        // Load top heroes.
        private void loadTopHeroes ()
        {
            Hero[] topHeroes = HeroesService.topHeroes();
            foreach (var item in topHeroes)
            {
                string itemText = "Name: " + item.fullname + " | Level: " + item.level;
                topHeroesList.Items.Add(itemText);
            }
        }
    }
}
