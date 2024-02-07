using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class External_Student_Transcript_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_External_TranscriptObjectType[] external_Student_Transcript_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("External_Student_Transcript_Reference", Order = 0)]
		public Student_External_TranscriptObjectType[] External_Student_Transcript_Reference
		{
			get
			{
				return this.external_Student_Transcript_ReferenceField;
			}
			set
			{
				this.external_Student_Transcript_ReferenceField = value;
				this.RaisePropertyChanged("External_Student_Transcript_Reference");
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
