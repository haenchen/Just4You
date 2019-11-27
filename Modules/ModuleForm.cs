using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Just4You.Modules.InputModule;

namespace Just4You
{
    public abstract partial class ModuleForm : Form
    {
        protected List<String> output = new List<string>();
        public ModuleForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Module geben unterschiedlich viele Rückgabewerte aus, daher schreiben sie in ihren eigenen Buffer.
        /// </summary>
        /// <returns>Die Ausgabe des Moduls</returns>
        public List<String> GetOutput()
        {
            return output;
        }

        /// <summary>
        /// Etwas hacky, aber das Schulmodul braucht kein eigenes Fenster.
        /// Ohne diese Funktion müsste man im MainForm gegen den Type vergleichen.
        /// </summary>
        public virtual void DoModuleFunction()
        {
            this.ShowDialog();
        }

        /// <summary>
        /// Schließt das Fenster automatisch. Ist zwar nue eine Zeile, aber Kleinvieh macht auch MIst.
        /// </summary>
        /// <param name="param">Der zu überprüfende Parameter</param>
        /// <returns>True wenn Eingabe nicht ordnungsgemäß beendet wurde</returns>
        protected bool ParamAborted(Parameter param)
        {
            if (param.Aborted)
            {
                this.Close();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Geld wird immer mit 2 Nachkommastellen ausgegeben
        /// </summary>
        /// <param name="val">Fließkommazahl die formatiert werden soll</param>
        /// <returns>Zahl mit zwei Nachkommastellen</returns>
        protected String FormatMoney(double val)
        {
            return String.Format("{0:0.00}", val).Replace('.', ',');
        }

        /// <summary>
        /// Wird benutzt um den Text in den Knopf zu schreiben.
        /// </summary>
        /// <returns>Anzeigename des Moduls</returns>
        public abstract String GetModuleText();
    }
}
