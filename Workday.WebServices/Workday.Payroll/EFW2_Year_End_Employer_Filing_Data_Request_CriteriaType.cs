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
	public class EFW2_Year_End_Employer_Filing_Data_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private Calendar_YearObjectType calendar_Year_ReferenceField;

		private bool exclude_Opt_Out_WorkersField;

		private bool exclude_Opt_Out_WorkersFieldSpecified;

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
		public bool Exclude_Opt_Out_Workers
		{
			get
			{
				return this.exclude_Opt_Out_WorkersField;
			}
			set
			{
				this.exclude_Opt_Out_WorkersField = value;
				this.RaisePropertyChanged("Exclude_Opt_Out_Workers");
			}
		}

		[XmlIgnore]
		public bool Exclude_Opt_Out_WorkersSpecified
		{
			get
			{
				return this.exclude_Opt_Out_WorkersFieldSpecified;
			}
			set
			{
				this.exclude_Opt_Out_WorkersFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Opt_Out_WorkersSpecified");
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
