using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    /// <summary>
    /// 3️⃣ الـ Composite
    /// وده العنصر اللي يحتوي عناصر تانية يعني الـ Department 👥
    /// </summary>
    public class Department : ICompanyComponent
    {
        private string _name;

        private List<ICompanyComponent> _members = new List<ICompanyComponent>();

        public Department(string name)
        {
            _name = name;
        }

        public void Add(ICompanyComponent component)
        {
            _members.Add(component);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Department: {_name}");

            foreach (var member in _members)
            {
                member.ShowDetails();
            }
        }
    }
}
