using ExpertSystemWinForms.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemWinForms.Models.MembershipFunction
{
    public class TriangleMembershipFunction : IMembershipFunction
    {
        /// <summary>
        /// Gets the variable's name.
        /// </summary>
        /// <value>
        /// The variable name.
        /// </value>
        public string Name { get; } = "Triangle";

        /// <summary>
        /// Gets or sets the minimum value.
        /// </summary>
        /// <value>
        /// The minimum value.
        /// </value>
        public int Min { get; set; }

        /// <summary>
        /// Gets or sets the middle value.
        /// </summary>
        /// <value>
        /// The middle value.
        /// </value>
        public int Middle { get; set; }

        /// <summary>
        /// Gets or sets the high value.
        /// </summary>
        /// <value>
        /// The high value.
        /// </value>
        public int Right { get; set; }
    }
}
