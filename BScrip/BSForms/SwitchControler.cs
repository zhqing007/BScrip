using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BScrip.BSForms {
    public partial class SwitchControler : Form {
        private Host mySwitch;

        public SwitchControler(Host sw) {
            InitializeComponent();
            mySwitch = sw;
        }



    }
}
