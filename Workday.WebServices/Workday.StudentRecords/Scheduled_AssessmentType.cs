using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Scheduled_AssessmentType : INotifyPropertyChanged
	{
		private Scheduled_AssessmentObjectType scheduled_Assessment_ReferenceField;

		private Scheduled_Assessment_DataType scheduled_Assessment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Scheduled_AssessmentObjectType Scheduled_Assessment_Reference
		{
			get
			{
				return this.scheduled_Assessment_ReferenceField;
			}
			set
			{
				this.scheduled_Assessment_ReferenceField = value;
				this.RaisePropertyChanged("Scheduled_Assessment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Scheduled_Assessment_DataType Scheduled_Assessment_Data
		{
			get
			{
				return this.scheduled_Assessment_DataField;
			}
			set
			{
				this.scheduled_Assessment_DataField = value;
				this.RaisePropertyChanged("Scheduled_Assessment_Data");
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
