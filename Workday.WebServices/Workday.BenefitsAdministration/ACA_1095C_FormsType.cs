using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "ACA_1095-C_FormsType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ACA_1095C_FormsType : INotifyPropertyChanged
	{
		private Calendar_YearObjectType calendar_Year_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private ACA_1095C_FormType[] aCA_1095C_FormField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement("ACA_1095-C_Form", Order = 2)]
		public ACA_1095C_FormType[] ACA_1095C_Form
		{
			get
			{
				return this.aCA_1095C_FormField;
			}
			set
			{
				this.aCA_1095C_FormField = value;
				this.RaisePropertyChanged("ACA_1095C_Form");
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
