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
	public class Payroll_Payee_PT1Type : INotifyPropertyChanged
	{
		private Payroll_Payee_PT1ObjectType payroll_Payee_PT1_ReferenceField;

		private Payroll_Payee_PT1_DataType[] payroll_Payee_PT1_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Payee_PT1ObjectType Payroll_Payee_PT1_Reference
		{
			get
			{
				return this.payroll_Payee_PT1_ReferenceField;
			}
			set
			{
				this.payroll_Payee_PT1_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payee_PT1_Reference");
			}
		}

		[XmlElement("Payroll_Payee_PT1_Data", Order = 1)]
		public Payroll_Payee_PT1_DataType[] Payroll_Payee_PT1_Data
		{
			get
			{
				return this.payroll_Payee_PT1_DataField;
			}
			set
			{
				this.payroll_Payee_PT1_DataField = value;
				this.RaisePropertyChanged("Payroll_Payee_PT1_Data");
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
