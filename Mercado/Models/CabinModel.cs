namespace Mercado.Models
{
    using System.ComponentModel.DataAnnotations;
    using Mercado.Interfaces;

    /// <summary>
    /// CabinModel.
    /// </summary>
    public class CabinModel : ICabin
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CabinModel"/> class.
        /// </summary>
        /// <param name="id">Id of Cabin.</param>
        /// <param name="number">Number of Cabin.</param>
        public CabinModel(string id, int number)
        {
            this.Id = id;
            this.Number = number;
        }

        [Required]
        private string Id { get; set; }

        [Required]
        private int Number { get; set; }

        /// <inheritdoc/>
        public string GetId()
        {
            return this.Id;
        }

        /// <inheritdoc/>
        public void SetId(string id)
        {
            this.Id = id;
        }

        /// <inheritdoc/>
        public int GetNumber()
        {
            return this.Number;
        }

        /// <inheritdoc/>
        public void SetNumber(int number)
        {
            this.Number = number;
        }
    }
}
