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
	public class Payroll_Payslip_Request_CriteriaType : INotifyPropertyChanged
	{
		private Outsourced_Payment_GroupObjectType outsourced_Payment_Group_ReferenceField;

		private WorkerObjectType[] employee_ReferenceField;

		private DateTime payment_Interval_Start_Date_ReferenceField;

		private bool payment_Interval_Start_Date_ReferenceFieldSpecified;

		private DateTime payment_Interval_End_Date_ReferenceField;

		private bool payment_Interval_End_Date_ReferenceFieldSpecified;

		private Payslip_Printing_OptionObjectType payslip_Printing_Option_ReferenceField;

		private External_Field_and_Parameter_Initialization_ProviderObjectType[] field_And_Parameter_Criteria_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Outsourced_Payment_GroupObjectType Outsourced_Payment_Group_Reference
		{
			get
			{
				return this.outsourced_Payment_Group_ReferenceField;
			}
			set
			{
				this.outsourced_Payment_Group_ReferenceField = value;
				this.RaisePropertyChanged("Outsourced_Payment_Group_Reference");
			}
		}

		[XmlElement("Employee_Reference", Order = 1)]
		public WorkerObjectType[] Employee_Reference
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

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Payment_Interval_Start_Date_Reference
		{
			get
			{
				return this.payment_Interval_Start_Date_ReferenceField;
			}
			set
			{
				this.payment_Interval_Start_Date_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Interval_Start_Date_Reference");
			}
		}

		[XmlIgnore]
		public bool Payment_Interval_Start_Date_ReferenceSpecified
		{
			get
			{
				return this.payment_Interval_Start_Date_ReferenceFieldSpecified;
			}
			set
			{
				this.payment_Interval_Start_Date_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Interval_Start_Date_ReferenceSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Payment_Interval_End_Date_Reference
		{
			get
			{
				return this.payment_Interval_End_Date_ReferenceField;
			}
			set
			{
				this.payment_Interval_End_Date_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Interval_End_Date_Reference");
			}
		}

		[XmlIgnore]
		public bool Payment_Interval_End_Date_ReferenceSpecified
		{
			get
			{
				return this.payment_Interval_End_Date_ReferenceFieldSpecified;
			}
			set
			{
				this.payment_Interval_End_Date_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Interval_End_Date_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Payslip_Printing_OptionObjectType Payslip_Printing_Option_Reference
		{
			get
			{
				return this.payslip_Printing_Option_ReferenceField;
			}
			set
			{
				this.payslip_Printing_Option_ReferenceField = value;
				this.RaisePropertyChanged("Payslip_Printing_Option_Reference");
			}
		}

		[XmlArray(Order = 5), XmlArrayItem("Provider_Reference", IsNullable = false)]
		public External_Field_and_Parameter_Initialization_ProviderObjectType[] Field_And_Parameter_Criteria_Data
		{
			get
			{
				return this.field_And_Parameter_Criteria_DataField;
			}
			set
			{
				this.field_And_Parameter_Criteria_DataField = value;
				this.RaisePropertyChanged("Field_And_Parameter_Criteria_Data");
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
