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
	public class Add_Retiree_Status_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private DateTime retiree_Status_DateField;

		private Add_Retiree_Status_Event_DataType add_Retiree_Status_Event_DataField;

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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Retiree_Status_Date
		{
			get
			{
				return this.retiree_Status_DateField;
			}
			set
			{
				this.retiree_Status_DateField = value;
				this.RaisePropertyChanged("Retiree_Status_Date");
			}
		}

		[XmlElement(Order = 2)]
		public Add_Retiree_Status_Event_DataType Add_Retiree_Status_Event_Data
		{
			get
			{
				return this.add_Retiree_Status_Event_DataField;
			}
			set
			{
				this.add_Retiree_Status_Event_DataField = value;
				this.RaisePropertyChanged("Add_Retiree_Status_Event_Data");
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
