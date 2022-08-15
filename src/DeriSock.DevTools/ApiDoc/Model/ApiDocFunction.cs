namespace DeriSock.DevTools.ApiDoc.Model;

using System.Text.Json.Serialization;

public enum ApiDocFunctionType
{
  Undefined, Method, Subscription
}

/// <summary>
///   For the lack of a better name, this is called <see cref="ApiDocFunction" />. It represents a method or subscription definition
/// </summary>
public class ApiDocFunction : IApiDocPropertyNode
{
  [JsonIgnore]
  IApiDocPropertyNode? IApiDocPropertyNode.Parent => null;

  [JsonIgnore]
  public ApiDocFunctionType FunctionType { get; set; } = ApiDocFunctionType.Undefined;

  /// <summary>
  ///   Gets the category of a method. This is always <c>null</c> on a subscription
  /// </summary>
  [JsonPropertyName("category")]
  public string? Category { get; set; } = null;

  /// <summary>
  ///   Gets, if the method is private and authentication is needed to use it. This is always false on a subscription
  /// </summary>
  [JsonIgnore]
  public bool IsPrivate => Name.StartsWith("private/");

  /// <summary>
  ///   <para>This is the methods or subscriptions name in the form of:</para>
  ///   <para>
  ///     Method: <c>public/name_of_method</c><br />
  ///     Subscription: <c>subscription_name.{param1}.{param2}</c>
  ///   </para>
  /// </summary>
  [JsonIgnore]
  public string Name { get; set; } = string.Empty;

  /// <summary>
  ///   This is the description of the method or subscription
  /// </summary>
  [JsonPropertyName("description")]
  public string Description { get; set; } = string.Empty;

  /// <summary>
  /// Gets, if this entry should not be included in interface generation
  /// </summary>
  [JsonPropertyName("excludeInInterface")]
  public bool ExcludeInInterface { get; set; }

  /// <summary>
  /// Gets, if this function is executed synchronously
  /// </summary>
  [JsonPropertyName("isSynchronous")]
  public bool IsSynchronous { get; set; }

  /// <summary>
  ///   Gets, if this entry
  /// </summary>
  [JsonPropertyName("deprecated")]
  public bool Deprecated { get; set; }

  /// <summary>
  ///   This contains the parameters for a method request or for subscribing to a subscription
  /// </summary>
  [JsonPropertyName("request")]
  public ApiDocProperty? Request { get; set; } = default;

  /// <summary>
  ///   This contains the content of the method responses result property or the subscription notifications data property
  /// </summary>
  [JsonPropertyName("response")]
  public ApiDocProperty? Response { get; set; } = default;

  [JsonIgnore]
  ApiDocPropertyCollection? IApiDocPropertyNode.Properties
  {
    get => ApiDocPropertyCollection.Empty;
    set { }
  }

  public void Accept(IApiDocDocumentVisitor visitor)
  {
    visitor.VisitFunction(this);
    Request?.Accept(visitor);
    Response?.Accept(visitor);
  }

  public void UpdateParent(IApiDocPropertyNode? parent)
  {
    if (Request != null) {
      Request.Name = "request";
      Request.UpdateParent(this);
    }

    if (Response != null) {
      Response.Name = "response";
      Response.UpdateParent(this);
    }
  }
}
