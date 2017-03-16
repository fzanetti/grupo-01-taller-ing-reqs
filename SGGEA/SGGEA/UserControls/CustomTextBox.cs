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
    public partial class CustomTextBox : TextBox
    {
        private Boolean firstTime = true;
        private Font fontRegular = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

        public CustomTextBox()
        {
            InitializeComponent();
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            BorderStyle = BorderStyle.None;
            Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            Size = new Size(175, 22);
            KeyPress += new KeyPressEventHandler(this.customTextBox_KeyPress);
            Enter += new EventHandler(this.customTextBox_Enter);
        }

        private void customTextBox_KeyPress(object sender, EventArgs e)
        {
            if (firstTime)
            {
                firstTime = false;
                Text = "";
                Font = fontRegular;
            }
        }

        private void customTextBox_Enter(object sender, EventArgs e)
        {
            Select(0, 0);
        }
    }
}
