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
            if (this.Min == null || this.Max == null)
            {
                this.CalculateMinMaxOfFunction();
            }

            for (float x = (int)this.Min; x <= this.Max; x += 1f)
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

        /// <summary>
        /// Deffuzificates the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="deffuzification">The deffuzification.</param>
        /// <returns>
        /// Deffuzzificated value.
        /// </returns>
        public float Deffuzificate(float value, Deffuzification deffuzification)
        {
            float left, right, middle;
            left = right = middle = 0f;

            float step = 0.5f;

            if(deffuzification == Deffuzification.LM)
            {
                left = this.GetLeftXValue((float)this.Min, value, step, (float)this.Max);
                return left;
            }
            if(deffuzification == Deffuzification.RM)
            {
                right = this.GetRightXValue((float)this.Max, value, -step, (float)this.Min);
                return right;
            }
            if(deffuzification == Deffuzification.MM)
            {
                right = this.GetRightXValue((float)this.Max, value, -step, (float)this.Min);
                left = this.GetLeftXValue((float)this.Min, value, step, (float)this.Max);
                middle = (left + right) / 2;
                return middle;
            }
            return 0;
        }

        /// <summary>
        /// Gets the x value.
        /// </summary>
        /// <param name="startXValue">The start x value.</param>
        /// <param name="yTargetValue">The y target value.</param>
        /// <param name="step">The step.</param>
        /// <returns></returns>
        private float GetRightXValue(float startXValue, float yTargetValue, float step, float stopXValue)
        {
            float yCurrentValue = 0f;

            yCurrentValue = this.MembershipFunction(startXValue);
            while (yCurrentValue <= yTargetValue && startXValue >= stopXValue)
            {
                startXValue += step;
                yCurrentValue = this.MembershipFunction(startXValue);
            }
            return startXValue;
        }

        /// <summary>
        /// Gets the x value.
        /// </summary>
        /// <param name="startXValue">The start x value.</param>
        /// <param name="yTargetValue">The y target value.</param>
        /// <param name="step">The step.</param>
        /// <returns></returns>
        private float GetLeftXValue(float startXValue, float yTargetValue, float step, float stopXValue)
        {
            float yCurrentValue = 0f;

            yCurrentValue = this.MembershipFunction(startXValue);
            while (yCurrentValue <= yTargetValue && startXValue <= stopXValue)
            {
                startXValue += step;
                yCurrentValue = this.MembershipFunction(startXValue);
            }
            return startXValue;
        }
    }
}
