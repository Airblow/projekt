using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class mathPage : Form
    {
        public mathPage()
        {
            InitializeComponent();

            utility.FormSize(this);
        }

        public void menuButton_Click(object sender, EventArgs e)
        {
            allround.MenuButton(this);
        }

        public void backButton_Click(object sender, EventArgs e)
        {
            allround.BackButton(this);
        }

    }

}
