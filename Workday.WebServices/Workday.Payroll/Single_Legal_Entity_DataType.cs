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
	public class Single_Legal_Entity_DataType : INotifyPropertyChanged
	{
		private Calendar_YearObjectType reporting_Tax_Year_ReferenceField;

		private Calendar_YearObjectType inactive_asof_Tax_Year_ReferenceField;

		private CompanyObjectType legal_Entity_ReferenceField;

		private CompanyObjectType[] related_Companies_ReferenceField;

		private Withholding_Order_TypeObjectType[] withholding_Order_Type_ReferenceField;

		private bool periodic_Combined_Tax_FilingField;

		private bool periodic_Combined_Tax_FilingFieldSpecified;

		private string federal_Tax_IDField;

		private string single_Legal_Entity_TypeField;

		private string financial_Tax_ReportingField;

		private string combined_Financial_YE_for_all_companiesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Calendar_YearObjectType Reporting_Tax_Year_Reference
		{
			get
			{
				return this.reporting_Tax_Year_ReferenceField;
			}
			set
			{
				this.reporting_Tax_Year_ReferenceField = value;
				this.RaisePropertyChanged("Reporting_Tax_Year_Reference");
			}
		}

		[XmlElement("Inactive_as-of_Tax_Year_Reference", Order = 1)]
		public Calendar_YearObjectType Inactive_asof_Tax_Year_Reference
		{
			get
			{
				return this.inactive_asof_Tax_Year_ReferenceField;
			}
			set
			{
				this.inactive_asof_Tax_Year_ReferenceField = value;
				this.RaisePropertyChanged("Inactive_asof_Tax_Year_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public CompanyObjectType Legal_Entity_Reference
		{
			get
			{
				return this.legal_Entity_ReferenceField;
			}
			set
			{
				this.legal_Entity_ReferenceField = value;
				this.RaisePropertyChanged("Legal_Entity_Reference");
			}
		}

		[XmlElement("Related_Companies_Reference", Order = 3)]
		public CompanyObjectType[] Related_Companies_Reference
		{
			get
			{
				return this.related_Companies_ReferenceField;
			}
			set
			{
				this.related_Companies_ReferenceField = value;
				this.RaisePropertyChanged("Related_Companies_Reference");
			}
		}

		[XmlElement("Withholding_Order_Type_Reference", Order = 4)]
		public Withholding_Order_TypeObjectType[] Withholding_Order_Type_Reference
		{
			get
			{
				return this.withholding_Order_Type_ReferenceField;
			}
			set
			{
				this.withholding_Order_Type_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Order_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public bool Periodic_Combined_Tax_Filing
		{
			get
			{
				return this.periodic_Combined_Tax_FilingField;
			}
			set
			{
				this.periodic_Combined_Tax_FilingField = value;
				this.RaisePropertyChanged("Periodic_Combined_Tax_Filing");
			}
		}

		[XmlIgnore]
		public bool Periodic_Combined_Tax_FilingSpecified
		{
			get
			{
				return this.periodic_Combined_Tax_FilingFieldSpecified;
			}
			set
			{
				this.periodic_Combined_Tax_FilingFieldSpecified = value;
				this.RaisePropertyChanged("Periodic_Combined_Tax_FilingSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Federal_Tax_ID
		{
			get
			{
				return this.federal_Tax_IDField;
			}
			set
			{
				this.federal_Tax_IDField = value;
				this.RaisePropertyChanged("Federal_Tax_ID");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Single_Legal_Entity_Type
		{
			get
			{
				return this.single_Legal_Entity_TypeField;
			}
			set
			{
				this.single_Legal_Entity_TypeField = value;
				this.RaisePropertyChanged("Single_Legal_Entity_Type");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Financial_Tax_Reporting
		{
			get
			{
				return this.financial_Tax_ReportingField;
			}
			set
			{
				this.financial_Tax_ReportingField = value;
				this.RaisePropertyChanged("Financial_Tax_Reporting");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Combined_Financial_YE_for_all_companies
		{
			get
			{
				return this.combined_Financial_YE_for_all_companiesField;
			}
			set
			{
				this.combined_Financial_YE_for_all_companiesField = value;
				this.RaisePropertyChanged("Combined_Financial_YE_for_all_companies");
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
