using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;


namespace PDC03_MODULE02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity5 : ContentPage
    {

        ObservableCollection<employeee> employees = new ObservableCollection<employeee>();
        public ObservableCollection<employeee> Employees { get { return employees; } }
        public activity5()
        {
            InitializeComponent();

            {
                lst.ItemsSource = employees;

                employees.Add(new employeee { DisplayName = "Juan Dela Cruz", Position = "President", profileimage="volleyball.png" });
                employees.Add(new employeee { DisplayName = "Peter", Position = "Vice President" });
                employees.Add(new employeee { DisplayName = "Mary", Position = "Secretary" });
            }
        }
    }
}