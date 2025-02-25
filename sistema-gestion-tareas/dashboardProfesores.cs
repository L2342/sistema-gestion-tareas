using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestion_tareas
{
    public partial class dashboardProfesores : Form
    {
        public dashboardProfesores()
        {
            InitializeComponent();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.Thistle;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            PnlNav.Top = BtnLogOut.Top;
            PnlNav.Left = BtnLogOut.Left;
            BtnLogOut.BackColor = Color.Thistle;
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.White;
        }

        private void BtnLogOut_Leave(object sender, EventArgs e)
        {
             BtnLogOut.BackColor= Color.White;
        }
    }
}
