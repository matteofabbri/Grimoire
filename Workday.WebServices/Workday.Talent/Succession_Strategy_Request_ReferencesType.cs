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
	public class Succession_Strategy_Request_ReferencesType : INotifyPropertyChanged
	{
		private Succession_StrategyObjectType[] succession_Strategy_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Succession_Strategy_Reference", Order = 0)]
		public Succession_StrategyObjectType[] Succession_Strategy_Reference
		{
			get
			{
				return this.succession_Strategy_ReferenceField;
			}
			set
			{
				this.succession_Strategy_ReferenceField = value;
				this.RaisePropertyChanged("Succession_Strategy_Reference");
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
