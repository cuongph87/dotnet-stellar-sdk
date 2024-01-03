// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr;

// === xdr source ============================================================

//  enum SorobanCredentialsType
//  {
//      SOROBAN_CREDENTIALS_SOURCE_ACCOUNT = 0,
//      SOROBAN_CREDENTIALS_ADDRESS = 1
//  };

//  ===========================================================================
public class SorobanCredentialsType
{
    public enum SorobanCredentialsTypeEnum
    {
        SOROBAN_CREDENTIALS_SOURCE_ACCOUNT = 0,
        SOROBAN_CREDENTIALS_ADDRESS = 1
    }

    public SorobanCredentialsTypeEnum InnerValue { get; set; } = default;

    public static SorobanCredentialsType Create(SorobanCredentialsTypeEnum v)
    {
        return new SorobanCredentialsType
        {
            InnerValue = v
        };
    }

    public static SorobanCredentialsType Decode(XdrDataInputStream stream)
    {
        var value = stream.ReadInt();
        switch (value)
        {
            case 0: return Create(SorobanCredentialsTypeEnum.SOROBAN_CREDENTIALS_SOURCE_ACCOUNT);
            case 1: return Create(SorobanCredentialsTypeEnum.SOROBAN_CREDENTIALS_ADDRESS);
            default:
                throw new Exception("Unknown enum value: " + value);
        }
    }

    public static void Encode(XdrDataOutputStream stream, SorobanCredentialsType value)
    {
        stream.WriteInt((int)value.InnerValue);
    }
}