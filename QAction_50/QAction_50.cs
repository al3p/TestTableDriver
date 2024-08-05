using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Skyline.DataMiner.Scripting;

/// <summary>
/// DataMiner QAction Class: QActionName.
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
		/// cde here is only t focus on understanding the correct action sequence 
		/// that must be logically performed to populate a tabe.

		try
		{

			List<object[]> allRows = new List<object[]>
			{
				CreateEventRow("1", "News").ToObjectArray(),
				CreateEventRow("2", "Sports").ToObjectArray(),
				CreateEventRow("3", "Movie Time").ToObjectArray(),
				CreateEventRow("4", "Skyline Late Night").ToObjectArray(),
			};

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