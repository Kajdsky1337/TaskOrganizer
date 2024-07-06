using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.DataAccess.Models;

namespace TaskMaster.DataAccess
{
    public class Repository
    {
        List<Employee> Employees { get; set; }
        List<TaskForEmployee> TasksForEmployees { get; set; }
       
        public List<Employee> GetEmployees()
        {

            return Employees;

        }
        public List<TaskForEmployee> GetTasks()
        {
            return TasksForEmployees;
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void AddTask(TaskForEmployee task)
        {
            TasksForEmployees.Add(task);
        }
    }
}
