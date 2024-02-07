using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Sales_Item_Fair_Value_Price_List_RequestType : INotifyPropertyChanged
	{
		private Sales_Item_Fair_Value_Price_ListObjectType sales_Item_Fair_Value_Price_List_ReferenceField;

		private Sales_Item_Fair_Value_Price_List_DataType sales_Item_Fair_Value_Price_List_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Sales_Item_Fair_Value_Price_ListObjectType Sales_Item_Fair_Value_Price_List_Reference
		{
			get
			{
				return this.sales_Item_Fair_Value_Price_List_ReferenceField;
			}
			set
			{
				this.sales_Item_Fair_Value_Price_List_ReferenceField = value;
				this.RaisePropertyChanged("Sales_Item_Fair_Value_Price_List_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Sales_Item_Fair_Value_Price_List_DataType Sales_Item_Fair_Value_Price_List_Data
		{
			get
			{
				return this.sales_Item_Fair_Value_Price_List_DataField;
			}
			set
			{
				this.sales_Item_Fair_Value_Price_List_DataField = value;
				this.RaisePropertyChanged("Sales_Item_Fair_Value_Price_List_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
