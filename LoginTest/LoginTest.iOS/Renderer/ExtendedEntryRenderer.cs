using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using LoginTest;
using LoginTest.CustomControls;
using LoginTest.iOS;
using LoginTest.iOS.Renderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace LoginTest.iOS.Renderer
{
    public class ExtendedEntryRenderer : EntryRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;
            }

        }

    }
}