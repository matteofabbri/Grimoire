using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Survey_DataType : INotifyPropertyChanged
	{
		private Effort_Certification_Survey_TypeObjectType survey_Type_ReferenceField;

		private string survey_NameField;

		private Survey_Question_DataType[] survey_Question_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Effort_Certification_Survey_TypeObjectType Survey_Type_Reference
		{
			get
			{
				return this.survey_Type_ReferenceField;
			}
			set
			{
				this.survey_Type_ReferenceField = value;
				this.RaisePropertyChanged("Survey_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Survey_Name
		{
			get
			{
				return this.survey_NameField;
			}
			set
			{
				this.survey_NameField = value;
				this.RaisePropertyChanged("Survey_Name");
			}
		}

		[XmlElement("Survey_Question_Reference", Order = 2)]
		public Survey_Question_DataType[] Survey_Question_Reference
		{
			get
			{
				return this.survey_Question_ReferenceField;
			}
			set
			{
				this.survey_Question_ReferenceField = value;
				this.RaisePropertyChanged("Survey_Question_Reference");
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
