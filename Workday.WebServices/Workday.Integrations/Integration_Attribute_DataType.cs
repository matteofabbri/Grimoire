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
	public class Integration_Attribute_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private string nameField;

		private string descriptionField;

		private object itemField;

		private bool multiSelectField;

		private bool multiSelectFieldSpecified;

		private Display_OptionObjectType[] display_Option_ReferenceField;

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

		[XmlElement("Multi-Select", Order = 4)]
		public bool MultiSelect
		{
			get
			{
				return this.multiSelectField;
			}
			set
			{
				this.multiSelectField = value;
				this.RaisePropertyChanged("MultiSelect");
			}
		}

		[XmlIgnore]
		public bool MultiSelectSpecified
		{
			get
			{
				return this.multiSelectFieldSpecified;
			}
			set
			{
				this.multiSelectFieldSpecified = value;
				this.RaisePropertyChanged("MultiSelectSpecified");
			}
		}

		[XmlElement("Display_Option_Reference", Order = 5)]
		public Display_OptionObjectType[] Display_Option_Reference
		{
			get
			{
				return this.display_Option_ReferenceField;
			}
			set
			{
				this.display_Option_ReferenceField = value;
				this.RaisePropertyChanged("Display_Option_Reference");
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
