// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  typedef opaque Value<>;

    //  ===========================================================================
    public class Value
    {
        public byte[] InnerValue { get; set; } = default(byte[]);

        public Value() { }

        public Value(byte[] value)
        {
            InnerValue = value;
        }

        public static void Encode(XdrDataOutputStream stream, Value encodedValue)
        {
            int Valuesize = encodedValue.InnerValue.Length;
            stream.WriteInt(Valuesize);
            stream.Write(encodedValue.InnerValue, 0, Valuesize);
        }
        public static Value Decode(XdrDataInputStream stream)
        {
            Value decodedValue = new Value();
            int Valuesize = stream.ReadInt();
            decodedValue.InnerValue = new byte[Valuesize];
            stream.Read(decodedValue.InnerValue, 0, Valuesize);
            return decodedValue;
        }
    }
}
