using ExpertSystemWinForms.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemWinForms.Models
{
    /// <summary>
    /// Describe the model of a Term
    /// </summary>
    public class TermModel
    {
        /// <summary>
        /// Gets or sets the name of term.
        /// </summary>
        /// <value>
        /// The name of term.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the membership function.
        /// </summary>
        /// <value>
        /// The membership function.
        /// </value>
        public IMembershipFunction Function { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TermModel"/> class.
        /// </summary>
        public TermModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TermModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public TermModel(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TermModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="membershipFunction">The membership function.</param>
        public TermModel(string name, IMembershipFunction membershipFunction)
        {
            this.Name = name;
            this.Function = membershipFunction;
        }
    }
}
