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
	public static void Run(SLProtocolExt protocol)
	{
		try
		{
            protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Executing QAction", LogType.DebugInfo, LogLevel.NoLogging);

            int val = Convert.ToInt32(protocol.Togglestatecycle);
			protocol.Togglestatecycle = (val + 1) % 2;

		}
		catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}
}