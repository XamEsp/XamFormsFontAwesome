using Xamarin.Forms;

namespace XamFormsFontAwesome
{
   public class FontAwesomeIcon : Label
   {
      //Must match the exact "Name" of the font which you can get by double clicking the TTF in Windows
      // Android
      // FontAwesome
      // IOS
      // FontAwesome5FreeSolid

      public static string Typeface => Device.RuntimePlatform == Device.Android ? "fa-solid-900" : "FontAwesome5FreeSolid";

      public FontAwesomeIcon()
      {
         FontFamily = Typeface;
      }

      public FontAwesomeIcon(string fontAwesomeIcon = null)
      {
         FontFamily = Typeface; //iOS is happy with this, Android needs a renderer to add ".ttf"
         Text = fontAwesomeIcon;
      }
   }
}