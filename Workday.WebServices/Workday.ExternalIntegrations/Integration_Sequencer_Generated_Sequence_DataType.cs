using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ExternalIntegrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_Sequencer_Generated_Sequence_DataType : INotifyPropertyChanged
	{
		private Integration_SequencerObjectType integration_Sequencer_ReferenceField;

		private string sequenced_ValueField;

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
