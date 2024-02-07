using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Bank_Statement_Summary_DataType : INotifyPropertyChanged
	{
		private Bank_Statement_Balance_Type_ReferenceType bank_Statement_Balance_Type_ReferenceField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal item_CountField;

		private bool item_CountFieldSpecified;

		private Funds_Availability_DataType[] funds_Availability_DataField;

		private string alternate_Balance_Type_CodeField;

		private bool debitField;

		private bool debitFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Bank_Statement_Balance_Type_ReferenceType Bank_Statement_Balance_Type_Reference
		{
			get
			{
				return this.bank_Statement_Balance_Type_ReferenceField;
			}
			set
			{
				this.bank_Statement_Balance_Type_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Statement_Balance_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Item_Count
		{
			get
			{
				return this.item_CountField;
			}
			set
			{
				this.item_CountField = value;
				this.RaisePropertyChanged("Item_Count");
			}
		}

		[XmlIgnore]
		public bool Item_CountSpecified
		{
			get
			{
				return this.item_CountFieldSpecified;
			}
			set
			{
				this.item_CountFieldSpecified = value;
				this.RaisePropertyChanged("Item_CountSpecified");
			}
		}

		[XmlElement("Funds_Availability_Data", Order = 3)]
		public Funds_Availability_DataType[] Funds_Availability_Data
		{
			get
			{
				return this.funds_Availability_DataField;
			}
			set
			{
				this.funds_Availability_DataField = value;
				this.RaisePropertyChanged("Funds_Availability_Data");
			}
		}

		[XmlElement(Order = 4)]
		public string Alternate_Balance_Type_Code
		{
			get
			{
				return this.alternate_Balance_Type_CodeField;
			}
			set
			{
				this.alternate_Balance_Type_CodeField = value;
				this.RaisePropertyChanged("Alternate_Balance_Type_Code");
			}
		}

		[XmlElement(Order = 5)]
		public bool Debit
		{
			get
			{
				return this.debitField;
			}
			set
			{
				this.debitField = value;
				this.RaisePropertyChanged("Debit");
			}
		}

		[XmlIgnore]
		public bool DebitSpecified
		{
			get
			{
				return this.debitFieldSpecified;
			}
			set
			{
				this.debitFieldSpecified = value;
				this.RaisePropertyChanged("DebitSpecified");
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
