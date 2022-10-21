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
    public partial class WinScreen : Form
    {
        public WinScreen()
        {
            InitializeComponent();
        }

        private void winScreenText_TextChanged(object sender, EventArgs e)
        {

        }

        private void WinScreen_Load(object sender, EventArgs e)
        {

        }

        private void diedRestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void diedExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
