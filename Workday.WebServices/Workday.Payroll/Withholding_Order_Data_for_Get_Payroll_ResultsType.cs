using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Withholding_Order_Data_for_Get_Payroll_ResultsType : INotifyPropertyChanged
	{
		private string case_NumberField;

		private string withholding_Order_TypeField;

		private DateTime order_DateField;

		private bool order_DateFieldSpecified;

		private DateTime received_DateField;

		private bool received_DateFieldSpecified;

		private DateTime begin_DateField;

		private bool begin_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private string order_StatusField;

		private decimal order_PriorityField;

		private bool order_PriorityFieldSpecified;

		private decimal total_Debt_AmountField;

		private bool total_Debt_AmountFieldSpecified;

		private Withholding_Order_Amount_TypeObjectType pay_Period_Amount_Type_ReferenceField;

		private decimal itemField;

		private ItemChoiceType itemElementNameField;

		private FrequencyObjectType pay_Period_Frequency_ReferenceField;

		private Payroll_Tax_AuthorityObjectType payroll_Tax_Authority_ReferenceField;

		private Deduction_RecipientObjectType deduction_Recipient_ReferenceField;

		private Unique_IdentifierObjectType[] deduction_Recipient_Instant_Messenger_ReferenceField;

		private Settlement_Bank_AccountObjectType deduction_Recipient_Bank_Account_ReferenceField;

		private string originating_EntityField;

		private string memoField;

		private Address_Information_DataType[] deduction_Recipient_Address_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Case_Number
		{
			get
			{
				return this.case_NumberField;
			}
			set
			{
				this.case_NumberField = value;
				this.RaisePropertyChanged("Case_Number");
			}
		}

		[XmlElement(Order = 1)]
		public string Withholding_Order_Type
		{
			get
			{
				return this.withholding_Order_TypeField;
			}
			set
			{
				this.withholding_Order_TypeField = value;
				this.RaisePropertyChanged("Withholding_Order_Type");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Order_Date
		{
			get
			{
				return this.order_DateField;
			}
			set
			{
				this.order_DateField = value;
				this.RaisePropertyChanged("Order_Date");
			}
		}

		[XmlIgnore]
		public bool Order_DateSpecified
		{
			get
			{
				return this.order_DateFieldSpecified;
			}
			set
			{
				this.order_DateFieldSpecified = value;
				this.RaisePropertyChanged("Order_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Received_Date
		{
			get
			{
				return this.received_DateField;
			}
			set
			{
				this.received_DateField = value;
				this.RaisePropertyChanged("Received_Date");
			}
		}

		[XmlIgnore]
		public bool Received_DateSpecified
		{
			get
			{
				return this.received_DateFieldSpecified;
			}
			set
			{
				this.received_DateFieldSpecified = value;
				this.RaisePropertyChanged("Received_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Begin_Date
		{
			get
			{
				return this.begin_DateField;
			}
			set
			{
				this.begin_DateField = value;
				this.RaisePropertyChanged("Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Begin_DateSpecified
		{
			get
			{
				return this.begin_DateFieldSpecified;
			}
			set
			{
				this.begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Order_Status
		{
			get
			{
				return this.order_StatusField;
			}
			set
			{
				this.order_StatusField = value;
				this.RaisePropertyChanged("Order_Status");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Order_Priority
		{
			get
			{
				return this.order_PriorityField;
			}
			set
			{
				this.order_PriorityField = value;
				this.RaisePropertyChanged("Order_Priority");
			}
		}

		[XmlIgnore]
		public bool Order_PrioritySpecified
		{
			get
			{
				return this.order_PriorityFieldSpecified;
			}
			set
			{
				this.order_PriorityFieldSpecified = value;
				this.RaisePropertyChanged("Order_PrioritySpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Total_Debt_Amount
		{
			get
			{
				return this.total_Debt_AmountField;
			}
			set
			{
				this.total_Debt_AmountField = value;
				this.RaisePropertyChanged("Total_Debt_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Debt_AmountSpecified
		{
			get
			{
				return this.total_Debt_AmountFieldSpecified;
			}
			set
			{
				this.total_Debt_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Debt_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Withholding_Order_Amount_TypeObjectType Pay_Period_Amount_Type_Reference
		{
			get
			{
				return this.pay_Period_Amount_Type_ReferenceField;
			}
			set
			{
				this.pay_Period_Amount_Type_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Period_Amount_Type_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Pay_Period_Amount", typeof(decimal), Order = 10), XmlElement("Pay_Period_Amount_as_Percent", typeof(decimal), Order = 10)]
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

		[XmlElement(Order = 11), XmlIgnore]
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

		[XmlElement(Order = 12)]
		public FrequencyObjectType Pay_Period_Frequency_Reference
		{
			get
			{
				return this.pay_Period_Frequency_ReferenceField;
			}
			set
			{
				this.pay_Period_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Period_Frequency_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Payroll_Tax_AuthorityObjectType Payroll_Tax_Authority_Reference
		{
			get
			{
				return this.payroll_Tax_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Tax_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Tax_Authority_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Deduction_RecipientObjectType Deduction_Recipient_Reference
		{
			get
			{
				return this.deduction_Recipient_ReferenceField;
			}
			set
			{
				this.deduction_Recipient_ReferenceField = value;
				this.RaisePropertyChanged("Deduction_Recipient_Reference");
			}
		}

		[XmlElement("Deduction_Recipient_Instant_Messenger_Reference", Order = 15)]
		public Unique_IdentifierObjectType[] Deduction_Recipient_Instant_Messenger_Reference
		{
			get
			{
				return this.deduction_Recipient_Instant_Messenger_ReferenceField;
			}
			set
			{
				this.deduction_Recipient_Instant_Messenger_ReferenceField = value;
				this.RaisePropertyChanged("Deduction_Recipient_Instant_Messenger_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Settlement_Bank_AccountObjectType Deduction_Recipient_Bank_Account_Reference
		{
			get
			{
				return this.deduction_Recipient_Bank_Account_ReferenceField;
			}
			set
			{
				this.deduction_Recipient_Bank_Account_ReferenceField = value;
				this.RaisePropertyChanged("Deduction_Recipient_Bank_Account_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public string Originating_Entity
		{
			get
			{
				return this.originating_EntityField;
			}
			set
			{
				this.originating_EntityField = value;
				this.RaisePropertyChanged("Originating_Entity");
			}
		}

		[XmlElement(Order = 18)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement("Deduction_Recipient_Address_Data", Order = 19)]
		public Address_Information_DataType[] Deduction_Recipient_Address_Data
		{
			get
			{
				return this.deduction_Recipient_Address_DataField;
			}
			set
			{
				this.deduction_Recipient_Address_DataField = value;
				this.RaisePropertyChanged("Deduction_Recipient_Address_Data");
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
