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
	public class Parameter_Initialization_WWS_DataType : INotifyPropertyChanged
	{
		private object[] itemsField;

		private ItemsChoiceType1[] itemsElementNameField;

		private Parameter_Initialization_OperatorObjectType parameter_Initialization_Operator_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlChoiceIdentifier("ItemsElementName"), XmlElement("Boolean", typeof(bool), Order = 0), XmlElement("Business_Object_Instance_Reference", typeof(InstanceObjectType), Order = 0), XmlElement("Currency", typeof(decimal), Order = 0), XmlElement("Date", typeof(DateTime), DataType = "date", Order = 0), XmlElement("DateTime", typeof(DateTime), Order = 0), XmlElement("External_Field_Reference", typeof(External_FieldObjectType), Order = 0), XmlElement("Numeric", typeof(decimal), Order = 0), XmlElement("Text", typeof(string), Order = 0)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlElement("ItemsElementName", Order = 1), XmlIgnore]
		public ItemsChoiceType1[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
				this.RaisePropertyChanged("ItemsElementName");
			}
		}

		[XmlElement(Order = 2)]
		public Parameter_Initialization_OperatorObjectType Parameter_Initialization_Operator_Reference
		{
			get
			{
				return this.parameter_Initialization_Operator_ReferenceField;
			}
			set
			{
				this.parameter_Initialization_Operator_ReferenceField = value;
				this.RaisePropertyChanged("Parameter_Initialization_Operator_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
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
