// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr;

// === xdr source ============================================================

//  enum TrustLineFlags
//  {
//      // issuer has authorized account to perform transactions with its credit
//      AUTHORIZED_FLAG = 1,
//      // issuer has authorized account to maintain and reduce liabilities for its
//      // credit
//      AUTHORIZED_TO_MAINTAIN_LIABILITIES_FLAG = 2,
//      // issuer has specified that it may clawback its credit, and that claimable
//      // balances created with its credit may also be clawed back
//      TRUSTLINE_CLAWBACK_ENABLED_FLAG = 4
//  };

//  ===========================================================================
public class TrustLineFlags
{
    public enum TrustLineFlagsEnum
    {
        AUTHORIZED_FLAG = 1,
        AUTHORIZED_TO_MAINTAIN_LIABILITIES_FLAG = 2,
        TRUSTLINE_CLAWBACK_ENABLED_FLAG = 4
    }

    public TrustLineFlagsEnum InnerValue { get; set; } = default;

    public static TrustLineFlags Create(TrustLineFlagsEnum v)
    {
        return new TrustLineFlags
        {
            InnerValue = v
        };
    }

    public static TrustLineFlags Decode(XdrDataInputStream stream)
    {
        var value = stream.ReadInt();
        switch (value)
        {
            case 1: return Create(TrustLineFlagsEnum.AUTHORIZED_FLAG);
            case 2: return Create(TrustLineFlagsEnum.AUTHORIZED_TO_MAINTAIN_LIABILITIES_FLAG);
            case 4: return Create(TrustLineFlagsEnum.TRUSTLINE_CLAWBACK_ENABLED_FLAG);
            default:
                throw new Exception("Unknown enum value: " + value);
        }
    }

    public static void Encode(XdrDataOutputStream stream, TrustLineFlags value)
    {
        stream.WriteInt((int)value.InnerValue);
    }
}