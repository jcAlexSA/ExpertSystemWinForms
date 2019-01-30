﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemWinForms.Models
{
    /// <summary>
    /// Represent a rule block model.
    /// </summary>
    public class RuleBlockModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the input variables.
        /// </summary>
        /// <value>
        /// The input variables.
        /// </value>
        public List<FuzzyVariableModel> InputFuzzyVariables { get; set; } = new List<FuzzyVariableModel>();

        /// <summary>
        /// Gets or sets the output variables.
        /// </summary>
        /// <value>
        /// The output variables.
        /// </value>
        public List<FuzzyVariableModel> OutputFuzzyVariables { get; set; } = new List<FuzzyVariableModel>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleBlockModel"/> class.
        /// </summary>
        public RuleBlockModel()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleBlockModel"/> class.
        /// </summary>
        /// <param name="name">The rule block name.</param>
        public RuleBlockModel(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleBlockModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="inputFuzzyVariables">The input fuzzy variables.</param>
        /// <param name="outputFuzzyVariables">The output fuzzy variables.</param>
        public RuleBlockModel(string name, List<FuzzyVariableModel> inputFuzzyVariables, List<FuzzyVariableModel> outputFuzzyVariables)
        {
            this.Name = name;
            this.InputFuzzyVariables = inputFuzzyVariables;
            this.OutputFuzzyVariables = outputFuzzyVariables;
        }
    }
}