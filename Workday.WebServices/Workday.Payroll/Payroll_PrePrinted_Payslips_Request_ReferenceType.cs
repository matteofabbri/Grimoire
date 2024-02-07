using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Payroll_Pre-Printed_Payslips_Request_ReferenceType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_PrePrinted_Payslips_Request_ReferenceType : INotifyPropertyChanged
	{
		private Repository_DocumentObjectType[] payroll_PrePrinted_Payslips_Request_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Pre-Printed_Payslips_Request_Reference", Order = 0)]
		public Repository_DocumentObjectType[] Payroll_PrePrinted_Payslips_Request_Reference
		{
			get
			{
				return this.payroll_PrePrinted_Payslips_Request_ReferenceField;
			}
			set
			{
				this.payroll_PrePrinted_Payslips_Request_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_PrePrinted_Payslips_Request_Reference");
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
