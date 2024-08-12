using Skyline.DataMiner.Scripting;
using System;

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
            protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Executing QAction", LogType.DebugInfo, LogLevel.NoLogging);
            string tableRowKey = protocol.RowKey();

            object[] oRow = protocol.tbleventsoverview.GetRow(tableRowKey);
            TbleventsoverviewQActionRow row = new TbleventsoverviewQActionRow(oRow);

            protocol.Fieldeventsoverviewinstance_111 = row.Coleventsoverviewinstance_101.ToString();
            protocol.Fieldeventsoverviewname_112 = row.Coleventsoverviewname_102.ToString();
            protocol.Fieldeventsoverviewstatus_113 = Convert.ToInt32(row.Coleventsoverviewstatus_103);

        }
        catch (Exception ex)
        {
            protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
        }
    }
}