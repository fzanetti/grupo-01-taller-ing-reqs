using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Dominio;

namespace SGGEA.UserControls
{
    public partial class SelPerfil : UserControl
    {
        private bool _selected = false;
        private Perfil _perfil;

        public SelPerfil(Perfil perfil)
        {
            InitializeComponent();
            _perfil = perfil;
            lblPerfil.Text = _perfil.Nombre;
        }

        public Perfil getPerfil()
        {
            return _perfil;
        }
    
        public bool Seleccionado()
        {
            return _selected; 
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (!_selected)
            {
                 this.btnPerfil.BackgroundImage = global::SGGEA.Properties.Resources.checkBoxChequed;              
            }else{
                this.btnPerfil.BackgroundImage = global::SGGEA.Properties.Resources.checkBox;
            }
            _selected = !_selected;
        }


    }
}
