using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_LimitType : INotifyPropertyChanged
	{
		private Payroll_LimitObjectType salary_Cap_Request_ReferenceField;

		private Payroll_Limit_DataType[] salary_Cap_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_LimitObjectType Salary_Cap_Request_Reference
		{
			get
			{
				return this.salary_Cap_Request_ReferenceField;
			}
			set
			{
				this.salary_Cap_Request_ReferenceField = value;
				this.RaisePropertyChanged("Salary_Cap_Request_Reference");
			}
		}

		[XmlElement("Salary_Cap_Data", Order = 1)]
		public Payroll_Limit_DataType[] Salary_Cap_Data
		{
			get
			{
				return this.salary_Cap_DataField;
			}
			set
			{
				this.salary_Cap_DataField = value;
				this.RaisePropertyChanged("Salary_Cap_Data");
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
