using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Paycheck_Delivery__Public__ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType paycheck_Delivery_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Paycheck_Delivery_MethodObjectType paycheck_Delivery_Method_ReferenceField;

		private Payslip_Printing_OverrideObjectType payslip_Printing_Override_ReferenceField;

		private DateTime last_UpdatedField;

		private bool last_UpdatedFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Paycheck_Delivery_Reference
		{
			get
			{
				return this.paycheck_Delivery_ReferenceField;
			}
			set
			{
				this.paycheck_Delivery_ReferenceField = value;
				this.RaisePropertyChanged("Paycheck_Delivery_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public CompanyObjectType Company_Reference
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

		[XmlElement(Order = 3)]
		public Paycheck_Delivery_MethodObjectType Paycheck_Delivery_Method_Reference
		{
			get
			{
				return this.paycheck_Delivery_Method_ReferenceField;
			}
			set
			{
				this.paycheck_Delivery_Method_ReferenceField = value;
				this.RaisePropertyChanged("Paycheck_Delivery_Method_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Payslip_Printing_OverrideObjectType Payslip_Printing_Override_Reference
		{
			get
			{
				return this.payslip_Printing_Override_ReferenceField;
			}
			set
			{
				this.payslip_Printing_Override_ReferenceField = value;
				this.RaisePropertyChanged("Payslip_Printing_Override_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Last_Updated
		{
			get
			{
				return this.last_UpdatedField;
			}
			set
			{
				this.last_UpdatedField = value;
				this.RaisePropertyChanged("Last_Updated");
			}
		}

		[XmlIgnore]
		public bool Last_UpdatedSpecified
		{
			get
			{
				return this.last_UpdatedFieldSpecified;
			}
			set
			{
				this.last_UpdatedFieldSpecified = value;
				this.RaisePropertyChanged("Last_UpdatedSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
