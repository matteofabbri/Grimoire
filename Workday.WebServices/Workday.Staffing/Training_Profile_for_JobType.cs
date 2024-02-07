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
	public class Training_Profile_for_JobType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType training_Profile_ReferenceField;

		private Training_Profile_for_Job_DataType training_Profile_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Training_Profile_Reference
		{
			get
			{
				return this.training_Profile_ReferenceField;
			}
			set
			{
				this.training_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Training_Profile_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Training_Profile_for_Job_DataType Training_Profile_Data
		{
			get
			{
				return this.training_Profile_DataField;
			}
			set
			{
				this.training_Profile_DataField = value;
				this.RaisePropertyChanged("Training_Profile_Data");
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
