using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_Plan_DataType : INotifyPropertyChanged
	{
		private string compensation_Plan_IDField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private string nameField;

		private string descriptionField;

		private Condition_RuleObjectType[] eligibility_Rule_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private object itemField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Compensation_Plan_ID
		{
			get
			{
				return this.compensation_Plan_IDField;
			}
			set
			{
				this.compensation_Plan_IDField = value;
				this.RaisePropertyChanged("Compensation_Plan_ID");
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement("Eligibility_Rule_Reference", Order = 4)]
		public Condition_RuleObjectType[] Eligibility_Rule_Reference
		{
			get
			{
				return this.eligibility_Rule_ReferenceField;
			}
			set
			{
				this.eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Eligibility_Rule_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement("Allowance_Plan_Data", typeof(Allowance_Plan_DataType), Order = 6), XmlElement("Base_Pay_Plan_Data", typeof(Base_Pay_Plan_DataType), Order = 6), XmlElement("Bonus_Plan_Data", typeof(Bonus_Plan_DataType), Order = 6), XmlElement("Calculated_Plan_Data", typeof(Calculated_Plan_DataType), Order = 6), XmlElement("Commission_Plan_Data", typeof(Commission_Plan_DataType), Order = 6), XmlElement("Future_Payment_Plan_Data", typeof(Future_Payment_Plan_DataType), Order = 6), XmlElement("Merit_Plan_Data", typeof(Merit_Plan_DataType), Order = 6), XmlElement("Period_Plan_Data", typeof(Period_Plan_DataType), Order = 6), XmlElement("Stock_Plan_Data", typeof(Stock_Plan_DataType), Order = 6)]
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
