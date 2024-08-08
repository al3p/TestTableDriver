using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Skyline.DataMiner.Scripting;

/// <summary>
/// DataMiner QAction Class: QAPopulateTable.
/// populate the table with predefined hardcoded sample data
/// </summary>
public static class QAction
{
	/// <summary>
	/// The QAction entry point.
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	///
	private static readonly Random rd = new Random();

	public static void Run(SLProtocolExt protocol)
	{

		/// this is NOT good OO programming practice
		/// code here is only to focus on understanding the correct action sequence 
		/// that must be logically performed to populate a table.

		try
		{

			List<object[]> allRows = new List<object[]>
			{
				CreateEventRow("1", "House of dragons").ToObjectArray(),
				CreateEventRow("2", "The lords of the rings").ToObjectArray(),
				CreateEventRow("3", "A song of ice and fire").ToObjectArray(),
				CreateEventRow("4", "Harry Potter").ToObjectArray(),
			};

			/// object FillArray(int 'The ID of the table parameter', List<object[]> 'The rows of the table', NotifyProtocol.SaveOption option)
			protocol.FillArray(Parameter.Tbleventsoverview.tablePid, allRows, NotifyProtocol.SaveOption.Full);

		}
		catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}

	}

	private static TbleventsoverviewQActionRow CreateEventRow(string primaryKey, string eventName)
	{

		TbleventsoverviewQActionRow row = new TbleventsoverviewQActionRow
		{
			Coleventsoverviewinstance_101 = primaryKey,
			Coleventsoverviewname_102 = eventName,
			Coleventsoverviewstatus_103 = GetRandomEventState(),
		};

		return row;
	}

	private static int GetRandomEventState()
	{
		return rd.Next(0, 4);
	}


}