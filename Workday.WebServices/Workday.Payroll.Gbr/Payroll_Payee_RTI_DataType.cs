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
	public class Payroll_Payee_RTI_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private DateTime effective_As_OfField;

		private bool effective_As_OfFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private bool irregular_Payment_PatternField;

		private bool irregular_Payment_PatternFieldSpecified;

		private Payroll_Constant_TextObjectType late_PAYE_Reporting_Reason_ReferenceField;

		private bool fPS_Submitted_for_Deceased_WorkerField;

		private bool fPS_Submitted_for_Deceased_WorkerFieldSpecified;

		private bool override_Contract_End_DateField;

		private bool override_Contract_End_DateFieldSpecified;

		private DateTime contract_End_DateField;

		private bool contract_End_DateFieldSpecified;

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
		public DateTime Effective_As_Of
		{
			get
			{
				return this.effective_As_OfField;
			}
			set
			{
				this.effective_As_OfField = value;
				this.RaisePropertyChanged("Effective_As_Of");
			}
		}

		[XmlIgnore]
		public bool Effective_As_OfSpecified
		{
			get
			{
				return this.effective_As_OfFieldSpecified;
			}
			set
			{
				this.effective_As_OfFieldSpecified = value;
				this.RaisePropertyChanged("Effective_As_OfSpecified");
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
		public bool Irregular_Payment_Pattern
		{
			get
			{
				return this.irregular_Payment_PatternField;
			}
			set
			{
				this.irregular_Payment_PatternField = value;
				this.RaisePropertyChanged("Irregular_Payment_Pattern");
			}
		}

		[XmlIgnore]
		public bool Irregular_Payment_PatternSpecified
		{
			get
			{
				return this.irregular_Payment_PatternFieldSpecified;
			}
			set
			{
				this.irregular_Payment_PatternFieldSpecified = value;
				this.RaisePropertyChanged("Irregular_Payment_PatternSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Payroll_Constant_TextObjectType Late_PAYE_Reporting_Reason_Reference
		{
			get
			{
				return this.late_PAYE_Reporting_Reason_ReferenceField;
			}
			set
			{
				this.late_PAYE_Reporting_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Late_PAYE_Reporting_Reason_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public bool FPS_Submitted_for_Deceased_Worker
		{
			get
			{
				return this.fPS_Submitted_for_Deceased_WorkerField;
			}
			set
			{
				this.fPS_Submitted_for_Deceased_WorkerField = value;
				this.RaisePropertyChanged("FPS_Submitted_for_Deceased_Worker");
			}
		}

		[XmlIgnore]
		public bool FPS_Submitted_for_Deceased_WorkerSpecified
		{
			get
			{
				return this.fPS_Submitted_for_Deceased_WorkerFieldSpecified;
			}
			set
			{
				this.fPS_Submitted_for_Deceased_WorkerFieldSpecified = value;
				this.RaisePropertyChanged("FPS_Submitted_for_Deceased_WorkerSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Override_Contract_End_Date
		{
			get
			{
				return this.override_Contract_End_DateField;
			}
			set
			{
				this.override_Contract_End_DateField = value;
				this.RaisePropertyChanged("Override_Contract_End_Date");
			}
		}

		[XmlIgnore]
		public bool Override_Contract_End_DateSpecified
		{
			get
			{
				return this.override_Contract_End_DateFieldSpecified;
			}
			set
			{
				this.override_Contract_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Override_Contract_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Contract_End_Date
		{
			get
			{
				return this.contract_End_DateField;
			}
			set
			{
				this.contract_End_DateField = value;
				this.RaisePropertyChanged("Contract_End_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_End_DateSpecified
		{
			get
			{
				return this.contract_End_DateFieldSpecified;
			}
			set
			{
				this.contract_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_End_DateSpecified");
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
