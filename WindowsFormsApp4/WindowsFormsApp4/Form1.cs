using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Abstractions;
using WindowsFormsApp4.Entities;

namespace WindowsFormsApp4
{

    


    public partial class Form1 : Form
    {
        private List<Toy> _toys = new List<Toy>();
        private Interface1 _factory;
        private Interface1 Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }


        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            panel1.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition)
                    maxPosition = toy.Left;
            }

            if (maxPosition > 1000)
            {
                var oldesttoy = _toys[0];
                panel1.Controls.Remove(oldesttoy);
                _toys.Remove(oldesttoy);
            }
        }
    }
}
