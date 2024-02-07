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
	public class Integration_Service_Generated_Sequence_DataType : INotifyPropertyChanged
	{
		private Integration_Sequence_Generator_ServiceObjectType integration_Service_ReferenceField;

		private Integration_Sequencer_Generated_Sequence_DataType[] integration_Sequencer_Generated_Sequence_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Sequence_Generator_ServiceObjectType Integration_Service_Reference
		{
			get
			{
				return this.integration_Service_ReferenceField;
			}
			set
			{
				this.integration_Service_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Service_Reference");
			}
		}

		[XmlElement("Integration_Sequencer_Generated_Sequence_Data", Order = 1)]
		public Integration_Sequencer_Generated_Sequence_DataType[] Integration_Sequencer_Generated_Sequence_Data
		{
			get
			{
				return this.integration_Sequencer_Generated_Sequence_DataField;
			}
			set
			{
				this.integration_Sequencer_Generated_Sequence_DataField = value;
				this.RaisePropertyChanged("Integration_Sequencer_Generated_Sequence_Data");
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
