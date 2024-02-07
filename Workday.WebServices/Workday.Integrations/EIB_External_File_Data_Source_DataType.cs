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
	public class EIB_External_File_Data_Source_DataType : INotifyPropertyChanged
	{
		private EIB_Integration_Transport_Protocol_Data_WWSType integration_Transport_Protocol_DataField;

		private object itemField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EIB_Integration_Transport_Protocol_Data_WWSType Integration_Transport_Protocol_Data
		{
			get
			{
				return this.integration_Transport_Protocol_DataField;
			}
			set
			{
				this.integration_Transport_Protocol_DataField = value;
				this.RaisePropertyChanged("Integration_Transport_Protocol_Data");
			}
		}

		[XmlElement("Custom_Object_Reference", typeof(Custom_ObjectObjectType), Order = 1), XmlElement("Web_Service_Operation_Reference", typeof(Web_Service_OperationObjectType), Order = 1)]
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
