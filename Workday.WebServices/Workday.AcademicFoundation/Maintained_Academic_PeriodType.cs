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
	public class Maintained_Academic_PeriodType : INotifyPropertyChanged
	{
		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private Maintained_Academic_Period_DataType[] maintained_Academic_Period_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_PeriodObjectType Academic_Period_Reference
		{
			get
			{
				return this.academic_Period_ReferenceField;
			}
			set
			{
				this.academic_Period_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Reference");
			}
		}

		[XmlElement("Maintained_Academic_Period_Data", Order = 1)]
		public Maintained_Academic_Period_DataType[] Maintained_Academic_Period_Data
		{
			get
			{
				return this.maintained_Academic_Period_DataField;
			}
			set
			{
				this.maintained_Academic_Period_DataField = value;
				this.RaisePropertyChanged("Maintained_Academic_Period_Data");
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
