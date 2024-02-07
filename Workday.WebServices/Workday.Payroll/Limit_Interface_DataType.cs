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
	public class Limit_Interface_DataType : INotifyPropertyChanged
	{
		private Pay_ComponentObjectType pay_Component_ReferenceField;

		private Related_Calculation__All_ObjectType related_Calculation__All__ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Pay_ComponentObjectType Pay_Component_Reference
		{
			get
			{
				return this.pay_Component_ReferenceField;
			}
			set
			{
				this.pay_Component_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Component_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Related_Calculation__All_ObjectType Related_Calculation__All__Reference
		{
			get
			{
				return this.related_Calculation__All__ReferenceField;
			}
			set
			{
				this.related_Calculation__All__ReferenceField = value;
				this.RaisePropertyChanged("Related_Calculation__All__Reference");
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
