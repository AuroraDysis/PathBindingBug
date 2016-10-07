using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var circle = Parse("M 0,0 A 180,180 180 1 1 1,1 Z");
            this.Items = new List<TestItem>()
            {
                new TestItem() {Data = circle },
                new TestItem() {Data = circle },
                new TestItem() {Data = circle },
                new TestItem() {Data = circle },
            };
        }

        public List<TestItem> Items { get; set; }

        public static Geometry Parse(string data)
        {
            var sb = new StringBuilder();
            sb.Append("<Geometry xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>");
            sb.Append(data);
            sb.Append("</Geometry>");
            return (Geometry)XamlReader.Load(sb.ToString());
        }
    }

    public class TestItem
    {
        public Geometry Data { get; set; }
    }
}
