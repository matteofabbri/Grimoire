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
	public class Job_Profile_Questionnaire_DataType : INotifyPropertyChanged
	{
		private QuestionnaireObjectType questionnaire_for_Internal_Career_Site_ReferenceField;

		private QuestionnaireObjectType secondary_Questionnaire_for_Internal_Career_Site_ReferenceField;

		private QuestionnaireObjectType questionnaire_for_External_Career_Sites_ReferenceField;

		private QuestionnaireObjectType secondary_Questionnaire_for_External_Career_Sites_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public QuestionnaireObjectType Questionnaire_for_Internal_Career_Site_Reference
		{
			get
			{
				return this.questionnaire_for_Internal_Career_Site_ReferenceField;
			}
			set
			{
				this.questionnaire_for_Internal_Career_Site_ReferenceField = value;
				this.RaisePropertyChanged("Questionnaire_for_Internal_Career_Site_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public QuestionnaireObjectType Secondary_Questionnaire_for_Internal_Career_Site_Reference
		{
			get
			{
				return this.secondary_Questionnaire_for_Internal_Career_Site_ReferenceField;
			}
			set
			{
				this.secondary_Questionnaire_for_Internal_Career_Site_ReferenceField = value;
				this.RaisePropertyChanged("Secondary_Questionnaire_for_Internal_Career_Site_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public QuestionnaireObjectType Questionnaire_for_External_Career_Sites_Reference
		{
			get
			{
				return this.questionnaire_for_External_Career_Sites_ReferenceField;
			}
			set
			{
				this.questionnaire_for_External_Career_Sites_ReferenceField = value;
				this.RaisePropertyChanged("Questionnaire_for_External_Career_Sites_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public QuestionnaireObjectType Secondary_Questionnaire_for_External_Career_Sites_Reference
		{
			get
			{
				return this.secondary_Questionnaire_for_External_Career_Sites_ReferenceField;
			}
			set
			{
				this.secondary_Questionnaire_for_External_Career_Sites_ReferenceField = value;
				this.RaisePropertyChanged("Secondary_Questionnaire_for_External_Career_Sites_Reference");
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
