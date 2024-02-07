using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "W-2_W-2C_Printing_Election_Request_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class W2_W2C_Printing_Election_Request_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private CompanyObjectType[] company_ReferenceField;

		private bool receive_only_electronic_copies_of_W2_W2C_ReferenceField;

		private bool receive_only_electronic_copies_of_W2_W2C_ReferenceFieldSpecified;

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

		[XmlElement("Company_Reference", Order = 1)]
		public CompanyObjectType[] Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement("Receive_only_electronic_copies_of_W-2_W-2C_Reference", Order = 2)]
		public bool Receive_only_electronic_copies_of_W2_W2C_Reference
		{
			get
			{
				return this.receive_only_electronic_copies_of_W2_W2C_ReferenceField;
			}
			set
			{
				this.receive_only_electronic_copies_of_W2_W2C_ReferenceField = value;
				this.RaisePropertyChanged("Receive_only_electronic_copies_of_W2_W2C_Reference");
			}
		}

		[XmlIgnore]
		public bool Receive_only_electronic_copies_of_W2_W2C_ReferenceSpecified
		{
			get
			{
				return this.receive_only_electronic_copies_of_W2_W2C_ReferenceFieldSpecified;
			}
			set
			{
				this.receive_only_electronic_copies_of_W2_W2C_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Receive_only_electronic_copies_of_W2_W2C_ReferenceSpecified");
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
