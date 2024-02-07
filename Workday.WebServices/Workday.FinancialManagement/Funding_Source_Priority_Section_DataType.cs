using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Funding_Source_Priority_Section_DataType : INotifyPropertyChanged
	{
		private Abstract_Funding_SourceObjectType funding_Source_ReferenceField;

		private decimal percentageField;

		private decimal current_Available_BalanceField;

		private bool current_Available_BalanceFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Abstract_Funding_SourceObjectType Funding_Source_Reference
		{
			get
			{
				return this.funding_Source_ReferenceField;
			}
			set
			{
				this.funding_Source_ReferenceField = value;
				this.RaisePropertyChanged("Funding_Source_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Percentage
		{
			get
			{
				return this.percentageField;
			}
			set
			{
				this.percentageField = value;
				this.RaisePropertyChanged("Percentage");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Current_Available_Balance
		{
			get
			{
				return this.current_Available_BalanceField;
			}
			set
			{
				this.current_Available_BalanceField = value;
				this.RaisePropertyChanged("Current_Available_Balance");
			}
		}

		[XmlIgnore]
		public bool Current_Available_BalanceSpecified
		{
			get
			{
				return this.current_Available_BalanceFieldSpecified;
			}
			set
			{
				this.current_Available_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Current_Available_BalanceSpecified");
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
