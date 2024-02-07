using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Competency_Profile_for_JobType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType competency_Profile_ReferenceField;

		private Competency_Profile_for_Job_DataType competency_Profile_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Competency_Profile_Reference
		{
			get
			{
				return this.competency_Profile_ReferenceField;
			}
			set
			{
				this.competency_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Competency_Profile_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Competency_Profile_for_Job_DataType Competency_Profile_Data
		{
			get
			{
				return this.competency_Profile_DataField;
			}
			set
			{
				this.competency_Profile_DataField = value;
				this.RaisePropertyChanged("Competency_Profile_Data");
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
