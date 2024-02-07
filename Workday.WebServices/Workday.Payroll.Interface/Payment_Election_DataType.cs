using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payment_Election_DataType : INotifyPropertyChanged
	{
		private decimal orderField;

		private Payment_Election_RuleObjectType payment_Election_Rule_ReferenceField;

		private CountryObjectType country_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private Worker_Bank_Account_WWS_DataType worker_Bank_Account_DataField;

		private object itemField;

		private ItemChoiceType itemElementNameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 1)]
		public Payment_Election_RuleObjectType Payment_Election_Rule_Reference
		{
			get
			{
				return this.payment_Election_Rule_ReferenceField;
			}
			set
			{
				this.payment_Election_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Election_Rule_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
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
		public Payment_TypeObjectType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Worker_Bank_Account_WWS_DataType Worker_Bank_Account_Data
		{
			get
			{
				return this.worker_Bank_Account_DataField;
			}
			set
			{
				this.worker_Bank_Account_DataField = value;
				this.RaisePropertyChanged("Worker_Bank_Account_Data");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Distribution_Amount", typeof(decimal), Order = 6), XmlElement("Distribution_Balance", typeof(bool), Order = 6), XmlElement("Distribution_Percentage", typeof(decimal), Order = 6)]
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

		[XmlElement(Order = 7), XmlIgnore]
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
