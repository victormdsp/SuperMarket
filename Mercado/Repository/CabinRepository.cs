namespace Mercado.Repository
{
    using Mercado.Interfaces;
    using Mercado.Models;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Repository for Cabin.
    /// </summary>
    public class CabinRepository : ICabinRepository
    {
        // Fake data
        private List<ICabin> cabinList = new ()
        {
            new CabinModel("0", 1),
            new CabinModel("1", 2),
            new CabinModel("2", 3),
        };

        /// <inheritdoc/>
        public List<ICabin> GetAllCabins()
        {
            try
            {
                foreach (ICabin cabin in this.cabinList)
                {
                    Console.WriteLine(@$"The id of the cabin is {cabin.GetId()}, and the number is {cabin.GetNumber()}");
                }

                return this.cabinList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <inheritdoc/>
        public ICabin GetCabinById(string id)
        {
            try
            {
                ICabin? cabin = this.cabinList.Find(cabin => cabin.GetId().Equals(id));
                if (cabin != null)
                {
                    Console.WriteLine($@"The cabin id is {cabin.GetId()} and the number is {cabin.GetNumber()}");
                    return cabin;
                }

                throw new Exception("Cabin not found");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <inheritdoc/>
        public ICabin CreateCabin(ICabin cabin)
        {
            return cabin;
        }

        /// <inheritdoc/>
        public string DeleteCabin(string id)
        {
            try
            {
                ICabin? cabinToDelete = this.cabinList.Find(cabin => cabin.GetId().Equals(id));
                if (cabinToDelete != null)
                {
                    return "Cabin deleted";
                }

                throw new Exception("Cabin not found");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <inheritdoc/>
        public string UpdateCabin(ICabin cabinRequest)
        {
            try
            {
                ICabin? cabinToUpdate = this.cabinList.Find(cabin => cabin.GetId().Equals(cabinRequest.GetId()));
                if (cabinToUpdate != null)
                {
                    return "Cabin updated";
                }

                throw new Exception("Cabin not found");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
