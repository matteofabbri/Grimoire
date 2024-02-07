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
	public class CompetencyType : INotifyPropertyChanged
	{
		private CompetencyObjectType competency_ReferenceField;

		private Competency_DataType[] competency_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompetencyObjectType Competency_Reference
		{
			get
			{
				return this.competency_ReferenceField;
			}
			set
			{
				this.competency_ReferenceField = value;
				this.RaisePropertyChanged("Competency_Reference");
			}
		}

		[XmlElement("Competency_Data", Order = 1)]
		public Competency_DataType[] Competency_Data
		{
			get
			{
				return this.competency_DataField;
			}
			set
			{
				this.competency_DataField = value;
				this.RaisePropertyChanged("Competency_Data");
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
