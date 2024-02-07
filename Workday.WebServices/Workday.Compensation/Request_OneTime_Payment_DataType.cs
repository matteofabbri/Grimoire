using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Request_One-Time_Payment_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Request_OneTime_Payment_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private DateTime effective_DateField;

		private DateTime employee_Visibility_DateField;

		private bool employee_Visibility_DateFieldSpecified;

		private Event_Classification_SubcategoryObjectType reason_ReferenceField;

		private OneTime_Payment_DataType[] oneTime_Payment_Sub_DataField;

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

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement("One-Time_Payment_Sub_Data", Order = 5)]
		public OneTime_Payment_DataType[] OneTime_Payment_Sub_Data
		{
			get
			{
				return this.oneTime_Payment_Sub_DataField;
			}
			set
			{
				this.oneTime_Payment_Sub_DataField = value;
				this.RaisePropertyChanged("OneTime_Payment_Sub_Data");
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
