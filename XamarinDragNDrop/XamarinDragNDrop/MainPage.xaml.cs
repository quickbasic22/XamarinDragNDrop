using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDragNDrop
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            var label = (sender as Element).Parent as Label;


        }

        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            DropZone.Text = e.Data.GetTextAsync().Result;

        }

        private void DropGestureRecognizer_Drop_1(object sender, DropEventArgs e)
        {
            DropZone2.Text = e.Data.GetTextAsync().Result;
        }

        private void DragGestureRecognizer_DragStarting_1(object sender, DragStartingEventArgs e)
        {

        }
         
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            MyEntry.Text = "Hello World! Its currently " + DateTime.Now.ToLongDateString();
        }
    }
}
