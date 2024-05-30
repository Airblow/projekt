using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public static class allround
    {
        public static void MenuButton(Form currentForm)
        {
            startPage startPage = new startPage();
            startPage.StartPosition = FormStartPosition.Manual;
            startPage.Location = currentForm.Location;
            startPage.Show();
            currentForm.Visible = false;

        }

        public static void BackButton(Form currentForm)
        {
            subjectPage subjectPage = new subjectPage();
            subjectPage.StartPosition = FormStartPosition.Manual;
            subjectPage.Location = currentForm.Location;
            subjectPage.Show();
            currentForm.Visible = false;

        }

    }

    class utility
    {
        public static void SpawnForm(Form currentForm, Form newForm)
        {
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = currentForm.Location;
            newForm.Show();
            currentForm.Visible = false;

        }
        public static void FormSize(Form currentForm)
        {
            currentForm.MinimumSize = new Size(1228, 798);
            currentForm.MaximumSize = new Size(1228, 798);
        }


    }

}




