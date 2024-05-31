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
    public partial class subjectPage : Form
    {
        public subjectPage()
        {
            InitializeComponent();
        }

        void mathButton_Click(object sender, EventArgs e)
        {
            mathPage mathPage = new mathPage();
            utility.SpawnForm(this, mathPage);

        }

        void engButton_Click(object sender, EventArgs e)
        {
            engPage engPage = new engPage();
            utility.SpawnForm(this, engPage);

        }

        void compButton_Click(object sender, EventArgs e)
        {
            compPage compPage = new compPage();
            utility.SpawnForm(this, compPage);

        }
    }
}
