using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Contribution_Amount_DataType : INotifyPropertyChanged
	{
		private Contribution_Amount_DataType contribution_Amount_DataField;

		private Payroll_Interface_Contribution_Amount_DataType payroll_Interface_Contribution_Amount_DataField;

		private decimal contribution_Amount_MaximumField;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Contribution_Amount_DataType Contribution_Amount_Data
		{
			get
			{
				return this.contribution_Amount_DataField;
			}
			set
			{
				this.contribution_Amount_DataField = value;
				this.RaisePropertyChanged("Contribution_Amount_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_Interface_Contribution_Amount_DataType Payroll_Interface_Contribution_Amount_Data
		{
			get
			{
				return this.payroll_Interface_Contribution_Amount_DataField;
			}
			set
			{
				this.payroll_Interface_Contribution_Amount_DataField = value;
				this.RaisePropertyChanged("Payroll_Interface_Contribution_Amount_Data");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Contribution_Amount_Maximum
		{
			get
			{
				return this.contribution_Amount_MaximumField;
			}
			set
			{
				this.contribution_Amount_MaximumField = value;
				this.RaisePropertyChanged("Contribution_Amount_Maximum");
			}
		}

		[XmlElement(Order = 3)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
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
