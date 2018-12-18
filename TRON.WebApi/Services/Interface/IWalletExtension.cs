﻿using System.Threading;
using System.Threading.Tasks;
using Tron.Net.Protocol;

namespace TRON.WebApi.Services.Interface
{
    public interface IWalletExtension
    {
        Task<TransactionList> GetTransactionsFromThisAsync(AccountPaginated accountPagination, CancellationToken token = default(CancellationToken));

        Task<TransactionList> GetTransactionsToThisAsync(AccountPaginated accountPagination, CancellationToken token = default(CancellationToken));
    }
}
