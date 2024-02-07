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
	public class Usage_Billing_Rate_Rule_DataType : INotifyPropertyChanged
	{
		private Billing_Rate_RuleObjectType billing_Rate_Rule_ReferenceField;

		private Frequency_BehaviorObjectType reset_Frequency_ReferenceField;

		private DateTime start_Date_for_ResetField;

		private bool start_Date_for_ResetFieldSpecified;

		private decimal itemField;

		private ItemChoiceType2 itemElementNameField;

		private string notesField;

		private Unit_of_MeasureObjectType[] unit_of_Measure_ReferenceField;

		private Usage_Billing_Rate_Rule_Break_DataType[] usage_Billing_Rate_Rule_Break_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Billing_Rate_RuleObjectType Billing_Rate_Rule_Reference
		{
			get
			{
				return this.billing_Rate_Rule_ReferenceField;
			}
			set
			{
				this.billing_Rate_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Rate_Rule_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Frequency_BehaviorObjectType Reset_Frequency_Reference
		{
			get
			{
				return this.reset_Frequency_ReferenceField;
			}
			set
			{
				this.reset_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Reset_Frequency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Start_Date_for_Reset
		{
			get
			{
				return this.start_Date_for_ResetField;
			}
			set
			{
				this.start_Date_for_ResetField = value;
				this.RaisePropertyChanged("Start_Date_for_Reset");
			}
		}

		[XmlIgnore]
		public bool Start_Date_for_ResetSpecified
		{
			get
			{
				return this.start_Date_for_ResetFieldSpecified;
			}
			set
			{
				this.start_Date_for_ResetFieldSpecified = value;
				this.RaisePropertyChanged("Start_Date_for_ResetSpecified");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Minimum_Amount", typeof(decimal), Order = 3), XmlElement("Minimum_Count", typeof(decimal), Order = 3)]
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

		[XmlElement(Order = 4), XmlIgnore]
		public ItemChoiceType2 ItemElementName
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

		[XmlElement(Order = 5)]
		public string Notes
		{
			get
			{
				return this.notesField;
			}
			set
			{
				this.notesField = value;
				this.RaisePropertyChanged("Notes");
			}
		}

		[XmlElement("Unit_of_Measure_Reference", Order = 6)]
		public Unit_of_MeasureObjectType[] Unit_of_Measure_Reference
		{
			get
			{
				return this.unit_of_Measure_ReferenceField;
			}
			set
			{
				this.unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Measure_Reference");
			}
		}

		[XmlElement("Usage_Billing_Rate_Rule_Break_Data", Order = 7)]
		public Usage_Billing_Rate_Rule_Break_DataType[] Usage_Billing_Rate_Rule_Break_Data
		{
			get
			{
				return this.usage_Billing_Rate_Rule_Break_DataField;
			}
			set
			{
				this.usage_Billing_Rate_Rule_Break_DataField = value;
				this.RaisePropertyChanged("Usage_Billing_Rate_Rule_Break_Data");
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
