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

        public List<List<string>> GetRulesAsRows()
        {
            if (this.Rules == null)
            {
                return null;
            }

            var list = new List<List<string>>();

            List<string> subList = null;
            for (int i = 0; i < this.Rules.Values.FirstOrDefault().Count; i++)
            {
                subList = new List<string>();
                foreach (var key in this.Rules.Keys)
                {
                    subList.Add(this.Rules[key][i]);
                }
                list.Add(subList);
            }

            return list.OrderBy(r => r.Last()).ToList();
        }
    }
}
