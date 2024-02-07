using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Feedback_and_Review_Question_Request_ReferencesType : INotifyPropertyChanged
	{
		private QuestionObjectType[] feedback_and_Review_Question_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Feedback_and_Review_Question_Reference", Order = 0)]
		public QuestionObjectType[] Feedback_and_Review_Question_Reference
		{
			get
			{
				return this.feedback_and_Review_Question_ReferenceField;
			}
			set
			{
				this.feedback_and_Review_Question_ReferenceField = value;
				this.RaisePropertyChanged("Feedback_and_Review_Question_Reference");
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
