using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Health_Care_Rate_Request_ReferencesType : INotifyPropertyChanged
	{
		private Health_Care_Banded_RateObjectType[] health_Care_Rate_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Health_Care_Rate_Reference", Order = 0)]
		public Health_Care_Banded_RateObjectType[] Health_Care_Rate_Reference
		{
			get
			{
				return this.health_Care_Rate_ReferenceField;
			}
			set
			{
				this.health_Care_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Health_Care_Rate_Reference");
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
