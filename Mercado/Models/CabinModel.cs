
namespace Mercado.Models
{
    using Mercado.Interfaces;
    using System.ComponentModel.DataAnnotations;
    
    /// <summary>
    /// CabinModel.
    /// </summary>
    public class CabinModel: ICabin
    {
        [Required]
        private string Id { get; set; }

        [Required]
        private int Number { get; set; }

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
