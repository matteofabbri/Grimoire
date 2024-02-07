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
	public class Recruiting_Agency_Career_Site_Configuration_DataType : INotifyPropertyChanged
	{
		private Applicant_SourceObjectType source_ReferenceField;

		private decimal ownership_PeriodField;

		private bool ownership_PeriodFieldSpecified;

		private Unique_IdentifierObjectType job_Posting_Template_ReferenceField;

		private LocationObjectType[] restrict_to_Locations_ReferenceField;

		private string terms_and_ConditionsField;

		private bool require_esignatureField;

		private bool require_esignatureFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Applicant_SourceObjectType Source_Reference
		{
			get
			{
				return this.source_ReferenceField;
			}
			set
			{
				this.source_ReferenceField = value;
				this.RaisePropertyChanged("Source_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Ownership_Period
		{
			get
			{
				return this.ownership_PeriodField;
			}
			set
			{
				this.ownership_PeriodField = value;
				this.RaisePropertyChanged("Ownership_Period");
			}
		}

		[XmlIgnore]
		public bool Ownership_PeriodSpecified
		{
			get
			{
				return this.ownership_PeriodFieldSpecified;
			}
			set
			{
				this.ownership_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Ownership_PeriodSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Restrict_to_Locations_Reference", Order = 3)]
		public LocationObjectType[] Restrict_to_Locations_Reference
		{
			get
			{
				return this.restrict_to_Locations_ReferenceField;
			}
			set
			{
				this.restrict_to_Locations_ReferenceField = value;
				this.RaisePropertyChanged("Restrict_to_Locations_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Terms_and_Conditions
		{
			get
			{
				return this.terms_and_ConditionsField;
			}
			set
			{
				this.terms_and_ConditionsField = value;
				this.RaisePropertyChanged("Terms_and_Conditions");
			}
		}

		[XmlElement("Require_e-signature", Order = 5)]
		public bool Require_esignature
		{
			get
			{
				return this.require_esignatureField;
			}
			set
			{
				this.require_esignatureField = value;
				this.RaisePropertyChanged("Require_esignature");
			}
		}

		[XmlIgnore]
		public bool Require_esignatureSpecified
		{
			get
			{
				return this.require_esignatureFieldSpecified;
			}
			set
			{
				this.require_esignatureFieldSpecified = value;
				this.RaisePropertyChanged("Require_esignatureSpecified");
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
