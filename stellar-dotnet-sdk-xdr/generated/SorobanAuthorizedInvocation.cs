// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

namespace stellar_dotnet_sdk.xdr;

// === xdr source ============================================================

//  struct SorobanAuthorizedInvocation
//  {
//      SorobanAuthorizedFunction function;
//      SorobanAuthorizedInvocation subInvocations<>;
//  };

//  ===========================================================================
public class SorobanAuthorizedInvocation
{
    public SorobanAuthorizedFunction Function { get; set; }
    public SorobanAuthorizedInvocation[] SubInvocations { get; set; }

    public static void Encode(XdrDataOutputStream stream,
        SorobanAuthorizedInvocation encodedSorobanAuthorizedInvocation)
    {
        SorobanAuthorizedFunction.Encode(stream, encodedSorobanAuthorizedInvocation.Function);
        var subInvocationssize = encodedSorobanAuthorizedInvocation.SubInvocations.Length;
        stream.WriteInt(subInvocationssize);
        for (var i = 0; i < subInvocationssize; i++)
            Encode(stream, encodedSorobanAuthorizedInvocation.SubInvocations[i]);
    }

    public static SorobanAuthorizedInvocation Decode(XdrDataInputStream stream)
    {
        var decodedSorobanAuthorizedInvocation = new SorobanAuthorizedInvocation();
        decodedSorobanAuthorizedInvocation.Function = SorobanAuthorizedFunction.Decode(stream);
        var subInvocationssize = stream.ReadInt();
        decodedSorobanAuthorizedInvocation.SubInvocations = new SorobanAuthorizedInvocation[subInvocationssize];
        for (var i = 0; i < subInvocationssize; i++)
            decodedSorobanAuthorizedInvocation.SubInvocations[i] = Decode(stream);
        return decodedSorobanAuthorizedInvocation;
    }
}