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
	public class Position_Payroll_Interface_Detail_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Pay_Rate_TypeObjectType pay_Rate_Type_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private External_Pay_GroupObjectType pay_Group_ReferenceField;

		private External_Payroll_EntityObjectType payroll_Entity_ReferenceField;

		private External_Payroll_Employee_TypeObjectType external_Employee_Type_ReferenceField;

		private string payroll_File_NumberField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Pay_Rate_TypeObjectType Pay_Rate_Type_Reference
		{
			get
			{
				return this.pay_Rate_Type_ReferenceField;
			}
			set
			{
				this.pay_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Rate_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public External_Pay_GroupObjectType Pay_Group_Reference
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

		[XmlElement(Order = 4)]
		public External_Payroll_EntityObjectType Payroll_Entity_Reference
		{
			get
			{
				return this.payroll_Entity_ReferenceField;
			}
			set
			{
				this.payroll_Entity_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Entity_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public External_Payroll_Employee_TypeObjectType External_Employee_Type_Reference
		{
			get
			{
				return this.external_Employee_Type_ReferenceField;
			}
			set
			{
				this.external_Employee_Type_ReferenceField = value;
				this.RaisePropertyChanged("External_Employee_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
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
