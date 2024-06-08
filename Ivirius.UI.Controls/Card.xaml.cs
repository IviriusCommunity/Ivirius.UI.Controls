using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Ivirius.UI.Controls
{
    public sealed partial class Card : UserControl
    {
        public Card()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register(
        "Title", // The name of the property
        typeof(string), // The type of the property
        typeof(Card), // The type of the owner class
        new PropertyMetadata("Title", TitleChanged) // Default value
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

        private static void TitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Card)d).DetectTitleChange();
        }

        public void DetectTitleChange()
        {
            TitleTextBlock.Text = Title;
        }

        public static readonly DependencyProperty ContentProperty =
        DependencyProperty.Register(
        "Content", // The name of the property
        typeof(string), // The type of the property
        typeof(Card), // The type of the owner class
        new PropertyMetadata("Content", ContentChanged) // Default value
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

        private static void ContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Card)d).DetectContentChange();
        }

        public void DetectContentChange()
        {
            TitleTextBlock.Text = Title;
        }

        public static readonly DependencyProperty SubtitleProperty =
        DependencyProperty.Register(
        "Subtitle", // The name of the property
        typeof(string), // The type of the property
        typeof(Card), // The type of the owner class
        new PropertyMetadata("Subtitle", SubtitleChanged) // Default value
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

        private static void SubtitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Card)d).DetectSubtitleChange();
        }

        public void DetectSubtitleChange()
        {
            SubtitleTextBlock.Text = Subtitle;
        }
    }
}
