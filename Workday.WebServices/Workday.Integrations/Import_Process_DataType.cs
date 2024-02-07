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
	public class Import_Process_DataType : INotifyPropertyChanged
	{
		private string process_DescriptionField;

		private decimal percent_CompleteField;

		private bool percent_CompleteFieldSpecified;

		private DateTime process_Completed_DateTimeField;

		private bool process_Completed_DateTimeFieldSpecified;

		private InstanceObjectType import_Header_ReferenceField;

		private Background_Process_Runtime_StatusObjectType status_ReferenceField;

		private bool has_MessagesField;

		private bool has_MessagesFieldSpecified;

		private bool validate_OnlyField;

		private bool validate_OnlyFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Process_Description
		{
			get
			{
				return this.process_DescriptionField;
			}
			set
			{
				this.process_DescriptionField = value;
				this.RaisePropertyChanged("Process_Description");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Percent_Complete
		{
			get
			{
				return this.percent_CompleteField;
			}
			set
			{
				this.percent_CompleteField = value;
				this.RaisePropertyChanged("Percent_Complete");
			}
		}

		[XmlIgnore]
		public bool Percent_CompleteSpecified
		{
			get
			{
				return this.percent_CompleteFieldSpecified;
			}
			set
			{
				this.percent_CompleteFieldSpecified = value;
				this.RaisePropertyChanged("Percent_CompleteSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Process_Completed_DateTime
		{
			get
			{
				return this.process_Completed_DateTimeField;
			}
			set
			{
				this.process_Completed_DateTimeField = value;
				this.RaisePropertyChanged("Process_Completed_DateTime");
			}
		}

		[XmlIgnore]
		public bool Process_Completed_DateTimeSpecified
		{
			get
			{
				return this.process_Completed_DateTimeFieldSpecified;
			}
			set
			{
				this.process_Completed_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("Process_Completed_DateTimeSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public InstanceObjectType Import_Header_Reference
		{
			get
			{
				return this.import_Header_ReferenceField;
			}
			set
			{
				this.import_Header_ReferenceField = value;
				this.RaisePropertyChanged("Import_Header_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Background_Process_Runtime_StatusObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public bool Has_Messages
		{
			get
			{
				return this.has_MessagesField;
			}
			set
			{
				this.has_MessagesField = value;
				this.RaisePropertyChanged("Has_Messages");
			}
		}

		[XmlIgnore]
		public bool Has_MessagesSpecified
		{
			get
			{
				return this.has_MessagesFieldSpecified;
			}
			set
			{
				this.has_MessagesFieldSpecified = value;
				this.RaisePropertyChanged("Has_MessagesSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Validate_Only
		{
			get
			{
				return this.validate_OnlyField;
			}
			set
			{
				this.validate_OnlyField = value;
				this.RaisePropertyChanged("Validate_Only");
			}
		}

		[XmlIgnore]
		public bool Validate_OnlySpecified
		{
			get
			{
				return this.validate_OnlyFieldSpecified;
			}
			set
			{
				this.validate_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Validate_OnlySpecified");
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
