﻿// Decompiled with JetBrains decompiler
// Type: TechnologySolutions.Rfid.AsciiProtocol.IAsciiResponseResponder
// Assembly: TechnologySolutions.Rfid.AsciiProtocol.FX35, Version=1.1.5423.27429, Culture=neutral, PublicKeyToken=null
// MVID: 9C1072D5-BA32-4CFB-BB8E-6AC565EFDF12
// Assembly location: F:\Visual Studio\Repositories\IlukaOreSampleTracking\lib\Ascii 2 Windows\TechnologySolutions.Rfid.AsciiProtocol.FX35.dll

using System.Collections.Generic;

namespace Tsl.AsciiProtocol.Pcl
{
  /// <summary>
  /// Extends the <see cref="T:TechnologySolutions.Rfid.AsciiProtocol.IAsciiResponse"/> with the <see cref="T:TechnologySolutions.Rfid.AsciiProtocol.IAsciiResponder"/> event
  /// 
  /// </summary>
  public interface IAsciiResponseResponder : IAsciiResponse, IAsciiResponder
  {
    /// <summary>
    /// Gets the headers that are accepted as part of the response to this command
    /// 
    /// </summary>
    ICollection<string> AcceptedHeaders { get; }
  }
}
