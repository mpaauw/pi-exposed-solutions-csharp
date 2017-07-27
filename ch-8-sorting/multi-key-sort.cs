public static void sortMultiKey(List<Employee> employeeArr)
{
    employeeArr.Sort();
}

public class Employee : IComparable<Employee>
{
    public string extension;
    public string givenname;
    public string surname;

    public int CompareTo(Employee other)
    {
        if (this.surname.CompareTo(other.surname) > 0)
        {
            return 1;
        }
        else if (this.surname.CompareTo(other.surname) == 0)
        {
            if (this.givenname.CompareTo(other.givenname) > 0)
            {
                return 1;
            }
            else if (this.givenname.CompareTo(other.givenname) == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        else
        {
            return -1;
        }
    }
}