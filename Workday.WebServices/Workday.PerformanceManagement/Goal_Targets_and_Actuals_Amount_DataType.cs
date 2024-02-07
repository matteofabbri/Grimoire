using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Goal_Targets_and_Actuals_Amount_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType goal_Target_And_Actual_Track_By_ReferenceField;

		private CurrencyObjectType goal_Currency_ReferenceField;

		private decimal target_AmountField;

		private bool target_AmountFieldSpecified;

		private decimal actual_AmountField;

		private bool actual_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Goal_Target_And_Actual_Track_By_Reference
		{
			get
			{
				return this.goal_Target_And_Actual_Track_By_ReferenceField;
			}
			set
			{
				this.goal_Target_And_Actual_Track_By_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Target_And_Actual_Track_By_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public CurrencyObjectType Goal_Currency_Reference
		{
			get
			{
				return this.goal_Currency_ReferenceField;
			}
			set
			{
				this.goal_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Currency_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Target_Amount
		{
			get
			{
				return this.target_AmountField;
			}
			set
			{
				this.target_AmountField = value;
				this.RaisePropertyChanged("Target_Amount");
			}
		}

		[XmlIgnore]
		public bool Target_AmountSpecified
		{
			get
			{
				return this.target_AmountFieldSpecified;
			}
			set
			{
				this.target_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Target_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Actual_Amount
		{
			get
			{
				return this.actual_AmountField;
			}
			set
			{
				this.actual_AmountField = value;
				this.RaisePropertyChanged("Actual_Amount");
			}
		}

		[XmlIgnore]
		public bool Actual_AmountSpecified
		{
			get
			{
				return this.actual_AmountFieldSpecified;
			}
			set
			{
				this.actual_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Actual_AmountSpecified");
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
