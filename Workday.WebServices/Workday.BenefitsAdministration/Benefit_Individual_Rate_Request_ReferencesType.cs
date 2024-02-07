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
	public class Benefit_Individual_Rate_Request_ReferencesType : INotifyPropertyChanged
	{
		private Benefit_Individual_RateObjectType[] benefit_Individual_Rate_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Benefit_Individual_Rate_Reference", Order = 0)]
		public Benefit_Individual_RateObjectType[] Benefit_Individual_Rate_Reference
		{
			get
			{
				return this.benefit_Individual_Rate_ReferenceField;
			}
			set
			{
				this.benefit_Individual_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Individual_Rate_Reference");
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
