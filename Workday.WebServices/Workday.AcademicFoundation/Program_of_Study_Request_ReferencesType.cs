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
	public class Program_of_Study_Request_ReferencesType : INotifyPropertyChanged
	{
		private Program_of_StudyObjectType[] program_of_Study_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Program_of_Study_Reference", Order = 0)]
		public Program_of_StudyObjectType[] Program_of_Study_Reference
		{
			get
			{
				return this.program_of_Study_ReferenceField;
			}
			set
			{
				this.program_of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Program_of_Study_Reference");
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
