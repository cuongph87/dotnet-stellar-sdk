// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  enum ClaimAtomType
    //  {
    //      CLAIM_ATOM_TYPE_V0 = 0,
    //      CLAIM_ATOM_TYPE_ORDER_BOOK = 1,
    //      CLAIM_ATOM_TYPE_LIQUIDITY_POOL = 2
    //  };

    //  ===========================================================================
    public class ClaimAtomType
    {
        public enum ClaimAtomTypeEnum
        {
            CLAIM_ATOM_TYPE_V0 = 0,
            CLAIM_ATOM_TYPE_ORDER_BOOK = 1,
            CLAIM_ATOM_TYPE_LIQUIDITY_POOL = 2,
        }
        public ClaimAtomTypeEnum InnerValue { get; set; } = default(ClaimAtomTypeEnum);

        public static ClaimAtomType Create(ClaimAtomTypeEnum v)
        {
            return new ClaimAtomType
            {
                InnerValue = v
            };
        }

        public static ClaimAtomType Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(ClaimAtomTypeEnum.CLAIM_ATOM_TYPE_V0);
                case 1: return Create(ClaimAtomTypeEnum.CLAIM_ATOM_TYPE_ORDER_BOOK);
                case 2: return Create(ClaimAtomTypeEnum.CLAIM_ATOM_TYPE_LIQUIDITY_POOL);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, ClaimAtomType value)
        {
            stream.WriteInt((int)value.InnerValue);
        }
    }
}
