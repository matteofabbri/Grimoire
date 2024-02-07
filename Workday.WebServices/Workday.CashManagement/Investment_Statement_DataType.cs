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
	public class Investment_Statement_DataType : INotifyPropertyChanged
	{
		private string idField;

		private bool submitField;

		private bool submitFieldSpecified;

		private Investment_ProfileObjectType investment_Profile_ReferenceField;

		private DateTime statement_Beginning_DateField;

		private bool statement_Beginning_DateFieldSpecified;

		private DateTime statement_DateField;

		private decimal ending_BalanceField;

		private bool ending_BalanceFieldSpecified;

		private string memoField;

		private Investment_Statement_Line_DataType[] investment_Statement_Line_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Investment_ProfileObjectType Investment_Profile_Reference
		{
			get
			{
				return this.investment_Profile_ReferenceField;
			}
			set
			{
				this.investment_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Profile_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Statement_Beginning_Date
		{
			get
			{
				return this.statement_Beginning_DateField;
			}
			set
			{
				this.statement_Beginning_DateField = value;
				this.RaisePropertyChanged("Statement_Beginning_Date");
			}
		}

		[XmlIgnore]
		public bool Statement_Beginning_DateSpecified
		{
			get
			{
				return this.statement_Beginning_DateFieldSpecified;
			}
			set
			{
				this.statement_Beginning_DateFieldSpecified = value;
				this.RaisePropertyChanged("Statement_Beginning_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Statement_Date
		{
			get
			{
				return this.statement_DateField;
			}
			set
			{
				this.statement_DateField = value;
				this.RaisePropertyChanged("Statement_Date");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Ending_Balance
		{
			get
			{
				return this.ending_BalanceField;
			}
			set
			{
				this.ending_BalanceField = value;
				this.RaisePropertyChanged("Ending_Balance");
			}
		}

		[XmlIgnore]
		public bool Ending_BalanceSpecified
		{
			get
			{
				return this.ending_BalanceFieldSpecified;
			}
			set
			{
				this.ending_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Ending_BalanceSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement("Investment_Statement_Line_Data", Order = 7)]
		public Investment_Statement_Line_DataType[] Investment_Statement_Line_Data
		{
			get
			{
				return this.investment_Statement_Line_DataField;
			}
			set
			{
				this.investment_Statement_Line_DataField = value;
				this.RaisePropertyChanged("Investment_Statement_Line_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 8)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
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
