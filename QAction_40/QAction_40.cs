using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Skyline.DataMiner.Scripting;
using Skyline.Protocol.MyExtension;

/// <summary>
/// DataMiner QAction Class: QAToJSON.
/// Save the table with into the required file (the default used here)
/// </summary>
public static class QAction
{
	/// <summary>
	/// Entry point: just call the common function with the required parameters
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void Run(SLProtocolExt protocol)
	{
		try
		{
            protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Executing QAction", LogType.DebugInfo, LogLevel.NoLogging);
			MyCommons.ToJSON(protocol, protocol.tbleventsoverview);
        }
        catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}
}