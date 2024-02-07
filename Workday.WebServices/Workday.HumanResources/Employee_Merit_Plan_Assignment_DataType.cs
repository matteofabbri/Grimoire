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
	public class Employee_Merit_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private Merit_Percent_PlanObjectType compensation_Plan_ReferenceField;

		private decimal individual_Target_PercentField;

		private bool individual_Target_PercentFieldSpecified;

		private decimal default_Target_PercentField;

		private bool default_Target_PercentFieldSpecified;

		private Compensation_MatrixObjectType merit_Increase_Matrix_ReferenceField;

		private bool guaranteed_MinimumField;

		private bool guaranteed_MinimumFieldSpecified;

		private DateTime assignment_Effective_DateField;

		private bool assignment_Effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Merit_Percent_PlanObjectType Compensation_Plan_Reference
		{
			get
			{
				return this.compensation_Plan_ReferenceField;
			}
			set
			{
				this.compensation_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public decimal Default_Target_Percent
		{
			get
			{
				return this.default_Target_PercentField;
			}
			set
			{
				this.default_Target_PercentField = value;
				this.RaisePropertyChanged("Default_Target_Percent");
			}
		}

		[XmlIgnore]
		public bool Default_Target_PercentSpecified
		{
			get
			{
				return this.default_Target_PercentFieldSpecified;
			}
			set
			{
				this.default_Target_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Default_Target_PercentSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Compensation_MatrixObjectType Merit_Increase_Matrix_Reference
		{
			get
			{
				return this.merit_Increase_Matrix_ReferenceField;
			}
			set
			{
				this.merit_Increase_Matrix_ReferenceField = value;
				this.RaisePropertyChanged("Merit_Increase_Matrix_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Assignment_Effective_Date
		{
			get
			{
				return this.assignment_Effective_DateField;
			}
			set
			{
				this.assignment_Effective_DateField = value;
				this.RaisePropertyChanged("Assignment_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Assignment_Effective_DateSpecified
		{
			get
			{
				return this.assignment_Effective_DateFieldSpecified;
			}
			set
			{
				this.assignment_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Assignment_Effective_DateSpecified");
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
