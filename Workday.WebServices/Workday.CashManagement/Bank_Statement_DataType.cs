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
	public class Bank_Statement_DataType : INotifyPropertyChanged
	{
		private string bank_Statement_Reference_IDField;

		private Bank_Statement_FileObjectType bank_Statement_File_ReferenceField;

		private string customer_Account_NumberField;

		private string routing_NumberField;

		private DateTime statement_Begin_DateField;

		private bool statement_Begin_DateFieldSpecified;

		private DateTime statement_End_DateField;

		private bool statement_End_DateFieldSpecified;

		private bool same_Day_Bank_StatementField;

		private bool same_Day_Bank_StatementFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Bank_Statement_Summary_DataType[] bank_Statement_Summary_DataField;

		private Bank_Statement_Transaction_DataType[] bank_Statement_Transaction_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Bank_Statement_Reference_ID
		{
			get
			{
				return this.bank_Statement_Reference_IDField;
			}
			set
			{
				this.bank_Statement_Reference_IDField = value;
				this.RaisePropertyChanged("Bank_Statement_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Bank_Statement_FileObjectType Bank_Statement_File_Reference
		{
			get
			{
				return this.bank_Statement_File_ReferenceField;
			}
			set
			{
				this.bank_Statement_File_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Statement_File_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Customer_Account_Number
		{
			get
			{
				return this.customer_Account_NumberField;
			}
			set
			{
				this.customer_Account_NumberField = value;
				this.RaisePropertyChanged("Customer_Account_Number");
			}
		}

		[XmlElement(Order = 3)]
		public string Routing_Number
		{
			get
			{
				return this.routing_NumberField;
			}
			set
			{
				this.routing_NumberField = value;
				this.RaisePropertyChanged("Routing_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Statement_Begin_Date
		{
			get
			{
				return this.statement_Begin_DateField;
			}
			set
			{
				this.statement_Begin_DateField = value;
				this.RaisePropertyChanged("Statement_Begin_Date");
			}
		}

		[XmlIgnore]
		public bool Statement_Begin_DateSpecified
		{
			get
			{
				return this.statement_Begin_DateFieldSpecified;
			}
			set
			{
				this.statement_Begin_DateFieldSpecified = value;
				this.RaisePropertyChanged("Statement_Begin_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Statement_End_Date
		{
			get
			{
				return this.statement_End_DateField;
			}
			set
			{
				this.statement_End_DateField = value;
				this.RaisePropertyChanged("Statement_End_Date");
			}
		}

		[XmlIgnore]
		public bool Statement_End_DateSpecified
		{
			get
			{
				return this.statement_End_DateFieldSpecified;
			}
			set
			{
				this.statement_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Statement_End_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Same_Day_Bank_Statement
		{
			get
			{
				return this.same_Day_Bank_StatementField;
			}
			set
			{
				this.same_Day_Bank_StatementField = value;
				this.RaisePropertyChanged("Same_Day_Bank_Statement");
			}
		}

		[XmlIgnore]
		public bool Same_Day_Bank_StatementSpecified
		{
			get
			{
				return this.same_Day_Bank_StatementFieldSpecified;
			}
			set
			{
				this.same_Day_Bank_StatementFieldSpecified = value;
				this.RaisePropertyChanged("Same_Day_Bank_StatementSpecified");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement("Bank_Statement_Summary_Data", Order = 8)]
		public Bank_Statement_Summary_DataType[] Bank_Statement_Summary_Data
		{
			get
			{
				return this.bank_Statement_Summary_DataField;
			}
			set
			{
				this.bank_Statement_Summary_DataField = value;
				this.RaisePropertyChanged("Bank_Statement_Summary_Data");
			}
		}

		[XmlElement("Bank_Statement_Transaction_Data", Order = 9)]
		public Bank_Statement_Transaction_DataType[] Bank_Statement_Transaction_Data
		{
			get
			{
				return this.bank_Statement_Transaction_DataField;
			}
			set
			{
				this.bank_Statement_Transaction_DataField = value;
				this.RaisePropertyChanged("Bank_Statement_Transaction_Data");
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
