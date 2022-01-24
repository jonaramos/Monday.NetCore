using System.Collections.Generic;
using Monday.Client.Models;

namespace Monday.Client.Responses
{
    /// <summary>
    /// Describes a response for a Get Items Request.
    /// </summary>
    public class GetItemsResponse
    {
        /// <summary>
        /// A collection of items returned by Monday.
        /// </summary>
        public List<Item> Items { get; set; }
    }
}