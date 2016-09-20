using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FormsGallery
{
    public partial class MasterDetailPageDemoXamlPage : MasterDetailPage
    {
        public MasterDetailPageDemoXamlPage()
        {
            InitializeComponent();

            // Assemble an array of NamedColor objects.
            NamedColor[] namedColors = {
                new NamedColor ("Aqua", Color.Aqua),
                new NamedColor ("Black", Color.Black),
                new NamedColor ("Blue", Color.Blue),
                new NamedColor ("Fuchsia", Color.Fuchsia),
                new NamedColor ("Gray", Color.Gray),
                new NamedColor ("Green", Color.Green),
                new NamedColor ("Lime", Color.Lime),
                new NamedColor ("Maroon", Color.Maroon),
                new NamedColor ("Navy", Color.Navy),
                new NamedColor ("Olive", Color.Olive),
                new NamedColor ("Purple", Color.Purple),
                new NamedColor ("Red", Color.Red),
                new NamedColor ("Silver", Color.Silver),
                new NamedColor ("Teal", Color.Teal),
                new NamedColor ("White", Color.White),
                new NamedColor ("Yellow", Color.Yellow)
            };

            listView.ItemsSource = namedColors;

            listView.ItemSelected += (sender, args) => {
                // Set the BindingContext of the detail page.
                this.Detail.BindingContext = args.SelectedItem;
                // Show the detail page.
                this.IsPresented = false;
            };

            // Initialize the ListView selection.
            listView.SelectedItem = namedColors[0];
        }
    }
}
