using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Revaluation_Run_DataType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_or_Company_Hierarchy_ReferenceField;

		private Unique_IdentifierObjectType fiscal_Period_for_Revaluation_ReferenceField;

		private Revaluation_RuleObjectType revaluation_Rule_ReferenceField;

		private DateTime revaluation_Reversal_DateField;

		private bool revaluation_Reversal_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_or_Company_Hierarchy_Reference", Order = 0)]
		public OrganizationObjectType[] Company_or_Company_Hierarchy_Reference
		{
			get
			{
				return this.company_or_Company_Hierarchy_ReferenceField;
			}
			set
			{
				this.company_or_Company_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Company_or_Company_Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Unique_IdentifierObjectType Fiscal_Period_for_Revaluation_Reference
		{
			get
			{
				return this.fiscal_Period_for_Revaluation_ReferenceField;
			}
			set
			{
				this.fiscal_Period_for_Revaluation_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Period_for_Revaluation_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Revaluation_RuleObjectType Revaluation_Rule_Reference
		{
			get
			{
				return this.revaluation_Rule_ReferenceField;
			}
			set
			{
				this.revaluation_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Revaluation_Rule_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Revaluation_Reversal_Date
		{
			get
			{
				return this.revaluation_Reversal_DateField;
			}
			set
			{
				this.revaluation_Reversal_DateField = value;
				this.RaisePropertyChanged("Revaluation_Reversal_Date");
			}
		}

		[XmlIgnore]
		public bool Revaluation_Reversal_DateSpecified
		{
			get
			{
				return this.revaluation_Reversal_DateFieldSpecified;
			}
			set
			{
				this.revaluation_Reversal_DateFieldSpecified = value;
				this.RaisePropertyChanged("Revaluation_Reversal_DateSpecified");
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
