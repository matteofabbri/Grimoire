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
	public class Certification_Profile_for_JobType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType certification_Profile_ReferenceField;

		private Certification_Profile_for_Job_DataType certification_Profile_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Certification_Profile_Reference
		{
			get
			{
				return this.certification_Profile_ReferenceField;
			}
			set
			{
				this.certification_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Certification_Profile_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Certification_Profile_for_Job_DataType Certification_Profile_Data
		{
			get
			{
				return this.certification_Profile_DataField;
			}
			set
			{
				this.certification_Profile_DataField = value;
				this.RaisePropertyChanged("Certification_Profile_Data");
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
