
namespace Mercado.Repository
{

    using Mercado.Interfaces;
    using Mercado.Models;
    using Microsoft.AspNetCore.Mvc;

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
                throw new Exception("Funciona o erro, agora vamos ver dos status");

                foreach (ICabin cabin in this.cabinList)
                {
                    Console.WriteLine(@$"The id of the cabin is {cabin.getId()}, and the number is {cabin.getNumber()}");
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
                ICabin? cabin = this.cabinList.Find(cabin => cabin.getId().Equals(id));
                if (cabin != null)
                {
                    Console.WriteLine($@"The cabin id is {cabin.getId()} and the number is {cabin.getNumber()}");
                    return cabin;
                }

                throw new Exception("Cabin not found");
            } catch (Exception)
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
                ICabin? cabinToDelete = this.cabinList.Find(cabin => cabin.getId().Equals(id));
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
                ICabin? cabinToUpdate = this.cabinList.Find(cabin => cabin.getId().Equals(cabinRequest.getId()));
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
