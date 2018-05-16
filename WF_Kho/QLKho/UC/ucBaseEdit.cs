using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKho.Code;

namespace QLKho.UC
{
    public partial class ucBaseEdit : UserControl
    {
        public IFormBase iFormBase { get; set; }
        public ucBaseEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            iFormBase.Cancel();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            iFormBase.Save();
        }
    }
}
