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
	public class Add_Stock_Grant_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private EmployeeObjectType employee_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private Stock_PlanObjectType stock_Plan_ReferenceField;

		private Event_Classification_SubcategoryObjectType reason_ReferenceField;

		private Add_Individual_Stock_Grant_DataType[] stock_Grant_DataField;

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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Stock_PlanObjectType Stock_Plan_Reference
		{
			get
			{
				return this.stock_Plan_ReferenceField;
			}
			set
			{
				this.stock_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Plan_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Event_Classification_SubcategoryObjectType Reason_Reference
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

		[XmlElement("Stock_Grant_Data", Order = 5)]
		public Add_Individual_Stock_Grant_DataType[] Stock_Grant_Data
		{
			get
			{
				return this.stock_Grant_DataField;
			}
			set
			{
				this.stock_Grant_DataField = value;
				this.RaisePropertyChanged("Stock_Grant_Data");
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
