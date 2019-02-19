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
        public int? Min { get; set; } = null;

        /// <summary>
        /// Gets or sets the last carrier of function.
        /// </summary>
        /// <value>
        /// The second carrier.
        /// </value>
        public int? Max { get; set; } = null;

        /// <summary>
        /// Gets or sets the fuzzificated value.
        /// </summary>
        /// <value>
        /// The fuzzificated value.
        /// </value>
        public float? FuzzificatedValue { get; private set; }

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

        /// <summary>
        /// Calculates the minimum maximum of function.
        /// </summary>
        private void CalculateMinMaxOfFunction()
        {
            int x = this.B;
            float result = 1;

            do
            {
                result = (float)this.MembershipFunction(x);
                x -= 1;
            } while (result > 0.001);

            this.Min = (int?)Math.Floor((double)x);
            this.Max = (2 * this.B) - this.Min;
        }

        /// <summary>
        /// Fuzzifications the specified value.
        /// </summary>
        /// <param name="value">The value to fuzzificate.</param>
        /// <returns>The fuzzificated value.</returns>
        public void Fuzzificate(float value)
        {
            this.FuzzificatedValue = this.MembershipFunction(value);
        }
    }
}
