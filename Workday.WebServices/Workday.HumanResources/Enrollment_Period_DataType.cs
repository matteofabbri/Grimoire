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
	public class Enrollment_Period_DataType : INotifyPropertyChanged
	{
		private string benefit_Program_NameField;

		private DateTime plan_YearField;

		private bool plan_YearFieldSpecified;

		private DateTime begin_DateField;

		private DateTime end_DateField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Benefit_Program_Name
		{
			get
			{
				return this.benefit_Program_NameField;
			}
			set
			{
				this.benefit_Program_NameField = value;
				this.RaisePropertyChanged("Benefit_Program_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Plan_Year
		{
			get
			{
				return this.plan_YearField;
			}
			set
			{
				this.plan_YearField = value;
				this.RaisePropertyChanged("Plan_Year");
			}
		}

		[XmlIgnore]
		public bool Plan_YearSpecified
		{
			get
			{
				return this.plan_YearFieldSpecified;
			}
			set
			{
				this.plan_YearFieldSpecified = value;
				this.RaisePropertyChanged("Plan_YearSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Begin_Date
		{
			get
			{
				return this.begin_DateField;
			}
			set
			{
				this.begin_DateField = value;
				this.RaisePropertyChanged("Begin_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
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
