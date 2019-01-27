using ExpertSystemWinForms.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemWinForms.Models.MembershipFunctions
{
    public class GaussMembershipFunction : IMembershipFunction
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = "Gauss";

        /// <summary>
        /// Gets or sets the C params.
        /// </summary>
        /// <value>
        /// The c params.
        /// </value>
        public float C { get; set; }

        /// <summary>
        /// Gets or sets the B params.
        /// </summary>
        /// <value>
        /// The b params.
        /// </value>
        public float B { get; set; }
    }
}
