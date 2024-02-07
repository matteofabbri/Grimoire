using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Web_Service_Operation_Data_WWSType : INotifyPropertyChanged
	{
		private string orderField;

		private Web_Service_OperationObjectType web_Service_Operation_ReferenceField;

		private string web_Service_Operation_Connector_WIDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 1)]
		public Web_Service_OperationObjectType Web_Service_Operation_Reference
		{
			get
			{
				return this.web_Service_Operation_ReferenceField;
			}
			set
			{
				this.web_Service_Operation_ReferenceField = value;
				this.RaisePropertyChanged("Web_Service_Operation_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Web_Service_Operation_Connector_WID
		{
			get
			{
				return this.web_Service_Operation_Connector_WIDField;
			}
			set
			{
				this.web_Service_Operation_Connector_WIDField = value;
				this.RaisePropertyChanged("Web_Service_Operation_Connector_WID");
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
