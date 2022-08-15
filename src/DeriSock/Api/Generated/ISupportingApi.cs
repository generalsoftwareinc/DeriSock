// --------------------------------------------------------------------------
// <auto-generated>
//      This code was generated by a tool.
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------
#pragma warning disable CS1591
#nullable enable
namespace DeriSock.Api {
  using System.Threading.Tasks;
  using DeriSock.JsonRpc;
  using DeriSock.Model;
  using System;
  
  
  [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
  public partial interface ISupportingApi {
    
    /// <summary>
    /// <para>Retrieves the current time (in milliseconds). This API endpoint can be used to check the clock skew between your software and Deribit&apos;s systems.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DateTime?> PublicGetTime();
    
    /// <summary>
    /// <para>Method used to introduce the client software connected to Deribit platform over websocket. Provided data may have an impact on the maintained connection and will be collected for internal statistical purposes. In response, Deribit will also introduce itself.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicHelloResponse>> PublicHello(PublicHelloRequest args);
    
    /// <summary>
    /// <para>Method used to get information about locked currencies</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicStatusResponse>> PublicStatus();
    
    /// <summary>
    /// <para>Tests the connection to the API server, and returns its version. You can use this to make sure the API is reachable, and matches the expected version.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicTestResponse>> PublicTest(PublicTestRequest? args);
  }
}
