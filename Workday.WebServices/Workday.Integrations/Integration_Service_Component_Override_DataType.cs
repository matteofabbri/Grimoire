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
	public class Integration_Service_Component_Override_DataType : INotifyPropertyChanged
	{
		private bool itemField;

		private ItemChoiceType itemElementNameField;

		private Integration_Service_Component_Field_Override_DataType[] field_Override_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Data_Source", typeof(bool), Order = 0), XmlElement("File_Utility", typeof(bool), Order = 0), XmlElement("Transformation", typeof(bool), Order = 0), XmlElement("Transport_Protocol", typeof(bool), Order = 0)]
		public bool Item
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

		[XmlElement(Order = 1), XmlIgnore]
		public ItemChoiceType ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement("Field_Override_Data", Order = 2)]
		public Integration_Service_Component_Field_Override_DataType[] Field_Override_Data
		{
			get
			{
				return this.field_Override_DataField;
			}
			set
			{
				this.field_Override_DataField = value;
				this.RaisePropertyChanged("Field_Override_Data");
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
