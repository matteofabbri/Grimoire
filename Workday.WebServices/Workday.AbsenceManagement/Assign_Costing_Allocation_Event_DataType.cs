using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_Costing_Allocation_Event_DataType : INotifyPropertyChanged
	{
		private Costing_Allocation_Interval_DataType[] costing_Override_DataField;

		private Costing_Allocation_LevelObjectType costing_Allocation_Level_ReferenceField;

		private Earning__All_ObjectType costing_Allocation_Earning_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Costing_Override_Data", Order = 0)]
		public Costing_Allocation_Interval_DataType[] Costing_Override_Data
		{
			get
			{
				return this.costing_Override_DataField;
			}
			set
			{
				this.costing_Override_DataField = value;
				this.RaisePropertyChanged("Costing_Override_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Costing_Allocation_LevelObjectType Costing_Allocation_Level_Reference
		{
			get
			{
				return this.costing_Allocation_Level_ReferenceField;
			}
			set
			{
				this.costing_Allocation_Level_ReferenceField = value;
				this.RaisePropertyChanged("Costing_Allocation_Level_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Earning__All_ObjectType Costing_Allocation_Earning_Reference
		{
			get
			{
				return this.costing_Allocation_Earning_ReferenceField;
			}
			set
			{
				this.costing_Allocation_Earning_ReferenceField = value;
				this.RaisePropertyChanged("Costing_Allocation_Earning_Reference");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
