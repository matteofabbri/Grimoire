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
	public class Committee_DefinitionType : INotifyPropertyChanged
	{
		private CommitteeObjectType committee_Definition_ReferenceField;

		private Committee_Definition_DataType[] committee_Definition_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CommitteeObjectType Committee_Definition_Reference
		{
			get
			{
				return this.committee_Definition_ReferenceField;
			}
			set
			{
				this.committee_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Definition_Reference");
			}
		}

		[XmlElement("Committee_Definition_Data", Order = 1)]
		public Committee_Definition_DataType[] Committee_Definition_Data
		{
			get
			{
				return this.committee_Definition_DataField;
			}
			set
			{
				this.committee_Definition_DataField = value;
				this.RaisePropertyChanged("Committee_Definition_Data");
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
