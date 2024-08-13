using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Skyline.DataMiner.Scripting;
using Skyline.Protocol.MyExtension;
using SLNetMessages = Skyline.DataMiner.Net.Messages;

/// <summary>
/// DataMiner QAction Class: QAStateCycle.
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

            uint[] columnsIdx = new uint[] { 0, 2 };
            object[] columns = MyCommons.GetColumns(protocol, protocol.tbleventsoverview.TableId, columnsIdx);
            object[] keyCol = (object[])columns[0];
            object[] valueCol = (object[])columns[1];
            string[] strKeyCol = new string[keyCol.Length];
 
            for (uint i = 0; i < valueCol.Length; i++)
            {
                valueCol[i] = (((Convert.ToUInt32(valueCol[i])) + 1) % 4);
                strKeyCol[i] = Convert.ToString(keyCol[i]);
             }

            protocol.tbleventsoverview.SetColumn(Parameter.Tbleventsoverview.Pid.coleventsoverviewstatus_103, strKeyCol, valueCol, false);
           

        }
        catch (Exception ex)
        {
            protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
        }
    }
}