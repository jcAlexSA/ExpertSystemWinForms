using ExpertSystemWinForms.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

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
        public int C { get; set; }

        /// <summary>
        /// Gets or sets the B params.
        /// </summary>
        /// <value>
        /// The b params.
        /// </value>
        public int B { get; set; }

        /// <summary>
        /// Gets or sets the first carrier of function.
        /// </summary>
        /// <value>
        /// The first carrier.
        /// </value>
        public float? Min { get; set; } = null;

        /// <summary>
        /// Gets or sets the last carrier of function.
        /// </summary>
        /// <value>
        /// The second carrier.
        /// </value>
        public float? Max { get; set; } = null;

        /// <summary>
        /// Memberships the function.
        /// </summary>
        /// <param name="x">The x value.</param>
        /// <returns>Return result of calculation based on X value.</returns>
        public float MembershipFunction(float x)
        {
            float res = (float)Math.Pow(Math.E, -(Math.Pow(x - this.B, 2) / (2 * Math.Pow(this.C, 2))));
            return res;
        }

        /// <summary>
        /// Draws the function on chart.
        /// </summary>
        /// <param name="series">The series on wich function drawing.</param>
        public void DrawFunctionOnSeriesChart(Series series)
        {
            //this.Min = -10;
            //this.Max = 10;

            if (this.Min == null || this.Max == null)
            {
                this.CalculateMinMaxOfFunction();
            }

            for (float x = (int)this.Min; x <= this.Max; x+=1f)
            {
                series.Points.AddXY(x, this.MembershipFunction(x));
            }
        }

        private void CalculateMinMaxOfFunction()
        {
            var x = (float)this.B;
            float? result = 1;

            do
            {
                result = (float)this.MembershipFunction(x);
                x -= 1f;
            } while (result > 0.001);

            this.Min = (float)Math.Round(x);
            this.Max = (float)Math.Round(-x) * 2;
        }
    }
}
