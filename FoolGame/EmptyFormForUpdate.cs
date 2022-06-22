using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoolGame
{
    public partial class EmptyFormForUpdate : Form
    {
        public EmptyFormForUpdate()
        {
            InitializeComponent();
        }

        private void EmptyFormForUpdate_Load(object sender, EventArgs e)
        {
            Close();
        }
    }
}
