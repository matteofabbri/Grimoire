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
	public class Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_for_Tax_Election_ReferenceField;

		private DateTime effective_DateField;

		private CompanyObjectType company_for_Tax_Election_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Payroll_Payee_Ongoing_Jurisdiction_Splits_Tax_Election_DataType[] payroll_Payee_Ongoing_Jurisdiction_SplitField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_for_Tax_Election_Reference
		{
			get
			{
				return this.worker_for_Tax_Election_ReferenceField;
			}
			set
			{
				this.worker_for_Tax_Election_ReferenceField = value;
				this.RaisePropertyChanged("Worker_for_Tax_Election_Reference");
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
		public CompanyObjectType Company_for_Tax_Election_Reference
		{
			get
			{
				return this.company_for_Tax_Election_ReferenceField;
			}
			set
			{
				this.company_for_Tax_Election_ReferenceField = value;
				this.RaisePropertyChanged("Company_for_Tax_Election_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement("Payroll_Payee_Ongoing_Jurisdiction_Split", Order = 4)]
		public Payroll_Payee_Ongoing_Jurisdiction_Splits_Tax_Election_DataType[] Payroll_Payee_Ongoing_Jurisdiction_Split
		{
			get
			{
				return this.payroll_Payee_Ongoing_Jurisdiction_SplitField;
			}
			set
			{
				this.payroll_Payee_Ongoing_Jurisdiction_SplitField = value;
				this.RaisePropertyChanged("Payroll_Payee_Ongoing_Jurisdiction_Split");
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
