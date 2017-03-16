using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGGEA.UserControls
{
    public partial class LabelError : Label
    {
        public LabelError()
        {
            InitializeComponent();
            BackColor = System.Drawing.Color.Transparent;
            Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.Red;
            Size = new System.Drawing.Size(184, 16);
            TabIndex = 4;
            Visible = false;
        }
    }
}
