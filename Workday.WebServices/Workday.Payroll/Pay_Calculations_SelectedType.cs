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
	public class Pay_Calculations_SelectedType : INotifyPropertyChanged
	{
		private Earning__All_ObjectType[] earning_ReferenceField;

		private Deduction__All_ObjectType[] deduction_ReferenceField;

		private Pay_Accumulation__All_ObjectType[] pay_Accumulation_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Earning_Reference", Order = 0)]
		public Earning__All_ObjectType[] Earning_Reference
		{
			get
			{
				return this.earning_ReferenceField;
			}
			set
			{
				this.earning_ReferenceField = value;
				this.RaisePropertyChanged("Earning_Reference");
			}
		}

		[XmlElement("Deduction_Reference", Order = 1)]
		public Deduction__All_ObjectType[] Deduction_Reference
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

		[XmlElement("Pay_Accumulation_Reference", Order = 2)]
		public Pay_Accumulation__All_ObjectType[] Pay_Accumulation_Reference
		{
			get
			{
				return this.pay_Accumulation_ReferenceField;
			}
			set
			{
				this.pay_Accumulation_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Accumulation_Reference");
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
