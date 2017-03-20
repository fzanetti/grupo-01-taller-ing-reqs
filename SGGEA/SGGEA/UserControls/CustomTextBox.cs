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
    public partial class CustomTextBox : UserControl
    {

        public CustomTextBox()
        {
            InitializeComponent();
        }

        [Description("Texto del Campo"), Category("TextoCampo")]
        public string TextoCampo
        {
            get { return tbCampo.Text; }
            set { tbCampo.Text = value; }
        }

        [Description("Texto del mensaje de error"), Category("TextoError")]
        public string TextoError
        {
            get { return lblError.Text; }
            set { lblError.Text = value; }
        }

        [Description("Título del campo"), Category("TituloCampo")]
        public string TituloCampo
        {
            get { return lblCampo.Text; }
            set { lblCampo.Text = value; }
        }

        [Description("Ofusca el texo si el campo es contraseña"), Category("EsPassword")]
        public bool EsPassword
        {
            get { return tbCampo.UseSystemPasswordChar; }
            set { tbCampo.UseSystemPasswordChar = value; }
        }

        [Description("Font del Campo"), Category("FontCampo")]
        public Font FontCampo
        {
            get { return tbCampo.Font; }
            set { tbCampo.Font = value; }
        }

        [Description("Font del Título"), Category("FontTitulo")]
        public Font FontTitulo
        {
            get { return lblCampo.Font; }
            set { lblCampo.Font = value; }
        }

        [Description("Font del Error"), Category("FontError")]
        public Font FontError
        {
            get { return lblError.Font; }
            set { lblError.Font = value; }
        }

        [Description("Color de Fondo"), Category("ColorDeFondo")]
        public Color ColorDeFondo
        {
            get { return lblCampo.BackColor; }
            set { lblCampo.BackColor = tbCampo.BackColor = value; }
        }

        [Description("Ancho del campo"), Category("AnchoCampo")]
        public int AnchoCampo
        {
            get { return  tbCampo.Size.Width; }
            set {tbCampo.Size = lblError.Size= new System.Drawing.Size(value, tbCampo.Size.Height);}
        }

        public delegate void FuncionDelEvento(object sender, KeyPressEventArgs e);
        public void setKeyPressEvent(FuncionDelEvento f)
        {
            this.tbCampo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(f);
        }

        private void tbCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string txt = tbCampo.Text;
            if (e.KeyChar != (char)Keys.Back)
            {
                txt+=e.KeyChar;
            }
            else if (!String.IsNullOrEmpty(txt))
            {
                txt = txt.Substring(0, txt.Length - 1);
            }
            lblCampo.Visible = String.IsNullOrEmpty(txt.Trim());       
        }

        private void lblCampo_Click(object sender, EventArgs e)
        {
            lblCampo.Focus();
            this.ActiveControl = tbCampo;
        }


    }
}
