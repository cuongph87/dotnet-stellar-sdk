// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

namespace stellar_dotnet_sdk.xdr;

// === xdr source ============================================================

//  struct Operation
//  {
//      // sourceAccount is the account used to run the operation
//      // if not set, the runtime defaults to "sourceAccount" specified at
//      // the transaction level
//      MuxedAccount* sourceAccount;
//  
//      union switch (OperationType type)
//      {
//      case CREATE_ACCOUNT:
//          CreateAccountOp createAccountOp;
//      case PAYMENT:
//          PaymentOp paymentOp;
//      case PATH_PAYMENT_STRICT_RECEIVE:
//          PathPaymentStrictReceiveOp pathPaymentStrictReceiveOp;
//      case MANAGE_SELL_OFFER:
//          ManageSellOfferOp manageSellOfferOp;
//      case CREATE_PASSIVE_SELL_OFFER:
//          CreatePassiveSellOfferOp createPassiveSellOfferOp;
//      case SET_OPTIONS:
//          SetOptionsOp setOptionsOp;
//      case CHANGE_TRUST:
//          ChangeTrustOp changeTrustOp;
//      case ALLOW_TRUST:
//          AllowTrustOp allowTrustOp;
//      case ACCOUNT_MERGE:
//          MuxedAccount destination;
//      case INFLATION:
//          void;
//      case MANAGE_DATA:
//          ManageDataOp manageDataOp;
//      case BUMP_SEQUENCE:
//          BumpSequenceOp bumpSequenceOp;
//      case MANAGE_BUY_OFFER:
//          ManageBuyOfferOp manageBuyOfferOp;
//      case PATH_PAYMENT_STRICT_SEND:
//          PathPaymentStrictSendOp pathPaymentStrictSendOp;
//      case CREATE_CLAIMABLE_BALANCE:
//          CreateClaimableBalanceOp createClaimableBalanceOp;
//      case CLAIM_CLAIMABLE_BALANCE:
//          ClaimClaimableBalanceOp claimClaimableBalanceOp;
//      case BEGIN_SPONSORING_FUTURE_RESERVES:
//          BeginSponsoringFutureReservesOp beginSponsoringFutureReservesOp;
//      case END_SPONSORING_FUTURE_RESERVES:
//          void;
//      case REVOKE_SPONSORSHIP:
//          RevokeSponsorshipOp revokeSponsorshipOp;
//      case CLAWBACK:
//          ClawbackOp clawbackOp;
//      case CLAWBACK_CLAIMABLE_BALANCE:
//          ClawbackClaimableBalanceOp clawbackClaimableBalanceOp;
//      case SET_TRUST_LINE_FLAGS:
//          SetTrustLineFlagsOp setTrustLineFlagsOp;
//      case LIQUIDITY_POOL_DEPOSIT:
//          LiquidityPoolDepositOp liquidityPoolDepositOp;
//      case LIQUIDITY_POOL_WITHDRAW:
//          LiquidityPoolWithdrawOp liquidityPoolWithdrawOp;
//      case INVOKE_HOST_FUNCTION:
//          InvokeHostFunctionOp invokeHostFunctionOp;
//      case EXTEND_FOOTPRINT_TTL:
//          ExtendFootprintTTLOp extendFootprintTTLOp;
//      case RESTORE_FOOTPRINT:
//          RestoreFootprintOp restoreFootprintOp;
//      }
//      body;
//  };

//  ===========================================================================
public class Operation
{
    public MuxedAccount SourceAccount { get; set; }
    public OperationBody Body { get; set; }

    public static void Encode(XdrDataOutputStream stream, Operation encodedOperation)
    {
        if (encodedOperation.SourceAccount != null)
        {
            stream.WriteInt(1);
            MuxedAccount.Encode(stream, encodedOperation.SourceAccount);
        }
        else
        {
            stream.WriteInt(0);
        }

        OperationBody.Encode(stream, encodedOperation.Body);
    }

    public static Operation Decode(XdrDataInputStream stream)
    {
        var decodedOperation = new Operation();
        var SourceAccountPresent = stream.ReadInt();
        if (SourceAccountPresent != 0) decodedOperation.SourceAccount = MuxedAccount.Decode(stream);
        decodedOperation.Body = OperationBody.Decode(stream);
        return decodedOperation;
    }

    public class OperationBody
    {
        public OperationType Discriminant { get; set; } = new();

        public CreateAccountOp CreateAccountOp { get; set; }
        public PaymentOp PaymentOp { get; set; }
        public PathPaymentStrictReceiveOp PathPaymentStrictReceiveOp { get; set; }
        public ManageSellOfferOp ManageSellOfferOp { get; set; }
        public CreatePassiveSellOfferOp CreatePassiveSellOfferOp { get; set; }
        public SetOptionsOp SetOptionsOp { get; set; }
        public ChangeTrustOp ChangeTrustOp { get; set; }
        public AllowTrustOp AllowTrustOp { get; set; }
        public MuxedAccount Destination { get; set; }
        public ManageDataOp ManageDataOp { get; set; }
        public BumpSequenceOp BumpSequenceOp { get; set; }
        public ManageBuyOfferOp ManageBuyOfferOp { get; set; }
        public PathPaymentStrictSendOp PathPaymentStrictSendOp { get; set; }
        public CreateClaimableBalanceOp CreateClaimableBalanceOp { get; set; }
        public ClaimClaimableBalanceOp ClaimClaimableBalanceOp { get; set; }
        public BeginSponsoringFutureReservesOp BeginSponsoringFutureReservesOp { get; set; }
        public RevokeSponsorshipOp RevokeSponsorshipOp { get; set; }
        public ClawbackOp ClawbackOp { get; set; }
        public ClawbackClaimableBalanceOp ClawbackClaimableBalanceOp { get; set; }
        public SetTrustLineFlagsOp SetTrustLineFlagsOp { get; set; }
        public LiquidityPoolDepositOp LiquidityPoolDepositOp { get; set; }
        public LiquidityPoolWithdrawOp LiquidityPoolWithdrawOp { get; set; }
        public InvokeHostFunctionOp InvokeHostFunctionOp { get; set; }
        public ExtendFootprintTTLOp ExtendFootprintTTLOp { get; set; }
        public RestoreFootprintOp RestoreFootprintOp { get; set; }

        public static void Encode(XdrDataOutputStream stream, OperationBody encodedOperationBody)
        {
            stream.WriteInt((int)encodedOperationBody.Discriminant.InnerValue);
            switch (encodedOperationBody.Discriminant.InnerValue)
            {
                case OperationType.OperationTypeEnum.CREATE_ACCOUNT:
                    CreateAccountOp.Encode(stream, encodedOperationBody.CreateAccountOp);
                    break;
                case OperationType.OperationTypeEnum.PAYMENT:
                    PaymentOp.Encode(stream, encodedOperationBody.PaymentOp);
                    break;
                case OperationType.OperationTypeEnum.PATH_PAYMENT_STRICT_RECEIVE:
                    PathPaymentStrictReceiveOp.Encode(stream, encodedOperationBody.PathPaymentStrictReceiveOp);
                    break;
                case OperationType.OperationTypeEnum.MANAGE_SELL_OFFER:
                    ManageSellOfferOp.Encode(stream, encodedOperationBody.ManageSellOfferOp);
                    break;
                case OperationType.OperationTypeEnum.CREATE_PASSIVE_SELL_OFFER:
                    CreatePassiveSellOfferOp.Encode(stream, encodedOperationBody.CreatePassiveSellOfferOp);
                    break;
                case OperationType.OperationTypeEnum.SET_OPTIONS:
                    SetOptionsOp.Encode(stream, encodedOperationBody.SetOptionsOp);
                    break;
                case OperationType.OperationTypeEnum.CHANGE_TRUST:
                    ChangeTrustOp.Encode(stream, encodedOperationBody.ChangeTrustOp);
                    break;
                case OperationType.OperationTypeEnum.ALLOW_TRUST:
                    AllowTrustOp.Encode(stream, encodedOperationBody.AllowTrustOp);
                    break;
                case OperationType.OperationTypeEnum.ACCOUNT_MERGE:
                    MuxedAccount.Encode(stream, encodedOperationBody.Destination);
                    break;
                case OperationType.OperationTypeEnum.INFLATION:
                    break;
                case OperationType.OperationTypeEnum.MANAGE_DATA:
                    ManageDataOp.Encode(stream, encodedOperationBody.ManageDataOp);
                    break;
                case OperationType.OperationTypeEnum.BUMP_SEQUENCE:
                    BumpSequenceOp.Encode(stream, encodedOperationBody.BumpSequenceOp);
                    break;
                case OperationType.OperationTypeEnum.MANAGE_BUY_OFFER:
                    ManageBuyOfferOp.Encode(stream, encodedOperationBody.ManageBuyOfferOp);
                    break;
                case OperationType.OperationTypeEnum.PATH_PAYMENT_STRICT_SEND:
                    PathPaymentStrictSendOp.Encode(stream, encodedOperationBody.PathPaymentStrictSendOp);
                    break;
                case OperationType.OperationTypeEnum.CREATE_CLAIMABLE_BALANCE:
                    CreateClaimableBalanceOp.Encode(stream, encodedOperationBody.CreateClaimableBalanceOp);
                    break;
                case OperationType.OperationTypeEnum.CLAIM_CLAIMABLE_BALANCE:
                    ClaimClaimableBalanceOp.Encode(stream, encodedOperationBody.ClaimClaimableBalanceOp);
                    break;
                case OperationType.OperationTypeEnum.BEGIN_SPONSORING_FUTURE_RESERVES:
                    BeginSponsoringFutureReservesOp.Encode(stream,
                        encodedOperationBody.BeginSponsoringFutureReservesOp);
                    break;
                case OperationType.OperationTypeEnum.END_SPONSORING_FUTURE_RESERVES:
                    break;
                case OperationType.OperationTypeEnum.REVOKE_SPONSORSHIP:
                    RevokeSponsorshipOp.Encode(stream, encodedOperationBody.RevokeSponsorshipOp);
                    break;
                case OperationType.OperationTypeEnum.CLAWBACK:
                    ClawbackOp.Encode(stream, encodedOperationBody.ClawbackOp);
                    break;
                case OperationType.OperationTypeEnum.CLAWBACK_CLAIMABLE_BALANCE:
                    ClawbackClaimableBalanceOp.Encode(stream, encodedOperationBody.ClawbackClaimableBalanceOp);
                    break;
                case OperationType.OperationTypeEnum.SET_TRUST_LINE_FLAGS:
                    SetTrustLineFlagsOp.Encode(stream, encodedOperationBody.SetTrustLineFlagsOp);
                    break;
                case OperationType.OperationTypeEnum.LIQUIDITY_POOL_DEPOSIT:
                    LiquidityPoolDepositOp.Encode(stream, encodedOperationBody.LiquidityPoolDepositOp);
                    break;
                case OperationType.OperationTypeEnum.LIQUIDITY_POOL_WITHDRAW:
                    LiquidityPoolWithdrawOp.Encode(stream, encodedOperationBody.LiquidityPoolWithdrawOp);
                    break;
                case OperationType.OperationTypeEnum.INVOKE_HOST_FUNCTION:
                    InvokeHostFunctionOp.Encode(stream, encodedOperationBody.InvokeHostFunctionOp);
                    break;
                case OperationType.OperationTypeEnum.EXTEND_FOOTPRINT_TTL:
                    ExtendFootprintTTLOp.Encode(stream, encodedOperationBody.ExtendFootprintTTLOp);
                    break;
                case OperationType.OperationTypeEnum.RESTORE_FOOTPRINT:
                    RestoreFootprintOp.Encode(stream, encodedOperationBody.RestoreFootprintOp);
                    break;
            }
        }

        public static OperationBody Decode(XdrDataInputStream stream)
        {
            var decodedOperationBody = new OperationBody();
            var discriminant = OperationType.Decode(stream);
            decodedOperationBody.Discriminant = discriminant;
            switch (decodedOperationBody.Discriminant.InnerValue)
            {
                case OperationType.OperationTypeEnum.CREATE_ACCOUNT:
                    decodedOperationBody.CreateAccountOp = CreateAccountOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.PAYMENT:
                    decodedOperationBody.PaymentOp = PaymentOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.PATH_PAYMENT_STRICT_RECEIVE:
                    decodedOperationBody.PathPaymentStrictReceiveOp = PathPaymentStrictReceiveOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.MANAGE_SELL_OFFER:
                    decodedOperationBody.ManageSellOfferOp = ManageSellOfferOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.CREATE_PASSIVE_SELL_OFFER:
                    decodedOperationBody.CreatePassiveSellOfferOp = CreatePassiveSellOfferOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.SET_OPTIONS:
                    decodedOperationBody.SetOptionsOp = SetOptionsOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.CHANGE_TRUST:
                    decodedOperationBody.ChangeTrustOp = ChangeTrustOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.ALLOW_TRUST:
                    decodedOperationBody.AllowTrustOp = AllowTrustOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.ACCOUNT_MERGE:
                    decodedOperationBody.Destination = MuxedAccount.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.INFLATION:
                    break;
                case OperationType.OperationTypeEnum.MANAGE_DATA:
                    decodedOperationBody.ManageDataOp = ManageDataOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.BUMP_SEQUENCE:
                    decodedOperationBody.BumpSequenceOp = BumpSequenceOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.MANAGE_BUY_OFFER:
                    decodedOperationBody.ManageBuyOfferOp = ManageBuyOfferOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.PATH_PAYMENT_STRICT_SEND:
                    decodedOperationBody.PathPaymentStrictSendOp = PathPaymentStrictSendOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.CREATE_CLAIMABLE_BALANCE:
                    decodedOperationBody.CreateClaimableBalanceOp = CreateClaimableBalanceOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.CLAIM_CLAIMABLE_BALANCE:
                    decodedOperationBody.ClaimClaimableBalanceOp = ClaimClaimableBalanceOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.BEGIN_SPONSORING_FUTURE_RESERVES:
                    decodedOperationBody.BeginSponsoringFutureReservesOp =
                        BeginSponsoringFutureReservesOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.END_SPONSORING_FUTURE_RESERVES:
                    break;
                case OperationType.OperationTypeEnum.REVOKE_SPONSORSHIP:
                    decodedOperationBody.RevokeSponsorshipOp = RevokeSponsorshipOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.CLAWBACK:
                    decodedOperationBody.ClawbackOp = ClawbackOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.CLAWBACK_CLAIMABLE_BALANCE:
                    decodedOperationBody.ClawbackClaimableBalanceOp = ClawbackClaimableBalanceOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.SET_TRUST_LINE_FLAGS:
                    decodedOperationBody.SetTrustLineFlagsOp = SetTrustLineFlagsOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.LIQUIDITY_POOL_DEPOSIT:
                    decodedOperationBody.LiquidityPoolDepositOp = LiquidityPoolDepositOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.LIQUIDITY_POOL_WITHDRAW:
                    decodedOperationBody.LiquidityPoolWithdrawOp = LiquidityPoolWithdrawOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.INVOKE_HOST_FUNCTION:
                    decodedOperationBody.InvokeHostFunctionOp = InvokeHostFunctionOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.EXTEND_FOOTPRINT_TTL:
                    decodedOperationBody.ExtendFootprintTTLOp = ExtendFootprintTTLOp.Decode(stream);
                    break;
                case OperationType.OperationTypeEnum.RESTORE_FOOTPRINT:
                    decodedOperationBody.RestoreFootprintOp = RestoreFootprintOp.Decode(stream);
                    break;
            }

            return decodedOperationBody;
        }
    }
}