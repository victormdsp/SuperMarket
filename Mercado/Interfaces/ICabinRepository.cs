namespace Mercado.Interfaces
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Interface for the Cabin Repository.
    /// <summary>
    public interface ICabinRepository
    {

        /// <summary>
        /// List all Cabins.
        /// </summary>
        /// <returns>Return a list of Cabins.</returns>
        public List<ICabin> GetAllCabins();

        /// <summary>
        /// Get a cabin by Id.
        /// </summary>
        /// <param name="id">Id of the cabin.</param>
        /// <returns>Return one Cabin if find.</returns>
        public ICabin GetCabinById(string id);

        /// <summary>
        /// Create a new cabin in the system.
        /// </summary>
        /// <param name="cabin">Infos of the cabin</param>
        /// <returns>A message telling if the cabin was created</returns>
        public ICabin CreateCabin(ICabin cabin);

        /// <summary>
        /// Delete one cabin.
        /// </summary>
        /// <param name="id">Id of the cabin to be deleted</param>
        /// <returns>A message telling if the cabin was deletead</returns>
        public string DeleteCabin(string id);

        /// <summary>
        /// Update one cabin.
        /// </summary>
        /// <param name="cabin">Infos of the cabin to be changed.</param>
        /// <returns>A message telling ig the cabin was updated.</returns>
        public string UpdateCabin(ICabin cabin);
    }
}
