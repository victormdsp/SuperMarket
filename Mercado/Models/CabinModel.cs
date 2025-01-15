namespace Mercado.Models
{
    public class CabinModel
    {
        private string Id { get; set; }
        private int Number { get; set; }

        
        public CabinModel(string id, int number)
        {
            this.Id = id;
            this.Number = number;
        }

        public string getId()
        {
            return this.Id;
        }

        public void setId(string id)
        {
            this.Id = id;
        }

        public int getNumber()
        {
            return this.Number;
        }

        public void setNumber(int number)
        {
            this.Number = number;
        }
    }
}
