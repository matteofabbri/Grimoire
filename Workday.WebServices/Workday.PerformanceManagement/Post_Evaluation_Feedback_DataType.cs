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
	public class Post_Evaluation_Feedback_DataType : INotifyPropertyChanged
	{
		private Post_Evaluation_Feedback_Employee_DataType post_Evaluation_Feedback_Employee_DataField;

		private Post_Evaluation_Feedback_Manager_DataType post_Evaluation_Feedback_Manager_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Post_Evaluation_Feedback_Employee_DataType Post_Evaluation_Feedback_Employee_Data
		{
			get
			{
				return this.post_Evaluation_Feedback_Employee_DataField;
			}
			set
			{
				this.post_Evaluation_Feedback_Employee_DataField = value;
				this.RaisePropertyChanged("Post_Evaluation_Feedback_Employee_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Post_Evaluation_Feedback_Manager_DataType Post_Evaluation_Feedback_Manager_Data
		{
			get
			{
				return this.post_Evaluation_Feedback_Manager_DataField;
			}
			set
			{
				this.post_Evaluation_Feedback_Manager_DataField = value;
				this.RaisePropertyChanged("Post_Evaluation_Feedback_Manager_Data");
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
