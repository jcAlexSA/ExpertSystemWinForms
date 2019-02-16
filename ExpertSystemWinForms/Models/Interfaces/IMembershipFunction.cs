using System.Windows.Forms.DataVisualization.Charting;

namespace ExpertSystemWinForms.Models.Interfaces
{
    /// <summary>
    /// Interface for membership function.
    /// </summary>
    public interface IMembershipFunction
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Draws the function on Series chart.
        /// </summary>
        /// <param name="series">The series on which draw function.</param>
        void DrawFunctionOnSeriesChart(Series series);
    }
}
