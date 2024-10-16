using System.Globalization;
using System.Windows.Data;
using System.Windows;
using System.Windows.Media;

namespace DAndD.Converters
{
    public class CornerRadiusToPathConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 4 &&
                values[0] is CornerRadius cornerRadius &&
                values[1] is double width &&
                values[2] is double height &&
                values[3] is double inset)
            {
                double topLeft = Math.Max(0, cornerRadius.TopLeft - inset);
                double topRight = Math.Max(0, cornerRadius.TopRight - inset);
                double bottomRight = Math.Max(0, cornerRadius.BottomRight - inset);
                double bottomLeft = Math.Max(0, cornerRadius.BottomLeft - inset);

                PathGeometry pathGeometry = new PathGeometry();
                PathFigure pathFigure = new PathFigure();
                pathFigure.StartPoint = new Point(inset + topLeft, inset);

                pathFigure.Segments.Add(new LineSegment(new Point(width - inset - topRight, inset), true));
                pathFigure.Segments.Add(new ArcSegment(new Point(width - inset, inset + topRight), new Size(topRight, topRight), 0, false, SweepDirection.Clockwise, true));
                pathFigure.Segments.Add(new LineSegment(new Point(width - inset, height - inset - bottomRight), true));
                pathFigure.Segments.Add(new ArcSegment(new Point(width - inset - bottomRight, height - inset), new Size(bottomRight, bottomRight), 0, false, SweepDirection.Clockwise, true));
                pathFigure.Segments.Add(new LineSegment(new Point(inset + bottomLeft, height - inset), true));
                pathFigure.Segments.Add(new ArcSegment(new Point(inset, height - inset - bottomLeft), new Size(bottomLeft, bottomLeft), 0, false, SweepDirection.Clockwise, true));
                pathFigure.Segments.Add(new LineSegment(new Point(inset, inset + topLeft), true));
                pathFigure.Segments.Add(new ArcSegment(new Point(inset + topLeft, inset), new Size(topLeft, topLeft), 0, false, SweepDirection.Clockwise, true));

                pathFigure.IsClosed = true;
                pathGeometry.Figures.Add(pathFigure);

                return pathGeometry;
            }

            // Default rectangle if conversion fails
            return new RectangleGeometry(new Rect(0, 0, 300, 200));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
