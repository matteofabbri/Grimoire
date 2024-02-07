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
	public class Multiple_Worksite_Report_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private string company_Legal_NameField;

		private string company_FEINField;

		private Calendar_YearObjectType calendar_Year_ReferenceField;

		private Calendar_QuarterObjectType calendar_Quarter_ReferenceField;

		private decimal quarter_NumberField;

		private bool quarter_NumberFieldSpecified;

		private Multiple_Worksite_Report_State_DataType[] multiple_Worksite_Report_State_DataField;

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
		public string Company_Legal_Name
		{
			get
			{
				return this.company_Legal_NameField;
			}
			set
			{
				this.company_Legal_NameField = value;
				this.RaisePropertyChanged("Company_Legal_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Company_FEIN
		{
			get
			{
				return this.company_FEINField;
			}
			set
			{
				this.company_FEINField = value;
				this.RaisePropertyChanged("Company_FEIN");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Calendar_QuarterObjectType Calendar_Quarter_Reference
		{
			get
			{
				return this.calendar_Quarter_ReferenceField;
			}
			set
			{
				this.calendar_Quarter_ReferenceField = value;
				this.RaisePropertyChanged("Calendar_Quarter_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Quarter_Number
		{
			get
			{
				return this.quarter_NumberField;
			}
			set
			{
				this.quarter_NumberField = value;
				this.RaisePropertyChanged("Quarter_Number");
			}
		}

		[XmlIgnore]
		public bool Quarter_NumberSpecified
		{
			get
			{
				return this.quarter_NumberFieldSpecified;
			}
			set
			{
				this.quarter_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Quarter_NumberSpecified");
			}
		}

		[XmlElement("Multiple_Worksite_Report_State_Data", Order = 6)]
		public Multiple_Worksite_Report_State_DataType[] Multiple_Worksite_Report_State_Data
		{
			get
			{
				return this.multiple_Worksite_Report_State_DataField;
			}
			set
			{
				this.multiple_Worksite_Report_State_DataField = value;
				this.RaisePropertyChanged("Multiple_Worksite_Report_State_Data");
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
