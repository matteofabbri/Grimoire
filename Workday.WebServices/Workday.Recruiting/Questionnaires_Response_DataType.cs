using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Questionnaires_Response_DataType : INotifyPropertyChanged
	{
		private QuestionnaireObjectType questionnaire_ReferenceField;

		private Questionnaire_Answer_DataType[] questionnaire_Answer_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public QuestionnaireObjectType Questionnaire_Reference
		{
			get
			{
				return this.questionnaire_ReferenceField;
			}
			set
			{
				this.questionnaire_ReferenceField = value;
				this.RaisePropertyChanged("Questionnaire_Reference");
			}
		}

		[XmlElement("Questionnaire_Answer_Data", Order = 1)]
		public Questionnaire_Answer_DataType[] Questionnaire_Answer_Data
		{
			get
			{
				return this.questionnaire_Answer_DataField;
			}
			set
			{
				this.questionnaire_Answer_DataField = value;
				this.RaisePropertyChanged("Questionnaire_Answer_Data");
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
