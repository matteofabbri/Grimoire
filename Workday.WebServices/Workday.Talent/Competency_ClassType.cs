using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Competency_ClassType : INotifyPropertyChanged
	{
		private Competency_ClassObjectType competency_Class_ReferenceField;

		private Competency_Class_DataType[] competency_Class_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Competency_ClassObjectType Competency_Class_Reference
		{
			get
			{
				return this.competency_Class_ReferenceField;
			}
			set
			{
				this.competency_Class_ReferenceField = value;
				this.RaisePropertyChanged("Competency_Class_Reference");
			}
		}

		[XmlElement("Competency_Class_Data", Order = 1)]
		public Competency_Class_DataType[] Competency_Class_Data
		{
			get
			{
				return this.competency_Class_DataField;
			}
			set
			{
				this.competency_Class_DataField = value;
				this.RaisePropertyChanged("Competency_Class_Data");
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
