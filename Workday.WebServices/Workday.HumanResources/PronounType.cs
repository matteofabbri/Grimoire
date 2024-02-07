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
	public class PronounType : INotifyPropertyChanged
	{
		private PronounObjectType pronoun_ReferenceField;

		private Pronoun_DataType[] pronoun_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public PronounObjectType Pronoun_Reference
		{
			get
			{
				return this.pronoun_ReferenceField;
			}
			set
			{
				this.pronoun_ReferenceField = value;
				this.RaisePropertyChanged("Pronoun_Reference");
			}
		}

		[XmlElement("Pronoun_Data", Order = 1)]
		public Pronoun_DataType[] Pronoun_Data
		{
			get
			{
				return this.pronoun_DataField;
			}
			set
			{
				this.pronoun_DataField = value;
				this.RaisePropertyChanged("Pronoun_Data");
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
