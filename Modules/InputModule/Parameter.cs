using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just4You.Modules.InputModule
{
    /// <summary>
    /// Diese Klasse kann benutzt werden um Eingaben vom Benutzer zu holen, da es albern wäre, sich ständig ums InputForm zu kümmern.
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Theoretisch brauchen die Properties kein set, aber die VS Version in der Schule lässt nur get nicht zu.
        /// </summary>
        public double Value
        {
            get;
            set;
        }

        /// <summary>
        /// Theoretisch brauchen die Properties kein set, aber die VS Version in der Schule lässt nur get nicht zu.
        /// </summary>
        public String Input
        {
            get;
            set;
        }

        /// <summary>
        /// Theoretisch brauchen die Properties kein set, aber die VS Version in der Schule lässt nur get nicht zu.
        /// </summary>
        public bool Aborted
        {
            get;
            set;
        }

        /// <summary>
        /// Behandelt die Eingabe des Benutzers und setzt das Label im Eingabeformular.
        /// </summary>
        /// <param name="name">Der Name der im Eingemodul angezeigt wird.</param>
        public Parameter(String name)
        {
            var Form = new InputForm();
            Form.SetLabel(name);
            Form.ShowDialog();
            Aborted = Form.Aborted;
            Input = Form.GetInput();
            Value = Form.GetValue();
        }

        /// <summary>
        /// Constructor mit Constraints. Macht nichts besonderes wenn die Eingabe abgebrochen wurde.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="constraints"></param>
        public Parameter(String name, InputConstraint[] constraints) : this(name)
        {
            if (Aborted)
                return;
            foreach (InputConstraint constraint in constraints)
                if (!constraint.IsValid(Value))
                {
                    Aborted = true;
                    return;
                }
        }
    }
}
