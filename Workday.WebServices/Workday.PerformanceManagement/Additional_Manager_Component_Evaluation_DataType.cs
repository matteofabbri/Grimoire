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
	public class Additional_Manager_Component_Evaluation_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType additional_Manager_ReferenceField;

		private string additional_Manager_CommentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Additional_Manager_Reference
		{
			get
			{
				return this.additional_Manager_ReferenceField;
			}
			set
			{
				this.additional_Manager_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Manager_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Additional_Manager_Comment
		{
			get
			{
				return this.additional_Manager_CommentField;
			}
			set
			{
				this.additional_Manager_CommentField = value;
				this.RaisePropertyChanged("Additional_Manager_Comment");
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
