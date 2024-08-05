// <auto-generated>This is auto-generated code by DIS. Do not modify.</auto-generated>
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Skyline.DataMiner.Scripting
{
public static class Parameter
{
	public class Write
	{
		/// <summary>PID: 50 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int btnstaticpopulatetable_50 = 50;
		/// <summary>PID: 50 | Type: write</summary>
		public const int btnstaticpopulatetable = 50;
		/// <summary>PID: 201 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int coleventsoverviewinstance_201 = 201;
		/// <summary>PID: 201 | Type: write</summary>
		public const int coleventsoverviewinstance = 201;
		/// <summary>PID: 202 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int coleventsoverviewname_202 = 202;
		/// <summary>PID: 202 | Type: write</summary>
		public const int coleventsoverviewname = 202;
		/// <summary>PID: 203 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int coleventsoverviewstatus_203 = 203;
		/// <summary>PID: 203 | Type: write</summary>
		public const int coleventsoverviewstatus = 203;
	}
	public class Tbleventsoverview
	{
		/// <summary>PID: 100</summary>
		public const int tablePid = 100;
		/// <summary>IDX: 0</summary>
		public const int indexColumn = 0;
		/// <summary>PID: 101</summary>
		public const int indexColumnPid = 101;
		public class Pid
		{
			/// <summary>PID: 101 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int coleventsoverviewinstance_101 = 101;
			/// <summary>PID: 101 | Type: read</summary>
			public const int coleventsoverviewinstance = 101;
			/// <summary>PID: 102 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int coleventsoverviewname_102 = 102;
			/// <summary>PID: 102 | Type: read</summary>
			public const int coleventsoverviewname = 102;
			/// <summary>PID: 103 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int coleventsoverviewstatus_103 = 103;
			/// <summary>PID: 103 | Type: read</summary>
			public const int coleventsoverviewstatus = 103;
			public class Write
			{
			}
		}
		public class Idx
		{
			/// <summary>IDX: 0 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int coleventsoverviewinstance_101 = 0;
			/// <summary>IDX: 0 | Type: read</summary>
			public const int coleventsoverviewinstance = 0;
			/// <summary>IDX: 1 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int coleventsoverviewname_102 = 1;
			/// <summary>IDX: 1 | Type: read</summary>
			public const int coleventsoverviewname = 1;
			/// <summary>IDX: 2 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int coleventsoverviewstatus_103 = 2;
			/// <summary>IDX: 2 | Type: read</summary>
			public const int coleventsoverviewstatus = 2;
		}
	}
}
public class WriteParameters
{
	/// <summary>PID: 50  | Type: write | DISCREETS: Populate Static = 1</summary>
	public System.Object Btnstaticpopulatetable {get { return Protocol.GetParameter(50); }set { Protocol.SetParameter(50, value); }}
	/// <summary>PID: 201  | Type: write</summary>
	public System.Object Coleventsoverviewinstance {get { return Protocol.GetParameter(201); }set { Protocol.SetParameter(201, value); }}
	/// <summary>PID: 202  | Type: write</summary>
	public System.Object Coleventsoverviewname {get { return Protocol.GetParameter(202); }set { Protocol.SetParameter(202, value); }}
	/// <summary>PID: 203  | Type: write | DISCREETS: Pending = 0, Scheduled = 1, Busy = 2, Finished = 3</summary>
	public System.Object Coleventsoverviewstatus {get { return Protocol.GetParameter(203); }set { Protocol.SetParameter(203, value); }}
	public SLProtocolExt Protocol;
	public WriteParameters(SLProtocolExt protocol)
	{
		Protocol = protocol;
	}
}
public interface SLProtocolExt : SLProtocol
{
	/// <summary>PID: 100</summary>
	TbleventsoverviewQActionTable tbleventsoverview { get; set; }
	object Afterstartup_dummy { get; set; }
	object Btnstaticpopulatetable_50 { get; set; }
	object Btnstaticpopulatetable { get; set; }
	object Coleventsoverviewinstance_101 { get; set; }
	object Coleventsoverviewinstance { get; set; }
	object Coleventsoverviewname_102 { get; set; }
	object Coleventsoverviewname { get; set; }
	object Coleventsoverviewstatus_103 { get; set; }
	object Coleventsoverviewstatus { get; set; }
	object Coleventsoverviewinstance_201 { get; set; }
	object Coleventsoverviewname_202 { get; set; }
	object Coleventsoverviewstatus_203 { get; set; }
	WriteParameters Write { get; set; }
}
public class ConcreteSLProtocolExt : ConcreteSLProtocol, SLProtocolExt
{
	/// <summary>PID: 100</summary>
	public TbleventsoverviewQActionTable tbleventsoverview { get; set; }
	/// <summary>PID: 2  | Type: dummy</summary>
	public System.Object Afterstartup_dummy {get { return GetParameter(2); }set { SetParameter(2, value); }}
	/// <summary>PID: 50  | Type: write | DISCREETS: Populate Static = 1</summary>
	public System.Object Btnstaticpopulatetable_50 {get { return GetParameter(50); }set { SetParameter(50, value); }}
	/// <summary>PID: 50  | Type: write | DISCREETS: Populate Static = 1</summary>
	public System.Object Btnstaticpopulatetable {get { return Write.Btnstaticpopulatetable; }set { Write.Btnstaticpopulatetable = value; }}
	/// <summary>PID: 101  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Coleventsoverviewinstance_101 {get { return GetParameter(101); }set { SetParameter(101, value); }}
	/// <summary>PID: 101  | Type: read</summary>
	public System.Object Coleventsoverviewinstance {get { return GetParameter(101); }set { SetParameter(101, value); }}
	/// <summary>PID: 102  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Coleventsoverviewname_102 {get { return GetParameter(102); }set { SetParameter(102, value); }}
	/// <summary>PID: 102  | Type: read</summary>
	public System.Object Coleventsoverviewname {get { return GetParameter(102); }set { SetParameter(102, value); }}
	/// <summary>PID: 103  | Type: read | DISCREETS: Pending = 0, Scheduled = 1, Busy = 2, Finished = 3</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Coleventsoverviewstatus_103 {get { return GetParameter(103); }set { SetParameter(103, value); }}
	/// <summary>PID: 103  | Type: read | DISCREETS: Pending = 0, Scheduled = 1, Busy = 2, Finished = 3</summary>
	public System.Object Coleventsoverviewstatus {get { return GetParameter(103); }set { SetParameter(103, value); }}
	/// <summary>PID: 201  | Type: write</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Coleventsoverviewinstance_201 {get { return GetParameter(201); }set { SetParameter(201, value); }}
	/// <summary>PID: 202  | Type: write</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Coleventsoverviewname_202 {get { return GetParameter(202); }set { SetParameter(202, value); }}
	/// <summary>PID: 203  | Type: write | DISCREETS: Pending = 0, Scheduled = 1, Busy = 2, Finished = 3</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Coleventsoverviewstatus_203 {get { return GetParameter(203); }set { SetParameter(203, value); }}
	public WriteParameters Write { get; set; }
	public ConcreteSLProtocolExt()
	{
		tbleventsoverview = new TbleventsoverviewQActionTable(this, 100, "tbleventsoverview");
		Write = new WriteParameters(this);
	}
}
/// <summary>IDX: 0</summary>
public class TbleventsoverviewQActionTable : QActionTable, IEnumerable<TbleventsoverviewQActionRow>
{
	public TbleventsoverviewQActionTable(SLProtocol protocol, int tableId, string tableName) : base(protocol, tableId, tableName) { }
	IEnumerator IEnumerable.GetEnumerator() { return (IEnumerator) GetEnumerator(); }
	public IEnumerator<TbleventsoverviewQActionRow> GetEnumerator() { return new QActionTableEnumerator<TbleventsoverviewQActionRow>(this); }
}
/// <summary>IDX: 0</summary>
public class TbleventsoverviewQActionRow : QActionTableRow
{
	/// <summary>PID: 101 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Coleventsoverviewinstance_101 { get { if (base.Columns.ContainsKey(0)) { return base.Columns[0]; } else { return null; } } set { if (base.Columns.ContainsKey(0)) { base.Columns[0] = value; } else { base.Columns.Add(0, value); } } }
	/// <summary>PID: 101 | Type: read</summary>
	public System.Object Coleventsoverviewinstance { get { if (base.Columns.ContainsKey(0)) { return base.Columns[0]; } else { return null; } } set { if (base.Columns.ContainsKey(0)) { base.Columns[0] = value; } else { base.Columns.Add(0, value); } } }
	/// <summary>PID: 102 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Coleventsoverviewname_102 { get { if (base.Columns.ContainsKey(1)) { return base.Columns[1]; } else { return null; } } set { if (base.Columns.ContainsKey(1)) { base.Columns[1] = value; } else { base.Columns.Add(1, value); } } }
	/// <summary>PID: 102 | Type: read</summary>
	public System.Object Coleventsoverviewname { get { if (base.Columns.ContainsKey(1)) { return base.Columns[1]; } else { return null; } } set { if (base.Columns.ContainsKey(1)) { base.Columns[1] = value; } else { base.Columns.Add(1, value); } } }
	/// <summary>PID: 103 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Coleventsoverviewstatus_103 { get { if (base.Columns.ContainsKey(2)) { return base.Columns[2]; } else { return null; } } set { if (base.Columns.ContainsKey(2)) { base.Columns[2] = value; } else { base.Columns.Add(2, value); } } }
	/// <summary>PID: 103 | Type: read</summary>
	public System.Object Coleventsoverviewstatus { get { if (base.Columns.ContainsKey(2)) { return base.Columns[2]; } else { return null; } } set { if (base.Columns.ContainsKey(2)) { base.Columns[2] = value; } else { base.Columns.Add(2, value); } } }
	public TbleventsoverviewQActionRow() : base(0, 3) { }
	public TbleventsoverviewQActionRow(System.Object[] oRow) : base(0, 3, oRow) { }
	public static implicit operator TbleventsoverviewQActionRow(System.Object[] source) { return new TbleventsoverviewQActionRow(source); }
	public static implicit operator System.Object[](TbleventsoverviewQActionRow source) { return source.ToObjectArray(); }
}
}
