.class private auto ansi '<Module>'
{
} // end of class <Module>

.class private auto ansi beforefieldinit Plain
    extends [System.Private.CoreLib]System.Object
{
    // Methods
    .method private hidebysig static 
        string ternaryPlain (
            float64 temp
        ) cil managed 
    {
        // Method begins at RVA 0x2050
        // Code size 24 (0x18)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: ldc.r8 20
        IL_000a: bge.un.s IL_0012

        IL_000c: ldstr "Cold."
        IL_0011: ret

        IL_0012: ldstr "Perfect!"
        IL_0017: ret
    } // end of method Plain::ternaryPlain

    .method private hidebysig static 
        void lambdaPlain (
            string name
        ) cil managed 
    {
        // Method begins at RVA 0x2069
        // Code size 22 (0x16)
        .maxstack 8

        IL_0000: ldstr "Hello "
        IL_0005: ldarg.0
        IL_0006: ldstr "!"
        IL_000b: call string [System.Private.CoreLib]System.String::Concat(string, string, string)
        IL_0010: call void [System.Console]System.Console::WriteLine(string)
        IL_0015: ret
    } // end of method Plain::lambdaPlain

    .method private hidebysig static 
        void nullCoalescePlain () cil managed 
    {
        // Method begins at RVA 0x2080
        // Code size 22 (0x16)
        .maxstack 1
        .locals init (
            [0] class Person a,
            [1] class Person b
        )

        IL_0000: ldnull
        IL_0001: stloc.0
        IL_0002: ldloc.0
        IL_0003: brfalse.s IL_0009

        IL_0005: ldloc.0
        IL_0006: stloc.1
        // sequence point: hidden
        IL_0007: br.s IL_000f

        IL_0009: newobj instance void Person::.ctor()
        IL_000e: stloc.1

        IL_000f: ldloc.1
        IL_0010: call void [System.Console]System.Console::WriteLine(object)
        IL_0015: ret
    } // end of method Plain::nullCoalescePlain

    .method private hidebysig static 
        void nullConditionalPlain () cil managed 
    {
        // Method begins at RVA 0x20a4
        // Code size 27 (0x1b)
        .maxstack 1
        .locals init (
            [0] class Person p,
            [1] string name
        )

        IL_0000: newobj instance void Person::.ctor()
        IL_0005: stloc.0
        IL_0006: ldloc.0
        IL_0007: brfalse.s IL_0012

        IL_0009: ldloc.0
        IL_000a: callvirt instance string Person::get_firstName()
        IL_000f: stloc.1
        // sequence point: hidden
        IL_0010: br.s IL_0014

        IL_0012: ldnull
        IL_0013: stloc.1

        IL_0014: ldloc.1
        IL_0015: call void [System.Console]System.Console::WriteLine(string)
        IL_001a: ret
    } // end of method Plain::nullConditionalPlain

    .method private hidebysig static 
        void incrDecrPlain () cil managed 
    {
        // Method begins at RVA 0x20cc
        // Code size 33 (0x21)
        .maxstack 3
        .locals init (
            [0] int32 y,
            [1] int32 z
        )

        IL_0000: ldc.i4.0
        IL_0001: stloc.0
        IL_0002: ldc.i4.0
        IL_0003: stloc.1
        IL_0004: ldc.i4.3
        IL_0005: dup
        IL_0006: stloc.0
        IL_0007: ldc.i4.1
        IL_0008: add
        IL_0009: dup
        IL_000a: ldc.i4.1
        IL_000b: add
        IL_000c: stloc.1
        IL_000d: ldc.i4.1
        IL_000e: add
        IL_000f: call void [System.Console]System.Console::WriteLine(int32)
        IL_0014: ldloc.0
        IL_0015: call void [System.Console]System.Console::WriteLine(int32)
        IL_001a: ldloc.1
        IL_001b: call void [System.Console]System.Console::WriteLine(int32)
        IL_0020: ret
    } // end of method Plain::incrDecrPlain

    .method private hidebysig static 
        void compoundAssignPlain () cil managed 
    {
        // Method begins at RVA 0x20f9
        // Code size 9 (0x9)
        .maxstack 8

        IL_0000: ldc.i4.2
        IL_0001: ldc.i4.3
        IL_0002: add
        IL_0003: call void [System.Console]System.Console::WriteLine(int32)
        IL_0008: ret
    } // end of method Plain::compoundAssignPlain

    .method private hidebysig static 
        void foreachPlain () cil managed 
    {
        // Method begins at RVA 0x2104
        // Code size 89 (0x59)
        .maxstack 3
        .locals init (
            [0] class [System.Private.CoreLib]System.Collections.Generic.List`1<int32> nums,
            [1] int32 total,
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
        IL_0034: stloc.0
        IL_0035: ldc.i4.0
        IL_0036: stloc.1
        IL_0037: ldc.i4.0
        IL_0038: stloc.2
        // sequence point: hidden
        IL_0039: br.s IL_0049
        // loop start (head: IL_0049)
            IL_003b: ldloc.1
            IL_003c: ldloc.0
            IL_003d: ldloc.2
            IL_003e: callvirt instance !0 class [System.Private.CoreLib]System.Collections.Generic.List`1<int32>::get_Item(int32)
            IL_0043: add
            IL_0044: stloc.1
            IL_0045: ldloc.2
            IL_0046: ldc.i4.1
            IL_0047: add
            IL_0048: stloc.2

            IL_0049: ldloc.2
            IL_004a: ldloc.0
            IL_004b: callvirt instance int32 class [System.Private.CoreLib]System.Collections.Generic.List`1<int32>::get_Count()
            IL_0050: blt.s IL_003b
        // end loop

        IL_0052: ldloc.1
        IL_0053: call void [System.Console]System.Console::WriteLine(int32)
        IL_0058: ret
    } // end of method Plain::foreachPlain

    .method private hidebysig static 
        void Main (
            string[] args
        ) cil managed 
    {
        // Method begins at RVA 0x2169
        // Code size 51 (0x33)
        .maxstack 8

        IL_0000: ldc.r8 10
        IL_0009: call string Plain::ternaryPlain(float64)
        IL_000e: pop
        IL_000f: ldstr "Alice"
        IL_0014: call void Plain::lambdaPlain(string)
        IL_0019: call void Plain::nullCoalescePlain()
        IL_001e: call void Plain::nullConditionalPlain()
        IL_0023: call void Plain::incrDecrPlain()
        IL_0028: call void Plain::compoundAssignPlain()
        IL_002d: call void Plain::foreachPlain()
        IL_0032: ret
    } // end of method Plain::Main

    .method public hidebysig specialname rtspecialname 
        instance void .ctor () cil managed 
    {
        // Method begins at RVA 0x219d
        // Code size 7 (0x7)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: call instance void [System.Private.CoreLib]System.Object::.ctor()
        IL_0006: ret
    } // end of method Plain::.ctor

} // end of class Plain

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
        // Method begins at RVA 0x21a5
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
        // Method begins at RVA 0x21ad
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
        // Method begins at RVA 0x219d
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

