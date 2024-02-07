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
	public class Manager_Component_Evaluation_DataType : INotifyPropertyChanged
	{
		private Abstract_Review_RatingObjectType review_Rating_ReferenceField;

		private string manager_CommentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Abstract_Review_RatingObjectType Review_Rating_Reference
		{
			get
			{
				return this.review_Rating_ReferenceField;
			}
			set
			{
				this.review_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Review_Rating_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Manager_Comment
		{
			get
			{
				return this.manager_CommentField;
			}
			set
			{
				this.manager_CommentField = value;
				this.RaisePropertyChanged("Manager_Comment");
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
