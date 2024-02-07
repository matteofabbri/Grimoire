using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Practical_LearningType : INotifyPropertyChanged
	{
		private Practical_LearningObjectType practical_Learning_ReferenceField;

		private Practical_Learning_DataType[] practical_Learning_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Practical_LearningObjectType Practical_Learning_Reference
		{
			get
			{
				return this.practical_Learning_ReferenceField;
			}
			set
			{
				this.practical_Learning_ReferenceField = value;
				this.RaisePropertyChanged("Practical_Learning_Reference");
			}
		}

		[XmlElement("Practical_Learning_Data", Order = 1)]
		public Practical_Learning_DataType[] Practical_Learning_Data
		{
			get
			{
				return this.practical_Learning_DataField;
			}
			set
			{
				this.practical_Learning_DataField = value;
				this.RaisePropertyChanged("Practical_Learning_Data");
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
