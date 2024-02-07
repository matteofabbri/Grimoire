using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_ReviewType : INotifyPropertyChanged
	{
		private Employee_ReviewObjectType employee_Review_ReferenceField;

		private Review_DataType[] employee_Review_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Employee_ReviewObjectType Employee_Review_Reference
		{
			get
			{
				return this.employee_Review_ReferenceField;
			}
			set
			{
				this.employee_Review_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Review_Reference");
			}
		}

		[XmlElement("Employee_Review_Data", Order = 1)]
		public Review_DataType[] Employee_Review_Data
		{
			get
			{
				return this.employee_Review_DataField;
			}
			set
			{
				this.employee_Review_DataField = value;
				this.RaisePropertyChanged("Employee_Review_Data");
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
