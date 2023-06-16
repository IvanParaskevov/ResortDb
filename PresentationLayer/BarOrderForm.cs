using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class BarOrderForm : Form
    {
        ResortDbContext dbContext = new ResortDbContext();
        BarOrderDbContext BarOrderDbContext = new BarOrderDbContext();


        public BarOrderForm()
        {
            InitializeComponent();
        }

        private void Create_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Read_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
