using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_Code
{
    public partial class Select : Form
    {
        bool isClicked = false;
        public Select()
        {
            InitializeComponent();
        }

        bool getBool()
        {
            return isClicked;
        }
        private void Select_Load(object sender, EventArgs e)
        {
            //form chosen
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //form cancelled
            this.Close();

            FormMain var = (FormMain)Application.OpenForms["FormMain"];
            var.Close();
        }
    }
}
