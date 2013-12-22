namespace ebcse
{
  class Kernel
  {
    unsafe static void Main()
    {
      *(byte*) (0xb8000) = (byte)'?';

      //libsupcs.OtherOperations.Halt();
      while (true) {
        // ...
      }
    }
  }
}
