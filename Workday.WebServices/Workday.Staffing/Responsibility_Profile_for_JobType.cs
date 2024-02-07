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
	public class Responsibility_Profile_for_JobType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType responsibility_Profile_ReferenceField;

		private Responsibility_Profile_for_Job_DataType responsibility_Profile_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Responsibility_Profile_Reference
		{
			get
			{
				return this.responsibility_Profile_ReferenceField;
			}
			set
			{
				this.responsibility_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Responsibility_Profile_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Responsibility_Profile_for_Job_DataType Responsibility_Profile_Data
		{
			get
			{
				return this.responsibility_Profile_DataField;
			}
			set
			{
				this.responsibility_Profile_DataField = value;
				this.RaisePropertyChanged("Responsibility_Profile_Data");
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
