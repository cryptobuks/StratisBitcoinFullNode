﻿using System.Collections.Generic;

namespace Stratis.SmartContracts.Executor.Reflection.ContractLogging
{
    public interface IContractLogHolder : IContractLogger
    {
        /// <summary>
        /// Get the raw logs from the holder. Likely to be used to return the logs from inside a contract execution.
        /// </summary>
        IList<RawLog> GetRawLogs();

        /// <summary>
        /// Add several raw logs to the holder. Likely to be used after nested contract execution.
        /// </summary>
        void AddRawLogs(IEnumerable<RawLog> toAdd);
    }
}