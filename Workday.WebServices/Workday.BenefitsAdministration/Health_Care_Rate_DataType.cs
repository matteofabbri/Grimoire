using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Health_Care_Rate_DataType : INotifyPropertyChanged
	{
		private string health_Care_Rate_IDField;

		private string nameField;

		private string descriptionField;

		private bool use_Minimum_CostField;

		private bool use_Minimum_CostFieldSpecified;

		private bool use_Maximum_CostField;

		private bool use_Maximum_CostFieldSpecified;

		private FrequencyObjectType frequency_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Health_Care_Coverage_TargetObjectType[] health_Care_Coverage_Target_ReferenceField;

		private object itemField;

		private object[] itemsField;

		private bool consider_TobaccoField;

		private bool consider_TobaccoFieldSpecified;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Health_Care_Rate_ID
		{
			get
			{
				return this.health_Care_Rate_IDField;
			}
			set
			{
				this.health_Care_Rate_IDField = value;
				this.RaisePropertyChanged("Health_Care_Rate_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 3)]
		public bool Use_Minimum_Cost
		{
			get
			{
				return this.use_Minimum_CostField;
			}
			set
			{
				this.use_Minimum_CostField = value;
				this.RaisePropertyChanged("Use_Minimum_Cost");
			}
		}

		[XmlIgnore]
		public bool Use_Minimum_CostSpecified
		{
			get
			{
				return this.use_Minimum_CostFieldSpecified;
			}
			set
			{
				this.use_Minimum_CostFieldSpecified = value;
				this.RaisePropertyChanged("Use_Minimum_CostSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Use_Maximum_Cost
		{
			get
			{
				return this.use_Maximum_CostField;
			}
			set
			{
				this.use_Maximum_CostField = value;
				this.RaisePropertyChanged("Use_Maximum_Cost");
			}
		}

		[XmlIgnore]
		public bool Use_Maximum_CostSpecified
		{
			get
			{
				return this.use_Maximum_CostFieldSpecified;
			}
			set
			{
				this.use_Maximum_CostFieldSpecified = value;
				this.RaisePropertyChanged("Use_Maximum_CostSpecified");
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

		[XmlElement("Health_Care_Coverage_Target_Reference", Order = 7)]
		public Health_Care_Coverage_TargetObjectType[] Health_Care_Coverage_Target_Reference
		{
			get
			{
				return this.health_Care_Coverage_Target_ReferenceField;
			}
			set
			{
				this.health_Care_Coverage_Target_ReferenceField = value;
				this.RaisePropertyChanged("Health_Care_Coverage_Target_Reference");
			}
		}

		[XmlElement("Age_in_Years_Data", typeof(Age_in_Years_DataType), Order = 8), XmlElement("Length_of_Service_Data", typeof(Length_of_Service_DataType), Order = 8), XmlElement("Salary_Data", typeof(Salary_DataType), Order = 8)]
		public object Item
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

		[XmlElement("Health_Care_Rate_Flat_Data", typeof(Health_Care_Rate_Flat_DataType), Order = 9), XmlElement("Health_Care_Rate_Percent_Salary_Data", typeof(Health_Care_Rate_Percent_Salary_DataType), Order = 9)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlElement(Order = 10)]
		public bool Consider_Tobacco
		{
			get
			{
				return this.consider_TobaccoField;
			}
			set
			{
				this.consider_TobaccoField = value;
				this.RaisePropertyChanged("Consider_Tobacco");
			}
		}

		[XmlIgnore]
		public bool Consider_TobaccoSpecified
		{
			get
			{
				return this.consider_TobaccoFieldSpecified;
			}
			set
			{
				this.consider_TobaccoFieldSpecified = value;
				this.RaisePropertyChanged("Consider_TobaccoSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
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

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
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
