using DammyApp1.MVVM.Commands;
using DammyApp1.MVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DammyApp1.MVVM.ViewModel
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {

        public ICommand TextChangedCommand { get; set; }
        private string text1;

        public string Text1
        {
            get { return text1; }
            set 
            { text1 = value;
                OnPropertyChange("Text1");
            }
        }

        private string text2;

        public string Text2
        {
            get { return text1; }
            set 
            { 
                text1 = value;
                OnPropertyChange("Text2");
            }
        }
        private string text3;

        public string Text3
        {
            get { return text1; }
            set 
            { 
                text1 = value;
                OnPropertyChange("Text3");
            }
        }










        private string inputtext;

        public string InputText
        {
            get { return inputtext; }
            set { inputtext = value;
                OnPropertyChange("InputText");
                FilterTableList(value);
            }
        }

        private Teacher myVar2;

        public Teacher TeacherDetails
        {
            get { return myVar2; }
            set { myVar2 = value;
                OnPropertyChange("TeacherDetails");
            }
        }

        private void FilterTableList(string value)
        {
          
           List<Student> filteredStudentList = StudentList.Where(x => x.FirstName.Contains(value)).ToList();
            StudentList=filteredStudentList;
        }

        private List<Student> myVar;
        public List<Student> StudentList
        {
            get { return myVar; }
            set { myVar = value;
                OnPropertyChange("StudentList");
            }
        }

        public MainWindowViewModel()
        {
            TextChangedCommand = new RelayCommand(ExecuteMethod, CanExecute); 
            TeacherDetails = new Teacher("Teacher-1","Class-8th","Section A");
            StudentList = new List<Student>();

            StudentList.Add(new Student(1,"a","Kulkarni","Male",80.48));
            StudentList.Add(new Student(2, "z", "Kulkarni", "Male", 8.8));
            StudentList.Add(new Student(3, "b", "Kulkarni", "Male", 88));
        }

        public bool CanExecute( object parameter)
        {
            return true;
        }
        public void ExecuteMethod(object parameter)
        {

        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
