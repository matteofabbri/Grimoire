using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Sales_Item_Fair_Value_Price_List_Rule_Line_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private decimal item1Field;

		private Item1ChoiceType item1ElementNameField;

		private Sales_Item_Fair_Value_Price_TypeObjectType price_Type_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] worktag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Sales_Item_Group_Reference", typeof(Sales_Item_GroupObjectType), Order = 0), XmlElement("Sales_Item_Reference", typeof(Sales_ItemObjectType), Order = 0)]
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

		[XmlChoiceIdentifier("Item1ElementName"), XmlElement("Amount", typeof(decimal), Order = 1), XmlElement("Percent", typeof(decimal), Order = 1)]
		public decimal Item1
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

		[XmlElement(Order = 2), XmlIgnore]
		public Item1ChoiceType Item1ElementName
		{
			get
			{
				return this.item1ElementNameField;
			}
			set
			{
				this.item1ElementNameField = value;
				this.RaisePropertyChanged("Item1ElementName");
			}
		}

		[XmlElement(Order = 3)]
		public Sales_Item_Fair_Value_Price_TypeObjectType Price_Type_Reference
		{
			get
			{
				return this.price_Type_ReferenceField;
			}
			set
			{
				this.price_Type_ReferenceField = value;
				this.RaisePropertyChanged("Price_Type_Reference");
			}
		}

		[XmlElement("Worktag_Reference", Order = 4)]
		public Audited_Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
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
