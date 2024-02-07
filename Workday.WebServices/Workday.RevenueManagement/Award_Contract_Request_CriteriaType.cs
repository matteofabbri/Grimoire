using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Contract_Request_CriteriaType : INotifyPropertyChanged
	{
		private SponsorObjectType[] sponsor_ReferenceField;

		private string award_NameField;

		private string award_Reference_IDField;

		private CompanyObjectType company_ReferenceField;

		private Document_StatusObjectType[] award_Status_ReferenceField;

		private DateTime award_Effective_Date_On_or_AfterField;

		private bool award_Effective_Date_On_or_AfterFieldSpecified;

		private DateTime award_Effective_Date_On_or_BeforeField;

		private bool award_Effective_Date_On_or_BeforeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Sponsor_Reference", Order = 0)]
		public SponsorObjectType[] Sponsor_Reference
		{
			get
			{
				return this.sponsor_ReferenceField;
			}
			set
			{
				this.sponsor_ReferenceField = value;
				this.RaisePropertyChanged("Sponsor_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Award_Name
		{
			get
			{
				return this.award_NameField;
			}
			set
			{
				this.award_NameField = value;
				this.RaisePropertyChanged("Award_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Award_Reference_ID
		{
			get
			{
				return this.award_Reference_IDField;
			}
			set
			{
				this.award_Reference_IDField = value;
				this.RaisePropertyChanged("Award_Reference_ID");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement("Award_Status_Reference", Order = 4)]
		public Document_StatusObjectType[] Award_Status_Reference
		{
			get
			{
				return this.award_Status_ReferenceField;
			}
			set
			{
				this.award_Status_ReferenceField = value;
				this.RaisePropertyChanged("Award_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Award_Effective_Date_On_or_After
		{
			get
			{
				return this.award_Effective_Date_On_or_AfterField;
			}
			set
			{
				this.award_Effective_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Award_Effective_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Award_Effective_Date_On_or_AfterSpecified
		{
			get
			{
				return this.award_Effective_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.award_Effective_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Award_Effective_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Award_Effective_Date_On_or_Before
		{
			get
			{
				return this.award_Effective_Date_On_or_BeforeField;
			}
			set
			{
				this.award_Effective_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Award_Effective_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Award_Effective_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.award_Effective_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.award_Effective_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Award_Effective_Date_On_or_BeforeSpecified");
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
