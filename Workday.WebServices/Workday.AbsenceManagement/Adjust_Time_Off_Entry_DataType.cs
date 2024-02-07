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
	public class Adjust_Time_Off_Entry_DataType : INotifyPropertyChanged
	{
		private string time_Off_Entry_IDField;

		private Time_Off_EntryObjectType time_Off_Entry_ReferenceField;

		private decimal adjustment_to_RequestedField;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Time_Off_Entry_ID
		{
			get
			{
				return this.time_Off_Entry_IDField;
			}
			set
			{
				this.time_Off_Entry_IDField = value;
				this.RaisePropertyChanged("Time_Off_Entry_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Time_Off_EntryObjectType Time_Off_Entry_Reference
		{
			get
			{
				return this.time_Off_Entry_ReferenceField;
			}
			set
			{
				this.time_Off_Entry_ReferenceField = value;
				this.RaisePropertyChanged("Time_Off_Entry_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Adjustment_to_Requested
		{
			get
			{
				return this.adjustment_to_RequestedField;
			}
			set
			{
				this.adjustment_to_RequestedField = value;
				this.RaisePropertyChanged("Adjustment_to_Requested");
			}
		}

		[XmlElement(Order = 3)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
