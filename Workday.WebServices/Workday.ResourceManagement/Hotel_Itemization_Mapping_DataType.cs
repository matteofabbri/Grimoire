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
	public class Hotel_Itemization_Mapping_DataType : INotifyPropertyChanged
	{
		private Hotel_Charge_TypeObjectType hotel_Charge_Type_ReferenceField;

		private Expense_ItemObjectType expense_Item_ReferenceField;

		private bool hotel_Mapping_Field_RequiredField;

		private bool hotel_Mapping_Field_RequiredFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Hotel_Charge_TypeObjectType Hotel_Charge_Type_Reference
		{
			get
			{
				return this.hotel_Charge_Type_ReferenceField;
			}
			set
			{
				this.hotel_Charge_Type_ReferenceField = value;
				this.RaisePropertyChanged("Hotel_Charge_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Expense_ItemObjectType Expense_Item_Reference
		{
			get
			{
				return this.expense_Item_ReferenceField;
			}
			set
			{
				this.expense_Item_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Item_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Hotel_Mapping_Field_Required
		{
			get
			{
				return this.hotel_Mapping_Field_RequiredField;
			}
			set
			{
				this.hotel_Mapping_Field_RequiredField = value;
				this.RaisePropertyChanged("Hotel_Mapping_Field_Required");
			}
		}

		[XmlIgnore]
		public bool Hotel_Mapping_Field_RequiredSpecified
		{
			get
			{
				return this.hotel_Mapping_Field_RequiredFieldSpecified;
			}
			set
			{
				this.hotel_Mapping_Field_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Hotel_Mapping_Field_RequiredSpecified");
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
