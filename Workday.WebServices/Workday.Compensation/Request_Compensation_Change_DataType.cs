using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Request_Compensation_Change_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private object itemField;

		private DateTime employee_Visibility_DateField;

		private bool employee_Visibility_DateFieldSpecified;

		private Compensation_Change_DataType compensation_Change_DataField;

		private Check_Position_Budget_Sub_Business_ProcessType check_Position_Budget_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement("Compensation_Change_Date", typeof(DateTime), DataType = "date", Order = 2), XmlElement("Compensation_Change_On_Next_Pay_Period", typeof(bool), Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Employee_Visibility_Date
		{
			get
			{
				return this.employee_Visibility_DateField;
			}
			set
			{
				this.employee_Visibility_DateField = value;
				this.RaisePropertyChanged("Employee_Visibility_Date");
			}
		}

		[XmlIgnore]
		public bool Employee_Visibility_DateSpecified
		{
			get
			{
				return this.employee_Visibility_DateFieldSpecified;
			}
			set
			{
				this.employee_Visibility_DateFieldSpecified = value;
				this.RaisePropertyChanged("Employee_Visibility_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Compensation_Change_DataType Compensation_Change_Data
		{
			get
			{
				return this.compensation_Change_DataField;
			}
			set
			{
				this.compensation_Change_DataField = value;
				this.RaisePropertyChanged("Compensation_Change_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Check_Position_Budget_Sub_Business_ProcessType Check_Position_Budget_Sub_Process
		{
			get
			{
				return this.check_Position_Budget_Sub_ProcessField;
			}
			set
			{
				this.check_Position_Budget_Sub_ProcessField = value;
				this.RaisePropertyChanged("Check_Position_Budget_Sub_Process");
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
