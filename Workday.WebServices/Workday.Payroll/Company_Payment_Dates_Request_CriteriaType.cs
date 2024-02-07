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
	public class Company_Payment_Dates_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private bool include_Related_Companies_for_Legal_EntityField;

		private bool include_Related_Companies_for_Legal_EntityFieldSpecified;

		private DateTime result_Completed_FromField;

		private DateTime result_Completed_ToField;

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
		public bool Include_Related_Companies_for_Legal_Entity
		{
			get
			{
				return this.include_Related_Companies_for_Legal_EntityField;
			}
			set
			{
				this.include_Related_Companies_for_Legal_EntityField = value;
				this.RaisePropertyChanged("Include_Related_Companies_for_Legal_Entity");
			}
		}

		[XmlIgnore]
		public bool Include_Related_Companies_for_Legal_EntitySpecified
		{
			get
			{
				return this.include_Related_Companies_for_Legal_EntityFieldSpecified;
			}
			set
			{
				this.include_Related_Companies_for_Legal_EntityFieldSpecified = value;
				this.RaisePropertyChanged("Include_Related_Companies_for_Legal_EntitySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Result_Completed_From
		{
			get
			{
				return this.result_Completed_FromField;
			}
			set
			{
				this.result_Completed_FromField = value;
				this.RaisePropertyChanged("Result_Completed_From");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Result_Completed_To
		{
			get
			{
				return this.result_Completed_ToField;
			}
			set
			{
				this.result_Completed_ToField = value;
				this.RaisePropertyChanged("Result_Completed_To");
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
