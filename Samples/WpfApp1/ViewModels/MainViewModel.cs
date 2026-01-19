using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private ObservableCollection<Employee> _employees;
        private Employee _selectedEmployee;

        public ObservableCollection<Employee> Employees
        {
            get => _employees;
            set => SetProperty(ref _employees, value);
        }

        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set => SetProperty(ref _selectedEmployee, value);
        }

        public MainViewModel()
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            Employees = new ObservableCollection<Employee>
            {
                new Employee { Id = 1, Name = "John Smith", Department = "Engineering", Salary = 75000, HireDate = new DateTime(2020, 3, 15) },
                new Employee { Id = 2, Name = "Jane Doe", Department = "Marketing", Salary = 65000, HireDate = new DateTime(2021, 7, 22) },
                new Employee { Id = 3, Name = "Robert Johnson", Department = "Sales", Salary = 55000, HireDate = new DateTime(2019, 11, 5) },
                new Employee { Id = 4, Name = "Emily Wilson", Department = "Engineering", Salary = 82000, HireDate = new DateTime(2018, 5, 30) },
                new Employee { Id = 5, Name = "Michael Brown", Department = "HR", Salary = 60000, HireDate = new DateTime(2022, 1, 10) }
            };
        }
    }
}
