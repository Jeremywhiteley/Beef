﻿using Beef;
using Beef.Data.Cosmos;
using Beef.Mapper;
using Cdr.Banking.Common.Entities;
using Microsoft.Azure.Cosmos.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace Cdr.Banking.Business.Data
{
    public partial class AccountData
    {
        // Create a mapper for, a) the Model.Account to support the balance query, and b) the Balance to Model.Balance.
        private static readonly CosmosDbMapper<Model.Account, Model.Account> _accountMapper = CosmosDbMapper.CreateAuto<Model.Account, Model.Account>();
        private static readonly EntityMapper<Balance, Model.Balance> _balanceMapper = EntityMapper.CreateAuto<Balance, Model.Balance>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountData"/> class setting the required internal configurations.
        /// </summary>
        public AccountData()
        {
            _getAccountsOnQuery = GetAccountsOnQuery;   // Wire up the plug-in to enable filtering. 
        }

        /// <summary>
        /// Perform the query filering for the GetAccounts.
        /// </summary>
        private IQueryable<Model.Account> GetAccountsOnQuery(IQueryable<Model.Account> query, AccountArgs? args, ICosmosDbArgs dbArgs)
        {
            if (args == null || args.IsInitial)
                return query;

            // Where an argument value has been specified then add as a filter - the WhereWhen and WhereWith are enabled by Beef.
            var q = query.WhereWhen(!(args.OpenStatus == null) && args.OpenStatus != OpenStatus.All, x => x.OpenStatus == args!.OpenStatus!.Code);
            q = q.WhereWith(args?.ProductCategory, x => x.ProductCategory == args!.ProductCategory!.Code);

            // With checking IsOwned a simple false check cannot be performed with Cosmos; assume "not IsDefined" is equivalent to false also. 
            if (args!.IsOwned == null)
                return q;

            if (args.IsOwned == true)
                return q.Where(x => x.IsOwned == true);
            else
                return q.Where(x => !x.IsOwned.IsDefined() || !x.IsOwned);
        }

        /// <summary>
        /// Gets the balance for the specified account.
        /// </summary>
        private Task<Balance?> GetBalanceOnImplementationAsync(string? accountId)
        {
            // Create an IQueryable for the 'Account' container, then select for the specified id just the balance property.
            var args = _accountMapper.CreateArgs("Account");
            var val = (from a in CosmosDb.Default.Container(args).AsQueryable()
                        where a.Id == accountId
                        select new { a.Id, a.Balance }).SelectSingleOrDefault();

            if (val == null)
                return Task.FromResult<Balance?>(null);

            // Map the Model.Balance to Balance and return.
            var bal = _balanceMapper.MapToSrce(val.Balance)!;
            bal.Id = val.Id;
            return Task.FromResult<Balance?>(bal);
        }
    }
}