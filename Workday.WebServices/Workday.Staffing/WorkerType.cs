using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class WorkerType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private string worker_DescriptorField;

		private Universal_IdentifierObjectType universal_Identifier_ReferenceField;

		private Worker_DataType worker_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Worker_Descriptor
		{
			get
			{
				return this.worker_DescriptorField;
			}
			set
			{
				this.worker_DescriptorField = value;
				this.RaisePropertyChanged("Worker_Descriptor");
			}
		}

		[XmlElement(Order = 2)]
		public Universal_IdentifierObjectType Universal_Identifier_Reference
		{
			get
			{
				return this.universal_Identifier_ReferenceField;
			}
			set
			{
				this.universal_Identifier_ReferenceField = value;
				this.RaisePropertyChanged("Universal_Identifier_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Worker_DataType Worker_Data
		{
			get
			{
				return this.worker_DataField;
			}
			set
			{
				this.worker_DataField = value;
				this.RaisePropertyChanged("Worker_Data");
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
