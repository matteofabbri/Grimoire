using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Paycheck_Delivery_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private DateTime date_Last_UpdatedField;

		private bool date_Last_UpdatedFieldSpecified;

		private Paycheck_Delivery_MethodObjectType paycheck_Delivery_Method_ReferenceField;

		private Payslip_Printing_OverrideObjectType payslip_Printing_Override_ReferenceField;

		private CompanyObjectType company_ReferenceField;

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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Date_Last_Updated
		{
			get
			{
				return this.date_Last_UpdatedField;
			}
			set
			{
				this.date_Last_UpdatedField = value;
				this.RaisePropertyChanged("Date_Last_Updated");
			}
		}

		[XmlIgnore]
		public bool Date_Last_UpdatedSpecified
		{
			get
			{
				return this.date_Last_UpdatedFieldSpecified;
			}
			set
			{
				this.date_Last_UpdatedFieldSpecified = value;
				this.RaisePropertyChanged("Date_Last_UpdatedSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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
