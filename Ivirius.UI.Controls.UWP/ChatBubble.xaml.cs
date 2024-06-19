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
    public sealed partial class ChatBubble : UserControl
    {
        public ChatBubble()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(
        "Text", // The name of the property
        typeof(string), // The type of the property
        typeof(ChatBubble), // The type of the owner class
        new PropertyMetadata("Text", TextChanged) // Default value
        );

        [Browsable(true)]
        [Category("Common")]
        [Description("The text in the ChatBubble")]
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        private static void TextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((ChatBubble)d).DetectTextChange();
        }

        public void DetectTextChange()
        {
            BubbleText.Text = Text;
        }
    }
}
