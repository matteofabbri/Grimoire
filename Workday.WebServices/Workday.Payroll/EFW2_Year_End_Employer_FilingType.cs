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
	public class EFW2_Year_End_Employer_FilingType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private EFW2_Year_End_Employer_Filing_DataType eFW2_Year_End_Employer_Filing_DataField;

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
		public EFW2_Year_End_Employer_Filing_DataType EFW2_Year_End_Employer_Filing_Data
		{
			get
			{
				return this.eFW2_Year_End_Employer_Filing_DataField;
			}
			set
			{
				this.eFW2_Year_End_Employer_Filing_DataField = value;
				this.RaisePropertyChanged("EFW2_Year_End_Employer_Filing_Data");
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
