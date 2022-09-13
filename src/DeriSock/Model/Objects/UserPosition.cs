using Newtonsoft.Json;

namespace DeriSock.Model
{
  public partial class UserPosition
  {
    /// <summary>
    ///   Underlying currency
    /// </summary>
    [JsonIgnore]
    public string Label { get; set; }
  }
}
