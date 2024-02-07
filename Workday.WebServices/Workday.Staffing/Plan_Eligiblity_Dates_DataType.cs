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
	public class Plan_Eligiblity_Dates_DataType : INotifyPropertyChanged
	{
		private Benefit_PlanObjectType benefit_Plan_ReferenceField;

		private DateTime earliest_Eligibility_DateField;

		private bool earliest_Eligibility_DateFieldSpecified;

		private DateTime earliest_Contiguous_Eligibility_DateField;

		private bool earliest_Contiguous_Eligibility_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Benefit_PlanObjectType Benefit_Plan_Reference
		{
			get
			{
				return this.benefit_Plan_ReferenceField;
			}
			set
			{
				this.benefit_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Plan_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Earliest_Eligibility_Date
		{
			get
			{
				return this.earliest_Eligibility_DateField;
			}
			set
			{
				this.earliest_Eligibility_DateField = value;
				this.RaisePropertyChanged("Earliest_Eligibility_Date");
			}
		}

		[XmlIgnore]
		public bool Earliest_Eligibility_DateSpecified
		{
			get
			{
				return this.earliest_Eligibility_DateFieldSpecified;
			}
			set
			{
				this.earliest_Eligibility_DateFieldSpecified = value;
				this.RaisePropertyChanged("Earliest_Eligibility_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Earliest_Contiguous_Eligibility_Date
		{
			get
			{
				return this.earliest_Contiguous_Eligibility_DateField;
			}
			set
			{
				this.earliest_Contiguous_Eligibility_DateField = value;
				this.RaisePropertyChanged("Earliest_Contiguous_Eligibility_Date");
			}
		}

		[XmlIgnore]
		public bool Earliest_Contiguous_Eligibility_DateSpecified
		{
			get
			{
				return this.earliest_Contiguous_Eligibility_DateFieldSpecified;
			}
			set
			{
				this.earliest_Contiguous_Eligibility_DateFieldSpecified = value;
				this.RaisePropertyChanged("Earliest_Contiguous_Eligibility_DateSpecified");
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
