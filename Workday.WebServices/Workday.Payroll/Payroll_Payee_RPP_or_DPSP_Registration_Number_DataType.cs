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
	public class Payroll_Payee_RPP_or_DPSP_Registration_Number_DataType : INotifyPropertyChanged
	{
		private Payroll_Payee_RPP_or_DPSP_Registration_NumbersObjectType payroll_Payee_RPP_or_DPSP_Registration_Number_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private DateTime effective_DateField;

		private string rPP_or_DPSP_Registration_NumberField;

		private DateTime last_UpdatedField;

		private bool last_UpdatedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Payee_RPP_or_DPSP_Registration_NumbersObjectType Payroll_Payee_RPP_or_DPSP_Registration_Number_Reference
		{
			get
			{
				return this.payroll_Payee_RPP_or_DPSP_Registration_Number_ReferenceField;
			}
			set
			{
				this.payroll_Payee_RPP_or_DPSP_Registration_Number_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payee_RPP_or_DPSP_Registration_Number_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(Order = 4)]
		public string RPP_or_DPSP_Registration_Number
		{
			get
			{
				return this.rPP_or_DPSP_Registration_NumberField;
			}
			set
			{
				this.rPP_or_DPSP_Registration_NumberField = value;
				this.RaisePropertyChanged("RPP_or_DPSP_Registration_Number");
			}
		}

		[XmlElement(Order = 5)]
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
