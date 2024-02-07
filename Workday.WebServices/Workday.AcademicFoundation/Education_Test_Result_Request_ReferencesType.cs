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
	public class Education_Test_Result_Request_ReferencesType : INotifyPropertyChanged
	{
		private Education_Test_ResultObjectType[] education_Test_Result_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Education_Test_Result_Reference", Order = 0)]
		public Education_Test_ResultObjectType[] Education_Test_Result_Reference
		{
			get
			{
				return this.education_Test_Result_ReferenceField;
			}
			set
			{
				this.education_Test_Result_ReferenceField = value;
				this.RaisePropertyChanged("Education_Test_Result_Reference");
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
