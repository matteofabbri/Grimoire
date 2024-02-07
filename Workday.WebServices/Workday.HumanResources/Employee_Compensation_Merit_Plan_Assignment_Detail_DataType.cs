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
	public class Employee_Compensation_Merit_Plan_Assignment_Detail_DataType : INotifyPropertyChanged
	{
		private decimal individual_TargetField;

		private bool individual_TargetFieldSpecified;

		private bool guaranteed_MinimumField;

		private bool guaranteed_MinimumFieldSpecified;

		private DateTime actual_End_DateField;

		private bool actual_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Individual_Target
		{
			get
			{
				return this.individual_TargetField;
			}
			set
			{
				this.individual_TargetField = value;
				this.RaisePropertyChanged("Individual_Target");
			}
		}

		[XmlIgnore]
		public bool Individual_TargetSpecified
		{
			get
			{
				return this.individual_TargetFieldSpecified;
			}
			set
			{
				this.individual_TargetFieldSpecified = value;
				this.RaisePropertyChanged("Individual_TargetSpecified");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(DataType = "date", Order = 2)]
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
