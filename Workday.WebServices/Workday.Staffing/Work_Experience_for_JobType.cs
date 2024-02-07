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
	public class Work_Experience_for_JobType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType worker_Experience_Profile_ReferenceField;

		private Work_Experience_Profile_for_Job_DataType work_Experience_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Worker_Experience_Profile_Reference
		{
			get
			{
				return this.worker_Experience_Profile_ReferenceField;
			}
			set
			{
				this.worker_Experience_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Experience_Profile_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Work_Experience_Profile_for_Job_DataType Work_Experience_Data
		{
			get
			{
				return this.work_Experience_DataField;
			}
			set
			{
				this.work_Experience_DataField = value;
				this.RaisePropertyChanged("Work_Experience_Data");
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
