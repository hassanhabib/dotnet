﻿#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f830678e508a850354b4240a5821a1d75347fa64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_CSharp8_Runtime), @"default", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml")]
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
#nullable restore
#line 1 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f830678e508a850354b4240a5821a1d75347fa64", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml")]
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_CSharp8_Runtime
    {
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml"
  
    IAsyncEnumerable<bool> GetAsyncEnumerable()
    {
        return null;
    }

    await foreach (var val in GetAsyncEnumerable())
    {

    }

    Range range = 1..5;
    using var disposable = GetLastDisposableInRange(range);

    var words = Array.Empty<string>();
    var testEnum = GetEnum();
    static TestEnum GetEnum()
    {
        return TestEnum.First;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line (25,2)-(25,13) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml"
Write(words[1..2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line (26,3)-(26,16) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml"
Write(words[^2..^0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line (28,3)-(33,2) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml"
Write(testEnum switch
{
    TestEnum.First => "The First!",
    TestEnum.Second => "The Second!",
    _ => "The others",
});

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 35 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml"
 await foreach (var val in GetAsyncEnumerable())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line (37,6)-(37,9) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml"
Write(val);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml"
        
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line (40,2)-(40,14) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml"
Write(Person!.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line (41,2)-(41,22) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml"
Write(People![0]!.Name![1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line (42,2)-(42,23) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml"
Write(DoSomething!(Person!));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/CSharp8.cshtml"
            
    enum TestEnum
    {
        First,
        Second
    }

    IDisposable GetLastDisposableInRange(Range range)
    {
        var disposables = (IDisposable[])ViewData["disposables"];
        return disposables[range][^1];
    }

    private Human? Person { get; set; }

    private Human?[]? People { get; set; }

    private Func<Human, string>? DoSomething { get; set; }

    private class Human
    {
        public string? Name { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
