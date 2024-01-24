using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace binding.Models
{
    public class Student: INotifyPropertyChanged
    {
        private string name;
        private int age;
        public string Name {  get => name;set { name = value; OnPropertychanged(); } }
        public int Age { get=>age; set { age = value; OnPropertychanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertychanged([CallerMemberName]string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
