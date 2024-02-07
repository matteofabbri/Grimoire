using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Time_In_Time_Out_WWS_DataType : INotifyPropertyChanged
	{
		private DateTime time_InField;

		private bool time_InFieldSpecified;

		private DateTime time_OutField;

		private bool time_OutFieldSpecified;

		private Time_Entry_CodeObjectType time_Card_Factor_ReferenceField;

		private string time_In_Time_Out_MemoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Time_In
		{
			get
			{
				return this.time_InField;
			}
			set
			{
				this.time_InField = value;
				this.RaisePropertyChanged("Time_In");
			}
		}

		[XmlIgnore]
		public bool Time_InSpecified
		{
			get
			{
				return this.time_InFieldSpecified;
			}
			set
			{
				this.time_InFieldSpecified = value;
				this.RaisePropertyChanged("Time_InSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Time_Out
		{
			get
			{
				return this.time_OutField;
			}
			set
			{
				this.time_OutField = value;
				this.RaisePropertyChanged("Time_Out");
			}
		}

		[XmlIgnore]
		public bool Time_OutSpecified
		{
			get
			{
				return this.time_OutFieldSpecified;
			}
			set
			{
				this.time_OutFieldSpecified = value;
				this.RaisePropertyChanged("Time_OutSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Time_Entry_CodeObjectType Time_Card_Factor_Reference
		{
			get
			{
				return this.time_Card_Factor_ReferenceField;
			}
			set
			{
				this.time_Card_Factor_ReferenceField = value;
				this.RaisePropertyChanged("Time_Card_Factor_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Time_In_Time_Out_Memo
		{
			get
			{
				return this.time_In_Time_Out_MemoField;
			}
			set
			{
				this.time_In_Time_Out_MemoField = value;
				this.RaisePropertyChanged("Time_In_Time_Out_Memo");
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
