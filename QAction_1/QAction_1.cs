namespace Skyline.Protocol
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Text;

	using Skyline.DataMiner.Scripting;

	/// kept the usual default names assigned by commmon template
	namespace MyExtension
    {
        public static class MyCommons
        {
			public static TbleventsoverviewQActionRow CreateEventRow(string primaryKey, string eventName, int eventState)
			{

				TbleventsoverviewQActionRow row = new TbleventsoverviewQActionRow
				{
					Coleventsoverviewinstance_101 = primaryKey,
					Coleventsoverviewname_102 = eventName,
					Coleventsoverviewstatus_103 = eventState,
				};

				return row;
			}

		}
	}
}