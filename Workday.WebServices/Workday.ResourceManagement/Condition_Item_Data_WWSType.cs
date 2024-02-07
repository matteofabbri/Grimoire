using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Condition_Item_Data_WWSType : INotifyPropertyChanged
	{
		private string orderField;

		private And_Or_OperatorsObjectType and_Or_Operator_ReferenceField;

		private string open_ParenthesesField;

		private Relational_OperatorObjectType relational_Operator_ReferenceField;

		private Condition_Entry_OptionObjectType condition_Entry_Option_ReferenceField;

		private string close_ParenthesesField;

		private object itemField;

		private object[] itemsField;

		private ItemsChoiceType[] itemsElementNameField;

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
		public And_Or_OperatorsObjectType And_Or_Operator_Reference
		{
			get
			{
				return this.and_Or_Operator_ReferenceField;
			}
			set
			{
				this.and_Or_Operator_ReferenceField = value;
				this.RaisePropertyChanged("And_Or_Operator_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Open_Parentheses
		{
			get
			{
				return this.open_ParenthesesField;
			}
			set
			{
				this.open_ParenthesesField = value;
				this.RaisePropertyChanged("Open_Parentheses");
			}
		}

		[XmlElement(Order = 3)]
		public Relational_OperatorObjectType Relational_Operator_Reference
		{
			get
			{
				return this.relational_Operator_ReferenceField;
			}
			set
			{
				this.relational_Operator_ReferenceField = value;
				this.RaisePropertyChanged("Relational_Operator_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Condition_Entry_OptionObjectType Condition_Entry_Option_Reference
		{
			get
			{
				return this.condition_Entry_Option_ReferenceField;
			}
			set
			{
				this.condition_Entry_Option_ReferenceField = value;
				this.RaisePropertyChanged("Condition_Entry_Option_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Close_Parentheses
		{
			get
			{
				return this.close_ParenthesesField;
			}
			set
			{
				this.close_ParenthesesField = value;
				this.RaisePropertyChanged("Close_Parentheses");
			}
		}

		[XmlElement("Source_Condition_Rule_Reference", typeof(Condition_RuleObjectType), Order = 6), XmlElement("Source_External_Field_Reference", typeof(External_FieldObjectType), Order = 6)]
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

		[XmlChoiceIdentifier("ItemsElementName"), XmlElement("Filter_Boolean", typeof(bool), Order = 7), XmlElement("Filter_Date", typeof(DateTime), DataType = "date", Order = 7), XmlElement("Filter_DateTimeZone", typeof(Filter_DateTimeZone_DataType), Order = 7), XmlElement("Filter_Number", typeof(decimal), Order = 7), XmlElement("Filter_Text", typeof(string), Order = 7), XmlElement("Filter_Time", typeof(DateTime), DataType = "time", Order = 7), XmlElement("Target_External_Field_Reference", typeof(External_FieldObjectType), Order = 7), XmlElement("Target_Instance_Reference", typeof(InstanceObjectType), Order = 7)]
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

		[XmlElement("ItemsElementName", Order = 8), XmlIgnore]
		public ItemsChoiceType[] ItemsElementName
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
