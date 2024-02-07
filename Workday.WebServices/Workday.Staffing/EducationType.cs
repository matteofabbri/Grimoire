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
	public class EducationType : INotifyPropertyChanged
	{
		private EducationObjectType education_ReferenceField;

		private Education_Achievement_DataType[] education_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EducationObjectType Education_Reference
		{
			get
			{
				return this.education_ReferenceField;
			}
			set
			{
				this.education_ReferenceField = value;
				this.RaisePropertyChanged("Education_Reference");
			}
		}

		[XmlElement("Education_Data", Order = 1)]
		public Education_Achievement_DataType[] Education_Data
		{
			get
			{
				return this.education_DataField;
			}
			set
			{
				this.education_DataField = value;
				this.RaisePropertyChanged("Education_Data");
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
