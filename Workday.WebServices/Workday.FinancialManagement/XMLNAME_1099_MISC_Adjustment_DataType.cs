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
	public class XMLNAME_1099_MISC_Adjustment_DataType : INotifyPropertyChanged
	{
		private string iRS_1099_MISC_Adjustment_IDField;

		private CompanyObjectType uSD_Company_ReferenceField;

		private Tax_Reportable_PayeeObjectType iRS_1099_MISC_Payee_ReferenceField;

		private DateTime adjustment_DateField;

		private string memoField;

		private decimal federal_Income_Tax_Withholding_AmountField;

		private bool federal_Income_Tax_Withholding_AmountFieldSpecified;

		private XMLNAME_1099_MISC_Adjustment_Line_DataType[] iRS_1099_MISC_Adjustment_Line_DataField;

		private XMLNAME_1099_MISC_State_Withholding_DataType[] iRS_1099_State_Withholding_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string IRS_1099_MISC_Adjustment_ID
		{
			get
			{
				return this.iRS_1099_MISC_Adjustment_IDField;
			}
			set
			{
				this.iRS_1099_MISC_Adjustment_IDField = value;
				this.RaisePropertyChanged("IRS_1099_MISC_Adjustment_ID");
			}
		}

		[XmlElement(Order = 1)]
		public CompanyObjectType USD_Company_Reference
		{
			get
			{
				return this.uSD_Company_ReferenceField;
			}
			set
			{
				this.uSD_Company_ReferenceField = value;
				this.RaisePropertyChanged("USD_Company_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Tax_Reportable_PayeeObjectType IRS_1099_MISC_Payee_Reference
		{
			get
			{
				return this.iRS_1099_MISC_Payee_ReferenceField;
			}
			set
			{
				this.iRS_1099_MISC_Payee_ReferenceField = value;
				this.RaisePropertyChanged("IRS_1099_MISC_Payee_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Adjustment_Date
		{
			get
			{
				return this.adjustment_DateField;
			}
			set
			{
				this.adjustment_DateField = value;
				this.RaisePropertyChanged("Adjustment_Date");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public decimal Federal_Income_Tax_Withholding_Amount
		{
			get
			{
				return this.federal_Income_Tax_Withholding_AmountField;
			}
			set
			{
				this.federal_Income_Tax_Withholding_AmountField = value;
				this.RaisePropertyChanged("Federal_Income_Tax_Withholding_Amount");
			}
		}

		[XmlIgnore]
		public bool Federal_Income_Tax_Withholding_AmountSpecified
		{
			get
			{
				return this.federal_Income_Tax_Withholding_AmountFieldSpecified;
			}
			set
			{
				this.federal_Income_Tax_Withholding_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Federal_Income_Tax_Withholding_AmountSpecified");
			}
		}

		[XmlElement("IRS_1099_MISC_Adjustment_Line_Data", Order = 6)]
		public XMLNAME_1099_MISC_Adjustment_Line_DataType[] IRS_1099_MISC_Adjustment_Line_Data
		{
			get
			{
				return this.iRS_1099_MISC_Adjustment_Line_DataField;
			}
			set
			{
				this.iRS_1099_MISC_Adjustment_Line_DataField = value;
				this.RaisePropertyChanged("IRS_1099_MISC_Adjustment_Line_Data");
			}
		}

		[XmlElement("IRS_1099_State_Withholding_Data", Order = 7)]
		public XMLNAME_1099_MISC_State_Withholding_DataType[] IRS_1099_State_Withholding_Data
		{
			get
			{
				return this.iRS_1099_State_Withholding_DataField;
			}
			set
			{
				this.iRS_1099_State_Withholding_DataField = value;
				this.RaisePropertyChanged("IRS_1099_State_Withholding_Data");
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
