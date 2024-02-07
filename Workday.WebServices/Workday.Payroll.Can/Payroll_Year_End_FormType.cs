using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Year_End_FormType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payroll_Year_End_Form_ReferenceField;

		private Payroll_Year_End_Form_DataType[] payroll_Year_End_Form_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Payroll_Year_End_Form_Reference
		{
			get
			{
				return this.payroll_Year_End_Form_ReferenceField;
			}
			set
			{
				this.payroll_Year_End_Form_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Year_End_Form_Reference");
			}
		}

		[XmlElement("Payroll_Year_End_Form_Data", Order = 1)]
		public Payroll_Year_End_Form_DataType[] Payroll_Year_End_Form_Data
		{
			get
			{
				return this.payroll_Year_End_Form_DataField;
			}
			set
			{
				this.payroll_Year_End_Form_DataField = value;
				this.RaisePropertyChanged("Payroll_Year_End_Form_Data");
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
