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
	public class Succession_StrategyType : INotifyPropertyChanged
	{
		private Succession_StrategyObjectType succession_Strategy_ReferenceField;

		private Succession_Strategy_DataType[] succession_Strategy_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Succession_StrategyObjectType Succession_Strategy_Reference
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

		[XmlElement("Succession_Strategy_Data", Order = 1)]
		public Succession_Strategy_DataType[] Succession_Strategy_Data
		{
			get
			{
				return this.succession_Strategy_DataField;
			}
			set
			{
				this.succession_Strategy_DataField = value;
				this.RaisePropertyChanged("Succession_Strategy_Data");
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
