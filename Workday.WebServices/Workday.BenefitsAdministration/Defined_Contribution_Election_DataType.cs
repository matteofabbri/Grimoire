using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Defined_Contribution_Election_DataType : INotifyPropertyChanged
	{
		private Retirement_Savings_PlanObjectType defined_Contribution_Plan_ReferenceField;

		private decimal itemField;

		private ItemChoiceType itemElementNameField;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private Defined_Contribution_Beneficiary_Allocation_DataType[] beneficiary_Allocation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Retirement_Savings_PlanObjectType Defined_Contribution_Plan_Reference
		{
			get
			{
				return this.defined_Contribution_Plan_ReferenceField;
			}
			set
			{
				this.defined_Contribution_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Defined_Contribution_Plan_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Election_Amount", typeof(decimal), Order = 1), XmlElement("Election_Percentage", typeof(decimal), Order = 1)]
		public decimal Item
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

		[XmlElement(Order = 2), XmlIgnore]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement("Beneficiary_Allocation_Data", Order = 5)]
		public Defined_Contribution_Beneficiary_Allocation_DataType[] Beneficiary_Allocation_Data
		{
			get
			{
				return this.beneficiary_Allocation_DataField;
			}
			set
			{
				this.beneficiary_Allocation_DataField = value;
				this.RaisePropertyChanged("Beneficiary_Allocation_Data");
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
