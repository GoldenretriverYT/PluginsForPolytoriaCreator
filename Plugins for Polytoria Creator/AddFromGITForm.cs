using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugins_for_Polytoria_Creator.Utils {
    public partial class AddFromGITForm : Form {
        public AddFromGITForm() {
            InitializeComponent();
        }

        private void ButtonAddFromGIT_Click(object sender, EventArgs e) {
            this.Close();
            StartForm.Instance.InstallFromGIT(TextBoxGitURL.Text);
        }
    }
}
