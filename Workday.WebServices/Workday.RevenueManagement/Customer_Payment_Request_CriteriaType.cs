using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Customer_Payment_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_ReferenceField;

		private PayeeObjectType[] remitfrom_Customer_ReferenceField;

		private Business_Entity_Status_ValueObjectType[] customer_Status_ReferenceField;

		private Payment_TypeObjectType[] payment_Type_ReferenceField;

		private DateTime payment_Date_On_or_AfterField;

		private bool payment_Date_On_or_AfterFieldSpecified;

		private DateTime payment_Date_On_or_BeforeField;

		private bool payment_Date_On_or_BeforeFieldSpecified;

		private WorkerObjectType[] created_by_Worker_ReferenceField;

		private bool tranaction_is_IntercompanyField;

		private bool tranaction_is_IntercompanyFieldSpecified;

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

		[XmlElement("Remit-from_Customer_Reference", Order = 1)]
		public PayeeObjectType[] Remitfrom_Customer_Reference
		{
			get
			{
				return this.remitfrom_Customer_ReferenceField;
			}
			set
			{
				this.remitfrom_Customer_ReferenceField = value;
				this.RaisePropertyChanged("Remitfrom_Customer_Reference");
			}
		}

		[XmlElement("Customer_Status_Reference", Order = 2)]
		public Business_Entity_Status_ValueObjectType[] Customer_Status_Reference
		{
			get
			{
				return this.customer_Status_ReferenceField;
			}
			set
			{
				this.customer_Status_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Status_Reference");
			}
		}

		[XmlElement("Payment_Type_Reference", Order = 3)]
		public Payment_TypeObjectType[] Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Payment_Date_On_or_After
		{
			get
			{
				return this.payment_Date_On_or_AfterField;
			}
			set
			{
				this.payment_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Payment_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Payment_Date_On_or_AfterSpecified
		{
			get
			{
				return this.payment_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.payment_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Payment_Date_On_or_Before
		{
			get
			{
				return this.payment_Date_On_or_BeforeField;
			}
			set
			{
				this.payment_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Payment_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Payment_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.payment_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.payment_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement("Created_by_Worker_Reference", Order = 6)]
		public WorkerObjectType[] Created_by_Worker_Reference
		{
			get
			{
				return this.created_by_Worker_ReferenceField;
			}
			set
			{
				this.created_by_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Created_by_Worker_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public bool Tranaction_is_Intercompany
		{
			get
			{
				return this.tranaction_is_IntercompanyField;
			}
			set
			{
				this.tranaction_is_IntercompanyField = value;
				this.RaisePropertyChanged("Tranaction_is_Intercompany");
			}
		}

		[XmlIgnore]
		public bool Tranaction_is_IntercompanySpecified
		{
			get
			{
				return this.tranaction_is_IntercompanyFieldSpecified;
			}
			set
			{
				this.tranaction_is_IntercompanyFieldSpecified = value;
				this.RaisePropertyChanged("Tranaction_is_IntercompanySpecified");
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
