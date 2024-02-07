using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Applicant_Resume_Detail_DataType : INotifyPropertyChanged
	{
		private Applicant_ResumeObjectType resume_ReferenceField;

		private Attachment_Data_WWSType resume_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Applicant_ResumeObjectType Resume_Reference
		{
			get
			{
				return this.resume_ReferenceField;
			}
			set
			{
				this.resume_ReferenceField = value;
				this.RaisePropertyChanged("Resume_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Attachment_Data_WWSType Resume_Data
		{
			get
			{
				return this.resume_DataField;
			}
			set
			{
				this.resume_DataField = value;
				this.RaisePropertyChanged("Resume_Data");
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
