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
	public class Feedback_ResponseType : INotifyPropertyChanged
	{
		private string feedback_QuestionField;

		private string feedback_CommentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Feedback_Question
		{
			get
			{
				return this.feedback_QuestionField;
			}
			set
			{
				this.feedback_QuestionField = value;
				this.RaisePropertyChanged("Feedback_Question");
			}
		}

		[XmlElement(Order = 1)]
		public string Feedback_Comment
		{
			get
			{
				return this.feedback_CommentField;
			}
			set
			{
				this.feedback_CommentField = value;
				this.RaisePropertyChanged("Feedback_Comment");
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
