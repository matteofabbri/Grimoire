using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Proposed_Merit_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private Merit_PlanObjectType merit_Plan_ReferenceField;

		private decimal individual_Target_AmountField;

		private bool individual_Target_AmountFieldSpecified;

		private decimal individual_Target_PercentField;

		private bool individual_Target_PercentFieldSpecified;

		private bool guaranteed_MinimumField;

		private bool guaranteed_MinimumFieldSpecified;

		private DateTime actual_End_DateField;

		private bool actual_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Merit_PlanObjectType Merit_Plan_Reference
		{
			get
			{
				return this.merit_Plan_ReferenceField;
			}
			set
			{
				this.merit_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Merit_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Individual_Target_Amount
		{
			get
			{
				return this.individual_Target_AmountField;
			}
			set
			{
				this.individual_Target_AmountField = value;
				this.RaisePropertyChanged("Individual_Target_Amount");
			}
		}

		[XmlIgnore]
		public bool Individual_Target_AmountSpecified
		{
			get
			{
				return this.individual_Target_AmountFieldSpecified;
			}
			set
			{
				this.individual_Target_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Individual_Target_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Individual_Target_Percent
		{
			get
			{
				return this.individual_Target_PercentField;
			}
			set
			{
				this.individual_Target_PercentField = value;
				this.RaisePropertyChanged("Individual_Target_Percent");
			}
		}

		[XmlIgnore]
		public bool Individual_Target_PercentSpecified
		{
			get
			{
				return this.individual_Target_PercentFieldSpecified;
			}
			set
			{
				this.individual_Target_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Individual_Target_PercentSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Guaranteed_Minimum
		{
			get
			{
				return this.guaranteed_MinimumField;
			}
			set
			{
				this.guaranteed_MinimumField = value;
				this.RaisePropertyChanged("Guaranteed_Minimum");
			}
		}

		[XmlIgnore]
		public bool Guaranteed_MinimumSpecified
		{
			get
			{
				return this.guaranteed_MinimumFieldSpecified;
			}
			set
			{
				this.guaranteed_MinimumFieldSpecified = value;
				this.RaisePropertyChanged("Guaranteed_MinimumSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Actual_End_Date
		{
			get
			{
				return this.actual_End_DateField;
			}
			set
			{
				this.actual_End_DateField = value;
				this.RaisePropertyChanged("Actual_End_Date");
			}
		}

		[XmlIgnore]
		public bool Actual_End_DateSpecified
		{
			get
			{
				return this.actual_End_DateFieldSpecified;
			}
			set
			{
				this.actual_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Actual_End_DateSpecified");
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
