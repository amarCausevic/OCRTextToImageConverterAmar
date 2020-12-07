using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageReaderAmar
{
    public partial class CustomPopUp : Form
    {
        public CustomPopUp(string message, string customTitle)
        {
            this.CenterToParent();
            InitializeComponent();
            label1.Text = message;
            this.Text = customTitle;
        }

    }
 
}
