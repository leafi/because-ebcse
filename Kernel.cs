namespace ebcse
{
  class Kernel
  {
    [libsupcs.MethodAlias("__undefined_func")]
    [libsupcs.AlwaysCompile]
    static void UndefinedFunc(ulong address)
    {
      // TODO: report that an undefined function was called
      bad('u');
    }

    [libsupcs.MethodAlias("__cxa_pure_virtual")]
    [libsupcs.AlwaysCompile]
    static void CxaPureVirtual()
    {
      // TODO: report that a pure virtual function was called
      bad('V');
    }

    [libsupcs.MethodAlias("__display_halt")]
    [libsupcs.AlwaysCompile]
    static void DisplayHalt()
    {
      // TODO: report that the system is going to halt
      bad('h');
    }

    [libsupcs.MethodAlias("throw")]
    [libsupcs.AlwaysCompile]
    static void Throw(System.Exception e, libsupcs.TysosMethod m)
    {
      // TODO: OH GOD
      bad('E');
    }

    static ulong enb = 0x30000000;  // just a guess. should read the end symbol...

    [libsupcs.MethodAlias("gcmalloc")]
    [libsupcs.AlwaysCompile]
    static ulong Alloc(ulong size)
    {
      // and here comes a really, really shitty allocator
      ulong a = enb;
      enb += size;
      return a;
    }

    [libsupcs.MethodAlias("__get_cur_thread_id")]
    [libsupcs.AlwaysCompile]
    static int GetCurThreadId()  // used by monitors (like semaphores) 'n' stuff
    {
      bad('t');
      return 0;
    }

    [libsupcs.MethodAlias("__try_acquire")]
    [libsupcs.AlwaysCompile]
    static void TryAcquire() // TODO: check correct fun type!
    {
      bad('1');
    }

    [libsupcs.MethodAlias("__release")]
    [libsupcs.AlwaysCompile]
    static void Release() // TODO: check correct fun type!
    {
      bad('2');
    }

    static int next_obj_id = 0x1000;

    [libsupcs.MethodAlias("__get_new_obj_id")]
    [libsupcs.AlwaysCompile]
    static int GetNewObjId()
    {
      next_obj_id++;
      return next_obj_id;
    }

    [libsupcs.MethodAlias("jit_tm")]
    [libsupcs.AlwaysCompile]
    static System.IntPtr JitCompile(libsupcs.TysosMethod m)
    {
      bad('j');
      return System.IntPtr.Zero;
    }

    [libsupcs.MethodAlias("__mbstowcs")]
    [libsupcs.AlwaysCompile]
    static unsafe void MbsToWcs(char* dest, sbyte* src, int length)
    {
      // UGH... this looks like a string conversion function.
      // The implementation in TysOS just copies from one string to the other and has
      //  a warning saying that it won't work for anything other than ascii strings.
      bad('W');
    }

    private unsafe static void bad(char c)
    {
      *(byte*) (0xb8000) = (byte) '!';
      *(byte*) (0xb8002) = (byte) c;
      *(byte*) (0xb8004) = (byte) '!';
      libsupcs.OtherOperations.Halt();
    }

    unsafe static void Main()
    {
      *(byte*) (0xb8000) = (byte)'>';
      new PCI();

      //libsupcs.OtherOperations.Halt();
      while (true) {
        // ...
      }

      *(byte*) (0xb8000) = (byte) '<';
    }
  }
}
