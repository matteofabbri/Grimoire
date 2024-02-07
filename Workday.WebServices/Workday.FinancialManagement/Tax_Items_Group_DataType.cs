using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Tax_Items_Group_DataType : INotifyPropertyChanged
	{
		private string tax_Items_Group_Data_IDField;

		private string tax_Item_Group_NameField;

		private Unique_IdentifierObjectType tax_Items_Group_Type_ReferenceField;

		private Item_DescriptorObjectType[] item_Descriptor_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Tax_Items_Group_Data_ID
		{
			get
			{
				return this.tax_Items_Group_Data_IDField;
			}
			set
			{
				this.tax_Items_Group_Data_IDField = value;
				this.RaisePropertyChanged("Tax_Items_Group_Data_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Tax_Item_Group_Name
		{
			get
			{
				return this.tax_Item_Group_NameField;
			}
			set
			{
				this.tax_Item_Group_NameField = value;
				this.RaisePropertyChanged("Tax_Item_Group_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Unique_IdentifierObjectType Tax_Items_Group_Type_Reference
		{
			get
			{
				return this.tax_Items_Group_Type_ReferenceField;
			}
			set
			{
				this.tax_Items_Group_Type_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Items_Group_Type_Reference");
			}
		}

		[XmlElement("Item_Descriptor_Reference", Order = 3)]
		public Item_DescriptorObjectType[] Item_Descriptor_Reference
		{
			get
			{
				return this.item_Descriptor_ReferenceField;
			}
			set
			{
				this.item_Descriptor_ReferenceField = value;
				this.RaisePropertyChanged("Item_Descriptor_Reference");
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
