using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DAndD
{
    public partial class FileDragDropZone : Control
    {
        static FileDragDropZone()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FileDragDropZone),
                new FrameworkPropertyMetadata(typeof(FileDragDropZone)));
        }

        public FileDragDropZone()
        {
            this.AllowDrop = true;
        }

        private static void OnButtonStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (FileDragDropZone)d;
            control.UpdateButtonStyle();
        }

        private void UpdateButtonStyle()
        {
            if (Template != null)
            {
                var button = Template.FindName("BrowseButton", this) as Button;
                if (button != null)
                {
                    if (ButtonStyle != null)
                    {
                        button.Style = ButtonStyle;
                    }
                    else
                    {
                        button.Style = button.Tag as Style ?? FindResource("DefaultDandDButtonStyle") as Style;
                    }
                }
            }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.Drop += FileDragDropZone_Drop;
            this.DragEnter += FileDragDropZone_DragEnter;
            this.DragLeave += FileDragDropZone_DragLeave;

            var browseButton = GetTemplateChild("BrowseButton") as Button;
            if (browseButton != null)
            {
                browseButton.Click += BrowseButton_Click;
            }
            UpdateButtonStyle();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string[] files = { openFileDialog.FileName };
                RaiseEvent(new RoutedEventArgs(FileDroppedEvent, files));
            }
        }

        private void FileDragDropZone_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                RaiseEvent(new RoutedEventArgs(FileDroppedEvent, files));
            }
            UpdateVisualState(normal: true);
        }

        private void FileDragDropZone_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Copy;
                UpdateVisualState(highlight: true);
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = true;
        }

        private void FileDragDropZone_DragLeave(object sender, DragEventArgs e)
        {
            UpdateVisualState(normal: true);
            e.Handled = true;
        }

        private void UpdateVisualState(bool normal = false, bool highlight = false)
        {
            var border = GetTemplateChild("DropZoneBorder") as Border;
            if (border != null)
            {
                if (normal)
                {
                    border.Background = BackgroundBrush;
                }
                else if (highlight)
                {
                    // Create a slightly lighter brush for highlight
                    if (BackgroundBrush is SolidColorBrush solidBrush)
                    {
                        Color baseColor = solidBrush.Color;
                        Color lighterColor = Color.FromRgb(
                            (byte)Math.Min(baseColor.R + 20, 255),
                            (byte)Math.Min(baseColor.G + 20, 255),
                            (byte)Math.Min(baseColor.B + 20, 255));
                        border.Background = new SolidColorBrush(lighterColor);
                    }
                }
            }
        }

        public static readonly RoutedEvent FileDroppedEvent =
            EventManager.RegisterRoutedEvent("FileDropped", RoutingStrategy.Bubble,
                typeof(RoutedEventHandler), typeof(FileDragDropZone));

        public event RoutedEventHandler FileDropped
        {
            add { AddHandler(FileDroppedEvent, value); }
            remove { RemoveHandler(FileDroppedEvent, value); }
        }
    }
}