using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Political_AffiliationType : INotifyPropertyChanged
	{
		private Political_AffiliationObjectType political_Affiliation_ReferenceField;

		private Political_Affiliation_DataType political_Affiliation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Political_AffiliationObjectType Political_Affiliation_Reference
		{
			get
			{
				return this.political_Affiliation_ReferenceField;
			}
			set
			{
				this.political_Affiliation_ReferenceField = value;
				this.RaisePropertyChanged("Political_Affiliation_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Political_Affiliation_DataType Political_Affiliation_Data
		{
			get
			{
				return this.political_Affiliation_DataField;
			}
			set
			{
				this.political_Affiliation_DataField = value;
				this.RaisePropertyChanged("Political_Affiliation_Data");
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
