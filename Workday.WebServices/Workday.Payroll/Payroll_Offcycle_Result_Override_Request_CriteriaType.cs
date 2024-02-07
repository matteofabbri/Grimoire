using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Payroll_Off-cycle_Result_Override_Request_CriteriaType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Offcycle_Result_Override_Request_CriteriaType : INotifyPropertyChanged
	{
		private string payment_IDField;

		private EmployeeObjectType[] employee_ReferenceField;

		private PeriodObjectType[] period_ReferenceField;

		private Run_CategoryObjectType[] run_Category_ReferenceField;

		private Pay_GroupObjectType[] pay_Group_ReferenceField;

		private string batch_IDField;

		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

		private Payroll_Action_ReasonObjectType[] reason_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Payment_ID
		{
			get
			{
				return this.payment_IDField;
			}
			set
			{
				this.payment_IDField = value;
				this.RaisePropertyChanged("Payment_ID");
			}
		}

		[XmlElement("Employee_Reference", Order = 1)]
		public EmployeeObjectType[] Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement("Period_Reference", Order = 2)]
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

		[XmlElement("Run_Category_Reference", Order = 3)]
		public Run_CategoryObjectType[] Run_Category_Reference
		{
			get
			{
				return this.run_Category_ReferenceField;
			}
			set
			{
				this.run_Category_ReferenceField = value;
				this.RaisePropertyChanged("Run_Category_Reference");
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

		[XmlElement(Order = 5)]
		public string Batch_ID
		{
			get
			{
				return this.batch_IDField;
			}
			set
			{
				this.batch_IDField = value;
				this.RaisePropertyChanged("Batch_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
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

		[XmlElement("Reason_Reference", Order = 7)]
		public Payroll_Action_ReasonObjectType[] Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
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
