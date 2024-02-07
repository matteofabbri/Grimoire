using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Health_Savings_Account_Election_Info_DataType : INotifyPropertyChanged
	{
		private string coverage_Target_NameField;

		private decimal maximum_Annual_Contribution_AmountField;

		private bool maximum_Annual_Contribution_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Coverage_Target_Name
		{
			get
			{
				return this.coverage_Target_NameField;
			}
			set
			{
				this.coverage_Target_NameField = value;
				this.RaisePropertyChanged("Coverage_Target_Name");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Maximum_Annual_Contribution_Amount
		{
			get
			{
				return this.maximum_Annual_Contribution_AmountField;
			}
			set
			{
				this.maximum_Annual_Contribution_AmountField = value;
				this.RaisePropertyChanged("Maximum_Annual_Contribution_Amount");
			}
		}

		[XmlIgnore]
		public bool Maximum_Annual_Contribution_AmountSpecified
		{
			get
			{
				return this.maximum_Annual_Contribution_AmountFieldSpecified;
			}
			set
			{
				this.maximum_Annual_Contribution_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_Annual_Contribution_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
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
