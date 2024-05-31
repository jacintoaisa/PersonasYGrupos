namespace PersonasYGrupos.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public DateTime DOB { get; set; }
        public char Sex { get; set; }

        public override string ToString()
        {
            return $"ID: {ID} FName: {FName} LName: {LName} DOB: {DOB} Sex: {Sex}";
        }
    }
}
