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
	public partial class FlatButton : ContentView
	{
        public string Text
        {
            get => textLabel.Text;
            set => textLabel.Text = value;
        }

        public Color Color
        {
            get => backgroundFrame.BackgroundColor;
            set => backgroundFrame.BackgroundColor = value;
        }

        public float CornerRadius
        {
            get => backgroundFrame.CornerRadius;
            set => backgroundFrame.CornerRadius = value;
        }

        public FlatButton ()
		{
			InitializeComponent ();
		}
    }
}