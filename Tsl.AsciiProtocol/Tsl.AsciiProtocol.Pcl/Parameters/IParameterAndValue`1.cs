﻿// Decompiled with JetBrains decompiler
// Type: TechnologySolutions.Rfid.AsciiProtocol.Parameters.IParameterAndValue`1
// Assembly: TechnologySolutions.Rfid.AsciiProtocol.FX35, Version=1.1.5423.27429, Culture=neutral, PublicKeyToken=null
// MVID: 9C1072D5-BA32-4CFB-BB8E-6AC565EFDF12
// Assembly location: F:\Visual Studio\Repositories\IlukaOreSampleTracking\lib\Ascii 2 Windows\TechnologySolutions.Rfid.AsciiProtocol.FX35.dll

namespace Tsl.AsciiProtocol.Pcl.Parameters
{
  /// <summary>
  /// Defines a command line parameter for a command with a type specific value
  /// 
  /// </summary>
  /// <typeparam name="TParameter">The type of the parameters value</typeparam>
  public interface IParameterAndValue<TParameter> : IParameterValue<TParameter>, ICommandParameter, IParameterAction
  {
  }
}
