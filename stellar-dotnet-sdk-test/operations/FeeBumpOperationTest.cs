﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using stellar_dotnet_sdk;
using xdrSDK = stellar_dotnet_sdk.xdr;
using System.Threading.Tasks;
using stellar_dotnet_sdk.responses;
using stellar_dotnet_sdk.responses.results;

namespace stellar_dotnet_sdk_test.operations;

[TestClass]
public class FeeBumpOperationTest
{
    [TestMethod]
    public async Task InsufficientFee()
    {
        Network.UseTestNetwork();
        using var server = new Server("https://horizon-testnet.stellar.org");

        var sourceKeyPair = KeyPair.Random();
        var sponsorKeyPair = KeyPair.Random();

        await Task.WhenAll(
            server.TestNetFriendBot
                .FundAccount(sourceKeyPair.AccountId)
                .Execute(),
            server.TestNetFriendBot
                .FundAccount(sponsorKeyPair.AccountId)
                .Execute()
        );

        var sourceAccount = await server.Accounts.Account(sourceKeyPair.AccountId);

        const uint maxFee = 2000000u;

        var transactionBuilder = new TransactionBuilder(sourceAccount);
        transactionBuilder.SetFee(maxFee);
            
        var paymentOperationBuilder = new PaymentOperation.Builder(
            sponsorKeyPair,
            new AssetTypeNative(),
            "1000"
        );
        transactionBuilder.AddOperation(
            paymentOperationBuilder.Build()
        );
        transactionBuilder.AddOperation(
            paymentOperationBuilder.Build()
        );
        var transaction = transactionBuilder.Build();
        transaction.Sign(sourceKeyPair);

        var exception = Assert.ThrowsException<Exception>(() => {
            TransactionBuilder.BuildFeeBumpTransaction(
                sponsorKeyPair,
                transaction,
                maxFee / 2
            );
        });

        Assert.AreEqual($"Invalid fee, it should be at least {maxFee} stroops", exception.Message);
    }
}