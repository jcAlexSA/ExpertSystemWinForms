﻿using ExpertSystemWinForms.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExpertSystemWinForms.Infrastructure
{
    /// <summary>
    /// Represent a creator 
    /// </summary>
    /// <seealso cref="ExpertSystemWinForms.Models.Interfaces.IUserControlCreator" />
    public class FuzzyVariableCreator : IUserControlCreator
    {
        public Control CreateElement(string name)
        {
            Label variable = new Label();

            variable.BackColor = Color.Gainsboro;
            variable.ForeColor = Color.DimGray;

            variable.BorderStyle = BorderStyle.FixedSingle;

            variable.Text = name;
            variable.Name = "labelVariable" + name;

            variable.Width = 90;
            variable.Height = 20;

            variable.Font = new Font("Arial", 8, FontStyle.Bold);
            variable.Location = new Point(10, 10);

            ControlExtension.Draggable(variable, true);

            return variable;
        }
    }
}
