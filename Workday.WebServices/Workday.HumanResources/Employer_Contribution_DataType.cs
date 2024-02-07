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
	public class Employer_Contribution_DataType : INotifyPropertyChanged
	{
		private Contribution_DataType contribution_DataField;

		private Payroll_Interface_Contribution_DataType payroll_Interface_Contribution_DataField;

		private Goal_DataType goal_DataField;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Contribution_DataType Contribution_Data
		{
			get
			{
				return this.contribution_DataField;
			}
			set
			{
				this.contribution_DataField = value;
				this.RaisePropertyChanged("Contribution_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_Interface_Contribution_DataType Payroll_Interface_Contribution_Data
		{
			get
			{
				return this.payroll_Interface_Contribution_DataField;
			}
			set
			{
				this.payroll_Interface_Contribution_DataField = value;
				this.RaisePropertyChanged("Payroll_Interface_Contribution_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Goal_DataType Goal_Data
		{
			get
			{
				return this.goal_DataField;
			}
			set
			{
				this.goal_DataField = value;
				this.RaisePropertyChanged("Goal_Data");
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
