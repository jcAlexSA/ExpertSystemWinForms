using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystemWinForms.Infrastructure
{
    public class LinesSet
    {
        /// <summary>
        /// The pen
        /// </summary>
        private Pen pen = new Pen(Color.Gray, 1.8f);

        /// <summary>
        /// Gets or sets the lines collection.
        /// </summary>
        /// <value>
        /// The lines collection.
        /// </value>
        public List<Line> Lines { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinesSet"/> class.
        /// </summary>
        public LinesSet()
        {
            this.Lines = new List<Line>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinesSet"/> class.
        /// </summary>
        /// <param name="lines">The lines.</param>
        public LinesSet(List<Line> lines)
        {
            this.Lines = lines;
        }

        /// <summary>
        /// Draw lines using graphics, created by UI control element.
        /// </summary>
        /// <param name="graphics">The graphics, created by UI control.</param>
        public void DrawLines(Graphics graphics)
        {
            graphics.Clear(Color.White);

            foreach (var line in this.Lines)
            {
                graphics.DrawLine(this.pen, line.Start, line.End); 
            }
        }

        /// <summary>
        /// Removes the lines related to element, based on control name.
        /// </summary>
        /// <param name="control">The UI control.</param>
        public void RemoveLinesRelativeToElement(Control control)
        {
            this.Lines.RemoveAll(l => l.StartControl.Name.Equals(control.Name) || l.EndControl.Name.Equals(control.Name));
        }

        /// <summary>
        /// Updates coordinates of lines that relate to specify control.
        /// </summary>
        /// <param name="control"></param>
        public void UpdateLinesCoordinatesAccoringControl(Control control)
        {
            var linesToUpdate = this.Lines.Where(l => l.StartControl.Name.Equals(control.Name) || l.EndControl.Name.Equals(control.Name));
            if (linesToUpdate != null)
            {
                foreach (var line in linesToUpdate)
                {
                    if (control.Name.Equals(line.StartControl.Name))
                    {
                        line.Start = new Point(control.Location.X + control.Width, control.Location.Y + control.Height / 2);
                    }
                    else if (control.Name.Equals(line.EndControl.Name))
                    {
                        line.End = new Point(control.Location.X, control.Location.Y + control.Height / 2);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Represents a Line UI element.
    /// </summary>
    public class Line
    {
        /// <summary>
        /// Gets or sets the start point of Line.
        /// </summary>
        /// <value>
        /// The start of Line.
        /// </value>
        public Point Start { get; set; }

        /// <summary>
        /// Gets or sets the end point of Line.
        /// </summary>
        /// <value>
        /// The end of Line.
        /// </value>
        public Point End { get; set; }

        /// <summary>
        /// Gets or sets the start control UI element, from which line starts.
        /// </summary>
        /// <value>
        /// The start control for line.
        /// </value>
        public Control StartControl { get; set; }

        /// <summary>
        /// Gets or sets the end control UI element, in whick line ends.
        /// </summary>
        /// <value>
        /// The end control for line.
        /// </value>
        public Control EndControl { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line"/> class.
        /// </summary>
        /// <param name="start">The start point.</param>
        /// <param name="end">The end point.</param>
        /// <param name="startControl">The start UI control.</param>
        /// <param name="endControl">The end UI control.</param>
        public Line(Control startControl, Control endControl)
        {
            this.StartControl = startControl;
            this.EndControl = endControl;

            // Init point.
            this.Start = new Point(this.StartControl.Location.X + this.StartControl.Width, this.StartControl.Location.Y + this.StartControl.Height / 2);
            this.End = new Point(this.EndControl.Location.X, this.EndControl.Location.Y + this.EndControl.Height / 2);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinesSet"/> class.
        /// </summary>
        /// <param name="startControl">The start control.</param>
        /// <param name="endControl">The end control.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        public Line(Control startControl, Control endControl, Point start, Point end)
        {
            this.Start = start;
            this.End = end;
            this.StartControl = startControl;
            this.EndControl = endControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinesSet"/> class.
        /// </summary>
        public Line()
        {

        }
    }
}
