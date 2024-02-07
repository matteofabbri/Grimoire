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
	public class Health_Care_RateType : INotifyPropertyChanged
	{
		private Health_Care_Banded_RateObjectType health_Care_Rate_ReferenceField;

		private Health_Care_Rate_DataType[] health_Care_Rate_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Health_Care_Banded_RateObjectType Health_Care_Rate_Reference
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

		[XmlElement("Health_Care_Rate_Data", Order = 1)]
		public Health_Care_Rate_DataType[] Health_Care_Rate_Data
		{
			get
			{
				return this.health_Care_Rate_DataField;
			}
			set
			{
				this.health_Care_Rate_DataField = value;
				this.RaisePropertyChanged("Health_Care_Rate_Data");
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
