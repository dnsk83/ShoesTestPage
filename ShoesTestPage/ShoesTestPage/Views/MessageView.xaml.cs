using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoesTestPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessageView : ContentView
	{
        public string Text
        {
            get => textLabel.Text;
            set => textLabel.Text = value;
        }

        public Color Color
        {
            get => backgroundFrame.BackgroundColor;
            set
            {
                backgroundFrame.BackgroundColor = value;
                cornerView.BackgroundColor = value;
            }
        }

        public Color TextColor
        {
            get => textLabel.TextColor;
            set => textLabel.TextColor = value;
        }

        public MessageView()
		{
			InitializeComponent ();
		}
    }
}