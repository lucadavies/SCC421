.class private auto ansi '<Module>'
{
} // end of class <Module>

.class private auto ansi beforefieldinit Adv
    extends [System.Private.CoreLib]System.Object
{
    // Nested Types
    .class nested private auto ansi sealed serializable beforefieldinit '<>c'
        extends [System.Private.CoreLib]System.Object
    {
        .custom instance void [System.Private.CoreLib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
            01 00 00 00
        )
        // Fields
        .field public static initonly class Adv/'<>c' '<>9'
        .field public static class [System.Private.CoreLib]System.Action`1<string> '<>9__1_0'

        // Methods
        .method private hidebysig specialname rtspecialname static 
            void .cctor () cil managed 
        {
            // Method begins at RVA 0x21cd
            // Code size 11 (0xb)
            .maxstack 8

            IL_0000: newobj instance void Adv/'<>c'::.ctor()
            IL_0005: stsfld class Adv/'<>c' Adv/'<>c'::'<>9'
            IL_000a: ret
        } // end of method '<>c'::.cctor

        .method public hidebysig specialname rtspecialname 
            instance void .ctor () cil managed 
        {
            // Method begins at RVA 0x21b4
            // Code size 7 (0x7)
            .maxstack 8

            IL_0000: ldarg.0
            IL_0001: call instance void [System.Private.CoreLib]System.Object::.ctor()
            IL_0006: ret
        } // end of method '<>c'::.ctor

        .method assembly hidebysig 
            instance void '<lambdaAdv>b__1_0' (
                string s
            ) cil managed 
        {
            // Method begins at RVA 0x21d9
            // Code size 22 (0x16)
            .maxstack 8

            IL_0000: ldstr "Hello "
            IL_0005: ldarg.1
            IL_0006: ldstr "!"
            IL_000b: call string [System.Private.CoreLib]System.String::Concat(string, string, string)
            IL_0010: call void [System.Console]System.Console::WriteLine(string)
            IL_0015: ret
        } // end of method '<>c'::'<lambdaAdv>b__1_0'

    } // end of class <>c


    // Methods
    .method private hidebysig static 
        string ternaryAdv (
            float64 temp
        ) cil managed 
    {
        // Method begins at RVA 0x2050
        // Code size 24 (0x18)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: ldc.r8 20
        IL_000a: blt.s IL_0012

        IL_000c: ldstr "Perfect!"
        IL_0011: ret

        IL_0012: ldstr "Cold."
        IL_0017: ret
    } // end of method Adv::ternaryAdv

    .method private hidebysig static 
        void lambdaAdv (
            string name
        ) cil managed 
    {
        // Method begins at RVA 0x2069
        // Code size 38 (0x26)
        .maxstack 8

        IL_0000: ldsfld class [System.Private.CoreLib]System.Action`1<string> Adv/'<>c'::'<>9__1_0'
        IL_0005: dup
        IL_0006: brtrue.s IL_001f

        IL_0008: pop
        IL_0009: ldsfld class Adv/'<>c' Adv/'<>c'::'<>9'
        IL_000e: ldftn instance void Adv/'<>c'::'<lambdaAdv>b__1_0'(string)
        IL_0014: newobj instance void class [System.Private.CoreLib]System.Action`1<string>::.ctor(object, native int)
        IL_0019: dup
        IL_001a: stsfld class [System.Private.CoreLib]System.Action`1<string> Adv/'<>c'::'<>9__1_0'

        IL_001f: ldarg.0
        IL_0020: callvirt instance void class [System.Private.CoreLib]System.Action`1<string>::Invoke(!0)
        IL_0025: ret
    } // end of method Adv::lambdaAdv

    .method private hidebysig static 
        void nullCoalesceAdv () cil managed 
    {
        // Method begins at RVA 0x2090
        // Code size 16 (0x10)
        .maxstack 8

        IL_0000: ldnull
        IL_0001: dup
        IL_0002: brtrue.s IL_000a

        IL_0004: pop
        IL_0005: newobj instance void Person::.ctor()

        IL_000a: call void [System.Console]System.Console::WriteLine(object)
        IL_000f: ret
    } // end of method Adv::nullCoalesceAdv

    .method private hidebysig static 
        void nullConditionalAdv () cil managed 
    {
        // Method begins at RVA 0x20a1
        // Code size 23 (0x17)
        .maxstack 8

        IL_0000: newobj instance void Person::.ctor()
        IL_0005: dup
        IL_0006: brtrue.s IL_000c

        IL_0008: pop
        IL_0009: ldnull
        IL_000a: br.s IL_0011

        IL_000c: call instance string Person::get_firstName()

        IL_0011: call void [System.Console]System.Console::WriteLine(string)
        IL_0016: ret
    } // end of method Adv::nullConditionalAdv

    .method private hidebysig static 
        void incrDecrAdv () cil managed 
    {
        // Method begins at RVA 0x20bc
        // Code size 35 (0x23)
        .maxstack 3
        .locals init (
            [0] int32 x,
            [1] int32 y
        )

        IL_0000: ldc.i4.0
        IL_0001: stloc.0
        IL_0002: ldc.i4.0
        IL_0003: stloc.1
        IL_0004: ldc.i4.3
        IL_0005: stloc.0
        IL_0006: ldloc.0
        IL_0007: dup
        IL_0008: ldc.i4.1
        IL_0009: add
        IL_000a: stloc.0
        IL_000b: stloc.1
        IL_000c: ldloc.0
        IL_000d: ldc.i4.1
        IL_000e: add
        IL_000f: dup
        IL_0010: stloc.0
        IL_0011: ldloc.0
        IL_0012: call void [System.Console]System.Console::WriteLine(int32)
        IL_0017: ldloc.1
        IL_0018: call void [System.Console]System.Console::WriteLine(int32)
        IL_001d: call void [System.Console]System.Console::WriteLine(int32)
        IL_0022: ret
    } // end of method Adv::incrDecrAdv

    .method private hidebysig static 
        void compoundAssignAdv () cil managed 
    {
        // Method begins at RVA 0x20eb
        // Code size 9 (0x9)
        .maxstack 8

        IL_0000: ldc.i4.2
        IL_0001: ldc.i4.3
        IL_0002: add
        IL_0003: call void [System.Console]System.Console::WriteLine(int32)
        IL_0008: ret
    } // end of method Adv::compoundAssignAdv

    .method private hidebysig static 
        void foreachAdv () cil managed 
    {
        // Method begins at RVA 0x20f8
        // Code size 106 (0x6a)
        .maxstack 3
        .locals init (
            [0] int32 total,
            [1] valuetype [System.Private.CoreLib]System.Collections.Generic.List`1/Enumerator<int32>,
            [2] int32 i
        )

        IL_0000: newobj instance void class [System.Private.CoreLib]System.Collections.Generic.List`1<int32>::.ctor()
        IL_0005: dup
        IL_0006: ldc.i4.s 10
        IL_0008: callvirt instance void class [System.Private.CoreLib]System.Collections.Generic.List`1<int32>::Add(!0)
        IL_000d: dup
        IL_000e: ldc.i4.s 99
        IL_0010: callvirt instance void class [System.Private.CoreLib]System.Collections.Generic.List`1<int32>::Add(!0)
        IL_0015: dup
        IL_0016: ldc.i4.4
        IL_0017: callvirt instance void class [System.Private.CoreLib]System.Collections.Generic.List`1<int32>::Add(!0)
        IL_001c: dup
        IL_001d: ldc.i4.s 65
        IL_001f: callvirt instance void class [System.Private.CoreLib]System.Collections.Generic.List`1<int32>::Add(!0)
        IL_0024: dup
        IL_0025: ldc.i4.s 38
        IL_0027: callvirt instance void class [System.Private.CoreLib]System.Collections.Generic.List`1<int32>::Add(!0)
        IL_002c: dup
        IL_002d: ldc.i4.s 42
        IL_002f: callvirt instance void class [System.Private.CoreLib]System.Collections.Generic.List`1<int32>::Add(!0)
        IL_0034: ldc.i4.0
        IL_0035: stloc.0
        IL_0036: callvirt instance valuetype [System.Private.CoreLib]System.Collections.Generic.List`1/Enumerator<!0> class [System.Private.CoreLib]System.Collections.Generic.List`1<int32>::GetEnumerator()
        IL_003b: stloc.1
        .try
        {
            // sequence point: hidden
            IL_003c: br.s IL_004a
            // loop start (head: IL_004a)
                IL_003e: ldloca.s 1
                IL_0040: call instance !0 valuetype [System.Private.CoreLib]System.Collections.Generic.List`1/Enumerator<int32>::get_Current()
                IL_0045: stloc.2
                IL_0046: ldloc.0
                IL_0047: ldloc.2
                IL_0048: add
                IL_0049: stloc.0

                IL_004a: ldloca.s 1
                IL_004c: call instance bool valuetype [System.Private.CoreLib]System.Collections.Generic.List`1/Enumerator<int32>::MoveNext()
                IL_0051: brtrue.s IL_003e
            // end loop

            IL_0053: leave.s IL_0063
        } // end .try
        finally
        {
            // sequence point: hidden
            IL_0055: ldloca.s 1
            IL_0057: constrained. valuetype [System.Private.CoreLib]System.Collections.Generic.List`1/Enumerator<int32>
            IL_005d: callvirt instance void [System.Private.CoreLib]System.IDisposable::Dispose()
            IL_0062: endfinally
        } // end handler

        IL_0063: ldloc.0
        IL_0064: call void [System.Console]System.Console::WriteLine(int32)
        IL_0069: ret
    } // end of method Adv::foreachAdv

    .method private hidebysig static 
        void Main (
            string[] args
        ) cil managed 
    {
        // Method begins at RVA 0x2180
        // Code size 51 (0x33)
        .maxstack 8

        IL_0000: ldc.r8 10
        IL_0009: call string Adv::ternaryAdv(float64)
        IL_000e: pop
        IL_000f: ldstr "Alice"
        IL_0014: call void Adv::lambdaAdv(string)
        IL_0019: call void Adv::nullCoalesceAdv()
        IL_001e: call void Adv::nullConditionalAdv()
        IL_0023: call void Adv::incrDecrAdv()
        IL_0028: call void Adv::compoundAssignAdv()
        IL_002d: call void Adv::foreachAdv()
        IL_0032: ret
    } // end of method Adv::Main

    .method public hidebysig specialname rtspecialname 
        instance void .ctor () cil managed 
    {
        // Method begins at RVA 0x21b4
        // Code size 7 (0x7)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: call instance void [System.Private.CoreLib]System.Object::.ctor()
        IL_0006: ret
    } // end of method Adv::.ctor

} // end of class Adv

.class private auto ansi beforefieldinit Person
    extends [System.Private.CoreLib]System.Object
{
    // Fields
    .field private string '<firstName>k__BackingField'
    .custom instance void [System.Private.CoreLib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
        01 00 00 00
    )

    // Methods
    .method public hidebysig specialname 
        instance string get_firstName () cil managed 
    {
        .custom instance void [System.Private.CoreLib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
            01 00 00 00
        )
        // Method begins at RVA 0x21bc
        // Code size 7 (0x7)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: ldfld string Person::'<firstName>k__BackingField'
        IL_0006: ret
    } // end of method Person::get_firstName

    .method public hidebysig specialname 
        instance void set_firstName (
            string 'value'
        ) cil managed 
    {
        .custom instance void [System.Private.CoreLib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
            01 00 00 00
        )
        // Method begins at RVA 0x21c4
        // Code size 8 (0x8)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: ldarg.1
        IL_0002: stfld string Person::'<firstName>k__BackingField'
        IL_0007: ret
    } // end of method Person::set_firstName

    .method public hidebysig specialname rtspecialname 
        instance void .ctor () cil managed 
    {
        // Method begins at RVA 0x21b4
        // Code size 7 (0x7)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: call instance void [System.Private.CoreLib]System.Object::.ctor()
        IL_0006: ret
    } // end of method Person::.ctor

    // Properties
    .property instance string firstName()
    {
        .get instance string Person::get_firstName()
        .set instance void Person::set_firstName(string)
    }

} // end of class Person

