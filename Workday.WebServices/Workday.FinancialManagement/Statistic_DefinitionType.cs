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
	public class Statistic_DefinitionType : INotifyPropertyChanged
	{
		private Statistic_DefinitionObjectType statistic_Definition_ReferenceField;

		private Statistic_Definition_DataType statistic_Definition_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Statistic_DefinitionObjectType Statistic_Definition_Reference
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

		[XmlElement(Order = 1)]
		public Statistic_Definition_DataType Statistic_Definition_Data
		{
			get
			{
				return this.statistic_Definition_DataField;
			}
			set
			{
				this.statistic_Definition_DataField = value;
				this.RaisePropertyChanged("Statistic_Definition_Data");
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
