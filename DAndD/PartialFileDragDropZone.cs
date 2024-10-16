using System.Windows.Media;
using System.Windows;
using MahApps.Metro.IconPacks;
using System.Windows.Controls;

namespace DAndD
{
    public partial class FileDragDropZone
    {
        public static readonly DependencyProperty BackgroundBrushProperty =
            DependencyProperty.Register("BackgroundBrush", typeof(Brush), typeof(FileDragDropZone),
                new PropertyMetadata(new SolidColorBrush(Color.FromRgb(87, 85, 217))));

        public Brush BackgroundBrush
        {
            get { return (Brush)GetValue(BackgroundBrushProperty); }
            set { SetValue(BackgroundBrushProperty, value); }
        }

        public static readonly DependencyProperty TextBrushProperty =
            DependencyProperty.Register("TextBrush", typeof(Brush), typeof(FileDragDropZone),
                new PropertyMetadata(Brushes.White));

        public Brush TextBrush
        {
            get { return (Brush)GetValue(TextBrushProperty); }
            set { SetValue(TextBrushProperty, value); }
        }

        public static readonly DependencyProperty ButtonBackgroundBrushProperty =
            DependencyProperty.Register("ButtonBackgroundBrush", typeof(Brush), typeof(FileDragDropZone),
                new PropertyMetadata(Brushes.White));

        public Brush ButtonBackgroundBrush
        {
            get { return (Brush)GetValue(ButtonBackgroundBrushProperty); }
            set { SetValue(ButtonBackgroundBrushProperty, value); }
        }

        public static readonly DependencyProperty ButtonTextBrushProperty =
            DependencyProperty.Register("ButtonTextBrush", typeof(Brush), typeof(FileDragDropZone),
                new PropertyMetadata(new SolidColorBrush(Color.FromRgb(87, 85, 217))));

        public Brush ButtonTextBrush
        {
            get { return (Brush)GetValue(ButtonTextBrushProperty); }
            set { SetValue(ButtonTextBrushProperty, value); }
        }

        public static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.Register("BorderBrush", typeof(Brush), typeof(FileDragDropZone),
                new PropertyMetadata(Brushes.White));

        public Brush BorderBrush
        {
            get { return (Brush)GetValue(BorderBrushProperty); }
            set { SetValue(BorderBrushProperty, value); }
        }

        public static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.Register("BorderThickness", typeof(double), typeof(FileDragDropZone),
                new PropertyMetadata(2.0));

        public double BorderThickness
        {
            get { return (double)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty DashArrayProperty =
            DependencyProperty.Register("DashArray", typeof(DoubleCollection), typeof(FileDragDropZone),
                new PropertyMetadata(new DoubleCollection { 4, 4 }));

        public DoubleCollection DashArray
        {
            get { return (DoubleCollection)GetValue(DashArrayProperty); }
            set { SetValue(DashArrayProperty, value); }
        }

        public static readonly DependencyProperty IconBrushProperty =
            DependencyProperty.Register("IconBrush", typeof(Brush), typeof(FileDragDropZone),
                new PropertyMetadata(Brushes.White));

        public Brush IconBrush
        {
            get { return (Brush)GetValue(IconBrushProperty); }
            set { SetValue(IconBrushProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(FileDragDropZone),
                new PropertyMetadata(new CornerRadius(25)));

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ButtonCornerRadiusProperty =
            DependencyProperty.Register("ButtonCornerRadius", typeof(CornerRadius), typeof(FileDragDropZone),
                new PropertyMetadata(new CornerRadius(20)));

        public CornerRadius ButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(ButtonCornerRadiusProperty); }
            set { SetValue(ButtonCornerRadiusProperty, value); }
        }



        public static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register("FontSize", typeof(double), typeof(FileDragDropZone),
                new PropertyMetadata(16.0));

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public static readonly DependencyProperty FontFamilyProperty =
            DependencyProperty.Register("FontFamily", typeof(FontFamily), typeof(FileDragDropZone),
                new PropertyMetadata(new FontFamily("Segoe UI")));

        public FontFamily FontFamily
        {
            get { return (FontFamily)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        public static readonly DependencyProperty FontWeightProperty =
            DependencyProperty.Register("FontWeight", typeof(FontWeight), typeof(FileDragDropZone),
                new PropertyMetadata(FontWeights.Normal));

        public FontWeight FontWeight
        {
            get { return (FontWeight)GetValue(FontWeightProperty); }
            set { SetValue(FontWeightProperty, value); }
        }

        // You might want to add a separate property for the "OR" text, as it's typically smaller
        public static readonly DependencyProperty SmallFontSizeProperty =
            DependencyProperty.Register("SmallFontSize", typeof(double), typeof(FileDragDropZone),
                new PropertyMetadata(14.0));

        public double SmallFontSize
        {
            get { return (double)GetValue(SmallFontSizeProperty); }
            set { SetValue(SmallFontSizeProperty, value); }
        }

        public static readonly DependencyProperty ControlWidthProperty =
            DependencyProperty.Register("ControlWidth", typeof(double), typeof(FileDragDropZone),
                new PropertyMetadata(300.0));

        public double ControlWidth
        {
            get { return (double)GetValue(ControlWidthProperty); }
            set { SetValue(ControlWidthProperty, value); }
        }

        public static readonly DependencyProperty ControlHeightProperty =
            DependencyProperty.Register("ControlHeight", typeof(double), typeof(FileDragDropZone),
                new PropertyMetadata(200.0));

        public double ControlHeight
        {
            get { return (double)GetValue(ControlHeightProperty); }
            set { SetValue(ControlHeightProperty, value); }
        }


        public static readonly DependencyProperty InsetProperty =
            DependencyProperty.Register("Inset", typeof(double), typeof(FileDragDropZone),
                new PropertyMetadata(5.0));

        public double Inset
        {
            get { return (double)GetValue(InsetProperty); }
            set { SetValue(InsetProperty, value); }
        }

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(FileDragDropZone),
                new PropertyMetadata(48.0));


        public static readonly DependencyProperty IconKindProperty =
            DependencyProperty.Register("IconKind", typeof(PackIconMaterialKind), typeof(FileDragDropZone),
                new PropertyMetadata(PackIconMaterialKind.CloudUpload));

        public PackIconMaterialKind IconKind
        {
            get { return (PackIconMaterialKind)GetValue(IconKindProperty); }
            set { SetValue(IconKindProperty, value); }
        }

        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(FileDragDropZone),
                new PropertyMetadata(48.0));

        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }


        public static readonly DependencyProperty MainTextMarginProperty =
            DependencyProperty.Register("MainTextMargin", typeof(Thickness), typeof(FileDragDropZone),
                new PropertyMetadata(new Thickness(0, 10, 0, 5)));

        public Thickness MainTextMargin
        {
            get { return (Thickness)GetValue(MainTextMarginProperty); }
            set { SetValue(MainTextMarginProperty, value); }
        }

        public static readonly DependencyProperty OrTextMarginProperty =
            DependencyProperty.Register("OrTextMargin", typeof(Thickness), typeof(FileDragDropZone),
                new PropertyMetadata(new Thickness(0, 5, 0, 10)));

        public Thickness OrTextMargin
        {
            get { return (Thickness)GetValue(OrTextMarginProperty); }
            set { SetValue(OrTextMarginProperty, value); }
        }

        public static readonly DependencyProperty BrowseButtonPaddingProperty =
            DependencyProperty.Register("BrowseButtonPadding", typeof(Thickness), typeof(FileDragDropZone),
                new PropertyMetadata(new Thickness(20, 10, 20, 10)));

        public Thickness BrowseButtonPadding
        {
            get { return (Thickness)GetValue(BrowseButtonPaddingProperty); }
            set { SetValue(BrowseButtonPaddingProperty, value); }
        }

        public static readonly DependencyProperty ButtonBorderThicknessProperty =
            DependencyProperty.Register("ButtonBorderThickness", typeof(Thickness), typeof(FileDragDropZone),
                new PropertyMetadata(new Thickness(2)));

        public Thickness ButtonBorderThickness
        {
            get { return (Thickness)GetValue(ButtonBorderThicknessProperty); }
            set { SetValue(ButtonBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ButtonBorderBrushProperty =
            DependencyProperty.Register("ButtonBorderBrush", typeof(Brush), typeof(FileDragDropZone),
                new PropertyMetadata(Brushes.White));

        public Brush ButtonBorderBrush
        {
            get { return (Brush)GetValue(ButtonBorderBrushProperty); }
            set { SetValue(ButtonBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ButtonMouseOverBorderBrushProperty =
            DependencyProperty.Register("ButtonMouseOverBorderBrush", typeof(Brush), typeof(FileDragDropZone),
                new PropertyMetadata(Brushes.LightGray));

        public Brush ButtonMouseOverBorderBrush
        {
            get { return (Brush)GetValue(ButtonMouseOverBorderBrushProperty); }
            set { SetValue(ButtonMouseOverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ButtonHeightProperty =
            DependencyProperty.Register("ButtonHeight", typeof(double), typeof(FileDragDropZone),
                new PropertyMetadata(double.NaN)); // NaN means auto-size

        public double ButtonHeight
        {
            get { return (double)GetValue(ButtonHeightProperty); }
            set { SetValue(ButtonHeightProperty, value); }
        }


        public static readonly DependencyProperty ButtonStyleProperty =
            DependencyProperty.Register("ButtonStyle", typeof(Style), typeof(FileDragDropZone),
                new PropertyMetadata(null, OnButtonStyleChanged));

        public Style ButtonStyle
        {
            get { return (Style)GetValue(ButtonStyleProperty); }
            set { SetValue(ButtonStyleProperty, value); }
        }
    }
}