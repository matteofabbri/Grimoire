using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_Message_Detail_DataType : INotifyPropertyChanged
	{
		private DateTime timestampField;

		private bool timestampFieldSpecified;

		private Background_Process_Message_Severity_LevelObjectType severity_Level_ReferenceField;

		private string message_SummaryField;

		private string message_DetailField;

		private InstanceObjectType[] message_Target_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Timestamp
		{
			get
			{
				return this.timestampField;
			}
			set
			{
				this.timestampField = value;
				this.RaisePropertyChanged("Timestamp");
			}
		}

		[XmlIgnore]
		public bool TimestampSpecified
		{
			get
			{
				return this.timestampFieldSpecified;
			}
			set
			{
				this.timestampFieldSpecified = value;
				this.RaisePropertyChanged("TimestampSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Background_Process_Message_Severity_LevelObjectType Severity_Level_Reference
		{
			get
			{
				return this.severity_Level_ReferenceField;
			}
			set
			{
				this.severity_Level_ReferenceField = value;
				this.RaisePropertyChanged("Severity_Level_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Message_Summary
		{
			get
			{
				return this.message_SummaryField;
			}
			set
			{
				this.message_SummaryField = value;
				this.RaisePropertyChanged("Message_Summary");
			}
		}

		[XmlElement(Order = 3)]
		public string Message_Detail
		{
			get
			{
				return this.message_DetailField;
			}
			set
			{
				this.message_DetailField = value;
				this.RaisePropertyChanged("Message_Detail");
			}
		}

		[XmlElement("Message_Target_Reference", Order = 4)]
		public InstanceObjectType[] Message_Target_Reference
		{
			get
			{
				return this.message_Target_ReferenceField;
			}
			set
			{
				this.message_Target_ReferenceField = value;
				this.RaisePropertyChanged("Message_Target_Reference");
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
