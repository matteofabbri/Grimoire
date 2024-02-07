using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Statistic_Definition_Request_ReferencesType : INotifyPropertyChanged
	{
		private Statistic_DefinitionObjectType[] statistic_Definition_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Statistic_Definition_Reference", Order = 0)]
		public Statistic_DefinitionObjectType[] Statistic_Definition_Reference
		{
			get
			{
				return this.statistic_Definition_ReferenceField;
			}
			set
			{
				this.statistic_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Statistic_Definition_Reference");
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
