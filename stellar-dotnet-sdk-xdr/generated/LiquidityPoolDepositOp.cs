// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

namespace stellar_dotnet_sdk.xdr;

// === xdr source ============================================================

//  struct LiquidityPoolDepositOp
//  {
//      PoolID liquidityPoolID;
//      int64 maxAmountA; // maximum amount of first asset to deposit
//      int64 maxAmountB; // maximum amount of second asset to deposit
//      Price minPrice;   // minimum depositA/depositB
//      Price maxPrice;   // maximum depositA/depositB
//  };

//  ===========================================================================
public class LiquidityPoolDepositOp
{
    public PoolID LiquidityPoolID { get; set; }
    public Int64 MaxAmountA { get; set; }
    public Int64 MaxAmountB { get; set; }
    public Price MinPrice { get; set; }
    public Price MaxPrice { get; set; }

    public static void Encode(XdrDataOutputStream stream, LiquidityPoolDepositOp encodedLiquidityPoolDepositOp)
    {
        PoolID.Encode(stream, encodedLiquidityPoolDepositOp.LiquidityPoolID);
        Int64.Encode(stream, encodedLiquidityPoolDepositOp.MaxAmountA);
        Int64.Encode(stream, encodedLiquidityPoolDepositOp.MaxAmountB);
        Price.Encode(stream, encodedLiquidityPoolDepositOp.MinPrice);
        Price.Encode(stream, encodedLiquidityPoolDepositOp.MaxPrice);
    }

    public static LiquidityPoolDepositOp Decode(XdrDataInputStream stream)
    {
        var decodedLiquidityPoolDepositOp = new LiquidityPoolDepositOp();
        decodedLiquidityPoolDepositOp.LiquidityPoolID = PoolID.Decode(stream);
        decodedLiquidityPoolDepositOp.MaxAmountA = Int64.Decode(stream);
        decodedLiquidityPoolDepositOp.MaxAmountB = Int64.Decode(stream);
        decodedLiquidityPoolDepositOp.MinPrice = Price.Decode(stream);
        decodedLiquidityPoolDepositOp.MaxPrice = Price.Decode(stream);
        return decodedLiquidityPoolDepositOp;
    }
}