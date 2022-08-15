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
  public partial interface ITradingApi {
    
    /// <summary>
    /// <para>Places a buy order for an instrument.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateBuyResponse>> PrivateBuy(PrivateBuyRequest args);
    
    /// <summary>
    /// <para>Places a sell order for an instrument.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateSellResponse>> PrivateSell(PrivateSellRequest args);
    
    /// <summary>
    /// <para>Change price, amount and/or other properties of an order.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateEditResponse>> PrivateEdit(PrivateEditRequest args);
    
    /// <summary>
    /// <para>Change price, amount and/or other properties of an order with given label. It works only when there is one open order with this label</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateEditByLabelResponse>> PrivateEditByLabel(PrivateEditByLabelRequest args);
    
    /// <summary>
    /// <para>Cancel an order, specified by order id</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateCancelResponse>> PrivateCancel(PrivateCancelRequest args);
    
    /// <summary>
    /// <para>This method cancels all users orders and trigger orders within all currencies and instrument kinds.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<System.Decimal?> PrivateCancelAll(PrivateCancelAllRequest? args);
    
    /// <summary>
    /// <para>Cancels all orders by currency, optionally filtered by instrument kind and/or order type.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<System.Decimal?> PrivateCancelAllByCurrency(PrivateCancelAllByCurrencyRequest args);
    
    /// <summary>
    /// <para>Cancels all orders by instrument, optionally filtered by order type.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<System.Decimal?> PrivateCancelAllByInstrument(PrivateCancelAllByInstrumentRequest args);
    
    /// <summary>
    /// <para>Cancels orders by label. All user&apos;s orders (trigger orders too), with given label are canceled in all currencies or in one given currency (in this case currency queue is used)</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<System.Decimal?> PrivateCancelByLabel(PrivateCancelByLabelRequest args);
    
    /// <summary>
    /// <para>Makes closing position reduce only order .</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateClosePositionResponse>> PrivateClosePosition(PrivateClosePositionRequest args);
    
    /// <summary>
    /// <para>Get margins for given instrument, amount and price.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetMarginsResponse>> PrivateGetMargins(PrivateGetMarginsRequest args);
    
    /// <summary>
    /// <para>Get current config for MMP</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetMmpConfigResponse>> PrivateGetMmpConfig(PrivateGetMmpConfigRequest args);
    
    /// <summary>
    /// <para>Retrieves list of user&apos;s open orders.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetOpenOrdersByCurrencyResponse>> PrivateGetOpenOrdersByCurrency(PrivateGetOpenOrdersByCurrencyRequest args);
    
    /// <summary>
    /// <para>Retrieves list of user&apos;s open orders within given Instrument.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetOpenOrdersByInstrumentResponse>> PrivateGetOpenOrdersByInstrument(PrivateGetOpenOrdersByInstrumentRequest args);
    
    /// <summary>
    /// <para>Retrieves history of orders that have been partially or fully filled.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetOrderHistoryByCurrencyResponse>> PrivateGetOrderHistoryByCurrency(PrivateGetOrderHistoryByCurrencyRequest args);
    
    /// <summary>
    /// <para>Retrieves history of orders that have been partially or fully filled.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetOrderHistoryByInstrumentResponse>> PrivateGetOrderHistoryByInstrument(PrivateGetOrderHistoryByInstrumentRequest args);
    
    /// <summary>
    /// <para>Retrieves initial margins of given orders</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetOrderMarginByIdsResponse>> PrivateGetOrderMarginByIds(PrivateGetOrderMarginByIdsRequest args);
    
    /// <summary>
    /// <para>Retrieve the current state of an order.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetOrderStateResponse>> PrivateGetOrderState(PrivateGetOrderStateRequest args);
    
    /// <summary>
    /// <para>Retrieves detailed log of the user&apos;s trigger orders.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetTriggerOrderHistoryResponse>> PrivateGetTriggerOrderHistory(PrivateGetTriggerOrderHistoryRequest args);
    
    /// <summary>
    /// <para>Retrieve the latest user trades that have occurred for instruments in a specific currency symbol.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetUserTradesByCurrencyResponse>> PrivateGetUserTradesByCurrency(PrivateGetUserTradesByCurrencyRequest args);
    
    /// <summary>
    /// <para>Retrieve the latest user trades that have occurred for instruments in a specific currency symbol and within given time range.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetUserTradesByCurrencyAndTimeResponse>> PrivateGetUserTradesByCurrencyAndTime(PrivateGetUserTradesByCurrencyAndTimeRequest args);
    
    /// <summary>
    /// <para>Retrieve the latest user trades that have occurred for a specific instrument.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetUserTradesByInstrumentResponse>> PrivateGetUserTradesByInstrument(PrivateGetUserTradesByInstrumentRequest args);
    
    /// <summary>
    /// <para>Retrieve the latest user trades that have occurred for a specific instrument and within given time range.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetUserTradesByInstrumentAndTimeResponse>> PrivateGetUserTradesByInstrumentAndTime(PrivateGetUserTradesByInstrumentAndTimeRequest args);
    
    /// <summary>
    /// <para>Retrieve the list of user trades that was created for given order</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetUserTradesByOrderResponse>> PrivateGetUserTradesByOrder(PrivateGetUserTradesByOrderRequest args);
    
    /// <summary>
    /// <para>Reset MMP</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<System.String?> PrivateResetMmp(PrivateResetMmpRequest args);
    
    /// <summary>
    /// <para>Sends RFQ on a given instrument.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<System.String?> PrivateSendRfq(PrivateSendRfqRequest args);
    
    /// <summary>
    /// <para>Set config for MMP - triggers MMP reset</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<System.String?> PrivateSetMmpConfig(PrivateSetMmpConfigRequest args);
    
    /// <summary>
    /// <para>Retrieves public settlement, delivery and bankruptcy events filtered by instrument name</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetSettlementHistoryByInstrumentResponse>> PrivateGetSettlementHistoryByInstrument(PrivateGetSettlementHistoryByInstrumentRequest args);
    
    /// <summary>
    /// <para>Retrieves settlement, delivery and bankruptcy events that have affected your account.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PrivateGetSettlementHistoryByCurrencyResponse>> PrivateGetSettlementHistoryByCurrency(PrivateGetSettlementHistoryByCurrencyRequest args);
  }
}
