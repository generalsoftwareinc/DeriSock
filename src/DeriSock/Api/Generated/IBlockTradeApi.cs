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
  
  
  [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
  public partial interface IBlockTradeApi {
    
    /// <summary>
    /// <para>Creates block trade</para>
    /// <para>The whole request have to be exact the same as in <c>private/verify_block_trade</c>, only role field should be set appropriately - it basically means that both sides have to agree on the same timestamp, nonce, trades fields and server will assure that role field is different between sides (each party accepted own role).</para>
    /// <para>Using the same timestamp and nonce by both sides in <c>private/verify_block_trade</c> assures that even if unintentionally both sides execute given block trade with valid counterparty_signature, the given block trade will be executed only once.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateExecuteBlockTradeResponse>> PrivateExecuteBlockTrade(PrivateExecuteBlockTradeRequest args);
    
    /// <summary>
    /// <para>Returns information about users block trade</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetBlockTradeResponse>> PrivateGetBlockTrade(PrivateGetBlockTradeRequest args);
    
    /// <summary>
    /// <para>Returns list of last users block trades</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetLastBlockTradesByCurrencyResponse>> PrivateGetLastBlockTradesByCurrency(PrivateGetLastBlockTradesByCurrencyRequest args);
    
    /// <summary>
    /// <para>User at any time (before the private/execute_block_trade is called) can invalidate its own signature effectively cancelling block trade</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<System.String?> PrivateInvalidateBlockTradeSignature(PrivateInvalidateBlockTradeSignatureRequest args);
    
    /// <summary>
    /// <para>Moves positions from source subaccount to target subaccount</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateMovePositionsResponse>> PrivateMovePositions(PrivateMovePositionsRequest args);
    
    /// <summary>
    /// <para>Verifies and creates block trade signature</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateVerifyBlockTradeResponse>> PrivateVerifyBlockTrade(PrivateVerifyBlockTradeRequest args);
  }
}
