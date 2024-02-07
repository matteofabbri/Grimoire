using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_Sequence_Generator_Configuration_DataType : INotifyPropertyChanged
	{
		private Integration_SequencerObjectType integration_Sequencer_ReferenceField;

		private Sequence_GeneratorObjectType sequence_Generator_ReferenceField;

		private OMS_EnvironmentObjectType[] oMS_Environment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_SequencerObjectType Integration_Sequencer_Reference
		{
			get
			{
				return this.integration_Sequencer_ReferenceField;
			}
			set
			{
				this.integration_Sequencer_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Sequencer_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement("OMS_Environment_Reference", Order = 2)]
		public OMS_EnvironmentObjectType[] OMS_Environment_Reference
		{
			get
			{
				return this.oMS_Environment_ReferenceField;
			}
			set
			{
				this.oMS_Environment_ReferenceField = value;
				this.RaisePropertyChanged("OMS_Environment_Reference");
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
