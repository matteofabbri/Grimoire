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
	public class Feedback_and_Review_QuestionType : INotifyPropertyChanged
	{
		private QuestionObjectType feedback_and_Review_Question_ReferenceField;

		private Question_DataType[] feedback_and_Review_Question_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public QuestionObjectType Feedback_and_Review_Question_Reference
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

		[XmlElement("Feedback_and_Review_Question_Data", Order = 1)]
		public Question_DataType[] Feedback_and_Review_Question_Data
		{
			get
			{
				return this.feedback_and_Review_Question_DataField;
			}
			set
			{
				this.feedback_and_Review_Question_DataField = value;
				this.RaisePropertyChanged("Feedback_and_Review_Question_Data");
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
