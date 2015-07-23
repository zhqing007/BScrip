using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BScrip.BSForms {
    public partial class BSMessageBox : Form {
        public BSMessageBox(string msg) {
            InitializeComponent();
            this.msglabel.Text = msg;
        }
    }
}
