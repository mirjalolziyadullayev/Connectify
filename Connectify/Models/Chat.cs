using Newtonsoft.Json;
using System.Diagnostics.Metrics;
using System.Text.Json.Serialization;

namespace Connectify.Models;
public class Chat
{

    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("user1_id")]
    public int User1_id { get; set; }
    [JsonProperty("user2_id")]
    public int User2_id { get; set; }
    [JsonProperty("messages")]
    List<Message> Messages { get; set; }
}
