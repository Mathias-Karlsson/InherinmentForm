using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InherinmentForm
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();

        public Form1()
        {
            InitializeComponent();

            animals.Add(new Cat("Squeaky"));
            animals.Add(new Dog("Sif"));
            animals.Add(new Bird("Jock"));

            foreach  (Animal a in animals)
            {
                cbNames.Items.Add(a.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbNames.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Animal animal = animals[selectedIndex];
                lbSpecies.Text = animal.Species.ToString();
                lbCanFly.Text = (animal.CanFly ? "Kan flyga" : "Kan inte flyga");
            } else
            {
                lbSpecies.Text = "";
                lbCanFly.Text = "";
            }
            
        }
    }
}
