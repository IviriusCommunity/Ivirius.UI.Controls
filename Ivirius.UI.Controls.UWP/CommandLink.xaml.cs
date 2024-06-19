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
    public sealed partial class CommandLink : UserControl
    {
        public CommandLink()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register(
        "Title", // The name of the property
        typeof(string), // The type of the property
        typeof(CommandLink), // The type of the owner class
        new PropertyMetadata("Title", TitleChanged) // Default value
        );

        [Browsable(true)]
        [Category("Common")]
        [Description("The title of the CommandLink")]
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
            ((CommandLink)d).DetectTitleChange();
        }

        public void DetectTitleChange()
        {
            TitleTextBlock.Text = Title;
        }

        public static readonly DependencyProperty DescriptionProperty =
        DependencyProperty.Register(
        "Description", // The name of the property
        typeof(string), // The type of the property
        typeof(CommandLink), // The type of the owner class
        new PropertyMetadata("Description", DescriptionChanged) // Default value
        );

        [Browsable(true)]
        [Category("Common")]
        [Description("The description of the CommandLink")]
        public string Description
        {
            get
            {
                return (string)GetValue(DescriptionProperty);
            }
            set
            {
                SetValue(DescriptionProperty, value);
            }
        }

        private static void DescriptionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((CommandLink)d).DetectDescriptionChange();
        }

        public void DetectDescriptionChange()
        {
            DescriptionTextBlock.Text = Description;
        }
    }
}
