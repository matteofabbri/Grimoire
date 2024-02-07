using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Periodic_CAN_Tax_Remittance_Data_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private bool include_Related_Companies_for_Legal_EntityField;

		private bool include_Related_Companies_for_Legal_EntityFieldSpecified;

		private DateTime result_Completed_FromField;

		private bool result_Completed_FromFieldSpecified;

		private DateTime result_Completed_ToField;

		private bool result_Completed_ToFieldSpecified;

		private Pay_GroupObjectType[] pay_Group_ReferenceField;

		private PeriodObjectType[] period_ReferenceField;

		private bool include_WCBField;

		private bool include_WCBFieldSpecified;

		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

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
		public bool Include_Related_Companies_for_Legal_Entity
		{
			get
			{
				return this.include_Related_Companies_for_Legal_EntityField;
			}
			set
			{
				this.include_Related_Companies_for_Legal_EntityField = value;
				this.RaisePropertyChanged("Include_Related_Companies_for_Legal_Entity");
			}
		}

		[XmlIgnore]
		public bool Include_Related_Companies_for_Legal_EntitySpecified
		{
			get
			{
				return this.include_Related_Companies_for_Legal_EntityFieldSpecified;
			}
			set
			{
				this.include_Related_Companies_for_Legal_EntityFieldSpecified = value;
				this.RaisePropertyChanged("Include_Related_Companies_for_Legal_EntitySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Result_Completed_From
		{
			get
			{
				return this.result_Completed_FromField;
			}
			set
			{
				this.result_Completed_FromField = value;
				this.RaisePropertyChanged("Result_Completed_From");
			}
		}

		[XmlIgnore]
		public bool Result_Completed_FromSpecified
		{
			get
			{
				return this.result_Completed_FromFieldSpecified;
			}
			set
			{
				this.result_Completed_FromFieldSpecified = value;
				this.RaisePropertyChanged("Result_Completed_FromSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Result_Completed_To
		{
			get
			{
				return this.result_Completed_ToField;
			}
			set
			{
				this.result_Completed_ToField = value;
				this.RaisePropertyChanged("Result_Completed_To");
			}
		}

		[XmlIgnore]
		public bool Result_Completed_ToSpecified
		{
			get
			{
				return this.result_Completed_ToFieldSpecified;
			}
			set
			{
				this.result_Completed_ToFieldSpecified = value;
				this.RaisePropertyChanged("Result_Completed_ToSpecified");
			}
		}

		[XmlElement("Pay_Group_Reference", Order = 4)]
		public Pay_GroupObjectType[] Pay_Group_Reference
		{
			get
			{
				return this.pay_Group_ReferenceField;
			}
			set
			{
				this.pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Group_Reference");
			}
		}

		[XmlElement("Period_Reference", Order = 5)]
		public PeriodObjectType[] Period_Reference
		{
			get
			{
				return this.period_ReferenceField;
			}
			set
			{
				this.period_ReferenceField = value;
				this.RaisePropertyChanged("Period_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_WCB
		{
			get
			{
				return this.include_WCBField;
			}
			set
			{
				this.include_WCBField = value;
				this.RaisePropertyChanged("Include_WCB");
			}
		}

		[XmlIgnore]
		public bool Include_WCBSpecified
		{
			get
			{
				return this.include_WCBFieldSpecified;
			}
			set
			{
				this.include_WCBFieldSpecified = value;
				this.RaisePropertyChanged("Include_WCBSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_DateSpecified
		{
			get
			{
				return this.payment_DateFieldSpecified;
			}
			set
			{
				this.payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_DateSpecified");
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
