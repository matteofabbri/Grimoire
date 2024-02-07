using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Affordable_Care_Act_Worker_Hours_And_Wages_ResponseType : INotifyPropertyChanged
	{
		private Affordable_Care_Act_Worker_Hours_And_WagesObjectType affordable_Care_Act_Worker_Hours_And_Wages_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Affordable_Care_Act_Worker_Hours_And_WagesObjectType Affordable_Care_Act_Worker_Hours_And_Wages_Reference
		{
			get
			{
				return this.affordable_Care_Act_Worker_Hours_And_Wages_ReferenceField;
			}
			set
			{
				this.affordable_Care_Act_Worker_Hours_And_Wages_ReferenceField = value;
				this.RaisePropertyChanged("Affordable_Care_Act_Worker_Hours_And_Wages_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
