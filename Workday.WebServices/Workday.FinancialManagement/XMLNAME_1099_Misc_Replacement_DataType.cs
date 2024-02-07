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
	public class XMLNAME_1099_Misc_Replacement_DataType : INotifyPropertyChanged
	{
		private Tax_Reportable_PayeeObjectType payee_ReferenceField;

		private string print_Formatted_IRS_1099_Payee_NameField;

		private DateTime calendar_YearField;

		private bool calendar_YearFieldSpecified;

		private string corrected_Return_Type_for_1099_MiscField;

		private string tax_IDField;

		private string tIN_TypeField;

		private bool foreign_Entity_IndicatorField;

		private bool foreign_Entity_IndicatorFieldSpecified;

		private Address_Information_DataType[] payee_Address_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Tax_Reportable_PayeeObjectType Payee_Reference
		{
			get
			{
				return this.payee_ReferenceField;
			}
			set
			{
				this.payee_ReferenceField = value;
				this.RaisePropertyChanged("Payee_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Print_Formatted_IRS_1099_Payee_Name
		{
			get
			{
				return this.print_Formatted_IRS_1099_Payee_NameField;
			}
			set
			{
				this.print_Formatted_IRS_1099_Payee_NameField = value;
				this.RaisePropertyChanged("Print_Formatted_IRS_1099_Payee_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Calendar_Year
		{
			get
			{
				return this.calendar_YearField;
			}
			set
			{
				this.calendar_YearField = value;
				this.RaisePropertyChanged("Calendar_Year");
			}
		}

		[XmlIgnore]
		public bool Calendar_YearSpecified
		{
			get
			{
				return this.calendar_YearFieldSpecified;
			}
			set
			{
				this.calendar_YearFieldSpecified = value;
				this.RaisePropertyChanged("Calendar_YearSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Corrected_Return_Type_for_1099_Misc
		{
			get
			{
				return this.corrected_Return_Type_for_1099_MiscField;
			}
			set
			{
				this.corrected_Return_Type_for_1099_MiscField = value;
				this.RaisePropertyChanged("Corrected_Return_Type_for_1099_Misc");
			}
		}

		[XmlElement(Order = 4)]
		public string Tax_ID
		{
			get
			{
				return this.tax_IDField;
			}
			set
			{
				this.tax_IDField = value;
				this.RaisePropertyChanged("Tax_ID");
			}
		}

		[XmlElement(Order = 5)]
		public string TIN_Type
		{
			get
			{
				return this.tIN_TypeField;
			}
			set
			{
				this.tIN_TypeField = value;
				this.RaisePropertyChanged("TIN_Type");
			}
		}

		[XmlElement(Order = 6)]
		public bool Foreign_Entity_Indicator
		{
			get
			{
				return this.foreign_Entity_IndicatorField;
			}
			set
			{
				this.foreign_Entity_IndicatorField = value;
				this.RaisePropertyChanged("Foreign_Entity_Indicator");
			}
		}

		[XmlIgnore]
		public bool Foreign_Entity_IndicatorSpecified
		{
			get
			{
				return this.foreign_Entity_IndicatorFieldSpecified;
			}
			set
			{
				this.foreign_Entity_IndicatorFieldSpecified = value;
				this.RaisePropertyChanged("Foreign_Entity_IndicatorSpecified");
			}
		}

		[XmlElement("Payee_Address_Data", Order = 7)]
		public Address_Information_DataType[] Payee_Address_Data
		{
			get
			{
				return this.payee_Address_DataField;
			}
			set
			{
				this.payee_Address_DataField = value;
				this.RaisePropertyChanged("Payee_Address_Data");
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
