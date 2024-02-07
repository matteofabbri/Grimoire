using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Educational_Institution_District_Request_ReferencesType : INotifyPropertyChanged
	{
		private Educational_Institution_DistrictObjectType[] educational_Institution_District_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Educational_Institution_District_Reference", Order = 0)]
		public Educational_Institution_DistrictObjectType[] Educational_Institution_District_Reference
		{
			get
			{
				return this.educational_Institution_District_ReferenceField;
			}
			set
			{
				this.educational_Institution_District_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_District_Reference");
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
