// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

namespace stellar_dotnet_sdk.xdr;

// === xdr source ============================================================

//  struct SCSpecTypeVec
//  {
//      SCSpecTypeDef elementType;
//  };

//  ===========================================================================
public class SCSpecTypeVec
{
    public SCSpecTypeDef ElementType { get; set; }

    public static void Encode(XdrDataOutputStream stream, SCSpecTypeVec encodedSCSpecTypeVec)
    {
        SCSpecTypeDef.Encode(stream, encodedSCSpecTypeVec.ElementType);
    }

    public static SCSpecTypeVec Decode(XdrDataInputStream stream)
    {
        var decodedSCSpecTypeVec = new SCSpecTypeVec();
        decodedSCSpecTypeVec.ElementType = SCSpecTypeDef.Decode(stream);
        return decodedSCSpecTypeVec;
    }
}