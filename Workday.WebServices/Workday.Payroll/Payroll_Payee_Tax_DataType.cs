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
	public class Payroll_Payee_Tax_DataType : INotifyPropertyChanged
	{
		private Payroll_Payee_Tax_DataObjectType payroll_Payee_Tax_Data_ReferenceField;

		private Payroll_Payee_FICA_DataType[] payroll_Payee_FICA_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Payee_Tax_DataObjectType Payroll_Payee_Tax_Data_Reference
		{
			get
			{
				return this.payroll_Payee_Tax_Data_ReferenceField;
			}
			set
			{
				this.payroll_Payee_Tax_Data_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payee_Tax_Data_Reference");
			}
		}

		[XmlElement("Payroll_Payee_FICA_Data", Order = 1)]
		public Payroll_Payee_FICA_DataType[] Payroll_Payee_FICA_Data
		{
			get
			{
				return this.payroll_Payee_FICA_DataField;
			}
			set
			{
				this.payroll_Payee_FICA_DataField = value;
				this.RaisePropertyChanged("Payroll_Payee_FICA_Data");
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
