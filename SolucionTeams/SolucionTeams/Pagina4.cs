using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.IO;

namespace SolucionTeams
{
    public partial class Pagina4 : Form
    {
        private readonly string _opcion;
        private readonly string _usuAdm;
        private readonly string _conAdm;
        private readonly string _userOption;
        private PowerShell _pshellP4;
        private OpenFileDialog _openFileDialog = new OpenFileDialog();
        private bool _onContinue;

        public Pagina4(string opcion, string usuAdm, string conAdm, string userOption)
        {
            _opcion = opcion;
            _usuAdm = usuAdm;
            _conAdm = conAdm;
            _userOption = userOption;
            _onContinue = false;
            InitializeComponent();
        }

        private void BtnSalirP4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAtrP4_Click(object sender, EventArgs e)
        {
            previousPage();
        }

        private void BtnContP4_Click(object sender, EventArgs e)
        {
            optionExecution();
            nextPage();
        }

        private void BtnExaminarP4_Click(object sender, EventArgs e)
        {
            filePath();
            savePath();
        }

        private void filePath() 
        {
            if (_opcion == "RB1")
            {
                _openFileDialog.Filter = "File Msi (*.msi)|*.msi";
            }

            if (_opcion == "RB2")
            {
                _openFileDialog.Filter = "File Msi (*.msi)|*.msi";
            }

            if (_opcion == "RB3")
            {
                _openFileDialog.Filter = "All Files(*.*)|*.*";
            }

            if (_opcion == "RB4")
            {
                _openFileDialog.Filter = "File ps1 (*.ps1)|*.ps1";
            }
        }

        private void savePath() 
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TxtPath.Text = _openFileDialog.FileName;
                File.WriteAllText(@"C:\STSetup\path.txt",_openFileDialog.FileName);
                BtnContP4.Enabled = true;
            }
        }

        private void config() 
        {
            _pshellP4 = PowerShell.Create();
            _pshellP4.AddCommand("Set-ExecutionPolicy")
                .AddParameter("ExecutionPolicy", "unrestricted")
                .AddParameter("Scope", "CurrentUser");
            _pshellP4.AddScript("$UsuAdm =" + "'" + _usuAdm + "'");
            _pshellP4.AddScript("$ConAdm =" + "'" + _conAdm + "'");
            _pshellP4.AddScript("$UO =" + _userOption);
        }


        private void previousPage() 
        {
            SolucionTeams.Pagina3 AtrP4 = new SolucionTeams.Pagina3(_usuAdm, _conAdm, _userOption);
            AtrP4.Show();
            _onContinue = true;
            Close();
        }

        private void optionExecution() 
        {
            Cursor.Current = Cursors.WaitCursor;

            if (_opcion == "RB1")
            {
                config();
                _pshellP4.AddScript(@"Scripts\Opcion1.ps1");
                _pshellP4.Invoke();
            }

            if (_opcion == "RB2")
            {
                config();
                _pshellP4.AddScript(@"Scripts\Opcion2.ps1");
                _pshellP4.Invoke();
            }

            if (_opcion == "RB3")
            {
                config();
                _pshellP4.AddScript(@"Scripts\Opcion3.ps1");
                _pshellP4.Invoke();
            }

            if (_opcion == "RB4")
            {
                config();
                _pshellP4.AddScript(@"Scripts\Opcion4.ps1");
                _pshellP4.Invoke();
            }

            Cursor.Current = Cursors.Default;
        }

        private void nextPage() 
        {
            SolucionTeams.Pagina5 ContP5 = new SolucionTeams.Pagina5(_opcion, _usuAdm, _conAdm, _userOption);
            ContP5.Show();
            _onContinue = true;
            Close();
        }

        private void Pagina4_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_onContinue)
            {
                Directory.Delete(@"C:\STSetup", true);
                Application.Exit();
            }
        }

        private void PBLogoP4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sonda.com/");
        }
    }
}
