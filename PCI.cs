using System;
using System.Collections.Generic;
using libsupcs;

namespace ebcse
{
  /*  public class BAR
  {
    // TODO (can't you change bars...?)
  }

  public class GetUShortFun { }
  public class SetByteFun { }
  public class SetUShortFun { }
  /*public delegate ushort GetUShortFun();
  public delegate void SetByteFun(byte b);
  public delegate void SetUShortFun(ushort w);*//*

  public class PCIFunction
  {
    public ushort PCIBus { get; private set; }
    public ushort PCISlot { get; private set; }
    public ushort PCIFun { get; private set; }

    public ushort Vendor { get; private set; }
    public ushort Device { get; private set; }
    public ushort Class { get; private set; }
    public ushort Subclass { get; private set; }

    private SetByteFun setIrq;
    private byte lastIrq;
    public byte IRQ
    {
      get { return lastIrq; }
      set {
        lastIrq = value;
        //setIrq(value);
      }
    }

    public bool Multifunction { get; private set; }

    private GetUShortFun getFreshStatus;
    public ushort Status { get { return 0; } } //return getFreshStatus(); } }

    private SetUShortFun setCommand;
    private ushort lastCommand;
    public ushort Command
    { 
      get { return lastCommand; }
      set {
        lastCommand = value;
        //setCommand(value);
      }
    }

    public byte Subsys { get; private set; }
    public byte SubsysVen { get; private set; }

    public PCIFunction(ushort bus, ushort slot, ushort fun, ushort ven, ushort dev, ushort class_, ushort subclass,
      byte irq, SetByteFun setIrq, bool multifun, GetUShortFun getStatus, ushort cmd, SetUShortFun setCmd, byte subsys, byte subsysven)
    {
      this.PCIBus = bus;
      this.PCISlot = slot;
      this.PCIFun = fun;
      this.Vendor = ven;
      this.Device = dev;
      this.Class = class_;
      this.Subclass = subclass;
      this.lastIrq = irq;
      this.setIrq = setIrq;
      this.Multifunction = multifun;
      this.getFreshStatus = getStatus;
      this.lastCommand = cmd;
      this.setCommand = setCmd;
      this.Subsys = subsys;
      this.SubsysVen = subsysven;
    }

  }*/

  public class PCI
  {
    /*  private uint pcireadi(uint bus, uint slot, uint fun, uint offy)
    {
      uint addr = 0x80000000 | (bus << 16) | (slot << 11) | (fun << 8) | offy;
      IoOperations.PortOut(0xcf8, addr);
      return IoOperations.PortInd(0xcfc);
    }


    System.Collections.ArrayList funcs = new System.Collections.ArrayList();

    private void checkFun(ushort bus, ushort slot, ushort fun)
    {
      uint devven = pcireadi(bus, slot, fun, 0);

      if (devven == 0xffffffff)
        return;

      uint classes = pcireadi(bus, slot, fun, 0x8);
      uint bhlc = pcireadi(bus, slot, fun, 0xc);

      /*SetByteFun a = delegate(byte b) {
        devven += b;
      };
      GetUShortFun u = delegate() {
        return 0;
      };
      SetUShortFun c = delegate(ushort d) {
        devven += d;
      };*//*
      SetByteFun a = new SetByteFun();
      GetUShortFun u = new GetUShortFun();
      SetUShortFun c = new SetUShortFun();

      funcs.Add(new PCIFunction(0, 0, 0, 0, 0, 0, 0, 0, a, false, u, 120, c, (byte)devven, 0));

    }

    public PCI()
    {
      checkFun(0, 0, 0);
  }*/
  }
}

