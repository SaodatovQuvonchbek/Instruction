using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookDemo.UserControls
{
    public partial class UC_Chat : UserControl
    {
        public UC_Chat()
        {
            InitializeComponent();
        }

        public string ChatTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string ChatContent
        {
            get { return lblContent.Text; }
            set { lblContent.Text = value; }
        }

        public Image ChatImage
        {
            get { return imgProfile.Image; }
            set { imgProfile.Image = value; }
        }

        private void UC_Chat_Load(object sender, EventArgs e)
        {

        }
    }
}
