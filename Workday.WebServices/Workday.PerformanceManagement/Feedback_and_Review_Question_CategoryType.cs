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
	public class Feedback_and_Review_Question_CategoryType : INotifyPropertyChanged
	{
		private Question_CategoryObjectType feedback_and_Review_Question_Category_ReferenceField;

		private Feedback_and_Review_Question_Category_DataType[] feedback_and_Review_Question_Category_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Question_CategoryObjectType Feedback_and_Review_Question_Category_Reference
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

		[XmlElement("Feedback_and_Review_Question_Category_Data", Order = 1)]
		public Feedback_and_Review_Question_Category_DataType[] Feedback_and_Review_Question_Category_Data
		{
			get
			{
				return this.feedback_and_Review_Question_Category_DataField;
			}
			set
			{
				this.feedback_and_Review_Question_Category_DataField = value;
				this.RaisePropertyChanged("Feedback_and_Review_Question_Category_Data");
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
