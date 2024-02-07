using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Pensions_Auto_Enrolment_Details_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private DateTime effective_DateField;

		private CompanyObjectType company_ReferenceField;

		private DateTime deferral_DateField;

		private bool deferral_DateFieldSpecified;

		private bool eligible_for_Tax_ReliefField;

		private bool eligible_for_Tax_ReliefFieldSpecified;

		private bool itemField;

		private ItemChoiceType itemElementNameField;

		private bool exception_from_Employer_DutiesField;

		private bool exception_from_Employer_DutiesFieldSpecified;

		private string reason_for_ExceptionField;

		private bool exception_RemovedField;

		private bool exception_RemovedFieldSpecified;

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

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Deferral_Date
		{
			get
			{
				return this.deferral_DateField;
			}
			set
			{
				this.deferral_DateField = value;
				this.RaisePropertyChanged("Deferral_Date");
			}
		}

		[XmlIgnore]
		public bool Deferral_DateSpecified
		{
			get
			{
				return this.deferral_DateFieldSpecified;
			}
			set
			{
				this.deferral_DateFieldSpecified = value;
				this.RaisePropertyChanged("Deferral_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Eligible_for_Tax_Relief
		{
			get
			{
				return this.eligible_for_Tax_ReliefField;
			}
			set
			{
				this.eligible_for_Tax_ReliefField = value;
				this.RaisePropertyChanged("Eligible_for_Tax_Relief");
			}
		}

		[XmlIgnore]
		public bool Eligible_for_Tax_ReliefSpecified
		{
			get
			{
				return this.eligible_for_Tax_ReliefFieldSpecified;
			}
			set
			{
				this.eligible_for_Tax_ReliefFieldSpecified = value;
				this.RaisePropertyChanged("Eligible_for_Tax_ReliefSpecified");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Opt_In", typeof(bool), Order = 5), XmlElement("Opt_Out_during_Postponement", typeof(bool), Order = 5)]
		public bool Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 6), XmlIgnore]
		public ItemChoiceType ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 7)]
		public bool Exception_from_Employer_Duties
		{
			get
			{
				return this.exception_from_Employer_DutiesField;
			}
			set
			{
				this.exception_from_Employer_DutiesField = value;
				this.RaisePropertyChanged("Exception_from_Employer_Duties");
			}
		}

		[XmlIgnore]
		public bool Exception_from_Employer_DutiesSpecified
		{
			get
			{
				return this.exception_from_Employer_DutiesFieldSpecified;
			}
			set
			{
				this.exception_from_Employer_DutiesFieldSpecified = value;
				this.RaisePropertyChanged("Exception_from_Employer_DutiesSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public string Reason_for_Exception
		{
			get
			{
				return this.reason_for_ExceptionField;
			}
			set
			{
				this.reason_for_ExceptionField = value;
				this.RaisePropertyChanged("Reason_for_Exception");
			}
		}

		[XmlElement(Order = 9)]
		public bool Exception_Removed
		{
			get
			{
				return this.exception_RemovedField;
			}
			set
			{
				this.exception_RemovedField = value;
				this.RaisePropertyChanged("Exception_Removed");
			}
		}

		[XmlIgnore]
		public bool Exception_RemovedSpecified
		{
			get
			{
				return this.exception_RemovedFieldSpecified;
			}
			set
			{
				this.exception_RemovedFieldSpecified = value;
				this.RaisePropertyChanged("Exception_RemovedSpecified");
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
