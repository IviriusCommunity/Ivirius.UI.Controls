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
    public sealed class Card : Control
    {
        public Card()
        {
            this.DefaultStyleKey = typeof(Card);
        }

        public static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register(
        "Title", // The name of the property
        typeof(string), // The type of the property
        typeof(Card), // The type of the owner class
        new PropertyMetadata("Title") // Default value
        );

        [Browsable(true)]
        [Category("Common")]
        [Description("The title of the Card")]
        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public static readonly DependencyProperty SubtitleProperty =
        DependencyProperty.Register(
        "Subtitle", // The name of the property
        typeof(string), // The type of the property
        typeof(Card), // The type of the owner class
        new PropertyMetadata("Subtitle") // Default value
        );

        [Browsable(true)]
        [Category("Common")]
        [Description("The subtitle of the Card")]
        public string Subtitle
        {
            get
            {
                return (string)GetValue(SubtitleProperty);
            }
            set
            {
                SetValue(SubtitleProperty, value);
            }
        }

        public static readonly DependencyProperty ContentProperty =
        DependencyProperty.Register(
        "Content", // The name of the property
        typeof(string), // The type of the property
        typeof(Card), // The type of the owner class
        new PropertyMetadata("Content") // Default value
        );

        [Browsable(true)]
        [Category("Common")]
        [Description("The content of the Card")]
        public string Content
        {
            get
            {
                return (string)GetValue(ContentProperty);
            }
            set
            {
                SetValue(ContentProperty, value);
            }
        }
    }
}
