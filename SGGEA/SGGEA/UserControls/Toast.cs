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
    public partial class Toast : UserControl
    {

        private System.Windows.Forms.Timer _timer;
        private ToastObserver _observer;
        private bool _ejecutarAccionPosterior;

        public Toast()
        {
            InitializeComponent();
            this.Visible = false;
        }

        public void AddToastObserver(ToastObserver observer)
        {
            _observer = observer;
        }

        public void MostrarMensaje(string mensaje, bool ejecutarAccionPosterior=true)
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 2000;
            _timer.Tick += new System.EventHandler(this.timer_Tick);
            _timer.Start();

            this.txtMensaje.Text=mensaje;
            _ejecutarAccionPosterior = ejecutarAccionPosterior;
                   
            this.Visible = true;
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            _timer.Stop();
            this.Visible = false;
            if (_ejecutarAccionPosterior)
                _observer.AccionPosterior();
        }

    }
}
