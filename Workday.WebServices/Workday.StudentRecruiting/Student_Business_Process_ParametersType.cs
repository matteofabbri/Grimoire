using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Business_Process_ParametersType : INotifyPropertyChanged
	{
		private bool automatically_CompleteField;

		private bool automatically_CompleteFieldSpecified;

		private Business_Process_Comment_DataType comment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Automatically_Complete
		{
			get
			{
				return this.automatically_CompleteField;
			}
			set
			{
				this.automatically_CompleteField = value;
				this.RaisePropertyChanged("Automatically_Complete");
			}
		}

		[XmlIgnore]
		public bool Automatically_CompleteSpecified
		{
			get
			{
				return this.automatically_CompleteFieldSpecified;
			}
			set
			{
				this.automatically_CompleteFieldSpecified = value;
				this.RaisePropertyChanged("Automatically_CompleteSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Business_Process_Comment_DataType Comment_Data
		{
			get
			{
				return this.comment_DataField;
			}
			set
			{
				this.comment_DataField = value;
				this.RaisePropertyChanged("Comment_Data");
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
