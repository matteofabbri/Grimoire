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
	public class Extracurricular_Activity_Request_CriteriaType : INotifyPropertyChanged
	{
		private Extracurricular_Activity_CategoryObjectType[] extracurricular_Activity_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Extracurricular_Activity_Category_Reference", Order = 0)]
		public Extracurricular_Activity_CategoryObjectType[] Extracurricular_Activity_Category_Reference
		{
			get
			{
				return this.extracurricular_Activity_Category_ReferenceField;
			}
			set
			{
				this.extracurricular_Activity_Category_ReferenceField = value;
				this.RaisePropertyChanged("Extracurricular_Activity_Category_Reference");
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
