using ExpertSystemWinForms.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemWinForms.Models.RulesModels
{
    /// <summary>
    /// Represent an entity of expert rules.
    /// </summary>
    /// <seealso cref="ExpertSystemWinForms.Models.Interfaces.IRules" />
    public class RulesModel : IRules
    {
        public Dictionary<string, List<string>> Rules { get; set; } = new Dictionary<string, List<string>>();

        public RulesModel()
        {

        }
    }
}
