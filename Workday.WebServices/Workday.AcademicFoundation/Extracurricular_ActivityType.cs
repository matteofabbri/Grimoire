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
	public class Extracurricular_ActivityType : INotifyPropertyChanged
	{
		private Extracurricular_ActivityObjectType extracurricular_Activity_ReferenceField;

		private Extracurricular_Activity_DataType extracurricular_Activity_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Extracurricular_ActivityObjectType Extracurricular_Activity_Reference
		{
			get
			{
				return this.extracurricular_Activity_ReferenceField;
			}
			set
			{
				this.extracurricular_Activity_ReferenceField = value;
				this.RaisePropertyChanged("Extracurricular_Activity_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Extracurricular_Activity_DataType Extracurricular_Activity_Data
		{
			get
			{
				return this.extracurricular_Activity_DataField;
			}
			set
			{
				this.extracurricular_Activity_DataField = value;
				this.RaisePropertyChanged("Extracurricular_Activity_Data");
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
