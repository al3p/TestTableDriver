using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Skyline.DataMiner.Scripting;

/// <summary>
/// DataMiner QAction Class: QASelectRow.
/// </summary>
public static class QAction
{
	/// <summary>
	/// The QAction entry point.
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void Run(SLProtocolExt protocol)
	{
		try
		{
			string tableRowKey = protocol.RowKey();
			object[] oRow = protocol.tbleventsoverview.GetRow(tableRowKey);
			TbleventsoverviewQActionRow row = new TbleventsoverviewQActionRow(oRow);

			protocol.Fieldeventsoverviewinstance_111 = row.Coleventsoverviewinstance_101;
			protocol.Fieldeventsoverviewname_112 = row.Coleventsoverviewname_102;
			protocol.Fieldeventsoverviewstatus_113 = row.Coleventsoverviewstatus_103;

		}
		catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}
}