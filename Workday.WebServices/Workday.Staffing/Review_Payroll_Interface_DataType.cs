using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Review_Payroll_Interface_DataType : INotifyPropertyChanged
	{
		private External_Pay_GroupObjectType external_Pay_Group_ReferenceField;

		private FrequencyObjectType pay_Frequency_ReferenceField;

		private External_Payroll_Employee_TypeObjectType external_Payroll_Employee_Type_ReferenceField;

		private string payroll_File_NumberField;

		private Review_Payroll_Interface_Data_Extract_Business_Sub_ProcessType review_Payroll_Interface_Event_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public External_Pay_GroupObjectType External_Pay_Group_Reference
		{
			get
			{
				return this.external_Pay_Group_ReferenceField;
			}
			set
			{
				this.external_Pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("External_Pay_Group_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public FrequencyObjectType Pay_Frequency_Reference
		{
			get
			{
				return this.pay_Frequency_ReferenceField;
			}
			set
			{
				this.pay_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Frequency_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public External_Payroll_Employee_TypeObjectType External_Payroll_Employee_Type_Reference
		{
			get
			{
				return this.external_Payroll_Employee_Type_ReferenceField;
			}
			set
			{
				this.external_Payroll_Employee_Type_ReferenceField = value;
				this.RaisePropertyChanged("External_Payroll_Employee_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Payroll_File_Number
		{
			get
			{
				return this.payroll_File_NumberField;
			}
			set
			{
				this.payroll_File_NumberField = value;
				this.RaisePropertyChanged("Payroll_File_Number");
			}
		}

		[XmlElement(Order = 4)]
		public Review_Payroll_Interface_Data_Extract_Business_Sub_ProcessType Review_Payroll_Interface_Event_Sub_Process
		{
			get
			{
				return this.review_Payroll_Interface_Event_Sub_ProcessField;
			}
			set
			{
				this.review_Payroll_Interface_Event_Sub_ProcessField = value;
				this.RaisePropertyChanged("Review_Payroll_Interface_Event_Sub_Process");
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
