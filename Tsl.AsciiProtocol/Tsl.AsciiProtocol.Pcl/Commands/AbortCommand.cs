﻿// Decompiled with JetBrains decompiler
// Type: TechnologySolutions.Rfid.AsciiProtocol.Commands.AbortCommand
// Assembly: TechnologySolutions.Rfid.AsciiProtocol.FX35, Version=1.1.5423.27429, Culture=neutral, PublicKeyToken=null
// MVID: 9C1072D5-BA32-4CFB-BB8E-6AC565EFDF12
// Assembly location: F:\Visual Studio\Repositories\IlukaOreSampleTracking\lib\Ascii 2 Windows\TechnologySolutions.Rfid.AsciiProtocol.FX35.dll

namespace PortableAscii2.Commands
{
  /// <summary>
  /// A command to terminate the current command and any pending commands.
  ///             It also stops any software switch presses that are in progress.
  /// 
  /// </summary>
  public class AbortCommand : AsciiCommandBase
  {
    /// <summary>
    /// Initializes a new instance of the AbortCommand class with the specified responder
    /// 
    /// </summary>
    public AbortCommand()
      : base(".ab")
    {
    }
  }
}
