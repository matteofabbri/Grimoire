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
	public class Payment_Message_Group_WWS_DataType : INotifyPropertyChanged
	{
		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private Payment_MethodObjectType payment_Method_ReferenceField;

		private Payment_CategoryObjectType payment_Category_ReferenceField;

		private Originating_Party_WWS_DataType[] originating_Contact_DataField;

		private Originating_Party_Bank_DataType[] originating_Bank_DataField;

		private decimal group_Payment_CountField;

		private bool group_Payment_CountFieldSpecified;

		private decimal group_Rejected_Payment_CountField;

		private bool group_Rejected_Payment_CountFieldSpecified;

		private decimal group_Reprocessed_Payment_CountField;

		private bool group_Reprocessed_Payment_CountFieldSpecified;

		private decimal group_Payment_SumField;

		private bool group_Payment_SumFieldSpecified;

		private string group_IDField;

		private Payment_WWS_DataType[] payment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_DateSpecified
		{
			get
			{
				return this.payment_DateFieldSpecified;
			}
			set
			{
				this.payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Payment_MethodObjectType Payment_Method_Reference
		{
			get
			{
				return this.payment_Method_ReferenceField;
			}
			set
			{
				this.payment_Method_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Method_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Payment_CategoryObjectType Payment_Category_Reference
		{
			get
			{
				return this.payment_Category_ReferenceField;
			}
			set
			{
				this.payment_Category_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Category_Reference");
			}
		}

		[XmlElement("Originating_Contact_Data", Order = 5)]
		public Originating_Party_WWS_DataType[] Originating_Contact_Data
		{
			get
			{
				return this.originating_Contact_DataField;
			}
			set
			{
				this.originating_Contact_DataField = value;
				this.RaisePropertyChanged("Originating_Contact_Data");
			}
		}

		[XmlElement("Originating_Bank_Data", Order = 6)]
		public Originating_Party_Bank_DataType[] Originating_Bank_Data
		{
			get
			{
				return this.originating_Bank_DataField;
			}
			set
			{
				this.originating_Bank_DataField = value;
				this.RaisePropertyChanged("Originating_Bank_Data");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Group_Payment_Count
		{
			get
			{
				return this.group_Payment_CountField;
			}
			set
			{
				this.group_Payment_CountField = value;
				this.RaisePropertyChanged("Group_Payment_Count");
			}
		}

		[XmlIgnore]
		public bool Group_Payment_CountSpecified
		{
			get
			{
				return this.group_Payment_CountFieldSpecified;
			}
			set
			{
				this.group_Payment_CountFieldSpecified = value;
				this.RaisePropertyChanged("Group_Payment_CountSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Group_Rejected_Payment_Count
		{
			get
			{
				return this.group_Rejected_Payment_CountField;
			}
			set
			{
				this.group_Rejected_Payment_CountField = value;
				this.RaisePropertyChanged("Group_Rejected_Payment_Count");
			}
		}

		[XmlIgnore]
		public bool Group_Rejected_Payment_CountSpecified
		{
			get
			{
				return this.group_Rejected_Payment_CountFieldSpecified;
			}
			set
			{
				this.group_Rejected_Payment_CountFieldSpecified = value;
				this.RaisePropertyChanged("Group_Rejected_Payment_CountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Group_Reprocessed_Payment_Count
		{
			get
			{
				return this.group_Reprocessed_Payment_CountField;
			}
			set
			{
				this.group_Reprocessed_Payment_CountField = value;
				this.RaisePropertyChanged("Group_Reprocessed_Payment_Count");
			}
		}

		[XmlIgnore]
		public bool Group_Reprocessed_Payment_CountSpecified
		{
			get
			{
				return this.group_Reprocessed_Payment_CountFieldSpecified;
			}
			set
			{
				this.group_Reprocessed_Payment_CountFieldSpecified = value;
				this.RaisePropertyChanged("Group_Reprocessed_Payment_CountSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Group_Payment_Sum
		{
			get
			{
				return this.group_Payment_SumField;
			}
			set
			{
				this.group_Payment_SumField = value;
				this.RaisePropertyChanged("Group_Payment_Sum");
			}
		}

		[XmlIgnore]
		public bool Group_Payment_SumSpecified
		{
			get
			{
				return this.group_Payment_SumFieldSpecified;
			}
			set
			{
				this.group_Payment_SumFieldSpecified = value;
				this.RaisePropertyChanged("Group_Payment_SumSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public string Group_ID
		{
			get
			{
				return this.group_IDField;
			}
			set
			{
				this.group_IDField = value;
				this.RaisePropertyChanged("Group_ID");
			}
		}

		[XmlElement("Payment_Data", Order = 12)]
		public Payment_WWS_DataType[] Payment_Data
		{
			get
			{
				return this.payment_DataField;
			}
			set
			{
				this.payment_DataField = value;
				this.RaisePropertyChanged("Payment_Data");
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
