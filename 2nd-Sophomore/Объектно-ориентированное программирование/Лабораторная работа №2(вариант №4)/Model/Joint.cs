namespace Model
{
    public class Joint : Product
    {
        public override string Info()
        {
            return "Weight: " + Weight.ToString();
        }

        public override string Info (int i, string content)
        {
            return "Producing company: " + Company;
        }

        public Joint(int weight, string serialNumber, string company, Detail detail)
            : base(weight, serialNumber, company, detail) { }
    }
}