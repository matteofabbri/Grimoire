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
	public class Payroll_Deduction_RecipientType : INotifyPropertyChanged
	{
		private Deduction_RecipientObjectType payroll_Deduction_Recipient_ReferenceField;

		private Payroll_Deduction_Recipient_DataType[] payroll_Deduction_Recipient_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Deduction_RecipientObjectType Payroll_Deduction_Recipient_Reference
		{
			get
			{
				return this.payroll_Deduction_Recipient_ReferenceField;
			}
			set
			{
				this.payroll_Deduction_Recipient_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Deduction_Recipient_Reference");
			}
		}

		[XmlElement("Payroll_Deduction_Recipient_Data", Order = 1)]
		public Payroll_Deduction_Recipient_DataType[] Payroll_Deduction_Recipient_Data
		{
			get
			{
				return this.payroll_Deduction_Recipient_DataField;
			}
			set
			{
				this.payroll_Deduction_Recipient_DataField = value;
				this.RaisePropertyChanged("Payroll_Deduction_Recipient_Data");
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
