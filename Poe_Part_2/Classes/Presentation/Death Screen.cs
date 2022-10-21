using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinSlayer
{
    [Serializable]
    public partial class DeathScreen : Form
    {
        public DeathScreen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void winScreenText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeathScreen_Load(object sender, EventArgs e)
        {

        }

        private void diedExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
