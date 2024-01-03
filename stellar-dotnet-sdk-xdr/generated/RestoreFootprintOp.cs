// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

namespace stellar_dotnet_sdk.xdr;

// === xdr source ============================================================

//  struct RestoreFootprintOp
//  {
//      ExtensionPoint ext;
//  };

//  ===========================================================================
public class RestoreFootprintOp
{
    public ExtensionPoint Ext { get; set; }

    public static void Encode(XdrDataOutputStream stream, RestoreFootprintOp encodedRestoreFootprintOp)
    {
        ExtensionPoint.Encode(stream, encodedRestoreFootprintOp.Ext);
    }

    public static RestoreFootprintOp Decode(XdrDataInputStream stream)
    {
        var decodedRestoreFootprintOp = new RestoreFootprintOp();
        decodedRestoreFootprintOp.Ext = ExtensionPoint.Decode(stream);
        return decodedRestoreFootprintOp;
    }
}