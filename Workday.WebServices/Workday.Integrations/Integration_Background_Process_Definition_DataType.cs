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
	public class Integration_Background_Process_Definition_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private Integration_Scheduled_Future_Process_DataType integration_Background_Process_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Dynamic_Description_External_Field_Reference", typeof(External_FieldObjectType), Order = 0), XmlElement("Process_Description", typeof(string), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 1)]
		public Integration_Scheduled_Future_Process_DataType Integration_Background_Process_Data
		{
			get
			{
				return this.integration_Background_Process_DataField;
			}
			set
			{
				this.integration_Background_Process_DataField = value;
				this.RaisePropertyChanged("Integration_Background_Process_Data");
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
