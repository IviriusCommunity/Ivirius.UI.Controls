using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Ivirius.UI.Controls
{
    public sealed class ImageFrame : Control
    {
        public ImageFrame()
        {
            this.DefaultStyleKey = typeof(ImageFrame);
        }

        public static readonly DependencyProperty SourceProperty =
        DependencyProperty.Register(
        "Source", // The name of the property
        typeof(string), // The type of the property
        typeof(ImageFrame), // The type of the owner class
        new PropertyMetadata("Source") // Default value
        );

        [Browsable(true)]
        [Category("Common")]
        [Description("The source of the content of the ImageFrame")]
        public string Source
        {
            get { return (string)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
    }
}
