using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timesheet
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            Connection newConnection = new Connection();
            bool connected = newConnection.connectNow();
            if (connected)
            {
                InitializeComponent();
            }
        }

    }
}
