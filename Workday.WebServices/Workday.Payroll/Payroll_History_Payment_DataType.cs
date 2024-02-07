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
	public class Payroll_History_Payment_DataType : INotifyPropertyChanged
	{
		private string batch_IDField;

		private string payment_IDField;

		private EmployeeObjectType employee_ReferenceField;

		private DateTime period_DateField;

		private Run_CategoryObjectType run_Category_ReferenceField;

		private Pay_GroupObjectType pay_Group_ReferenceField;

		private Payroll_IDObjectType payroll_ID_ReferenceField;

		private History_Payment_DataType history_Payment_DataField;

		private Result_Worktag_Overrides_DataType result_Worktag_OverridesField;

		private bool add_to_Existing_Input_DataField;

		private bool add_to_Existing_Input_DataFieldSpecified;

		private History_Payment_Input_DataType[] history_Payment_Input_DataField;

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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public Payroll_IDObjectType Payroll_ID_Reference
		{
			get
			{
				return this.payroll_ID_ReferenceField;
			}
			set
			{
				this.payroll_ID_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_ID_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public History_Payment_DataType History_Payment_Data
		{
			get
			{
				return this.history_Payment_DataField;
			}
			set
			{
				this.history_Payment_DataField = value;
				this.RaisePropertyChanged("History_Payment_Data");
			}
		}

		[XmlElement(Order = 8)]
		public Result_Worktag_Overrides_DataType Result_Worktag_Overrides
		{
			get
			{
				return this.result_Worktag_OverridesField;
			}
			set
			{
				this.result_Worktag_OverridesField = value;
				this.RaisePropertyChanged("Result_Worktag_Overrides");
			}
		}

		[XmlElement(Order = 9)]
		public bool Add_to_Existing_Input_Data
		{
			get
			{
				return this.add_to_Existing_Input_DataField;
			}
			set
			{
				this.add_to_Existing_Input_DataField = value;
				this.RaisePropertyChanged("Add_to_Existing_Input_Data");
			}
		}

		[XmlIgnore]
		public bool Add_to_Existing_Input_DataSpecified
		{
			get
			{
				return this.add_to_Existing_Input_DataFieldSpecified;
			}
			set
			{
				this.add_to_Existing_Input_DataFieldSpecified = value;
				this.RaisePropertyChanged("Add_to_Existing_Input_DataSpecified");
			}
		}

		[XmlElement("History_Payment_Input_Data", Order = 10)]
		public History_Payment_Input_DataType[] History_Payment_Input_Data
		{
			get
			{
				return this.history_Payment_Input_DataField;
			}
			set
			{
				this.history_Payment_Input_DataField = value;
				this.RaisePropertyChanged("History_Payment_Input_Data");
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
