using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Web;
using Skyline.DataMiner.Net.Apps.APIDeployment.DMAObjectRefParsing;
using Skyline.DataMiner.Scripting;
using Skyline.Protocol.MyExtension;

/// <summary>
/// DataMiner QAction Class.
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

			string instance = protocol.Fieldeventsoverviewinstance_111.ToString();
			if (instance == null || instance == "0")
				return;
			string name = protocol.Fieldeventsoverviewname_112.ToString();
			int status = Convert.ToInt32(protocol.Fieldeventsoverviewstatus_113);

			///object[] newRow = MyCommons.CreateEventRow(instance, name, status).ToObjectArray();
			///protocol.AddRow(Parameter.Tbleventsoverview.tablePid, newRow);
			TbleventsoverviewQActionRow newRow = MyCommons.CreateEventRow(instance, name, status);

            protocol.tbleventsoverview.SetRow(newRow, true);


        }
		catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}
}
