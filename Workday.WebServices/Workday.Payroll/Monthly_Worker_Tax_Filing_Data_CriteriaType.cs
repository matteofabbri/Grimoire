using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Monthly_Worker_Tax_Filing_Data_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private Calendar_YearObjectType calendar_Year_ReferenceField;

		private MonthObjectType month_ReferenceField;

		private DateTime as_Of_DateField;

		private bool as_Of_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Calendar_YearObjectType Calendar_Year_Reference
		{
			get
			{
				return this.calendar_Year_ReferenceField;
			}
			set
			{
				this.calendar_Year_ReferenceField = value;
				this.RaisePropertyChanged("Calendar_Year_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public MonthObjectType Month_Reference
		{
			get
			{
				return this.month_ReferenceField;
			}
			set
			{
				this.month_ReferenceField = value;
				this.RaisePropertyChanged("Month_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime As_Of_Date
		{
			get
			{
				return this.as_Of_DateField;
			}
			set
			{
				this.as_Of_DateField = value;
				this.RaisePropertyChanged("As_Of_Date");
			}
		}

		[XmlIgnore]
		public bool As_Of_DateSpecified
		{
			get
			{
				return this.as_Of_DateFieldSpecified;
			}
			set
			{
				this.as_Of_DateFieldSpecified = value;
				this.RaisePropertyChanged("As_Of_DateSpecified");
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
