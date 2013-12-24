[bits 64]

global sthrow
global __halt

sthrow:
  hlt
  jmp sthrow

 __halt:
  hlt
  jmp __halt


; cough cough, hack around the fact that my mono build is actually broken
; (tysila kept crashing on some function in System.Xml, so i hacked around the func.
;  i'd be careful before diving into system.xml usage in-OS if i were you...)
global _ZW10Mono#2EXml14SmallXmlParserM_0_15SkipWhitespaces_Rv_P2u1tb
global _ZW10Mono#2EXml14SmallXmlParserM_0_11ReadComment_Rv_P1u1t
global _ZW10Mono#2EXml14SmallXmlParserM_0_14ReadCharacters_Rv_P1u1t

_ZW10Mono#2EXml14SmallXmlParserM_0_15SkipWhitespaces_Rv_P2u1tb:
_ZW10Mono#2EXml14SmallXmlParserM_0_11ReadComment_Rv_P1u1t:
_ZW10Mono#2EXml14SmallXmlParserM_0_14ReadCharacters_Rv_P1u1t:
  jmp __halt
