using ExpertSystemWinForms.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

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
        public int Left { get; set; }

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
        
        /// <summary>
        /// Draws the function on chart.
        /// </summary>
        /// <param name="series">The series on which draw function.</param>
        public void DrawFunctionOnSeriesChart(Series series)
        {
            //Insert this dummy point before the real data:
            series.Points.AddXY(-1, 0);
            series.Points.AddXY(this.Left, 0);
            series.Points.AddXY(this.Middle, 1);
            series.Points.AddXY(this.Right, 0);
         
            // Hides the Line segment before the 1st real point.
            series.Points[0].Color = Color.Transparent;
            series.Points[1].Color = Color.Transparent;
        }
    }
}
