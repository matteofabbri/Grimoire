using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "ACA_1095-C_Form_Request_CriteriaType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ACA_1095C_Form_Request_CriteriaType : INotifyPropertyChanged
	{
		private Calendar_YearObjectType calendar_Year_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private WorkerObjectType[] employee_ReferenceField;

		private External_1095C_RecipientObjectType[] external_1095C_Recipient_ReferenceField;

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

		[XmlElement("Employee_Reference", Order = 2)]
		public WorkerObjectType[] Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement("External_1095-C_Recipient_Reference", Order = 3)]
		public External_1095C_RecipientObjectType[] External_1095C_Recipient_Reference
		{
			get
			{
				return this.external_1095C_Recipient_ReferenceField;
			}
			set
			{
				this.external_1095C_Recipient_ReferenceField = value;
				this.RaisePropertyChanged("External_1095C_Recipient_Reference");
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
