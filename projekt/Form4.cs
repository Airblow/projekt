using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class engPage : Form
    {
        public engPage()
        {
            InitializeComponent();

            utility.FormSize(this);
        }

        void backButton_Click(object sender, EventArgs e)
        {
            allround.BackButton(this);
        }

        void menuButton_Click(object sender, EventArgs e)
        {
            allround.MenuButton(this);
        }
    }
}
