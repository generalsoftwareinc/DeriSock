﻿namespace DeriSock.Model;

public enum ComboType
{
  Undefined,
  FutureSpread,
  CallSpread,
  PutSpread,
  Straddle,
  Strangle,
  StrangleItm,
  RiskReversal,
  RiskReversalItm,
  CallCalendarSpread,
  PutCalendarSpread,
  CallDiagonalCalendar,
  PutDiagonalCalendar,
  StraddleCalendar,
  StraddleCalendarDiagonal,
  ReversalConversion,
  CallButterfly,
  PutButterfly,
  IronButterfly,
  SkinnyCallButterfly,
  SkinnyPutButterfly,
  CallLadder,
  PutLadder,
  CallCondor,
  PutCondor,
  IronCondor,
  Box,
  JellyRoll,
  PutRatioSpread1x3,
  CallRatioSpread1x2,
  CallRatioSpread1x3,
  CallRatioSpread2s3,
  PutRatioSpread1x2,
  PutRatioSpread2x3
}
