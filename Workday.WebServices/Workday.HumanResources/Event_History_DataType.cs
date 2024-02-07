using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Event_History_DataType : INotifyPropertyChanged
	{
		private string event_IDField;

		private Business_Process_Type_Reference_DataType event_Type_ReferenceField;

		private string descriptionField;

		private DateTime completed_DateTimeField;

		private bool completed_DateTimeFieldSpecified;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Event_ID
		{
			get
			{
				return this.event_IDField;
			}
			set
			{
				this.event_IDField = value;
				this.RaisePropertyChanged("Event_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Business_Process_Type_Reference_DataType Event_Type_Reference
		{
			get
			{
				return this.event_Type_ReferenceField;
			}
			set
			{
				this.event_Type_ReferenceField = value;
				this.RaisePropertyChanged("Event_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Completed_DateTime
		{
			get
			{
				return this.completed_DateTimeField;
			}
			set
			{
				this.completed_DateTimeField = value;
				this.RaisePropertyChanged("Completed_DateTime");
			}
		}

		[XmlIgnore]
		public bool Completed_DateTimeSpecified
		{
			get
			{
				return this.completed_DateTimeFieldSpecified;
			}
			set
			{
				this.completed_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("Completed_DateTimeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
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
