// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

namespace stellar_dotnet_sdk.xdr;

// === xdr source ============================================================

//  union LedgerKey switch (LedgerEntryType type)
//  {
//  case ACCOUNT:
//      struct
//      {
//          AccountID accountID;
//      } account;
//  
//  case TRUSTLINE:
//      struct
//      {
//          AccountID accountID;
//          TrustLineAsset asset;
//      } trustLine;
//  
//  case OFFER:
//      struct
//      {
//          AccountID sellerID;
//          int64 offerID;
//      } offer;
//  
//  case DATA:
//      struct
//      {
//          AccountID accountID;
//          string64 dataName;
//      } data;
//  
//  case CLAIMABLE_BALANCE:
//      struct
//      {
//          ClaimableBalanceID balanceID;
//      } claimableBalance;
//  
//  case LIQUIDITY_POOL:
//      struct
//      {
//          PoolID liquidityPoolID;
//      } liquidityPool;
//  case CONTRACT_DATA:
//      struct
//      {
//          SCAddress contract;
//          SCVal key;
//          ContractDataDurability durability;
//      } contractData;
//  case CONTRACT_CODE:
//      struct
//      {
//          Hash hash;
//      } contractCode;
//  case CONFIG_SETTING:
//      struct
//      {
//          ConfigSettingID configSettingID;
//      } configSetting;
//  case TTL:
//      struct
//      {
//          // Hash of the LedgerKey that is associated with this TTLEntry
//          Hash keyHash;
//      } ttl;
//  };

//  ===========================================================================
public class LedgerKey
{
    public LedgerEntryType Discriminant { get; set; } = new();

    public LedgerKeyAccount Account { get; set; }
    public LedgerKeyTrustLine TrustLine { get; set; }
    public LedgerKeyOffer Offer { get; set; }
    public LedgerKeyData Data { get; set; }
    public LedgerKeyClaimableBalance ClaimableBalance { get; set; }
    public LedgerKeyLiquidityPool LiquidityPool { get; set; }
    public LedgerKeyContractData ContractData { get; set; }
    public LedgerKeyContractCode ContractCode { get; set; }
    public LedgerKeyConfigSetting ConfigSetting { get; set; }
    public LedgerKeyTtl Ttl { get; set; }

    public static void Encode(XdrDataOutputStream stream, LedgerKey encodedLedgerKey)
    {
        stream.WriteInt((int)encodedLedgerKey.Discriminant.InnerValue);
        switch (encodedLedgerKey.Discriminant.InnerValue)
        {
            case LedgerEntryType.LedgerEntryTypeEnum.ACCOUNT:
                LedgerKeyAccount.Encode(stream, encodedLedgerKey.Account);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.TRUSTLINE:
                LedgerKeyTrustLine.Encode(stream, encodedLedgerKey.TrustLine);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.OFFER:
                LedgerKeyOffer.Encode(stream, encodedLedgerKey.Offer);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.DATA:
                LedgerKeyData.Encode(stream, encodedLedgerKey.Data);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.CLAIMABLE_BALANCE:
                LedgerKeyClaimableBalance.Encode(stream, encodedLedgerKey.ClaimableBalance);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.LIQUIDITY_POOL:
                LedgerKeyLiquidityPool.Encode(stream, encodedLedgerKey.LiquidityPool);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.CONTRACT_DATA:
                LedgerKeyContractData.Encode(stream, encodedLedgerKey.ContractData);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.CONTRACT_CODE:
                LedgerKeyContractCode.Encode(stream, encodedLedgerKey.ContractCode);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.CONFIG_SETTING:
                LedgerKeyConfigSetting.Encode(stream, encodedLedgerKey.ConfigSetting);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.TTL:
                LedgerKeyTtl.Encode(stream, encodedLedgerKey.Ttl);
                break;
        }
    }

    public static LedgerKey Decode(XdrDataInputStream stream)
    {
        var decodedLedgerKey = new LedgerKey();
        var discriminant = LedgerEntryType.Decode(stream);
        decodedLedgerKey.Discriminant = discriminant;
        switch (decodedLedgerKey.Discriminant.InnerValue)
        {
            case LedgerEntryType.LedgerEntryTypeEnum.ACCOUNT:
                decodedLedgerKey.Account = LedgerKeyAccount.Decode(stream);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.TRUSTLINE:
                decodedLedgerKey.TrustLine = LedgerKeyTrustLine.Decode(stream);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.OFFER:
                decodedLedgerKey.Offer = LedgerKeyOffer.Decode(stream);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.DATA:
                decodedLedgerKey.Data = LedgerKeyData.Decode(stream);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.CLAIMABLE_BALANCE:
                decodedLedgerKey.ClaimableBalance = LedgerKeyClaimableBalance.Decode(stream);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.LIQUIDITY_POOL:
                decodedLedgerKey.LiquidityPool = LedgerKeyLiquidityPool.Decode(stream);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.CONTRACT_DATA:
                decodedLedgerKey.ContractData = LedgerKeyContractData.Decode(stream);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.CONTRACT_CODE:
                decodedLedgerKey.ContractCode = LedgerKeyContractCode.Decode(stream);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.CONFIG_SETTING:
                decodedLedgerKey.ConfigSetting = LedgerKeyConfigSetting.Decode(stream);
                break;
            case LedgerEntryType.LedgerEntryTypeEnum.TTL:
                decodedLedgerKey.Ttl = LedgerKeyTtl.Decode(stream);
                break;
        }

        return decodedLedgerKey;
    }

    public class LedgerKeyAccount
    {
        public AccountID AccountID { get; set; }

        public static void Encode(XdrDataOutputStream stream, LedgerKeyAccount encodedLedgerKeyAccount)
        {
            AccountID.Encode(stream, encodedLedgerKeyAccount.AccountID);
        }

        public static LedgerKeyAccount Decode(XdrDataInputStream stream)
        {
            var decodedLedgerKeyAccount = new LedgerKeyAccount();
            decodedLedgerKeyAccount.AccountID = AccountID.Decode(stream);
            return decodedLedgerKeyAccount;
        }
    }

    public class LedgerKeyTrustLine
    {
        public AccountID AccountID { get; set; }
        public TrustLineAsset Asset { get; set; }

        public static void Encode(XdrDataOutputStream stream, LedgerKeyTrustLine encodedLedgerKeyTrustLine)
        {
            AccountID.Encode(stream, encodedLedgerKeyTrustLine.AccountID);
            TrustLineAsset.Encode(stream, encodedLedgerKeyTrustLine.Asset);
        }

        public static LedgerKeyTrustLine Decode(XdrDataInputStream stream)
        {
            var decodedLedgerKeyTrustLine = new LedgerKeyTrustLine();
            decodedLedgerKeyTrustLine.AccountID = AccountID.Decode(stream);
            decodedLedgerKeyTrustLine.Asset = TrustLineAsset.Decode(stream);
            return decodedLedgerKeyTrustLine;
        }
    }

    public class LedgerKeyOffer
    {
        public AccountID SellerID { get; set; }
        public Int64 OfferID { get; set; }

        public static void Encode(XdrDataOutputStream stream, LedgerKeyOffer encodedLedgerKeyOffer)
        {
            AccountID.Encode(stream, encodedLedgerKeyOffer.SellerID);
            Int64.Encode(stream, encodedLedgerKeyOffer.OfferID);
        }

        public static LedgerKeyOffer Decode(XdrDataInputStream stream)
        {
            var decodedLedgerKeyOffer = new LedgerKeyOffer();
            decodedLedgerKeyOffer.SellerID = AccountID.Decode(stream);
            decodedLedgerKeyOffer.OfferID = Int64.Decode(stream);
            return decodedLedgerKeyOffer;
        }
    }

    public class LedgerKeyData
    {
        public AccountID AccountID { get; set; }
        public String64 DataName { get; set; }

        public static void Encode(XdrDataOutputStream stream, LedgerKeyData encodedLedgerKeyData)
        {
            AccountID.Encode(stream, encodedLedgerKeyData.AccountID);
            String64.Encode(stream, encodedLedgerKeyData.DataName);
        }

        public static LedgerKeyData Decode(XdrDataInputStream stream)
        {
            var decodedLedgerKeyData = new LedgerKeyData();
            decodedLedgerKeyData.AccountID = AccountID.Decode(stream);
            decodedLedgerKeyData.DataName = String64.Decode(stream);
            return decodedLedgerKeyData;
        }
    }

    public class LedgerKeyClaimableBalance
    {
        public ClaimableBalanceID BalanceID { get; set; }

        public static void Encode(XdrDataOutputStream stream,
            LedgerKeyClaimableBalance encodedLedgerKeyClaimableBalance)
        {
            ClaimableBalanceID.Encode(stream, encodedLedgerKeyClaimableBalance.BalanceID);
        }

        public static LedgerKeyClaimableBalance Decode(XdrDataInputStream stream)
        {
            var decodedLedgerKeyClaimableBalance = new LedgerKeyClaimableBalance();
            decodedLedgerKeyClaimableBalance.BalanceID = ClaimableBalanceID.Decode(stream);
            return decodedLedgerKeyClaimableBalance;
        }
    }

    public class LedgerKeyLiquidityPool
    {
        public PoolID LiquidityPoolID { get; set; }

        public static void Encode(XdrDataOutputStream stream, LedgerKeyLiquidityPool encodedLedgerKeyLiquidityPool)
        {
            PoolID.Encode(stream, encodedLedgerKeyLiquidityPool.LiquidityPoolID);
        }

        public static LedgerKeyLiquidityPool Decode(XdrDataInputStream stream)
        {
            var decodedLedgerKeyLiquidityPool = new LedgerKeyLiquidityPool();
            decodedLedgerKeyLiquidityPool.LiquidityPoolID = PoolID.Decode(stream);
            return decodedLedgerKeyLiquidityPool;
        }
    }

    public class LedgerKeyContractData
    {
        public SCAddress Contract { get; set; }
        public SCVal Key { get; set; }
        public ContractDataDurability Durability { get; set; }

        public static void Encode(XdrDataOutputStream stream, LedgerKeyContractData encodedLedgerKeyContractData)
        {
            SCAddress.Encode(stream, encodedLedgerKeyContractData.Contract);
            SCVal.Encode(stream, encodedLedgerKeyContractData.Key);
            ContractDataDurability.Encode(stream, encodedLedgerKeyContractData.Durability);
        }

        public static LedgerKeyContractData Decode(XdrDataInputStream stream)
        {
            var decodedLedgerKeyContractData = new LedgerKeyContractData();
            decodedLedgerKeyContractData.Contract = SCAddress.Decode(stream);
            decodedLedgerKeyContractData.Key = SCVal.Decode(stream);
            decodedLedgerKeyContractData.Durability = ContractDataDurability.Decode(stream);
            return decodedLedgerKeyContractData;
        }
    }

    public class LedgerKeyContractCode
    {
        public Hash Hash { get; set; }

        public static void Encode(XdrDataOutputStream stream, LedgerKeyContractCode encodedLedgerKeyContractCode)
        {
            Hash.Encode(stream, encodedLedgerKeyContractCode.Hash);
        }

        public static LedgerKeyContractCode Decode(XdrDataInputStream stream)
        {
            var decodedLedgerKeyContractCode = new LedgerKeyContractCode();
            decodedLedgerKeyContractCode.Hash = Hash.Decode(stream);
            return decodedLedgerKeyContractCode;
        }
    }

    public class LedgerKeyConfigSetting
    {
        public ConfigSettingID ConfigSettingID { get; set; }

        public static void Encode(XdrDataOutputStream stream, LedgerKeyConfigSetting encodedLedgerKeyConfigSetting)
        {
            ConfigSettingID.Encode(stream, encodedLedgerKeyConfigSetting.ConfigSettingID);
        }

        public static LedgerKeyConfigSetting Decode(XdrDataInputStream stream)
        {
            var decodedLedgerKeyConfigSetting = new LedgerKeyConfigSetting();
            decodedLedgerKeyConfigSetting.ConfigSettingID = ConfigSettingID.Decode(stream);
            return decodedLedgerKeyConfigSetting;
        }
    }

    public class LedgerKeyTtl
    {
        public Hash KeyHash { get; set; }

        public static void Encode(XdrDataOutputStream stream, LedgerKeyTtl encodedLedgerKeyTtl)
        {
            Hash.Encode(stream, encodedLedgerKeyTtl.KeyHash);
        }

        public static LedgerKeyTtl Decode(XdrDataInputStream stream)
        {
            var decodedLedgerKeyTtl = new LedgerKeyTtl();
            decodedLedgerKeyTtl.KeyHash = Hash.Decode(stream);
            return decodedLedgerKeyTtl;
        }
    }
}