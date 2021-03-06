﻿using ExpertSystemWinForms.Models.RulesModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<FuzzyVariableModel> InputFuzzyVariables { get; set; } = new ObservableCollection<FuzzyVariableModel>();

        /// <summary>
        /// Gets or sets the output variables.
        /// </summary>
        /// <value>
        /// The output variables.
        /// </value>
        public ObservableCollection<FuzzyVariableModel> OutputFuzzyVariables { get; set; } = new ObservableCollection<FuzzyVariableModel>();

        /// <summary>
        /// Gets or sets the expert rules of current rule block.
        /// </summary>
        /// <value>
        /// The rules.
        /// </value>
        public RulesModel Rules { get; set; }

        /// <summary>
        /// Gets or sets the operator.
        /// </summary>
        /// <value>
        /// The operator.
        /// </value>
        public NormOperator NormOperator { get; set; } = NormOperator.MinMax;   // TEMPORARY!!! TODO HERE AN INTERFACE !!!

        /// <summary>
        /// Gets or sets the deffuzification method.
        /// </summary>
        /// <value>
        /// The deffuzification method.
        /// </value>
        public Deffuzification DeffuzificationMethod { get; set; } = Deffuzification.MM;

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
        public RuleBlockModel(string name, ObservableCollection<FuzzyVariableModel> inputFuzzyVariables, ObservableCollection<FuzzyVariableModel> outputFuzzyVariables)
        {
            this.Name = name;
            this.InputFuzzyVariables = inputFuzzyVariables;
            this.OutputFuzzyVariables = outputFuzzyVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleBlockModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="inputFuzzyVariables">The input fuzzy variables.</param>
        /// <param name="outputFuzzyVariables">The output fuzzy variables.</param>
        /// <param name="normOperator">The norm operator.</param>
        public RuleBlockModel(string name, ObservableCollection<FuzzyVariableModel> inputFuzzyVariables, 
            ObservableCollection<FuzzyVariableModel> outputFuzzyVariables, NormOperator normOperator, Deffuzification deffuzification)
        {
            this.Name = name;
            this.InputFuzzyVariables = inputFuzzyVariables;
            this.OutputFuzzyVariables = outputFuzzyVariables;
            this.NormOperator = normOperator;
            this.DeffuzificationMethod = deffuzification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleBlockModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="inputFuzzyVariables">The input fuzzy variables.</param>
        /// <param name="outputFuzzyVariables">The output fuzzy variables.</param>
        /// <param name="rules">The rules.</param>
        public RuleBlockModel(string name, ObservableCollection<FuzzyVariableModel> inputFuzzyVariables, ObservableCollection<FuzzyVariableModel> outputFuzzyVariables, RulesModel rules)
        {
            this.Name = name;
            this.InputFuzzyVariables = inputFuzzyVariables;
            this.OutputFuzzyVariables = outputFuzzyVariables;
            this.Rules = rules;
        }
    }

    /// <summary>
    /// Norm operators.
    /// </summary>
    public enum NormOperator
    {
        MinMax,
        Prod,
        Mean
    }

    public enum Deffuzification
    {
        MM,
        LM,
        RM
    }
}
