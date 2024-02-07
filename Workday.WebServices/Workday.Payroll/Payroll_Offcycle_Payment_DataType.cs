using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Payroll_Off-cycle_Payment_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Offcycle_Payment_DataType : INotifyPropertyChanged
	{
		private string batch_IDField;

		private string payment_IDField;

		private EmployeeObjectType employee_ReferenceField;

		private DateTime payment_DateField;

		private DateTime period_DateField;

		private decimal payment_PriorityField;

		private Run_CategoryObjectType run_Category_ReferenceField;

		private Pay_GroupObjectType pay_Group_ReferenceField;

		private Payroll_Offcycle_TypeObjectType result_Type_ReferenceField;

		private bool replacementField;

		private bool replacementFieldSpecified;

		private Payroll_Action_ReasonObjectType reason_ReferenceField;

		private object itemField;

		private Result_Worktag_Overrides_DataType result_Worktag_Overrides_DataField;

		private Offcycle_Input_DataType[] offcycle_Input_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public EmployeeObjectType Employee_Reference
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

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Period_Date
		{
			get
			{
				return this.period_DateField;
			}
			set
			{
				this.period_DateField = value;
				this.RaisePropertyChanged("Period_Date");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Payment_Priority
		{
			get
			{
				return this.payment_PriorityField;
			}
			set
			{
				this.payment_PriorityField = value;
				this.RaisePropertyChanged("Payment_Priority");
			}
		}

		[XmlElement(Order = 6)]
		public Run_CategoryObjectType Run_Category_Reference
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

		[XmlElement(Order = 7)]
		public Pay_GroupObjectType Pay_Group_Reference
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

		[XmlElement(Order = 8)]
		public Payroll_Offcycle_TypeObjectType Result_Type_Reference
		{
			get
			{
				return this.result_Type_ReferenceField;
			}
			set
			{
				this.result_Type_ReferenceField = value;
				this.RaisePropertyChanged("Result_Type_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public bool Replacement
		{
			get
			{
				return this.replacementField;
			}
			set
			{
				this.replacementField = value;
				this.RaisePropertyChanged("Replacement");
			}
		}

		[XmlIgnore]
		public bool ReplacementSpecified
		{
			get
			{
				return this.replacementFieldSpecified;
			}
			set
			{
				this.replacementFieldSpecified = value;
				this.RaisePropertyChanged("ReplacementSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Payroll_Action_ReasonObjectType Reason_Reference
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

		[XmlElement("Manual_Payment_Data", typeof(Manual_Payment_DataType), Order = 11), XmlElement("On_Demand_Payment_Data", typeof(On_Demand_Payment_DataType), Order = 11)]
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

		[XmlElement(Order = 12)]
		public Result_Worktag_Overrides_DataType Result_Worktag_Overrides_Data
		{
			get
			{
				return this.result_Worktag_Overrides_DataField;
			}
			set
			{
				this.result_Worktag_Overrides_DataField = value;
				this.RaisePropertyChanged("Result_Worktag_Overrides_Data");
			}
		}

		[XmlElement("Off-cycle_Input_Data", Order = 13)]
		public Offcycle_Input_DataType[] Offcycle_Input_Data
		{
			get
			{
				return this.offcycle_Input_DataField;
			}
			set
			{
				this.offcycle_Input_DataField = value;
				this.RaisePropertyChanged("Offcycle_Input_Data");
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
