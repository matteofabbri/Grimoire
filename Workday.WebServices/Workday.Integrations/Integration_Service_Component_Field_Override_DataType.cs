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
	public class Integration_Service_Component_Field_Override_DataType : INotifyPropertyChanged
	{
		private string field_NameField;

		private object itemField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Field_Name
		{
			get
			{
				return this.field_NameField;
			}
			set
			{
				this.field_NameField = value;
				this.RaisePropertyChanged("Field_Name");
			}
		}

		[XmlElement("Attachment_Data", typeof(Integration_Attachment_DataType), Order = 1), XmlElement("External_Field_Reference", typeof(External_FieldObjectType), Order = 1), XmlElement("Specify_Value_Data", typeof(Integration_Abstract_Value_DataType), Order = 1)]
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
