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
	public class Financial_Institution_WWS_DataType : INotifyPropertyChanged
	{
		private string financial_Institution_IDField;

		private string financial_Institution_Reference_IDField;

		private string financial_Institution_NameField;

		private object itemField;

		private string bank_Identifier_CodeField;

		private string bank_CodeField;

		private Business_Entity_WWS_DataType business_Entity_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Financial_Institution_ID
		{
			get
			{
				return this.financial_Institution_IDField;
			}
			set
			{
				this.financial_Institution_IDField = value;
				this.RaisePropertyChanged("Financial_Institution_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Financial_Institution_Reference_ID
		{
			get
			{
				return this.financial_Institution_Reference_IDField;
			}
			set
			{
				this.financial_Institution_Reference_IDField = value;
				this.RaisePropertyChanged("Financial_Institution_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Financial_Institution_Name
		{
			get
			{
				return this.financial_Institution_NameField;
			}
			set
			{
				this.financial_Institution_NameField = value;
				this.RaisePropertyChanged("Financial_Institution_Name");
			}
		}

		[XmlElement("Create_Financial_Institution_from_Customer_Reference", typeof(Billable_EntityObjectType), Order = 3), XmlElement("Create_Financial_Institution_from_Investor_Reference", typeof(InvestorObjectType), Order = 3), XmlElement("Create_Financial_Institution_from_Supplier_Reference", typeof(SupplierObjectType), Order = 3), XmlElement("Create_Financial_Institution_from_Tax_Authority_Reference", typeof(Tax_AuthorityObjectType), Order = 3)]
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

		[XmlElement(Order = 4)]
		public string Bank_Identifier_Code
		{
			get
			{
				return this.bank_Identifier_CodeField;
			}
			set
			{
				this.bank_Identifier_CodeField = value;
				this.RaisePropertyChanged("Bank_Identifier_Code");
			}
		}

		[XmlElement(Order = 5)]
		public string Bank_Code
		{
			get
			{
				return this.bank_CodeField;
			}
			set
			{
				this.bank_CodeField = value;
				this.RaisePropertyChanged("Bank_Code");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement("Attachment_Data", Order = 7)]
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
