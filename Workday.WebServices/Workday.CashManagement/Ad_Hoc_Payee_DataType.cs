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
	public class Ad_Hoc_Payee_DataType : INotifyPropertyChanged
	{
		private string ad_Hoc_Payee_IDField;

		private string ad_Hoc_Payee_NameField;

		private Tax_Authority_Form_TypeObjectType[] tax_Authority_Form_Type_ReferenceField;

		private Taxpayer_ID_Number_TypeObjectType tIN_Type_ReferenceField;

		private string tax_IDField;

		private DateTime tax_Document_DateField;

		private bool tax_Document_DateFieldSpecified;

		private Address_Information_DataType[] address_DataField;

		private Settlement_Account_WWS_DataType[] bank_DataField;

		private Business_Entity_Alternate_Name_DataType[] payee_Alternate_Name_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Ad_Hoc_Payee_ID
		{
			get
			{
				return this.ad_Hoc_Payee_IDField;
			}
			set
			{
				this.ad_Hoc_Payee_IDField = value;
				this.RaisePropertyChanged("Ad_Hoc_Payee_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Ad_Hoc_Payee_Name
		{
			get
			{
				return this.ad_Hoc_Payee_NameField;
			}
			set
			{
				this.ad_Hoc_Payee_NameField = value;
				this.RaisePropertyChanged("Ad_Hoc_Payee_Name");
			}
		}

		[XmlElement("Tax_Authority_Form_Type_Reference", Order = 2)]
		public Tax_Authority_Form_TypeObjectType[] Tax_Authority_Form_Type_Reference
		{
			get
			{
				return this.tax_Authority_Form_Type_ReferenceField;
			}
			set
			{
				this.tax_Authority_Form_Type_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Authority_Form_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Taxpayer_ID_Number_TypeObjectType TIN_Type_Reference
		{
			get
			{
				return this.tIN_Type_ReferenceField;
			}
			set
			{
				this.tIN_Type_ReferenceField = value;
				this.RaisePropertyChanged("TIN_Type_Reference");
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

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Tax_Document_Date
		{
			get
			{
				return this.tax_Document_DateField;
			}
			set
			{
				this.tax_Document_DateField = value;
				this.RaisePropertyChanged("Tax_Document_Date");
			}
		}

		[XmlIgnore]
		public bool Tax_Document_DateSpecified
		{
			get
			{
				return this.tax_Document_DateFieldSpecified;
			}
			set
			{
				this.tax_Document_DateFieldSpecified = value;
				this.RaisePropertyChanged("Tax_Document_DateSpecified");
			}
		}

		[XmlElement("Address_Data", Order = 6)]
		public Address_Information_DataType[] Address_Data
		{
			get
			{
				return this.address_DataField;
			}
			set
			{
				this.address_DataField = value;
				this.RaisePropertyChanged("Address_Data");
			}
		}

		[XmlElement("Bank_Data", Order = 7)]
		public Settlement_Account_WWS_DataType[] Bank_Data
		{
			get
			{
				return this.bank_DataField;
			}
			set
			{
				this.bank_DataField = value;
				this.RaisePropertyChanged("Bank_Data");
			}
		}

		[XmlElement("Payee_Alternate_Name_Data", Order = 8)]
		public Business_Entity_Alternate_Name_DataType[] Payee_Alternate_Name_Data
		{
			get
			{
				return this.payee_Alternate_Name_DataField;
			}
			set
			{
				this.payee_Alternate_Name_DataField = value;
				this.RaisePropertyChanged("Payee_Alternate_Name_Data");
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
