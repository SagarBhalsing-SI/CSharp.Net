namespace CollectionDemo
{
    internal class EmployeeCompare : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            int result = 0;
            if (x != null && y != null) { result = 0; }
            if (x is null) { result = 1; }
            if (y is null) { result = -1; }

            if (x.salary == y.salary) { result = 0; }
            if (x.salary > y.salary) { result = -1; }
            if (x.salary > y.salary) { result = -1; };
            return result;
        }
    }
}   