using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_PayslipType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payroll_Payslip_ReferenceField;

		private Payroll_Payslip_DataType payslip_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Payroll_Payslip_Reference
		{
			get
			{
				return this.payroll_Payslip_ReferenceField;
			}
			set
			{
				this.payroll_Payslip_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payslip_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_Payslip_DataType Payslip_Data
		{
			get
			{
				return this.payslip_DataField;
			}
			set
			{
				this.payslip_DataField = value;
				this.RaisePropertyChanged("Payslip_Data");
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
