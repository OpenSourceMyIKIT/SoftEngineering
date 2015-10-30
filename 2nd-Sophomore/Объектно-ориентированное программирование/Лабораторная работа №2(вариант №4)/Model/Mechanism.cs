namespace Model
{
    public class Mechanism : Product
    {
        public override string Info()
        {
            return null;
        }

        public override string Info(int i, string content)
        {
            if (content == "Info")
                return "Producing company: " + Mechanism.GetProduct(i).Company;
            else return "Number of details: " + Mechanism.GetProduct(i).DetailsCount.ToString();

        }

        public Mechanism(int weight, string serialNumber, string company, Detail detail)
            : base(weight, serialNumber, company, detail) { }
    }
}