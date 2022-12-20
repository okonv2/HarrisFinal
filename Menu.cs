using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarrisFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showmenu(studentpanelmenu);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            showmenu(staffpanelmenu);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            studentpanelmenu.Visible = false;
            staffpanelmenu.Visible = false;
            classespanelmenu.Visible = false;
            enrolmentpanelmenu.Visible = false;
            materialspanelmenu.Visible = false;

        }

        private void hidemenu()
        {
            if (studentpanelmenu.Visible == true)
                studentpanelmenu.Visible = false;
            if (staffpanelmenu.Visible == true)
                staffpanelmenu.Visible = false;
            if (classespanelmenu.Visible == true)
                classespanelmenu.Visible = false;
            if (materialspanelmenu.Visible == true)
                materialspanelmenu.Visible = false;
            if (enrolmentpanelmenu.Visible == true)
                enrolmentpanelmenu.Visible = false;
        }

        private void showmenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hidemenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showmenu(enrolmentpanelmenu);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void managestudentsbutton_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void statusstudentsbutton_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void classesbutton_Click(object sender, EventArgs e)
        {
            showmenu(classespanelmenu);
        }

        private void materialsbutton_Click(object sender, EventArgs e)
        {
            showmenu(materialspanelmenu);
        }

        private void newclassesbutton_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void manageclassesbutton_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void statusclassesbutton_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void newenrolmentbutton_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void manageenrolmentbutton_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void statusenrolmentbutton_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void newmaterialsbutton_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void managematerialsbutton_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }

        private void statusmaterialsbutton_Click(object sender, EventArgs e)
        {
            //...
            //my code
            //...
            hidemenu();
        }
    }
}
