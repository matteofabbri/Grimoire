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
	public class YTD_Tax_FilterType : INotifyPropertyChanged
	{
		private Payroll_Tax_AuthorityObjectType[] payroll_Tax_Authority_ReferenceField;

		private Deduction__Workday_Owned_ObjectType[] deduction_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Tax_Authority_Reference", Order = 0)]
		public Payroll_Tax_AuthorityObjectType[] Payroll_Tax_Authority_Reference
		{
			get
			{
				return this.payroll_Tax_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Tax_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Tax_Authority_Reference");
			}
		}

		[XmlElement("Deduction_Reference", Order = 1)]
		public Deduction__Workday_Owned_ObjectType[] Deduction_Reference
		{
			get
			{
				return this.deduction_ReferenceField;
			}
			set
			{
				this.deduction_ReferenceField = value;
				this.RaisePropertyChanged("Deduction_Reference");
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
