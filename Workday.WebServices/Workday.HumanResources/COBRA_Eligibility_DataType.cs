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
	public class COBRA_Eligibility_DataType : INotifyPropertyChanged
	{
		private COBRA_Eligibility_ReasonObjectType cOBRA_Eligibility_Reason_ReferenceField;

		private DateTime eligible_DateField;

		private bool eligible_DateFieldSpecified;

		private DateTime loss_of_Coverage_DateField;

		private bool loss_of_Coverage_DateFieldSpecified;

		private DateTime coverage_End_DateField;

		private bool coverage_End_DateFieldSpecified;

		private Benefit_PlanObjectType benefit_Plan_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public COBRA_Eligibility_ReasonObjectType COBRA_Eligibility_Reason_Reference
		{
			get
			{
				return this.cOBRA_Eligibility_Reason_ReferenceField;
			}
			set
			{
				this.cOBRA_Eligibility_Reason_ReferenceField = value;
				this.RaisePropertyChanged("COBRA_Eligibility_Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Eligible_Date
		{
			get
			{
				return this.eligible_DateField;
			}
			set
			{
				this.eligible_DateField = value;
				this.RaisePropertyChanged("Eligible_Date");
			}
		}

		[XmlIgnore]
		public bool Eligible_DateSpecified
		{
			get
			{
				return this.eligible_DateFieldSpecified;
			}
			set
			{
				this.eligible_DateFieldSpecified = value;
				this.RaisePropertyChanged("Eligible_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Loss_of_Coverage_Date
		{
			get
			{
				return this.loss_of_Coverage_DateField;
			}
			set
			{
				this.loss_of_Coverage_DateField = value;
				this.RaisePropertyChanged("Loss_of_Coverage_Date");
			}
		}

		[XmlIgnore]
		public bool Loss_of_Coverage_DateSpecified
		{
			get
			{
				return this.loss_of_Coverage_DateFieldSpecified;
			}
			set
			{
				this.loss_of_Coverage_DateFieldSpecified = value;
				this.RaisePropertyChanged("Loss_of_Coverage_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Coverage_End_Date
		{
			get
			{
				return this.coverage_End_DateField;
			}
			set
			{
				this.coverage_End_DateField = value;
				this.RaisePropertyChanged("Coverage_End_Date");
			}
		}

		[XmlIgnore]
		public bool Coverage_End_DateSpecified
		{
			get
			{
				return this.coverage_End_DateFieldSpecified;
			}
			set
			{
				this.coverage_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_End_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
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
