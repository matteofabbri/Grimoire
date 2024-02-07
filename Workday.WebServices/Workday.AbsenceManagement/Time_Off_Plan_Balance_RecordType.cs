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
	public class Time_Off_Plan_Balance_RecordType : INotifyPropertyChanged
	{
		private Absence_Plan__All_ObjectType time_Off_Plan_ReferenceField;

		private Unit_of_TimeObjectType unit_of_Time_ReferenceField;

		private Time_Off_Plan_Balance_Position_RecordType[] time_Off_Plan_Balance_Position_RecordField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Absence_Plan__All_ObjectType Time_Off_Plan_Reference
		{
			get
			{
				return this.time_Off_Plan_ReferenceField;
			}
			set
			{
				this.time_Off_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Time_Off_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Unit_of_TimeObjectType Unit_of_Time_Reference
		{
			get
			{
				return this.unit_of_Time_ReferenceField;
			}
			set
			{
				this.unit_of_Time_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Time_Reference");
			}
		}

		[XmlElement("Time_Off_Plan_Balance_Position_Record", Order = 2)]
		public Time_Off_Plan_Balance_Position_RecordType[] Time_Off_Plan_Balance_Position_Record
		{
			get
			{
				return this.time_Off_Plan_Balance_Position_RecordField;
			}
			set
			{
				this.time_Off_Plan_Balance_Position_RecordField = value;
				this.RaisePropertyChanged("Time_Off_Plan_Balance_Position_Record");
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
