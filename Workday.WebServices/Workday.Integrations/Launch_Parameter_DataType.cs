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
	public class Launch_Parameter_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private string nameField;

		private string descriptionField;

		private object itemField;

		private Integration_Launch_OptionObjectType[] launch_Option_ReferenceField;

		private Launch_Parameter_Default_DataType launch_Parameter_Default_DataField;

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
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement("Data_Type_Enumeration_Definition_Reference", typeof(Integration_Enumeration_DefinitionObjectType), Order = 3), XmlElement("Data_Type_External_Field_Reference", typeof(External_FieldObjectType), Order = 3)]
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

		[XmlElement("Launch_Option_Reference", Order = 4)]
		public Integration_Launch_OptionObjectType[] Launch_Option_Reference
		{
			get
			{
				return this.launch_Option_ReferenceField;
			}
			set
			{
				this.launch_Option_ReferenceField = value;
				this.RaisePropertyChanged("Launch_Option_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Launch_Parameter_Default_DataType Launch_Parameter_Default_Data
		{
			get
			{
				return this.launch_Parameter_Default_DataField;
			}
			set
			{
				this.launch_Parameter_Default_DataField = value;
				this.RaisePropertyChanged("Launch_Parameter_Default_Data");
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
