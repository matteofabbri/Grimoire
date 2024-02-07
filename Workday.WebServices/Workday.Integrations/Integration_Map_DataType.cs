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
	public class Integration_Map_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private string nameField;

		private string descriptionField;

		private object itemField;

		private Display_OptionObjectType[] internal_Value_Display_Option_ReferenceField;

		private object item1Field;

		private Display_OptionObjectType[] external_Value_Display_Option_ReferenceField;

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

		[XmlElement("Internal_Value_Data_Type_External_Field_Reference", typeof(External_FieldObjectType), Order = 3), XmlElement("Internal_Value_Data_Type_Integration_Enumeration_Reference", typeof(Integration_Enumeration_DefinitionObjectType), Order = 3)]
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

		[XmlElement("Internal_Value_Display_Option_Reference", Order = 4)]
		public Display_OptionObjectType[] Internal_Value_Display_Option_Reference
		{
			get
			{
				return this.internal_Value_Display_Option_ReferenceField;
			}
			set
			{
				this.internal_Value_Display_Option_ReferenceField = value;
				this.RaisePropertyChanged("Internal_Value_Display_Option_Reference");
			}
		}

		[XmlElement("External_Value_Data_Type_External_Field_Reference", typeof(External_FieldObjectType), Order = 5), XmlElement("External_Value_Data_Type_Integration_Enumeration_Reference", typeof(Integration_Enumeration_DefinitionObjectType), Order = 5)]
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement("External_Value_Display_Option_Reference", Order = 6)]
		public Display_OptionObjectType[] External_Value_Display_Option_Reference
		{
			get
			{
				return this.external_Value_Display_Option_ReferenceField;
			}
			set
			{
				this.external_Value_Display_Option_ReferenceField = value;
				this.RaisePropertyChanged("External_Value_Display_Option_Reference");
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
