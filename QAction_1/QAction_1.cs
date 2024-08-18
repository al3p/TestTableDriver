namespace Skyline.Protocol
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    using System.IO;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;
    using System.Text;

    using System.Web.Script.Serialization;


    using Skyline.DataMiner.Scripting;
    using SLNetMessages = Skyline.DataMiner.Net.Messages;

    /// kept the usual default names assigned by commmon template
    namespace MyExtension
    {
        public static class MyCommons
        {
            public static TbleventsoverviewQActionRow CreateEventRow(this SLProtocolExt protocol, string primaryKey, string eventName, int eventState)
            {
                protocol.Log($"Function CreateEventRow|Run|Executing Function", LogType.DebugInfo, LogLevel.NoLogging);

                TbleventsoverviewQActionRow row = new TbleventsoverviewQActionRow
                {
                    Coleventsoverviewinstance_101 = primaryKey,
                    Coleventsoverviewname_102 = eventName,
                    Coleventsoverviewstatus_103 = eventState,
                    Coleventsselectbutton_104 = 1,
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
                protocol.Log($"Function GetColumns|Run|Executing Function", LogType.DebugInfo, LogLevel.NoLogging);
                object[] columnsRawData = (object[])protocol.NotifyProtocol((int)SLNetMessages.NotifyType.NT_GET_TABLE_COLUMNS, tablePid, columnsIdx);
                if (columnsRawData == null || columnsRawData.Length != columnsIdx.Length)
                {
                    throw new ArgumentException($"Retrieving data from table {tablePid} failed: Invalid data returned from SLProtocol.");
                }

                return columnsRawData;
            }

            public static void ToJSON(this SLProtocolExt protocol, QActionTable table, string fileName = "MyJSON.json")
            {
                var serializer = new JavaScriptSerializer();

                try
                {
                    protocol.Log($"Function ToJSON|Run|Executing Function", LogType.DebugInfo, LogLevel.NoLogging);

                    string[] keys = protocol.GetKeys(table.TableId);
                    List<object[]> rowList = new List<object[]>();

                    foreach (string key in keys)
                    {
                        rowList.Add(table.GetRow(key));
                    }

                    string serializedData = serializer.Serialize(rowList);
                    ///var deserializedResult = serializer.Deserialize((string)data, typeof(object)) as Dictionary<string, object>;

                    int thisElement = protocol.ElementID;
                    string file = $"C:\\{thisElement}-{fileName}";

                    WriteFileData(file, serializedData);

                }
                catch (Exception e)
                {
                    protocol.Log("QA" + protocol.QActionID + "|ERR|An unexpected error occurred during serialization of JSON data: " + e.ToString(), LogType.Error, LogLevel.NoLogging);
                }
            }

            public static void FromJSON(this SLProtocolExt protocol, QActionTable table, bool clean, string fileName = "MyJSON.json")
            {
                var serializer = new JavaScriptSerializer();

                try
                {
                    protocol.Log($"Function FromJSON|Run|Executing Function", LogType.DebugInfo, LogLevel.NoLogging);

                    int thisElement = protocol.ElementID;
                    string file = $"C:\\{thisElement}-{fileName}";

                    string serializedData = GetFileData(file);
                    var deserializedResult = serializer.Deserialize(serializedData, typeof(List<object[]>)) as List<object[]>;

                    if (deserializedResult != null)
                    {
                        if (clean)
                        {
                            protocol.ClearAllKeys(table.TableId);
                        }
                        foreach (object[] currentRow in deserializedResult)
                        {
                            table.AddRow(currentRow);
                        }
                    }
                    else
                    {
                        protocol.Log($"Function FromJSON|DBG|null after deserialization", LogType.DebugInfo, LogLevel.NoLogging);

                    }

                }
                catch (Exception e)
                {
                    protocol.Log("QA" + protocol.QActionID + "|ERR|An unexpected error occurred during deserialization of JSON data: " + e.ToString(), LogType.Error, LogLevel.NoLogging);
                }
            }

            public static void WriteFileData(string file, string data)
            {
                using (FileStream logWriter = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
                {
                    using (StreamWriter sw = new StreamWriter(logWriter, Encoding.Default))
                    {
                        sw.Write(data);
                    }
                }
            }

            public static string GetFileData(string file)
            {
                List<string> lines = new List<string>();

                if (File.Exists(file))
                {

                    using (FileStream logReader = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (StreamReader sr = new StreamReader(logReader, Encoding.Default))
                        {
                            while (!sr.EndOfStream)
                            {
                                lines.Add(sr.ReadLine());
                            }
                        }
                    }
                }
                return String.Join("\n", lines);
            }


        }

    }

}