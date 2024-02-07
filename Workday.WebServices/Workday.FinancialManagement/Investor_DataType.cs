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
	public class Investor_DataType : INotifyPropertyChanged
	{
		private string investor_Reference_IDField;

		private string investor_NameField;

		private Tax_Authority_Form_TypeObjectType tax_Authority_Form_Type_ReferenceField;

		private bool investor_Is_1099_PayeeField;

		private bool investor_Is_1099_PayeeFieldSpecified;

		private Taxpayer_ID_Number_TypeObjectType investor_Taxpayer_ID_Number_Type_ReferenceField;

		private DateTime tax_Document_DateField;

		private bool tax_Document_DateFieldSpecified;

		private object itemField;

		private Payment_TypeObjectType default_Payment_Type_ReferenceField;

		private Investor_Security_SegmentObjectType[] investor_Security_Segment_ReferenceField;

		private Business_Entity_WWS_DataType business_Entity_DataField;

		private Settlement_Account_WWS_DataType[] settlement_Account_DataField;

		private Business_Entity_Alternate_Name_DataType[] alternate_Name_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Investor_Reference_ID
		{
			get
			{
				return this.investor_Reference_IDField;
			}
			set
			{
				this.investor_Reference_IDField = value;
				this.RaisePropertyChanged("Investor_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Investor_Name
		{
			get
			{
				return this.investor_NameField;
			}
			set
			{
				this.investor_NameField = value;
				this.RaisePropertyChanged("Investor_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Tax_Authority_Form_TypeObjectType Tax_Authority_Form_Type_Reference
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
		public bool Investor_Is_1099_Payee
		{
			get
			{
				return this.investor_Is_1099_PayeeField;
			}
			set
			{
				this.investor_Is_1099_PayeeField = value;
				this.RaisePropertyChanged("Investor_Is_1099_Payee");
			}
		}

		[XmlIgnore]
		public bool Investor_Is_1099_PayeeSpecified
		{
			get
			{
				return this.investor_Is_1099_PayeeFieldSpecified;
			}
			set
			{
				this.investor_Is_1099_PayeeFieldSpecified = value;
				this.RaisePropertyChanged("Investor_Is_1099_PayeeSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Taxpayer_ID_Number_TypeObjectType Investor_Taxpayer_ID_Number_Type_Reference
		{
			get
			{
				return this.investor_Taxpayer_ID_Number_Type_ReferenceField;
			}
			set
			{
				this.investor_Taxpayer_ID_Number_Type_ReferenceField = value;
				this.RaisePropertyChanged("Investor_Taxpayer_ID_Number_Type_Reference");
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

		[XmlElement("Create_Investor_from_Customer_Reference", typeof(Billable_EntityObjectType), Order = 6), XmlElement("Create_Investor_from_Financial_Institution_Reference", typeof(Financial_InstitutionObjectType), Order = 6), XmlElement("Create_Investor_from_Supplier_Reference", typeof(SupplierObjectType), Order = 6), XmlElement("Create_Investor_from_Tax_Authority_Reference", typeof(Tax_AuthorityObjectType), Order = 6)]
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

		[XmlElement(Order = 7)]
		public Payment_TypeObjectType Default_Payment_Type_Reference
		{
			get
			{
				return this.default_Payment_Type_ReferenceField;
			}
			set
			{
				this.default_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Default_Payment_Type_Reference");
			}
		}

		[XmlElement("Investor_Security_Segment_Reference", Order = 8)]
		public Investor_Security_SegmentObjectType[] Investor_Security_Segment_Reference
		{
			get
			{
				return this.investor_Security_Segment_ReferenceField;
			}
			set
			{
				this.investor_Security_Segment_ReferenceField = value;
				this.RaisePropertyChanged("Investor_Security_Segment_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Business_Entity_WWS_DataType Business_Entity_Data
		{
			get
			{
				return this.business_Entity_DataField;
			}
			set
			{
				this.business_Entity_DataField = value;
				this.RaisePropertyChanged("Business_Entity_Data");
			}
		}

		[XmlElement("Settlement_Account_Data", Order = 10)]
		public Settlement_Account_WWS_DataType[] Settlement_Account_Data
		{
			get
			{
				return this.settlement_Account_DataField;
			}
			set
			{
				this.settlement_Account_DataField = value;
				this.RaisePropertyChanged("Settlement_Account_Data");
			}
		}

		[XmlElement("Alternate_Name_Data", Order = 11)]
		public Business_Entity_Alternate_Name_DataType[] Alternate_Name_Data
		{
			get
			{
				return this.alternate_Name_DataField;
			}
			set
			{
				this.alternate_Name_DataField = value;
				this.RaisePropertyChanged("Alternate_Name_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 12)]
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
