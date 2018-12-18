﻿using System.Threading;
using System.Threading.Tasks;
using Tron.Net.Protocol;
using TRON.WebApi.Grpc;
using TRON.WebApi.Grpc.Configuration;
using TRON.WebApi.Services.Interface;

namespace TRON.WebApi.Services.Service
{
    public class WalletSolidity : IWalletSolidity
    {
        private readonly IWalletSolidityClientFactory _clientFactory;
        private readonly IWalletSolidityClientCallConfiguration _configuration;

        public WalletSolidity(IWalletSolidityClientFactory clientFactory, IWalletSolidityClientCallConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
        }


        private Tron.Net.Protocol.WalletSolidity.WalletSolidityClient GetWalletSolidity()
        {
            return _clientFactory.Create();
        }

        public async Task<Account> GetAccountAsync(Account account, CancellationToken token = default(CancellationToken))
        {
            var walletSolidity = GetWalletSolidity();
            return await walletSolidity.GetAccountAsync(account, _configuration.GetCallOptions(token));
        }

        public async Task<WitnessList> ListWitnessesAsync(CancellationToken token = default(CancellationToken))
        {
            var walletSolidity = GetWalletSolidity();
            return await walletSolidity.ListWitnessesAsync(new EmptyMessage(), _configuration.GetCallOptions(token));
        }

        public async Task<AssetIssueList> GetAssetIssueListAsync(CancellationToken token = default(CancellationToken))
        {
            var walletSolidity = GetWalletSolidity();
            return await walletSolidity.GetAssetIssueListAsync(new EmptyMessage(), _configuration.GetCallOptions(token));
        }

        public async Task<Block> GetNowBlockAsync(CancellationToken token = default(CancellationToken))
        {
            var walletSolidity = GetWalletSolidity();
            return await walletSolidity.GetNowBlockAsync(new EmptyMessage(), _configuration.GetCallOptions(token));
        }

        public async Task<Block> GetBlockByNumAsync(NumberMessage message, CancellationToken token = default(CancellationToken))
        {
            var walletSolidity = GetWalletSolidity();
            return await walletSolidity.GetBlockByNumAsync(message, _configuration.GetCallOptions(token));
        }
    }
}