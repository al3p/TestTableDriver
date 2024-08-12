namespace Skyline.Protocol
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Text;

	using Skyline.DataMiner.Scripting;
    using SLNetMessages = Skyline.DataMiner.Net.Messages;

    /// kept the usual default names assigned by commmon template
    namespace MyExtension
    {
        public static class MyCommons
        {
			public static TbleventsoverviewQActionRow CreateEventRow(string primaryKey, string eventName, int eventState)
			{

				TbleventsoverviewQActionRow row = new TbleventsoverviewQActionRow
				{
					Coleventsoverviewinstance_101 = primaryKey,
					Coleventsoverviewname_102 = eventName,
					Coleventsoverviewstatus_103 = eventState,
				};

				return row;
			}

            /// <summary>
            /// Get columns from table.
            /// This is a wrapper function for the NotifyProtocol type 321 NT_GET_TABLE_COLUMNS call.
            /// see https://docs.dataminer.services/develop/api/NotifyTypes/NT_GET_TABLE_COLUMNS.html   
            /// </summary>
            /// <param name="protocol">Link with SLProtocol process.</param>
            /// <param name="tablePid">The table ID: integer.</param>
            /// <param name="columnsIdx">The ID of the columns to be retrieved (0 based): array of integers</param>
            /// <returns> an object array whose elements are the two colums requested</returns>
            /// <example> 
            /// int tablePid = 1000;
            /// uint[] columnsIdx = new uint[] { 0, 1 };
            /// object[] columns = (object[])protocol.NotifyProtocol(321, tablePid, columnsToGetIdx);
            /// object[] firstColumn = (object[])columns[0];
            /// object[] secondColumn = (object[])columns[1];
            /// </example>
            /// <exception>
            /// Thrown when incomplete data are fetched
            /// </exception>
            public static object[] GetColumns(this SLProtocol protocol, int tablePid, uint[] columnsIdx)
            {
                object[] columnsRawData = (object[])protocol.NotifyProtocol((int)SLNetMessages.NotifyType.NT_GET_TABLE_COLUMNS, tablePid, columnsIdx);
                if (columnsRawData == null || columnsRawData.Length != columnsIdx.Length)
                {
                    throw new ArgumentException($"Retrieving data from table {tablePid} failed: Invalid data returned from SLProtocol.");
                }

                return columnsRawData;
            }

        }

    }
}