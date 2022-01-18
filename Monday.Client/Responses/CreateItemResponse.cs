using Monday.Client.Models;
using Newtonsoft.Json;

namespace Monday.Client.Responses
{
    /// <summary>
    /// Describes the Monday response for a new Item request.
    /// </summary>
    public class CreateItemResponse
    {
        /// <summary>
        /// The item created.
        /// </summary>
        [JsonProperty("create_item")] public Item Item { get; set; }
    }
}