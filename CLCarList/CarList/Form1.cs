using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarList
{
    public partial class carListForm : Form
    {
        public carListForm()
        {
            InitializeComponent();
        }

        private void GetData(ref Automobile auto)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                // Display the error message
                MessageBox.Show(ex.Message);

            }
        }
    }
}
