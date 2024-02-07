using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Enroll_in_Retirement_Savings_Plans_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType employee_ReferenceField;

		private DateTime event_DateField;

		private Retirement_Savings_Election_Data_for_Change_Retirement_Savings_PlansType[] retirement_Savings_Election_DataField;

		private Benefit_Coverage_Type_for_Retirement_Savings_Elections_DataType[] retirement_Savings_Coverage_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Employee_Reference
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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Event_Date
		{
			get
			{
				return this.event_DateField;
			}
			set
			{
				this.event_DateField = value;
				this.RaisePropertyChanged("Event_Date");
			}
		}

		[XmlElement("Retirement_Savings_Election_Data", Order = 2)]
		public Retirement_Savings_Election_Data_for_Change_Retirement_Savings_PlansType[] Retirement_Savings_Election_Data
		{
			get
			{
				return this.retirement_Savings_Election_DataField;
			}
			set
			{
				this.retirement_Savings_Election_DataField = value;
				this.RaisePropertyChanged("Retirement_Savings_Election_Data");
			}
		}

		[XmlElement("Retirement_Savings_Coverage_Type_Data", Order = 3)]
		public Benefit_Coverage_Type_for_Retirement_Savings_Elections_DataType[] Retirement_Savings_Coverage_Type_Data
		{
			get
			{
				return this.retirement_Savings_Coverage_Type_DataField;
			}
			set
			{
				this.retirement_Savings_Coverage_Type_DataField = value;
				this.RaisePropertyChanged("Retirement_Savings_Coverage_Type_Data");
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
