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
	public class Payroll_Limit_Request_ReferencesType : INotifyPropertyChanged
	{
		private Payroll_LimitObjectType[] salary_Cap_Request_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Salary_Cap_Request_Reference", Order = 0)]
		public Payroll_LimitObjectType[] Salary_Cap_Request_Reference
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
