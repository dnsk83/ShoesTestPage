using ShoesTestPage.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(LightEntryRenderer))]

namespace ShoesTestPage.iOS.Renderers
{
    public class LightEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (this.Control == null) return;
            this.Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}
