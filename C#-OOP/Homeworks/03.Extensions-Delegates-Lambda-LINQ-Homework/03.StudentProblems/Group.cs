namespace _03.StudentProblems
{
    public class Group
    {
        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        public Group(int grNum, string departName)
        {
            this.GroupNumber = grNum;
            this.DepartmentName = departName;
        }
    }
}
