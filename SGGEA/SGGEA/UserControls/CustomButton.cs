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
    public partial class CustomButton : Button
    {
        public CustomButton()
        {
            InitializeComponent();
            BackColor = Globals.ColorFondoBoton;
            FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;

            Size = new System.Drawing.Size(188, 36);

            UseVisualStyleBackColor = true;
            MouseEnter += new System.EventHandler(this.customButton_MouseEnter);
            MouseLeave += new System.EventHandler(this.customButton_MouseLeave);
        }

        private void customButton_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Globals.ColorFondoBotonHover;
        }

        private void customButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Globals.ColorFondoBoton;
        }
    }
}
