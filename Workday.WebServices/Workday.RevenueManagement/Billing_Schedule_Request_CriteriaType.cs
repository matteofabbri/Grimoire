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
	public class Billing_Schedule_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_ReferenceField;

		private Billable_EntityObjectType[] customer_ReferenceField;

		private Document_StatusObjectType[] schedule_Status_ReferenceField;

		private Schedule_TypeObjectType[] schedule_Type_ReferenceField;

		private Schedule_Distribution_MethodObjectType[] schedule_Distribution_Method_ReferenceField;

		private Frequency_BehaviorObjectType[] frequency_Behavior_ReferenceField;

		private Billing_TypeObjectType[] billing_Type_ReferenceField;

		private CurrencyObjectType[] currency_ReferenceField;

		private DateTime schedule_From_Date_On_or_AfterField;

		private bool schedule_From_Date_On_or_AfterFieldSpecified;

		private DateTime schedule_From_Date_On_or_BeforeField;

		private bool schedule_From_Date_On_or_BeforeFieldSpecified;

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

		[XmlElement("Customer_Reference", Order = 1)]
		public Billable_EntityObjectType[] Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement("Schedule_Status_Reference", Order = 2)]
		public Document_StatusObjectType[] Schedule_Status_Reference
		{
			get
			{
				return this.schedule_Status_ReferenceField;
			}
			set
			{
				this.schedule_Status_ReferenceField = value;
				this.RaisePropertyChanged("Schedule_Status_Reference");
			}
		}

		[XmlElement("Schedule_Type_Reference", Order = 3)]
		public Schedule_TypeObjectType[] Schedule_Type_Reference
		{
			get
			{
				return this.schedule_Type_ReferenceField;
			}
			set
			{
				this.schedule_Type_ReferenceField = value;
				this.RaisePropertyChanged("Schedule_Type_Reference");
			}
		}

		[XmlElement("Schedule_Distribution_Method_Reference", Order = 4)]
		public Schedule_Distribution_MethodObjectType[] Schedule_Distribution_Method_Reference
		{
			get
			{
				return this.schedule_Distribution_Method_ReferenceField;
			}
			set
			{
				this.schedule_Distribution_Method_ReferenceField = value;
				this.RaisePropertyChanged("Schedule_Distribution_Method_Reference");
			}
		}

		[XmlElement("Frequency_Behavior_Reference", Order = 5)]
		public Frequency_BehaviorObjectType[] Frequency_Behavior_Reference
		{
			get
			{
				return this.frequency_Behavior_ReferenceField;
			}
			set
			{
				this.frequency_Behavior_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Behavior_Reference");
			}
		}

		[XmlElement("Billing_Type_Reference", Order = 6)]
		public Billing_TypeObjectType[] Billing_Type_Reference
		{
			get
			{
				return this.billing_Type_ReferenceField;
			}
			set
			{
				this.billing_Type_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Type_Reference");
			}
		}

		[XmlElement("Currency_Reference", Order = 7)]
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

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Schedule_From_Date_On_or_After
		{
			get
			{
				return this.schedule_From_Date_On_or_AfterField;
			}
			set
			{
				this.schedule_From_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Schedule_From_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Schedule_From_Date_On_or_AfterSpecified
		{
			get
			{
				return this.schedule_From_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.schedule_From_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Schedule_From_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Schedule_From_Date_On_or_Before
		{
			get
			{
				return this.schedule_From_Date_On_or_BeforeField;
			}
			set
			{
				this.schedule_From_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Schedule_From_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Schedule_From_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.schedule_From_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.schedule_From_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Schedule_From_Date_On_or_BeforeSpecified");
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
