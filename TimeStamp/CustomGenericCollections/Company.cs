namespace CustomGenericCollections
{
    public class Company
    {
        public Company()
        {
            this.Trainings = new Trainings();
        }

        public Trainings Trainings { get; set; }

    } 
}
