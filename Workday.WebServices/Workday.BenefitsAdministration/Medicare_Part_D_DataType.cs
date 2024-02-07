using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Medicare_Part_D_DataType : INotifyPropertyChanged
	{
		private DateTime enrollment_DateField;

		private DateTime termination_DateField;

		private bool termination_DateFieldSpecified;

		private DateTime eligibility_Start_DateField;

		private DateTime eligibility_Stop_DateField;

		private bool eligibility_Stop_DateFieldSpecified;

		private string plan_Contractor_NumberField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Enrollment_Date
		{
			get
			{
				return this.enrollment_DateField;
			}
			set
			{
				this.enrollment_DateField = value;
				this.RaisePropertyChanged("Enrollment_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Termination_Date
		{
			get
			{
				return this.termination_DateField;
			}
			set
			{
				this.termination_DateField = value;
				this.RaisePropertyChanged("Termination_Date");
			}
		}

		[XmlIgnore]
		public bool Termination_DateSpecified
		{
			get
			{
				return this.termination_DateFieldSpecified;
			}
			set
			{
				this.termination_DateFieldSpecified = value;
				this.RaisePropertyChanged("Termination_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Eligibility_Start_Date
		{
			get
			{
				return this.eligibility_Start_DateField;
			}
			set
			{
				this.eligibility_Start_DateField = value;
				this.RaisePropertyChanged("Eligibility_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Eligibility_Stop_Date
		{
			get
			{
				return this.eligibility_Stop_DateField;
			}
			set
			{
				this.eligibility_Stop_DateField = value;
				this.RaisePropertyChanged("Eligibility_Stop_Date");
			}
		}

		[XmlIgnore]
		public bool Eligibility_Stop_DateSpecified
		{
			get
			{
				return this.eligibility_Stop_DateFieldSpecified;
			}
			set
			{
				this.eligibility_Stop_DateFieldSpecified = value;
				this.RaisePropertyChanged("Eligibility_Stop_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Plan_Contractor_Number
		{
			get
			{
				return this.plan_Contractor_NumberField;
			}
			set
			{
				this.plan_Contractor_NumberField = value;
				this.RaisePropertyChanged("Plan_Contractor_Number");
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
