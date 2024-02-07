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
	public class Job_Classification_Group_Request_ReferencesType : INotifyPropertyChanged
	{
		private Job_Classification_GroupObjectType[] job_Classification_Group_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Job_Classification_Group_Reference", Order = 0)]
		public Job_Classification_GroupObjectType[] Job_Classification_Group_Reference
		{
			get
			{
				return this.job_Classification_Group_ReferenceField;
			}
			set
			{
				this.job_Classification_Group_ReferenceField = value;
				this.RaisePropertyChanged("Job_Classification_Group_Reference");
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
