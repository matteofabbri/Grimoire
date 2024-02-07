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
	public class Box_16_Data_WrapperType : INotifyPropertyChanged
	{
		private Box_16_AA_DataType[] overtime_During_EmergencyField;

		private Box_16_AB_DataType[] overtime_By_Police_MemberField;

		private Box_16_AC_DataType[] stipendsField;

		private Box_16_AD_DataType[] compensation_for_Researcher_or_ScientistField;

		private Box_16_AE_DataType[] salary_Not_Over_40KField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Overtime_During_Emergency", Order = 0)]
		public Box_16_AA_DataType[] Overtime_During_Emergency
		{
			get
			{
				return this.overtime_During_EmergencyField;
			}
			set
			{
				this.overtime_During_EmergencyField = value;
				this.RaisePropertyChanged("Overtime_During_Emergency");
			}
		}

		[XmlElement("Overtime_By_Police_Member", Order = 1)]
		public Box_16_AB_DataType[] Overtime_By_Police_Member
		{
			get
			{
				return this.overtime_By_Police_MemberField;
			}
			set
			{
				this.overtime_By_Police_MemberField = value;
				this.RaisePropertyChanged("Overtime_By_Police_Member");
			}
		}

		[XmlElement("Stipends", Order = 2)]
		public Box_16_AC_DataType[] Stipends
		{
			get
			{
				return this.stipendsField;
			}
			set
			{
				this.stipendsField = value;
				this.RaisePropertyChanged("Stipends");
			}
		}

		[XmlElement("Compensation_for_Researcher_or_Scientist", Order = 3)]
		public Box_16_AD_DataType[] Compensation_for_Researcher_or_Scientist
		{
			get
			{
				return this.compensation_for_Researcher_or_ScientistField;
			}
			set
			{
				this.compensation_for_Researcher_or_ScientistField = value;
				this.RaisePropertyChanged("Compensation_for_Researcher_or_Scientist");
			}
		}

		[XmlElement("Salary_Not_Over_40K", Order = 4)]
		public Box_16_AE_DataType[] Salary_Not_Over_40K
		{
			get
			{
				return this.salary_Not_Over_40KField;
			}
			set
			{
				this.salary_Not_Over_40KField = value;
				this.RaisePropertyChanged("Salary_Not_Over_40K");
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
