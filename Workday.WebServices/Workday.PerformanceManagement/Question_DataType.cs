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
	public class Question_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string questionField;

		private Question_CategoryObjectType[] feedback_and_Review_Question_Category_ReferenceField;

		private decimal used_In_Templates_CountField;

		private bool used_In_Templates_CountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Question
		{
			get
			{
				return this.questionField;
			}
			set
			{
				this.questionField = value;
				this.RaisePropertyChanged("Question");
			}
		}

		[XmlElement("Feedback_and_Review_Question_Category_Reference", Order = 2)]
		public Question_CategoryObjectType[] Feedback_and_Review_Question_Category_Reference
		{
			get
			{
				return this.feedback_and_Review_Question_Category_ReferenceField;
			}
			set
			{
				this.feedback_and_Review_Question_Category_ReferenceField = value;
				this.RaisePropertyChanged("Feedback_and_Review_Question_Category_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Used_In_Templates_Count
		{
			get
			{
				return this.used_In_Templates_CountField;
			}
			set
			{
				this.used_In_Templates_CountField = value;
				this.RaisePropertyChanged("Used_In_Templates_Count");
			}
		}

		[XmlIgnore]
		public bool Used_In_Templates_CountSpecified
		{
			get
			{
				return this.used_In_Templates_CountFieldSpecified;
			}
			set
			{
				this.used_In_Templates_CountFieldSpecified = value;
				this.RaisePropertyChanged("Used_In_Templates_CountSpecified");
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
