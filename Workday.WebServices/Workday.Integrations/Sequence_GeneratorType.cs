using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Workday.Integrations;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Sequence_GeneratorType : INotifyPropertyChanged
	{
		private Sequence_GeneratorObjectType sequence_Generator_ReferenceField;

		private Abstract_Sequence_Generator_DataType sequence_Generator_DataField;

		private string sequenced_ValueField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Sequence_GeneratorObjectType Sequence_Generator_Reference
		{
			get
			{
				return this.sequence_Generator_ReferenceField;
			}
			set
			{
				this.sequence_Generator_ReferenceField = value;
				this.RaisePropertyChanged("Sequence_Generator_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Abstract_Sequence_Generator_DataType Sequence_Generator_Data
		{
			get
			{
				return this.sequence_Generator_DataField;
			}
			set
			{
				this.sequence_Generator_DataField = value;
				this.RaisePropertyChanged("Sequence_Generator_Data");
			}
		}

		[XmlElement(Order = 2)]
		public string Sequenced_Value
		{
			get
			{
				return this.sequenced_ValueField;
			}
			set
			{
				this.sequenced_ValueField = value;
				this.RaisePropertyChanged("Sequenced_Value");
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
