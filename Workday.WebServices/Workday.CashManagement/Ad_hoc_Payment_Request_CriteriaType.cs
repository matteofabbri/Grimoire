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
	public class Ad_hoc_Payment_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType company_ReferenceField;

		private Financial_AccountObjectType[] bank_Account_ReferenceField;

		private PayeeObjectType[] payee_ReferenceField;

		private HierarchyObjectType[] payee_Hierarchy_ReferenceField;

		private DateTime payment_Date_on_Date_or_AfterField;

		private bool payment_Date_on_Date_or_AfterFieldSpecified;

		private DateTime payment_Date_on_Date_or_BeforeField;

		private bool payment_Date_on_Date_or_BeforeFieldSpecified;

		private CurrencyObjectType[] currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public OrganizationObjectType Company_Reference
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

		[XmlElement("Payee_Reference", Order = 2)]
		public PayeeObjectType[] Payee_Reference
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

		[XmlElement("Payee_Hierarchy_Reference", Order = 3)]
		public HierarchyObjectType[] Payee_Hierarchy_Reference
		{
			get
			{
				return this.payee_Hierarchy_ReferenceField;
			}
			set
			{
				this.payee_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Payee_Hierarchy_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Payment_Date_on_Date_or_After
		{
			get
			{
				return this.payment_Date_on_Date_or_AfterField;
			}
			set
			{
				this.payment_Date_on_Date_or_AfterField = value;
				this.RaisePropertyChanged("Payment_Date_on_Date_or_After");
			}
		}

		[XmlIgnore]
		public bool Payment_Date_on_Date_or_AfterSpecified
		{
			get
			{
				return this.payment_Date_on_Date_or_AfterFieldSpecified;
			}
			set
			{
				this.payment_Date_on_Date_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Date_on_Date_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Payment_Date_on_Date_or_Before
		{
			get
			{
				return this.payment_Date_on_Date_or_BeforeField;
			}
			set
			{
				this.payment_Date_on_Date_or_BeforeField = value;
				this.RaisePropertyChanged("Payment_Date_on_Date_or_Before");
			}
		}

		[XmlIgnore]
		public bool Payment_Date_on_Date_or_BeforeSpecified
		{
			get
			{
				return this.payment_Date_on_Date_or_BeforeFieldSpecified;
			}
			set
			{
				this.payment_Date_on_Date_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Date_on_Date_or_BeforeSpecified");
			}
		}

		[XmlElement("Currency_Reference", Order = 6)]
		public CurrencyObjectType[] Currency_Reference
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
