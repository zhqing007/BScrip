using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BScrip.BSForms {
    public partial class DeviceViewer : Form {
        private Host deviceInfo = null;
        private Dictionary<string, string> infodic = new Dictionary<string, string>();

        public DeviceViewer(Host sw) {
            InitializeComponent();
            deviceInfo = sw;
        }

        public void FlashDictionary() {
        }
    }
}
