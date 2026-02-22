using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift
{
    // Custom DataGridViewCell that acts as a ProgressBar
    public class DataGridViewProgressBarCell : DataGridViewCell
    {
        public DataGridViewProgressBarCell()
        {
            this.ValueType = typeof(int); // The value will be the percentage (0-100)
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds,
            Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState,
            object value, object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            // Call the base class method to paint the background and border.
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState,
                value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            if (value == null || !(value is int))
            {
                // If no value or not an integer, draw nothing in the progress bar area
                return;
            }

            int progressVal = (int)value;

            // Ensure value is within 0-100 range
            progressVal = Math.Max(0, Math.Min(100, progressVal));

            // Calculate the width of the progress bar
            int barWidth = (int)((float)progressVal / 100 * cellBounds.Width);

            // Draw the progress bar background
            graphics.FillRectangle(new SolidBrush(cellStyle.BackColor), cellBounds);

            // Draw the progress bar fill
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 180, 255)), cellBounds.X, cellBounds.Y, barWidth, cellBounds.Height); // Light blue

            // Draw text (percentage) over the bar
            string text = progressVal.ToString() + "%";
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                graphics.DrawString(text, cellStyle.Font, new SolidBrush(cellStyle.ForeColor), cellBounds, sf);
            }

            // Draw cell border
            graphics.DrawRectangle(new Pen(DataGridView.GridColor), cellBounds.X, cellBounds.Y, cellBounds.Width - 1, cellBounds.Height - 1);
        }

        public override object Clone()
        {
            DataGridViewProgressBarCell cell = (DataGridViewProgressBarCell)base.Clone();
            return cell;
        }
    }

    // Custom DataGridViewColumn that hosts DataGridViewProgressBarCell
    public class DataGridViewProgressBarColumn : DataGridViewColumn
    {
        public DataGridViewProgressBarColumn() : base(new DataGridViewProgressBarCell())
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get { return base.CellTemplate; }
            set
            {
                // Ensure that the cell template is a DataGridViewProgressBarCell.
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewProgressBarCell)))
                {
                    throw new InvalidCastException("Must be a DataGridViewProgressBarCell.");
                }
                base.CellTemplate = value;
            }
        }
    }
}
