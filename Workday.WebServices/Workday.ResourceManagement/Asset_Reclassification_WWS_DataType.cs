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
	public class Asset_Reclassification_WWS_DataType : INotifyPropertyChanged
	{
		private DateTime transaction_Effective_DateField;

		private bool transaction_Effective_DateFieldSpecified;

		private Item_DescriptorObjectType item_Descriptor_ReferenceField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private Asset_TypeObjectType asset_Type_ReferenceField;

		private Asset_ClassObjectType asset_Class_ReferenceField;

		private decimal useful_LifeField;

		private bool useful_LifeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Transaction_Effective_Date
		{
			get
			{
				return this.transaction_Effective_DateField;
			}
			set
			{
				this.transaction_Effective_DateField = value;
				this.RaisePropertyChanged("Transaction_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Transaction_Effective_DateSpecified
		{
			get
			{
				return this.transaction_Effective_DateFieldSpecified;
			}
			set
			{
				this.transaction_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Item_DescriptorObjectType Item_Descriptor_Reference
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

		[XmlElement(Order = 2)]
		public Spend_CategoryObjectType Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Asset_TypeObjectType Asset_Type_Reference
		{
			get
			{
				return this.asset_Type_ReferenceField;
			}
			set
			{
				this.asset_Type_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Asset_ClassObjectType Asset_Class_Reference
		{
			get
			{
				return this.asset_Class_ReferenceField;
			}
			set
			{
				this.asset_Class_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Class_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Useful_Life
		{
			get
			{
				return this.useful_LifeField;
			}
			set
			{
				this.useful_LifeField = value;
				this.RaisePropertyChanged("Useful_Life");
			}
		}

		[XmlIgnore]
		public bool Useful_LifeSpecified
		{
			get
			{
				return this.useful_LifeFieldSpecified;
			}
			set
			{
				this.useful_LifeFieldSpecified = value;
				this.RaisePropertyChanged("Useful_LifeSpecified");
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
