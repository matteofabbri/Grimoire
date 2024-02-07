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
	public class Goal_Comment_DataType : INotifyPropertyChanged
	{
		private string comment_TextField;

		private WorkerObjectType worker_ReferenceField;

		private DateTime comment_Entry_MomentField;

		private bool comment_Entry_MomentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Comment_Text
		{
			get
			{
				return this.comment_TextField;
			}
			set
			{
				this.comment_TextField = value;
				this.RaisePropertyChanged("Comment_Text");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Comment_Entry_Moment
		{
			get
			{
				return this.comment_Entry_MomentField;
			}
			set
			{
				this.comment_Entry_MomentField = value;
				this.RaisePropertyChanged("Comment_Entry_Moment");
			}
		}

		[XmlIgnore]
		public bool Comment_Entry_MomentSpecified
		{
			get
			{
				return this.comment_Entry_MomentFieldSpecified;
			}
			set
			{
				this.comment_Entry_MomentFieldSpecified = value;
				this.RaisePropertyChanged("Comment_Entry_MomentSpecified");
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
