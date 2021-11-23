using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Vp_mid_exam
{
    public class Customer
    {
        public string Name { get; set; }
    }

    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Customer> Customers { get; }
            = new ObservableCollection<Customer>();

        public MainPage()
        {
            this.InitializeComponent();
            // Add some customers
            this.Customers.Add(new Customer() { Name = "NAME: Ibrahim" });
            this.Customers.Add(new Customer() { Name = "NAME2: Ryaan" });
            this.Customers.Add(new Customer() { Name = "NAME3: Waleed" });
        }
    }


}
