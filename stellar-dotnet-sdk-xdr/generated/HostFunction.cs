// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

namespace stellar_dotnet_sdk.xdr;

// === xdr source ============================================================

//  union HostFunction switch (HostFunctionType type)
//  {
//  case HOST_FUNCTION_TYPE_INVOKE_CONTRACT:
//      InvokeContractArgs invokeContract;
//  case HOST_FUNCTION_TYPE_CREATE_CONTRACT:
//      CreateContractArgs createContract;
//  case HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM:
//      opaque wasm<>;
//  };

//  ===========================================================================
public class HostFunction
{
    public HostFunctionType Discriminant { get; set; } = new();

    public InvokeContractArgs InvokeContract { get; set; }
    public CreateContractArgs CreateContract { get; set; }
    public byte[] Wasm { get; set; }

    public static void Encode(XdrDataOutputStream stream, HostFunction encodedHostFunction)
    {
        stream.WriteInt((int)encodedHostFunction.Discriminant.InnerValue);
        switch (encodedHostFunction.Discriminant.InnerValue)
        {
            case HostFunctionType.HostFunctionTypeEnum.HOST_FUNCTION_TYPE_INVOKE_CONTRACT:
                InvokeContractArgs.Encode(stream, encodedHostFunction.InvokeContract);
                break;
            case HostFunctionType.HostFunctionTypeEnum.HOST_FUNCTION_TYPE_CREATE_CONTRACT:
                CreateContractArgs.Encode(stream, encodedHostFunction.CreateContract);
                break;
            case HostFunctionType.HostFunctionTypeEnum.HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM:
                var wasmsize = encodedHostFunction.Wasm.Length;
                stream.WriteInt(wasmsize);
                stream.Write(encodedHostFunction.Wasm, 0, wasmsize);
                break;
        }
    }

    public static HostFunction Decode(XdrDataInputStream stream)
    {
        var decodedHostFunction = new HostFunction();
        var discriminant = HostFunctionType.Decode(stream);
        decodedHostFunction.Discriminant = discriminant;
        switch (decodedHostFunction.Discriminant.InnerValue)
        {
            case HostFunctionType.HostFunctionTypeEnum.HOST_FUNCTION_TYPE_INVOKE_CONTRACT:
                decodedHostFunction.InvokeContract = InvokeContractArgs.Decode(stream);
                break;
            case HostFunctionType.HostFunctionTypeEnum.HOST_FUNCTION_TYPE_CREATE_CONTRACT:
                decodedHostFunction.CreateContract = CreateContractArgs.Decode(stream);
                break;
            case HostFunctionType.HostFunctionTypeEnum.HOST_FUNCTION_TYPE_UPLOAD_CONTRACT_WASM:
                var wasmsize = stream.ReadInt();
                decodedHostFunction.Wasm = new byte[wasmsize];
                stream.Read(decodedHostFunction.Wasm, 0, wasmsize);
                break;
        }

        return decodedHostFunction;
    }
}