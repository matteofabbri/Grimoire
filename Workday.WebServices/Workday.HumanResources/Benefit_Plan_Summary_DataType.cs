using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Benefit_Plan_Summary_DataType : INotifyPropertyChanged
	{
		private Benefit_PlanObjectType benefit_Plan_ReferenceField;

		private string benefit_Plan_NameField;

		private string group_IdentifierField;

		private Benefit_Coverage_TypeObjectType benefit_Coverage_Type_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private Health_Care_ClassificationObjectType health_Care_Classification_ReferenceField;

		private Insurance_Coverage_TargetObjectType insurance_Coverage_Target_ReferenceField;

		private Benefit_Provider_Summary_DataType benefit_Provider_Summary_DataField;

		private IDType[] external_Integration_ID_DataField;

		private Pay_ComponentObjectType[] pay_Component_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Benefit_PlanObjectType Benefit_Plan_Reference
		{
			get
			{
				return this.benefit_Plan_ReferenceField;
			}
			set
			{
				this.benefit_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Benefit_Plan_Name
		{
			get
			{
				return this.benefit_Plan_NameField;
			}
			set
			{
				this.benefit_Plan_NameField = value;
				this.RaisePropertyChanged("Benefit_Plan_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Group_Identifier
		{
			get
			{
				return this.group_IdentifierField;
			}
			set
			{
				this.group_IdentifierField = value;
				this.RaisePropertyChanged("Group_Identifier");
			}
		}

		[XmlElement(Order = 3)]
		public Benefit_Coverage_TypeObjectType Benefit_Coverage_Type_Reference
		{
			get
			{
				return this.benefit_Coverage_Type_ReferenceField;
			}
			set
			{
				this.benefit_Coverage_Type_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Coverage_Type_Reference");
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

		[XmlElement(Order = 6)]
		public Health_Care_ClassificationObjectType Health_Care_Classification_Reference
		{
			get
			{
				return this.health_Care_Classification_ReferenceField;
			}
			set
			{
				this.health_Care_Classification_ReferenceField = value;
				this.RaisePropertyChanged("Health_Care_Classification_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Insurance_Coverage_TargetObjectType Insurance_Coverage_Target_Reference
		{
			get
			{
				return this.insurance_Coverage_Target_ReferenceField;
			}
			set
			{
				this.insurance_Coverage_Target_ReferenceField = value;
				this.RaisePropertyChanged("Insurance_Coverage_Target_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Benefit_Provider_Summary_DataType Benefit_Provider_Summary_Data
		{
			get
			{
				return this.benefit_Provider_Summary_DataField;
			}
			set
			{
				this.benefit_Provider_Summary_DataField = value;
				this.RaisePropertyChanged("Benefit_Provider_Summary_Data");
			}
		}

		[XmlArray(Order = 9), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] External_Integration_ID_Data
		{
			get
			{
				return this.external_Integration_ID_DataField;
			}
			set
			{
				this.external_Integration_ID_DataField = value;
				this.RaisePropertyChanged("External_Integration_ID_Data");
			}
		}

		[XmlElement("Pay_Component_Reference", Order = 10)]
		public Pay_ComponentObjectType[] Pay_Component_Reference
		{
			get
			{
				return this.pay_Component_ReferenceField;
			}
			set
			{
				this.pay_Component_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Component_Reference");
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
