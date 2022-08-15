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
  public partial interface IMarketDataApi {
    
    /// <summary>
    /// <para>Retrieves the summary information such as open interest, 24h volume, etc. for all instruments for the currency (optionally filtered by kind).</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetBookSummaryByCurrencyResponse>> PublicGetBookSummaryByCurrency(PublicGetBookSummaryByCurrencyRequest args);
    
    /// <summary>
    /// <para>Retrieves the summary information such as open interest, 24h volume, etc. for a specific instrument.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetBookSummaryByInstrumentResponse>> PublicGetBookSummaryByInstrument(PublicGetBookSummaryByInstrumentRequest args);
    
    /// <summary>
    /// <para>Retrieves contract size of provided instrument.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetContractSizeResponse>> PublicGetContractSize(PublicGetContractSizeRequest args);
    
    /// <summary>
    /// <para>Retrieves all cryptocurrencies supported by the API.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetCurrenciesResponse>> PublicGetCurrencies();
    
    /// <summary>
    /// <para>Retrieves delivery prices for then given index</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetDeliveryPricesResponse>> PublicGetDeliveryPrices(PublicGetDeliveryPricesRequest args);
    
    /// <summary>
    /// <para>Retrieve the latest user trades that have occurred for PERPETUAL instruments in a specific currency symbol and within given time range.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetFundingChartDataResponse>> PublicGetFundingChartData(PublicGetFundingChartDataRequest args);
    
    /// <summary>
    /// <para>Retrieves hourly historical interest rate for requested PERPETUAL instrument.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetFundingRateHistoryResponse>> PublicGetFundingRateHistory(PublicGetFundingRateHistoryRequest args);
    
    /// <summary>
    /// <para>Retrieves interest rate value for requested period. Applicable only for PERPETUAL instruments.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<System.Double?>> PublicGetFundingRateValue(PublicGetFundingRateValueRequest args);
    
    /// <summary>
    /// <para>Provides information about historical volatility for given cryptocurrency.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<DeriSock.Model.TimestampValueItem[]?>> PublicGetHistoricalVolatility(PublicGetHistoricalVolatilityRequest args);
    
    /// <summary>
    /// <para>Retrieves the current index price for the instruments, for the selected currency.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetIndexResponse>> PublicGetIndex(PublicGetIndexRequest args);
    
    /// <summary>
    /// <para>Retrieves the current index price value for given index name.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetIndexPriceResponse>> PublicGetIndexPrice(PublicGetIndexPriceRequest args);
    
    /// <summary>
    /// <para>Retrieves the identifiers of all supported Price Indexes</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<System.String[]?>> PublicGetIndexPriceNames();
    
    /// <summary>
    /// <para>Retrieves information about instrument</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetInstrumentResponse>> PublicGetInstrument(PublicGetInstrumentRequest args);
    
    /// <summary>
    /// <para>Retrieves available trading instruments. This method can be used to see which instruments are available for trading, or which instruments have recently expired.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetInstrumentsResponse>> PublicGetInstruments(PublicGetInstrumentsRequest args);
    
    /// <summary>
    /// <para>Retrieves historical settlement, delivery and bankruptcy events coming from all instruments within given currency.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetLastSettlementsByCurrencyResponse>> PublicGetLastSettlementsByCurrency(PublicGetLastSettlementsByCurrencyRequest args);
    
    /// <summary>
    /// <para>Retrieves historical public settlement, delivery and bankruptcy events filtered by instrument name.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetLastSettlementsByInstrumentResponse>> PublicGetLastSettlementsByInstrument(PublicGetLastSettlementsByInstrumentRequest args);
    
    /// <summary>
    /// <para>Retrieve the latest trades that have occurred for instruments in a specific currency symbol.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetLastTradesByCurrencyResponse>> PublicGetLastTradesByCurrency(PublicGetLastTradesByCurrencyRequest args);
    
    /// <summary>
    /// <para>Retrieve the latest trades that have occurred for instruments in a specific currency symbol and within given time range.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetLastTradesByCurrencyAndTimeResponse>> PublicGetLastTradesByCurrencyAndTime(PublicGetLastTradesByCurrencyAndTimeRequest args);
    
    /// <summary>
    /// <para>Retrieve the latest trades that have occurred for a specific instrument.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetLastTradesByInstrumentResponse>> PublicGetLastTradesByInstrument(PublicGetLastTradesByInstrumentRequest args);
    
    /// <summary>
    /// <para>Retrieve the latest trades that have occurred for a specific instrument and within given time range.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetLastTradesByInstrumentAndTimeResponse>> PublicGetLastTradesByInstrumentAndTime(PublicGetLastTradesByInstrumentAndTimeRequest args);
    
    /// <summary>
    /// <para>Public request for 5min history of markprice values for the instrument. For now the markprice history is available only for a subset of options which take part in the volatility index calculations. All other instruments, futures and perpetuals will return empty list.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<DeriSock.Model.TimestampValueItem[]?>> PublicGetMarkPriceHistory(PublicGetMarkPriceHistoryRequest args);
    
    /// <summary>
    /// <para>Retrieves the order book, along with other market values for a given instrument.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetOrderBookResponse>> PublicGetOrderBook(PublicGetOrderBookRequest args);
    
    /// <summary>
    /// <para>Retrieves the order book, along with other market values for a given instrument ID.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetOrderBookByInstrumentIdResponse>> PublicGetOrderBookByInstrumentId(PublicGetOrderBookByInstrumentIdRequest args);
    
    /// <summary>
    /// <para>Retrieve active RFQs for instruments in given currency.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetRfqsResponse>> PublicGetRfqs(PublicGetRfqsRequest args);
    
    /// <summary>
    /// <para>Retrieves aggregated 24h trade volumes for different instrument types and currencies.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetTradeVolumesResponse>> PublicGetTradeVolumes(PublicGetTradeVolumesRequest? args);
    
    /// <summary>
    /// <para>Publicly available market data used to generate a TradingView candle chart.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetTradingviewChartDataResponse>> PublicGetTradingviewChartData(PublicGetTradingviewChartDataRequest args);
    
    /// <summary>
    /// <para>Public market data request for volatility index candles.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicGetVolatilityIndexDataResponse>> PublicGetVolatilityIndexData(PublicGetVolatilityIndexDataRequest args);
    
    /// <summary>
    /// <para>Get ticker for an instrument.</para>
    /// </summary>
    /// <param name="args"></param>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
    System.Threading.Tasks.Task<DeriSock.JsonRpc.JsonRpcResponse<PublicTickerResponse>> PublicTicker(PublicTickerRequest args);
  }
}
