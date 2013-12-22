[bits 64]

global sthrow
global twothrow

sthrow:
  hlt
  jmp sthrow


twothrow:
  jmp twothrow