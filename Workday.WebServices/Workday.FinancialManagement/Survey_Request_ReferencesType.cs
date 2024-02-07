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
	public class Survey_Request_ReferencesType : INotifyPropertyChanged
	{
		private Effort_Certification_SurveyObjectType[] survey_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Survey_Reference", Order = 0)]
		public Effort_Certification_SurveyObjectType[] Survey_Reference
		{
			get
			{
				return this.survey_ReferenceField;
			}
			set
			{
				this.survey_ReferenceField = value;
				this.RaisePropertyChanged("Survey_Reference");
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
