﻿
namespace Mercado.Interfaces
{
    using Mercado.Models;

    /// <summary>
    /// Interface for CabinModel.
    /// </summary>
    public interface ICabin
    {
        /// <summary>
        /// Get the id of a cabin.
        /// </summary>
        /// <returns>The id of a cabin.</returns>
        string GetId();

        /// <summary>
        /// Set a new id for a Cabin.
        /// </summary>
        /// <param name="id">New Id for the cabin.</param>
        void SetId(string id);

        /// <summary>
        /// Get the number of a cabin.
        /// </summary>
        /// <returns>The number of the cabin.</returns>
        int GetNumber();

        /// <summary>
        /// Set a new number for a cabin.
        /// </summary>
        /// <param name="number">New number for the cabin.</param>
        void SetNumber(int number);
    }
}
