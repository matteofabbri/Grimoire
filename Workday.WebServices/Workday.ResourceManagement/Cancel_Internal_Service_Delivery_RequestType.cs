using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Cancel_Internal_Service_Delivery_RequestType : INotifyPropertyChanged
	{
		private Internal_Service_DeliveryObjectType internal_Service_Delivery_ReferenceField;

		private Cancel_Internal_Service_Delivery_DataType internal_Service_Delivery_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Internal_Service_DeliveryObjectType Internal_Service_Delivery_Reference
		{
			get
			{
				return this.internal_Service_Delivery_ReferenceField;
			}
			set
			{
				this.internal_Service_Delivery_ReferenceField = value;
				this.RaisePropertyChanged("Internal_Service_Delivery_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Cancel_Internal_Service_Delivery_DataType Internal_Service_Delivery_Data
		{
			get
			{
				return this.internal_Service_Delivery_DataField;
			}
			set
			{
				this.internal_Service_Delivery_DataField = value;
				this.RaisePropertyChanged("Internal_Service_Delivery_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
