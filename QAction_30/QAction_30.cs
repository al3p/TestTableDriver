using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Skyline.DataMiner.Scripting;
using Skyline.Protocol.MyExtension;


/// <summary>
/// DataMiner QAction Class: QAFromJSON.
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
            protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Executing QAction", LogType.DebugInfo, LogLevel.NoLogging);
            MyCommons.FromJSON(protocol, protocol.tbleventsoverview, true);
        }
        catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}
}