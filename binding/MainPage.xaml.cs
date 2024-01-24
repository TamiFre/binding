using binding.Models;
namespace binding;
 public partial class MainPage : ContentPage
 {
    Student s;
   

        public MainPage()
        {
            s =new Student() {Name="Tami", Age=16 };
            this.BindingContext = s;
            InitializeComponent();
        }

    private void ChangeName(object sender, EventArgs e)
    {
        s.Name = "Ziv";
    }
}
