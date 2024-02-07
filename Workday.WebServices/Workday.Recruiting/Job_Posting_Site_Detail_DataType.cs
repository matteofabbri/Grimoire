using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Job_Posting_Site_Detail_DataType : INotifyPropertyChanged
	{
		private string job_Posting_Site_NameField;

		private string job_Posting_Site_IDField;

		private string contract_IDField;

		private decimal job_Posting_CostField;

		private bool job_Posting_CostFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Applicant_SourceObjectType recruiting_Source_ReferenceField;

		private Unique_IdentifierObjectType job_Posting_Template_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Job_Posting_Site_Name
		{
			get
			{
				return this.job_Posting_Site_NameField;
			}
			set
			{
				this.job_Posting_Site_NameField = value;
				this.RaisePropertyChanged("Job_Posting_Site_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Job_Posting_Site_ID
		{
			get
			{
				return this.job_Posting_Site_IDField;
			}
			set
			{
				this.job_Posting_Site_IDField = value;
				this.RaisePropertyChanged("Job_Posting_Site_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Contract_ID
		{
			get
			{
				return this.contract_IDField;
			}
			set
			{
				this.contract_IDField = value;
				this.RaisePropertyChanged("Contract_ID");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Job_Posting_Cost
		{
			get
			{
				return this.job_Posting_CostField;
			}
			set
			{
				this.job_Posting_CostField = value;
				this.RaisePropertyChanged("Job_Posting_Cost");
			}
		}

		[XmlIgnore]
		public bool Job_Posting_CostSpecified
		{
			get
			{
				return this.job_Posting_CostFieldSpecified;
			}
			set
			{
				this.job_Posting_CostFieldSpecified = value;
				this.RaisePropertyChanged("Job_Posting_CostSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Applicant_SourceObjectType Recruiting_Source_Reference
		{
			get
			{
				return this.recruiting_Source_ReferenceField;
			}
			set
			{
				this.recruiting_Source_ReferenceField = value;
				this.RaisePropertyChanged("Recruiting_Source_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Unique_IdentifierObjectType Job_Posting_Template_Reference
		{
			get
			{
				return this.job_Posting_Template_ReferenceField;
			}
			set
			{
				this.job_Posting_Template_ReferenceField = value;
				this.RaisePropertyChanged("Job_Posting_Template_Reference");
			}
		}

		[XmlElement(Order = 7)]
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
