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
	public class Ad_hoc_Bank_Transaction_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_ReferenceField;

		private Financial_AccountObjectType[] bank_Account_ReferenceField;

		private DateTime transaction_On_or_AfterField;

		private bool transaction_On_or_AfterFieldSpecified;

		private DateTime transaction_On_or_BeforeField;

		private bool transaction_On_or_BeforeFieldSpecified;

		private string ad_Hoc_Bank_Transaction_NumberField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Reference", Order = 0)]
		public OrganizationObjectType[] Company_Reference
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

		[XmlElement("Bank_Account_Reference", Order = 1)]
		public Financial_AccountObjectType[] Bank_Account_Reference
		{
			get
			{
				return this.bank_Account_ReferenceField;
			}
			set
			{
				this.bank_Account_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Account_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Transaction_On_or_After
		{
			get
			{
				return this.transaction_On_or_AfterField;
			}
			set
			{
				this.transaction_On_or_AfterField = value;
				this.RaisePropertyChanged("Transaction_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Transaction_On_or_AfterSpecified
		{
			get
			{
				return this.transaction_On_or_AfterFieldSpecified;
			}
			set
			{
				this.transaction_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Transaction_On_or_Before
		{
			get
			{
				return this.transaction_On_or_BeforeField;
			}
			set
			{
				this.transaction_On_or_BeforeField = value;
				this.RaisePropertyChanged("Transaction_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Transaction_On_or_BeforeSpecified
		{
			get
			{
				return this.transaction_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.transaction_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_On_or_BeforeSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Ad_Hoc_Bank_Transaction_Number
		{
			get
			{
				return this.ad_Hoc_Bank_Transaction_NumberField;
			}
			set
			{
				this.ad_Hoc_Bank_Transaction_NumberField = value;
				this.RaisePropertyChanged("Ad_Hoc_Bank_Transaction_Number");
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
