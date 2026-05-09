using System;

namespace DesignPatterns.Structural.Composite
{
    /// <summary>
    /// 2️⃣ الـ Leaf
    /// وده العنصر الفردي يعني الـ Employee 👨💻
    /// </summary>
    public class Employee : ICompanyComponent
    {
        private string _name;

        public Employee(string name)
        {
            _name = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Employee: {_name}");
        }
    }
}
