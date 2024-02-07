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
	public class Beginning_Balance_Translation_Amounts_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private Fiscal_YearObjectType fiscal_Year_ReferenceField;

		private Ledger_TypeObjectType ledger_Type_ReferenceField;

		private CurrencyObjectType translation_Currency_ReferenceField;

		private Book_CodeObjectType book_Code_ReferenceField;

		private Beginning_Balance_Translation_Amount_Line_DataType[] beginning_Balance_Translation_Amount_Line_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Fiscal_YearObjectType Fiscal_Year_Reference
		{
			get
			{
				return this.fiscal_Year_ReferenceField;
			}
			set
			{
				this.fiscal_Year_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Year_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Ledger_TypeObjectType Ledger_Type_Reference
		{
			get
			{
				return this.ledger_Type_ReferenceField;
			}
			set
			{
				this.ledger_Type_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public CurrencyObjectType Translation_Currency_Reference
		{
			get
			{
				return this.translation_Currency_ReferenceField;
			}
			set
			{
				this.translation_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Translation_Currency_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Book_CodeObjectType Book_Code_Reference
		{
			get
			{
				return this.book_Code_ReferenceField;
			}
			set
			{
				this.book_Code_ReferenceField = value;
				this.RaisePropertyChanged("Book_Code_Reference");
			}
		}

		[XmlElement("Beginning_Balance_Translation_Amount_Line_Replacement_Data", Order = 5)]
		public Beginning_Balance_Translation_Amount_Line_DataType[] Beginning_Balance_Translation_Amount_Line_Replacement_Data
		{
			get
			{
				return this.beginning_Balance_Translation_Amount_Line_Replacement_DataField;
			}
			set
			{
				this.beginning_Balance_Translation_Amount_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Beginning_Balance_Translation_Amount_Line_Replacement_Data");
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
