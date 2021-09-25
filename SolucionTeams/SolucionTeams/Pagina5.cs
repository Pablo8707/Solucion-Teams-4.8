using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SolucionTeams
{
    public partial class Pagina5 : Form
    {
        private readonly string _opcion;
        private readonly string _usuAdm;
        private readonly string _conAdm;
        private readonly string _userOption;
        private bool _onContinue;

        public Pagina5(string opcion, string usuAdm, string conAdm, string userOption)
        {
            _opcion = opcion;
            _usuAdm = usuAdm;
            _conAdm = conAdm;
            _userOption = userOption;
            _onContinue = false;
            InitializeComponent();
        }

        private void BtnSalirP5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAtrP5_Click(object sender, EventArgs e)
        {
            previousPage();
        }

        private void previousPage() 
        {
            if (_opcion != "0" )
            {
                SolucionTeams.Pagina4 AtrP5 = new SolucionTeams.Pagina4(_opcion, _usuAdm, _conAdm, _userOption);
                AtrP5.Show();
                _onContinue = true;
                Close();
            }
            else
            {
                SolucionTeams.Pagina3 AtrP5 = new SolucionTeams.Pagina3(_usuAdm, _conAdm, _userOption);
                AtrP5.Show();
                _onContinue = true;
                Close();
            }
        }

        private void Pagina5_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_onContinue)
            {
                Directory.Delete(@"C:\STSetup", true);
                Application.Exit();
            }
        }

        private void PBLogoP5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sonda.com/");
        }
    }
}
